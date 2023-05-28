using System;
using Foundation;
using ObjCRuntime;

namespace Network;

[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class NWErrorDomainExtensions
{
	private static IntPtr[] values = new IntPtr[3];

	[Field("kNWErrorDomainPOSIX", "Network")]
	internal unsafe static IntPtr kNWErrorDomainPOSIX
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.Network.Handle, "kNWErrorDomainPOSIX", storage);
			}
		}
	}

	[Field("kNWErrorDomainDNS", "Network")]
	internal unsafe static IntPtr kNWErrorDomainDNS
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.Network.Handle, "kNWErrorDomainDNS", storage);
			}
		}
	}

	[Field("kNWErrorDomainTLS", "Network")]
	internal unsafe static IntPtr kNWErrorDomainTLS
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.Network.Handle, "kNWErrorDomainTLS", storage);
			}
		}
	}

	public static NSString? GetConstant(this NWErrorDomain self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 1:
			zero = kNWErrorDomainPOSIX;
			break;
		case 2:
			zero = kNWErrorDomainDNS;
			break;
		case 3:
			zero = kNWErrorDomainTLS;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static NWErrorDomain GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kNWErrorDomainPOSIX))
		{
			return NWErrorDomain.Posix;
		}
		if (constant.IsEqualTo(kNWErrorDomainDNS))
		{
			return NWErrorDomain.Dns;
		}
		if (constant.IsEqualTo(kNWErrorDomainTLS))
		{
			return NWErrorDomain.Tls;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
