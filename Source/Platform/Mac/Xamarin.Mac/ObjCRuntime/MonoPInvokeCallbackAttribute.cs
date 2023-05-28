using System;

namespace ObjCRuntime;

[AttributeUsage(AttributeTargets.Method)]
public sealed class MonoPInvokeCallbackAttribute : Attribute
{
	public Type DelegateType { get; set; }

	public MonoPInvokeCallbackAttribute(Type t)
	{
		DelegateType = t;
	}
}
