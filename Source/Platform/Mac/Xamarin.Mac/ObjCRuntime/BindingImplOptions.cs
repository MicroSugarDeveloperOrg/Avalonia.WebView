using System;

namespace ObjCRuntime;

[Flags]
public enum BindingImplOptions
{
	GeneratedCode = 1,
	Optimizable = 2
}
