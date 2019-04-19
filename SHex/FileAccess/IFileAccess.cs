using System;
using System.Collections.Generic;
namespace SHex
{
	public interface IFileAccess
	{
		List<MemBlock> Memblks{ get; set;}
		bool parse(string[] lines);
		string[] generate();
	}
}

