using System;
using System.Collections.Generic;

namespace EasyOS
{
	public class MessageAccess{
		public Message message;
		public bool input;
		public bool output;
		public MessageAccess(){
			input = false;
			output = false;
		}
	}
	public class Process:BaseData
	{
		private List<MessageAccess> messageaccesses;

		public Process ()
		{
			messageaccesses = new List<MessageAccess> ();
		}
	}
}

