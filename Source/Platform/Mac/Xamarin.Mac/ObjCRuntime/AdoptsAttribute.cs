using System;

namespace ObjCRuntime;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class AdoptsAttribute : Attribute
{
	private IntPtr handle;

	public string ProtocolType { get; private set; }

	public IntPtr ProtocolHandle
	{
		get
		{
			if (handle == IntPtr.Zero && ProtocolType != null)
			{
				handle = Runtime.GetProtocol(ProtocolType);
			}
			return handle;
		}
	}

	public AdoptsAttribute(string protocolType)
	{
		ProtocolType = protocolType;
	}
}
