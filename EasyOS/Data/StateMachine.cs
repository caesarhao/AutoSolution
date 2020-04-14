using System;
using System.Collections.Generic;
using System.Xml;

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
		public static StateMachine ParseFromXml(XmlNode node, StateMachine ret = null){
			if (null == ret) {
				ret = new StateMachine ();
			}
			ret = (StateMachine)AbstractData.ParseFromXml (node, ret);
			XmlNode cnode = null;
			cnode = node.SelectSingleNode ("showAs");
			if (null != cnode) {
				//ret.showAs = cnode.InnerText;
			}
			return ret;
		}
	}
}

