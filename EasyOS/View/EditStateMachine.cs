using System;
using Gtk;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditStateMachine : Gtk.Bin
	{
		private StateMachine currentSM;
		public EditStateMachine ()
		{
			this.Build ();
		}
		public bool LoadData(StateMachine dat){
			currentSM = dat;
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;
			return true;
		}
		public StateMachine SaveData(StateMachine dat=null){
			if (null == dat) {
				dat = currentSM;
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
			currentSM.name = ((Entry)sender).Text;
		}
		protected void OnEntryDescriptionChanged (object sender, EventArgs e)
		{
			currentSM.description = ((Entry)sender).Text;
		}
	}
}

