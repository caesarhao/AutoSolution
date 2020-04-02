using System;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditTask : Gtk.Bin
	{
		public EditTask ()
		{
			this.Build ();
		}
		public bool LoadData(BaseData data=null){
			Task dat = (Task)data;
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;

			return true;
		}
	}
}

