using System;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditMessage : Gtk.Bin
	{
		public EditMessage ()
		{
			this.Build ();
			foreach (var item in typeof(BaseType).GetEnumNames()) {
				this.cmbbType.AppendText (item.ToString ());
			}

		}
		public bool LoadData(AbstractData data=null){
			Message dat = (Message)data;
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;
			this.entryUnit.Text = dat.unit;
			this.cmbbType.Active = (int)dat.type;
			return true;
		}
	}
}

