using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSScreen", true)]
public class NSScreen : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveColorSpaceDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ColorSpaceDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveColorSpaceDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ColorSpaceDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackingAlignedRect_Options_ = "backingAlignedRect:options:";

	private static readonly IntPtr selBackingAlignedRect_Options_Handle = Selector.GetHandle("backingAlignedRect:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackingScaleFactor = "backingScaleFactor";

	private static readonly IntPtr selBackingScaleFactorHandle = Selector.GetHandle("backingScaleFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanRepresentDisplayGamut_ = "canRepresentDisplayGamut:";

	private static readonly IntPtr selCanRepresentDisplayGamut_Handle = Selector.GetHandle("canRepresentDisplayGamut:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorSpace = "colorSpace";

	private static readonly IntPtr selColorSpaceHandle = Selector.GetHandle("colorSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRectFromBacking_ = "convertRectFromBacking:";

	private static readonly IntPtr selConvertRectFromBacking_Handle = Selector.GetHandle("convertRectFromBacking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertRectToBacking_ = "convertRectToBacking:";

	private static readonly IntPtr selConvertRectToBacking_Handle = Selector.GetHandle("convertRectToBacking:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeepestScreen = "deepestScreen";

	private static readonly IntPtr selDeepestScreenHandle = Selector.GetHandle("deepestScreen");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDepth = "depth";

	private static readonly IntPtr selDepthHandle = Selector.GetHandle("depth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeviceDescription = "deviceDescription";

	private static readonly IntPtr selDeviceDescriptionHandle = Selector.GetHandle("deviceDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrame = "frame";

	private static readonly IntPtr selFrameHandle = Selector.GetHandle("frame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedName = "localizedName";

	private static readonly IntPtr selLocalizedNameHandle = Selector.GetHandle("localizedName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMainScreen = "mainScreen";

	private static readonly IntPtr selMainScreenHandle = Selector.GetHandle("mainScreen");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumExtendedDynamicRangeColorComponentValue = "maximumExtendedDynamicRangeColorComponentValue";

	private static readonly IntPtr selMaximumExtendedDynamicRangeColorComponentValueHandle = Selector.GetHandle("maximumExtendedDynamicRangeColorComponentValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumPotentialExtendedDynamicRangeColorComponentValue = "maximumPotentialExtendedDynamicRangeColorComponentValue";

	private static readonly IntPtr selMaximumPotentialExtendedDynamicRangeColorComponentValueHandle = Selector.GetHandle("maximumPotentialExtendedDynamicRangeColorComponentValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumReferenceExtendedDynamicRangeColorComponentValue = "maximumReferenceExtendedDynamicRangeColorComponentValue";

	private static readonly IntPtr selMaximumReferenceExtendedDynamicRangeColorComponentValueHandle = Selector.GetHandle("maximumReferenceExtendedDynamicRangeColorComponentValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScreens = "screens";

	private static readonly IntPtr selScreensHandle = Selector.GetHandle("screens");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScreensHaveSeparateSpaces = "screensHaveSeparateSpaces";

	private static readonly IntPtr selScreensHaveSeparateSpacesHandle = Selector.GetHandle("screensHaveSeparateSpaces");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupportedWindowDepths = "supportedWindowDepths";

	private static readonly IntPtr selSupportedWindowDepthsHandle = Selector.GetHandle("supportedWindowDepths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserSpaceScaleFactor = "userSpaceScaleFactor";

	private static readonly IntPtr selUserSpaceScaleFactorHandle = Selector.GetHandle("userSpaceScaleFactor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVisibleFrame = "visibleFrame";

	private static readonly IntPtr selVisibleFrameHandle = Selector.GetHandle("visibleFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSScreen");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ColorSpaceDidChangeNotification;

	public NSWindowDepth[] SupportedWindowDepths
	{
		get
		{
			List<NSWindowDepth> list = new List<NSWindowDepth>();
			IntPtr intPtr = GetSupportedWindowDepths();
			if (intPtr != IntPtr.Zero)
			{
				for (int num = Marshal.ReadInt32(intPtr); num != 0; num = Marshal.ReadInt32(intPtr))
				{
					list.Add((NSWindowDepth)num);
					intPtr = (IntPtr)(intPtr.ToInt64() + 4);
				}
			}
			return list.ToArray();
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat BackingScaleFactor
	{
		[Export("backingScaleFactor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selBackingScaleFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selBackingScaleFactorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSColorSpace ColorSpace
	{
		[Export("colorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceHandle));
			}
			return Runtime.GetNSObject<NSColorSpace>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[ThreadSafe]
	public static NSScreen DeepestScreen
	{
		[Export("deepestScreen")]
		get
		{
			return Runtime.GetNSObject<NSScreen>(Messaging.IntPtr_objc_msgSend(class_ptr, selDeepestScreenHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSWindowDepth Depth
	{
		[Export("depth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSWindowDepth)Messaging.int_objc_msgSend(base.Handle, selDepthHandle);
			}
			return (NSWindowDepth)Messaging.int_objc_msgSendSuper(base.SuperHandle, selDepthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary DeviceDescription
	{
		[Export("deviceDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceDescriptionHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Frame
	{
		[Export("frame")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selFrameHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual string LocalizedName
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("localizedName", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[ThreadSafe]
	public static NSScreen MainScreen
	{
		[Export("mainScreen")]
		get
		{
			return Runtime.GetNSObject<NSScreen>(Messaging.IntPtr_objc_msgSend(class_ptr, selMainScreenHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual nfloat MaximumExtendedDynamicRangeColorComponentValue
	{
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("maximumExtendedDynamicRangeColorComponentValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMaximumExtendedDynamicRangeColorComponentValueHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMaximumExtendedDynamicRangeColorComponentValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual nfloat MaximumPotentialExtendedDynamicRangeColorComponentValue
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("maximumPotentialExtendedDynamicRangeColorComponentValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMaximumPotentialExtendedDynamicRangeColorComponentValueHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMaximumPotentialExtendedDynamicRangeColorComponentValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual nfloat MaximumReferenceExtendedDynamicRangeColorComponentValue
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("maximumReferenceExtendedDynamicRangeColorComponentValue")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMaximumReferenceExtendedDynamicRangeColorComponentValueHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMaximumReferenceExtendedDynamicRangeColorComponentValueHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[ThreadSafe]
	public static NSScreen[] Screens
	{
		[Export("screens", ArgumentSemantic.Copy)]
		get
		{
			return NSArray.ArrayFromHandle<NSScreen>(Messaging.IntPtr_objc_msgSend(class_ptr, selScreensHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
	public virtual nfloat UserSpaceScaleFactor
	{
		[Deprecated(PlatformName.MacOSX, 10, 7, PlatformArchitecture.All, null)]
		[Export("userSpaceScaleFactor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selUserSpaceScaleFactorHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selUserSpaceScaleFactorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect VisibleFrame
	{
		[Export("visibleFrame")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selVisibleFrameHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selVisibleFrameHandle);
			}
			return retval;
		}
	}

	[Field("NSScreenColorSpaceDidChangeNotification", "AppKit")]
	[Advice("Use NSScreen.Notifications.ObserveColorSpaceDidChange helper method instead.")]
	public static NSString ColorSpaceDidChangeNotification
	{
		get
		{
			if (_ColorSpaceDidChangeNotification == null)
			{
				_ColorSpaceDidChangeNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSScreenColorSpaceDidChangeNotification");
			}
			return _ColorSpaceDidChangeNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSScreen()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSScreen(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSScreen(IntPtr handle)
		: base(handle)
	{
	}

	[Export("canRepresentDisplayGamut:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanRepresentDisplayGamut(NSDisplayGamut displayGamut)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selCanRepresentDisplayGamut_Handle, (long)displayGamut);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selCanRepresentDisplayGamut_Handle, (long)displayGamut);
	}

	[Export("convertRectToBacking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectToBacking(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectToBacking_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectToBacking_Handle, aRect);
		}
		return retval;
	}

	[Export("convertRectFromBacking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect ConvertRectfromBacking(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect(out retval, base.Handle, selConvertRectFromBacking_Handle, aRect);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect(out retval, base.SuperHandle, selConvertRectFromBacking_Handle, aRect);
		}
		return retval;
	}

	[Export("backingAlignedRect:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect GetBackingAlignedRect(CGRect globalScreenCoordRect, NSAlignmentOptions options)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_Int64(out retval, base.Handle, selBackingAlignedRect_Options_Handle, globalScreenCoordRect, (long)options);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_Int64(out retval, base.SuperHandle, selBackingAlignedRect_Options_Handle, globalScreenCoordRect, (long)options);
		}
		return retval;
	}

	[Export("supportedWindowDepths")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr GetSupportedWindowDepths()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedWindowDepthsHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedWindowDepthsHandle);
	}

	[Export("screensHaveSeparateSpaces")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ScreensHaveSeparateSpaces()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(class_ptr, selScreensHaveSeparateSpacesHandle);
	}
}
