using System;

namespace ObjCRuntime;

public sealed class ThreadSafeAttribute : Attribute
{
	public bool Safe { get; private set; }

	public ThreadSafeAttribute()
	{
		Safe = true;
	}

	public ThreadSafeAttribute(bool safe)
	{
		Safe = safe;
	}
}
