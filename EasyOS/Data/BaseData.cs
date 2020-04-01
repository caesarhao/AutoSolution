using System;

namespace EasyOS
{
	public abstract class BaseData
	{
		private static List<this.GetType()> allItems = new List<this.GetType()>();
		public string name{ get; set;}
		public string description{ get; set;}
		public BaseData ()
		{
			allItems.Add(this);
		}
		public static T[] GetAll<T where T: BaseData>(){
			return (T[])allItems.ToArray();
		}
		public static T GetWithName<T where T: BaseData>(string name){
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

