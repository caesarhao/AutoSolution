using System;

namespace EasyOS
{
	public partial class AboutDialogue : Gtk.Dialog
	{
		public AboutDialogue ()
		{
			this.Build ();
		}

		protected void btnOkClicked_handler (object sender, EventArgs e)
		{
			this.Destroy ();
		}
	}
}

