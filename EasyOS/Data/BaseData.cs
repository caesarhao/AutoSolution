﻿using System;

namespace EasyOS
{
	public abstract class BaseData
	{
		public string name{ get; set;}
		public BaseData ()
		{
		}
		override public string ToString(){
			return name;
		}
	}
}

