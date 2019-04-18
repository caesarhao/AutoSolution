using System;

namespace SHex
{
	
	public class HexAccess:IFileAccess
	{
		 
		public HexAccess ()
		{
			
		}
		public HexAccess(string fileName)
		{
			
		}
		public HexAccess(string[] fileLines)
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

