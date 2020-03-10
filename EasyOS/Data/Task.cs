using System;
using System.Collections.Generic;

namespace EasyOS
{
	public class Task:BaseData
	{
		List<Process> procs;
		public Task ()
		{
			procs = new List<Process> ();
		}
	}
}

