
// This file has been generated by the GUI designer. Do not modify.
namespace EasyOS
{
	public partial class EditCompuMethod
	{
		private global::Gtk.Table table1;
		
		private global::Gtk.Entry entryDescription;
		
		private global::Gtk.Entry entryName;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		
		private global::Gtk.TextView textviewDebug;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label6;
		
		private global::Gtk.Notebook notebook1;
		
		private global::Gtk.Table table2;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Entry entryNumerator2;
		
		private global::Gtk.Label label5;
		
		private global::Gtk.Entry entryNumerator1;
		
		private global::Gtk.Label label7;
		
		private global::Gtk.Entry entryNumerator;
		
		private global::Gtk.Label label10;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Entry entryDenominator2;
		
		private global::Gtk.Label label8;
		
		private global::Gtk.Entry entryDenominator1;
		
		private global::Gtk.Label label9;
		
		private global::Gtk.Entry entryDenominator;
		
		private global::Gtk.Label label11;
		
		private global::Gtk.HSeparator hseparator1;
		
		private global::Gtk.Label label4;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.HBox hbox3;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.Button buttonAdd;
		
		private global::Gtk.Button buttonDelete;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TreeView TreeViewVT;
		
		private global::Gtk.Label label3;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget EasyOS.EditCompuMethod
			global::Stetic.BinContainer.Attach (this);
			this.Name = "EasyOS.EditCompuMethod";
			// Container child EasyOS.EditCompuMethod.Gtk.Container+ContainerChild
			this.table1 = new global::Gtk.Table (((uint)(4)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(10));
			// Container child table1.Gtk.Table+TableChild
			this.entryDescription = new global::Gtk.Entry ();
			this.entryDescription.CanFocus = true;
			this.entryDescription.Name = "entryDescription";
			this.entryDescription.IsEditable = true;
			this.entryDescription.InvisibleChar = '●';
			this.table1.Add (this.entryDescription);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryDescription]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			w1.LeftAttach = ((uint)(1));
			w1.RightAttach = ((uint)(2));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.entryName = new global::Gtk.Entry ();
			this.entryName.CanFocus = true;
			this.entryName.Name = "entryName";
			this.entryName.IsEditable = true;
			this.entryName.InvisibleChar = '●';
			this.table1.Add (this.entryName);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1 [this.entryName]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.textviewDebug = new global::Gtk.TextView ();
			this.textviewDebug.CanFocus = true;
			this.textviewDebug.Name = "textviewDebug";
			this.GtkScrolledWindow1.Add (this.textviewDebug);
			this.table1.Add (this.GtkScrolledWindow1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.GtkScrolledWindow1]));
			w4.TopAttach = ((uint)(3));
			w4.BottomAttach = ((uint)(4));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Name");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label6 = new global::Gtk.Label ();
			this.label6.Name = "label6";
			this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Description");
			this.table1.Add (this.label6);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.label6]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.table2 = new global::Gtk.Table (((uint)(3)), ((uint)(3)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryNumerator2 = new global::Gtk.Entry ();
			this.entryNumerator2.WidthRequest = 5;
			this.entryNumerator2.CanFocus = true;
			this.entryNumerator2.Name = "entryNumerator2";
			this.entryNumerator2.IsEditable = true;
			this.entryNumerator2.InvisibleChar = '●';
			this.hbox1.Add (this.entryNumerator2);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryNumerator2]));
			w7.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString (" * Phy * Phy + ");
			this.hbox1.Add (this.label5);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label5]));
			w8.Position = 1;
			w8.Expand = false;
			w8.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryNumerator1 = new global::Gtk.Entry ();
			this.entryNumerator1.WidthRequest = 5;
			this.entryNumerator1.CanFocus = true;
			this.entryNumerator1.Name = "entryNumerator1";
			this.entryNumerator1.IsEditable = true;
			this.entryNumerator1.InvisibleChar = '●';
			this.hbox1.Add (this.entryNumerator1);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryNumerator1]));
			w9.Position = 2;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label7 = new global::Gtk.Label ();
			this.label7.Name = "label7";
			this.label7.LabelProp = global::Mono.Unix.Catalog.GetString (" * Phy + ");
			this.hbox1.Add (this.label7);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label7]));
			w10.Position = 3;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.entryNumerator = new global::Gtk.Entry ();
			this.entryNumerator.WidthRequest = 5;
			this.entryNumerator.CanFocus = true;
			this.entryNumerator.Name = "entryNumerator";
			this.entryNumerator.IsEditable = true;
			this.entryNumerator.InvisibleChar = '●';
			this.hbox1.Add (this.entryNumerator);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.entryNumerator]));
			w11.Position = 4;
			// Container child hbox1.Gtk.Box+BoxChild
			this.label10 = new global::Gtk.Label ();
			this.label10.Name = "label10";
			this.label10.LabelProp = global::Mono.Unix.Catalog.GetString (" * 1");
			this.hbox1.Add (this.label10);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.label10]));
			w12.Position = 5;
			w12.Expand = false;
			w12.Fill = false;
			this.table2.Add (this.hbox1);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table2 [this.hbox1]));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entryDenominator2 = new global::Gtk.Entry ();
			this.entryDenominator2.WidthRequest = 5;
			this.entryDenominator2.CanFocus = true;
			this.entryDenominator2.Name = "entryDenominator2";
			this.entryDenominator2.IsEditable = true;
			this.entryDenominator2.InvisibleChar = '●';
			this.hbox2.Add (this.entryDenominator2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.entryDenominator2]));
			w14.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label8 = new global::Gtk.Label ();
			this.label8.Name = "label8";
			this.label8.LabelProp = global::Mono.Unix.Catalog.GetString (" * Phy * Phy + ");
			this.hbox2.Add (this.label8);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label8]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entryDenominator1 = new global::Gtk.Entry ();
			this.entryDenominator1.WidthRequest = 5;
			this.entryDenominator1.CanFocus = true;
			this.entryDenominator1.Name = "entryDenominator1";
			this.entryDenominator1.IsEditable = true;
			this.entryDenominator1.InvisibleChar = '●';
			this.hbox2.Add (this.entryDenominator1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.entryDenominator1]));
			w16.Position = 2;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label9 = new global::Gtk.Label ();
			this.label9.Name = "label9";
			this.label9.LabelProp = global::Mono.Unix.Catalog.GetString (" * Phy + ");
			this.hbox2.Add (this.label9);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label9]));
			w17.Position = 3;
			w17.Expand = false;
			w17.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.entryDenominator = new global::Gtk.Entry ();
			this.entryDenominator.WidthRequest = 5;
			this.entryDenominator.CanFocus = true;
			this.entryDenominator.Name = "entryDenominator";
			this.entryDenominator.IsEditable = true;
			this.entryDenominator.InvisibleChar = '●';
			this.hbox2.Add (this.entryDenominator);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.entryDenominator]));
			w18.Position = 4;
			// Container child hbox2.Gtk.Box+BoxChild
			this.label11 = new global::Gtk.Label ();
			this.label11.Name = "label11";
			this.label11.LabelProp = global::Mono.Unix.Catalog.GetString (" * 1");
			this.hbox2.Add (this.label11);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.label11]));
			w19.Position = 5;
			w19.Expand = false;
			w19.Fill = false;
			this.table2.Add (this.hbox2);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table2 [this.hbox2]));
			w20.TopAttach = ((uint)(2));
			w20.BottomAttach = ((uint)(3));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.hseparator1 = new global::Gtk.HSeparator ();
			this.hseparator1.Name = "hseparator1";
			this.table2.Add (this.hseparator1);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table2 [this.hseparator1]));
			w21.TopAttach = ((uint)(1));
			w21.BottomAttach = ((uint)(2));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label ();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Int(Phy)=");
			this.table2.Add (this.label4);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table2 [this.label4]));
			w22.TopAttach = ((uint)(1));
			w22.BottomAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			this.notebook1.Add (this.table2);
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Rational Function");
			this.notebook1.SetTabLabel (this.table2, this.label2);
			this.label2.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
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
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.buttonAdd]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.buttonDelete = new global::Gtk.Button ();
			this.buttonDelete.Sensitive = false;
			this.buttonDelete.CanFocus = true;
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.UseUnderline = true;
			this.buttonDelete.Label = global::Mono.Unix.Catalog.GetString ("Delete");
			this.vbox1.Add (this.buttonDelete);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.buttonDelete]));
			w25.Position = 1;
			w25.Expand = false;
			w25.Fill = false;
			this.hbox3.Add (this.vbox1);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.vbox1]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.TreeViewVT = new global::Gtk.TreeView ();
			this.TreeViewVT.CanFocus = true;
			this.TreeViewVT.Name = "TreeViewVT";
			this.GtkScrolledWindow.Add (this.TreeViewVT);
			this.hbox3.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.GtkScrolledWindow]));
			w28.Position = 1;
			this.notebook1.Add (this.hbox3);
			global::Gtk.Notebook.NotebookChild w29 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.hbox3]));
			w29.Position = 1;
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Verbal Table");
			this.notebook1.SetTabLabel (this.hbox3, this.label3);
			this.label3.ShowAll ();
			this.table1.Add (this.notebook1);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table1 [this.notebook1]));
			w30.TopAttach = ((uint)(2));
			w30.BottomAttach = ((uint)(3));
			w30.LeftAttach = ((uint)(1));
			w30.RightAttach = ((uint)(2));
			this.Add (this.table1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.entryDenominator2.Changed += new global::System.EventHandler (this.OnEntryDenominator2Changed);
			this.entryDenominator1.Changed += new global::System.EventHandler (this.OnEntryDenominator1Changed);
			this.entryDenominator.Changed += new global::System.EventHandler (this.OnEntryDenominatorChanged);
			this.entryNumerator2.Changed += new global::System.EventHandler (this.OnEntryNumerator2Changed);
			this.entryNumerator1.Changed += new global::System.EventHandler (this.OnEntryNumerator1Changed);
			this.entryNumerator.Changed += new global::System.EventHandler (this.OnEntryNumeratorChanged);
			this.buttonAdd.Clicked += new global::System.EventHandler (this.OnButtonAddClicked);
			this.buttonDelete.Clicked += new global::System.EventHandler (this.OnButtonDeleteClicked);
			this.TreeViewVT.CursorChanged += new global::System.EventHandler (this.OnTreeViewVTCursorChanged);
			this.entryName.Changed += new global::System.EventHandler (this.OnEntryNameChanged);
			this.entryDescription.Changed += new global::System.EventHandler (this.OnEntryDescriptionChanged);
		}
	}
}
