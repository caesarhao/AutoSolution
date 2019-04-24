using System;
using System.Collections.Generic;
namespace SHex
{
	
	public class HexAccess:IFileAccess
	{
		public List<MemBlock> Memblks{ get; set;}
		public int BytesEachLine{ get; set; }
		public uint CsIp{ get; set; }
		public uint EIP{ get; set; }
		public HexAccess ()
		{
			Memblks = new List<MemBlock> ();
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
							if ((0 == mb.DataSize) && ((0xFFFF & (mb.StartAddr)) != hr.Address)) {
								mb.StartAddr += hr.Address;
							} else if (((0xFFFF & (mb.StartAddr)) + mb.NextAddress()) != hr.Address) { // check the address
							} else {
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
							this.CsIp = BitConverter.ToUInt32(hr.Data, 0);
						}
						break;
					case HexRecord.RecordTypeE.ExtLineAddr:
						{
							MemBlock mb = new MemBlock ();
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
							this.EIP = BitConverter.ToUInt32(hr.Data, 0);
						}
						break;
					default:
						break;
					}
				}
			}
			return true;
		}
		public string[] generate(){
			List<string> retu = new List<string> ();
			HexRecord hr = new HexRecord();
			foreach(MemBlock mb in Memblks){
				hr.RecordType = HexRecord.RecordTypeE.StrtLineAddr;
			}
			return retu.ToArray ();
		}
		public string[] generate(int lineSize){
			this.BytesEachLine = lineSize;
			return generate ();
		}
	}
}

