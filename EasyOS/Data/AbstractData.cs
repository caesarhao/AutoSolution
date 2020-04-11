using System;
using System.Collections.Generic;

namespace EasyOS
{
	public abstract class AbstractData
	{
		public string name{ get; set;}
		public string description{ get; set;}
		public AbstractData ()
		{
			name = "New" + this.GetType ().Name;
			description = "";
		}
		override public string ToString(){
			return name;
		}
//		public abstract string[] SaveToXml();
//		public abstract BaseData ParseFromXml(string[] lines);
//		public abstract string[] GenCode();
	}
}

