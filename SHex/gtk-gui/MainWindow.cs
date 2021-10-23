
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	
	private global::Gtk.Action FileAction;
	
	private global::Gtk.Action openAction;
	
	private global::Gtk.Action saveAction;
	
	private global::Gtk.Action EditAction;
	
	private global::Gtk.Action HelpAction;
	
	private global::Gtk.Action OpenAction;
	
	private global::Gtk.Action AboutAction;
	
	private global::Gtk.Action SaveAsAction;
	
	private global::Gtk.Action SaveAction;
	
	private global::Gtk.Action SaveAction1;
	
	private global::Gtk.Action saveAsAction;
	
	private global::Gtk.VBox vbox_main;
	
	private global::Gtk.MenuBar menubar1;
	
	private global::Gtk.Toolbar toolbar1;
	
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	
	private global::Gtk.TextView textview_debug;
	
	private global::Gtk.Statusbar statusbar1;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("_File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_File");
		w1.Add (this.FileAction, "<Alt><Mod2>f");
		this.openAction = new global::Gtk.Action ("openAction", global::Mono.Unix.Catalog.GetString ("_Open"), null, "gtk-open");
		this.openAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Open");
		w1.Add (this.openAction, null);
		this.saveAction = new global::Gtk.Action ("saveAction", global::Mono.Unix.Catalog.GetString ("_Save"), null, "gtk-save");
		this.saveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Save");
		w1.Add (this.saveAction, null);
		this.EditAction = new global::Gtk.Action ("EditAction", global::Mono.Unix.Catalog.GetString ("_Edit"), null, null);
		this.EditAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Edit");
		w1.Add (this.EditAction, null);
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("_Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Help");
		w1.Add (this.HelpAction, "<Alt><Mod2>h");
		this.OpenAction = new global::Gtk.Action ("OpenAction", global::Mono.Unix.Catalog.GetString ("_Open"), null, null);
		this.OpenAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("_Open");
		w1.Add (this.OpenAction, "<Primary><Mod2>o");
		this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.AboutAction, null);
		this.SaveAsAction = new global::Gtk.Action ("SaveAsAction", global::Mono.Unix.Catalog.GetString ("Save As..."), null, null);
		this.SaveAsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save As...");
		w1.Add (this.SaveAsAction, null);
		this.SaveAction = new global::Gtk.Action ("SaveAction", global::Mono.Unix.Catalog.GetString ("Save"), null, null);
		this.SaveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save");
		w1.Add (this.SaveAction, null);
		this.SaveAction1 = new global::Gtk.Action ("SaveAction1", global::Mono.Unix.Catalog.GetString ("_Save"), null, null);
		this.SaveAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save");
		w1.Add (this.SaveAction1, null);
		this.saveAsAction = new global::Gtk.Action ("saveAsAction", null, null, "gtk-save-as");
		w1.Add (this.saveAsAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox_main = new global::Gtk.VBox ();
		this.vbox_main.Name = "vbox_main";
		this.vbox_main.Spacing = 6;
		// Container child vbox_main.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString (@"<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='OpenAction' action='OpenAction'/><menuitem name='SaveAction1' action='SaveAction1'/><menuitem name='SaveAsAction' action='SaveAsAction'/></menu><menu name='EditAction' action='EditAction'/><menu name='HelpAction' action='HelpAction'><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox_main.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox_main [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox_main.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name=\'toolbar1\'><toolitem name=\'openAction\' action=\'openAction\'/><to" +
		"olitem name=\'saveAction\' action=\'saveAction\'/><toolitem name=\'saveAsAction\' acti" +
		"on=\'saveAsAction\'/></toolbar></ui>");
		this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
		this.toolbar1.Name = "toolbar1";
		this.toolbar1.ShowArrow = false;
		this.vbox_main.Add (this.toolbar1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox_main [this.toolbar1]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox_main.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.textview_debug = new global::Gtk.TextView ();
		this.textview_debug.Buffer.Text = "haha";
		this.textview_debug.CanFocus = true;
		this.textview_debug.Name = "textview_debug";
		this.textview_debug.WrapMode = ((global::Gtk.WrapMode)(3));
		this.GtkScrolledWindow.Add (this.textview_debug);
		this.vbox_main.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox_main [this.GtkScrolledWindow]));
		w5.Position = 2;
		// Container child vbox_main.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		this.vbox_main.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox_main [this.statusbar1]));
		w6.Position = 3;
		w6.Expand = false;
		w6.Fill = false;
		this.Add (this.vbox_main);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 590;
		this.DefaultHeight = 446;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.openAction.Activated += new global::System.EventHandler (this.OnOpen);
		this.saveAction.Activated += new global::System.EventHandler (this.OnSave);
		this.OpenAction.Activated += new global::System.EventHandler (this.OnOpen);
		this.saveAsAction.Activated += new global::System.EventHandler (this.OnSaveAs);
		this.textview_debug.PasteClipboard += new global::System.EventHandler (this.OnTextviewDebugPasteClipboard);
	}
}
