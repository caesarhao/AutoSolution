using System;
using Gtk;
using System.Collections.Generic;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditMessage : Gtk.Bin
	{
		private Message currentMsg;
		private List<string> cmbbUntItems;
		private List<string> cmbbCMItems;
		public EditMessage ()
		{
			this.Build ();
			cmbbUntItems = new List<string> ();
			cmbbCMItems = new List<string> ();
			foreach (var item in typeof(BaseType).GetEnumNames()) {
				this.cmbbType.AppendText (item.ToString ());
			}
		}
		private void RefreshComboBoxes(){
			cmbbUntItems.Clear ();
			int nrows = this.cmbbUnit.Model.IterNChildren();
			for (int i = 0; i < nrows; i++) {
				this.cmbbUnit.RemoveText(0);
			}
			foreach (var item in Group<Unit>.AllItems) {
				this.cmbbUnit.AppendText (item.name);
				cmbbUntItems.Add (item.name);
			}

			cmbbCMItems.Clear ();
			nrows = this.cmbbCompuMethod.Model.IterNChildren();
			for (int i = 0; i < nrows; i++) {
				this.cmbbCompuMethod.RemoveText(0);
			}
			foreach (var item in Group<CompuMethod>.AllItems) {
				this.cmbbCompuMethod.AppendText (item.name);
				cmbbCMItems.Add (item.name);
			}
		}
		public bool LoadData(Message dat){
			currentMsg = dat;

			RefreshComboBoxes();

			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;

			this.cmbbType.Active = (int)dat.type;
	
			if (null != dat.unit){
				this.cmbbUnit.Active = Group<Unit>.GFindIndexWithName(dat.unit.name);
			}
			if (null != dat.compuMethod){
				this.cmbbCompuMethod.Active = Group<CompuMethod>.GFindIndexWithName(dat.compuMethod.name);
			}
			this.spinbuttonArraySize.Value = dat.arraySize;
			return true;
		}
		public Message SaveData(Message dat=null){
			if (null == dat) {
				dat = currentMsg;
			}
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;
			dat.type = (BaseType)this.cmbbType.Active;
			dat.unit = Group<Unit>.GFindWithName (this.cmbbUnit.ActiveText);
			dat.compuMethod = Group<CompuMethod>.GFindWithName(this.cmbbCompuMethod.ActiveText);
			dat.arraySize = (ushort)(this.spinbuttonArraySize.Value);
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

		protected void OnCmbbTypeChanged (object sender, EventArgs e)
		{
			currentMsg.type = (BaseType)((ComboBox)sender).Active;
		}

		protected void OnCmbbUnitChanged (object sender, EventArgs e)
		{
			if (((ComboBox)sender).Active >= 0)
				currentMsg.unit = Group<Unit>.GItem (((ComboBox)sender).Active);
		}

		protected void OnCmbbCompuMethodChanged (object sender, EventArgs e)
		{
			if (((ComboBox)sender).Active >= 0)
				currentMsg.compuMethod = Group<CompuMethod>.GItem (((ComboBox)sender).Active);
		}


		protected void OnSpinButtonArraySizeChanged (object sender, EventArgs e)
		{
			currentMsg.arraySize = (ushort)this.spinbuttonArraySize.Value;
		}
	}
}

