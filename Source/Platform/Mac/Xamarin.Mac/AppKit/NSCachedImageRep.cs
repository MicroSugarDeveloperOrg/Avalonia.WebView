using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCachedImageRep", true)]
[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, null)]
public class NSCachedImageRep : NSImageRep
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithSize_Depth_Separate_Alpha_ = "initWithSize:depth:separate:alpha:";

	private static readonly IntPtr selInitWithSize_Depth_Separate_Alpha_Handle = Selector.GetHandle("initWithSize:depth:separate:alpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithWindow_Rect_ = "initWithWindow:rect:";

	private static readonly IntPtr selInitWithWindow_Rect_Handle = Selector.GetHandle("initWithWindow:rect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRect = "rect";

	private static readonly IntPtr selRectHandle = Selector.GetHandle("rect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWindow = "window";

	private static readonly IntPtr selWindowHandle = Selector.GetHandle("window");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCachedImageRep");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, null)]
	public virtual CGRect Rectangle
	{
		[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, null)]
		[Export("rect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRectHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, null)]
	public virtual NSWindow Window
	{
		[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, null)]
		[Export("window")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSend(base.Handle, selWindowHandle));
			}
			return Runtime.GetNSObject<NSWindow>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWindowHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSCachedImageRep(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCachedImageRep(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCachedImageRep(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithWindow:rect:")]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCachedImageRep(NSWindow win, CGRect rect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (win == null)
		{
			throw new ArgumentNullException("win");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_CGRect(base.Handle, selInitWithWindow_Rect_Handle, win.Handle, rect), "initWithWindow:rect:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_CGRect(base.SuperHandle, selInitWithWindow_Rect_Handle, win.Handle, rect), "initWithWindow:rect:");
		}
	}

	[Export("initWithSize:depth:separate:alpha:")]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSCachedImageRep(CGSize size, NSWindowDepth depth, bool separate, bool alpha)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGSize_int_bool_bool(base.Handle, selInitWithSize_Depth_Separate_Alpha_Handle, size, (int)depth, separate, alpha), "initWithSize:depth:separate:alpha:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGSize_int_bool_bool(base.SuperHandle, selInitWithSize_Depth_Separate_Alpha_Handle, size, (int)depth, separate, alpha), "initWithSize:depth:separate:alpha:");
		}
	}
}
