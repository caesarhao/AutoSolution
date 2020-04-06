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
		public bool LoadData(Task dat){
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;

			return true;
		}
		public Task SaveData(Task dat=null){
			if (null == dat) {
				dat = new Task ();
			}
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;
			return dat;
		}
	}
}

