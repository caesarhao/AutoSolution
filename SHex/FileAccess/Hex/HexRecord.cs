using System;
using System.Text.RegularExpressions;
namespace SHex
{
	public class HexRecord
	{
		public enum RecordType : byte
		{
			Data = 0x00,
			EoF = 0x01,
			ExtSegAddr = 0x02,
			StrtSegAddr = 0x03,
			ExtLineAddr = 0x04,
			StrtLineAddr = 0x05
		};
		public enum ErrorNum : byte
		{
			NoErr = 0x00,

		};
		private ErrorNum errNo;
		private byte startCode; // : 1 byte
		private byte byteCount; // 1 byte
		private ushort address; // 2 bytes
		private RecordType recordType; // 1 byte
		private byte[] data; //
		private byte crc; // 1 byte
		public HexRecord()
		{
			this.errNo = ErrorNum.NoErr;
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
		public static int hex2dec(char c)
		{
			return(hex2dec(Convert.ToByte(c)));
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
		public static string dec2hex(byte h)
		{
			return String.Format ("{0,2:X2}", h);
		}
		public static byte getByte(char c1, char c2){
			byte retu = 0;
			retu = hex2dec (c1) << 4;
			retu += hex2dec (c2);
			return retu;
		}
		public bool parse(string line)
		{
			Regex rgx = new Regex (@"^:(?<byteCount>[A-Fa-f0-9]{2})(?<address>[A-Fa-f0-9]{4})(?<type>[A-Fa-f0-9]{2})(?<data>[A-Fa-f0-9]*)(?<crc>[A-Fa-f0-9]{2})$");
			Match match = rgx.Match(line);
			byte byteCount = byte.Parse(match.Groups["byteCount"].Value);
			ushort address = ushort.Parse(match.Groups["address"].Value);
			byte type = byte.Parse(match.Groups["type"].Value);
			byte crc = byte.Parse(match.Groups["crc"].Value);
			return (this.errNo == ErrorNum.NoErr);
		}
	}
}

