using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{
	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		
		Build ();

		Gtk.TreeStore ts = new Gtk.TreeStore (typeof (string));
		Gtk.TreeIter root = ts.AppendValues("Project");
		Gtk.TreeIter statemachines = ts.AppendValues (root, "StateMachineS");
		Gtk.TreeIter sm = ts.AppendValues (statemachines, "firststate");
		Gtk.TreeIter tasks = ts.AppendValues (root, "TaskS");
		Gtk.TreeIter isrs = ts.AppendValues (root, "ISRS");
		Gtk.TreeIter processs = ts.AppendValues (root, "ProcessS");
		Gtk.TreeIter variables = ts.AppendValues (root, "VariableS");
		Gtk.TreeIter computemethods = ts.AppendValues (root, "ComputeMethodS");
		Gtk.TreeIter units = ts.AppendValues (root, "UnitS");
		this.treeview1.Model = ts;

		Gtk.TreeViewColumn prjColumn = new Gtk.TreeViewColumn ();
//		prjColumn.Title = "Project";
		Gtk.CellRendererText projectCell = new Gtk.CellRendererText ();
		prjColumn.PackStart (projectCell, true);
		prjColumn.AddAttribute (projectCell, "text", 0);
//
//		// Add the columns to the TreeView
		treeview1.AppendColumn (prjColumn);
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
}
