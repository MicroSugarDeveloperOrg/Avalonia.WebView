using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace CoreServices;

[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'NSUrlSession'.")]
[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSUrlSession'.")]
public class CFHTTPStream : CFReadStream
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __AttemptPersistentConnection;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __FinalRequest;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __FinalURL;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __Proxy;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __RequestBytesWrittenCount;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __ResponseHeader;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? __ShouldAutoredirect;

	public Uri FinalURL
	{
		get
		{
			IntPtr property = GetProperty(_FinalURL);
			if (property == IntPtr.Zero)
			{
				return null;
			}
			if (CFType.GetTypeID(property) != CFUrl.GetTypeID())
			{
				CFObject.CFRelease(property);
				throw new InvalidCastException();
			}
			using CFUrl cFUrl = new CFUrl(property);
			return new Uri(cFUrl.ToString());
		}
	}

	public bool AttemptPersistentConnection
	{
		get
		{
			IntPtr property = GetProperty(_AttemptPersistentConnection);
			if (property == IntPtr.Zero)
			{
				return false;
			}
			if (property == CFBoolean.FalseHandle)
			{
				return false;
			}
			if (property == CFBoolean.TrueHandle)
			{
				return true;
			}
			throw new InvalidCastException();
		}
		set
		{
			SetProperty(_AttemptPersistentConnection, CFBoolean.FromBoolean(value));
		}
	}

	public int RequestBytesWrittenCount
	{
		get
		{
			IntPtr property = GetProperty(_RequestBytesWrittenCount);
			if (property == IntPtr.Zero)
			{
				return 0;
			}
			using NSNumber nSNumber = new NSNumber(property);
			return nSNumber.Int32Value;
		}
	}

	public bool ShouldAutoredirect
	{
		get
		{
			IntPtr property = GetProperty(_ShouldAutoredirect);
			if (property == IntPtr.Zero)
			{
				return false;
			}
			if (property == CFBoolean.FalseHandle)
			{
				return false;
			}
			if (property == CFBoolean.TrueHandle)
			{
				return true;
			}
			throw new InvalidCastException();
		}
		set
		{
			SetProperty(_ShouldAutoredirect, CFBoolean.FromBoolean(value));
		}
	}

	internal CFDictionary Proxy
	{
		set
		{
			SetProperty(_Proxy, value);
		}
	}

	[Field("kCFStreamPropertyHTTPAttemptPersistentConnection", "CFNetwork")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	internal static NSString _AttemptPersistentConnection
	{
		[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
		get
		{
			if (__AttemptPersistentConnection == null)
			{
				__AttemptPersistentConnection = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFStreamPropertyHTTPAttemptPersistentConnection");
			}
			return __AttemptPersistentConnection;
		}
	}

	[Field("kCFStreamPropertyHTTPFinalRequest", "CFNetwork")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	internal static NSString _FinalRequest
	{
		[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
		get
		{
			if (__FinalRequest == null)
			{
				__FinalRequest = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFStreamPropertyHTTPFinalRequest");
			}
			return __FinalRequest;
		}
	}

	[Field("kCFStreamPropertyHTTPFinalURL", "CFNetwork")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	internal static NSString _FinalURL
	{
		[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
		get
		{
			if (__FinalURL == null)
			{
				__FinalURL = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFStreamPropertyHTTPFinalURL");
			}
			return __FinalURL;
		}
	}

	[Field("kCFStreamPropertyHTTPProxy", "CFNetwork")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	internal static NSString _Proxy
	{
		[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
		get
		{
			if (__Proxy == null)
			{
				__Proxy = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFStreamPropertyHTTPProxy");
			}
			return __Proxy;
		}
	}

	[Field("kCFStreamPropertyHTTPRequestBytesWrittenCount", "CFNetwork")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	internal static NSString _RequestBytesWrittenCount
	{
		[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
		get
		{
			if (__RequestBytesWrittenCount == null)
			{
				__RequestBytesWrittenCount = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFStreamPropertyHTTPRequestBytesWrittenCount");
			}
			return __RequestBytesWrittenCount;
		}
	}

	[Field("kCFStreamPropertyHTTPResponseHeader", "CFNetwork")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	internal static NSString _ResponseHeader
	{
		[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
		get
		{
			if (__ResponseHeader == null)
			{
				__ResponseHeader = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFStreamPropertyHTTPResponseHeader");
			}
			return __ResponseHeader;
		}
	}

	[Field("kCFStreamPropertyHTTPShouldAutoredirect", "CFNetwork")]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
	internal static NSString _ShouldAutoredirect
	{
		[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, null)]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, null)]
		get
		{
			if (__ShouldAutoredirect == null)
			{
				__ShouldAutoredirect = Dlfcn.GetStringConstant(Libraries.CFNetwork.Handle, "kCFStreamPropertyHTTPShouldAutoredirect");
			}
			return __ShouldAutoredirect;
		}
	}

	internal CFHTTPStream(IntPtr handle)
		: base(handle)
	{
	}

	public CFHTTPMessage GetFinalRequest()
	{
		IntPtr property = GetProperty(_FinalRequest);
		if (property == IntPtr.Zero)
		{
			return null;
		}
		if (CFType.GetTypeID(property) != CFHTTPMessage.GetTypeID())
		{
			CFObject.CFRelease(property);
			throw new InvalidCastException();
		}
		return new CFHTTPMessage(property);
	}

	public CFHTTPMessage GetResponseHeader()
	{
		IntPtr property = GetProperty(_ResponseHeader);
		if (property == IntPtr.Zero)
		{
			return null;
		}
		if (CFType.GetTypeID(property) != CFHTTPMessage.GetTypeID())
		{
			CFObject.CFRelease(property);
			throw new InvalidCastException();
		}
		return new CFHTTPMessage(property);
	}

	public void SetProxy(CFProxySettings proxySettings)
	{
		if (proxySettings == null)
		{
			throw new ArgumentNullException("proxySettings");
		}
		SetProperty(_Proxy, proxySettings.Dictionary);
	}
}
