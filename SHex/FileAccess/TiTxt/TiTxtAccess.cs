/**
 * http://srecord.sourceforge.net/man/man5/srec_ti_txt.html
 * 
 * 
*/
using System;
using System.Collections.Generic;
namespace SHex
{
	public class TiTxtAccess:IFileAccess
	{
		public List<MemBlock> Memblks{ get; set;}
		public int BytesEachLine{ get; set; }
		public TiTxtAccess ()
		{
			Memblks = new List<MemBlock> ();
			this.BytesEachLine = 0;
		}
		public bool parse(string[] lines){
			
			TiTxtRecord tr = new TiTxtRecord ();
			foreach (string lin in lines) {
				string line = lin.Trim ();
				if (line.Length < 1) {
					continue;
				}
				if (tr.parse (line)) {
					if (TiTxtRecord.RecordTypeE.SecStrtAddr == tr.RecordType) {
						MemBlock mb = new MemBlock ();
						mb.StartAddr = tr.Address;
						mb.AddrSize = 16;
						Memblks.Add (mb);
					} else if (TiTxtRecord.RecordTypeE.EOF == tr.RecordType) {
						// end of file
					} else if (TiTxtRecord.RecordTypeE.Data == tr.RecordType) {
						MemBlock mb = Memblks [Memblks.Count - 1];
						if (0 == this.BytesEachLine) {
							this.BytesEachLine = tr.Data.Length;
						}
						mb.AppendData (tr.Data);
					} else {
					}
				}
			}
			MemBlock.MergeMBs (this.Memblks);
			return true;
		}
		public string[] generate(){
			List<string> retu = new List<string> ();
			TiTxtRecord tr = new TiTxtRecord ();
			foreach(MemBlock mb in Memblks){
				tr.RecordType = TiTxtRecord.RecordTypeE.SecStrtAddr;
				tr.Address = (ushort)(mb.StartAddr);
				retu.Add (tr.generate ());
				tr.RecordType = TiTxtRecord.RecordTypeE.Data;
				tr.Data = new byte[this.BytesEachLine];
				int lines = mb.DataSize / this.BytesEachLine;
				for (int i = 0; i < lines; i++) {
					Array.Copy (mb.DataAsArray, i * (this.BytesEachLine), tr.Data, 0, (this.BytesEachLine));
					retu.Add (tr.generate ());
				}
				int len = (mb.DataSize) % (this.BytesEachLine);
				if (len > 0) {
					tr.Data = new byte[len];
					Array.Copy (mb.DataAsArray, lines * (this.BytesEachLine), tr.Data, 0, len);
					retu.Add (tr.generate ());
				}
			}
			tr.RecordType = TiTxtRecord.RecordTypeE.EOF;
			retu.Add (tr.generate ());
			return retu.ToArray();
		}
		public string[] generate(int lineSize){
			this.BytesEachLine = lineSize;
			return generate ();
		}
	}
}

