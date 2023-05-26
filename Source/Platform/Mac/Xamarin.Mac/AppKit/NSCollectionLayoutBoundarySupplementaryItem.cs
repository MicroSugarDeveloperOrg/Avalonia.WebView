using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionLayoutBoundarySupplementaryItem", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSCollectionLayoutBoundarySupplementaryItem : NSCollectionLayoutSupplementaryItem, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlignment = "alignment";

	private static readonly IntPtr selAlignmentHandle = Selector.GetHandle("alignment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundarySupplementaryItemWithLayoutSize_ElementKind_Alignment_ = "boundarySupplementaryItemWithLayoutSize:elementKind:alignment:";

	private static readonly IntPtr selBoundarySupplementaryItemWithLayoutSize_ElementKind_Alignment_Handle = Selector.GetHandle("boundarySupplementaryItemWithLayoutSize:elementKind:alignment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundarySupplementaryItemWithLayoutSize_ElementKind_Alignment_AbsoluteOffset_ = "boundarySupplementaryItemWithLayoutSize:elementKind:alignment:absoluteOffset:";

	private static readonly IntPtr selBoundarySupplementaryItemWithLayoutSize_ElementKind_Alignment_AbsoluteOffset_Handle = Selector.GetHandle("boundarySupplementaryItemWithLayoutSize:elementKind:alignment:absoluteOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExtendsBoundary = "extendsBoundary";

	private static readonly IntPtr selExtendsBoundaryHandle = Selector.GetHandle("extendsBoundary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOffset = "offset";

	private static readonly IntPtr selOffsetHandle = Selector.GetHandle("offset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPinToVisibleBounds = "pinToVisibleBounds";

	private static readonly IntPtr selPinToVisibleBoundsHandle = Selector.GetHandle("pinToVisibleBounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExtendsBoundary_ = "setExtendsBoundary:";

	private static readonly IntPtr selSetExtendsBoundary_Handle = Selector.GetHandle("setExtendsBoundary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPinToVisibleBounds_ = "setPinToVisibleBounds:";

	private static readonly IntPtr selSetPinToVisibleBounds_Handle = Selector.GetHandle("setPinToVisibleBounds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionLayoutBoundarySupplementaryItem");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRectAlignment Alignment
	{
		[Export("alignment")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSRectAlignment)Messaging.Int64_objc_msgSend(base.Handle, selAlignmentHandle);
			}
			return (NSRectAlignment)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selAlignmentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ExtendsBoundary
	{
		[Export("extendsBoundary")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selExtendsBoundaryHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selExtendsBoundaryHandle);
		}
		[Export("setExtendsBoundary:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetExtendsBoundary_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetExtendsBoundary_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint Offset
	{
		[Export("offset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selOffsetHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selOffsetHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PinToVisibleBounds
	{
		[Export("pinToVisibleBounds")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPinToVisibleBoundsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPinToVisibleBoundsHandle);
		}
		[Export("setPinToVisibleBounds:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPinToVisibleBounds_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPinToVisibleBounds_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCollectionLayoutBoundarySupplementaryItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionLayoutBoundarySupplementaryItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public new virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("boundarySupplementaryItemWithLayoutSize:elementKind:alignment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutBoundarySupplementaryItem Create(NSCollectionLayoutSize layoutSize, string elementKind, NSRectAlignment alignment)
	{
		NSApplication.EnsureUIThread();
		if (layoutSize == null)
		{
			throw new ArgumentNullException("layoutSize");
		}
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		IntPtr arg = NSString.CreateNative(elementKind);
		NSCollectionLayoutBoundarySupplementaryItem nSObject = Runtime.GetNSObject<NSCollectionLayoutBoundarySupplementaryItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Int64(class_ptr, selBoundarySupplementaryItemWithLayoutSize_ElementKind_Alignment_Handle, layoutSize.Handle, arg, (long)alignment));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("boundarySupplementaryItemWithLayoutSize:elementKind:alignment:absoluteOffset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutBoundarySupplementaryItem Create(NSCollectionLayoutSize layoutSize, string elementKind, NSRectAlignment alignment, CGPoint absoluteOffset)
	{
		NSApplication.EnsureUIThread();
		if (layoutSize == null)
		{
			throw new ArgumentNullException("layoutSize");
		}
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		IntPtr arg = NSString.CreateNative(elementKind);
		NSCollectionLayoutBoundarySupplementaryItem nSObject = Runtime.GetNSObject<NSCollectionLayoutBoundarySupplementaryItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Int64_CGPoint(class_ptr, selBoundarySupplementaryItemWithLayoutSize_ElementKind_Alignment_AbsoluteOffset_Handle, layoutSize.Handle, arg, (long)alignment, absoluteOffset));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
