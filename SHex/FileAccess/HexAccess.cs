using System;

namespace SHex
{
	public class Record
	{
		public enum RecordType
		{
			Data = 0x00,
			EoF = 0x01,
			ExtSegAddr = 0x02,
			StrtSegAddr = 0x03,
			ExtLineAddr = 0x04,
			StrtLineAddr = 0x05
		}
		private byte startCode; // : 1 byte
		private byte[] byteCount; // 2 bytes
		private byte[] address; // 4 bytes
		private byte[] recordType; // 2 bytes
		private byte[] data; //
		private byte[] crc; // 2 bytes
		public Record()
		{
			byteCount = new byte[2];
			address = new byte[4];
			recordType = new byte[2];
			crc = new byte[2];
		}
		public bool parse(string line)
		{
			
		}
	}
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

	}
}

