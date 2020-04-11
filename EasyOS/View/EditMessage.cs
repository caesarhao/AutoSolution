using System;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditMessage : Gtk.Bin
	{
		public Project CurrentPrj{ get; set;}
		public EditMessage ()
		{
			this.Build ();
			foreach (var item in typeof(BaseType).GetEnumNames()) {
				this.cmbbType.AppendText (item.ToString ());
			}

		}
		public bool LoadData(Message dat){
			// clearn combobox list
			int nrows = this.cmbbUnit.Model.IterNChildren();
			for (int i = 0; i < nrows; i++) {
				this.cmbbUnit.RemoveText(0);
			}
			foreach (var item in CurrentPrj.Units.GetAll()) {
				this.cmbbUnit.AppendText (item.name);
			}
			nrows = this.cmbbCompuMethod.Model.IterNChildren();
			for (int i = 0; i < nrows; i++) {
				this.cmbbCompuMethod.RemoveText(0);
			}
			foreach (var item in CurrentPrj.CompuMethods.GetAll()) {
				this.cmbbCompuMethod.AppendText (item.ToString ());
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
				dat = new Message ();
			}
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;
			return dat;
		}
	}
}

