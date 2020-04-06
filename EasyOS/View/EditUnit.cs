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
		public bool LoadData(Unit dat){
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
				dat = new Unit ();
			}
			dat.name=this.entryName.Text;
			dat.description=this.entryDescription.Text;
			dat.showAs=this.entryShowAs.Text;
			dat.coeff=this.spin_coeff.Value;
			dat.exponents [(int)Unit.SIunit.ten]=Convert.ToInt32(this.spin_ten.Value);
			dat.exponents [(int)Unit.SIunit.s]=Convert.ToInt32(this.spin_s.Value);
			dat.exponents [(int)Unit.SIunit.m]=Convert.ToInt32(this.spin_m.Value);
			dat.exponents [(int)Unit.SIunit.kg]=Convert.ToInt32(this.spin_kg.Value);
			dat.exponents [(int)Unit.SIunit.A]=Convert.ToInt32(this.spin_A.Value);
			dat.exponents [(int)Unit.SIunit.K]=Convert.ToInt32(this.spin_K.Value);
			dat.exponents [(int)Unit.SIunit.mol]=Convert.ToInt32(this.spin_mol.Value);
			dat.exponents [(int)Unit.SIunit.cd]=Convert.ToInt32(this.spin_cd.Value);
			return dat;
		}
		public void RefreshSIunit(){
			double coeff = this.spin_coeff.Value;
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
		}
	}
}

