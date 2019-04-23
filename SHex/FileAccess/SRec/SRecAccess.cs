using System;
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

		public SRecAccess ()
		{
			Memblks = new List<MemBlock> ();
			this.SFileType = SFileTypeE.S19;
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
								if (mb.NextAddress() == sr.Address) {
									mb.AppendData (sr.Data);
								} else { // create a new MemBlock
									mb.ResizeData();
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
								if (mb.NextAddress() == sr.Address) {
									mb.AppendData (sr.Data);
								} else { // create a new MemBlock
									mb.ResizeData();
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
								if (mb.NextAddress() == sr.Address) {
									mb.AppendData (sr.Data);
								} else { // create a new MemBlock
									mb.ResizeData();
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
			return true;
		}
		public string[] generate(){
			return null;
		}
	}
}

