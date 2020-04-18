﻿using System;
using System.Collections.Generic;
using System.Xml;

namespace EasyOS
{
	public class Message:AbstractData
	{
		public BaseType type{ get; set;}
		public Unit unit{get; set;}
		public CompuMethod compuMethod{ get; set;}
		public Message ()
		{
		}
		public override List<string> SaveToXml(){
			List<string> ret = new List<string> ();
			ret.Add ("<Message>");
			ret.Add ("\t<name>" + name + "</name>");
			ret.Add ("\t<description>" + description + "</description>");
			ret.Add ("\t<type>" + type + "</type>");
			ret.Add ("\t<unit>" + unit.name + "</unit>");
			ret.Add ("\t<compuMethod>" + compuMethod.name + "</compuMethod>");
			ret.Add ("</Message>");
			return ret;
		}
		public static Message ParseFromXml(XmlNode node, Message ret = null){
			if (null == ret) {
				ret = new Message ();
			}
			ret = (Message)AbstractData.ParseFromXml (node, ret);
			XmlNode cnode = null;
			cnode = node.SelectSingleNode ("type");
			if (null != cnode) {
				BaseType eval;
				Enum.TryParse (cnode.InnerText, out eval);
				ret.type = eval;
			}
			cnode = node.SelectSingleNode ("unit");
			if (null != cnode) {
				ret.unit = Group<Unit>.GFindWithName (cnode.InnerText);
			}
			return ret;
		}
		public static List<Message> CreateBaseMessages(){
			List<Message> ret = new List<Message> ();
			ret.Add (CreateAmbientTemperature ());
			ret.Add (CreateAtmosphericPressure ());
			return ret;
		}
		public static Message CreateAmbientTemperature(){
			Message msg = new Message ();
			msg.name = "t_ambient";
			msg.description = "Ambient temperature in Celsius";
			msg.type = BaseType.SINT32;
			msg.unit = Group<Unit>.GFindWithName ("Celsius");
			msg.compuMethod = Group<CompuMethod>.GFindWithName ("OneToOne");
			return msg;
		}
		public static Message CreateAtmosphericPressure(){
			Message msg = new Message ();
			msg.name = "p_atmosph";
			msg.description = "Atmospheric pressure in Pascal";
			msg.type = BaseType.UINT32;
			msg.unit = Group<Unit>.GFindWithName ("Pascal");
			msg.compuMethod = Group<CompuMethod>.GFindWithName ("OneToOne");
			return msg;
		}
	}
}

