using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace EasyOS
{
	public class Project:AbstractData
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
		public ELanguage language;
		public ETargetType target;
		public string version;

		public Group<Unit> Units;
		public Group<CompuMethod> CompuMethods;
		public Group<Message> Messages;
		public Group<Process> Processes;
		public Group<StateMachine> StateMachines;
		public Group<Task> Tasks;

		public Project ()
		{
			Units = new Group<Unit> ();
			CompuMethods = new Group<CompuMethod> ();
			Messages = new Group<Message> ();
			Processes = new Group<Process> ();
			StateMachines = new Group<StateMachine> ();
			Tasks = new Group<Task> ();
			version = "0.1";
		}
		public override List<string> SaveToXml(){
			List<string> ret = new List<string> ();
			ret.Add ("<Project>\n");
			ret.Add ("\t<name>" + name + "</name>\n");
			ret.Add ("\t<description>" + description + "</description>\n");
			ret.Add ("</Project>\n");
			return ret;
		}
	}
}

