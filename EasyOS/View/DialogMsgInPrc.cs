using System;
using Gtk;
using System.Collections.Generic;

namespace EasyOS
{
	public partial class DialogMsgInPrc : Gtk.Dialog
	{
		protected ListStore lsAM, lsSM;
		public List<string> lstAvailableMsgs, lstSelectedMsgs;
		public DialogMsgInPrc ()
		{
			lstAvailableMsgs = new List<string> ();
			lstSelectedMsgs = new List<string> ();
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
			this.lstSelectedMsgs.Clear ();
			foreach (var item in alreadySelectedMsgs) {
				lsSM.AppendValues (item.name);
				lstSelectedMsgs.Add (item.name);
			}

			this.lsAM.Clear ();
			lstAvailableMsgs.Clear ();
			foreach (var item in Group<Message>.AllItems) {
				if (!this.lstSelectedMsgs.Contains (item.name)) {
					lsAM.AppendValues (item.name);
					lstAvailableMsgs.Add (item.name);
				}
			}

			return true;
		}

		protected void OnButtonAddClicked (object sender, EventArgs e)
		{
			TreeIter ti;
			this.treeviewAvailableMsgs.Selection.GetSelected (out ti);
			string msgName = (string)lsAM.GetValue (ti, 0);
			if (lstAvailableMsgs.Contains (msgName) && !lstSelectedMsgs.Contains (msgName)) {
				lstSelectedMsgs.Add (msgName);
				lsSM.AppendValues (msgName);
				lstAvailableMsgs.Remove (msgName);
				lsAM.Remove (ref ti);
			}
		}

		protected void OnButtonDeleteClicked (object sender, EventArgs e)
		{
			TreeIter ti;
			this.treeviewSelectedMsgs.Selection.GetSelected (out ti);
			string msgName = (string)lsSM.GetValue (ti, 0);
			if (lstSelectedMsgs.Contains (msgName)) {
				lstSelectedMsgs.Remove (msgName);
				lsSM.Remove (ref ti);
				lstAvailableMsgs.Add (msgName);
				lsAM.AppendValues (msgName);
			}
		}
	}
}

