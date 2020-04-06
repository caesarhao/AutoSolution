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
		public bool LoadData(Message dat){
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;
			this.entryUnit.Text = dat.unit;
			this.cmbbType.Active = (int)dat.type;
			return true;
		}
		public Message SaveData(Message dat=null){
			if (null == dat) {
				dat = new Message ();
			}
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;
			return dat;
		}
	}
}

