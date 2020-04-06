using System;
using Gtk;
using System.Collections.Generic;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditGroup : Gtk.Bin
	{
		public EditGroup ()
		{
			this.Build ();
		}
		public bool LoadData<T>(Group<T> data)where T:AbstractData{
			this.entryName.Text = data.name;
			this.entryDescription.Text = data.description;
			return true;
		}
		public Group<T> SaveData<T>(Group<T> dat=null)where T:AbstractData{
			if (null == dat) {
				dat = new Group<T> ();
			}
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;
			return dat;
		}
	}
}

