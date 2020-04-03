using System;
using System.Collections.Generic;

namespace EasyOS
{
	public abstract class AbstractData
	{
		private static List<AbstractData> allItems = new List<AbstractData> ();
		public string name{ get; set;}
		public string description{ get; set;}
		public AbstractData ()
		{
			if (null == allItems) {
				allItems = new List<AbstractData> ();
			}
			allItems.Add(this);
		}
		public static T[] GetAll<T>() where T: AbstractData{
			return (T[])allItems.ToArray();
		}
		public static T GetWithName<T >(string name)where T: AbstractData{
			foreach(var item in allItems){
				if (name.CompareTo(item.name) == 0){
					return (T)item;
				}
			}
			return null;
		}
		override public string ToString(){
			return name;
		}
//		public abstract string[] SaveToXml();
//		public abstract BaseData ParseFromXml(string[] lines);
//		public abstract string[] GenCode();
	}
}

