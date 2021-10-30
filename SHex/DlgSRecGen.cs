using System;

namespace SHex
{
	public partial class DlgSRecGen : Gtk.Dialog
	{
		public DlgSRecGen ()
		{
			this.Build ();
			this.cmbbAddrSize.Active =2;
			this.cbbeDataLen.Active = 2;
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
		public int getAddrSize(){
			int retu = 32;
			retu = int.Parse(this.cmbbAddrSize.ActiveText);
			return retu;
		}
		public int getDataLen(){
			int retu = 32;
			retu = int.Parse (this.cbbeDataLen.ActiveText);
			retu = (retu > 0) ? retu : 1;
			retu = (retu < 33) ? retu : 32;
			return retu;
		}
		public string getFilename(){
			return this.filechooseWdg.Filename;
		}
	}
}

