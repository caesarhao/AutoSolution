using System;
using System.ComponentModel;
using Gtk;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditProcess : Gtk.Bin
	{
		private Process currentPrc;
		protected ListStore lsRM, lsSM;
		public EditProcess ()
		{
			this.Build ();
			lsRM = new ListStore (typeof(string));
			this.treeviewReceiveMessages.Model = lsRM;
			TreeViewColumn tvcRM = new TreeViewColumn ();
			tvcRM.Title = "Receive Messages";
			CellRendererText cellRM = new CellRendererText ();
			cellRM.Editable = false;
			tvcRM.PackStart (cellRM, true);
			tvcRM.AddAttribute (cellRM, "text", 0);
			this.treeviewReceiveMessages.AppendColumn (tvcRM);

			lsSM = new ListStore (typeof(string));
			this.treeviewSendMessages.Model = lsSM;
			TreeViewColumn tvcSM = new TreeViewColumn ();
			tvcSM.Title = "Send Messages";
			CellRendererText cellSM = new CellRendererText ();
			cellSM.Editable = false;
			tvcSM.PackStart (cellSM, true);
			tvcSM.AddAttribute (cellSM, "text", 0);
			this.treeviewSendMessages.AppendColumn (tvcSM);
		}
		public bool LoadData(Process dat){
			currentPrc = dat;
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;
			this.lsRM.Clear ();
			foreach (var item in dat.receiveMessages) {
				lsRM.AppendValues (item.name);
			}
			this.lsSM.Clear ();
			foreach (var item in dat.sendMessages) {
				lsSM.AppendValues (item.name);
			}
			return true;
		}
		public Process SaveData(Process dat=null){
			if (null == dat) {
				dat = currentPrc;
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
			currentPrc.name = ((Entry)sender).Text;
		}
		protected void OnEntryDescriptionChanged (object sender, EventArgs e)
		{
			currentPrc.description = ((Entry)sender).Text;
		}

		protected void OnButtonEditReceiveMessagesClicked (object sender, EventArgs e)
		{
			DialogMsgInPrc dlMP = new DialogMsgInPrc ();
			dlMP.LoadData (currentPrc.receiveMessages);
			dlMP.Run ();
			dlMP.Destroy ();
		}

		protected void OnButtonEditSendMessagesClicked (object sender, EventArgs e)
		{
			DialogMsgInPrc dlMP = new DialogMsgInPrc ();
			dlMP.LoadData (currentPrc.sendMessages);
			dlMP.Run ();
			dlMP.Destroy ();
		}
	}
}

