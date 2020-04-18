using System;
using Gtk;
using System.Collections.Generic;

namespace EasyOS
{
	public partial class DialogMsgInPrc : Gtk.Dialog
	{
		protected ListStore lsAM, lsSM;
		public List<string> availableMsgs, selectedMsgs;
		public DialogMsgInPrc ()
		{
			availableMsgs = new List<string> ();
			selectedMsgs = new List<string> ();
			this.Build ();
			lsAM = new ListStore (typeof(string));
			this.treeviewAvailableMsgs.Model = lsAM;
			TreeViewColumn tvcAM = new TreeViewColumn ();
			tvcAM.Title = "Available Messages";
			CellRendererText cellAM = new CellRendererText ();
			cellAM.Editable = false;
			tvcAM.PackStart (cellAM, true);
			tvcAM.AddAttribute (cellAM, "text", 0);
			this.treeviewAvailableMsgs.AppendColumn (tvcAM);

			lsSM = new ListStore (typeof(string));
			this.treeviewSelectedMsgs.Model = lsSM;
			TreeViewColumn tvcSM = new TreeViewColumn ();
			tvcSM.Title = "Selected Messages";
			CellRendererText cellSM = new CellRendererText ();
			cellSM.Editable = false;
			tvcSM.PackStart (cellSM, true);
			tvcSM.AddAttribute (cellSM, "text", 0);
			this.treeviewSelectedMsgs.AppendColumn (tvcSM);
		}
		public bool LoadData(List<Message> alreadySelectedMsgs){
			this.lsSM.Clear ();
			this.selectedMsgs.Clear ();
			foreach (var item in alreadySelectedMsgs) {
				lsSM.AppendValues (item.name);
				this.selectedMsgs.Add (item.name);
			}

			this.lsAM.Clear ();
			availableMsgs.Clear ();
			foreach (var item in Group<Message>.AllItems) {
				if (!this.selectedMsgs.Contains (item.name)) {
					lsAM.AppendValues (item.name);
					this.availableMsgs.Add (item.name);
				}
			}

			return true;
		}

		protected void OnButtonAddClicked (object sender, EventArgs e)
		{
			TreeIter ti;
			this.treeviewAvailableMsgs.Selection.GetSelected (out ti);
			string msgName = (string)lsAM.GetValue (ti, 0);
			if (!this.selectedMsgs.Contains (msgName)) {
				lsSM.AppendValues (msgName);
				this.selectedMsgs.Add (msgName);
				this.availableMsgs.Remove (msgName);
				this.lsAM.Remove (ref ti);
			}
		}

		protected void OnButtonDeleteClicked (object sender, EventArgs e)
		{
			TreeIter ti;
			this.treeviewSelectedMsgs.Selection.GetSelected (out ti);
			string msgName = (string)lsSM.GetValue (ti, 0);
			lsSM.Remove (ref ti);
			this.selectedMsgs.Remove (msgName);
			this.availableMsgs.Add (msgName);
			this.lsAM.AppendValues (msgName);
		}
	}
}

