using System;
using System.Xml;

namespace EasyOS
{
	public class XmlHelper
	{
		private XmlDocument xml;

		public XmlHelper ()
		{
			xml = new XmlDocument ();
		}
		public void LoadLines (string lines)
		{
			xml.LoadXml (lines);
		}
		public void LoadFile (string filename)
		{
			xml.Load (filename);
		}
	}
}

