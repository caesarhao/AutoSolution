using System;

namespace SHex
{
	public class MemBlock
	{
		private int AddrSize;
		private ulong StartAddr;
		private byte[]	data;
		public MemBlock ()
		{
			AddrSize = 4;
		}
	}
}

