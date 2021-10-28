using System;
using System.IO;
using System.Collections.Generic;
namespace SHex
{
	
	public class HexAccess:IFileAccess
	{
		public List<MemBlock> Memblks{ get; set;}
		public int BytesEachLine{ get; set; }
		public uint CsIp{ get; set; }
		public uint EIP{ get; set; }
		public HexAccess (int bytesEachLine)
		{
			this.Memblks = new List<MemBlock> ();
			this.BytesEachLine = bytesEachLine;
		}
		public HexAccess():this(32){
		}
		public bool parse(string[] lines){
			HexRecord hr = new HexRecord ();
			foreach (string lin in lines) {
				string line = lin.Trim ();
				if (line.Length < 1) {
					continue;
				}
				if (hr.parse (line)) {
					switch (hr.RecordType) {
					case HexRecord.RecordTypeE.Data:
						{
							MemBlock mb = Memblks [Memblks.Count - 1];
							if (0 == mb.DataSize) { // new empty block
								mb.StartAddr &= 0xFFFF0000;
								mb.StartAddr += hr.Address;
							} else if ((0xFFFF & mb.NextAddress) != hr.Address) { // address is interrupted, create new block
								this.Memblks.Add (new MemBlock());
								MemBlock oldmb = mb;
								mb = Memblks [Memblks.Count - 1];
								mb.AddrSize = oldmb.AddrSize;
								mb.StartAddr = oldmb.StartAddr;
								mb.StartAddr &= 0xFFFF0000;
								mb.StartAddr += hr.Address;
							} else { // continual address, just merge the data
							}
							mb.AppendData (hr.Data);
						}
						break;
					case HexRecord.RecordTypeE.EoF:
						{
							// End of file
						}
						break;
					case HexRecord.RecordTypeE.ExtSegAddr:
						{
							MemBlock mb = new MemBlock ();
							if (BitConverter.IsLittleEndian) {
								Array.Reverse (hr.Data);
							}
							ushort usba = BitConverter.ToUInt16 (hr.Data, 0);
							uint sba = (uint)usba;
							sba <<= 4;
							mb.AddrSize = 20;
							mb.StartAddr = sba;
							this.Memblks.Add (mb);
						}
						break;
					case HexRecord.RecordTypeE.StrtSegAddr:
						{
							if (BitConverter.IsLittleEndian) {
								Array.Reverse (hr.Data);
							}
							this.CsIp = BitConverter.ToUInt32(hr.Data, 0);
						}
						break;
					case HexRecord.RecordTypeE.ExtLineAddr: // extend address, create a new MemBlock
						{
							MemBlock mb = new MemBlock ();
							if (BitConverter.IsLittleEndian) {
								Array.Reverse (hr.Data);
							}
							ushort ulba = BitConverter.ToUInt16 (hr.Data, 0);
							uint lba = (uint)ulba;
							lba <<= 16;
							mb.AddrSize = 32;
							mb.StartAddr = lba;
							this.Memblks.Add (mb);
						}
						break;
					case HexRecord.RecordTypeE.StrtLineAddr:
						{
							if (BitConverter.IsLittleEndian) {
								Array.Reverse (hr.Data);
							}
							this.EIP = BitConverter.ToUInt32(hr.Data, 0);
						}
						break;
					default:
						break;
					}
				}
			}
			MemBlock.MergeMBs (this.Memblks);
			return true;
		}
		public string[] generate(){
			List<string> retu = new List<string> ();
			HexRecord hr = null;
			foreach(MemBlock mb in Memblks){
				int subMbs = mb.DataSize / 0x10000;
				if (0 < mb.DataSize % 0x10000) {
					subMbs++;
				}
				ushort ulba = (ushort)(mb.StartAddr >> 16);
				for (int i = 0; i < subMbs; i++) {
					// output start address
					hr = new HexRecord(HexRecord.RecordTypeE.ExtLineAddr);
					hr.Data[0]=BitConverter.GetBytes (ulba + i) [1];
					hr.Data[1]=BitConverter.GetBytes (ulba + i) [0];
					retu.Add (hr.generate());
					// output data records
					uint startAd = ((uint)(ulba+i)<<16);
					if (!mb.IsAddressInMemBlk (startAd)) {
						startAd = (uint)mb.StartAddr;
					}
					uint lastAd = ((uint)(ulba+i)<<16) + 0xFFFF;
					if (!mb.IsAddressInMemBlk (lastAd)) {
						lastAd = (uint)mb.LastAddress;
					}
					int subMbLen = (int)(lastAd - startAd + 1);
					int lines = subMbLen/BytesEachLine;
					hr = new HexRecord (HexRecord.RecordTypeE.Data);
					hr.Data = new byte[BytesEachLine];
					for (int j = 0; j < lines; j++) {
						int offset = j * BytesEachLine;
						ushort llba = (ushort)((startAd + offset) & 0xFFFF);
						hr.Address = llba;
						Array.Copy (mb.DataAsArray, (startAd + offset), hr.Data, 0, BytesEachLine);
						retu.Add (hr.generate());
					}
					if (0 < subMbLen%BytesEachLine) {
						int offset = BytesEachLine * lines;
						int restBytes = subMbLen-offset;
						hr.Data = new byte[restBytes];
						hr.Address = (ushort)((startAd + offset) & 0xFFFF);
						Array.Copy (mb.DataAsArray, (startAd + offset), hr.Data, 0, restBytes);
						retu.Add (hr.generate());
					}
				}
			}
			hr = new HexRecord (HexRecord.RecordTypeE.EoF);
			retu.Add (hr.generate());
			return retu.ToArray ();
		}
		public string[] generate(int lineSize){
			this.BytesEachLine = lineSize;
			return generate ();
		}
		public bool parseFile (string filePath){
			return(parse(File.ReadAllLines (filePath)));
		}
		public bool generateFile (string destFilePath){
			File.WriteAllLines (destFilePath, generate ());
			return true;
		}
	}
}

