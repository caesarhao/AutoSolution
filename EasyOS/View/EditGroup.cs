using System;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditGroup : Gtk.Bin
	{
		public EditGroup ()
		{
			this.Build ();
		}
		public bool LoadData(AbstractData data = null){
			this.entryName.Text = data.name;
			this.entryDescription.Text = "Some Description here";
			return true;
		}
	}
}

