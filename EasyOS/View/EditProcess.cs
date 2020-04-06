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
		public bool LoadData(Process dat){
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;

			return true;
		}
		public Process SaveData(Process dat=null){
			if (null == dat) {
				dat = new Process ();
			}
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;
			return dat;
		}
	}
}

