using System;
using Gtk;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditUnit : Gtk.Bin
	{
		private Unit currentUnt;
		public EditUnit ()
		{
			this.Build ();

		}
		public bool LoadData(Unit dat){
			currentUnt = dat;
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;
			this.entryShowAs.Text = dat.showAs;
			this.spin_coeff.Value = dat.coeff;
			this.spin_ten.Value = dat.exponents [(int)Unit.SIunit.ten];
			this.spin_s.Value = dat.exponents [(int)Unit.SIunit.s];
			this.spin_m.Value = dat.exponents [(int)Unit.SIunit.m];
			this.spin_kg.Value = dat.exponents [(int)Unit.SIunit.kg];
			this.spin_A.Value = dat.exponents [(int)Unit.SIunit.A];
			this.spin_K.Value = dat.exponents [(int)Unit.SIunit.K];
			this.spin_mol.Value = dat.exponents [(int)Unit.SIunit.mol];
			this.spin_cd.Value = dat.exponents [(int)Unit.SIunit.cd];
			RefreshSIunit ();
			return true;
		}
		public Unit SaveData(Unit dat=null){
			if (null == dat) {
				dat = currentUnt;
			}
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;
			dat.showAs=this.entryShowAs.Text;
			dat.coeff=this.spin_coeff.Value;
			dat.exponents [(int)Unit.SIunit.ten]=this.spin_ten.ValueAsInt;
			dat.exponents [(int)Unit.SIunit.s]=this.spin_s.ValueAsInt;
			dat.exponents [(int)Unit.SIunit.m]=this.spin_m.ValueAsInt;
			dat.exponents [(int)Unit.SIunit.kg]=this.spin_kg.ValueAsInt;
			dat.exponents [(int)Unit.SIunit.A]=this.spin_A.ValueAsInt;
			dat.exponents [(int)Unit.SIunit.K]=this.spin_K.ValueAsInt;
			dat.exponents [(int)Unit.SIunit.mol]=this.spin_mol.ValueAsInt;
			dat.exponents [(int)Unit.SIunit.cd]=this.spin_cd.ValueAsInt;
			return dat;
		}
		public void RefreshSIunit(){
			double coeff = this.spin_coeff.Value;
			int ten = this.spin_ten.ValueAsInt;
			int s = this.spin_s.ValueAsInt;
			int m = this.spin_m.ValueAsInt;
			int kg = this.spin_kg.ValueAsInt;
			int A = this.spin_A.ValueAsInt;
			int K = this.spin_K.ValueAsInt;
			int mol = this.spin_mol.ValueAsInt;
			int cd = this.spin_cd.ValueAsInt;
			string unitLabel = "";
			bool alreadyStart = false;
			if (0 != coeff.CompareTo(1)) {
				unitLabel += ("" + coeff);
				alreadyStart = true;
			}
			if (0 != ten) {
				if (alreadyStart)
					unitLabel += "*";
				unitLabel += ("10");
				if (1 != ten)
					unitLabel += ("<sup>" + ten + "</sup>");
				alreadyStart = true;
			}
			if (0 != s) {
				if (alreadyStart)
					unitLabel += "*";
				unitLabel += ("s");
				if (1 != s)
					unitLabel += ("<sup>" + s + "</sup>");
				alreadyStart = true;
			}
			if (0 != m) {
				if (alreadyStart)
					unitLabel += "*";
				unitLabel += ("m");
				if (1 != m)
					unitLabel += ("<sup>" + m + "</sup>");
				alreadyStart = true;
			}
			if (0 != kg) {
				if (alreadyStart)
					unitLabel += "*";
				unitLabel += ("kg");
				if (1 != kg)
					unitLabel += ("<sup>" + kg + "</sup>");
				alreadyStart = true;
			}
			if (0 != A) {
				if (alreadyStart)
					unitLabel += "*";
				unitLabel += ("A");
				if (1 != A)
					unitLabel += ("<sup>" + A + "</sup>");
				alreadyStart = true;
			}
			if (0 != K) {
				if (alreadyStart)
					unitLabel += "*";
				unitLabel += ("K");
				if (1 != K)
					unitLabel += ("<sup>" + K + "</sup>");
				alreadyStart = true;
			}
			if (0 != mol) {
				if (alreadyStart)
					unitLabel += "*";
				unitLabel += ("mol");
				if (1 != mol)
					unitLabel += ("<sup>" + mol + "</sup>");
				alreadyStart = true;
			}
			if (0 != cd) {
				if (alreadyStart)
					unitLabel += "*";
				unitLabel += ("cd");
				if (1 != cd)
					unitLabel += ("<sup>" + cd + "</sup>");
				alreadyStart = true;
			}
			this.lblSIunit.Markup = unitLabel;
		}

		protected void OnSpinValueChanged (object sender, EventArgs e)
		{
			RefreshSIunit ();
			switch (((SpinButton)sender).Name) {
			case "spin_coeff":
				currentUnt.coeff = this.spin_coeff.Value;
				break;
			case "spin_ten":
				currentUnt.exponents [(int)Unit.SIunit.ten] = this.spin_ten.ValueAsInt;
				break;
			case "spin_s":
				currentUnt.exponents [(int)Unit.SIunit.s] = this.spin_s.ValueAsInt;
				break;
			case "spin_m":
				currentUnt.exponents [(int)Unit.SIunit.m] = this.spin_m.ValueAsInt;
				break;
			case "spin_kg":
				currentUnt.exponents [(int)Unit.SIunit.kg] = this.spin_kg.ValueAsInt;
				break;
			case "spin_A":
				currentUnt.exponents [(int)Unit.SIunit.A] = this.spin_A.ValueAsInt;
				break;
			case "spin_K":
				currentUnt.exponents [(int)Unit.SIunit.K] = this.spin_K.ValueAsInt;
				break;
			case "spin_mol":
				currentUnt.exponents [(int)Unit.SIunit.mol] = this.spin_mol.ValueAsInt;
				break;
			case "spin_cd":
				currentUnt.exponents [(int)Unit.SIunit.cd] = this.spin_cd.ValueAsInt;
				break;
			default:
				break;
			}

		}

		protected void OnEntryNameChanged (object sender, EventArgs e)
		{
			string nom = ((Entry)sender).Text;
			TreeStore ts = MainWindow.MW.ts;
			TreeIter ti;
			MainWindow.MW.GetTreeViewGlobal().Selection.GetSelected(out ti);
			if (currentUnt.SetName (nom)) {
				ts.SetValue (ti, 0, ((Entry)sender).Text);
			} else {
				((Entry)sender).Text = currentUnt.name;
			}
		}

		protected void OnEntryDescriptionChanged (object sender, EventArgs e)
		{
			currentUnt.description = ((Entry)sender).Text;
		}

		protected void OnEntryShowAsChanged (object sender, EventArgs e)
		{
			currentUnt.showAs = ((Entry)sender).Text;
		}
	}
}

