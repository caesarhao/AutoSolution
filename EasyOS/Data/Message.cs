using System;
using System.Collections.Generic;

namespace EasyOS
{
	public class Message:AbstractData
	{
		public BaseType type{ get; set;}
		public Unit unit{get; set;}
		public CompuMethod compuMethod{ get; set;}
		public Message ()
		{
		}
		public override List<string> SaveToXml(){
			List<string> ret = new List<string> ();
			ret.Add ("<Message>");
			ret.Add ("\t<name>" + name + "</name>");
			ret.Add ("\t<description>" + description + "</description>");
			ret.Add ("\t<type>" + type + "</type>");
			ret.Add ("\t<unit>" + unit.name + "</unit>");
			ret.Add ("\t<compuMethod>" + compuMethod.name + "</compuMethod>");
			ret.Add ("</Message>");
			return ret;
		}
		public static Message ParseFromXml(List<string> lines, Message ret = null){
			if (null == ret) {
				ret = new Message ();
			}
			return ret;
		}
	}
}

