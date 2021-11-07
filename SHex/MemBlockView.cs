using System;
using System.Collections.Generic;
using Gtk;

namespace SHex
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class MemBlockView : Gtk.Bin
	{
		protected TreeStore tsMemBlcS;
		public MemBlockView ()
		{
			this.Build ();

			tsMemBlcS = new TreeStore (typeof(string), typeof(string));
			this.treeviewMemBlcs.Model = tsMemBlcS;

			TreeViewColumn startAdrColumn = new Gtk.TreeViewColumn ();
			startAdrColumn.Title = "Start Address";
			CellRendererText cellStartAdr = new CellRendererText ();
			cellStartAdr.Editable = false;
			startAdrColumn.PackStart (cellStartAdr, true);
			startAdrColumn.AddAttribute (cellStartAdr, "text", 0);
			this.treeviewMemBlcs.AppendColumn (startAdrColumn);

			TreeViewColumn sizeColumn = new Gtk.TreeViewColumn ();
			sizeColumn.Title = "Size (Bytes)";
			CellRendererText cellSize = new CellRendererText ();
			cellSize.Editable = false;
			sizeColumn.PackStart (cellSize, true);
			sizeColumn.AddAttribute (cellSize, "text", 1);
			this.treeviewMemBlcs.AppendColumn (sizeColumn);
			
		}
		public bool updateViewWithMemBlocks(List<MemBlock> mbs){
			this.tsMemBlcS.Clear ();
			for (int i = 0; i < mbs.Count; i++) {
				this.tsMemBlcS.AppendValues ("0x" + mbs[i].StartAddrAsHex(), mbs[i].DataSizeStr());
			}
			return true;
		}
	}
}

