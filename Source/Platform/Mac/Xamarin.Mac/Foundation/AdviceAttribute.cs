using System;

namespace Foundation;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
public sealed class AdviceAttribute : Attribute
{
	public string Message { get; private set; }

	public AdviceAttribute(string message)
	{
		Message = message;
	}
}
