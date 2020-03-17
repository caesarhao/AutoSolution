using System;
using System.Collections.Generic;

namespace EasyOS
{
	public class Task:BaseData
	{
		List<Process> processes;
		public Task ()
		{
			processes = new List<Process> ();
		}
	}
}

