using System;

namespace ObjCRuntime;

[AttributeUsage(AttributeTargets.Assembly)]
public abstract class DelayedRegistrationAttribute : Attribute
{
	public abstract bool Delay { get; }
}
