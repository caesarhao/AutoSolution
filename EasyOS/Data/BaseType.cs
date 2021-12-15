using System;

namespace EasyOS
{
	public enum BaseType
	{
		VOID, // void in C#
		BOOL, // bool in C#
		UINT8, // byte in C#
		SINT8, // sbyte in C#
		UINT16, // ushort in C#
		SINT16, // short in C#
		UINT32, // uint in C#
		SINT32, // int in C#
		UINT64, // ulong in C#
		SINT64, // long in C#
		FLOAT32, // float in C#
		DOUBLE64, // double in C#
		STRING	// string in C#
	}
	public static class BaseTypeExtensions
	{
		public static double LowerLimit(this BaseType t){
			switch (t) {
			case BaseType.VOID:
				return 0;
				break;
			case BaseType.BOOL:
				return 0;
				break;
			case BaseType.UINT8:
				return Byte.MinValue;
				break;
			case BaseType.SINT8:
				return SByte.MinValue;
				break;
			case BaseType.UINT16:
				return UInt16.MinValue;
				break;
			case BaseType.SINT16:
				return Int16.MinValue;
				break;
			case BaseType.UINT32:
				return UInt32.MinValue;
				break;
			case BaseType.SINT32:
				return Int32.MinValue;
				break;
			case BaseType.UINT64:
				return UInt64.MinValue;
				break;
			case BaseType.SINT64:
				return Int64.MinValue;
				break;
			case BaseType.FLOAT32:
				return float.MinValue;
				break;
			case BaseType.DOUBLE64:
				return Double.MinValue;
				break;
			case BaseType.STRING:
				return 0;
				break;
			default:
				return 0;
				break;
			}
		}
		public static double UpperLimit(this BaseType t){
				switch (t) {
				case BaseType.VOID:
					return 0;
					break;
				case BaseType.BOOL:
					return 1;
					break;
				case BaseType.UINT8:
					return Byte.MaxValue;
					break;
				case BaseType.SINT8:
					return SByte.MaxValue;
					break;
				case BaseType.UINT16:
					return UInt16.MaxValue;
					break;
				case BaseType.SINT16:
					return Int16.MaxValue;
					break;
				case BaseType.UINT32:
					return UInt32.MaxValue;
					break;
				case BaseType.SINT32:
					return Int32.MaxValue;
					break;
				case BaseType.UINT64:
					return UInt64.MaxValue;
					break;
				case BaseType.SINT64:
					return Int64.MaxValue;
					break;
				case BaseType.FLOAT32:
					return float.MaxValue;
					break;
				case BaseType.DOUBLE64:
					return Double.MaxValue;
					break;
				case BaseType.STRING:
					return 0;
					break;
				default:
					return 0;
					break;
				}
		}
		public static double Accuracy(this BaseType t){
			switch (t) {
			case BaseType.VOID:
				return 0;
				break;
			case BaseType.BOOL:
				return 0;
				break;
			case BaseType.UINT8:
				return (100/Byte.MaxValue);
				break;
			case BaseType.SINT8:
				return (100/SByte.MaxValue);
				break;
			case BaseType.UINT16:
				return (100/UInt16.MaxValue);
				break;
			case BaseType.SINT16:
				return (100/Int16.MaxValue);
				break;
			case BaseType.UINT32:
				return (100/UInt32.MaxValue);
				break;
			case BaseType.SINT32:
				return (100/Int32.MaxValue);
				break;
			case BaseType.UINT64:
				return (100/UInt64.MaxValue);
				break;
			case BaseType.SINT64:
				return (100/Int64.MaxValue);
				break;
			case BaseType.FLOAT32:
				return (100/float.MaxValue);
				break;
			case BaseType.DOUBLE64:
				return (100/Double.MaxValue);
				break;
			case BaseType.STRING:
				return 0;
				break;
			default:
				return 0;
				break;
			}
		}
		public static string ToC(this BaseType t){
			switch (t) {
			case BaseType.VOID:
				return "void";
				break;
			case BaseType.BOOL:
				return "int";
				break;
			case BaseType.UINT8:
				return "unsigned char";
				break;
			case BaseType.SINT8:
				return "signed char";
				break;
			case BaseType.UINT16:
				return "unsigned short";
				break;
			case BaseType.SINT16:
				return "signed short";
				break;
			case BaseType.UINT32:
				return "unsigned long";
				break;
			case BaseType.SINT32:
				return "signed long";
				break;
			case BaseType.UINT64:
				return "unsigned long long";
				break;
			case BaseType.SINT64:
				return "signed long long";
				break;
			case BaseType.FLOAT32:
				return "float";
				break;
			case BaseType.DOUBLE64:
				return "double";
				break;
			case BaseType.STRING:
				return "char *";
				break;
			default:
				return "void";
				break;
			}
		}
		public static string ToCpp(this BaseType t){
			switch (t) {
			case BaseType.VOID:
				return "void";
				break;
			case BaseType.BOOL:
				return "bool";
				break;
			case BaseType.UINT8:
				return "byte";
				break;
			case BaseType.SINT8:
				return "char";
				break;
			case BaseType.UINT16:
				return "word";
				break;
			case BaseType.SINT16:
				return "short";
				break;
			case BaseType.UINT32:
				return "unsigned long";
				break;
			case BaseType.SINT32:
				return "long";
				break;
			case BaseType.UINT64:
				return "unsigned long long";
				break;
			case BaseType.SINT64:
				return "long long";
				break;
			case BaseType.FLOAT32:
				return "float";
				break;
			case BaseType.DOUBLE64:
				return "double";
				break;
			case BaseType.STRING:
				return "char *";
				break;
			default:
				return "void";
				break;
			}
		}
		public static string ToPython(this BaseType t){
			return "";
		}
		public static string ToLua(this BaseType t){
			return "local";
		}
	}
}

