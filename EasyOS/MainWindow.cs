using System;
using Gtk;
using EasyOS;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		
		Build ();

		Gtk.TreeStore ts = new Gtk.TreeStore (typeof (string));
		Gtk.TreeIter root = ts.AppendValues("Project");
		Gtk.TreeIter statemachines = ts.AppendValues (root, "StateMachines");
		Gtk.TreeIter tasks = ts.AppendValues (root, "Tasks");
		Gtk.TreeIter processes = ts.AppendValues (root, "Processes");
		Gtk.TreeIter messages = ts.AppendValues (root, "Messages");
		Gtk.TreeIter compumethods = ts.AppendValues (root, "CompuMethods");
		Gtk.TreeIter units = ts.AppendValues (root, "Units");
		this.treeviewGlobal.Model = ts;

		Gtk.TreeViewColumn prjColumn = new Gtk.TreeViewColumn ();
		prjColumn.Title = "Project";
		Gtk.CellRendererText projectCell = new Gtk.CellRendererText ();
		prjColumn.PackStart (projectCell, true);
		prjColumn.AddAttribute (projectCell, "text", 0);
//
//		// Add the columns to the TreeView
		treeviewGlobal.AppendColumn (prjColumn);

		EditProject eprj = new EditProject ();
		EditProcess eprc = new EditProcess ();
		this.alignFrmEditor.Child = eprj;
		this.frmEditor.ShowAll ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void showAboutDialog (object sender, EventArgs e)
	{
		AboutDialogue ad = new AboutDialogue ();
		ad.Run ();
	}

	protected void OnTreeViewGlobalCursorChanged (object sender, EventArgs e)
	{
		TreeView tv = (TreeView)sender;
		TreeModel tm = tv.Model;
		int x, y;
		TreePath tp;
		TreeViewColumn tvc;
		tv.GetCursor (out tp, out tvc);
		tv.GetPointer (out x, out y);

		this.lblFrmEditor.Text = tm.NColumns.ToString();
	}
}
