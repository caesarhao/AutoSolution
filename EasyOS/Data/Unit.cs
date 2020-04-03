using System;

namespace EasyOS
{
	public class Unit:AbstractData
	{
		public enum SIunit{
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
			exponents = new int[7];
		}
	}
}

