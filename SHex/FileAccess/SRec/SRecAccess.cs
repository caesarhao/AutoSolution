using System;
using System.IO;
using System.Collections.Generic;
namespace SHex
{
	public class SRecAccess:IFileAccess
	{
		public byte[] HeadRec{ get; set; }
		public enum SFileTypeE{
			S19, // 16-bit address
			S28, // 24-bit address
			S37 // 32-bit address
		};
		public SFileTypeE SFileType{ get; set; }
		public uint DataRecordNum{ get; set;}
		public List<MemBlock> Memblks{ get; set;}
		public int BytesEachLine{ get; set; }
		public SRecAccess ()
		{
			Memblks = new List<MemBlock> ();
			this.SFileType = SFileTypeE.S37;
			this.BytesEachLine = 32;
			this.DataRecordNum = 0;
		}
		public bool parse(string[] lines){
			SRecord sr = new SRecord ();
			foreach (string lin in lines) {
				string line = lin.Trim ();
				if (line.Length < 1) {
					continue;
				}
				if (sr.parse (line)) {
					switch (sr.RecordType) {
					case SRecord.RecordTypeE.S0:
						{
							this.HeadRec = new byte[sr.Data.Length];
							sr.Data.CopyTo (this.HeadRec, 0);
						}
						break;
					case SRecord.RecordTypeE.S1:
						{
							this.SFileType = SFileTypeE.S19;
							this.DataRecordNum++;
							if (0 == Memblks.Count) {
								MemBlock mb = new MemBlock ();
								mb.AddrSize = 16;
								mb.StartAddr = sr.Address;
								mb.AppendData (sr.Data);
								Memblks.Add (mb);
							} else {
								MemBlock mb = Memblks [Memblks.Count - 1];
								if (mb.NextAddress == sr.Address) {
									mb.AppendData (sr.Data);
								} else { // create a new MemBlock
									MemBlock mbn = new MemBlock ();
									mbn.AddrSize = 16;
									mbn.StartAddr = sr.Address;
									mbn.AppendData (sr.Data);
									Memblks.Add (mbn);
								}
							}
						}
						break;
					case SRecord.RecordTypeE.S2:
						{
							this.SFileType = SFileTypeE.S28;
							this.DataRecordNum++;
							if (0 == Memblks.Count) {
								MemBlock mb = new MemBlock ();
								mb.AddrSize = 24;
								mb.StartAddr = sr.Address;
								mb.AppendData (sr.Data);
								Memblks.Add (mb);
							} else {
								MemBlock mb = Memblks [Memblks.Count - 1];
								if (mb.NextAddress == sr.Address) {
									mb.AppendData (sr.Data);
								} else { // create a new MemBlock
									MemBlock mbn = new MemBlock ();
									mbn.AddrSize = 24;
									mbn.StartAddr = sr.Address;
									mbn.AppendData (sr.Data);
									Memblks.Add (mbn);
								}
							}
						}
						break;
					case SRecord.RecordTypeE.S3:
						{
							this.SFileType = SFileTypeE.S37;
							this.DataRecordNum++;
							if (0 == Memblks.Count) {
								MemBlock mb = new MemBlock ();
								mb.AddrSize = 32;
								mb.StartAddr = sr.Address;
								mb.AppendData (sr.Data);
								Memblks.Add (mb);
							} else {
								MemBlock mb = Memblks [Memblks.Count - 1];
								if (mb.NextAddress == sr.Address) {
									mb.AppendData (sr.Data);
								} else { // create a new MemBlock
									MemBlock mbn = new MemBlock ();
									mbn.AddrSize = 32;
									mbn.StartAddr = sr.Address;
									mbn.AppendData (sr.Data);
									Memblks.Add (mbn);
								}
							}
						}
						break;
					case SRecord.RecordTypeE.S4:
						{
							// not used now
						}
						break;
					case SRecord.RecordTypeE.S5:
						{
							// check record count
							ushort recCount = BitConverter.ToUInt16(sr.Data, 0);
							if (recCount != this.DataRecordNum) {
								// error happens
							}
						}
						break;
					case SRecord.RecordTypeE.S6:
						{
							// check record count
							uint recCount = BitConverter.ToUInt16(sr.Data, 1);
							recCount += (uint)(sr.Data [0] << 16);
							if (recCount != this.DataRecordNum) {
								// error happens
							}
						}
						break;
					case SRecord.RecordTypeE.S7:
						{
							// end of S37, nothing to do
						}
						break;
					case SRecord.RecordTypeE.S8:
						{
							// end of S28, nothing to do
						}
						break;
					case SRecord.RecordTypeE.S9:
						{
							// end of S19, nothing to do
						}
						break;
					default:
						{
						}
						break;
					}
				}
			}
			MemBlock.MergeMBs (this.Memblks);
			return true;
		}
		public string[] generate(){
			List<string> retu = new List<string> ();
			SRecord sr = new SRecord();
			int totalLines = 0;
			foreach(MemBlock mb in Memblks){
				switch (SFileType) {
				case SFileTypeE.S19:
					{
						sr.RecordType = SRecord.RecordTypeE.S1;
					}
					break;
				case SFileTypeE.S28:
					{
						sr.RecordType = SRecord.RecordTypeE.S2;
					}
					break;
				case SFileTypeE.S37:
					{
						sr.RecordType = SRecord.RecordTypeE.S3;
					}
					break;
				default:
					break;
				}
				sr.Data = new byte[this.BytesEachLine];
				int lines = mb.DataSize / this.BytesEachLine;
				for (int i = 0; i < lines; i++) {
					int offset = i * this.BytesEachLine;
					sr.Address = (uint)((int)mb.StartAddr+offset);
					Array.Copy (mb.DataAsArray, offset, sr.Data, 0, this.BytesEachLine);
					retu.Add (sr.generate ());
				}
				if (0 < mb.DataSize %BytesEachLine) {
					int offset = BytesEachLine * lines;
					int restBytes = mb.DataSize-offset;
					sr.Data = new byte[restBytes];
					sr.Address = (uint)((int)mb.StartAddr + offset);
					Array.Copy (mb.DataAsArray, offset, sr.Data, 0, restBytes);
					retu.Add (sr.generate());
					lines++;
				}
				totalLines += lines;
			}
			if (totalLines <= 0xFFFF) {
				sr.RecordType = SRecord.RecordTypeE.S5;
			} else {
				sr.RecordType = SRecord.RecordTypeE.S6;
			}
			retu.Add (sr.generate());
			switch (SFileType) {
			case SFileTypeE.S19:
				{
					sr.RecordType = SRecord.RecordTypeE.S9;
				}
				break;
			case SFileTypeE.S28:
				{
					sr.RecordType = SRecord.RecordTypeE.S8;
				}
				break;
			case SFileTypeE.S37:
				{
					sr.RecordType = SRecord.RecordTypeE.S7;
				}
				break;
			default:
				break;
			}
			retu.Add (sr.generate());
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

