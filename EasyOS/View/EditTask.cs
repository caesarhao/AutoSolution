using System;
using Gtk;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditTask : Gtk.Bin
	{
		private Task currentTsk;
		public EditTask ()
		{
			this.Build ();
		}
		public bool LoadData(Task dat){
			currentTsk = dat;
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;

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
	}
}

