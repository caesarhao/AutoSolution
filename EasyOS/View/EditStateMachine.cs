using System;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditStateMachine : Gtk.Bin
	{
		public EditStateMachine ()
		{
			this.Build ();
		}
		public bool LoadData(StateMachine dat){
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;
			return true;
		}
		public StateMachine SaveData(StateMachine dat=null){
			if (null == dat) {
				dat = new StateMachine ();
			}
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;
			return dat;
		}
	}
}

