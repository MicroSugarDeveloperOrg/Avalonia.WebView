using System;

namespace Foundation;

[AttributeUsage(AttributeTargets.Method)]
public sealed class ActionAttribute : ExportAttribute
{
	public ActionAttribute()
		: base(null)
	{
	}

	public ActionAttribute(string selector)
		: base(selector)
	{
	}
}
