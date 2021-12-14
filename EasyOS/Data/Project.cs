using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

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
			E_Lang_C,
			[Description("Language C++")]
			E_Lang_Cpp,
			[Description("Language Python")]
			E_Lang_Python,
			[Description("Language Lua")]
			E_Lang_Lua
		}
		public enum ETargetType{
			[Description("General C")]
			E_C_General,
			[Description("Arduino with C")]
			E_C_Arduino,
			[Description("C EndFlag")]
			E_C_EndFlag,

			[Description("General C++")]
			E_Cpp_General,
			[Description("Arduino with C++")]
			E_Cpp_Arduino,
			[Description("ESP with C++")]
			E_Cpp_ESP,
			[Description("Cpp EndFlag")]
			E_Cpp_EndFlag,

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
			E_Lua_EndFlag
		}
		public enum EDebugInterface{
			[Description("No Debug")]
			E_NO_DEBUG,
			[Description("XCP ON CAN")]
			E_XCP_ON_CAN,
			[Description("XCP ON TCP")]
			E_XCP_ON_TCP,
			[Description("XCP ON UDP")]
			E_XCP_ON_UDP,
			[Description("XCP ON SxI")]
			E_XCP_ON_SxI,
			[Description("XCP ON USB")]
			E_XCP_ON_USB,
			[Description("XCP ON UART")]
			E_XCP_ON_UART,

		}
		public string author;
		public ELicense license;
		public ELanguage language;
		public ETargetType target;
		public string version;
		public EDebugInterface debugInterface;

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
			debugInterface = EDebugInterface.E_NO_DEBUG;
		}
		public override List<string> SaveToXml(){
			List<string> ret = new List<string> ();
			ret.Add ("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
			ret.Add ("<Project>");
			ret.Add ("\t<name>" + name + "</name>");
			ret.Add ("\t<description>" + description + "</description>");
			ret.Add ("\t<author>" + author + "</author>");
			ret.Add ("\t<license>" + license + "</license>");
			ret.Add ("\t<language>" + language + "</language>");
			ret.Add ("\t<target>" + target + "</target>");
			ret.Add ("\t<version>" + version + "</version>");
			ret.Add ("\t<debugInterface>" + debugInterface + "</debugInterface>");
			ret.AddRange (Units.SaveToXml ().Select(x => "\t" + x));
			ret.AddRange (CompuMethods.SaveToXml ().Select(x => "\t" + x));
			ret.AddRange (Messages.SaveToXml ().Select(x => "\t" + x));
			ret.AddRange (Processes.SaveToXml ().Select(x => "\t" + x));
			ret.AddRange (Tasks.SaveToXml ().Select(x => "\t" + x));
			ret.AddRange (StateMachines.SaveToXml ().Select(x => "\t" + x));
			ret.Add ("</Project>");
			return ret;
		}
		public override XElement SaveAsXml(){
			XElement xe = new XElement ("Project");
			xe.Add (new XElement ("name", name));
			xe.Add (new XElement ("description", description));
			xe.Add (new XElement ("author", author));
			xe.Add (new XElement ("license", license));
			xe.Add (new XElement ("language", language));
			xe.Add (new XElement ("target", target));
			xe.Add (new XElement ("version", version));
			xe.Add (new XElement ("debugInterface", debugInterface));
			xe.Add (Units.SaveAsXml ());
			xe.Add (CompuMethods.SaveAsXml ());
			xe.Add (Messages.SaveAsXml ());
			xe.Add (Processes.SaveAsXml ());
			xe.Add (Tasks.SaveAsXml ());
			xe.Add (StateMachines.SaveAsXml ());
			return xe;
		}
		public static Project ParseFromXml(XmlNode node, Project ret = null){
			if (null == ret) {
				ret = new Project ();
			}
			ret = (Project)AbstractData.ParseFromXml (node, ret);
			XmlNode cnode = null;
			cnode = node.SelectSingleNode ("name");
			if (null != cnode) {
				ret.name = cnode.InnerText;
			}
			cnode = node.SelectSingleNode ("description");
			if (null != cnode) {
				ret.description = cnode.InnerText;
			}
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
			cnode = node.SelectSingleNode ("target");
			if (null != cnode) {
				ETargetType eVal;
				Enum.TryParse(cnode.InnerText, out eVal);
				ret.target = eVal;
			}
			cnode = node.SelectSingleNode ("version");
			if (null != cnode) {
				ret.version = cnode.InnerText;
			}
			cnode = node.SelectSingleNode ("debugInterface");
			if (null != cnode) {
				EDebugInterface eVal;
				Enum.TryParse (cnode.InnerText, out eVal);
				ret.debugInterface = eVal;
			}
			cnode = node.SelectSingleNode ("Units");
			if (null != cnode) {
				ret.Units = Group<Unit>.ParseFromXml (cnode, ret.Units);
			}
			cnode = node.SelectSingleNode ("CompuMethods");
			if (null != cnode) {
				ret.CompuMethods = Group<CompuMethod>.ParseFromXml (cnode, ret.CompuMethods);
			}
			cnode = node.SelectSingleNode ("Messages");
			if (null != cnode) {
				ret.Messages = Group<Message>.ParseFromXml (cnode, ret.Messages);
			}
			cnode = node.SelectSingleNode ("Processes");
			if (null != cnode) {
				ret.Processes = Group<Process>.ParseFromXml (cnode, ret.Processes);
			}
			cnode = node.SelectSingleNode ("Tasks");
			if (null != cnode) {
				ret.Tasks = Group<Task>.ParseFromXml (cnode, ret.Tasks);
			}
			return ret;
		}
		public override List<string> GenA2L ()
		{
			List<string> ret = new List<string> ();
			ret.Add ("ASAP2_VERSION 1 71");
			ret.Add ("/begin PROJECT " + this.name + " " + this.LongIdentifier);

			ret.Add ("/begin HEADER " + this.LongIdentifier);
			ret.Add ("\tPROJECT_NO " + this.target.ToString());
			ret.Add ("\tVERSION " + "\"" + this.version + "\"");
			ret.Add ("/end HEADER");

			ret.Add ("/begin MODULE " + this.name + "\"\"");
			ret.Add ("/begin A2ML");
			ret.Add ("/end A2ML");

			ret.Add ("/end MODULE");

			ret.Add ("/end PROJECT");
			return ret;
		}
	}
}

