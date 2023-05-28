using System;

namespace Foundation;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
public class NotImplementedAttribute : Attribute
{
	public string Message { get; set; }

	public NotImplementedAttribute()
	{
	}

	public NotImplementedAttribute(string message)
	{
		Message = message;
	}
}
