using System;
using Gtk;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditMessage : Gtk.Bin
	{
		private Message currentMsg;
		public EditMessage ()
		{
			this.Build ();
			foreach (var item in typeof(BaseType).GetEnumNames()) {
				this.cmbbType.AppendText (item.ToString ());
			}

		}
		public bool LoadData(Message dat){
			currentMsg = dat;
			// clearn combobox list
			int nrows = this.cmbbUnit.Model.IterNChildren();
			for (int i = 0; i < nrows; i++) {
				this.cmbbUnit.RemoveText(0);
			}
			foreach (var item in Group<Unit>.AllItems) {
				this.cmbbUnit.AppendText (item.name);
			}
			nrows = this.cmbbCompuMethod.Model.IterNChildren();
			for (int i = 0; i < nrows; i++) {
				this.cmbbCompuMethod.RemoveText(0);
			}
			foreach (var item in Group<CompuMethod>.AllItems) {
				this.cmbbCompuMethod.AppendText (item.name);
			}
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;
			//this.cmbbUnit.Active = CurrentPrj.Units.FindIndexWithName(dat.unit.name);
			//this.cmbbCompuMethod.Active = CurrentPrj.CompuMethods.FindIndexWithName(dat.compuMethod.name);
			this.cmbbType.Active = (int)dat.type;
			return true;
		}
		public Message SaveData(Message dat=null){
			if (null == dat) {
				dat = currentMsg;
			}
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;
			return dat;
		}
		protected void OnEntryNameChanged (object sender, EventArgs e)
		{
			TreeStore ts = MainWindow.MW.ts;
			TreeIter ti;
			MainWindow.MW.GetTreeViewGlobal().Selection.GetSelected(out ti);
			ts.SetValue(ti, 0, ((Entry)sender).Text);
			currentMsg.name = ((Entry)sender).Text;
		}
		protected void OnEntryDescriptionChanged (object sender, EventArgs e)
		{
			currentMsg.description = ((Entry)sender).Text;
		}
	}
}

