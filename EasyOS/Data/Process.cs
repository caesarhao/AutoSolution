using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EasyOS
{
	public class Process:BaseData
	{
		public List<Message> receiveMessages;
		public List<Message> sendMessages;
		public Process ()
		{
			receiveMessages = new List<Message> ();
			sendMessages = new List<Message> ();
		}
	}
}

