using System;
using Foundation;
using ObjCRuntime;

namespace BusinessChat;

[Introduced(PlatformName.MacOSX, 10, 13, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 3, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class BCParameterNameExtensions
{
	private static IntPtr[] values = new IntPtr[3];

	[Field("BCParameterNameIntent", "BusinessChat")]
	internal unsafe static IntPtr BCParameterNameIntent
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.BusinessChat.Handle, "BCParameterNameIntent", storage);
			}
		}
	}

	[Field("BCParameterNameGroup", "BusinessChat")]
	internal unsafe static IntPtr BCParameterNameGroup
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.BusinessChat.Handle, "BCParameterNameGroup", storage);
			}
		}
	}

	[Field("BCParameterNameBody", "BusinessChat")]
	internal unsafe static IntPtr BCParameterNameBody
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.BusinessChat.Handle, "BCParameterNameBody", storage);
			}
		}
	}

	public static NSString? GetConstant(this BCParameterName self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = BCParameterNameIntent;
			break;
		case 1:
			ptr = BCParameterNameGroup;
			break;
		case 2:
			ptr = BCParameterNameBody;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static BCParameterName GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(BCParameterNameIntent))
		{
			return BCParameterName.Intent;
		}
		if (constant.IsEqualTo(BCParameterNameGroup))
		{
			return BCParameterName.Group;
		}
		if (constant.IsEqualTo(BCParameterNameBody))
		{
			return BCParameterName.Body;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
