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
	private static readonly IntPtr selScreensHandle = Selector.GetHandle("screens");

	private static readonly IntPtr selMainScreenHandle = Selector.GetHandle("mainScreen");

	private static readonly IntPtr selDeepestScreenHandle = Selector.GetHandle("deepestScreen");

	private static readonly IntPtr selDepthHandle = Selector.GetHandle("depth");

	private static readonly IntPtr selFrameHandle = Selector.GetHandle("frame");

	private static readonly IntPtr selVisibleFrameHandle = Selector.GetHandle("visibleFrame");

	private static readonly IntPtr selDeviceDescriptionHandle = Selector.GetHandle("deviceDescription");

	private static readonly IntPtr selColorSpaceHandle = Selector.GetHandle("colorSpace");

	private static readonly IntPtr selUserSpaceScaleFactorHandle = Selector.GetHandle("userSpaceScaleFactor");

	private static readonly IntPtr selBackingScaleFactorHandle = Selector.GetHandle("backingScaleFactor");

	private static readonly IntPtr selSupportedWindowDepthsHandle = Selector.GetHandle("supportedWindowDepths");

	private static readonly IntPtr selConvertRectToBacking_Handle = Selector.GetHandle("convertRectToBacking:");

	private static readonly IntPtr selConvertRectFromBacking_Handle = Selector.GetHandle("convertRectFromBacking:");

	private static readonly IntPtr selBackingAlignedRectOptions_Handle = Selector.GetHandle("backingAlignedRect:options:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSScreen");

	private static object __mt_Screens_var_static;

	private static object __mt_MainScreen_var_static;

	private static object __mt_DeepestScreen_var_static;

	private object __mt_DeviceDescription_var;

	private object __mt_ColorSpace_var;

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
					intPtr = (IntPtr)(intPtr.ToInt64() + IntPtr.Size);
				}
			}
			return list.ToArray();
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public static NSScreen[] Screens
	{
		[Export("screens")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSScreen[])(__mt_Screens_var_static = NSArray.ArrayFromHandle<NSScreen>(Messaging.IntPtr_objc_msgSend(class_ptr, selScreensHandle)));
		}
	}

	public static NSScreen MainScreen
	{
		[Export("mainScreen")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSScreen)(__mt_MainScreen_var_static = (NSScreen)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selMainScreenHandle)));
		}
	}

	public static NSScreen DeepestScreen
	{
		[Export("deepestScreen")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSScreen)(__mt_DeepestScreen_var_static = (NSScreen)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDeepestScreenHandle)));
		}
	}

	public virtual NSWindowDepth Depth
	{
		[Export("depth")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSWindowDepth)Messaging.Int64_objc_msgSend(base.Handle, selDepthHandle);
			}
			return (NSWindowDepth)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDepthHandle);
		}
	}

	public virtual CGRect Frame
	{
		[Export("frame")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
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

	public virtual CGRect VisibleFrame
	{
		[Export("visibleFrame")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
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

	public virtual NSDictionary DeviceDescription
	{
		[Export("deviceDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_DeviceDescription_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDeviceDescriptionHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDeviceDescriptionHandle)))));
		}
	}

	public virtual NSColorSpace ColorSpace
	{
		[Export("colorSpace")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSColorSpace)(__mt_ColorSpace_var = ((!IsDirectBinding) ? ((NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorSpaceHandle))) : ((NSColorSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selColorSpaceHandle)))));
		}
	}

	[Obsolete("On Lion", false)]
	public virtual double UserSpaceScaleFactor
	{
		[Export("userSpaceScaleFactor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selUserSpaceScaleFactorHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selUserSpaceScaleFactorHandle);
		}
	}

	public virtual double BackingScaleFactor
	{
		[Export("backingScaleFactor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selBackingScaleFactorHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selBackingScaleFactorHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSScreen()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSScreen(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSScreen(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSScreen(IntPtr handle)
		: base(handle)
	{
	}

	[Export("supportedWindowDepths")]
	internal virtual IntPtr GetSupportedWindowDepths()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend(base.Handle, selSupportedWindowDepthsHandle);
		}
		return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupportedWindowDepthsHandle);
	}

	[Export("convertRectToBacking:")]
	public virtual CGRect ConvertRectToBacking(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
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
	public virtual CGRect ConvertRectfromBacking(CGRect aRect)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
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
	public virtual CGRect GetBackingAlignedRect(CGRect globalScreenCoordRect, NSAlignmentOptions options)
	{
		NSApplication.EnsureUIThread();
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGRect_UInt64(out retval, base.Handle, selBackingAlignedRectOptions_Handle, globalScreenCoordRect, (ulong)options);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGRect_UInt64(out retval, base.SuperHandle, selBackingAlignedRectOptions_Handle, globalScreenCoordRect, (ulong)options);
		}
		return retval;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_DeviceDescription_var = null;
			__mt_ColorSpace_var = null;
		}
	}
}
