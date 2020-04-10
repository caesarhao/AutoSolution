
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action FileAction;
	
	private global::Gtk.Action EditAction;
	
	private global::Gtk.Action GenerateAction;
	
	private global::Gtk.Action HelpAction;
	
	private global::Gtk.Action fileAction;
	
	private global::Gtk.Action openAction;
	
	private global::Gtk.Action saveAction;
	
	private global::Gtk.Action saveAsAction;
	
	private global::Gtk.Action executeAction;
	
	private global::Gtk.Action addAction;
	
	private global::Gtk.Action deleteAction;
	
	private global::Gtk.Action Action;
	
	private global::Gtk.Action AboutAction;
	
	private global::Gtk.Action NewAction;
	
	private global::Gtk.Action OpenAction;
	
	private global::Gtk.Action SaveAction;
	
	private global::Gtk.Action SaveAsAction;
	
	private global::Gtk.Action refreshAction;
	
	private global::Gtk.Action revertToSavedAction;
	
	private global::Gtk.VBox vbox1;
	
	private global::Gtk.MenuBar menubar1;
	
	private global::Gtk.Toolbar toolbar1;
	
	private global::Gtk.HPaned hpaned3;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.TreeView treeviewGlobal;
	
	private global::Gtk.Frame frmEditor;
	
	private global::Gtk.Alignment alignFrmEditor;
	
	private global::Gtk.Label lblFrmEditor;
	
	private global::Gtk.Statusbar statusbar1;
	
	private global::Gtk.Label statusBarLabel1;
	
	private global::Gtk.Label statusBarLabel2;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.EditAction = new global::Gtk.Action ("EditAction", global::Mono.Unix.Catalog.GetString ("Edit"), null, null);
		this.EditAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Edit");
		w1.Add (this.EditAction, null);
		this.GenerateAction = new global::Gtk.Action ("GenerateAction", global::Mono.Unix.Catalog.GetString ("Generate"), null, null);
		this.GenerateAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Generate");
		w1.Add (this.GenerateAction, null);
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpAction, null);
		this.fileAction = new global::Gtk.Action ("fileAction", null, null, "gtk-file");
		w1.Add (this.fileAction, null);
		this.openAction = new global::Gtk.Action ("openAction", null, null, "gtk-open");
		w1.Add (this.openAction, null);
		this.saveAction = new global::Gtk.Action ("saveAction", null, null, "gtk-save");
		w1.Add (this.saveAction, null);
		this.saveAsAction = new global::Gtk.Action ("saveAsAction", null, null, "gtk-save-as");
		w1.Add (this.saveAsAction, null);
		this.executeAction = new global::Gtk.Action ("executeAction", null, null, "gtk-execute");
		w1.Add (this.executeAction, null);
		this.addAction = new global::Gtk.Action ("addAction", null, null, "gtk-add");
		w1.Add (this.addAction, null);
		this.deleteAction = new global::Gtk.Action ("deleteAction", null, null, "gtk-delete");
		w1.Add (this.deleteAction, null);
		this.Action = new global::Gtk.Action ("Action", null, null, null);
		w1.Add (this.Action, null);
		this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.AboutAction, null);
		this.NewAction = new global::Gtk.Action ("NewAction", global::Mono.Unix.Catalog.GetString ("New"), null, null);
		this.NewAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("New");
		w1.Add (this.NewAction, "<Primary><Mod2>n");
		this.OpenAction = new global::Gtk.Action ("OpenAction", global::Mono.Unix.Catalog.GetString ("Open"), null, null);
		this.OpenAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open");
		w1.Add (this.OpenAction, "<Primary><Mod2>o");
		this.SaveAction = new global::Gtk.Action ("SaveAction", global::Mono.Unix.Catalog.GetString ("Save"), null, null);
		this.SaveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save");
		w1.Add (this.SaveAction, "<Primary><Mod2>s");
		this.SaveAsAction = new global::Gtk.Action ("SaveAsAction", global::Mono.Unix.Catalog.GetString ("Save As"), null, null);
		this.SaveAsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save As");
		w1.Add (this.SaveAsAction, null);
		this.refreshAction = new global::Gtk.Action ("refreshAction", null, null, "gtk-refresh");
		w1.Add (this.refreshAction, null);
		this.revertToSavedAction = new global::Gtk.Action ("revertToSavedAction", null, null, "gtk-revert-to-saved");
		w1.Add (this.revertToSavedAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("AutoSolution-EasyOS");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString (@"<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='NewAction' action='NewAction'/><menuitem name='OpenAction' action='OpenAction'/><menuitem name='SaveAction' action='SaveAction'/><menuitem name='SaveAsAction' action='SaveAsAction'/></menu><menu name='EditAction' action='EditAction'/><menu name='GenerateAction' action='GenerateAction'/><menu name='HelpAction' action='HelpAction'><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString (@"<ui><toolbar name='toolbar1'><toolitem name='fileAction' action='fileAction'/><toolitem name='openAction' action='openAction'/><toolitem name='saveAction' action='saveAction'/><toolitem name='saveAsAction' action='saveAsAction'/><toolitem name='executeAction' action='executeAction'/><toolitem name='addAction' action='addAction'/><toolitem name='deleteAction' action='deleteAction'/><toolitem name='refreshAction' action='refreshAction'/></toolbar></ui>");
		this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
		this.toolbar1.Name = "toolbar1";
		this.toolbar1.ShowArrow = false;
		this.vbox1.Add (this.toolbar1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.toolbar1]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hpaned3 = new global::Gtk.HPaned ();
		this.hpaned3.CanFocus = true;
		this.hpaned3.Name = "hpaned3";
		this.hpaned3.Position = 195;
		// Container child hpaned3.Gtk.Paned+PanedChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.treeviewGlobal = new global::Gtk.TreeView ();
		this.treeviewGlobal.CanFocus = true;
		this.treeviewGlobal.Name = "treeviewGlobal";
		this.GtkScrolledWindow.Add (this.treeviewGlobal);
		this.hpaned3.Add (this.GtkScrolledWindow);
		global::Gtk.Paned.PanedChild w5 = ((global::Gtk.Paned.PanedChild)(this.hpaned3 [this.GtkScrolledWindow]));
		w5.Resize = false;
		// Container child hpaned3.Gtk.Paned+PanedChild
		this.frmEditor = new global::Gtk.Frame ();
		this.frmEditor.Name = "frmEditor";
		this.frmEditor.ShadowType = ((global::Gtk.ShadowType)(0));
		this.frmEditor.BorderWidth = ((uint)(1));
		// Container child frmEditor.Gtk.Container+ContainerChild
		this.alignFrmEditor = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.alignFrmEditor.Name = "alignFrmEditor";
		this.alignFrmEditor.LeftPadding = ((uint)(12));
		this.frmEditor.Add (this.alignFrmEditor);
		this.lblFrmEditor = new global::Gtk.Label ();
		this.lblFrmEditor.Name = "lblFrmEditor";
		this.lblFrmEditor.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Project</b>");
		this.lblFrmEditor.UseMarkup = true;
		this.frmEditor.LabelWidget = this.lblFrmEditor;
		this.hpaned3.Add (this.frmEditor);
		this.vbox1.Add (this.hpaned3);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hpaned3]));
		w8.Position = 2;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		// Container child statusbar1.Gtk.Box+BoxChild
		this.statusBarLabel1 = new global::Gtk.Label ();
		this.statusBarLabel1.Name = "statusBarLabel1";
		this.statusBarLabel1.LabelProp = global::Mono.Unix.Catalog.GetString ("label1");
		this.statusbar1.Add (this.statusBarLabel1);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.statusbar1 [this.statusBarLabel1]));
		w9.Position = 1;
		w9.Expand = false;
		w9.Fill = false;
		// Container child statusbar1.Gtk.Box+BoxChild
		this.statusBarLabel2 = new global::Gtk.Label ();
		this.statusBarLabel2.Name = "statusBarLabel2";
		this.statusBarLabel2.LabelProp = global::Mono.Unix.Catalog.GetString ("label2");
		this.statusbar1.Add (this.statusBarLabel2);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.statusbar1 [this.statusBarLabel2]));
		w10.Position = 2;
		w10.Expand = false;
		w10.Fill = false;
		this.vbox1.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.statusbar1]));
		w11.Position = 4;
		w11.Expand = false;
		w11.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 790;
		this.DefaultHeight = 472;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.fileAction.Activated += new global::System.EventHandler (this.OnNewPrjActivated);
		this.AboutAction.Activated += new global::System.EventHandler (this.showAboutDialog);
		this.NewAction.Activated += new global::System.EventHandler (this.OnNewPrjActivated);
		this.treeviewGlobal.ButtonPressEvent += new global::Gtk.ButtonPressEventHandler (this.OnTreeViewGlobalBtnPrs);
		this.treeviewGlobal.CursorChanged += new global::System.EventHandler (this.OnTreeViewGlobalCursorChanged);
		this.treeviewGlobal.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnTreeViewGlobalKeyPress);
	}
}
