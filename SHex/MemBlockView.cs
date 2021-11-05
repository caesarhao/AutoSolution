using System;
using System.Collections.Generic;

namespace SHex
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class MemBlockView : Gtk.Bin
	{
		public MemBlockView ()
		{
			this.Build ();
			this.tblMemBlock.NRows = 1;
		}
		public bool updateViewWithMemBlocks(List<MemBlock> mbs){
			this.tblMemBlock.NRows = (uint)(mbs.Count + 1);
			for (int i = 0; i < mbs.Count; i++) {
				this.tblMemBlock.Add(new Gtk.Label("" + i));
				this.tblMemBlock.Add(new Gtk.Label("" + mbs[i].StartAddr));
			}
			return true;
		}
	}
}

