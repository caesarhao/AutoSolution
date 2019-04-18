using System;

namespace SHex
{
	public class SRecAccess:IFileAccess
	{
		public SRecAccess ()
		{
		}
		public bool parse(string[] lines){
			return true;
		}
		public string[] generate(){
			return null;
		}
	}
}

