using System;
using ObjCRuntime;

namespace Foundation;

public class NSSecureCoding
{
	private const string selConformsToProtocol = "conformsToProtocol:";

	private const string selSupportsSecureCoding = "supportsSecureCoding";

	public static bool SupportsSecureCoding(Type type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		try
		{
			return SupportsSecureCoding(new Class(type));
		}
		catch (ArgumentException)
		{
			return typeof(INSSecureCoding).IsAssignableFrom(type);
		}
	}

	public static bool SupportsSecureCoding(Class klass)
	{
		if (klass == null)
		{
			throw new ArgumentNullException("klass");
		}
		return SupportsSecureCoding(klass.Handle);
	}

	internal static bool SupportsSecureCoding(IntPtr ptr)
	{
		IntPtr protocol = Runtime.GetProtocol("NSSecureCoding");
		if (protocol == IntPtr.Zero)
		{
			return false;
		}
		if (!Messaging.bool_objc_msgSend_IntPtr(ptr, Selector.GetHandle("conformsToProtocol:"), protocol))
		{
			return false;
		}
		return Messaging.bool_objc_msgSend(ptr, Selector.GetHandle("supportsSecureCoding"));
	}
}
