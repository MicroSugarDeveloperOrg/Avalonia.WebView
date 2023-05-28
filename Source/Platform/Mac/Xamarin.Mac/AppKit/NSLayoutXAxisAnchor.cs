using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSLayoutXAxisAnchor", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSLayoutXAxisAnchor : NSLayoutAnchor<NSLayoutXAxisAnchor>
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnchorWithOffsetToAnchor_ = "anchorWithOffsetToAnchor:";

	private static readonly IntPtr selAnchorWithOffsetToAnchor_Handle = Selector.GetHandle("anchorWithOffsetToAnchor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSLayoutXAxisAnchor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSLayoutXAxisAnchor(NSCoder coder)
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
	protected NSLayoutXAxisAnchor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSLayoutXAxisAnchor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("anchorWithOffsetToAnchor:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLayoutDimension GetAnchorWithOffset(NSLayoutXAxisAnchor otherAnchor)
	{
		NSApplication.EnsureUIThread();
		if (otherAnchor == null)
		{
			throw new ArgumentNullException("otherAnchor");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSLayoutDimension>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnchorWithOffsetToAnchor_Handle, otherAnchor.Handle));
		}
		return Runtime.GetNSObject<NSLayoutDimension>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnchorWithOffsetToAnchor_Handle, otherAnchor.Handle));
	}
}
