using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EasyOS
{
	public class Task:BaseData
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
	}
}

