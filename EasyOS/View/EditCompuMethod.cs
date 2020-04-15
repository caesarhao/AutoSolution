using System;
using Gtk;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditCompuMethod : Gtk.Bin
	{
		protected ListStore lsVT;
		public EditCompuMethod ()
		{
			this.Build ();
			lsVT = new ListStore (typeof(int), typeof(string));
			this.TreeViewVT.Model = lsVT;
			TreeViewColumn tvcKey = new TreeViewColumn ();
			tvcKey.Title = "Key";
			CellRendererText cellKey = new CellRendererText ();
			tvcKey.PackStart (cellKey, true);
			tvcKey.AddAttribute (cellKey, "text", 0);

			TreeViewColumn tvcValue = new TreeViewColumn ();
			tvcValue.Title = "Value";
			CellRendererText cellValue = new CellRendererText ();
			tvcValue.PackStart (cellValue, true);
			tvcValue.AddAttribute (cellValue, "text", 1);

			this.TreeViewVT.AppendColumn (tvcKey);
			this.TreeViewVT.AppendColumn (tvcValue);
		}
		public bool LoadData(CompuMethod dat){
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;
			if (dat is RationalFunction) {
				this.notebook1.GetNthPage (0).ShowAll ();
				this.notebook1.GetNthPage (1).HideAll ();
				this.entryNumerator.Text = ((RationalFunction)dat).Numerators [0].ToString();
				this.entryNumerator1.Text = ((RationalFunction)dat).Numerators [1].ToString();
				this.entryDenominator.Text = ((RationalFunction)dat).Denominators [0].ToString();
				this.entryDenominator1.Text = ((RationalFunction)dat).Denominators [1].ToString();

			} else if (dat is VerbalTable) {
				this.notebook1.GetNthPage (0).HideAll ();
				this.notebook1.GetNthPage (1).ShowAll ();
				// clean lsVT
				lsVT.Clear();
				foreach (var item in ((VerbalTable)dat).items) {
					this.lsVT.AppendValues (item.Key, item.Value);
				}
				this.buttonDelete.Sensitive = false;
				this.buttonModify.Sensitive = false;
			} else {
			}
			return true;
		}
		public CompuMethod SaveData(CompuMethod dat){
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;
			if (dat is RationalFunction) {
				((RationalFunction)dat).Numerators [0] = Convert.ToDouble (this.entryNumerator.Text);
				((RationalFunction)dat).Numerators [1] = Convert.ToDouble (this.entryNumerator1.Text);
				((RationalFunction)dat).Denominators [0] = Convert.ToDouble (this.entryDenominator.Text);
				((RationalFunction)dat).Denominators [1] = Convert.ToDouble (this.entryDenominator1.Text);
			} else if (dat is VerbalTable) {
				
			} else {
			}
			return dat;
		}

		protected void OnTreeViewVTCursorChanged (object sender, EventArgs e)
		{
			this.buttonDelete.Sensitive = true;
			this.buttonModify.Sensitive = true;
		}

		protected void OnButtonAddClicked (object sender, EventArgs e)
		{
			Button snd = (Button)sender;
			this.textviewDebug.Buffer.Text = "Button Add clicked";
			lsVT.AppendValues (-1, "New value");
		}

		protected void OnButtonDeleteClicked (object sender, EventArgs e)
		{
			Button snd = (Button)sender;
			this.textviewDebug.Buffer.Text = "Button Delete clicked";
			AddModifyVerbalTableItem ();
		}

		protected void OnButtonModifyClicked (object sender, EventArgs e)
		{
			Button snd = (Button)sender;
			this.textviewDebug.Buffer.Text = "Button Modify clicked";
			AddModifyVerbalTableItem ();
		}
		protected int AddModifyVerbalTableItem(){
			Dialog dl = new Dialog();

			dl.SetSizeRequest (500, 200);
			VBox vb1 = new VBox ();

			dl.Add (vb1);
			vb1.Add (new Entry ());
			dl.ShowAll ();
			int resp = dl.Run();
			dl.Destroy();
			return resp;
		}
	}
}

