using System;
using System.Collections.Generic;

namespace EasyOS
{
	public class Unit:AbstractData
	{
		public enum SIunit{
			coeff,
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
		public int[] exponents;
		public Unit ()
		{
			exponents = new int[9];
			exponents [(int)SIunit.coeff] = 1;
		}
		public static List<Unit> CreateBaseUnits(){
			List<Unit> units = new List<Unit> ();
			units.Add (Unit.CreateSecond());
			units.Add (Unit.CreateMeter());
			units.Add (Unit.CreateKilogram());
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
	}
}

