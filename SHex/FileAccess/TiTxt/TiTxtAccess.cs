/**
 * http://srecord.sourceforge.net/man/man5/srec_ti_txt.html
 * 
 * 
*/
using System;
using System.Collections.Generic;
namespace SHex
{
	public class TiTxtAccess
	{
		private List<MemBlock> mbs;
		public TiTxtAccess ()
		{
			mbs = new List<MemBlock> ();
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
					} else if (TiTxtRecord.RecordTypeE.EOF == tr.RecordType) {
					} else if (TiTxtRecord.RecordTypeE.Data == tr.RecordType) {
					} else {
					}
				}
			}
			return true;
		}
	}
}

