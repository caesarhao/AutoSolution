using System;
using System.Collections.Generic;

namespace EasyOS
{
	public class Group<T> : AbstractData where T:AbstractData
	{
		public List<T> elements;
		public Group ()
		{
			elements = new List<T> ();
			this.name = typeof(T).Name;
		}
	}
}

