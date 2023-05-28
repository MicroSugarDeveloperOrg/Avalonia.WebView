using System;
using System.Runtime.InteropServices;
using CoreFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreText;

public class CTFontManager
{
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public delegate bool CTFontRegistrationHandler(NSError[] errors, bool done);

	internal delegate bool InnerRegistrationHandler(IntPtr block, IntPtr errors, bool done);

	public static class Notifications
	{
		public static NSObject ObserveRegisteredFontsChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			return NSNotificationCenter.DefaultCenter.AddObserver(RegisteredFontsChangedNotification, delegate(NSNotification notification)
			{
				handler(null, new NSNotificationEventArgs(notification));
			});
		}
	}

	private static readonly InnerRegistrationHandler callback;

	private static NSString _RegisteredFontsChangedNotification;

	public static readonly NSString ErrorDomain;

	[Obsolete("Use the 'CTFontManagerErrorKeys.FontUrlsKey' property instead.")]
	public static readonly NSString ErrorFontUrlsKey;

	[iOS(7, 0)]
	private static NSString RegisteredFontsChangedNotification
	{
		get
		{
			if (_RegisteredFontsChangedNotification == null)
			{
				_RegisteredFontsChangedNotification = Dlfcn.GetStringConstant(Libraries.CoreText.Handle, "kCTFontManagerRegisteredFontsChangedNotification");
			}
			return _RegisteredFontsChangedNotification;
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern bool CTFontManagerIsSupportedFont(IntPtr url);

	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.None, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	public static bool IsFontSupported(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return CTFontManagerIsSupportedFont(url.Handle);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern bool CTFontManagerRegisterFontsForURL(IntPtr fontUrl, CTFontManagerScope scope, ref IntPtr error);

	public static NSError RegisterFontsForUrl(NSUrl fontUrl, CTFontManagerScope scope)
	{
		if (fontUrl == null)
		{
			throw new ArgumentNullException("fontUrl");
		}
		IntPtr error = IntPtr.Zero;
		try
		{
			if (CTFontManagerRegisterFontsForURL(fontUrl.Handle, scope, ref error))
			{
				return null;
			}
			return Runtime.GetNSObject<NSError>(error);
		}
		finally
		{
			if (error != IntPtr.Zero)
			{
				CFObject.CFRelease(error);
			}
		}
	}

	private static NSArray EnsureNonNullArray(object[] items, string name)
	{
		if (items == null)
		{
			throw new ArgumentNullException(name);
		}
		foreach (object obj in items)
		{
			if (obj == null)
			{
				throw new ArgumentException("Array contains a null entry", name);
			}
		}
		return NSArray.FromObjects(items);
	}

	private static T[] ArrayFromHandle<T>(IntPtr handle, bool releaseAfterUse) where T : class, INativeObject
	{
		if (handle == IntPtr.Zero)
		{
			return null;
		}
		try
		{
			return NSArray.ArrayFromHandle<T>(handle);
		}
		finally
		{
			if (releaseAfterUse)
			{
				CFObject.CFRetain(handle);
			}
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern bool CTFontManagerRegisterFontsForURLs(IntPtr arrayRef, CTFontManagerScope scope, ref IntPtr error_array);

	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'RegisterFonts' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'RegisterFonts' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'RegisterFonts' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'RegisterFonts' instead.")]
	public static NSError[] RegisterFontsForUrl(NSUrl[] fontUrls, CTFontManagerScope scope)
	{
		using NSArray nSArray = EnsureNonNullArray(fontUrls, "fontUrls");
		IntPtr error_array = IntPtr.Zero;
		if (CTFontManagerRegisterFontsForURLs(nSArray.Handle, scope, ref error_array))
		{
			return null;
		}
		return ArrayFromHandle<NSError>(error_array, releaseAfterUse: true);
	}

	[MonoPInvokeCallback(typeof(InnerRegistrationHandler))]
	private static bool TrampolineRegistrationHandler(IntPtr block, IntPtr errors, bool done)
	{
		return BlockLiteral.GetTarget<CTFontRegistrationHandler>(block)?.Invoke(NSArray.ArrayFromHandle<NSError>(errors), done) ?? true;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern void CTFontManagerRegisterFontURLs(IntPtr fontUrls, CTFontManagerScope scope, bool enabled, IntPtr registrationHandler);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern void CTFontManagerRegisterFontURLs(IntPtr fontUrls, CTFontManagerScope scope, bool enabled, ref BlockLiteral registrationHandler);

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public static void RegisterFonts(NSUrl[] fontUrls, CTFontManagerScope scope, bool enabled, CTFontRegistrationHandler registrationHandler)
	{
		using NSArray nSArray = EnsureNonNullArray(fontUrls, "fontUrls");
		if (registrationHandler == null)
		{
			CTFontManagerRegisterFontURLs(nSArray.Handle, scope, enabled, IntPtr.Zero);
			return;
		}
		BlockLiteral registrationHandler2 = default(BlockLiteral);
		registrationHandler2.SetupBlockUnsafe(callback, registrationHandler);
		CTFontManagerRegisterFontURLs(nSArray.Handle, scope, enabled, ref registrationHandler2);
		registrationHandler2.CleanupBlock();
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern bool CTFontManagerUnregisterFontsForURL(IntPtr fotUrl, CTFontManagerScope scope, ref IntPtr error);

	public static NSError UnregisterFontsForUrl(NSUrl fontUrl, CTFontManagerScope scope)
	{
		if (fontUrl == null)
		{
			throw new ArgumentNullException("fontUrl");
		}
		IntPtr error = IntPtr.Zero;
		try
		{
			if (CTFontManagerUnregisterFontsForURL(fontUrl.Handle, scope, ref error))
			{
				return null;
			}
			return Runtime.GetNSObject<NSError>(error);
		}
		finally
		{
			if (error != IntPtr.Zero)
			{
				CFObject.CFRelease(error);
			}
		}
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern bool CTFontManagerUnregisterFontsForURLs(IntPtr arrayRef, CTFontManagerScope scope, ref IntPtr error_array);

	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'UnregisterFonts' instead.")]
	[Deprecated(PlatformName.iOS, 13, 0, PlatformArchitecture.None, "Use 'UnregisterFonts' instead.")]
	[Deprecated(PlatformName.WatchOS, 6, 0, PlatformArchitecture.None, "Use 'UnregisterFonts' instead.")]
	[Deprecated(PlatformName.TvOS, 13, 0, PlatformArchitecture.None, "Use 'UnregisterFonts' instead.")]
	public static NSError[] UnregisterFontsForUrl(NSUrl[] fontUrls, CTFontManagerScope scope)
	{
		IntPtr error_array = IntPtr.Zero;
		using NSArray nSArray = EnsureNonNullArray(fontUrls, "fontUrls");
		if (CTFontManagerUnregisterFontsForURLs(nSArray.Handle, scope, ref error_array))
		{
			return null;
		}
		return ArrayFromHandle<NSError>(error_array, releaseAfterUse: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern void CTFontManagerUnregisterFontURLs(IntPtr fontUrls, CTFontManagerScope scope, IntPtr registrationHandler);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern void CTFontManagerUnregisterFontURLs(IntPtr fontUrls, CTFontManagerScope scope, ref BlockLiteral registrationHandler);

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public static void UnregisterFonts(NSUrl[] fontUrls, CTFontManagerScope scope, CTFontRegistrationHandler registrationHandler)
	{
		using NSArray nSArray = EnsureNonNullArray(fontUrls, "fontUrls");
		if (registrationHandler == null)
		{
			CTFontManagerUnregisterFontURLs(nSArray.Handle, scope, IntPtr.Zero);
			return;
		}
		BlockLiteral registrationHandler2 = default(BlockLiteral);
		registrationHandler2.SetupBlockUnsafe(callback, registrationHandler);
		CTFontManagerUnregisterFontURLs(nSArray.Handle, scope, ref registrationHandler2);
		registrationHandler2.CleanupBlock();
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	[iOS(7, 0)]
	private static extern IntPtr CTFontManagerCreateFontDescriptorsFromURL(IntPtr fileURL);

	[iOS(7, 0)]
	public static CTFontDescriptor[] GetFonts(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr intPtr = CTFontManagerCreateFontDescriptorsFromURL(url.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return new CTFontDescriptor[0];
		}
		using CFArray cFArray = new CFArray(intPtr, owns: true);
		CTFontDescriptor[] array = new CTFontDescriptor[(long)cFArray.Count];
		for (int i = 0; i < cFArray.Count; i++)
		{
			array[i] = new CTFontDescriptor(cFArray.GetValue(i), owns: false);
		}
		return array;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern bool CTFontManagerRegisterGraphicsFont(IntPtr cgfont, out IntPtr error);

	public static bool RegisterGraphicsFont(CGFont font, out NSError error)
	{
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		IntPtr error2 = IntPtr.Zero;
		bool flag;
		try
		{
			flag = CTFontManagerRegisterGraphicsFont(font.Handle, out error2);
			if (flag)
			{
				error = null;
			}
			else
			{
				error = new NSError(error2);
			}
		}
		finally
		{
			if (error2 != IntPtr.Zero)
			{
				CFObject.CFRelease(error2);
			}
		}
		return flag;
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern bool CTFontManagerUnregisterGraphicsFont(IntPtr cgfont, out IntPtr error);

	public static bool UnregisterGraphicsFont(CGFont font, out NSError error)
	{
		if (font == null)
		{
			throw new ArgumentNullException("font");
		}
		IntPtr error2 = IntPtr.Zero;
		bool flag;
		try
		{
			flag = CTFontManagerUnregisterGraphicsFont(font.Handle, out error2);
			if (flag)
			{
				error = null;
			}
			else
			{
				error = new NSError(error2);
			}
		}
		finally
		{
			if (error2 != IntPtr.Zero)
			{
				CFObject.CFRelease(error2);
			}
		}
		return flag;
	}

	static CTFontManager()
	{
		callback = TrampolineRegistrationHandler;
		IntPtr handle = Libraries.CoreText.Handle;
		ErrorDomain = Dlfcn.GetStringConstant(handle, "kCTFontManagerErrorDomain");
		ErrorFontUrlsKey = Dlfcn.GetStringConstant(handle, "kCTFontManagerErrorFontURLsKey");
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern void CTFontManagerRegisterFontDescriptors(IntPtr fontDescriptors, CTFontManagerScope scope, bool enabled, IntPtr registrationHandler);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern void CTFontManagerRegisterFontDescriptors(IntPtr fontDescriptors, CTFontManagerScope scope, bool enabled, ref BlockLiteral registrationHandler);

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public static void RegisterFontDescriptors(CTFontDescriptor[] fontDescriptors, CTFontManagerScope scope, bool enabled, CTFontRegistrationHandler registrationHandler)
	{
		using NSArray nSArray = EnsureNonNullArray(fontDescriptors, "fontDescriptors");
		if (registrationHandler == null)
		{
			CTFontManagerRegisterFontDescriptors(nSArray.Handle, scope, enabled, IntPtr.Zero);
			return;
		}
		BlockLiteral registrationHandler2 = default(BlockLiteral);
		registrationHandler2.SetupBlockUnsafe(callback, registrationHandler);
		CTFontManagerRegisterFontDescriptors(nSArray.Handle, scope, enabled, ref registrationHandler2);
		registrationHandler2.CleanupBlock();
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern void CTFontManagerUnregisterFontDescriptors(IntPtr fontDescriptors, CTFontManagerScope scope, IntPtr registrationHandler);

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern void CTFontManagerUnregisterFontDescriptors(IntPtr fontDescriptors, CTFontManagerScope scope, ref BlockLiteral registrationHandler);

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public static void UnregisterFontDescriptors(CTFontDescriptor[] fontDescriptors, CTFontManagerScope scope, CTFontRegistrationHandler registrationHandler)
	{
		using NSArray nSArray = EnsureNonNullArray(fontDescriptors, "fontDescriptors");
		if (registrationHandler == null)
		{
			CTFontManagerUnregisterFontDescriptors(nSArray.Handle, scope, IntPtr.Zero);
			return;
		}
		BlockLiteral registrationHandler2 = default(BlockLiteral);
		registrationHandler2.SetupBlockUnsafe(callback, registrationHandler);
		CTFontManagerUnregisterFontDescriptors(nSArray.Handle, scope, ref registrationHandler2);
		registrationHandler2.CleanupBlock();
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	private static extern IntPtr CTFontManagerCreateFontDescriptorFromData(IntPtr data);

	public static CTFontDescriptor CreateFontDescriptor(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr intPtr = CTFontManagerCreateFontDescriptorFromData(data.Handle);
		if (intPtr == IntPtr.Zero)
		{
			return null;
		}
		return new CTFontDescriptor(intPtr, owns: true);
	}

	[DllImport("/System/Library/Frameworks/ApplicationServices.framework/Frameworks/CoreText.framework/CoreText")]
	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	private static extern IntPtr CTFontManagerCreateFontDescriptorsFromData(IntPtr data);

	[Watch(6, 0)]
	[TV(13, 0)]
	[Mac(10, 15)]
	[iOS(13, 0)]
	public static CTFontDescriptor[] CreateFontDescriptors(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr handle = CTFontManagerCreateFontDescriptorsFromData(data.Handle);
		return ArrayFromHandle<CTFontDescriptor>(handle, releaseAfterUse: true);
	}
}
