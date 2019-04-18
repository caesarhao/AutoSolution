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
		public TiTxtAccess ()
		{
			Memblks = new List<MemBlock> ();
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
						mb.AddrSize = 2;
						Memblks.Add (mb);
					} else if (TiTxtRecord.RecordTypeE.EOF == tr.RecordType) {
						// end of file
					} else if (TiTxtRecord.RecordTypeE.Data == tr.RecordType) {
						MemBlock mb = Memblks [Memblks.Count - 1];
						mb.AppendData (tr.Data);
					} else {
					}
				}
			}
			foreach (MemBlock mb in Memblks) {
				mb.ResizeData ();
			}
			return true;
		}
		public string[] generate(){
			return null;
		}
	}
}

