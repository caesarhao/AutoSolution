using System;
using Gtk;
using EasyOS;
using Gdk;

public partial class MainWindow: Gtk.Window
{
	private EditGroup 			egrp;
	private EditProject 		eprj;
	private EditUnit 			eunt;
	private EditCompuMethod 	ecpmd;
	private EditMessage 		emsg;
	private EditProcess 		eprc;
	private EditTask 			etsk;
	private EditStateMachine 	esm;

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
		esm = new EditStateMachine ();
		esm.ShowAll ();

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
				this.alignFrmEditor.Child = esm;
				StateMachine sm = this.GPrj.StateMachines.FindWithName (itemName);
				esm.LoadData (sm);
				PopTreeViewGlobalContextMenu (3, sm);
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

	protected void OnTreeViewGlobalKeyPress (object o, KeyPressEventArgs args)
	{
		TreeView tv = (TreeView)o;
		TreeStore tm = (TreeStore)tv.Model;
		TreeIter root; 
		TreeIter ti;
		TreePath tp ;
		tm.GetIterFirst (out root);
		TreeViewColumn tvc;
		tv.GetCursor (out tp, out tvc);
		tm.GetIter (out ti, tp);
		int level = tm.GetPath (ti).Depth;
		AbstractData dat;
		if (1 == level) { // Project level
			dat = GPrj;
		} else if (2 == tm.GetPath (ti).Depth) { // Groups, like Tasks
			switch((string)tm.GetValue(ti, 0)){
			case "StateMachines":
				dat = GPrj.StateMachines;
				break;
			case "Tasks":
				dat = GPrj.Tasks;
				break;
			case "Processes":
				dat = GPrj.Processes;
				break;
			case "Messages":
				dat = GPrj.Messages;
				break;
			case "CompuMethods":
				dat = GPrj.CompuMethods;
				break;
			case "Units":
				dat = GPrj.Units;
				break;
			default:
				break;
			}
		} else if (3 == level) { // Item, like Task
			TreeIter tiL2;
			tm.IterParent (out tiL2, ti);
			this.alignFrmEditor.Remove(this.alignFrmEditor.Child);
			string itemName = (string)tm.GetValue (ti, 0);
			switch ((string)tm.GetValue (tiL2, 0)) {
			case "StateMachines":
				StateMachine sm = this.GPrj.StateMachines.FindWithName (itemName);
				if (args.Event.Key == Gdk.Key.KP_Add) {
					sm = new StateMachine ();
					this.GPrj.StateMachines.Add (sm);
					tm.AppendValues (TIstatemachines, sm.name);
					esm.LoadData (sm);
				} else if (args.Event.Key == Gdk.Key.KP_Subtract) {
					this.GPrj.StateMachines.Remove (sm);
					tm.Remove (ref ti);
				} else {
				}
				break;
			case "Tasks":
				Task tsk = this.GPrj.Tasks.FindWithName (itemName);
				if (args.Event.Key == Gdk.Key.KP_Add) {
					tsk = new Task ();
					this.GPrj.Tasks.Add (tsk);
					tm.AppendValues (TItasks, tsk.name);
					etsk.LoadData (tsk);
				} else if (args.Event.Key == Gdk.Key.KP_Subtract) {
					this.GPrj.Tasks.Remove (tsk);
					tm.Remove (ref ti);
				} else {
				}
				break;
			case "Processes":
				Process prc = this.GPrj.Processes.FindWithName (itemName);
				if (args.Event.Key == Gdk.Key.KP_Add) {
					prc = new Process ();
					this.GPrj.Processes.Add (prc);
					tm.AppendValues (TIprocesses, prc.name);
					eprc.LoadData (prc);
				} else if (args.Event.Key == Gdk.Key.KP_Subtract) {
					this.GPrj.Processes.Remove (prc);
					tm.Remove (ref ti);
				} else {
				}
				break;
			case "Messages":
				Message msg = this.GPrj.Messages.FindWithName (itemName);
				if (args.Event.Key == Gdk.Key.KP_Add) {
					msg = new Message ();
					this.GPrj.Messages.Add (msg);
					tm.AppendValues (TImessages, msg.name);
					emsg.LoadData (msg);
				} else if (args.Event.Key == Gdk.Key.KP_Subtract) {
					this.GPrj.Messages.Remove (msg);
					tm.Remove (ref ti);
				} else {
				}
				break;
			case "CompuMethods":
				CompuMethod cpmd = this.GPrj.CompuMethods.FindWithName (itemName);
				if (args.Event.Key == Gdk.Key.KP_Add) {
					cpmd = new CompuMethod ();
					this.GPrj.CompuMethods.Add (cpmd);
					tm.AppendValues (TIcompumethods, cpmd.name);
					ecpmd.LoadData (cpmd);
				} else if (args.Event.Key == Gdk.Key.KP_Subtract) {
					this.GPrj.CompuMethods.Remove (cpmd);
					tm.Remove (ref ti);
				} else {
				}
				break;
			case "Units":
				EasyOS.Unit unt = this.GPrj.Units.FindWithName (itemName);
				if (args.Event.Key == Gdk.Key.KP_Add) {
					unt = new EasyOS.Unit ();
					this.GPrj.Units.Add (unt);
					tm.AppendValues (TIunits, unt.name);
					eunt.LoadData (unt);
				} else if (args.Event.Key == Gdk.Key.KP_Subtract) {
					this.GPrj.Units.Remove (unt);
					tm.Remove (ref ti);
				} else {
				}
				break;
			default:
				this.alignFrmEditor.Child = egrp;
				break;
			}
		} else {
		}

	}
}
