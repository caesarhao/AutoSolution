using System;

namespace SHex
{
	public interface IFileAccess
	{
		bool parse(string[] lines);
		string[] generate();
	}
}

