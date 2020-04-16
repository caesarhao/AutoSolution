using System;
using System.ComponentModel;
using Gtk;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditProject : Gtk.Bin
	{
		private Project currentPrj;
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
		}
		public bool LoadData(Project dat){
			currentPrj = dat;
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;
			this.entryAuthor.Text = dat.author;
			this.cmbbxLicense.Active = (int)dat.license;
			this.cmbbLanguage.Active = (int)dat.language;
			RefreshCmbbTarget ();
			switch (dat.language) {
			case Project.ELanguage.E_Lang_C:
				this.cmbbTarget.Active = (int)dat.target - (int)Project.ELanguage.E_Lang_C;
				break;
			case Project.ELanguage.E_Lang_Python:
				this.cmbbTarget.Active = (int)dat.target - (int)Project.ELanguage.E_Lang_Python;
				break;
			case Project.ELanguage.E_Lang_Lua:
				this.cmbbTarget.Active = (int)dat.target - (int)Project.ELanguage.E_Lang_Lua;
				break;
			default:
				break;
			}

			this.entryVersion.Text = dat.version;
			return true;
		}
		public Project SaveData(Project dat=null){
			if (null == dat) {
				dat = currentPrj;
			}
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;
			dat.author = this.entryAuthor.Text;
			dat.license = (Project.ELicense)this.cmbbxLicense.Active;
			dat.language = (Project.ELanguage)this.cmbbLanguage.Active;
			switch (dat.language) {
			case Project.ELanguage.E_Lang_C:
				dat.target = (Project.ETargetType)(this.cmbbTarget.Active + (int)Project.ETargetType.E_C_General);
				break;
			case Project.ELanguage.E_Lang_Python:
				dat.target = (Project.ETargetType)(this.cmbbTarget.Active + (int)Project.ETargetType.E_Python_General);
				break;
			case Project.ELanguage.E_Lang_Lua:
				dat.target = (Project.ETargetType)(this.cmbbTarget.Active + (int)Project.ETargetType.E_Lua_General);
				break;
			default:
				break;
			}
			dat.version = this.entryVersion.Text;
			return dat;
		}
		private void RefreshCmbbTarget(){
			int starter = 0, ender = 0;
			switch ((Project.ELanguage)this.cmbbLanguage.Active) {
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
			int nrows = this.cmbbTarget.Model.IterNChildren();
			for (int i = 0; i < nrows; i++) {
				this.cmbbTarget.RemoveText(0);
			}
			for (int i = starter; i < ender; i++) {
				Project.ETargetType item = (Project.ETargetType)i;
				DescriptionAttribute despAtt = (DescriptionAttribute)item.GetType ().GetMember (item.ToString ()) [0].GetCustomAttributes (typeof(DescriptionAttribute), false) [0];
				this.cmbbTarget.AppendText (despAtt.Description);
			}
		}

		protected void OnCmbbLanguageChanged (object sender, EventArgs e)
		{
			ComboBox senderr = (ComboBox)sender;
			RefreshCmbbTarget ();
		}
		protected void OnEntryNameChanged (object sender, EventArgs e)
		{
			TreeStore ts = MainWindow.MW.ts;
			TreeIter ti;
			MainWindow.MW.GetTreeViewGlobal().Selection.GetSelected(out ti);
			ts.SetValue(ti, 0, ((Entry)sender).Text);
			currentPrj.name = ((Entry)sender).Text;
		}
		protected void OnEntryDescriptionChanged (object sender, EventArgs e)
		{
			currentPrj.description = ((Entry)sender).Text;
		}
	}
}

