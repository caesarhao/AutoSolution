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
		public static string ToC(this BaseType t){
			switch (t) {
			case BaseType.VOID:
				return "void";
				break;
			case BaseType.BOOL:
				return "_Bool";
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
		public static string ToArduino(this BaseType t){
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

