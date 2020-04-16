using System;
using Gtk;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditCompuMethod : Gtk.Bin
	{
		protected CompuMethod currentCM;
		protected RationalFunction currentRF;
		protected VerbalTable currentVT;
		protected ListStore lsVT;
		public EditCompuMethod ()
		{
			this.Build ();
			lsVT = new ListStore (typeof(int), typeof(string));
			this.TreeViewVT.Model = lsVT;
			TreeViewColumn tvcKey = new TreeViewColumn ();
			tvcKey.Title = "Key";
			CellRendererText cellKey = new CellRendererText ();
			cellKey.Editable = true;
			cellKey.Edited += delegate(object o, EditedArgs args) {
				TreeIter ti;
				lsVT.GetIterFromString(out ti, args.Path);
				lsVT.SetValue(ti, 0, Convert.ToInt32(args.NewText));
				SaveData();
			};
			tvcKey.PackStart (cellKey, true);
			tvcKey.AddAttribute (cellKey, "text", 0);

			TreeViewColumn tvcValue = new TreeViewColumn ();
			tvcValue.Title = "Value";
			CellRendererText cellValue = new CellRendererText ();
			cellValue.Editable = true;
			cellValue.Edited += delegate(object o, EditedArgs args) {
				TreeIter ti;
				lsVT.GetIterFromString(out ti, args.Path);
				lsVT.SetValue(ti, 1, args.NewText);
				SaveData();
			};
			tvcValue.PackStart (cellValue, true);
			tvcValue.AddAttribute (cellValue, "text", 1);

			this.TreeViewVT.AppendColumn (tvcKey);
			this.TreeViewVT.AppendColumn (tvcValue);
		}
		public bool LoadData(CompuMethod dat){
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;
			if (dat is RationalFunction) {
				currentRF = (RationalFunction)dat;
				currentCM = dat;
				this.notebook1.GetNthPage (0).ShowAll ();
				this.notebook1.GetNthPage (1).HideAll ();
				this.entryNumerator.Text = ((RationalFunction)dat).Numerators [0].ToString();
				this.entryNumerator1.Text = ((RationalFunction)dat).Numerators [1].ToString();
				this.entryDenominator.Text = ((RationalFunction)dat).Denominators [0].ToString();
				this.entryDenominator1.Text = ((RationalFunction)dat).Denominators [1].ToString();

			} else if (dat is VerbalTable) {
				currentVT = (VerbalTable)dat;
				currentCM = dat;
				this.notebook1.GetNthPage (0).HideAll ();
				this.notebook1.GetNthPage (1).ShowAll ();
				lsVT.Clear();
				foreach (var item in ((VerbalTable)dat).items) {
					this.lsVT.AppendValues (item.Key, item.Value);
				}
				this.buttonDelete.Sensitive = false;
			} else {
			}
			return true;
		}
		public CompuMethod SaveData(CompuMethod dat=null){
			if (null == dat) {
				dat = currentCM;
			}
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;
			if (dat is RationalFunction) {
				((RationalFunction)dat).Numerators [0] = Convert.ToDouble (this.entryNumerator.Text);
				((RationalFunction)dat).Numerators [1] = Convert.ToDouble (this.entryNumerator1.Text);
				((RationalFunction)dat).Denominators [0] = Convert.ToDouble (this.entryDenominator.Text);
				((RationalFunction)dat).Denominators [1] = Convert.ToDouble (this.entryDenominator1.Text);
			} else if (dat is VerbalTable) {
				TreeIter ti;
				lsVT.GetIterFirst (out ti);
				((VerbalTable)dat).items.Clear ();
				for (int i = 0; i < lsVT.IterNChildren (); i++) {
					((VerbalTable)dat).items.Add ((int)lsVT.GetValue (ti, 0), (string)lsVT.GetValue (ti, 1));
					lsVT.IterNext (ref ti);
				}

			} else {
			}
			return dat;
		}

		protected void OnTreeViewVTCursorChanged (object sender, EventArgs e)
		{
			this.buttonDelete.Sensitive = true;
		}

		protected void OnButtonAddClicked (object sender, EventArgs e)
		{
			Button snd = (Button)sender;
			this.textviewDebug.Buffer.Text = "Button Add clicked";
			lsVT.AppendValues (-1, "New value");
			SaveData ();
		}

		protected void OnButtonDeleteClicked (object sender, EventArgs e)
		{
			Button snd = (Button)sender;
			TreeIter ti;
			TreeViewVT.Selection.GetSelected (out ti);
			lsVT.Remove (ref ti);
			SaveData ();
		}

	}
}

