using System;

namespace Foundation;

[AttributeUsage(AttributeTargets.Property)]
public sealed class OutletAttribute : ExportAttribute
{
	public OutletAttribute()
		: base(null)
	{
	}

	public OutletAttribute(string name)
		: base(name)
	{
	}
}
