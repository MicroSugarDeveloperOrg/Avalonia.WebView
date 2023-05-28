using System;
using Foundation;
using ObjCRuntime;

namespace Security;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
public static class SslSessionConfigExtensions
{
	private static IntPtr[] values = new IntPtr[12];

	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
	[Field("kSSLSessionConfig_default", "Security")]
	internal unsafe static IntPtr kSSLSessionConfig_default
	{
		get
		{
			fixed (IntPtr* storage = &values[0])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSSLSessionConfig_default", storage);
			}
		}
	}

	[Field("kSSLSessionConfig_ATSv1", "Security")]
	internal unsafe static IntPtr kSSLSessionConfig_ATSv1
	{
		get
		{
			fixed (IntPtr* storage = &values[1])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSSLSessionConfig_ATSv1", storage);
			}
		}
	}

	[Field("kSSLSessionConfig_ATSv1_noPFS", "Security")]
	internal unsafe static IntPtr kSSLSessionConfig_ATSv1_noPFS
	{
		get
		{
			fixed (IntPtr* storage = &values[2])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSSLSessionConfig_ATSv1_noPFS", storage);
			}
		}
	}

	[Field("kSSLSessionConfig_standard", "Security")]
	internal unsafe static IntPtr kSSLSessionConfig_standard
	{
		get
		{
			fixed (IntPtr* storage = &values[3])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSSLSessionConfig_standard", storage);
			}
		}
	}

	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
	[Field("kSSLSessionConfig_RC4_fallback", "Security")]
	internal unsafe static IntPtr kSSLSessionConfig_RC4_fallback
	{
		get
		{
			fixed (IntPtr* storage = &values[4])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSSLSessionConfig_RC4_fallback", storage);
			}
		}
	}

	[Field("kSSLSessionConfig_TLSv1_fallback", "Security")]
	internal unsafe static IntPtr kSSLSessionConfig_TLSv1_fallback
	{
		get
		{
			fixed (IntPtr* storage = &values[5])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSSLSessionConfig_TLSv1_fallback", storage);
			}
		}
	}

	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
	[Field("kSSLSessionConfig_TLSv1_RC4_fallback", "Security")]
	internal unsafe static IntPtr kSSLSessionConfig_TLSv1_RC4_fallback
	{
		get
		{
			fixed (IntPtr* storage = &values[6])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSSLSessionConfig_TLSv1_RC4_fallback", storage);
			}
		}
	}

	[Field("kSSLSessionConfig_legacy", "Security")]
	internal unsafe static IntPtr kSSLSessionConfig_legacy
	{
		get
		{
			fixed (IntPtr* storage = &values[7])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSSLSessionConfig_legacy", storage);
			}
		}
	}

	[Field("kSSLSessionConfig_legacy_DHE", "Security")]
	internal unsafe static IntPtr kSSLSessionConfig_legacy_DHE
	{
		get
		{
			fixed (IntPtr* storage = &values[8])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSSLSessionConfig_legacy_DHE", storage);
			}
		}
	}

	[Field("kSSLSessionConfig_anonymous", "Security")]
	internal unsafe static IntPtr kSSLSessionConfig_anonymous
	{
		get
		{
			fixed (IntPtr* storage = &values[9])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSSLSessionConfig_anonymous", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
	[Field("kSSLSessionConfig_3DES_fallback", "Security")]
	internal unsafe static IntPtr kSSLSessionConfig_3DES_fallback
	{
		get
		{
			fixed (IntPtr* storage = &values[10])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSSLSessionConfig_3DES_fallback", storage);
			}
		}
	}

	[Introduced(PlatformName.iOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 1, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, null)]
	[Field("kSSLSessionConfig_TLSv1_3DES_fallback", "Security")]
	internal unsafe static IntPtr kSSLSessionConfig_TLSv1_3DES_fallback
	{
		get
		{
			fixed (IntPtr* storage = &values[11])
			{
				return Dlfcn.CachePointer(Libraries.Security.Handle, "kSSLSessionConfig_TLSv1_3DES_fallback", storage);
			}
		}
	}

	public static NSString? GetConstant(this SslSessionConfig self)
	{
		IntPtr zero = IntPtr.Zero;
		switch ((int)self)
		{
		case 0:
			zero = kSSLSessionConfig_default;
			break;
		case 1:
			zero = kSSLSessionConfig_ATSv1;
			break;
		case 2:
			zero = kSSLSessionConfig_ATSv1_noPFS;
			break;
		case 3:
			zero = kSSLSessionConfig_standard;
			break;
		case 4:
			zero = kSSLSessionConfig_RC4_fallback;
			break;
		case 5:
			zero = kSSLSessionConfig_TLSv1_fallback;
			break;
		case 6:
			zero = kSSLSessionConfig_TLSv1_RC4_fallback;
			break;
		case 7:
			zero = kSSLSessionConfig_legacy;
			break;
		case 8:
			zero = kSSLSessionConfig_legacy_DHE;
			break;
		case 9:
			zero = kSSLSessionConfig_anonymous;
			break;
		case 10:
			zero = kSSLSessionConfig_3DES_fallback;
			break;
		case 11:
			zero = kSSLSessionConfig_TLSv1_3DES_fallback;
			break;
		}
		return (NSString)Runtime.GetNSObject(zero);
	}

	public static SslSessionConfig GetValue(NSString constant)
	{
		if (constant == null)
		{
			throw new ArgumentNullException("constant");
		}
		if (constant.IsEqualTo(kSSLSessionConfig_default))
		{
			return SslSessionConfig.Default;
		}
		if (constant.IsEqualTo(kSSLSessionConfig_ATSv1))
		{
			return SslSessionConfig.Ats1;
		}
		if (constant.IsEqualTo(kSSLSessionConfig_ATSv1_noPFS))
		{
			return SslSessionConfig.Ats1NoPfs;
		}
		if (constant.IsEqualTo(kSSLSessionConfig_standard))
		{
			return SslSessionConfig.Standard;
		}
		if (constant.IsEqualTo(kSSLSessionConfig_RC4_fallback))
		{
			return SslSessionConfig.RC4Fallback;
		}
		if (constant.IsEqualTo(kSSLSessionConfig_TLSv1_fallback))
		{
			return SslSessionConfig.Tls1Fallback;
		}
		if (constant.IsEqualTo(kSSLSessionConfig_TLSv1_RC4_fallback))
		{
			return SslSessionConfig.Tls1RC4Fallback;
		}
		if (constant.IsEqualTo(kSSLSessionConfig_legacy))
		{
			return SslSessionConfig.Legacy;
		}
		if (constant.IsEqualTo(kSSLSessionConfig_legacy_DHE))
		{
			return SslSessionConfig.LegacyDhe;
		}
		if (constant.IsEqualTo(kSSLSessionConfig_anonymous))
		{
			return SslSessionConfig.Anonymous;
		}
		if (constant.IsEqualTo(kSSLSessionConfig_3DES_fallback))
		{
			return SslSessionConfig.ThreeDesFallback;
		}
		if (constant.IsEqualTo(kSSLSessionConfig_TLSv1_3DES_fallback))
		{
			return SslSessionConfig.Tls1ThreeDesFallback;
		}
		throw new NotSupportedException($"{constant} has no associated enum value on this platform.");
	}
}
