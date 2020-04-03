using System;
using Gtk;
using EasyOS;

public partial class MainWindow: Gtk.Window
{
	private EditGroup egrp;
	private EditProject eprj;
	private EditMessage emsg;
	private EditProcess eprc;
	private EditTask 	etsk;
	public Project GPrj = null;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();

		egrp = new EditGroup ();
		egrp.ShowAll ();
		eprj = new EditProject ();
		eprj.ShowAll ();
		emsg = new EditMessage ();
		emsg.ShowAll ();
		eprc = new EditProcess ();
		eprc.ShowAll ();
		etsk = new EditTask ();
		etsk.ShowAll ();

		Gtk.TreeStore ts = new Gtk.TreeStore (typeof (string));
		this.treeviewGlobal.Model = ts;
		Gtk.TreeIter prj = ts.AppendValues("Project");
		Gtk.TreeIter messages = ts.AppendValues (prj, "Messages");
		Gtk.TreeIter msg = ts.AppendValues (messages, "msg 1");
		Gtk.TreeIter processes = ts.AppendValues (prj, "Processes");
		// for test
		Gtk.TreeIter prc = ts.AppendValues (processes, "Prc 1");
		Gtk.TreeIter tasks = ts.AppendValues (prj, "Tasks");
		Gtk.TreeIter tsk1 = ts.AppendValues (tasks, "Tsk 1");
		Gtk.TreeViewColumn prjColumn = new Gtk.TreeViewColumn ();
		prjColumn.Title = "Project";

		Gtk.CellRendererText projectCell = new Gtk.CellRendererText ();
		prjColumn.PackStart (projectCell, true);
		prjColumn.AddAttribute (projectCell, "text", 0);
//
//		// Add the columns to the TreeView
		treeviewGlobal.AppendColumn (prjColumn);
		treeviewGlobal.Visible = false;

		this.alignFrmEditor.Child = eprj;
		this.frmEditor.ShowAll ();
		this.frmEditor.Visible = false;
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
			eprj.LoadData (GPrj);
		} else if (2 == tm.GetPath (ti).Depth) { // Sub levels, like Tasks
			this.alignFrmEditor.Remove(this.alignFrmEditor.Child);
			this.alignFrmEditor.Child = egrp;
			egrp.LoadData (GPrj.tasks);
		} else if (3 == tm.GetPath (ti).Depth) { // Sub levels, like Task
			TreeIter tiL2;
			tm.IterParent (out tiL2, ti);
			this.alignFrmEditor.Remove(this.alignFrmEditor.Child);
			switch ((string)tm.GetValue (tiL2, 0)) {
			case "StateMachines":
				this.alignFrmEditor.Child = egrp;
				break;
			case "Tasks":
				this.alignFrmEditor.Child = etsk;
				break;
			case "Processes":
				this.alignFrmEditor.Child = eprc;
				break;
			case "Messages":
				this.alignFrmEditor.Child = emsg;
				break;
			case "CompuMethods":
				this.alignFrmEditor.Child = egrp;
				break;
			case "Units":
				this.alignFrmEditor.Child = egrp;
				break;
			default:
				this.alignFrmEditor.Child = egrp;
				break;
			}
		} else {
		}
	}

	protected void OnNewPrjActivated (object sender, EventArgs e)
	{
		this.GPrj = new Project ();
		treeviewGlobal.Visible = true;
		this.frmEditor.Visible = true;
	}
}
