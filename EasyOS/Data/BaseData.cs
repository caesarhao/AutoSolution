using System;

namespace EasyOS
{
	public abstract class BaseData
	{
		public string shortName{ get; set;}
		public string description{ get; set;}
		public BaseData ()
		{
		}
		override public string ToString(){
			return shortName;
		}
	}
}

