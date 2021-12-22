using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace EasyOS
{
	public class Task:AbstractData
	{
		/*
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
		*/
		//public ERaster raster;
		public int raster;
		public List<Process> processes;
		public Task ()
		{
			raster = 0;
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
		public override XElement SaveAsXml(){
			XElement xe = new XElement ("Task");
			xe.Add (new XElement ("name", name));
			xe.Add (new XElement ("description", description));
			xe.Add (new XElement ("raster", raster));
			XElement xeprocesses = new XElement ("processes");
			foreach (var item in processes) {
				xeprocesses.Add (new XElement("process", item.name));
			}
			xe.Add (xeprocesses);
			return xe;
		}
		public static Task ParseFromXml(XmlNode node, Task ret = null){
			if (null == ret) {
				ret = new Task ();
			}
			ret = (Task)AbstractData.ParseFromXml (node, ret);
			XmlNode cnode = null;
			cnode = node.SelectSingleNode ("raster");
			if (null != cnode) {
				ret.raster = int.Parse(cnode.InnerText);
			}
			cnode = node.SelectSingleNode ("processes");
			if (null != cnode) {
				for (int i = 0; i < cnode.SelectNodes ("process").Count; i++) {
					XmlNode dnode = cnode.SelectNodes ("process").Item (i);
					ret.processes.Add (Group<Process>.GFindWithName (dnode.InnerText)); 
				}
			}
			return ret;
		}
		public override List<string> GenC ()
		{
			List<string> ret = new List<string> ();
			ret.Add ("/* " + this.description + " */");
			ret.Add ("void " + this.name + "()");
			ret.Add ("{");
			foreach(var item in this.processes){
				ret.Add ("\t" + item.name + "();");
			}

			ret.Add ("}");
			return ret;
		}
		public override List<string> GenA2L ()
		{
			List<string> ret = new List<string> ();

			return ret;
		}
		public static List<Task> CreateBaseTasks(){
			List<Task> ret = new List<Task> ();
			ret.Add (CreateOs10msTask ());
			return ret;
		}
		public static Task CreateOs10msTask(){
			Task tsk = new Task ();
			tsk.name = "Os10msTask";
			tsk.description = "10ms task";
			tsk.raster = 10000;
			tsk.processes.Add(Group<Process>.GFindWithName("MeasureAmbientData_Prc"));
			tsk.processes.Add(Group<Process>.GFindWithName("GetChargeState"));
			return tsk;
		}

		public static bool ValidTxtAsRaster(string txt){
			txt = txt.ToLower ().Trim ();
			Regex rx = new Regex (@"^(background|init|shutdown|[1-9][0-9]*[um]?s)$", RegexOptions.Compiled);
			Match mtc = rx.Match (txt);
			return mtc.Success;
		}
		public void RasterFromStr(string period){
			period = period.ToLower ().Trim ();
			if (period.Equals ("background")) {
				raster = 0;
			} else if (period.Equals ("init")) {
				raster = -1;
			} else if (period.Equals ("shutdown")) {
				raster = -2;
			}else {
				if (period.EndsWith ("us")) {
					raster = int.Parse (period.Substring(0, period.Length-2));
				} else if (period.EndsWith ("ms")) {
					raster = 1000 * int.Parse (period.Substring(0, period.Length-2));
				} else if (period.EndsWith ("s")) {
					raster = 1000000 * int.Parse (period.Substring(0, period.Length-1));
				} else {
					raster = 0;
				}
			}
		}
		public string RasterAsStr(){
			string ret = "background";
			if (raster == 0) {
				ret = "background";
			} else if (raster == -1) {
				ret = "init";
			} else if (raster == -2) {
				ret = "shutdown";
			} else if (raster < 1000) {
				ret = raster.ToString () + "us";
			} else if (raster >= 1000000) {
				ret = (raster / 1000000).ToString () + "s";
			} else {
				ret = (raster / 1000).ToString () + "ms";
			}
			return ret;
		}
	}
}

