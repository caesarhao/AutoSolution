using System;
using System.Collections.Generic;
using Gtk;

namespace SHex
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class MemBlockView : Gtk.Bin
	{
		protected const int COL_SELECTED = 0;
		protected const int COL_INDEX = 1;
		protected const int COL_START_ADDRESS = 2;
		protected const int COL_SIZE = 3;
		protected TreeStore tsMemBlcS;
		private List<MemBlock> mbs;
		public MemBlockView ()
		{
			this.Build ();

			tsMemBlcS = new TreeStore (typeof(bool), typeof(int), typeof(string), typeof(string));
			this.treeviewMemBlcs.Model = tsMemBlcS;

			TreeViewColumn selectedColumn = new Gtk.TreeViewColumn ();
			selectedColumn.Title = "Selected";
			CellRendererToggle cellSelected = new CellRendererToggle ();
			cellSelected.Radio = false;
			cellSelected.Activatable = true;
			cellSelected.Active = true;
			cellSelected.Toggled += new ToggledHandler (OnCellSelectedToggled);
			selectedColumn.PackStart (cellSelected, true);
			selectedColumn.AddAttribute (cellSelected, "active", 0);
			this.treeviewMemBlcs.AppendColumn (selectedColumn);

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
			cellStartAdr.Edited += new EditedHandler (OnCellStartAdrEdited);
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
		public bool updateViewWithMemBlocks(List<MemBlock> nmbs){
			this.mbs = nmbs;
			this.tsMemBlcS.Clear ();
			for (int i = 0; i < mbs.Count; i++) {
				this.tsMemBlcS.AppendValues (true, i, "0x" + mbs[i].StartAddrAsHex(), mbs[i].DataSizeStr());
			}
			return true;
		}

		protected void OnCellSelectedToggled(object o, ToggledArgs args) {
			TreeIter iter;
			if (this.tsMemBlcS.GetIter (out iter, new TreePath (args.Path))){
				bool selected = (bool)this.tsMemBlcS.GetValue (iter, COL_SELECTED);
				selected = !selected;
				this.tsMemBlcS.SetValue(iter, COL_SELECTED, selected);
			}
		}

		protected void OnCellStartAdrEdited (object o, EditedArgs args)
		{
			TreeIter iter;
			TreePath tp = new TreePath (args.Path);
			if (this.tsMemBlcS.GetIter (out iter, tp)){
				string nstartAdr = (string)this.tsMemBlcS.GetValue (iter, COL_START_ADDRESS);
				this.tsMemBlcS.SetValue (iter, COL_START_ADDRESS, 0x40008000.ToString());
				this.mbs [0].StartAddr = 0x40008000;
			}
		}
	}
}

