using System;

namespace EasyOS
{
	public class BaseData
	{
		string name{ get; set;}
		public BaseData ()
		{
		}
		override public string ToString(){
			return name;
		}
	}
}

