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
			RasterStrs.Add ("init");
			RasterStrs.Add ("shutdown");
			RasterStrs.Add ("1ms");
			RasterStrs.Add ("10ms");
			RasterStrs.Add ("100ms");
			RasterStrs.Add ("1s");
			RasterStrs.Add ("10s");
			RasterStrs.Add ("60s");
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
			DialogSelectPrc dlSP = new DialogSelectPrc ();
			ResponseType resp = (ResponseType)dlSP.Run ();
			if (Gtk.ResponseType.Ok == resp) {
				if (1 > lsPrcs.IterNChildren()) { // empty, add prc directly
					currentTsk.processes.Add(Group<Process>.GFindWithName(dlSP.selectedPrcName));
					lsPrcs.AppendValues (dlSP.selectedPrcName);
				} else {
					TreeIter ti;
					if (this.treeviewProcesses.Selection.GetSelected (out ti)) { // add after the selected prc
						TreePath tp = lsPrcs.GetPath (ti);
						currentTsk.processes.Insert ((tp.Indices [0] + 1), Group<Process>.GFindWithName (dlSP.selectedPrcName));
						ti = lsPrcs.InsertAfter (ti);
						lsPrcs.SetValue (ti, 0, dlSP.selectedPrcName);
					} else { // Add at the end
						currentTsk.processes.Add(Group<Process>.GFindWithName(dlSP.selectedPrcName));
						lsPrcs.AppendValues (dlSP.selectedPrcName);
					}
				}
			}
			dlSP.Destroy ();

		}

		protected void OnButtonDeleteClicked (object sender, EventArgs e)
		{
			TreeIter ti;
			if (this.treeviewProcesses.Selection.GetSelected (out ti)) {
				TreePath tp = lsPrcs.GetPath (ti);
				Process selectedPrc = currentTsk.processes [tp.Indices [0]];
				currentTsk.processes.Remove (selectedPrc);
				lsPrcs.Remove (ref ti);
			}
		}

		protected void OnButtonUpClicked (object sender, EventArgs e)
		{
			TreeIter ti;
			if (this.treeviewProcesses.Selection.GetSelected (out ti)) {
				TreePath tp = lsPrcs.GetPath (ti);
				if (tp.Prev ()) {
					TreeIter ti_prev;
					lsPrcs.GetIter (out ti_prev, tp);
					lsPrcs.MoveBefore (ti, ti_prev);
					Process selectedPrc = currentTsk.processes [tp.Indices [0] + 1];
					currentTsk.processes.Remove (selectedPrc);
					currentTsk.processes.Insert (tp.Indices [0], selectedPrc);
				}
			}
		}

		protected void OnButtonDownClicked (object sender, EventArgs e)
		{
			TreeIter ti;
			if (this.treeviewProcesses.Selection.GetSelected (out ti)) {
				TreePath tp = lsPrcs.GetPath (ti);
				TreeIter ti_next = ti;
				if (lsPrcs.IterNext (ref ti_next)) {
					lsPrcs.MoveAfter (ti, ti_next);
					Process selectedPrc = currentTsk.processes [tp.Indices [0]];
					currentTsk.processes.Remove (selectedPrc);
					currentTsk.processes.Insert (tp.Indices [0] + 1, selectedPrc);
				}
			}
		}

		protected void OnCmbbeRasterChanged (object sender, EventArgs e)
		{
			string txt = ((ComboBoxEntry)sender).ActiveText;
			if (Task.ValidTxtAsRaster (txt)) {
				currentTsk.RasterFromStr (txt);
			}
		}
	}
}

