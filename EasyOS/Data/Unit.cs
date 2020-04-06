using System;
using System.Collections.Generic;

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
			exponents = new int[8];
			coeff = 1;
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
			return units;
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
	}
}

