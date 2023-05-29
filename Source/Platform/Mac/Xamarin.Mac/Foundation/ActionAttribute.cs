using System;

namespace Foundation;

[AttributeUsage(AttributeTargets.Method)]
public sealed class ActionAttribute : ExportAttribute
{
	public ActionAttribute()
	{
	}

	public ActionAttribute(string selector)
		: base(selector)
	{
	}
}
