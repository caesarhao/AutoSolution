using System;
using System.Collections.Generic;

namespace EasyOS
{
	public class Group<T> : AbstractData where T:AbstractData
	{
		private List<T> elements;
		private static string name4check;

		public static bool NameIsSame(T obj){
			return obj.name.Equals (name4check);
		}

		private static Predicate<T> MatchName = NameIsSame;

		public Group ()
		{
			elements = new List<T> ();
			if (typeof(T).Name.EndsWith("s")){
				this.name = typeof(T).Name + "es";

			}else{
				this.name = typeof(T).Name + "s";
			}
			this.description = "Folder for saving " + this.name;
			name4check = "dqfezfsqnlogrsn:fsdhu";
		}
		public int Count(){
			return elements.Count;
		}
		public T Find(Predicate<T> match){
			return elements.Find (match);
		}
		public T FindWithName(string name){
			name4check = name;
			return Find (MatchName);
		}
		public int FindIndex(Predicate<T> match){
			return elements.FindIndex (match);
		}
		public int FindIndexWithName(string name){
			name4check = name;
			return FindIndex (MatchName);
		}
		public List<T> FindAll(Predicate<T> match){
			return elements.FindAll (match);
		}
		public List<T> GetAll(){
			return elements;
		}
		public void Clear(){
			elements.Clear ();
		}
		public void Add(T item){
			elements.Add(item);
		}
		public void AddRange(IEnumerable<T> collection){
			elements.AddRange (collection);
		}
		public void Insert(int index, T item){
			elements.Insert (index, item);
		}
		public void InsertRange(int index, IEnumerable<T> collection){
			elements.InsertRange (index, collection);
		}
		public bool Remove(T item){
			return elements.Remove (item);
		}
		public bool RemoveWithName(string name){
			name4check = name;
			return Remove (FindWithName (name));
		}
		public void RemoveAt(int index){
			elements.RemoveAt (index);
		}
		public void RemoveRange(int index, int count){
			elements.RemoveRange(index, count);
		}
		public void RemoveAll(Predicate<T> match){
			elements.RemoveAll (match);
		}
		public void RemoveAllWithName(string name){
			name4check = name;
			elements.RemoveAll (MatchName);
		}
	}
}

