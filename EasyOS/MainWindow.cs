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
		Gtk.TreeIter statemachines = ts.AppendValues (root, "StateMachineS");
		Gtk.TreeIter sm = ts.AppendValues (statemachines, "firststate");
		Gtk.TreeIter tasks = ts.AppendValues (root, "TaskS");
		Gtk.TreeIter isrs = ts.AppendValues (root, "ISRS");
		Gtk.TreeIter processs = ts.AppendValues (root, "ProcessS");
		Gtk.TreeIter variables = ts.AppendValues (root, "VariableS");
		Gtk.TreeIter computemethods = ts.AppendValues (root, "ComputeMethodS");
		Gtk.TreeIter units = ts.AppendValues (root, "UnitS");
		this.prjTreeView.Model = ts;

		Gtk.TreeViewColumn prjColumn = new Gtk.TreeViewColumn ();
//		prjColumn.Title = "Project";
		Gtk.CellRendererText projectCell = new Gtk.CellRendererText ();
		prjColumn.PackStart (projectCell, true);
		prjColumn.AddAttribute (projectCell, "text", 0);
//
//		// Add the columns to the TreeView
		prjTreeView.AppendColumn (prjColumn);
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnPrjTreeViewButtonPressEvent (object o, ButtonPressEventArgs args)
	{
		// single click, left button
		if (args.Event.Type == Gdk.EventType.ButtonPress && args.Event.Button == 1) {
			var model = prjTreeView.Model;
			TreeIter iter;
			model.GetIterFirst (out iter);
			model.GetValue (iter, 0);
			editorGtkLabel.Text = model.GetValue (iter, 0).ToString();
		}
	}
	protected void showAboutDialog (object sender, EventArgs e)
	{
		AboutDialogue ad = new AboutDialogue ();
		ad.Run ();
	}
}
