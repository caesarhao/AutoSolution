using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;

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

