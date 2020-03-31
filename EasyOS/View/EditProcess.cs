using System;
using System.ComponentModel;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditProcess : Gtk.Bin
	{
		public EditProcess ()
		{
			this.Build ();
			foreach (var item in Enum.GetValues(typeof(EasyOS.Process.ERaster))) {
				DescriptionAttribute despAtt = (DescriptionAttribute)item.GetType ().GetMember (item.ToString ()) [0].GetCustomAttributes (typeof(DescriptionAttribute), false) [0];
				this.cmbbRaster.AppendText (despAtt.Description);
			}
		}
	}
}

