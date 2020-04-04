using System;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditUnit : Gtk.Bin
	{
		public EditUnit ()
		{
			this.Build ();
		}
		public bool LoadData(AbstractData data=null){
			Unit dat = (Unit)data;
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;
			this.spin_s.Value = dat.exponents [(int)Unit.SIunit.s];
			return true;
		}
	}
}

