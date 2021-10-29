using System;

namespace SHex
{
	public partial class DlgSRecGen : Gtk.Dialog
	{
		public DlgSRecGen ()
		{
			this.Build ();
			this.cmbbAddrSize.Active =2;
			Gtk.FileChooserWidget fcw = this.filechooseWdg;
			Gtk.FileFilter filter = new Gtk.FileFilter ();
			filter.Name = "SRec";
			filter.AddPattern("*.srec");
			filter.AddPattern("*.s19");
			filter.AddPattern("*.s28");
			filter.AddPattern("*.s37");
			filter.AddPattern("*.s1");
			filter.AddPattern("*.s2");
			filter.AddPattern("*.s3");
			fcw.AddFilter (filter);

		}


	}
}

