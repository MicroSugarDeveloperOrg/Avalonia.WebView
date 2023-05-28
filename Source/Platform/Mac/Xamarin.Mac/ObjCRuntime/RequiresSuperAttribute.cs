using System;
using Foundation;

namespace ObjCRuntime;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public sealed class RequiresSuperAttribute : AdviceAttribute
{
	public RequiresSuperAttribute()
		: base("Overriding this method requires a call to the overriden method.")
	{
	}
}
