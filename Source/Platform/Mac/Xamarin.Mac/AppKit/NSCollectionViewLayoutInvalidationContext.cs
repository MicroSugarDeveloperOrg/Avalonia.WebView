using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionViewLayoutInvalidationContext", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSCollectionViewLayoutInvalidationContext : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentOffsetAdjustment = "contentOffsetAdjustment";

	private static readonly IntPtr selContentOffsetAdjustmentHandle = Selector.GetHandle("contentOffsetAdjustment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentSizeAdjustment = "contentSizeAdjustment";

	private static readonly IntPtr selContentSizeAdjustmentHandle = Selector.GetHandle("contentSizeAdjustment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateDataSourceCounts = "invalidateDataSourceCounts";

	private static readonly IntPtr selInvalidateDataSourceCountsHandle = Selector.GetHandle("invalidateDataSourceCounts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateDecorationElementsOfKind_AtIndexPaths_ = "invalidateDecorationElementsOfKind:atIndexPaths:";

	private static readonly IntPtr selInvalidateDecorationElementsOfKind_AtIndexPaths_Handle = Selector.GetHandle("invalidateDecorationElementsOfKind:atIndexPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateEverything = "invalidateEverything";

	private static readonly IntPtr selInvalidateEverythingHandle = Selector.GetHandle("invalidateEverything");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateItemsAtIndexPaths_ = "invalidateItemsAtIndexPaths:";

	private static readonly IntPtr selInvalidateItemsAtIndexPaths_Handle = Selector.GetHandle("invalidateItemsAtIndexPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateSupplementaryElementsOfKind_AtIndexPaths_ = "invalidateSupplementaryElementsOfKind:atIndexPaths:";

	private static readonly IntPtr selInvalidateSupplementaryElementsOfKind_AtIndexPaths_Handle = Selector.GetHandle("invalidateSupplementaryElementsOfKind:atIndexPaths:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidatedDecorationIndexPaths = "invalidatedDecorationIndexPaths";

	private static readonly IntPtr selInvalidatedDecorationIndexPathsHandle = Selector.GetHandle("invalidatedDecorationIndexPaths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidatedItemIndexPaths = "invalidatedItemIndexPaths";

	private static readonly IntPtr selInvalidatedItemIndexPathsHandle = Selector.GetHandle("invalidatedItemIndexPaths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidatedSupplementaryIndexPaths = "invalidatedSupplementaryIndexPaths";

	private static readonly IntPtr selInvalidatedSupplementaryIndexPathsHandle = Selector.GetHandle("invalidatedSupplementaryIndexPaths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentOffsetAdjustment_ = "setContentOffsetAdjustment:";

	private static readonly IntPtr selSetContentOffsetAdjustment_Handle = Selector.GetHandle("setContentOffsetAdjustment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentSizeAdjustment_ = "setContentSizeAdjustment:";

	private static readonly IntPtr selSetContentSizeAdjustment_Handle = Selector.GetHandle("setContentSizeAdjustment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionViewLayoutInvalidationContext");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint ContentOffsetAdjustment
	{
		[Export("contentOffsetAdjustment", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selContentOffsetAdjustmentHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selContentOffsetAdjustmentHandle);
		}
		[Export("setContentOffsetAdjustment:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetContentOffsetAdjustment_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetContentOffsetAdjustment_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ContentSizeAdjustment
	{
		[Export("contentSizeAdjustment", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selContentSizeAdjustmentHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selContentSizeAdjustmentHandle);
		}
		[Export("setContentSizeAdjustment:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetContentSizeAdjustment_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetContentSizeAdjustment_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InvalidateDataSourceCounts
	{
		[Export("invalidateDataSourceCounts")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selInvalidateDataSourceCountsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selInvalidateDataSourceCountsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool InvalidateEverything
	{
		[Export("invalidateEverything")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selInvalidateEverythingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selInvalidateEverythingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary InvalidatedDecorationIndexPaths
	{
		[Export("invalidatedDecorationIndexPaths")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selInvalidatedDecorationIndexPathsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInvalidatedDecorationIndexPathsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet InvalidatedItemIndexPaths
	{
		[Export("invalidatedItemIndexPaths")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selInvalidatedItemIndexPathsHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInvalidatedItemIndexPathsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary InvalidatedSupplementaryIndexPaths
	{
		[Export("invalidatedSupplementaryIndexPaths")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selInvalidatedSupplementaryIndexPathsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInvalidatedSupplementaryIndexPathsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCollectionViewLayoutInvalidationContext()
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
	protected NSCollectionViewLayoutInvalidationContext(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionViewLayoutInvalidationContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("invalidateDecorationElementsOfKind:atIndexPaths:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateDecorationElements(NSString elementKind, NSSet indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInvalidateDecorationElementsOfKind_AtIndexPaths_Handle, elementKind.Handle, indexPaths.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInvalidateDecorationElementsOfKind_AtIndexPaths_Handle, elementKind.Handle, indexPaths.Handle);
		}
	}

	[Export("invalidateItemsAtIndexPaths:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateItems(NSSet indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInvalidateItemsAtIndexPaths_Handle, indexPaths.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInvalidateItemsAtIndexPaths_Handle, indexPaths.Handle);
		}
	}

	[Export("invalidateSupplementaryElementsOfKind:atIndexPaths:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateSupplementaryElements(NSString elementKind, NSSet indexPaths)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (indexPaths == null)
		{
			throw new ArgumentNullException("indexPaths");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selInvalidateSupplementaryElementsOfKind_AtIndexPaths_Handle, elementKind.Handle, indexPaths.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInvalidateSupplementaryElementsOfKind_AtIndexPaths_Handle, elementKind.Handle, indexPaths.Handle);
		}
	}
}
