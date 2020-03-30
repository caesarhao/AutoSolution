using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace EasyOS
{
	public class Project:BaseData
	{
		public enum ELicense{
			[Description("Private project")]
			E_Private,
			[Description("Apache License 2.0")]
			E_Apache_License_2_0,
			[Description("BSD 2-Clause \"Simplified\" or \"FreeBSD\" license")]
			E_BSD_2,
			[Description("BSD 3-Clause \"New\" or \"Revised\" license")]
			E_BSD_3,
			[Description("GNU General Public License (GPL)")]
			E_GNU_GPL,
			[Description("MIT license")]
			E_MIT,
			[Description("Mozilla Public License 2.0")]
			E_MPL,
			[Description("Eclipse Public License version 2.0")]
			E_EPL
		}
		public enum ETargetType{
			[Description("General C code")]
			E_General_C = 0,
			[Description("General Python code")]
			E_General_Python = 1,
			[Description("General Lua code")]
			E_General_Lua = 2
		}
		public string author;
		public ELicense license;
		public ETargetType target;
		public string version;
		public List<StateMachine> stateMachines;
		public List<Task> tasks;
		public List<Process> processes;
		public List<Message> messages;
		public List<CompuMethod> compuMethods;
		public List<Unit> units;
		public Project ()
		{
			stateMachines = new List<StateMachine> ();
			tasks = new List<Task> ();
			processes = new List<Process> ();
			messages = new List<Message> ();
			compuMethods = new List<CompuMethod> ();
			units = new List<Unit> ();
		}
	}
}

