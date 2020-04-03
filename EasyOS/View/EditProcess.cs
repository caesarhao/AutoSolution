using System;
using System.ComponentModel;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditProcess : Gtk.Bin
	{
		public EditProcess ()
		{
			this.Build ();

		}
		public bool LoadData(AbstractData data=null){
			Process dat = (Process)data;
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;

			return true;
		}
	}
}

