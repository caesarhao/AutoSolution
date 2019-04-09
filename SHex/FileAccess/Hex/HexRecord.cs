using System;
using System.Text.RegularExpressions;
using System.Globalization;
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
			WrongLength = 0x01,
			WrongCRC = 0x02

		};
		private ErrorNum errNo;
		private char startCode; // : 1 byte
		private byte byteCount; // 1 byte
		private ushort address; // 2 bytes
		private RecordType recordType; // 1 byte
		private byte[] data; //
		private byte crc; // 1 byte

		private string sdata; // data read from input
		private byte crcCal; // calculated crc
		public HexRecord()
		{
			this.errNo = ErrorNum.NoErr;
			this.startCode = ':';
		}
		public static string dec2hex(byte h)
		{
			return String.Format ("{0,2:X2}", h);
		}
		public static byte[] str2bytesAr(string data)
		{
			int len = data.Length;
			byte[] retu = new byte[len/2];
			for (int i = 0; i < (len / 2); i++) {
				string subs = data.Substring (2*i, 2);
				retu [i] = byte.Parse (subs, NumberStyles.HexNumber);
			}
			return retu;
		}
		public static byte calcSum(byte baze, byte[] data){
			for(int i = 0; i < data.Length; i++){
				baze = BitConverter.GetBytes(baze + data[i])[0];
			}
			return baze;
		}
		public static byte calcCrc(byte baze, byte[] data){
			return BitConverter.GetBytes(0x100 - calcSum(baze, data))[0];
		}
		public void calcCrc(){
			crcCal = BitConverter.GetBytes(this.byteCount + (byte)this.recordType)[0];
			crcCal = BitConverter.GetBytes(crcCal + (this.address >> 8))[0];
			crcCal = BitConverter.GetBytes(crcCal + (this.address & 0xFF))[0];
			crcCal = calcCrc (crcCal, this.data);
		}
		public void data2sdata(){
			this.sdata = "";
			for (int i = 0; i < this.data.Length; i++) {
				this.sdata += dec2hex (this.data [i]);
			}
		}
		public override string ToString ()
		{
			string retu = "";
			switch (this.recordType) {
			case RecordType.Data:
				retu = "DATA: ";
				break;
			case RecordType.EoF:
				retu = "End of File";
				break;
			case RecordType.StrtLineAddr:
				retu = "Start Linear Address: ";
				break;
			case RecordType.StrtSegAddr:
				retu = "Start Segment Address: ";
				break;
			case RecordType.ExtLineAddr:
				retu = "Extended Linear Address: ";
				break;
			case RecordType.ExtSegAddr:
				retu = "Extended Segment Address: ";
				break;
			default:
				retu = "Wrong Hex Record";
				break;
			}
			retu += this.sdata;
			return retu;
		}
		public bool parse(string line)
		{
			Regex rgx = new Regex (@"^:(?<byteCount>[A-Fa-f0-9]{2})(?<address>[A-Fa-f0-9]{4})(?<type>[A-Fa-f0-9]{2})(?<data>[A-Fa-f0-9]*)(?<crc>[A-Fa-f0-9]{2})$");
			Match match = rgx.Match(line);
			this.byteCount = byte.Parse(match.Groups["byteCount"].Value, NumberStyles.HexNumber);
			this.address = ushort.Parse(match.Groups["address"].Value, NumberStyles.HexNumber);
			this.recordType = (RecordType)byte.Parse(match.Groups["type"].Value, NumberStyles.HexNumber);
			this.sdata = match.Groups["data"].Value;
			this.crc = byte.Parse(match.Groups["crc"].Value, NumberStyles.HexNumber);
			if (sdata.Length != (2 * byteCount)) {
				this.errNo = ErrorNum.WrongLength;
			}
			this.data = str2bytesAr(sdata);
			calcCrc ();
			if (this.crc != crcCal) {
				this.errNo = ErrorNum.WrongCRC;
			}
			return (this.errNo == ErrorNum.NoErr);
		}
		public string generate(){
			string retu = "" + this.startCode;
			retu += dec2hex (this.byteCount);
			retu += String.Format ("{0,4:X4}", this.address);
			retu += dec2hex ((byte)this.recordType);
			data2sdata ();
			retu += this.sdata;
			calcCrc ();
			this.crc = crcCal;
			retu += dec2hex (this.crc);
			return retu;
		}
	}
}

