using System;
using Gtk;
using SHex;

public partial class MainWindow: Gtk.Window
{
	protected IFileAccess ifa = null;
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected void OnOpen(object sender, EventArgs e)
	{
		//throw new NotImplementedException ();
		Gtk.FileChooserDialog fcd = new Gtk.FileChooserDialog ("Open File", null, Gtk.FileChooserAction.Open);
		fcd.AddButton (Gtk.Stock.Cancel, Gtk.ResponseType.Cancel);
		fcd.AddButton (Gtk.Stock.Open, Gtk.ResponseType.Ok);
		fcd.DefaultResponse = Gtk.ResponseType.Ok;
		fcd.SelectMultiple = false;
		Gtk.FileFilter filterBin = new Gtk.FileFilter ();
		filterBin.Name = "Bin";
		filterBin.AddPattern("*.bin");
		fcd.AddFilter (filterBin);
		Gtk.FileFilter filterHex = new Gtk.FileFilter ();
		filterHex.Name = "Hex";
		filterHex.AddPattern("*.hex");
		fcd.AddFilter (filterHex);
		Gtk.FileFilter filterSRec = new Gtk.FileFilter ();
		filterSRec.Name = "SRec";
		filterSRec.AddPattern("*.s19");
		filterSRec.AddPattern("*.s28");
		filterSRec.AddPattern("*.s37");
		filterSRec.AddPattern("*.s3");
		fcd.AddFilter (filterSRec);
		Gtk.FileFilter filterTiTxt = new Gtk.FileFilter ();
		filterTiTxt.Name = "TiTxt";
		filterTiTxt.AddPattern("*.txt");
		fcd.AddFilter (filterTiTxt);
		Gtk.ResponseType response = (Gtk.ResponseType) fcd.Run ();
		if (response == Gtk.ResponseType.Ok) {
			if (fcd.Filter.Name == "Bin") {
				ifa = new BinAccess ();
				ifa.parseFile (fcd.Filename);
			} else if (fcd.Filter.Name == "Hex") {
				ifa = new HexAccess ();
				ifa.parseFile (fcd.Filename);
			} else if (fcd.Filter.Name == "SRec") {
				ifa = new SRecAccess ();
				ifa.parseFile (fcd.Filename);
			} else if (fcd.Filter.Name == "TiTxt") {
				ifa = new TiTxtAccess ();
				ifa.parseFile (fcd.Filename);
			} else {
			}
			if (null != ifa) {
				this.textview_debug.Buffer.Text = "Parse memblocks : " + ifa.Memblks.Count + "\n";
				for (int i = 0; i < ifa.Memblks.Count; i++) {
					this.textview_debug.Buffer.Text += "Block : " + ifa.Memblks[i].StartAddr + " Len : " + ifa.Memblks[i].DataSize + "\n";
				}
			}
		} else {
		}
		fcd.Destroy ();
	}
		
	protected void OnTextviewDebugPasteClipboard (object sender, EventArgs e)
	{
		throw new NotImplementedException ();
	}

