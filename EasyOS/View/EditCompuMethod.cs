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
			if (dat is RationalFunction) {
				this.notebook1.GetNthPage (0).ShowAll ();
				this.notebook1.GetNthPage (1).HideAll ();
			} else if (dat is VerbalTable) {
				this.notebook1.GetNthPage (0).HideAll ();
				this.notebook1.GetNthPage (1).ShowAll ();
			} else {
			}
			return true;
		}
		public CompuMethod SaveData(CompuMethod dat){
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;

			return dat;
		}
	}
}

