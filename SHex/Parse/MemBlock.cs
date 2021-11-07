using System;
using System.Linq;
using System.Collections.Generic;
namespace SHex
{
	public class MemBlock
	{
		// how many bits
		private int addrSize;
		public int AddrSize{
			get{
				return this.addrSize;
			}
			set{
				this.addrSize = value;
			}
		}
		private uint startAddr;
		public uint StartAddr{
			get{
				return this.startAddr;
			}
			set{
				this.startAddr = value;
			}
		}
		public static string dec2hex(byte h)
		{
			return String.Format ("{0,2:X2}", h);
		}
		public string StartAddrAsHex(){
			string retu = "";
			int numOfB = AddrSize / 8;
			for (int i = 0; i < numOfB; i++) {
				retu = dec2hex((byte)((this.StartAddr & (0x000000FF << (8 * i))) >> (8 * i))) + retu;
			}
			return retu;
		}
		private List<byte>	data;
		public List<byte> Data{
			get{
				return data;
			}
		}
		public int DataSize{
			get{
				return this.data.Count;
			}
		}
		public string DataSizeAsHex(){
			string retu = "";
			int numOfB = AddrSize / 8;
			for (int i = 0; i < numOfB; i++) {
				retu = dec2hex((byte)((this.DataSize & (0x000000FF << (8 * i))) >> (8 * i))) + retu;
			}
			return retu;
		}
		public float DataSizeAsKB(){
			return ((float)this.DataSize) / 1024;
		}
		public float DataSizeAsMB(){
			return this.DataSizeAsKB() / 1024;
		}
		public string DataSizeStr(){
			if (DataSizeAsMB () > 1) {
				return DataSizeAsMB ().ToString () + "M";
			} else if (DataSizeAsKB () > 1) {
				return DataSizeAsKB ().ToString () + "K";
			} else {
				return this.DataSize.ToString();
			}
		}
		public MemBlock ()
		{
			StartAddr = 0x00000000;
			this.addrSize = 32;
			this.data = new List<byte>();
		}
		public int Capacity(){
			return (2 << (this.AddrSize - 1)); 
		}
		public byte[] DataAsArray{
			get{
				return this.data.ToArray ();
			}
		}
		public int AppendData(byte[] nbs){
			if (null == nbs) {
				return -1;
			}
			data.AddRange (nbs);
			return nbs.Length;
		}
		public uint NextAddress{
			get{
				return (this.StartAddr + (uint)DataSize);
			}
		}
		public uint LastAddress{
			get{
				if (0 < DataSize) {
					return (NextAddress - 1);
				} else {
					return (NextAddress);
				}
			}
		}
		public bool IsAddressInMemBlk(uint addr){
			return(addr >= this.StartAddr && addr <= this.NextAddress);
		}
		public bool IsAddressBeforeMemBlk(uint addr){
			return(addr < this.StartAddr);
		}
		public bool IsAddressAfterMemBlk(uint addr){
			return(addr > this.LastAddress);
		}
		public bool MergeMB(MemBlock nxt){
			this.Data.AddRange (nxt.Data);
			return true;
		}
		public static bool MergeMBs(List<MemBlock> mbs){
			int m = 0;
			//mbs = mbs.OrderBy (x => x.StartAddr).ToList();
			mbs.Sort((x,y) => x.StartAddr.CompareTo(y.StartAddr));
			while (1 < mbs.Count && m < (mbs.Count-1)) {
				if (mbs [m].NextAddress == mbs [m + 1].StartAddr) {
					mbs [m].MergeMB (mbs [m + 1]);
					mbs.RemoveAt (m + 1);
					continue;
				} else {
					m++;
				}
			}
			return true;
		}
	}
}

