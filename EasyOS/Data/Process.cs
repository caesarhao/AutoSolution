using System;
using System.Collections.Generic;
using System.ComponentModel;

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
	}
}

