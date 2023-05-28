using System;

namespace ObjCRuntime;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
public class BindingImplAttribute : Attribute
{
	public BindingImplOptions Options { get; set; }

	public BindingImplAttribute(BindingImplOptions options)
	{
		Options = options;
	}
}
