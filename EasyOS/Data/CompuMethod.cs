using System;

namespace EasyOS
{
	public class CompuMethod:BaseData
	{
		public Unit unit{get; set;}
		public CompuMethod ()
		{
		}
	}
	// RAT_FUNC in ASAM
	public class RationalFunction:CompuMethod
	{
		public RationalFunction ()
		{
			// 		(numerators[0]   + numerators[1]*PHYS   + numerators[2]*PHYS*PHYS   + ...)
			// fi(PHYS) = -----------------------------------------------------------------------------
			//		(denominators[0] + denominators[1]*PHYS + denominators[2]*PHYS*PHYS + ...)
			
			public double[] numerators{get; set;}
			public double[] denominators{get; set;}
			public RationalFunction ()
			{
			}
			
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
	}
}