	protected void OnSave (object sender, EventArgs e)
	{
		HexRecord hr = new HexRecord ();
		this.textview_debug.Buffer.Text = "Hex Record Test:\n";
		string a = " :10010000214601360121470136007EFE09D2190140";
		string b = ":00000001FF  ";
		string c = "   :100110002146017EB7C20001FF5F16002148011988";
		this.textview_debug.Buffer.Text += (a + "\n");
		hr.parse (a);
		this.textview_debug.Buffer.Text += hr.generate ();
		this.textview_debug.Buffer.Text += "\n";
		this.textview_debug.Buffer.Text += (b + "\n");
		hr.parse (b);
		this.textview_debug.Buffer.Text += hr.generate ();
		this.textview_debug.Buffer.Text += "\n";
		this.textview_debug.Buffer.Text += (c + "\n");
		hr.parse (c);
		this.textview_debug.Buffer.Text += hr.generate ();
		SRecord sr = new SRecord ();
		this.textview_debug.Buffer.Text += "\nS Record Test:\n";
		string d = "  S00F000068656C6C6F202020202000003C";
		string ee = "S11F00007C0802A6900100049421FFF07C6C1B787C8C23783C6000003863000026";
		string f = "   S5030003F9  ";
		this.textview_debug.Buffer.Text += (d + "\n");
		sr.parse (d);
		this.textview_debug.Buffer.Text += sr.generate ();
		this.textview_debug.Buffer.Text += "\n";
		this.textview_debug.Buffer.Text += (ee + "\n");
		sr.parse (ee);
		this.textview_debug.Buffer.Text += sr.generate ();
		this.textview_debug.Buffer.Text += "\n";
		this.textview_debug.Buffer.Text += (f + "\n");
		sr.parse (f);
		this.textview_debug.Buffer.Text += sr.generate ();
		this.textview_debug.Buffer.Text += "\n";
		TiTxtRecord tr = new TiTxtRecord ();
		this.textview_debug.Buffer.Text += "TI Txt Record Test:\n";
		string g = "@FABC";
		string h = "31 40 00 03 B2 40 80 5A 20 01 D2 D3 22 00 D2 E3 ";
		string i = "q ";
		string j = " 21 00 3F 40 E8 FD 1F 83 FE 23 F9 3F  ";
		this.textview_debug.Buffer.Text += (g + "\n");
		tr.parse (g);
		this.textview_debug.Buffer.Text += tr.generate ();
		this.textview_debug.Buffer.Text += "\n";
		this.textview_debug.Buffer.Text += (h + "\n");
		tr.parse (h);
		this.textview_debug.Buffer.Text += tr.generate ();
		this.textview_debug.Buffer.Text += "\n";
		this.textview_debug.Buffer.Text += (i + "\n");
		tr.parse (i);
		this.textview_debug.Buffer.Text += tr.generate ();
		this.textview_debug.Buffer.Text += "\n";
		this.textview_debug.Buffer.Text += (j + "\n");
		tr.parse (j);
		this.textview_debug.Buffer.Text += tr.generate ();
		this.textview_debug.Buffer.Text += "\n";
		Console.WriteLine ("have a try");
	}
	protected void OnSaveAs (object sender, EventArgs e)
	{
		Gtk.FileChooserDialog fcd = new Gtk.FileChooserDialog ("Save as...", null, Gtk.FileChooserAction.Save);
		fcd.AddButton (Gtk.Stock.Cancel, Gtk.ResponseType.Cancel);
		fcd.AddButton (Gtk.Stock.SaveAs, Gtk.ResponseType.Ok);
		fcd.DefaultResponse = Gtk.ResponseType.Ok;
		fcd.SelectMultiple = false;
		Gtk.FileFilter filterBin = new Gtk.FileFilter ();
		filterBin.Name = "Bin";
		filterBin.AddPattern("*.bin");
		fcd.AddFilter (filterBin);
		Gtk.FileFilter filterHex = new Gtk.FileFilter ();
		filterHex.Name = "Hex";
		filterHex.AddPattern("*.hex");
		fcd.AddFilter (filterHex);
		Gtk.FileFilter filterSRec = new Gtk.FileFilter ();
		filterSRec.Name = "SRec";
		filterSRec.AddPattern("*.s19");
		filterSRec.AddPattern("*.s28");
		filterSRec.AddPattern("*.s37");
		filterSRec.AddPattern("*.s3");
		fcd.AddFilter (filterSRec);
		Gtk.FileFilter filterTiTxt = new Gtk.FileFilter ();
		filterTiTxt.Name = "TiTxt";
		filterTiTxt.AddPattern("*.txt");
		fcd.AddFilter (filterTiTxt);
		Gtk.ResponseType response = (Gtk.ResponseType) fcd.Run ();
		if (response == Gtk.ResponseType.Ok) {
			IFileAccess old_ifa = ifa;
			if (fcd.Filter.Name == "Bin") {
				ifa = new BinAccess ();
				ifa.Memblks = old_ifa.Memblks;
				ifa.generateFile (fcd.Filename + ".bin");
			} else if (fcd.Filter.Name == "Hex") {
				ifa = new HexAccess ();
				ifa.Memblks = old_ifa.Memblks;
				ifa.generateFile (fcd.Filename + ".hex");
			} else if (fcd.Filter.Name == "SRec") {
				ifa = new SRecAccess ();
				ifa.Memblks = old_ifa.Memblks;
				ifa.generateFile (fcd.Filename + ".s19");
			} else if (fcd.Filter.Name == "TiTxt") {
				ifa = new TiTxtAccess ();
				ifa.Memblks = old_ifa.Memblks;
				ifa.generateFile (fcd.Filename + ".txt");
			} else {
			}
		} else {
		}
		fcd.Destroy ();
	}
		
}
