/**
 * http://srecord.sourceforge.net/man/man5/srec_ti_txt.html
 * 
 * 
*/
using System;
using System.Text.RegularExpressions;
using System.Globalization;
namespace SHex
{
	public class TiTxtRecord
	{
		public enum ErrorNum : byte
		{
			NoErr = 0x00,
			WrongLength,
			WrongRecord
		};
		public enum RecordTypeE{
			SecStrtAddr = 0x00, //> Section Start Address
			Data = 0x01, //> Data line
			EOF = 0x02 //> End of File
		};
		private ErrorNum errNo;
		private RecordTypeE recordType;
		public RecordTypeE RecordType{
			get{
				return this.recordType;
			}
			set{
				this.recordType = value;
			}
		}
		private ushort address; // 2 bytes
		private byte[] data; //

		public TiTxtRecord ()
		{
			this.errNo = ErrorNum.NoErr;
		}

		public string dec2hex(byte h)
		{
			return String.Format ("{0,2:X2}", h);
		}
		public string addr2hex(ushort addr){
			byte tmp = BitConverter.GetBytes(addr >> 8)[0];
			string retu = dec2hex (tmp);
			tmp = BitConverter.GetBytes(addr & 0xFF)[0];
			retu += dec2hex (tmp);
			return retu;
		}
		public string data2str(byte[] data){
			string retu = "";
			foreach(byte b in data){
				retu += dec2hex (b);
				retu += " ";
			}
			retu = retu.Trim ();
			return retu;
		}
		public byte[] str2bytesAr(string data)
		{
			data = data.Replace(" ", "");
			int len = data.Length;
			byte[] retu = new byte[len/2];
			for (int i = 0; i < (len / 2); i++) {
				string subs = data.Substring (2*i, 2);
				retu [i] = byte.Parse (subs, NumberStyles.HexNumber);
			}
			return retu;
		}

		public bool parse(string line){
			line = line.Trim ();
			if ('@' == line [0]) {
				this.recordType = RecordTypeE.SecStrtAddr;
				line = line.Substring (1);
				if (4 != line.Length) {
					this.errNo = ErrorNum.WrongLength;
					return false;
				}
				this.address = ushort.Parse (line, NumberStyles.HexNumber);
				return true;
			} else if ('q' == line [0]) {
				this.recordType = RecordTypeE.EOF;
				if (1 != line.Length) {
					this.errNo = ErrorNum.WrongLength;
					return false;
				}
				return true;
			} else {
				Regex rgx = new Regex (@"^(?<data>[A-Fa-f0-9\s]*)$");
				Match match = rgx.Match(line);
				if (!match.Success) {
					this.errNo = ErrorNum.WrongRecord;
					return false;
				}
				this.recordType = RecordTypeE.Data;
				this.data = str2bytesAr (match.Groups ["data"].Value);
				return true;
			}
			return false;
		}
		public string generate(){
			string retu = "";
			switch (this.recordType) {
			case RecordTypeE.SecStrtAddr:
				retu = "@" + addr2hex (this.address);
				break;
			case RecordTypeE.EOF:
				retu = "q";
				break;
			case RecordTypeE.Data:
				retu = data2str (this.data);
				break;
			default:
				break;
			}
			return retu;
		}
	}
}

