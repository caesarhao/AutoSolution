using System;
using System.Collections.Generic;
namespace SHex
{
	
	public class HexAccess:IFileAccess
	{
		public List<MemBlock> Memblks{ get; set;} 
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
						break;
					case HexRecord.RecordTypeE.EoF:
						break;
					case HexRecord.RecordTypeE.ExtSegAddr:
						break;
					case HexRecord.RecordTypeE.StrtSegAddr:
						break;
					case HexRecord.RecordTypeE.ExtLineAddr:
						break;
					case HexRecord.RecordTypeE.StrtLineAddr:
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

