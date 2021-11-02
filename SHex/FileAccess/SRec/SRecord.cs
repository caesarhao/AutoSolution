using System;
using System.Text.RegularExpressions;
using System.Globalization;
namespace SHex
{
	public class SRecord
	{
		public enum ErrorNum : byte
		{
			NoErr = 0x00,
			WrongLength,
			WrongCRC,
			WrongRecord
		};
		public enum RecordTypeE{
			S0 = 0x00, //> Header
			S1 = 0x01, //> Data, 16-bit address
			S2 = 0x02, //> Data, 24-bit address
			S3 = 0x03, //> Data, 32-bit address
			S4 = 0x04, //> Reserved
			S5 = 0x05, //> Count, 16-bit
			S6 = 0x06, //> Count, 24-bit
			S7 = 0x07, //> Start Address, 32-bit
			S8 = 0x08, //> Start Address, 24-bit
			S9 = 0x09  //> Start Address, 16-bit
		};
		private ErrorNum errNo;
		public RecordTypeE RecordType{ get; set;}
		private byte byteCount; // 1 byte
		private uint address; // 2 bytes, 3 bytes, or 4 bytes, depends on S1, S2, or S3
		public uint Address{
			get{
				return this.address;
			}
			set{
				this.address = value;
			}
		}
		private byte[] data; //
		public byte[] Data{
			get{
				return this.data;
			}
			set{
				this.data = value;
			}
		}
		private byte crc; // 1 byte

		private string addrEtdata;
		private byte crcCal; // calculated crc
		public SRecord ()
		{
			this.errNo = ErrorNum.NoErr;
		}
		public string dec2hex(byte h)
		{
			return String.Format ("{0,2:X2}", h);
		}
		public byte[] str2bytesAr(string data)
		{
			int len = data.Length;
			byte[] retu = new byte[len/2];
			for (int i = 0; i < (len / 2); i++) {
				string subs = data.Substring (2*i, 2);
				retu [i] = byte.Parse (subs, NumberStyles.HexNumber);
			}
			return retu;
		}
		public string address2str(uint addr, int addrSize){
			string retu = "";
			if (addrSize >= 8) {
				retu = dec2hex ((byte)(this.Address & 0x000000FF)) + retu;
			}
			if (addrSize >= 16) {
				retu = dec2hex ((byte)((this.Address & 0x0000FF00) >> 8)) + retu;
			}
			if (addrSize >= 24) {
				retu = dec2hex ((byte)((this.Address & 0x00FF0000) >> 16)) + retu;
			}
			if (addrSize >= 32) {
				retu = dec2hex ((byte)((this.Address & 0xFF000000) >> 24)) + retu;
			}
			return retu;
		}
		public string bytesAr2str(byte[] bytes){
			string retu = "";
			for(int i = 0; i < bytes.Length; i++){
				retu += dec2hex (bytes [i]);
			}
			return retu;
		}
		public void splitAddrEtData(){
			string ad = "";
			string sdata = "";
			switch (this.RecordType) {
			case RecordTypeE.S1:
				ad = this.addrEtdata.Substring (0, 4);
				sdata = this.addrEtdata.Substring (4);
				break;
			case RecordTypeE.S2:
				ad = this.addrEtdata.Substring (0, 6);
				sdata = this.addrEtdata.Substring (6);
				break;
			case RecordTypeE.S3:
				ad = this.addrEtdata.Substring (0, 8);
				sdata = this.addrEtdata.Substring (8);
				break;
			default:
				ad = "0";
				sdata = this.addrEtdata;
				break;
			}
			this.address = uint.Parse(ad, NumberStyles.HexNumber);
			this.data = str2bytesAr (sdata);
		}
		public void mergeAddrEtData(){
			this.addrEtdata = "";
			switch (this.RecordType) {
			case RecordTypeE.S0:
			case RecordTypeE.S1:
				this.addrEtdata += address2str(this.Address, 16);
				this.addrEtdata += bytesAr2str (this.Data);
				this.byteCount = (byte)(2 + this.Data.Length + 1);
				break;
			case RecordTypeE.S2:
				this.addrEtdata += address2str(this.Address, 24);
				this.addrEtdata += bytesAr2str (this.Data);
				this.byteCount = (byte)(3 + this.Data.Length + 1);
				break;
			case RecordTypeE.S3:
				this.addrEtdata += address2str(this.Address, 32);
				this.addrEtdata += bytesAr2str (this.Data);
				this.byteCount = (byte)(4 + this.Data.Length + 1);
				break;
			case RecordTypeE.S4:
				break;
			case RecordTypeE.S5:
				this.addrEtdata += address2str(this.Address, 16);
				this.byteCount = (byte)(2 + 1);
				break;
			case RecordTypeE.S6:
				this.addrEtdata += address2str(this.Address, 24);
				this.byteCount = (byte)(3 + 1);
				break;
			case RecordTypeE.S7:
				this.addrEtdata += address2str(this.Address, 32);
				this.byteCount = (byte)(4 + 1);
				break;
			case RecordTypeE.S8:
				this.addrEtdata += address2str(this.Address, 24);
				this.byteCount = (byte)(3 + 1);
				break;
			case RecordTypeE.S9:
				this.addrEtdata += address2str(this.Address, 16);
				this.byteCount = (byte)(2 + 1);
				break;
			default:
				this.byteCount = 0;
				break;
			}
		}
		public byte calcSum(byte baze, byte[] data){
			ushort p = baze;
			for(int i = 0; i < data.Length; i++){
				p += data[i];
			}
			baze = BitConverter.GetBytes(p)[0];
			return baze;
		}
		public byte calcCrc(byte baze, byte[] data){
			return BitConverter.GetBytes(0xFF - calcSum(baze, data))[0];
		}
		public void calcCrc(){
			byte[] sdataAr = str2bytesAr (this.addrEtdata);
			crcCal = calcCrc (this.byteCount, sdataAr);
		}
		public bool parse(string line){
			Regex rgx = new Regex (@"^S(?<recordType>[0-9]{1})(?<byteCount>[A-Fa-f0-9]{2})(?<addressEtdata>[A-Fa-f0-9]*)(?<crc>[A-Fa-f0-9]{2})$");
			Match match = rgx.Match(line.Trim());
			if (!match.Success) {
				this.errNo = ErrorNum.WrongRecord;
				return false;
			}
			this.RecordType = (RecordTypeE)byte.Parse(match.Groups["recordType"].Value, NumberStyles.HexNumber);
			this.byteCount = byte.Parse(match.Groups["byteCount"].Value, NumberStyles.HexNumber);
			this.addrEtdata = match.Groups["addressEtdata"].Value;
			this.crc = byte.Parse(match.Groups["crc"].Value, NumberStyles.HexNumber);
			if ((addrEtdata.Length + 2) != (2 * byteCount)) {
				this.errNo = ErrorNum.WrongLength;
			}
			splitAddrEtData ();
			calcCrc ();
			if (this.crc != crcCal) {
				this.errNo = ErrorNum.WrongCRC;
			}
			this.errNo = ErrorNum.NoErr;
			return (this.errNo == ErrorNum.NoErr);
		}
		public string generate(){
			string retu = this.RecordType.ToString();
			// update addrEtdata, byteCount based on Address and Data
			mergeAddrEtData();
			retu += dec2hex (this.byteCount);
			retu += this.addrEtdata;
			calcCrc ();
			this.crc = crcCal;
			retu += dec2hex(this.crc);
			return retu;
		}
	}
}

