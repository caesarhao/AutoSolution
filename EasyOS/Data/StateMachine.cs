using System;
using System.Collections.Generic;

namespace EasyOS
{
	public class StateMachine:AbstractData
	{
		public StateMachine ()
		{
		}
		public override List<string> SaveToXml(){
			List<string> ret = new List<string> ();
			ret.Add ("<StateMachine>\n");
			ret.Add ("\t<name>" + name + "</name>\n");
			ret.Add ("\t<description>" + description + "</description>\n");
			ret.Add ("</StateMachine>\n");
			return ret;
		}
	}
}

