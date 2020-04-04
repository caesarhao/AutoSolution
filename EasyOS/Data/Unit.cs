using System;

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
		public static Unit[] CreateBaseUnits(){
			Unit[] units = new Unit[1];
			units[0].name = "second";
			units[0].description = "second";
			units[0].exponents [(int)SIunit.s] = 1;
			return units;
		}
	}
}

