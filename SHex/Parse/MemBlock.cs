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
		private ulong startAddr;
		public ulong StartAddr{
			get{
				return this.startAddr;
			}
			set{
				this.startAddr = value;
			}
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
		public ulong NextAddress{
			get{
				return (this.StartAddr + (ulong)DataSize);
			}
		}
		public ulong LastAddress{
			get{
				if (0 < DataSize) {
					return (NextAddress - 1);
				} else {
					return (NextAddress);
				}
			}
		}
		public bool IsAddressInMemBlk(ulong addr){
			return(addr >= this.StartAddr && addr <= this.NextAddress);
		}
		public bool IsAddressInMemBlk(uint addr){
			return(this.IsAddressInMemBlk((ulong)addr));
		}
		public bool IsAddressBeforeMemBlk(ulong addr){
			return(addr < this.StartAddr);
		}
		public bool IsAddressBeforeMemBlk(uint addr){
			return(IsAddressBeforeMemBlk((ulong)addr));
		}
		public bool IsAddressAfterMemBlk(ulong addr){
			return(addr > this.LastAddress);
		}
		public bool IsAddressAfterMemBlk(uint addr){
			return(IsAddressAfterMemBlk((ulong)addr));
		}
		public bool MergeMB(MemBlock nxt){
			this.Data.AddRange (nxt.Data);
			return true;
		}
		public static bool MergeMBs(List<MemBlock> mbs){
			int m = 0;
			//mbs = mbs.OrderBy (x => x.StartAddr).ToList();
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

