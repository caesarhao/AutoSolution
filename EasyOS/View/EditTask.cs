using System;
using Gtk;
using System.Collections.Generic;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditTask : Gtk.Bin
	{
		private Task currentTsk;
		private ListStore lsPrcs;
		public List<string> RasterStrs;
		public EditTask ()
		{
			RasterStrs = new List<string> ();
			RasterStrs.Add ("background");
			RasterStrs.Add ("once");
			RasterStrs.Add ("1ms");
			RasterStrs.Add ("10ms");
			RasterStrs.Add ("100ms");
			RasterStrs.Add ("1s");
			RasterStrs.Add ("10s");
			this.Build ();
			ReBuildCmbbeRaster ();
			lsPrcs = new ListStore (typeof(string));
			this.treeviewProcesses.Model = lsPrcs;
			TreeViewColumn tvcPrc = new TreeViewColumn ();
			tvcPrc.Title = "Processes";
			CellRendererText cellPrc = new CellRendererText ();
			cellPrc.Editable = false;
			tvcPrc.PackStart (cellPrc, true);
			tvcPrc.AddAttribute (cellPrc, "text", 0);
			this.treeviewProcesses.AppendColumn (tvcPrc);
		}
		protected void ReBuildCmbbeRaster(){
			int nrows = this.comboboxentryRaster.Model.IterNChildren();
			for (int i = 0; i < nrows; i++) {
				this.comboboxentryRaster.RemoveText(0);
			}
			foreach (var item in RasterStrs) {
				this.comboboxentryRaster.AppendText (item);
			}
		}
		public bool LoadData(Task dat){
			currentTsk = dat;
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;
			ReBuildCmbbeRaster ();
			if (RasterStrs.Contains (dat.RasterAsStr ())) {
				this.comboboxentryRaster.Active = RasterStrs.IndexOf (dat.RasterAsStr ());
			} else {
				RasterStrs.Add (dat.RasterAsStr ());
				this.comboboxentryRaster.AppendText (dat.RasterAsStr ());
				this.comboboxentryRaster.Active = RasterStrs.Count - 1;
			}
			lsPrcs.Clear ();
			foreach (var item in dat.processes) {
				lsPrcs.AppendValues (item.name);
			}
			return true;
		}
		public Task SaveData(Task dat=null){
			if (null == dat) {
				dat = currentTsk;
			}
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;
			return dat;
		}
		protected void OnEntryNameChanged (object sender, EventArgs e)
		{
			TreeStore ts = MainWindow.MW.ts;
			TreeIter ti;
			MainWindow.MW.GetTreeViewGlobal().Selection.GetSelected(out ti);
			ts.SetValue(ti, 0, ((Entry)sender).Text);
			currentTsk.name = ((Entry)sender).Text;
		}
		protected void OnEntryDescriptionChanged (object sender, EventArgs e)
		{
			currentTsk.description = ((Entry)sender).Text;
		}

		protected void OnButtonAddClicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnButtonDeleteClicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnButtonUpClicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected void OnButtonDownClicked (object sender, EventArgs e)
		{
			throw new NotImplementedException ();
		}

		protected bool ValidTxtAsRaster(string txt){
			bool ret = false;
			if (RasterStrs.Contains (txt)) {
				ret = true;
			} else {
				
			}
			return ret;
		}

		protected void OnCmbbeRasterChanged (object sender, EventArgs e)
		{
			string txt = ((ComboBoxEntry)sender).ActiveText;
			if (ValidTxtAsRaster (txt)) {
				currentTsk.RasterFromStr (txt);
			}
		}
	}
}

