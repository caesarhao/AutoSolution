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
		public enum ErrorNumE : byte
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
		public ErrorNumE ErrNo{ get; set;}
		private RecordTypeE recordType;
		public RecordTypeE RecordType{
			get{
				return this.recordType;
			}
			set{
				this.recordType = value;
			}
		}
		public ushort Address{ get; set;} // 2 bytes
		public byte[] Data{ get; set;} //


		public TiTxtRecord ()
		{
			this.ErrNo = ErrorNumE.NoErr;
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
					this.ErrNo = ErrorNumE.WrongLength;
					return false;
				}
				this.Address = ushort.Parse (line, NumberStyles.HexNumber);
				return true;
			} else if ('q' == line [0]) {
				this.recordType = RecordTypeE.EOF;
				if (1 != line.Length) {
					this.ErrNo = ErrorNumE.WrongLength;
					return false;
				}
				return true;
			} else {
				Regex rgx = new Regex (@"^(?<data>[A-Fa-f0-9\s]*)$");
				Match match = rgx.Match(line);
				if (!match.Success) {
					this.ErrNo = ErrorNumE.WrongRecord;
					return false;
				}
				this.recordType = RecordTypeE.Data;
				this.Data = str2bytesAr (match.Groups ["data"].Value);
				return true;
			}
		}
		public string generate(){
			string retu = "";
			switch (this.recordType) {
			case RecordTypeE.SecStrtAddr:
				retu = "@" + addr2hex (this.Address);
				break;
			case RecordTypeE.EOF:
				retu = "q";
				break;
			case RecordTypeE.Data:
				retu = data2str (this.Data);
				break;
			default:
				break;
			}
			return retu;
		}
	}
}

