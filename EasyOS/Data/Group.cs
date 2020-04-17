using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace EasyOS
{
	public class Group<T> : AbstractData where T:AbstractData
	{
		private List<T> elements;
		private static string name4check;
		public static List<T> AllItems;
		public static bool NameIsSame(T obj){
			return obj.name.Equals (name4check);
		}

		private static Predicate<T> MatchName = NameIsSame;

		public Group ()
		{
			elements = new List<T> ();
			AllItems = elements;
			if (typeof(T).Name.EndsWith("s")){
				this.name = typeof(T).Name + "es";

			}else{
				this.name = typeof(T).Name + "s";
			}
			this.description = "Folder for saving " + this.name;
			name4check = "dqfezfsqnlogrsn:fsdhu";
		}
		public override List<string> SaveToXml(){
			List<string> ret = new List<string> ();
			ret.Add ("<" + this.name + ">");
			ret.Add ("\t<description>" + description + "</description>");
			foreach (var item in elements) {
				ret.AddRange (item.SaveToXml ().Select(x => "\t" + x));
			}
			ret.Add ("</" + this.name + ">");
			return ret;
		}
		public static Group<T> ParseFromXml(XmlNode node, Group<T> ret = null){
			if (null == ret) {
				ret = new Group<T> ();
			}
			ret.elements.Clear ();
			XmlNode cnode = null;
			cnode = node.SelectSingleNode ("name");
			if (null != cnode) {
				ret.name = cnode.InnerText;
			}
			cnode = node.SelectSingleNode ("description");
			if (null != cnode) {
				ret.description = cnode.InnerText;
			}
			XmlNodeList cnodelist;
			if (typeof(T).Name.Equals ("CompuMethod")) {
				cnodelist = node.SelectNodes ("RationalFunction");
				for (int i = 0; i < cnodelist.Count; i++) {
					Group<CompuMethod>.GAdd (RationalFunction.ParseFromXml (cnodelist.Item (i)));
				}
				cnodelist = node.SelectNodes ("VerbalTable");
				for (int i = 0; i < cnodelist.Count; i++) {
					Group<CompuMethod>.GAdd (VerbalTable.ParseFromXml (cnodelist.Item (i)));
				}
			} else {
				cnodelist = node.SelectNodes (typeof(T).Name);
				for (int i = 0; i < cnodelist.Count; i++) {
					switch (typeof(T).Name) {
					case "Unit":
						Group<Unit>.GAdd (Unit.ParseFromXml(cnodelist.Item(i)));
						break;
					case "Message":
						Group<Message>.GAdd (Message.ParseFromXml (cnodelist.Item (i)));
						break;
					case "Process":
						Group<Process>.GAdd (Process.ParseFromXml (cnodelist.Item (i)));
						break;
					case "Task":
						Group<Task>.GAdd (Task.ParseFromXml (cnodelist.Item (i)));
						break;
					case "StateMachine":
						Group<StateMachine>.GAdd (StateMachine.ParseFromXml (cnodelist.Item (i)));
						break;
					default:
						break;
					}

				}
			}

			return ret;
		}
		public int Count(){
			return elements.Count;
		}
		public static int GCount(){
			return AllItems.Count;
		}
		public T Item(int index){
			return elements [index];
		}
		public static T GItem(int index){
			return AllItems [index];
		}
		public T Find(Predicate<T> match){
			return elements.Find (match);
		}
		public static T GFind(Predicate<T> match){
			return AllItems.Find (match);
		}
		public T FindWithName(string name){
			name4check = name;
			return Find (MatchName);
		}
		public static T GFindWithName(string name){
			name4check = name;
			return GFind (MatchName);
		}
		public int FindIndex(Predicate<T> match){
			return elements.FindIndex (match);
		}
		public static int GFindIndex(Predicate<T> match){
			return AllItems.FindIndex (match);
		}
		public int FindIndexWithName(string name){
			name4check = name;
			return FindIndex (MatchName);
		}
		public static int GFindIndexWithName(string name){
			name4check = name;
			return GFindIndex (MatchName);
		}
		public List<T> FindAll(Predicate<T> match){
			return elements.FindAll (match);
		}
		public static List<T> GFindAll(Predicate<T> match){
			return AllItems.FindAll (match);
		}
		public List<T> GetAll(){
			return elements;
		}
		public static List<T> GGetAll(){
			return AllItems;
		}
		public void Clear(){
			elements.Clear ();
		}
		public static void GClear(){
			AllItems.Clear ();
		}
		public void Add(T item){
			elements.Add(item);
		}
		public static void GAdd(T item){
			AllItems.Add(item);
		}
		public void AddRange(IEnumerable<T> collection){
			elements.AddRange (collection);
		}
		public static void GAddRange(IEnumerable<T> collection){
			AllItems.AddRange (collection);
		}
		public void Insert(int index, T item){
			elements.Insert (index, item);
		}
		public static void GInsert(int index, T item){
			AllItems.Insert (index, item);
		}
		public void InsertRange(int index, IEnumerable<T> collection){
			elements.InsertRange (index, collection);
		}
		public static void GInsertRange(int index, IEnumerable<T> collection){
			AllItems.InsertRange (index, collection);
		}
		public bool Remove(T item){
			return elements.Remove (item);
		}
		public static bool GRemove(T item){
			return AllItems.Remove (item);
		}
		public bool RemoveWithName(string name){
			name4check = name;
			return Remove (FindWithName (name));
		}
		public static bool GRemoveWithName(string name){
			name4check = name;
			return GRemove (GFindWithName (name));
		}
		public void RemoveAt(int index){
			elements.RemoveAt (index);
		}
		public static void GRemoveAt(int index){
			AllItems.RemoveAt (index);
		}
		public void RemoveRange(int index, int count){
			elements.RemoveRange(index, count);
		}
		public static void GRemoveRange(int index, int count){
			AllItems.RemoveRange(index, count);
		}
		public void RemoveAll(Predicate<T> match){
			elements.RemoveAll (match);
		}
		public static void GRemoveAll(Predicate<T> match){
			AllItems.RemoveAll (match);
		}
		public void RemoveAllWithName(string name){
			name4check = name;
			elements.RemoveAll (MatchName);
		}
		public static void GRemoveAllWithName(string name){
			name4check = name;
			AllItems.RemoveAll (MatchName);
		}
	}
}

