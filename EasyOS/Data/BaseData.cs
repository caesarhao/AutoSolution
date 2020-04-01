using System;
using System.Collections.Generic;

namespace EasyOS
{
	public abstract class BaseData
	{
		private static List<BaseData> allItems = new List<BaseData> ();
		public string name{ get; set;}
		public string description{ get; set;}
		public BaseData ()
		{
			if (null == allItems) {
				allItems = new List<BaseData> ();
			}
			allItems.Add(this);
		}
		public static T[] GetAll<T>() where T: BaseData{
			return (T[])allItems.ToArray();
		}
		public static T GetWithName<T >(string name)where T: BaseData{
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

