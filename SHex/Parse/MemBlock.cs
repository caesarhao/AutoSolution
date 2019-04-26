using System;
using System.Linq;
using System.Collections.Generic;
namespace SHex
{
	public class MemBlock
	{
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
			StartAddr = 0;
			this.addrSize = 32;
			this.data = new List<byte>();
		}
		public byte[] DataAsArray(){
			return this.data.ToArray();
		}
		public int AppendData(byte[] nbs){
			if (null == nbs) {
				return -1;
			}
			data.AddRange (nbs);
			return nbs.Length;
		}
		public ulong NextAddress(){
			return (startAddr + (ulong)DataSize);
		}
		public ulong LastAddress(){
			if (0 < DataSize) {
				return (NextAddress () - 1);
			} else {
				return (NextAddress ());
			}
		}
		public bool MergeMB(MemBlock nxt){
			this.Data.AddRange (nxt.Data);
			return true;
		}
		public static bool MergeMBs(List<MemBlock> mbs){
			int m = 0;
			while (1 < mbs.Count && m < (mbs.Count-1)) {
				if (mbs [m].NextAddress () == mbs [m + 1].StartAddr) {
					mbs [m].MergeMB (mbs [m + 1]);
					mbs.RemoveAt (m + 1);
					m = 0;
					continue;
				} else {
					m++;
				}
			}
			return true;
		}
	}
}

