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
			if (typeof(T).Name.EndsWith("s")){
				this.name = typeof(T).Name + "es";

			}else{
				this.name = typeof(T).Name + "s";
			}
			this.description = "Folder for saving " + this.name;
		}
		public void AddRange(IEnumerable<T> collection){
			elements.AddRange (collection);
		}
	}
}

