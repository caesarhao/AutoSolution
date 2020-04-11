using System;
using System.Collections.Generic;
using System.ComponentModel;

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
			ret.Add ("<Task>\n");
			ret.Add ("\t<name>" + name + "</name>\n");
			ret.Add ("\t<description>" + description + "</description>\n");
			ret.Add ("</Task>\n");
			return ret;
		}
	}
}

