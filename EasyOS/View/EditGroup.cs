using System;
using Gtk;
using System.Collections.Generic;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditGroup : Gtk.Bin
	{
		private AbstractData currentGrp;
		public EditGroup ()
		{
			this.Build ();
		}
		public bool LoadData<T>(Group<T> dat)where T:AbstractData{
			currentGrp = dat;
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;
			return true;
		}
		public Group<T> SaveData<T>(Group<T> dat=null)where T:AbstractData{
			if (null == dat) {
				dat = (Group<T>)currentGrp;
			}
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;
			return dat;
		}
		protected void OnEntryDescriptionChanged (object sender, EventArgs e)
		{
			currentGrp.description = ((Entry)sender).Text;
		}
	}
}

