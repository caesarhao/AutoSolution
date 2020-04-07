using System;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditCompuMethod : Gtk.Bin
	{
		public EditCompuMethod ()
		{
			this.Build ();
		}
		public bool LoadData(CompuMethod dat){
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;

			return true;
		}
		public CompuMethod SaveData(CompuMethod dat){
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;

			return dat;
		}
	}
}

