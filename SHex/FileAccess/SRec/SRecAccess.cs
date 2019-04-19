using System;
using System.Collections.Generic;
namespace SHex
{
	public class SRecAccess:IFileAccess
	{
		public List<MemBlock> Memblks{ get; set;}
		public SRecAccess ()
		{
			Memblks = new List<MemBlock> ();
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
						break;
					case SRecord.RecordTypeE.S1:
						break;
					case SRecord.RecordTypeE.S2:
						break;
					case SRecord.RecordTypeE.S3:
						break;
					case SRecord.RecordTypeE.S4:
						break;
					case SRecord.RecordTypeE.S5:
						break;
					case SRecord.RecordTypeE.S6:
						break;
					case SRecord.RecordTypeE.S7:
						break;
					case SRecord.RecordTypeE.S8:
						break;
					case SRecord.RecordTypeE.S9:
						break;
					default:
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

