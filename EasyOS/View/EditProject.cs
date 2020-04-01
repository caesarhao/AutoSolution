using System;
using System.ComponentModel;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditProject : Gtk.Bin
	{
		public EditProject ()
		{
			
			this.Build ();
			foreach (var item in Enum.GetValues(typeof(EasyOS.Project.ELicense))) {
				DescriptionAttribute despAtt = (DescriptionAttribute)item.GetType ().GetMember (item.ToString ()) [0].GetCustomAttributes (typeof(DescriptionAttribute), false) [0];
				this.cmbbxLicense.AppendText (despAtt.Description);
			}
			foreach (var item in Enum.GetValues(typeof(EasyOS.Project.ELanguage))) {
				DescriptionAttribute despAtt = (DescriptionAttribute)item.GetType ().GetMember (item.ToString ()) [0].GetCustomAttributes (typeof(DescriptionAttribute), false) [0];
				this.cmbbLanguage.AppendText (despAtt.Description);
			}
			foreach (var item in Enum.GetValues(typeof(EasyOS.Project.ETargetType))) {
				DescriptionAttribute despAtt = (DescriptionAttribute)item.GetType ().GetMember (item.ToString ()) [0].GetCustomAttributes (typeof(DescriptionAttribute), false) [0];
				this.cmbbTarget.AppendText (despAtt.Description);
			}
		}
		public bool LoadData(BaseData data){
			Project dat = (Project)data;
			this.entryName.Text = dat.name;
			this.entryVersion.Text = dat.version;
			return true;
		}
	}
}

