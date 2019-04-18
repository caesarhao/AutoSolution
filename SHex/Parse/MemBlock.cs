using System;
using System.Linq;
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
			this.addrSize = 4;
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
					newSize = nbs.Length;
				} else {
					newSize = dataSize * 2;
				}
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
	}
}

