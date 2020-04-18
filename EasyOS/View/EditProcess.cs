using System;
using System.ComponentModel;
using Gtk;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditProcess : Gtk.Bin
	{
		private Process currentPrc;

		public EditProcess ()
		{
			this.Build ();

		}
		public bool LoadData(Process dat){
			currentPrc = dat;
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;

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
	}
}

