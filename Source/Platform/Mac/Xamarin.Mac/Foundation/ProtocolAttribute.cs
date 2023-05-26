using System;

namespace Foundation;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public sealed class ProtocolAttribute : Attribute
{
	public Type WrapperType { get; set; }

	public string Name { get; set; }
}
