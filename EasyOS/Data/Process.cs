using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Linq;

namespace EasyOS
{
	public class Process:AbstractData
	{
		public List<Message> receiveMessages;
		public List<Message> sendMessages;
		public Process ()
		{
			receiveMessages = new List<Message> ();
			sendMessages = new List<Message> ();
		}
		public override List<string> SaveToXml(){
			List<string> ret = new List<string> ();
			ret.Add ("<Process>");
			ret.Add ("\t<name>" + name + "</name>");
			ret.Add ("\t<description>" + description + "</description>");
			ret.Add ("\t<receiveMessages>");
			foreach (var item in receiveMessages) {
				ret.Add ("\t\t<message>" + item.name + "</message>");
			}
			ret.Add ("\t</receiveMessages>");
			ret.Add ("\t<sendMessages>");
			foreach (var item in sendMessages) {
				ret.Add ("\t\t<message>" + item.name + "</message>");
			}
			ret.Add ("\t</sendMessages>");
			ret.Add ("</Process>");
			return ret;
		}
		public override XElement SaveAsXml(){
			XElement xe = new XElement ("Process");
			xe.Add (new XElement ("name", name));
			xe.Add (new XElement ("description", description));
			XElement xereceiveMessages = new XElement ("receiveMessages");
			foreach (var item in receiveMessages) {
				xereceiveMessages.Add (new XElement("message", item.name));
			}
			xe.Add (xereceiveMessages);
			XElement xesendMessages = new XElement ("sendMessages");
			foreach (var item in sendMessages) {
				xesendMessages.Add (new XElement("message", item.name));
			}
			xe.Add (xesendMessages);
			return xe;
		}
		public static Process ParseFromXml(XmlNode node, Process ret = null){
			if (null == ret) {
				ret = new Process ();
			}
			ret = (Process)AbstractData.ParseFromXml (node, ret);
			XmlNode cnode = null;
			cnode = node.SelectSingleNode ("receiveMessages");
			if (null != cnode) {
				for (int i = 0; i < cnode.SelectNodes ("message").Count; i++) {
					XmlNode dnode = cnode.SelectNodes ("message").Item (i);
					ret.receiveMessages.Add (Group<Message>.GFindWithName (dnode.InnerText)); 
				}
			}
			cnode = node.SelectSingleNode ("sendMessages");
			if (null != cnode) {
				for (int i = 0; i < cnode.SelectNodes ("message").Count; i++) {
					XmlNode dnode = cnode.SelectNodes ("message").Item (i);
					ret.sendMessages.Add (Group<Message>.GFindWithName (dnode.InnerText)); 
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
			ret.Add ("\t/* Create local copies of messages */");
			foreach(var item in this.receiveMessages){
				ret.Add ("\t" + item.type.ToC () + " " + item.name + ";");
			}
			foreach(var item in this.sendMessages){
				ret.Add ("\t" + item.type.ToC () + " " + item.name + ";");
			}
			foreach(var item in this.receiveMessages){
				ret.Add ("\tReceive_Msg_" + item.name + "(&" + item.name + ");");
			}
			ret.Add ("\t/* Code start here */");
			ret.Add ("\t");
			ret.Add ("\t/* Code end here */");
			foreach(var item in this.sendMessages){
				ret.Add ("\tSend_Msg_" + item.name + "(" + item.name + ");");
			}
			ret.Add ("}");
			return ret;
		}
		public override List<string> GenA2L ()
		{
			List<string> ret = new List<string> ();
			ret.Add ("/begin FUNCTION");
			ret.Add (this.name);
			ret.Add ("\"" + this.description + "\"");

			ret.Add ("/begin IN_MEASUREMENT");
			foreach (var item in receiveMessages) {
				ret.Add (item.name);
			}
			ret.Add ("/end IN_MEASUREMENT");

			ret.Add ("/begin OUT_MEASUREMENT");
			foreach (var item in sendMessages) {
				ret.Add (item.name);
			}
			ret.Add ("/end OUT_MEASUREMENT");

			ret.Add ("/end FUNCTION");
			return ret;
		}
		public static List<Process> CreateBaseProcesses(){
			List<Process> ret = new List<Process> ();
			ret.Add (CreateMeasureAmbientData ());
			ret.Add (CreateGetChargeState ());
			return ret;
		}
		public static Process CreateMeasureAmbientData(){
			Process prc = new Process ();
			prc.name = "MeasureAmbientData_Prc";
			prc.description = "measure ambient sensor data";
			prc.receiveMessages.Add(Group<Message>.GFindWithName("v_battery"));
			prc.sendMessages.Add(Group<Message>.GFindWithName("t_ambient"));
			prc.sendMessages.Add(Group<Message>.GFindWithName("p_atmosph"));
			return prc;
		}
		public static Process CreateGetChargeState(){
			Process prc = new Process ();
			prc.name = "GetChargeState";
			prc.description = "Get the charge state";
			prc.sendMessages.Add(Group<Message>.GFindWithName("st_charge"));
			return prc;
		}
	}
}

