using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;

namespace EasyOS
{
	public class Task:AbstractData
	{
		public enum ERaster{
			[Description("ONCE")]
			E_ONCE,
			[Description("1 ms")]
			E_1ms,
			[Description("10 ms")]
			E_10ms,
			[Description("100 ms")]
			E_100ms,
			[Description("1 s")]
			E_1s,
			[Description("10 s")]
			E_10s,
			[Description("100 s")]
			E_100s
		};
		public ERaster raster;
		public List<Process> processes;
		public Task ()
		{
			processes = new List<Process> ();
		}
		public override List<string> SaveToXml(){
			List<string> ret = new List<string> ();
			ret.Add ("<Task>");
			ret.Add ("\t<name>" + name + "</name>");
			ret.Add ("\t<description>" + description + "</description>");
			ret.Add ("\t<raster>" + raster + "</raster>");
			ret.Add ("\t<processes>");
			foreach (var item in processes) {
				ret.Add ("\t\t<process>" + item.name + "</process>");
			}
			ret.Add ("\t</processes>");
			ret.Add ("</Task>");
			return ret;
		}
		public static Task ParseFromXml(XmlNode node, Task ret = null){
			if (null == ret) {
				ret = new Task ();
			}
			ret = (Task)AbstractData.ParseFromXml (node, ret);
			XmlNode cnode = null;
			cnode = node.SelectSingleNode ("showAs");
			if (null != cnode) {
				//ret.showAs = cnode.InnerText;
			}
			return ret;
		}
	}
}

