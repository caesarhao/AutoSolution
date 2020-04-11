using System;
using System.Collections.Generic;

namespace EasyOS
{
	public abstract class CompuMethod:AbstractData
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
		public override List<string> SaveToXml(){
			List<string> ret = new List<string> ();
			ret.Add ("<RationalFunction>");
			ret.Add ("\t<name>" + name + "</name>");
			ret.Add ("\t<description>" + description + "</description>");
			ret.Add ("\t<Numerators>");
			foreach (var item in Numerators) {
				ret.Add ("\t\t<vt>" + item + "</vt>");
			}
			ret.Add ("\t</Numerators>");
			ret.Add ("\t<Denominators>");
			foreach (var item in Denominators) {
				ret.Add ("\t\t<vt>" + item + "</vt>");
			}
			ret.Add ("\t</Denominators>");
			ret.Add ("</RationalFunction>");
			return ret;
		}
		public static RationalFunction ParseFromXml(List<string> lines, RationalFunction ret = null){
			if (null == ret) {
				ret = new RationalFunction ();
			}
			return ret;
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
		public Dictionary<int, string> items{get; set;}
		public VerbalTable ()
		{
			items = new Dictionary<int, string>();
		}
		public override List<string> SaveToXml(){
			List<string> ret = new List<string> ();
			ret.Add ("<VerbalTable>");
			ret.Add ("\t<name>" + name + "</name>");
			ret.Add ("\t<description>" + description + "</description>");
			ret.Add ("\t<items>");
			foreach (var item in items) {
				ret.Add ("\t\t<item>");
				ret.Add ("\t\t\t<key>" + item.Key + "</key>");
				ret.Add ("\t\t\t<value>" + item.Value + "</value>");
				ret.Add ("\t\t</item>");
			}
			ret.Add ("\t</items>");
			ret.Add ("</VerbalTable>");
			return ret;
		}
		public static VerbalTable ParseFromXml(List<string> lines, VerbalTable ret = null){
			if (null == ret) {
				ret = new VerbalTable ();
			}
			return ret;
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
			ret.items.Add (0, "False");
			ret.items.Add (1, "True");
			return ret;
		}
		public static VerbalTable CreateOnOff(){
			VerbalTable ret = new VerbalTable ();
			ret.name = "OnOff";
			ret.description = "On and Off";
			ret.items.Add (0, "Off");
			ret.items.Add (1, "On");
			return ret;
		}
	}
}

