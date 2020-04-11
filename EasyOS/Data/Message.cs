using System;
using System.Collections.Generic;

namespace EasyOS
{
	public class Message:AbstractData
	{
		public BaseType type{ get; set;}
		public string unit{get; set;}
		//public CompuMethod compuMethod{ get; set;}
		public Message ()
		{
		}
		public override List<string> SaveToXml(){
			List<string> ret = new List<string> ();
			ret.Add ("<Message>\n");
			ret.Add ("\t<name>" + name + "</name>\n");
			ret.Add ("\t<description>" + description + "</description>\n");
			ret.Add ("</Message>\n");
			return ret;
		}
	}
}

