using System;

namespace EasyOS
{
	public partial class DialogSelectPrc : Gtk.Dialog
	{
		public string selectedPrcName;
		public DialogSelectPrc ()
		{
			this.Build ();
			foreach (var item in Group<Process>.AllItems) {
				this.comboboxPrc.AppendText (item.name);
			}
		}

		protected void OnCmbbPrcChanged (object sender, EventArgs e)
		{
			selectedPrcName = comboboxPrc.ActiveText;
		}
	}
}

