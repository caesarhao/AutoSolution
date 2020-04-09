using System;
using Gtk;
using EasyOS;
using Gdk;

public partial class MainWindow: Gtk.Window
{
	private EditGroup 		egrp;
	private EditProject 	eprj;
	private EditUnit 		eunt;
	private EditCompuMethod ecpmd;
	private EditMessage 	emsg;
	private EditProcess 	eprc;
	private EditTask 		etsk;

	public Project GPrj = null;
	public Gtk.TreeStore ts = null;

	public Gtk.TreeIter TIprj, TIunits, TIcompumethods,TImessages,TIprocesses,TItasks, TIstatemachines;

	private uint TreeViewGlobalBtn = 0;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();

		egrp = new EditGroup ();
		egrp.ShowAll ();
		eprj = new EditProject ();
		eprj.ShowAll ();
		eunt = new EditUnit ();
		eunt.ShowAll ();
		ecpmd = new EditCompuMethod ();
		ecpmd.ShowAll ();
		emsg = new EditMessage ();
		emsg.ShowAll ();
		eprc = new EditProcess ();
		eprc.ShowAll ();
		etsk = new EditTask ();
		etsk.ShowAll ();

		ts = new Gtk.TreeStore (typeof(string));
		this.treeviewGlobal.Model = ts;

		Gtk.TreeViewColumn prjColumn = new Gtk.TreeViewColumn ();
		prjColumn.Title = "EasyOS";

		Gtk.CellRendererText projectCell = new Gtk.CellRendererText ();
		prjColumn.PackStart (projectCell, true);
		prjColumn.AddAttribute (projectCell, "text", 0);
		treeviewGlobal.AppendColumn (prjColumn);

		treeviewGlobal.Visible = false;
		this.alignFrmEditor.Child = eprj;
		this.frmEditor.ShowAll ();
		this.frmEditor.Visible = false;

	}

	public void LoadTreeSubElements(){
		foreach (var item in GPrj.Units.GetAll()) {
			ts.AppendValues (TIunits, item.name);
		}
		foreach (var item in GPrj.CompuMethods.GetAll()) {
			ts.AppendValues (TIcompumethods, item.name);
		}
		foreach (var item in GPrj.Messages.GetAll()) {
			ts.AppendValues (TImessages, item.name);
		}
		foreach (var item in GPrj.Processes.GetAll()) {
			ts.AppendValues (TIprocesses, item.name);
		}
		foreach (var item in GPrj.Tasks.GetAll()) {
			ts.AppendValues (TItasks, item.name);
		}
		foreach (var item in GPrj.StateMachines.GetAll()) {
			ts.AppendValues (TIstatemachines, item.name);
		}
	}

	public void NewProject(){
		this.GPrj = new Project ();
		GPrj.Units.AddRange (EasyOS.Unit.CreateBaseUnits ());
		GPrj.CompuMethods.AddRange (EasyOS.CompuMethod.CreateBaseCompuMethods ());
		ts.Clear ();
		TIprj = ts.AppendValues(this.GPrj.name);
		TIunits = ts.AppendValues (TIprj, this.GPrj.Units.name);
		TIcompumethods = ts.AppendValues (TIprj, this.GPrj.CompuMethods.name);
		TImessages = ts.AppendValues (TIprj, this.GPrj.Messages.name);
		//Gtk.TreeIter msg = ts.AppendValues (messages, "msg 1");
		TIprocesses = ts.AppendValues (TIprj, this.GPrj.Processes.name);
		//Gtk.TreeIter prc = ts.AppendValues (processes, "Prc 1");
		TItasks = ts.AppendValues (TIprj, this.GPrj.Tasks.name);
		//Gtk.TreeIter tsk1 = ts.AppendValues (tasks, "Tsk 1");
		TIstatemachines = ts.AppendValues (TIprj, this.GPrj.StateMachines.name);

		LoadTreeSubElements ();

		treeviewGlobal.Visible = true;
		this.frmEditor.Visible = true;
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
			switch((string)tm.GetValue(ti, 0)){
			case "StateMachines":
				egrp.LoadData (GPrj.StateMachines);
				break;
			case "Tasks":
				egrp.LoadData (GPrj.Tasks);
				break;
			case "Processes":
				egrp.LoadData (GPrj.Processes);
				break;
			case "Messages":
				egrp.LoadData (GPrj.Messages);
				break;
			case "CompuMethods":
				egrp.LoadData (GPrj.CompuMethods);
				break;
			case "Units":
				egrp.LoadData (GPrj.Units);
				break;
			default:
				break;
			}
		} else if (3 == tm.GetPath (ti).Depth) { // Sub levels, like Task
			TreeIter tiL2;
			tm.IterParent (out tiL2, ti);
			this.alignFrmEditor.Remove(this.alignFrmEditor.Child);
			string itemName = (string)tm.GetValue (ti, 0);
			switch ((string)tm.GetValue (tiL2, 0)) {
			case "StateMachines":
				this.alignFrmEditor.Child = egrp;
				break;
			case "Tasks":
				this.alignFrmEditor.Child = etsk;
				Task tsk = this.GPrj.Tasks.FindWithName (itemName);
				etsk.LoadData (tsk);
				PopTreeViewGlobalContextMenu (3, tsk);
				break;
			case "Processes":
				this.alignFrmEditor.Child = eprc;
				Process prc = this.GPrj.Processes.FindWithName (itemName);
				eprc.LoadData (prc);
				PopTreeViewGlobalContextMenu (3, prc);
				break;
			case "Messages":
				this.alignFrmEditor.Child = emsg;
				Message msg = this.GPrj.Messages.FindWithName (itemName);
				emsg.LoadData (msg);
				PopTreeViewGlobalContextMenu (3, msg);
				break;
			case "CompuMethods":
				this.alignFrmEditor.Child = ecpmd;
				CompuMethod cpmd = this.GPrj.CompuMethods.FindWithName (itemName);
				ecpmd.LoadData (cpmd);
				PopTreeViewGlobalContextMenu (3, cpmd);
				break;
			case "Units":
				this.alignFrmEditor.Child = eunt;
				EasyOS.Unit unt = this.GPrj.Units.FindWithName (itemName);
				eunt.LoadData (unt);
				PopTreeViewGlobalContextMenu (3, unt);
				break;
			default:
				this.alignFrmEditor.Child = egrp;
				break;
			}
		} else {
		}
	}
	protected void PopTreeViewGlobalContextMenu<T>(int level, T data)where T: AbstractData{
		if (3 == TreeViewGlobalBtn) {
			TreeViewGlobalBtn = 0;

			if (1 == level) { // Project
				
			} else if (2 == level) { // Group
				
			} else if (3 == level) { // Item

			} else {
				
			}


		}
	}
	protected void OnNewPrjActivated (object sender, EventArgs e)
	{
		NewProject ();
	}

	[GLib.ConnectBefore]
	protected void OnTreeViewGlobalBtnPrs (object o, ButtonPressEventArgs args)
	{
		if (EventType.ButtonPress == args.Event.Type) {
			TreeViewGlobalBtn = args.Event.Button;
		}
	}
	[GLib.ConnectBefore]
	protected void OnTreeViewPopupMenu (object o, PopupMenuArgs args)
	{
//		Menu menu = new Menu ();
//		MenuItem mitem = new MenuItem ("Context Menu");
//		menu.Add (mitem);
//		menu.ShowAll ();
		this.statusBarLabel1.Text = o.GetType ().FullName;

	}
}
