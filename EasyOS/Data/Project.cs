using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

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
			author = "caesarhao";
			description = "An example";
			version = "0.1";
		}
		public override List<string> SaveToXml(){
			List<string> ret = new List<string> ();
			ret.Add ("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
			ret.Add ("<Project>");
			ret.Add ("\t<name>" + name + "</name>");
			ret.Add ("\t<description>" + description + "</description>");
			ret.Add ("\t<author>" + author + "</author>");
			ret.Add ("\t<license>" + license + "</license>");
			ret.Add ("\t<language>" + language + "</language>");
			ret.Add ("\t<target>" + target + "</target>");
			ret.Add ("\t<version>" + version + "</version>");
			ret.AddRange (Units.SaveToXml ().Select(x => "\t" + x));
			ret.AddRange (CompuMethods.SaveToXml ().Select(x => "\t" + x));
			ret.AddRange (Messages.SaveToXml ().Select(x => "\t" + x));
			ret.AddRange (Processes.SaveToXml ().Select(x => "\t" + x));
			ret.AddRange (Tasks.SaveToXml ().Select(x => "\t" + x));
			ret.AddRange (StateMachines.SaveToXml ().Select(x => "\t" + x));
			ret.Add ("</Project>");
			return ret;
		}
		public static Project ParseFromXml(XmlNode node, Project ret = null){
			if (null == ret) {
				ret = new Project ();
			}
			ret = (Project)AbstractData.ParseFromXml (node, ret);
			XmlNode cnode = null;
			cnode = node.SelectSingleNode ("author");
			if (null != cnode) {
				ret.author = cnode.InnerText;
			}
			cnode = node.SelectSingleNode ("license");
			if (null != cnode) {
				ELicense eVal;
				Enum.TryParse(cnode.InnerText, out eVal);
				ret.license = eVal;
			}
			cnode = node.SelectSingleNode ("language");
			if (null != cnode) {
				ELanguage eVal;
				Enum.TryParse(cnode.InnerText, out eVal);
				ret.language = eVal;
			}
			cnode = node.SelectSingleNode ("author");
			if (null != cnode) {
				ret.author = cnode.InnerText;
			}
			cnode = node.SelectSingleNode ("Units");
			if (null != cnode) {
				ret.Units = Group<Unit>.ParseFromXml (cnode, ret.Units);
			}
			cnode = node.SelectSingleNode ("CompuMethods");
			if (null != cnode) {
				ret.CompuMethods = Group<CompuMethod>.ParseFromXml (cnode, ret.CompuMethods);
			}
			return ret;
		}
	}
}

