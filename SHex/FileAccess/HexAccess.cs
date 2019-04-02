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
		private byte byteCount; // 1 byte
		private ushort address; // 2 bytes
		private byte recordType; // 1 byte
		private byte[] data; //
		private byte crc; // 1 byte
		public Record()
		{
			
		}
		public static int hex2dec(byte c)
		{
			if (c >= 'a' && c <= 'f') {
				return (c - 'a' + 10);
			} else if (c >= 'A' && c <= 'F') {
				return (c - 'A' + 10);
			} else if (c >= '0' && c <= '9') {
				return (c - '0');
			} else {
				return -1;
			}
		}
		public static byte getFrstByte(string line){
			byte retu = 0;
			if (line.Length > 1) 
			{
				retu = hex2dec (line [0]) << 4;
				retu += hex2dec (line [1]);
			}
			return retu;
		}
		public static byte getByte(char c1, char c2){
			byte retu = 0;
			retu = hex2dec (c1) << 4;
			retu += hex2dec (c2);
			return retu;
		}
		public bool parse(string line)
		{
			if (':' != line [0]) {
			} else {
				line = line.Substring (1);
				if ((line.Length) % 2 != 0) {
				} else {
					
				}
			}
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

