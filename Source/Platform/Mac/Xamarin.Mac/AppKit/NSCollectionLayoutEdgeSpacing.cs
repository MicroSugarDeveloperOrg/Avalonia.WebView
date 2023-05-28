using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionLayoutEdgeSpacing", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSCollectionLayoutEdgeSpacing : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBottom = "bottom";

	private static readonly IntPtr selBottomHandle = Selector.GetHandle("bottom");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLeading = "leading";

	private static readonly IntPtr selLeadingHandle = Selector.GetHandle("leading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpacingForLeading_Top_Trailing_Bottom_ = "spacingForLeading:top:trailing:bottom:";

	private static readonly IntPtr selSpacingForLeading_Top_Trailing_Bottom_Handle = Selector.GetHandle("spacingForLeading:top:trailing:bottom:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTop = "top";

	private static readonly IntPtr selTopHandle = Selector.GetHandle("top");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrailing = "trailing";

	private static readonly IntPtr selTrailingHandle = Selector.GetHandle("trailing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionLayoutEdgeSpacing");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutSpacing? Bottom
	{
		[Export("bottom")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCollectionLayoutSpacing>(Messaging.IntPtr_objc_msgSend(base.Handle, selBottomHandle));
			}
			return Runtime.GetNSObject<NSCollectionLayoutSpacing>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBottomHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutSpacing? Leading
	{
		[Export("leading")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCollectionLayoutSpacing>(Messaging.IntPtr_objc_msgSend(base.Handle, selLeadingHandle));
			}
			return Runtime.GetNSObject<NSCollectionLayoutSpacing>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLeadingHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutSpacing? Top
	{
		[Export("top")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCollectionLayoutSpacing>(Messaging.IntPtr_objc_msgSend(base.Handle, selTopHandle));
			}
			return Runtime.GetNSObject<NSCollectionLayoutSpacing>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTopHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutSpacing? Trailing
	{
		[Export("trailing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCollectionLayoutSpacing>(Messaging.IntPtr_objc_msgSend(base.Handle, selTrailingHandle));
			}
			return Runtime.GetNSObject<NSCollectionLayoutSpacing>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTrailingHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCollectionLayoutEdgeSpacing(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionLayoutEdgeSpacing(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("spacingForLeading:top:trailing:bottom:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutEdgeSpacing CreateSpacing(NSCollectionLayoutSpacing? leading, NSCollectionLayoutSpacing? top, NSCollectionLayoutSpacing? trailing, NSCollectionLayoutSpacing? bottom)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSCollectionLayoutEdgeSpacing>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selSpacingForLeading_Top_Trailing_Bottom_Handle, leading?.Handle ?? IntPtr.Zero, top?.Handle ?? IntPtr.Zero, trailing?.Handle ?? IntPtr.Zero, bottom?.Handle ?? IntPtr.Zero));
	}
}
