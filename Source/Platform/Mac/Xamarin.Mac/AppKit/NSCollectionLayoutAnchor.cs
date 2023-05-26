using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionLayoutAnchor", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSCollectionLayoutAnchor : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEdges = "edges";

	private static readonly IntPtr selEdgesHandle = Selector.GetHandle("edges");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAbsoluteOffset = "isAbsoluteOffset";

	private static readonly IntPtr selIsAbsoluteOffsetHandle = Selector.GetHandle("isAbsoluteOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsFractionalOffset = "isFractionalOffset";

	private static readonly IntPtr selIsFractionalOffsetHandle = Selector.GetHandle("isFractionalOffset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAnchorWithEdges_ = "layoutAnchorWithEdges:";

	private static readonly IntPtr selLayoutAnchorWithEdges_Handle = Selector.GetHandle("layoutAnchorWithEdges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAnchorWithEdges_AbsoluteOffset_ = "layoutAnchorWithEdges:absoluteOffset:";

	private static readonly IntPtr selLayoutAnchorWithEdges_AbsoluteOffset_Handle = Selector.GetHandle("layoutAnchorWithEdges:absoluteOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAnchorWithEdges_FractionalOffset_ = "layoutAnchorWithEdges:fractionalOffset:";

	private static readonly IntPtr selLayoutAnchorWithEdges_FractionalOffset_Handle = Selector.GetHandle("layoutAnchorWithEdges:fractionalOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOffset = "offset";

	private static readonly IntPtr selOffsetHandle = Selector.GetHandle("offset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionLayoutAnchor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDirectionalRectEdge Edges
	{
		[Export("edges")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSDirectionalRectEdge)Messaging.UInt64_objc_msgSend(base.Handle, selEdgesHandle);
			}
			return (NSDirectionalRectEdge)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selEdgesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsAbsoluteOffset
	{
		[Export("isAbsoluteOffset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAbsoluteOffsetHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAbsoluteOffsetHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsFractionalOffset
	{
		[Export("isFractionalOffset")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsFractionalOffsetHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsFractionalOffsetHandle);
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

	public static NSCollectionLayoutAnchor Create(NSDirectionalRectEdge edges, NSCollectionLayoutAnchorOffsetType offsetType, CGPoint offset)
	{
		return offsetType switch
		{
			NSCollectionLayoutAnchorOffsetType.Absolute => _LayoutAnchorWithEdgesAbsoluteOffset(edges, offset), 
			NSCollectionLayoutAnchorOffsetType.Fractional => _LayoutAnchorWithEdgesFractionalOffset(edges, offset), 
			_ => throw new ArgumentException("Invalid enum value", "offsetType"), 
		};
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCollectionLayoutAnchor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionLayoutAnchor(IntPtr handle)
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

	[Export("layoutAnchorWithEdges:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutAnchor Create(NSDirectionalRectEdge edges)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSCollectionLayoutAnchor>(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selLayoutAnchorWithEdges_Handle, (ulong)edges));
	}

	[Export("layoutAnchorWithEdges:absoluteOffset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSCollectionLayoutAnchor _LayoutAnchorWithEdgesAbsoluteOffset(NSDirectionalRectEdge edges, CGPoint absoluteOffset)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSCollectionLayoutAnchor>(Messaging.IntPtr_objc_msgSend_UInt64_CGPoint(class_ptr, selLayoutAnchorWithEdges_AbsoluteOffset_Handle, (ulong)edges, absoluteOffset));
	}

	[Export("layoutAnchorWithEdges:fractionalOffset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSCollectionLayoutAnchor _LayoutAnchorWithEdgesFractionalOffset(NSDirectionalRectEdge edges, CGPoint fractionalOffset)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSCollectionLayoutAnchor>(Messaging.IntPtr_objc_msgSend_UInt64_CGPoint(class_ptr, selLayoutAnchorWithEdges_FractionalOffset_Handle, (ulong)edges, fractionalOffset));
	}
}
