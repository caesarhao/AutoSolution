
// This file has been generated by the GUI designer. Do not modify.
namespace EasyOS
{
	public partial class EditTask
	{
		private global::Gtk.Table table1;
		
		private global::Gtk.ComboBoxEntry comboboxentryRaster;
		
		private global::Gtk.Entry entryDescription;
		
		private global::Gtk.Entry entryName;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.Button buttonAdd;
		
		private global::Gtk.Button buttonDelete;
		
		private global::Gtk.Button buttonUp;
		
		private global::Gtk.Button buttonDown;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TreeView treeviewProcesses;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.Label label7;
		
		private global::Gtk.Label label8;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget EasyOS.EditTask
			global::Stetic.BinContainer.Attach (this);
			this.Name = "EasyOS.EditTask";
			// Container child EasyOS.EditTask.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(4)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(10));
			// Container child table1.Gtk.Table+TableChild
			this.comboboxentryRaster = global::Gtk.ComboBoxEntry.NewText ();
			this.comboboxentryRaster.Name = "comboboxentryRaster";
			this.table1.Add (this.comboboxentryRaster);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.comboboxentryRaster]));
			w1.TopAttach = ((uint)(2));
			w1.BottomAttach = ((uint)(3));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryDescription = new global::Gtk.Entry ();
			this.entryDescription.CanFocus = true;
			this.entryDescription.Name = "entryDescription";
			this.entryDescription.IsEditable = true;
			this.entryDescription.InvisibleChar = '●';
			this.table1.Add (this.entryDescription);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryDescription]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryName = new global::Gtk.Entry ();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.table1.Add (this.entryName);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryName]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.buttonAdd = new global::Gtk.Button ();
			this.buttonAdd.CanFocus = true;
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.UseUnderline = true;
			this.buttonAdd.Label = global::Mono.Unix.Catalog.GetString ("Add");
			this.vbox1.Add (this.buttonAdd);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.buttonAdd]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.buttonDelete = new global::Gtk.Button ();
			this.buttonDelete.CanFocus = true;
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.UseUnderline = true;
			this.buttonDelete.Label = global::Mono.Unix.Catalog.GetString ("Delete");
			this.vbox1.Add (this.buttonDelete);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.buttonDelete]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.buttonUp = new global::Gtk.Button ();
			this.buttonUp.CanFocus = true;
			this.buttonUp.Name = "buttonUp";
			this.buttonUp.UseUnderline = true;
			this.buttonUp.Label = global::Mono.Unix.Catalog.GetString ("Up");
			this.vbox1.Add (this.buttonUp);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.buttonUp]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.buttonDown = new global::Gtk.Button ();
			this.buttonDown.CanFocus = true;
			this.buttonDown.Name = "buttonDown";
			this.buttonDown.UseUnderline = true;
			this.buttonDown.Label = global::Mono.Unix.Catalog.GetString ("Down");
			this.vbox1.Add (this.buttonDown);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.buttonDown]));
			w7.Position = 3;
			w7.Expand = false;
			w7.Fill = false;
			this.hbox1.Add (this.vbox1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox1]));
			w8.Position = 0;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.treeviewProcesses = new global::Gtk.TreeView ();
			this.treeviewProcesses.CanFocus = true;
			this.treeviewProcesses.Name = "treeviewProcesses";
			this.GtkScrolledWindow.Add (this.treeviewProcesses);
			this.hbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.GtkScrolledWindow]));
			w10.Position = 1;
			this.table1.Add (this.hbox1);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox1]));
			w11.TopAttach = ((uint)(3));
			w11.BottomAttach = ((uint)(4));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Name");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Description");
			this.table1.Add (this.label6);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.label6]));
			w13.TopAttach = ((uint)(1));
			w13.BottomAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Raster");
			this.table1.Add (this.label7);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.label7]));
			w14.TopAttach = ((uint)(2));
			w14.BottomAttach = ((uint)(3));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("Processes");
			this.table1.Add (this.label8);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.label8]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.buttonAdd.Clicked += new global::System.EventHandler (this.OnButtonAddClicked);
			this.buttonDelete.Clicked += new global::System.EventHandler (this.OnButtonDeleteClicked);
			this.buttonUp.Clicked += new global::System.EventHandler (this.OnButtonUpClicked);
			this.buttonDown.Clicked += new global::System.EventHandler (this.OnButtonDownClicked);
			this.entryName.Changed += new global::System.EventHandler (this.OnEntryNameChanged);
			this.entryDescription.Changed += new global::System.EventHandler (this.OnEntryDescriptionChanged);
			this.comboboxentryRaster.Changed += new global::System.EventHandler (this.OnCmbbeRasterChanged);
		}
	}
}
