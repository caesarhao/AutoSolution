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
		private byte[]	data;
		public byte[] Data{
			get{
				ResizeData ();
				return data;
			}
		}
		private int dataSize;
		public int DataSize{
			get{
				return this.dataSize;
			}
		}
		public MemBlock ()
		{
			this.addrSize = 32;
			this.dataSize = 0;
			this.data = new byte[0];
		}
		public bool ResizeData(){
			if (data.Length > dataSize) {
				Array.Resize (ref data, dataSize); 
			}
			return true;
		}
		public int AppendData(byte[] nbs){
			if (null == nbs) {
				return -1;
			}
			if ((data.Length - dataSize) < nbs.Length) { // need to resize
				int newSize = 0;
				if (dataSize < nbs.Length) {
					newSize = data.Length + nbs.Length;
				} else {
					newSize = dataSize * 2;
				}
				Array.Resize (ref data, newSize); 
			}
			foreach (byte b in nbs) {
				data [dataSize++] = b;
			}
			return nbs.Length;
		}
		public ulong NextAddress(){
			return (startAddr + (ulong)dataSize);
		}
		public ulong LastAddress(){
			if (0 < dataSize) {
				return (NextAddress () - 1);
			} else {
				return (NextAddress ());
			}
		}
		public bool MergeMB(MemBlock nxt){
			Array.Resize (ref data, dataSize + nxt.DataSize);
			Array.Copy (nxt.Data, 0, data, dataSize, nxt.DataSize);
			this.dataSize += nxt.DataSize;
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

