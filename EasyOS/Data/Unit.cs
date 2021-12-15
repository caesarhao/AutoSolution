using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace EasyOS
{
	public class Unit:AbstractData
	{
		public enum SIunit{
			ten,
			s,
			m,
			kg,
			A,
			K,
			mol,
			cd
		}
		public string showAs{ get; set;}
		public double coeff;
		public int[] exponents;
		public Unit ()
		{
			showAs = "-";
			exponents = new int[8];
			coeff = 1;
		}
		public bool SetName(string nom){
			if (null == Group<Unit>.GFindWithName (nom)) {
				this.name = nom;
				return true;
			} else {
				return false;
			}
		}
		public override List<string> SaveToXml(){
			List<string> ret = new List<string> ();
			ret.Add ("<Unit>");
			ret.Add ("\t<name>" + name + "</name>");
			ret.Add ("\t<description>" + description + "</description>");
			ret.Add ("\t<showAs>" + showAs + "</showAs>");
			ret.Add ("\t<coeff>" + coeff + "</coeff>");
			ret.Add ("\t<exponents>");
			foreach (var item in typeof(SIunit).GetEnumValues()) {
				ret.Add ("\t\t<"+ item.ToString() + ">" + exponents[(int)item] + "</"+ item.ToString() + ">");
			}
			ret.Add ("\t</exponents>");
			ret.Add ("</Unit>");
			return ret;
		}
		public override XElement SaveAsXml(){
			XElement xe = new XElement ("Unit");
			xe.Add (new XElement ("name", name));
			xe.Add (new XElement ("description", description));
			xe.Add (new XElement ("showAs", showAs));
			xe.Add (new XElement ("coeff", coeff));
			XElement xeexp = new XElement ("exponents");
			foreach (var item in typeof(SIunit).GetEnumValues()) {
				xeexp.Add (new XElement(item.ToString(), exponents[(int)item]));
			}
			xe.Add (xeexp);
			return xe;
		}
		public static Unit ParseFromXml(XmlNode node, Unit ret = null){
			if (null == ret) {
				ret = new Unit ();
			}
			ret = (Unit)AbstractData.ParseFromXml (node, ret);
			XmlNode cnode = null;
			cnode = node.SelectSingleNode ("showAs");
			if (null != cnode) {
				ret.showAs = cnode.InnerText;
			}
			cnode = node.SelectSingleNode ("coeff");
			if (null != cnode) {
				ret.coeff = Convert.ToDouble(cnode.InnerText);
			}
			cnode = node.SelectSingleNode ("exponents");
			if (null != cnode) {
				foreach (var item in typeof(SIunit).GetEnumValues()) {
					XmlNode dnode = cnode.SelectSingleNode (item.ToString ());
					if (null != dnode) {
						ret.exponents [(int)item] = Convert.ToInt32(dnode.InnerText);
					}
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
			ret.Add ("/begin UNIT " + this.name);
			ret.Add (this.LongIdentifier);
			ret.Add("\""+this.showAs+"\"");
			ret.Add ("EXTENDED_SI");
			ret.Add ("SI_EXPONENTS "
				+ this.exponents[(int)SIunit.m] + " "
				+ this.exponents[(int)SIunit.kg] + " "
				+ this.exponents[(int)SIunit.s] + " "
				+ this.exponents[(int)SIunit.A] + " "
				+ this.exponents[(int)SIunit.K] + " "
				+ this.exponents[(int)SIunit.mol] + " "
				+ this.exponents[(int)SIunit.cd] + " ");
			ret.Add ("/end UNIT");
			return ret;
		}
		public override bool Equals(object obj){
			if (null == obj) {
				return false;
			}
			if (!(obj is Unit)) {
				return false;
			}
			Unit unt = (Unit)obj;
			if (0 != this.coeff.CompareTo(unt.coeff)){
				return false;
			}
			foreach (var item in typeof(SIunit).GetEnumValues()) {
				if(this.exponents[(int)item] != unt.exponents[(int)item]){
					return false;
				}
			}
			return true;
		}
		public Unit Multiply(Unit obj){
			Unit ret = new Unit ();
			ret.coeff = this.coeff * obj.coeff;
			foreach (var item in typeof(SIunit).GetEnumValues()) {
				ret.exponents[(int)item] = this.exponents[(int)item] + obj.exponents[(int)item];
			}
			return ret;
		}
		public Unit Divide(Unit obj){
			Unit ret = new Unit ();
			ret.coeff = this.coeff / obj.coeff;
			foreach (var item in typeof(SIunit).GetEnumValues()) {
				ret.exponents[(int)item] = this.exponents[(int)item] - obj.exponents[(int)item];
			}
			return ret;
		}
		public static List<Unit> CreateBaseUnits(){
			List<Unit> units = new List<Unit> ();
			units.Add (Unit.CreateNone());
			units.Add (Unit.CreateSecond());
			units.Add (Unit.CreateMeter());
			units.Add (Unit.CreateKilogram());
			units.Add (Unit.CreateAmpere());
			units.Add (Unit.CreateKelvin());
			units.Add (Unit.CreateMole());
			units.Add (Unit.CreateCandela());

			units.Add (Unit.CreateRadian());
			units.Add (Unit.CreateVolt());
			units.Add (Unit.CreateOhm());
			units.Add (Unit.CreateGram());
			units.Add (Unit.CreateMinute());
			units.Add (Unit.CreateHour());
			units.Add (Unit.CreateMilliSecond());
			units.Add (Unit.CreateMicroSecond());
			units.Add (Unit.CreateNanoSecond());
			units.Add (Unit.CreateMilliMeter());
			units.Add (Unit.CreateCentiMeter());
			units.Add (Unit.CreateDeciMeter());
			units.Add (Unit.CreateHertz());
			units.Add (Unit.CreateKiloHertz());
			units.Add (Unit.CreateMegaHertz());
			units.Add (Unit.CreateGigaHertz());
			units.Add (Unit.CreateMilliAmpere());
			units.Add (Unit.CreateMicroAmpere());
			units.Add (Unit.CreateCelsius());
			units.Add (Unit.CreateFahrenheit());
			units.Add (Unit.CreatePascal());
			units.Add (Unit.CreateBar());
			return units;
		}
		public static Unit CreateNone(){
			Unit unit = new Unit();
			unit.name = "none";
			unit.description = "None";
			unit.showAs = "-";
			return unit;
		}
		public static Unit CreateSecond(){
			Unit unit = new Unit();
			unit.name = "second";
			unit.description = "second";
			unit.showAs = "s";
			unit.exponents [(int)SIunit.s] = 1;
			return unit;
		}
		public static Unit CreateMeter(){
			Unit unit = new Unit();
			unit.name = "meter";
			unit.description = "meter";
			unit.showAs = "m";
			unit.exponents [(int)SIunit.m] = 1;
			return unit;
		}
		public static Unit CreateKilogram(){
			Unit unit = new Unit();
			unit.name = "kilogram";
			unit.description = "kilogram";
			unit.showAs = "kg";
			unit.exponents [(int)SIunit.kg] = 1;
			return unit;
		}
		public static Unit CreateAmpere(){
			Unit unit = new Unit();
			unit.name = "ampere";
			unit.description = "ampere";
			unit.showAs = "A";
			unit.exponents [(int)SIunit.A] = 1;
			return unit;
		}
		public static Unit CreateKelvin(){
			Unit unit = new Unit();
			unit.name = "kelvin";
			unit.description = "kelvin";
			unit.showAs = "K";
			unit.exponents [(int)SIunit.K] = 1;
			return unit;
		}
		public static Unit CreateMole(){
			Unit unit = new Unit();
			unit.name = "mole";
			unit.description = "mole";
			unit.showAs = "mol";
			unit.exponents [(int)SIunit.mol] = 1;
			return unit;
		}
		public static Unit CreateCandela(){
			Unit unit = new Unit();
			unit.name = "candela";
			unit.description = "Candela";
			unit.showAs = "cd";
			unit.exponents [(int)SIunit.cd] = 1;
			return unit;
		}
		public static Unit CreateRadian(){
			Unit unit = new Unit();
			unit.name = "radian";
			unit.description = "Radian";
			unit.showAs = "rad";
			return unit;
		}
		public static Unit CreateVolt(){
			Unit unit = new Unit();
			unit.name = "volt";
			unit.description = "Volt";
			unit.showAs = "V";
			unit.exponents [(int)SIunit.kg] = 1;
			unit.exponents [(int)SIunit.m] = 2;
			unit.exponents [(int)SIunit.s] = -3;
			unit.exponents [(int)SIunit.A] = -1;
			return unit;
		}
		public static Unit CreateOhm(){
			Unit unit = new Unit();
			unit.name = "ohm";
			unit.description = "Ohm";
			unit.showAs = "Ω";
			unit.exponents [(int)SIunit.kg] = 1;
			unit.exponents [(int)SIunit.m] = 2;
			unit.exponents [(int)SIunit.s] = -3;
			unit.exponents [(int)SIunit.A] = -2;
			return unit;
		}
		public static Unit CreateGram(){
			Unit unit = new Unit();
			unit.name = "gram";
			unit.description = "Gram";
			unit.showAs = "g";
			unit.exponents [(int)SIunit.ten] = -3;
			unit.exponents [(int)SIunit.kg] = 1;
			return unit;
		}
		public static Unit CreateMinute(){
			Unit unit = new Unit();
			unit.name = "minute";
			unit.description = "Minute";
			unit.showAs = "min";
			unit.coeff = 6;
			unit.exponents [(int)SIunit.ten] = 1;
			unit.exponents [(int)SIunit.s] = 1;
			return unit;
		}
		public static Unit CreateHour(){
			Unit unit = new Unit();
			unit.name = "hour";
			unit.description = "Hour";
			unit.showAs = "hour";
			unit.coeff = 3.6;
			unit.exponents [(int)SIunit.ten] = 3;
			unit.exponents [(int)SIunit.s] = 1;
			return unit;
		}
		public static Unit CreateMilliSecond(){
			Unit unit = new Unit();
			unit.name = "millisecond";
			unit.description = "Millisecond";
			unit.showAs = "ms";
			unit.exponents [(int)SIunit.ten] = -3;
			unit.exponents [(int)SIunit.s] = 1;
			return unit;
		}
		public static Unit CreateMicroSecond(){
			Unit unit = new Unit();
			unit.name = "microsecond";
			unit.description = "Microsecond";
			unit.showAs = "μs";
			unit.exponents [(int)SIunit.ten] = -6;
			unit.exponents [(int)SIunit.s] = 1;
			return unit;
		}
		public static Unit CreateNanoSecond(){
			Unit unit = new Unit();
			unit.name = "nanosecond";
			unit.description = "Nanosecond";
			unit.showAs = "ns";
			unit.exponents [(int)SIunit.ten] = -9;
			unit.exponents [(int)SIunit.s] = 1;
			return unit;
		}
		public static Unit CreateMilliMeter(){
			Unit unit = new Unit();
			unit.name = "millimeter";
			unit.description = "MilliMeter";
			unit.showAs = "mm";
			unit.exponents [(int)SIunit.ten] = -3;
			unit.exponents [(int)SIunit.m] = 1;
			return unit;
		}
		public static Unit CreateCentiMeter(){
			Unit unit = new Unit();
			unit.name = "centimeter";
			unit.description = "CentiMeter";
			unit.showAs = "cm";
			unit.exponents [(int)SIunit.ten] = -2;
			unit.exponents [(int)SIunit.m] = 1;
			return unit;
		}
		public static Unit CreateDeciMeter(){
			Unit unit = new Unit();
			unit.name = "decimeter";
			unit.description = "DeciMeter";
			unit.showAs = "dm";
			unit.exponents [(int)SIunit.ten] = -1;
			unit.exponents [(int)SIunit.m] = 1;
			return unit;
		}
		public static Unit CreateHertz(){
			Unit unit = new Unit();
			unit.name = "hertz";
			unit.description = "Hertz";
			unit.showAs = "Hz";
			unit.exponents [(int)SIunit.s] = -1;
			return unit;
		}
		public static Unit CreateKiloHertz(){
			Unit unit = new Unit();
			unit.name = "kilohertz";
			unit.description = "KiloHertz";
			unit.showAs = "kHz";
			unit.exponents [(int)SIunit.ten] = 3;
			unit.exponents [(int)SIunit.s] = -1;
			return unit;
		}
		public static Unit CreateMegaHertz(){
			Unit unit = new Unit();
			unit.name = "megahertz";
			unit.description = "MegaHertz";
			unit.showAs = "MHz";
			unit.exponents [(int)SIunit.ten] = 6;
			unit.exponents [(int)SIunit.s] = -1;
			return unit;
		}
		public static Unit CreateGigaHertz(){
			Unit unit = new Unit();
			unit.name = "gigahertz";
			unit.description = "GigaHertz";
			unit.showAs = "GHz";
			unit.exponents [(int)SIunit.ten] = 9;
			unit.exponents [(int)SIunit.s] = -1;
			return unit;
		}
		public static Unit CreateMilliAmpere(){
			Unit unit = new Unit();
			unit.name = "milliampere";
			unit.description = "MilliAmpere";
			unit.showAs = "mA";
			unit.exponents [(int)SIunit.ten] = -3;
			unit.exponents [(int)SIunit.A] = 1;
			return unit;
		}
		public static Unit CreateMicroAmpere(){
			Unit unit = new Unit();
			unit.name = "microampere";
			unit.description = "MicroAmpere";
			unit.showAs = "µA";
			unit.exponents [(int)SIunit.ten] = -6;
			unit.exponents [(int)SIunit.A] = 1;
			return unit;
		}
		public static Unit CreateCelsius(){
			Unit unit = new Unit();
			unit.name = "Celsius";
			unit.description = "Temperature in Celsius";
			unit.showAs = "°C";
			unit.exponents [(int)SIunit.K] = 1;
			return unit;
		}
		public static Unit CreateFahrenheit(){
			Unit unit = new Unit();
			unit.name = "Fahrenheit";
			unit.description = "Temperature in Fahrenheit";
			unit.showAs = "°F";
			unit.coeff = 5.5555556;
			unit.exponents [(int)SIunit.ten] = -1;
			unit.exponents [(int)SIunit.K] = 1;
			return unit;
		}
		public static Unit CreatePascal(){
			Unit unit = new Unit();
			unit.name = "Pascal";
			unit.description = "Pressure in Pascal";
			unit.showAs = "Pa";
			unit.exponents [(int)SIunit.s] = -2;
			unit.exponents [(int)SIunit.m] = -1;
			unit.exponents [(int)SIunit.kg] = 1;
			return unit;
		}
		public static Unit CreateBar(){
			Unit unit = new Unit();
			unit.name = "Bar";
			unit.description = "Pressure in bar";
			unit.showAs = "bar";
			unit.exponents [(int)SIunit.ten] = 5;
			unit.exponents [(int)SIunit.s] = -2;
			unit.exponents [(int)SIunit.m] = -1;
			unit.exponents [(int)SIunit.kg] = 1;
			return unit;
		}
	}
}

