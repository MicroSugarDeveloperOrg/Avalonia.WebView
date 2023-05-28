using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSVisualEffectView", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSVisualEffectView : NSView
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlendingMode = "blendingMode";

	private static readonly IntPtr selBlendingModeHandle = Selector.GetHandle("blendingMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInteriorBackgroundStyle = "interiorBackgroundStyle";

	private static readonly IntPtr selInteriorBackgroundStyleHandle = Selector.GetHandle("interiorBackgroundStyle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEmphasized = "isEmphasized";

	private static readonly IntPtr selIsEmphasizedHandle = Selector.GetHandle("isEmphasized");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaskImage = "maskImage";

	private static readonly IntPtr selMaskImageHandle = Selector.GetHandle("maskImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaterial = "material";

	private static readonly IntPtr selMaterialHandle = Selector.GetHandle("material");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBlendingMode_ = "setBlendingMode:";

	private static readonly IntPtr selSetBlendingMode_Handle = Selector.GetHandle("setBlendingMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEmphasized_ = "setEmphasized:";

	private static readonly IntPtr selSetEmphasized_Handle = Selector.GetHandle("setEmphasized:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaskImage_ = "setMaskImage:";

	private static readonly IntPtr selSetMaskImage_Handle = Selector.GetHandle("setMaskImage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaterial_ = "setMaterial:";

	private static readonly IntPtr selSetMaterial_Handle = Selector.GetHandle("setMaterial:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetState_ = "setState:";

	private static readonly IntPtr selSetState_Handle = Selector.GetHandle("setState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selState = "state";

	private static readonly IntPtr selStateHandle = Selector.GetHandle("state");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewDidMoveToWindow = "viewDidMoveToWindow";

	private static readonly IntPtr selViewDidMoveToWindowHandle = Selector.GetHandle("viewDidMoveToWindow");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewWillMoveToWindow_ = "viewWillMoveToWindow:";

	private static readonly IntPtr selViewWillMoveToWindow_Handle = Selector.GetHandle("viewWillMoveToWindow:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSVisualEffectView");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSVisualEffectBlendingMode BlendingMode
	{
		[Export("blendingMode")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSVisualEffectBlendingMode)Messaging.Int64_objc_msgSend(base.Handle, selBlendingModeHandle);
			}
			return (NSVisualEffectBlendingMode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBlendingModeHandle);
		}
		[Export("setBlendingMode:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetBlendingMode_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetBlendingMode_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool Emphasized
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("isEmphasized")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEmphasizedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEmphasizedHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setEmphasized:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEmphasized_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEmphasized_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSBackgroundStyle InteriorBackgroundStyle
	{
		[Export("interiorBackgroundStyle")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSBackgroundStyle)Messaging.Int64_objc_msgSend(base.Handle, selInteriorBackgroundStyleHandle);
			}
			return (NSBackgroundStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selInteriorBackgroundStyleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSImage MaskImage
	{
		[Export("maskImage", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selMaskImageHandle));
			}
			return Runtime.GetNSObject<NSImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMaskImageHandle));
		}
		[Export("setMaskImage:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMaskImage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMaskImage_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSVisualEffectMaterial Material
	{
		[Export("material")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSVisualEffectMaterial)Messaging.Int64_objc_msgSend(base.Handle, selMaterialHandle);
			}
			return (NSVisualEffectMaterial)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMaterialHandle);
		}
		[Export("setMaterial:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetMaterial_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetMaterial_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSVisualEffectState State
	{
		[Export("state")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSVisualEffectState)Messaging.Int64_objc_msgSend(base.Handle, selStateHandle);
			}
			return (NSVisualEffectState)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStateHandle);
		}
		[Export("setState:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetState_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetState_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSVisualEffectView()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSVisualEffectView(NSCoder coder)
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
	protected NSVisualEffectView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSVisualEffectView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSVisualEffectView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("viewDidMoveToWindow")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual void ViewDidMove()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selViewDidMoveToWindowHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selViewDidMoveToWindowHandle);
		}
	}

	[Export("viewWillMoveToWindow:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Overriding this method requires a call to the overriden method.")]
	[RequiresSuper]
	public virtual void ViewWillMove(NSWindow newWindow)
	{
		NSApplication.EnsureUIThread();
		if (newWindow == null)
		{
			throw new ArgumentNullException("newWindow");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selViewWillMoveToWindow_Handle, newWindow.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selViewWillMoveToWindow_Handle, newWindow.Handle);
		}
	}
}
