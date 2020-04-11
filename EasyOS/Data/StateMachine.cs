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
			ret.Add ("<StateMachine>");
			ret.Add ("\t<name>" + name + "</name>");
			ret.Add ("\t<description>" + description + "</description>");
			ret.Add ("</StateMachine>");
			return ret;
		}
	}
}

