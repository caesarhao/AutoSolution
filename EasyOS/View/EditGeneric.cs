using System;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditGeneric : Gtk.Bin
	{
		public EditGeneric ()
		{
			this.Build ();
		}
		public bool LoadData(BaseData data = null){
			this.entryName.Text = "A new name?";
			this.entryDescription.Text = "Some Description here";
			return true;
		}
	}
}

