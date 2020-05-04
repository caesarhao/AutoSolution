using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

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
		public abstract List<string> SaveToXml();
		public abstract XElement SaveAsXml ();
		public static AbstractData ParseFromXml(XmlNode node, AbstractData ret = null){
			if (null == ret) {
				return null;
			}
			XmlNode cnode = null;
			cnode = node.SelectSingleNode ("name");
			if (null != cnode) {
				ret.name = cnode.InnerText;
			}
			cnode = node.SelectSingleNode ("description");
			if (null != cnode) {
				ret.description = cnode.InnerText;
			}
			return ret;
		}
//		public abstract typeof(this) ParseFromXml (string[] lines);
//		public abstract string[] GenCode();
	}
}

