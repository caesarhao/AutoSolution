using System;

namespace EasyOS
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class EditUnit : Gtk.Bin
	{
		public EditUnit ()
		{
			this.Build ();
		}
		public bool LoadData(AbstractData data=null){
			Unit dat = (Unit)data;
			this.entryName.Text = dat.name;
			this.entryDescription.Text = dat.description;
			this.entryShowAs.Text = dat.showAs;
			this.spin_coeff.Value = dat.exponents [(int)Unit.SIunit.coeff];
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
		public void RefreshSIunit(){
			int coeff = Convert.ToInt32(this.spin_coeff.Value);
			int ten = Convert.ToInt32(this.spin_ten.Value);
			int s = Convert.ToInt32(this.spin_s.Value);
			int m = Convert.ToInt32(this.spin_m.Value);
			int kg = Convert.ToInt32(this.spin_kg.Value);
			int A = Convert.ToInt32(this.spin_A.Value);
			int K = Convert.ToInt32(this.spin_K.Value);
			int mol = Convert.ToInt32(this.spin_mol.Value);
			int cd = Convert.ToInt32(this.spin_cd.Value);
			string unitLabel = "";
			bool alreadyStart = false;
			if (1 != coeff) {
				unitLabel += ("" + coeff);
				alreadyStart = true;
			}
			if (0 != ten) {
				if (alreadyStart)
					unitLabel += "*";
				unitLabel += ("10");
				if (1 != ten)
					unitLabel += ("^" + ten);
				alreadyStart = true;
			}
			if (0 != s) {
				if (alreadyStart)
					unitLabel += "*";
				unitLabel += ("s");
				if (1 != s)
					unitLabel += ("^" + s);
				alreadyStart = true;
			}
			if (0 != m) {
				if (alreadyStart)
					unitLabel += "*";
				unitLabel += ("m");
				if (1 != m)
					unitLabel += ("^" + m);
				alreadyStart = true;
			}
			if (0 != kg) {
				if (alreadyStart)
					unitLabel += "*";
				unitLabel += ("kg");
				if (1 != kg)
					unitLabel += ("^" + kg);
				alreadyStart = true;
			}
			if (0 != A) {
				if (alreadyStart)
					unitLabel += "*";
				unitLabel += ("A");
				if (1 != A)
					unitLabel += ("^" + A);
				alreadyStart = true;
			}
			if (0 != K) {
				if (alreadyStart)
					unitLabel += "*";
				unitLabel += ("K");
				if (1 != K)
					unitLabel += ("^" + K);
				alreadyStart = true;
			}
			if (0 != mol) {
				if (alreadyStart)
					unitLabel += "*";
				unitLabel += ("mol");
				if (1 != mol)
					unitLabel += ("^" + mol);
				alreadyStart = true;
			}
			if (0 != cd) {
				if (alreadyStart)
					unitLabel += "*";
				unitLabel += ("cd");
				if (1 != cd)
					unitLabel += ("^" + cd);
				alreadyStart = true;
			}
			this.lblSIunit.Text = unitLabel;
		}

		protected void OnSpinValueChanged (object sender, EventArgs e)
		{
			RefreshSIunit ();
		}
	}
}

