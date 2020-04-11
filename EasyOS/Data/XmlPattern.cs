using System;

namespace EasyOS
{
	public class XmlPattern
	{
		public XmlPattern ()
		{
		}
		public static bool MatchTag(string line, string tag){
			line = line.Trim();
			return (line.StartsWith ("<" + tag + ">") && line.EndsWith ("</" + tag + ">"));
		}
		public static string RetrieveData(string line, string tag){
			line = line.Trim();
			line = line.Substring (tag.Length + 2);
			line = line.Substring (0, line.Length - (tag.Length + 3));
			return line;
		}
		public static string RetrieveTag(string line){
			line = line.Trim();
			int start = line.IndexOf ("<") + 1;
			int end = line.IndexOf (">");
			return line.Substring(start, (end - start));
		}
		public static string RetrieveData(string line){
			return RetrieveData(line, RetrieveTag(line));
		}
	}
}

