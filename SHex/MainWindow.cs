using System;
using Gtk;
using SHex;

public partial class MainWindow: Gtk.Window
{
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
		throw new NotImplementedException ();
	}
		
	protected void OnTextviewDebugPasteClipboard (object sender, EventArgs e)
	{
		throw new NotImplementedException ();
	}

	protected void OnSave (object sender, EventArgs e)
	{
		HexRecord hr = new HexRecord ();
		this.textview_debug.Buffer.Text = "";
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
		this.textview_debug.Buffer.Text += "\n\n";
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
	}
}
