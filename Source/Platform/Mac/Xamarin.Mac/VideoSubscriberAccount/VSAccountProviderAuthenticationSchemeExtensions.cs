using System;
using Foundation;
using ObjCRuntime;

namespace VideoSubscriberAccount;

[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class VSAccountProviderAuthenticationSchemeExtensions
{
	private static IntPtr[] values = new IntPtr[2];

	[Field("VSAccountProviderAuthenticationSchemeSAML", "VideoSubscriberAccount")]
	internal unsafe static IntPtr VSAccountProviderAuthenticationSchemeSAML
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.VideoSubscriberAccount.Handle, "VSAccountProviderAuthenticationSchemeSAML", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Field("VSAccountProviderAuthenticationSchemeAPI", "VideoSubscriberAccount")]
	internal unsafe static IntPtr VSAccountProviderAuthenticationSchemeAPI
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.VideoSubscriberAccount.Handle, "VSAccountProviderAuthenticationSchemeAPI", storage);
			}
		}
	}

	public static NSString[] GetConstants(this VSAccountProviderAuthenticationScheme[] self)
	{
		if (self == null)
		{
			throw new ArgumentNullException("self");
		}
		NSString[] array = new NSString[self.Length];
		for (int i = 0; i < self.Length; i++)
		{
			array[i] = self[i].GetConstant();
		}
		return array;
	}

	public static VSAccountProviderAuthenticationScheme[] GetValues(NSString[] constants)
	{
		if (constants == null)
		{
			throw new ArgumentNullException("constants");
		}
		VSAccountProviderAuthenticationScheme[] array = new VSAccountProviderAuthenticationScheme[constants.Length];
		for (int i = 0; i < constants.Length; i++)
		{
			array[i] = GetValue(constants[i]);
		}
		return array;
	}

	public static NSString? GetConstant(this VSAccountProviderAuthenticationScheme self)
	{
		IntPtr ptr = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			ptr = VSAccountProviderAuthenticationSchemeSAML;
			break;
		case 1:
			ptr = VSAccountProviderAuthenticationSchemeAPI;
			break;
		}
		return (NSString)Runtime.GetNSObject(ptr);
	}

	public static VSAccountProviderAuthenticationScheme GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(VSAccountProviderAuthenticationSchemeSAML))
		{
			return VSAccountProviderAuthenticationScheme.Saml;
		}
		if (constant.IsEqualTo(VSAccountProviderAuthenticationSchemeAPI))
		{
			return VSAccountProviderAuthenticationScheme.Api;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
