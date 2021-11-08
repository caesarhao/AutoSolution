using System;
using System.Collections.Generic;
using Gtk;

namespace SHex
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class MemBlockView : Gtk.Bin
	{
		protected const int COL_INDEX = 0;
		protected const int COL_START_ADDRESS = 1;
		protected const int COL_SIZE = 2;
		protected TreeStore tsMemBlcS;
		public MemBlockView ()
		{
			this.Build ();

			tsMemBlcS = new TreeStore (typeof(int), typeof(string), typeof(string));
			this.treeviewMemBlcs.Model = tsMemBlcS;

			TreeViewColumn idxColumn = new Gtk.TreeViewColumn ();
			idxColumn.Title = "Index";
			CellRendererText cellIdx = new CellRendererText ();
			cellIdx.Editable = false;
			idxColumn.PackStart (cellIdx, true);
			idxColumn.AddAttribute (cellIdx, "text", COL_INDEX);
			this.treeviewMemBlcs.AppendColumn (idxColumn);

			TreeViewColumn startAdrColumn = new Gtk.TreeViewColumn ();
			startAdrColumn.Title = "Start Address";
			CellRendererText cellStartAdr = new CellRendererText ();
			cellStartAdr.Editable = true;
			startAdrColumn.PackStart (cellStartAdr, true);
			startAdrColumn.AddAttribute (cellStartAdr, "text", COL_START_ADDRESS);
			this.treeviewMemBlcs.AppendColumn (startAdrColumn);

			TreeViewColumn sizeColumn = new Gtk.TreeViewColumn ();
			sizeColumn.Title = "Size (Bytes)";
			CellRendererText cellSize = new CellRendererText ();
			cellSize.Editable = false;
			sizeColumn.PackStart (cellSize, true);
			sizeColumn.AddAttribute (cellSize, "text", COL_SIZE);
			this.treeviewMemBlcs.AppendColumn (sizeColumn);
			
		}
		public bool updateViewWithMemBlocks(List<MemBlock> mbs){
			this.tsMemBlcS.Clear ();
			for (int i = 0; i < mbs.Count; i++) {
				this.tsMemBlcS.AppendValues (i, "0x" + mbs[i].StartAddrAsHex(), mbs[i].DataSizeStr());
			}
			return true;
		}

		protected void OnRowActivated (object o, RowActivatedArgs args)
		{
			TreeIter iter;
			if (this.tsMemBlcS.GetIter (out iter, args.Path)) {
				int idx = (int) tsMemBlcS.GetValue (iter, COL_INDEX);
				//this.tsMemBlcS.SetValue (iter, COL_START_ADDRESS, "blabla");
			}
		}

		protected void OnColumnsChanged (object sender, EventArgs e)
		{
			TreeIter iter;
			if (this.treeviewMemBlcs.Selection.GetSelected (out iter)) {
				int idx = (int) this.tsMemBlcS.GetValue (iter, COL_INDEX);
				this.tsMemBlcS.SetValue (iter, COL_START_ADDRESS, "mylove");
			}
		}
	}
}

