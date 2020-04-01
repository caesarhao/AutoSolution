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
		public enum ELanguage{
			[Description("Language C")]
			E_Lang_C = 0,
			[Description("Language Python")]
			E_Lang_Python = 1,
			[Description("Language Lua")]
			E_Lang_Lua = 2
		}
		public enum ETargetType{
			[Description("General C")]
			E_C_General,
			[Description("Arduino with C")]
			E_C_Arduino,
			[Description("C EndFlag")]
			E_C_EndFlag,
			[Description("General Python")]
			E_Python_General,
			[Description("PyS60")]
			E_Python_PyS60,
			[Description("Python EndFlag")]
			E_Python_EndFlag,
			[Description("General Lua")]
			E_Lua_General,
			[Description("NodeMCU with Lua")]
			E_Lua_NodeMCU,
			[Description("Lua EndFlag")]
			E_Lua_EndFlag,
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
			// for test
			name = "New Project";
			version = "0.1";
		}
	}
}

