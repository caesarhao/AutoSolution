using System;

namespace EasyOS
{
	public class Message:BaseData
	{
		BaseType type{ get; set;}
		private string description{ get; set;}
		private CompMethod CompMethod{ get; set;}
		public Message ()
		{
		}
	}
}

