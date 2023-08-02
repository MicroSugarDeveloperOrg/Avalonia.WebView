using System;

namespace ObjCRuntime;

public class CompileFlagsAttribute : Attribute
{
	public string Flags;

	public CompileFlagsAttribute(string flags)
	{
		Flags = flags;
	}
}
