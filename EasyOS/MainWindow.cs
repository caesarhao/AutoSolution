﻿using System;
using Gtk;
using EasyOS;
using Gdk;
using System.IO;
using System.Xml;

public partial class MainWindow: Gtk.Window
{
	private string currentFilePath;
	private EditGroup 			egrp;
	private EditProject 		eprj;
	private EditUnit 			eunt;
	private EditCompuMethod 	ecpmd;
	private EditMessage 		emsg;
	private EditProcess 		eprc;
	private EditTask 			etsk;
	private EditStateMachine 	esm;

	public static MainWindow MW;

	public Project GPrj = null;
	public Gtk.TreeStore ts = null;

	public Gtk.TreeIter TIprj, TIunits, TIcompumethods,TImessages,TIprocesses,TItasks, TIstatemachines;

	private uint TreeViewGlobalBtn = 0;

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
		currentFilePath = "";
		MW = this;
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

		this.addAction.Sensitive = false;
		this.deleteAction.Sensitive = false;
		this.generateAction.Sensitive = false;
		this.GenerateAction.Sensitive = false;
		this.saveAction.Sensitive = false;
		this.SaveAction.Sensitive = false;
		this.saveAsAction.Sensitive = false;
		this.SaveAsAction.Sensitive = false;
		this.refreshAction.Sensitive = false;
	}
	public TreeView GetTreeViewGlobal(){
		return this.treeviewGlobal;
	}
	protected void CreateEmptyTreeStruct(){
		ts.Clear ();
		TIprj = ts.AppendValues(this.GPrj.name);
		TIunits = ts.AppendValues (TIprj, this.GPrj.Units.name);
		TIcompumethods = ts.AppendValues (TIprj, this.GPrj.CompuMethods.name);
		TImessages = ts.AppendValues (TIprj, this.GPrj.Messages.name);
		TIprocesses = ts.AppendValues (TIprj, this.GPrj.Processes.name);
		TItasks = ts.AppendValues (TIprj, this.GPrj.Tasks.name);
		TIstatemachines = ts.AppendValues (TIprj, this.GPrj.StateMachines.name);
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

	protected void NewProject(){
		this.GPrj = new Project ();
		GPrj.Units.AddRange (EasyOS.Unit.CreateBaseUnits ());
		GPrj.CompuMethods.AddRange (EasyOS.CompuMethod.CreateBaseCompuMethods ());
		GPrj.Messages.AddRange (EasyOS.Message.CreateBaseMessages ());
		GPrj.Processes.AddRange (EasyOS.Process.CreateBaseProcesses ());
		GPrj.Tasks.AddRange (EasyOS.Task.CreateBaseTasks ());
		CreateEmptyTreeStruct ();

		LoadTreeSubElements ();

		treeviewGlobal.Visible = true;
		this.frmEditor.Visible = true;

		this.saveAction.Sensitive = true;
		this.SaveAction.Sensitive = true;
	}

	protected void OpenProject(){
		if (null == this.GPrj) {
			return;
		}
		CreateEmptyTreeStruct ();

		LoadTreeSubElements ();

		treeviewGlobal.Visible = true;
		this.frmEditor.Visible = true;

		this.saveAction.Sensitive = true;
		this.SaveAction.Sensitive = true;
		this.saveAsAction.Sensitive = true;
		this.SaveAsAction.Sensitive = true;
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void showAboutDialog (object sender, EventArgs e)
	{
		AboutDialog about = new AboutDialog();
		about.ProgramName = "AutoSolution-EasyOS";
		about.Version = "0.1";
		about.Copyright = "(c) caesarhao";
		about.Comments = @"EasyOS is an app for generating OS structure";
		about.Website = "http://www.notyet.com";
		//about.Logo = new Gdk.Pixbuf("battery.png");
		about.Run();
		about.Destroy();
	}

	protected void OnTreeViewGlobalCursorChanged (object sender, EventArgs e)
	{
		TreeView tv = (TreeView)sender;
		TreeStore tm = (TreeStore)tv.Model;
		TreeIter root; 
		TreeIter ti;
		TreePath tp ;
		tm.GetIterFirst (out root);
		TreeViewColumn tvc;
		tv.GetCursor (out tp, out tvc);
		tm.GetIter (out ti, tp);
		this.lblFrmEditor.Text = (string)tm.GetValue(ti, 0);
		if (1 == tm.GetPath (ti).Depth) { // Project level
			this.addAction.Sensitive = false;
			this.deleteAction.Sensitive = false;
			this.alignFrmEditor.Remove(this.alignFrmEditor.Child);
			this.alignFrmEditor.Child = eprj;
			eprj.LoadData (GPrj);
		} else if (2 == tm.GetPath (ti).Depth) { // Sub levels, like Tasks
			this.addAction.Sensitive = true;
			this.deleteAction.Sensitive = false;
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
			this.addAction.Sensitive = true;
			this.deleteAction.Sensitive = true;
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
				if (args.Event.Key == Gdk.Key.KP_Add) {
					StateMachine sm = new StateMachine ();
					this.GPrj.StateMachines.Add (sm);
					ti = tm.AppendValues (TIstatemachines, sm.name);
					tp = tm.GetPath (ti);
					tv.ExpandToPath (tp);
					tv.SetCursor (tp, tvc, true);
					//esm.LoadData (sm);
				} else {
				}
				break;
			case "Tasks":
				dat = GPrj.Tasks;
				if (args.Event.Key == Gdk.Key.KP_Add) {
					Task tsk = new Task ();
					this.GPrj.Tasks.Add (tsk);
					ti = tm.AppendValues (TItasks, tsk.name);
					tp = tm.GetPath (ti);
					tv.ExpandToPath (tp);
					tv.SetCursor (tp, tvc, true);
					//etsk.LoadData (tsk);
				} else {
				}
				break;
			case "Processes":
				dat = GPrj.Processes;
				if (args.Event.Key == Gdk.Key.KP_Add) {
					Process prc = new Process ();
					this.GPrj.Processes.Add (prc);
					ti = tm.AppendValues (TIprocesses, prc.name);
					tp = tm.GetPath (ti);
					tv.ExpandToPath (tp);
					tv.SetCursor (tp, tvc, true);
					//eprc.LoadData (prc);
				} else {
				}
				break;
			case "Messages":
				dat = GPrj.Messages;
				if (args.Event.Key == Gdk.Key.KP_Add) {
					Message msg = new Message ();
					this.GPrj.Messages.Add (msg);
					ti = tm.AppendValues (TImessages, msg.name);
					tp = tm.GetPath (ti);
					tv.ExpandToPath (tp);
					tv.SetCursor (tp, tvc, true);
					//emsg.LoadData (msg);
				} else {
				}
				break;
			case "CompuMethods":
				dat = GPrj.CompuMethods;
				if (args.Event.Key == Gdk.Key.KP_Add) {
					CompuMethod cpmd;
					int resp = SelectCompuMethodToCreate (this);
					if (1 == resp) {
						cpmd = new RationalFunction ();
					} else if (2 == resp) {
						cpmd = new VerbalTable ();
					} else {
						return;
					}
					this.GPrj.CompuMethods.Add (cpmd);
					ti = tm.AppendValues (TIcompumethods, cpmd.name);
					tp = tm.GetPath (ti);
					tv.ExpandToPath (tp);
					tv.SetCursor (tp, tvc, true);
					//ecpmd.LoadData (cpmd);
				} else {
				}
				break;
			case "Units":
				dat = GPrj.Units;
				if (args.Event.Key == Gdk.Key.KP_Add) {
					EasyOS.Unit unt = new EasyOS.Unit ();
					this.GPrj.Units.Add (unt);
					ti = tm.AppendValues (TIunits, unt.name);
					tp = tm.GetPath (ti);
					tv.ExpandToPath (tp);
					tv.SetCursor (tp, tvc, true);
					//eunt.LoadData (unt);
				} else {
				}
				break;
			default:
				break;
			}
			this.statusBarLabel1.Text = tp.ToString ();
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
					ti = tm.AppendValues (TIstatemachines, sm.name);
					tp = tm.GetPath (ti);
					tv.SetCursor (tp, tvc, true);
					//esm.LoadData (sm);
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
					ti = tm.AppendValues (TItasks, tsk.name);
					tp = tm.GetPath (ti);
					tv.SetCursor (tp, tvc, true);
					//etsk.LoadData (tsk);
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
					ti = tm.AppendValues (TIprocesses, prc.name);
					tp = tm.GetPath (ti);
					tv.SetCursor (tp, tvc, true);
					//eprc.LoadData (prc);
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
					ti = tm.AppendValues (TImessages, msg.name);
					tp = tm.GetPath (ti);
					tv.SetCursor (tp, tvc, true);
					//emsg.LoadData (msg);
				} else if (args.Event.Key == Gdk.Key.KP_Subtract) {
					this.GPrj.Messages.Remove (msg);
					tm.Remove (ref ti);
				} else {
				}
				break;
			case "CompuMethods":
				CompuMethod cpmd = this.GPrj.CompuMethods.FindWithName (itemName);
				if (args.Event.Key == Gdk.Key.KP_Add) {
					int resp = SelectCompuMethodToCreate (this);
					if (1 == resp) {
						cpmd = new RationalFunction ();
					} else if (2 == resp) {
						cpmd = new VerbalTable ();
					} else {
						return;
					}
					this.GPrj.CompuMethods.Add (cpmd);
					ti = tm.AppendValues (TIcompumethods, cpmd.name);
					tp = tm.GetPath (ti);
					tv.SetCursor (tp, tvc, true);
					//ecpmd.LoadData (cpmd);
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
					ti = tm.AppendValues (TIunits, unt.name);
					tp = tm.GetPath (ti);
					tv.SetCursor (tp, tvc, true);
					//eunt.LoadData (unt);
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
			this.statusBarLabel1.Text = tp.ToString ();
		} else {
		}

	}

	protected int SelectCompuMethodToCreate(Gtk.Window parent){
		MessageDialog md = new MessageDialog(parent, 
			DialogFlags.DestroyWithParent, MessageType.Question, 
			ButtonsType.None, "Create a new?");
		md.AddButton ("RationalFuncion", 1);
		md.AddButton ("VerbalTable", 2);
		int resp = md.Run();
		md.Destroy();
		return resp;
	}
	protected void OnOpenActionActivated (object sender, EventArgs e)
	{
		FileChooserDialog fcd = new FileChooserDialog ("Open EasyOS project...", this, FileChooserAction.Open);
		fcd.AddButton (Gtk.Stock.Ok, ResponseType.Ok);
		fcd.AddButton (Gtk.Stock.Cancel, ResponseType.Cancel);
		fcd.SelectMultiple = false;
		fcd.Filter = new FileFilter ();
		fcd.Filter.AddPattern ("*.eos");
		fcd.DefaultResponse = ResponseType.Cancel;
		ResponseType response = (ResponseType) fcd.Run ();
		if (response == Gtk.ResponseType.Ok) {
			XmlDocument doc = new XmlDocument();
			currentFilePath = fcd.Filename;
			doc.Load (fcd.Filename);
			XmlNode nprj = doc.SelectSingleNode ("/Project");
			this.GPrj = (Project)Project.ParseFromXml (nprj);
			OpenProject ();
		}
		fcd.Destroy ();
	}

	protected void OnSaveActionActivated (object sender, EventArgs e)
	{
		if (currentFilePath.Equals ("")) {
			FileChooserDialog fcd = new FileChooserDialog ("Save EasyOS project...", this, FileChooserAction.Save);
			fcd.AddButton (Gtk.Stock.Ok, ResponseType.Ok);
			fcd.AddButton (Gtk.Stock.Cancel, ResponseType.Cancel);
			fcd.SelectMultiple = false;
			fcd.Filter = new FileFilter ();
			fcd.Filter.AddPattern ("*.eos");
			fcd.DefaultResponse = ResponseType.Cancel;
			fcd.CurrentName = GPrj.name + ".eos";
			ResponseType response = (ResponseType) fcd.Run ();
			if (response == Gtk.ResponseType.Ok) {
				string filename = fcd.Filename;
				if (!filename.EndsWith(".eos")){
					filename += ".eos";
				}
				currentFilePath = filename;
				TextWriter tw = new StreamWriter(filename);
				//			foreach (var item in GPrj.SaveToXml()) {
				//				tw.WriteLine (item);
				//			}
				GPrj.SaveAsXml().Save(tw);
				tw.Close();
				this.saveAsAction.Sensitive = true;
				this.SaveAsAction.Sensitive = true;
			}
			fcd.Destroy ();
		} else {
			TextWriter tw = new StreamWriter(currentFilePath);
			GPrj.SaveAsXml().Save(tw);
			tw.Close();
		}
	}

	protected void OnSaveAsActionActivated (object sender, EventArgs e)
	{
		FileChooserDialog fcd = new FileChooserDialog ("Save EasyOS project as...", this, FileChooserAction.Save);
		fcd.AddButton (Gtk.Stock.Ok, ResponseType.Ok);
		fcd.AddButton (Gtk.Stock.Cancel, ResponseType.Cancel);
		fcd.SelectMultiple = false;
		fcd.Filter = new FileFilter ();
		fcd.Filter.AddPattern ("*.eos");
		fcd.DefaultResponse = ResponseType.Cancel;
		fcd.SetCurrentFolder (System.IO.Path.GetDirectoryName (currentFilePath));
		fcd.CurrentName = (System.IO.Path.GetFileName (currentFilePath).Replace(".eos", "_Copy.eos"));

		ResponseType response = (ResponseType) fcd.Run ();
		if (response == Gtk.ResponseType.Ok) {
			string filename = fcd.Filename;
			if (!filename.EndsWith(".eos")){
				filename += ".eos";
			}
			currentFilePath = filename;
			TextWriter tw = new StreamWriter(currentFilePath);
			GPrj.SaveAsXml().Save(tw);
			tw.Close();
		}
		fcd.Destroy ();
	}

	protected void OnGenerateActionActivated (object sender, EventArgs e)
	{
		FileChooserDialog fcd = new FileChooserDialog ("Generate code into...", this, FileChooserAction.SelectFolder);
		fcd.AddButton (Gtk.Stock.Ok, ResponseType.Ok);
		fcd.AddButton (Gtk.Stock.Cancel, ResponseType.Cancel);
		fcd.SelectMultiple = false;
		fcd.Filter = new FileFilter ();
		fcd.DefaultResponse = ResponseType.Cancel;
		ResponseType response = (ResponseType) fcd.Run ();
		if (response == Gtk.ResponseType.Ok) {
			// TODO: Generate code here.
		}
		fcd.Destroy ();
	}

}
