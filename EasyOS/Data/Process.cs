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
			ret.Add ("<Process>\n");
			ret.Add ("\t<name>" + name + "</name>\n");
			ret.Add ("\t<description>" + description + "</description>\n");
			ret.Add ("</Process>\n");
			return ret;
		}
	}
}

