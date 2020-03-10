using System;
using System.Collections.Generic;

namespace EasyOS
{
	public class Process:BaseData
	{
		List<Variable> inVars;
		List<Variable> outVars;
		List<Variable> locVars;

		public Process ()
		{
			inVars = new List<Variable> ();
			outVars = new List<Variable> ();
			locVars = new List<Variable> ();
		}
	}
}

