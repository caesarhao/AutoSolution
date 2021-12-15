using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace EasyOS
{
	public  abstract class CompuMethod:AbstractData
	{
		public CompuMethod ()
		{
		}
		public static CompuMethod ParseFromXml(XmlNode node, CompuMethod ret = null){
			switch (node.Name) {
			case "RationalFunction":
				return RationalFunction.ParseFromXml (node, ret);
				break;
			case "VerbalTable":
				return VerbalTable.ParseFromXml (node, ret);
				break;
			default:
				return ret;
				break;
			}
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
			Numerators = new double[3];
			Numerators [0] = 0;
			Numerators [1] = 1;
			Numerators [2] = 0;
			Denominators = new double[3];
			Denominators [0] = 1;
			Denominators [1] = 0;
			Denominators [2] = 0;
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
		public override XElement SaveAsXml(){
			XElement xe = new XElement ("RationalFunction");
			xe.Add (new XElement ("name", name));
			xe.Add (new XElement ("description", description));
			xe.Add (new XElement ("Numerators", new XElement("vt", Numerators[0]), new XElement("vt", Numerators[1])));
			xe.Add (new XElement ("Denominators", new XElement("vt", Denominators[0]), new XElement("vt", Denominators[1])));
			return xe;
		}
		public static RationalFunction ParseFromXml(XmlNode node, RationalFunction ret = null){
			if (null == ret) {
				ret = new RationalFunction ();
			}
			ret = (RationalFunction)AbstractData.ParseFromXml (node, ret);
			XmlNode cnode = null;
			cnode = node.SelectSingleNode ("Numerators");
			if (null != cnode) {
				XmlNodeList dnodes = cnode.SelectNodes ("vt");
				for (int i = 0; i < dnodes.Count; i++) {
					ret.Numerators [i] = Convert.ToDouble (dnodes.Item (i).InnerText);
				}
			}
			cnode = node.SelectSingleNode ("Denominators");
			if (null != cnode) {
				XmlNodeList dnodes = cnode.SelectNodes ("vt");
				for (int i = 0; i < dnodes.Count; i++) {
					ret.Denominators [i] = Convert.ToDouble (dnodes.Item (i).InnerText);
				}
			}
			return ret;
		}
		public override List<string> GenC ()
		{
			List<string> ret = new List<string> ();
			return ret;
		}
		public override List<string> GenA2L ()
		{
			List<string> ret = new List<string> ();
			ret.Add ("/begin COMPU_METHOD");
			ret.Add (this.name);
			ret.Add (this.LongIdentifier);
			ret.Add ("RAT_FUNC");
			ret.Add ("FORMAT " + "\"%10.2\"");
			ret.Add ("\"No Unit\"");
			ret.Add ("COEFF " + this.Numerators[2] + " "
				+ this.Numerators[1] + " "
				+ this.Numerators[0] + " "
				+ this.Denominators[2] + " "
				+ this.Denominators[1] + " "
				+ this.Denominators[0] + " ");
			ret.Add ("/end COMPU_METHOD");
			return ret;
		}
		public static List<RationalFunction> CreateBaseRationalFunctions(){
			List<RationalFunction> ret = new List<RationalFunction> ();
			ret.Add (CreateOneToOne());
			ret.Add (CreateOneToTen());
			return ret;
		}
		public static RationalFunction CreateOneToOne(){
			RationalFunction ret = new RationalFunction ();
			ret.name = "OneToOne";
			ret.description = "Rational function one to one";
			ret.Numerators [0] = 0;
			ret.Numerators [1] = 1;
			ret.Numerators [2] = 0;
			ret.Denominators[0] = 1;
			ret.Denominators[1] = 0;
			ret.Denominators[2] = 0;
			return ret;
		}
		public static RationalFunction CreateOneToTen(){
			RationalFunction ret = new RationalFunction ();
			ret.name = "OneToTen";
			ret.description = "Rational function one to ten";
			ret.Numerators [0] = 0;
			ret.Numerators [1] = 10;
			ret.Numerators [2] = 0;
			ret.Denominators[0] = 1;
			ret.Denominators[1] = 0;
			ret.Denominators[2] = 0;
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
		public override XElement SaveAsXml(){
			XElement xe = new XElement ("VerbalTable");
			xe.Add (new XElement ("name", name));
			xe.Add (new XElement ("description", description));
			XElement xeitems = new XElement ("items");
			foreach (var item in items) {
				xeitems.Add (new XElement("item", new XElement("key", item.Key), new XElement("value", item.Value)));
			}
			xe.Add (xeitems);
			return xe;
		}
		public static VerbalTable ParseFromXml(XmlNode node, VerbalTable ret = null){
			if (null == ret) {
				ret = new VerbalTable ();
			}
			ret = (VerbalTable)AbstractData.ParseFromXml (node, ret);
			XmlNode cnode = null;
			cnode = node.SelectSingleNode ("items");
			if (null != cnode) {
				for (int i = 0; i < cnode.SelectNodes ("item").Count; i++) {
					XmlNode dnode = cnode.SelectNodes ("item").Item (i);
					ret.items.Add (Convert.ToInt32 (dnode.SelectSingleNode ("key").InnerText), 
						dnode.SelectSingleNode ("value").InnerText);
				}
			}
			return ret;
		}
		public override List<string> GenC ()
		{
			List<string> ret = new List<string> ();
			return ret;
		}
		public override List<string> GenA2L ()
		{
			List<string> ret = new List<string> ();
			ret.Add ("/begin COMPU_METHOD");
			ret.Add (this.name);
			ret.Add (this.LongIdentifier);
			ret.Add ("TAB_VERB");
			ret.Add ("/end COMPU_METHOD");
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

