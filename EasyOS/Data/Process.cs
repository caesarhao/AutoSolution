using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EasyOS
{
	public class Process:BaseData
	{
		public enum EMessageAcc{
			[Description("Read")]
			E_READ,
			[Description("Write")]
			E_WRITE,
			[Description("R/W")]
			E_READWRITE
		};
		public enum ERaster{
			[Description("ONCE")]
			E_ONCE,
			[Description("1 ms")]
			E_1ms,
			[Description("10 ms")]
			E_10ms,
			[Description("100 ms")]
			E_100ms,
			[Description("1 s")]
			E_1s,
			[Description("10 s")]
			E_10s,
			[Description("100 s")]
			E_100s
		};
		public class MessageAccess{
			public Message message;
			public EMessageAcc messageacc;
		};
		public ERaster raster;
		public List<MessageAccess> messageaccesses;

		public Process ()
		{
			messageaccesses = new List<MessageAccess> ();
		}
	}
}

