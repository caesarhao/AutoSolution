using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;

namespace EasyOS
{
	public class Message:AbstractData
	{
		public BaseType type{ get; set;}
		public Unit unit{get; set;}
		public CompuMethod compuMethod{ get; set;}
		public ushort arraySize{ get; set; }
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
			ret.Add("\t<arraySize>" + arraySize + "</arraySize>");
			ret.Add ("</Message>");
			return ret;
		}
		public override XElement SaveAsXml(){
			XElement xe = new XElement ("Message");
			xe.Add (new XElement ("name", name));
			xe.Add (new XElement ("description", description));
			xe.Add (new XElement ("type", type));
			xe.Add (new XElement ("unit", unit.name));
			xe.Add (new XElement ("compuMethod", compuMethod.name));
			xe.Add(new XElement ("arraySize", arraySize));
			return xe;
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
			cnode = node.SelectSingleNode ("compuMethod");
			if (null != cnode) {
				ret.compuMethod = Group<CompuMethod>.GFindWithName (cnode.InnerText);
			}
			cnode = node.SelectSingleNode ("arraySize");
			if (null != cnode) {
				ret.arraySize = Convert.ToUInt16 (cnode.InnerText);
			}
			return ret;
		}
		public override List<string> GenA2L ()
		{
			List<string> ret = new List<string> ();
			ret.Add ("/begin MEASUREMENT");
			ret.Add (this.name); // name
			ret.Add ("\"" + this.description + "\""); // long identifier
			ret.Add (this.type.ToString()); // data type
			ret.Add (this.compuMethod.ToString()); // conversion
			ret.Add("1"); // resolution, smallest possible change in bits
			ret.Add(""+this.type.Accuracy()); // accuracy, possible variation from exact value in %
			ret.Add(""+this.type.LowerLimit()); // lower limit
			ret.Add(""+this.type.UpperLimit()); // upper limit
			ret.Add("ECU_ADDRESS  " + "AddressToSet_"+this.name);
			ret.Add ("/end MEASUREMENT");
			return ret;
		}
		public static List<Message> CreateBaseMessages(){
			List<Message> ret = new List<Message> ();
			ret.Add (CreateAmbientTemperature ());
			ret.Add (CreateAtmosphericPressure ());
			ret.Add (CreateBatteryVoltage ());
			ret.Add (CreateChargeState ());
			return ret;
		}
		public static Message CreateAmbientTemperature(){
			Message msg = new Message ();
			msg.name = "t_ambient";
			msg.description = "Ambient temperature in Celsius";
			msg.type = BaseType.SINT32;
			msg.unit = Group<Unit>.GFindWithName ("Celsius");
			msg.compuMethod = Group<CompuMethod>.GFindWithName ("OneToOne");
			msg.arraySize = 0;
			return msg;
		}
		public static Message CreateAtmosphericPressure(){
			Message msg = new Message ();
			msg.name = "p_atmosph";
			msg.description = "Atmospheric pressure in Pascal";
			msg.type = BaseType.UINT32;
			msg.unit = Group<Unit>.GFindWithName ("Pascal");
			msg.compuMethod = Group<CompuMethod>.GFindWithName ("OneToOne");
			msg.arraySize = 0;
			return msg;
		}
		public static Message CreateBatteryVoltage(){
			Message msg = new Message ();
			msg.name = "v_battery";
			msg.description = "Battery voltage in volt";
			msg.type = BaseType.UINT32;
			msg.unit = Group<Unit>.GFindWithName ("volt");
			msg.compuMethod = Group<CompuMethod>.GFindWithName ("OneToTen");
			msg.arraySize = 0;
			return msg;
		}
		public static Message CreateChargeState(){
			Message msg = new Message ();
			msg.name = "st_charge";
			msg.description = "The charging state";
			msg.type = BaseType.BOOL;
			msg.unit = Group<Unit>.GFindWithName ("none");
			msg.compuMethod = Group<CompuMethod>.GFindWithName ("OnOff");
			msg.arraySize = 0;
			return msg;
		}
	}
}

