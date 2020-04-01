using System;
using System.ComponentModel;
using Gtk;

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

		protected void OnCmbbLanguageChanged (object sender, EventArgs e)
		{
			ComboBox senderr = (ComboBox)sender;
			this.entryAuthor.Text = senderr.Active.ToString();
			int starter = (int)Project.ETargetType.E_C_General, ender=(int)Project.ETargetType.E_Lua_EndFlag;
			switch ((Project.ELanguage)senderr.Active) {
			case Project.ELanguage.E_Lang_C:
				starter = (int)Project.ETargetType.E_C_General;
				ender = (int)Project.ETargetType.E_C_EndFlag;
				break;
			case Project.ELanguage.E_Lang_Python:
				starter = (int)Project.ETargetType.E_Python_General;
				ender = (int)Project.ETargetType.E_Python_EndFlag;
				break;
			case Project.ELanguage.E_Lang_Lua:
				starter = (int)Project.ETargetType.E_Lua_General;
				ender = (int)Project.ETargetType.E_Lua_EndFlag;
				break;
			default:
				break;
			}
			// clearn combobox list
//			for (int i = 0; i < this.cmbbTarget.Model.; i++) {
//				this.cmbbTarget.RemoveText(i);
//			}
			for (int i = starter; i < ender; i++) {
				Project.ETargetType item = (Project.ETargetType)i;
				DescriptionAttribute despAtt = (DescriptionAttribute)item.GetType ().GetMember (item.ToString ()) [0].GetCustomAttributes (typeof(DescriptionAttribute), false) [0];
				this.cmbbTarget.AppendText (despAtt.Description);
			}
		}
	}
}

