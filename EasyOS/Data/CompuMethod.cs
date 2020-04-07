using System;
using System.Collections.Generic;

namespace EasyOS
{
	public class CompuMethod:AbstractData
	{
		public CompuMethod ()
		{
		}
		public static List<CompuMethod> CreateBaseCompuMethods(){
			List<CompuMethod> ret = new List<CompuMethod> ();
			ret.AddRange (RationalFunction.CreateBaseRationalFunctions ());
			ret.AddRange (VerbalTable.CreateBaseVerbalTables ());
			return ret;
		}
	}
	// RAT_FUNC in ASAM
	public class RationalFunction:CompuMethod
	{
		// 				numerators[0]    +  numerators[1]*PHYS   +	numerators[2]*PHYS*PHYS + ...
		// fi(PHYS) = ----------------------------------------------------------------------------- 
		//				denominators[0]  +  denominators[1]*PHYS +	denominators[2]*PHYS*PHYS + ...
		public double[] Numerators{get; set;}
		public double[] Denominators{get; set;}
		public RationalFunction ()
		{
			Numerators = new double[2];
			Denominators = new double[2];
		}
		public static List<RationalFunction> CreateBaseRationalFunctions(){
			List<RationalFunction> ret = new List<RationalFunction> ();
			ret.Add (CreateOneToOne());
			return ret;
		}
		public static RationalFunction CreateOneToOne(){
			RationalFunction ret = new RationalFunction ();
			ret.name = "OneToOne";
			ret.description = "Rational function one to one";
			ret.Numerators [0] = 0;
			ret.Numerators [1] = 1;
			ret.Denominators[0] = 1;
			ret.Denominators[1] = 0;
			return ret;
		}
	}
	// TAB_VERB in ASAM
	public class VerbalTable:CompuMethod
	{
		public Dictionary<int, string> vt{get; set;}
		public VerbalTable ()
		{
			vt = new Dictionary<int, string>();
		}
		public static List<VerbalTable> CreateBaseVerbalTables(){
			List<VerbalTable> ret = new List<VerbalTable> ();
			ret.Add (CreateTrueFalse ());
			ret.Add (CreateOnOff ());
			return ret;
		}
		public static VerbalTable CreateTrueFalse(){
			VerbalTable ret = new VerbalTable ();
			ret.name = "TrueFalse";
			ret.description = "True and False";
			ret.vt.Add (0, "False");
			ret.vt.Add (1, "True");
			return ret;
		}
		public static VerbalTable CreateOnOff(){
			VerbalTable ret = new VerbalTable ();
			ret.name = "OnOff";
			ret.description = "On and Off";
			ret.vt.Add (0, "Off");
			ret.vt.Add (1, "On");
			return ret;
		}
	}
}

