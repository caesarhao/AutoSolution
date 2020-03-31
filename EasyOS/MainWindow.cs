using System;
using Gtk;
using EasyOS;

public partial class MainWindow: Gtk.Window
{
	private EditProject eprj;
	private EditProcess eprc;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		eprj = new EditProject ();
		eprj.ShowAll ();
		eprc = new EditProcess ();
		eprc.ShowAll ();
		Build ();
		Gtk.TreeStore ts = new Gtk.TreeStore (typeof (string));
		this.treeviewGlobal.Model = ts;
		Gtk.TreeIter prj = ts.AppendValues("Project");
		Gtk.TreeIter statemachines = ts.AppendValues (prj, "StateMachines");
		Gtk.TreeIter tasks = ts.AppendValues (prj, "Tasks");
		Gtk.TreeIter processes = ts.AppendValues (prj, "Processes");
		Gtk.TreeIter prc = ts.AppendValues (processes, "Prc 1");
		Gtk.TreeIter messages = ts.AppendValues (prj, "Messages");
		Gtk.TreeIter compumethods = ts.AppendValues (prj, "CompuMethods");
		Gtk.TreeIter units = ts.AppendValues (prj, "Units");

		Gtk.TreeViewColumn prjColumn = new Gtk.TreeViewColumn ();
		prjColumn.Title = "Project";
		Gtk.CellRendererText projectCell = new Gtk.CellRendererText ();
		prjColumn.PackStart (projectCell, true);
		prjColumn.AddAttribute (projectCell, "text", 0);
//
//		// Add the columns to the TreeView
		treeviewGlobal.AppendColumn (prjColumn);


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
		TreeIter root; 
		TreeIter ti;
		TreePath tp ;
		tm.GetIterFirst (out root);
		TreeViewColumn tvc;
		tv.GetCursor (out tp, out tvc);
		tm.GetIter (out ti, tp);
		this.lblFrmEditor.Text = (string)tm.GetValue(ti, 0);
		if (1 == tm.GetPath (ti).Depth) { // Project level
			this.alignFrmEditor.Remove(this.alignFrmEditor.Child);
			this.alignFrmEditor.Child = eprj;
		} else if (2 == tm.GetPath (ti).Depth) { // Sub levels, like Tasks
			this.alignFrmEditor.Remove(this.alignFrmEditor.Child);
			// show something
		} else if (3 == tm.GetPath (ti).Depth) { // Sub levels, like Task
			TreeIter tiL2;
			tm.IterParent (out tiL2, ti);
			this.alignFrmEditor.Remove(this.alignFrmEditor.Child);
			switch ((string)tm.GetValue (tiL2, 0)) {
			case "StateMachines":
				this.alignFrmEditor.Child = eprc;
				break;
			case "Tasks":
				this.alignFrmEditor.Child = eprc;
				break;
			case "Processes":
				this.alignFrmEditor.Child = eprc;
				break;
			case "Messages":
				this.alignFrmEditor.Child = eprc;
				break;
			case "CompuMethods":
				this.alignFrmEditor.Child = eprc;
				break;
			case "Units":
				this.alignFrmEditor.Child = eprc;
				break;
			default:
				this.alignFrmEditor.Child = eprj;
				break;
			}
		} else {
		}
	}
}
