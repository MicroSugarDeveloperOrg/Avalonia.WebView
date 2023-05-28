using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionViewLayout", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSCollectionViewLayout : NSObject, INSCoding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollectionView = "collectionView";

	private static readonly IntPtr selCollectionViewHandle = Selector.GetHandle("collectionView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollectionViewContentSize = "collectionViewContentSize";

	private static readonly IntPtr selCollectionViewContentSizeHandle = Selector.GetHandle("collectionViewContentSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinalLayoutAttributesForDisappearingDecorationElementOfKind_AtIndexPath_ = "finalLayoutAttributesForDisappearingDecorationElementOfKind:atIndexPath:";

	private static readonly IntPtr selFinalLayoutAttributesForDisappearingDecorationElementOfKind_AtIndexPath_Handle = Selector.GetHandle("finalLayoutAttributesForDisappearingDecorationElementOfKind:atIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinalLayoutAttributesForDisappearingItemAtIndexPath_ = "finalLayoutAttributesForDisappearingItemAtIndexPath:";

	private static readonly IntPtr selFinalLayoutAttributesForDisappearingItemAtIndexPath_Handle = Selector.GetHandle("finalLayoutAttributesForDisappearingItemAtIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinalLayoutAttributesForDisappearingSupplementaryElementOfKind_AtIndexPath_ = "finalLayoutAttributesForDisappearingSupplementaryElementOfKind:atIndexPath:";

	private static readonly IntPtr selFinalLayoutAttributesForDisappearingSupplementaryElementOfKind_AtIndexPath_Handle = Selector.GetHandle("finalLayoutAttributesForDisappearingSupplementaryElementOfKind:atIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinalizeAnimatedBoundsChange = "finalizeAnimatedBoundsChange";

	private static readonly IntPtr selFinalizeAnimatedBoundsChangeHandle = Selector.GetHandle("finalizeAnimatedBoundsChange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinalizeCollectionViewUpdates = "finalizeCollectionViewUpdates";

	private static readonly IntPtr selFinalizeCollectionViewUpdatesHandle = Selector.GetHandle("finalizeCollectionViewUpdates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinalizeLayoutTransition = "finalizeLayoutTransition";

	private static readonly IntPtr selFinalizeLayoutTransitionHandle = Selector.GetHandle("finalizeLayoutTransition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathsToDeleteForDecorationViewOfKind_ = "indexPathsToDeleteForDecorationViewOfKind:";

	private static readonly IntPtr selIndexPathsToDeleteForDecorationViewOfKind_Handle = Selector.GetHandle("indexPathsToDeleteForDecorationViewOfKind:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathsToDeleteForSupplementaryViewOfKind_ = "indexPathsToDeleteForSupplementaryViewOfKind:";

	private static readonly IntPtr selIndexPathsToDeleteForSupplementaryViewOfKind_Handle = Selector.GetHandle("indexPathsToDeleteForSupplementaryViewOfKind:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathsToInsertForDecorationViewOfKind_ = "indexPathsToInsertForDecorationViewOfKind:";

	private static readonly IntPtr selIndexPathsToInsertForDecorationViewOfKind_Handle = Selector.GetHandle("indexPathsToInsertForDecorationViewOfKind:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathsToInsertForSupplementaryViewOfKind_ = "indexPathsToInsertForSupplementaryViewOfKind:";

	private static readonly IntPtr selIndexPathsToInsertForSupplementaryViewOfKind_Handle = Selector.GetHandle("indexPathsToInsertForSupplementaryViewOfKind:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitialLayoutAttributesForAppearingDecorationElementOfKind_AtIndexPath_ = "initialLayoutAttributesForAppearingDecorationElementOfKind:atIndexPath:";

	private static readonly IntPtr selInitialLayoutAttributesForAppearingDecorationElementOfKind_AtIndexPath_Handle = Selector.GetHandle("initialLayoutAttributesForAppearingDecorationElementOfKind:atIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitialLayoutAttributesForAppearingItemAtIndexPath_ = "initialLayoutAttributesForAppearingItemAtIndexPath:";

	private static readonly IntPtr selInitialLayoutAttributesForAppearingItemAtIndexPath_Handle = Selector.GetHandle("initialLayoutAttributesForAppearingItemAtIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitialLayoutAttributesForAppearingSupplementaryElementOfKind_AtIndexPath_ = "initialLayoutAttributesForAppearingSupplementaryElementOfKind:atIndexPath:";

	private static readonly IntPtr selInitialLayoutAttributesForAppearingSupplementaryElementOfKind_AtIndexPath_Handle = Selector.GetHandle("initialLayoutAttributesForAppearingSupplementaryElementOfKind:atIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateLayout = "invalidateLayout";

	private static readonly IntPtr selInvalidateLayoutHandle = Selector.GetHandle("invalidateLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidateLayoutWithContext_ = "invalidateLayoutWithContext:";

	private static readonly IntPtr selInvalidateLayoutWithContext_Handle = Selector.GetHandle("invalidateLayoutWithContext:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidationContextClass = "invalidationContextClass";

	private static readonly IntPtr selInvalidationContextClassHandle = Selector.GetHandle("invalidationContextClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidationContextForBoundsChange_ = "invalidationContextForBoundsChange:";

	private static readonly IntPtr selInvalidationContextForBoundsChange_Handle = Selector.GetHandle("invalidationContextForBoundsChange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidationContextForPreferredLayoutAttributes_WithOriginalAttributes_ = "invalidationContextForPreferredLayoutAttributes:withOriginalAttributes:";

	private static readonly IntPtr selInvalidationContextForPreferredLayoutAttributes_WithOriginalAttributes_Handle = Selector.GetHandle("invalidationContextForPreferredLayoutAttributes:withOriginalAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttributesClass = "layoutAttributesClass";

	private static readonly IntPtr selLayoutAttributesClassHandle = Selector.GetHandle("layoutAttributesClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttributesForDecorationViewOfKind_AtIndexPath_ = "layoutAttributesForDecorationViewOfKind:atIndexPath:";

	private static readonly IntPtr selLayoutAttributesForDecorationViewOfKind_AtIndexPath_Handle = Selector.GetHandle("layoutAttributesForDecorationViewOfKind:atIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttributesForDropTargetAtPoint_ = "layoutAttributesForDropTargetAtPoint:";

	private static readonly IntPtr selLayoutAttributesForDropTargetAtPoint_Handle = Selector.GetHandle("layoutAttributesForDropTargetAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttributesForElementsInRect_ = "layoutAttributesForElementsInRect:";

	private static readonly IntPtr selLayoutAttributesForElementsInRect_Handle = Selector.GetHandle("layoutAttributesForElementsInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttributesForInterItemGapBeforeIndexPath_ = "layoutAttributesForInterItemGapBeforeIndexPath:";

	private static readonly IntPtr selLayoutAttributesForInterItemGapBeforeIndexPath_Handle = Selector.GetHandle("layoutAttributesForInterItemGapBeforeIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttributesForItemAtIndexPath_ = "layoutAttributesForItemAtIndexPath:";

	private static readonly IntPtr selLayoutAttributesForItemAtIndexPath_Handle = Selector.GetHandle("layoutAttributesForItemAtIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttributesForSupplementaryViewOfKind_AtIndexPath_ = "layoutAttributesForSupplementaryViewOfKind:atIndexPath:";

	private static readonly IntPtr selLayoutAttributesForSupplementaryViewOfKind_AtIndexPath_Handle = Selector.GetHandle("layoutAttributesForSupplementaryViewOfKind:atIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForAnimatedBoundsChange_ = "prepareForAnimatedBoundsChange:";

	private static readonly IntPtr selPrepareForAnimatedBoundsChange_Handle = Selector.GetHandle("prepareForAnimatedBoundsChange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForCollectionViewUpdates_ = "prepareForCollectionViewUpdates:";

	private static readonly IntPtr selPrepareForCollectionViewUpdates_Handle = Selector.GetHandle("prepareForCollectionViewUpdates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForTransitionFromLayout_ = "prepareForTransitionFromLayout:";

	private static readonly IntPtr selPrepareForTransitionFromLayout_Handle = Selector.GetHandle("prepareForTransitionFromLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareForTransitionToLayout_ = "prepareForTransitionToLayout:";

	private static readonly IntPtr selPrepareForTransitionToLayout_Handle = Selector.GetHandle("prepareForTransitionToLayout:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareLayout = "prepareLayout";

	private static readonly IntPtr selPrepareLayoutHandle = Selector.GetHandle("prepareLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterClass_ForDecorationViewOfKind_ = "registerClass:forDecorationViewOfKind:";

	private static readonly IntPtr selRegisterClass_ForDecorationViewOfKind_Handle = Selector.GetHandle("registerClass:forDecorationViewOfKind:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegisterNib_ForDecorationViewOfKind_ = "registerNib:forDecorationViewOfKind:";

	private static readonly IntPtr selRegisterNib_ForDecorationViewOfKind_Handle = Selector.GetHandle("registerNib:forDecorationViewOfKind:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldInvalidateLayoutForBoundsChange_ = "shouldInvalidateLayoutForBoundsChange:";

	private static readonly IntPtr selShouldInvalidateLayoutForBoundsChange_Handle = Selector.GetHandle("shouldInvalidateLayoutForBoundsChange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShouldInvalidateLayoutForPreferredLayoutAttributes_WithOriginalAttributes_ = "shouldInvalidateLayoutForPreferredLayoutAttributes:withOriginalAttributes:";

	private static readonly IntPtr selShouldInvalidateLayoutForPreferredLayoutAttributes_WithOriginalAttributes_Handle = Selector.GetHandle("shouldInvalidateLayoutForPreferredLayoutAttributes:withOriginalAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTargetContentOffsetForProposedContentOffset_ = "targetContentOffsetForProposedContentOffset:";

	private static readonly IntPtr selTargetContentOffsetForProposedContentOffset_Handle = Selector.GetHandle("targetContentOffsetForProposedContentOffset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTargetContentOffsetForProposedContentOffset_WithScrollingVelocity_ = "targetContentOffsetForProposedContentOffset:withScrollingVelocity:";

	private static readonly IntPtr selTargetContentOffsetForProposedContentOffset_WithScrollingVelocity_Handle = Selector.GetHandle("targetContentOffsetForProposedContentOffset:withScrollingVelocity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionViewLayout");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_CollectionView_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionView? CollectionView
	{
		[Export("collectionView", ArgumentSemantic.Weak)]
		get
		{
			NSApplication.EnsureUIThread();
			NSCollectionView nSCollectionView = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSCollectionView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCollectionViewHandle)) : Runtime.GetNSObject<NSCollectionView>(Messaging.IntPtr_objc_msgSend(base.Handle, selCollectionViewHandle)));
			MarkDirty();
			__mt_CollectionView_var = nSCollectionView;
			return nSCollectionView;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize CollectionViewContentSize
	{
		[Export("collectionViewContentSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selCollectionViewContentSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selCollectionViewContentSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Class InvalidationContextClass
	{
		[Export("invalidationContextClass")]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = Messaging.IntPtr_objc_msgSend(class_ptr, selInvalidationContextClassHandle);
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Class LayoutAttributesClass
	{
		[Export("layoutAttributesClass")]
		get
		{
			NSApplication.EnsureUIThread();
			IntPtr intPtr = Messaging.IntPtr_objc_msgSend(class_ptr, selLayoutAttributesClassHandle);
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
	}

	public void RegisterClassForDecorationView(Type itemClass, NSString elementKind)
	{
		_RegisterClassForDecorationView((itemClass == null) ? IntPtr.Zero : ObjCRuntime.Class.GetHandle(itemClass), elementKind);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCollectionViewLayout()
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
	public NSCollectionViewLayout(NSCoder coder)
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
	protected NSCollectionViewLayout(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionViewLayout(IntPtr handle)
		: base(handle)
	{
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("finalizeAnimatedBoundsChange")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinalizeAnimatedBoundsChange()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFinalizeAnimatedBoundsChangeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFinalizeAnimatedBoundsChangeHandle);
		}
	}

	[Export("finalizeCollectionViewUpdates")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinalizeCollectionViewUpdates()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFinalizeCollectionViewUpdatesHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFinalizeCollectionViewUpdatesHandle);
		}
	}

	[Export("finalizeLayoutTransition")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinalizeLayoutTransition()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFinalizeLayoutTransitionHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFinalizeLayoutTransitionHandle);
		}
	}

	[Export("finalLayoutAttributesForDisappearingDecorationElementOfKind:atIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutAttributes? GetFinalLayoutAttributesForDisappearingDecorationElement(NSString elementKind, NSIndexPath decorationIndexPath)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (decorationIndexPath == null)
		{
			throw new ArgumentNullException("decorationIndexPath");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selFinalLayoutAttributesForDisappearingDecorationElementOfKind_AtIndexPath_Handle, elementKind.Handle, decorationIndexPath.Handle));
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFinalLayoutAttributesForDisappearingDecorationElementOfKind_AtIndexPath_Handle, elementKind.Handle, decorationIndexPath.Handle));
	}

	[Export("finalLayoutAttributesForDisappearingItemAtIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutAttributes? GetFinalLayoutAttributesForDisappearingItem(NSIndexPath itemIndexPath)
	{
		NSApplication.EnsureUIThread();
		if (itemIndexPath == null)
		{
			throw new ArgumentNullException("itemIndexPath");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selFinalLayoutAttributesForDisappearingItemAtIndexPath_Handle, itemIndexPath.Handle));
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selFinalLayoutAttributesForDisappearingItemAtIndexPath_Handle, itemIndexPath.Handle));
	}

	[Export("finalLayoutAttributesForDisappearingSupplementaryElementOfKind:atIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutAttributes? GetFinalLayoutAttributesForDisappearingSupplementaryElement(NSString elementKind, NSIndexPath elementIndexPath)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (elementIndexPath == null)
		{
			throw new ArgumentNullException("elementIndexPath");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selFinalLayoutAttributesForDisappearingSupplementaryElementOfKind_AtIndexPath_Handle, elementKind.Handle, elementIndexPath.Handle));
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFinalLayoutAttributesForDisappearingSupplementaryElementOfKind_AtIndexPath_Handle, elementKind.Handle, elementIndexPath.Handle));
	}

	[Export("indexPathsToDeleteForDecorationViewOfKind:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet GetIndexPathsToDeleteForDecorationView(NSString elementKind)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIndexPathsToDeleteForDecorationViewOfKind_Handle, elementKind.Handle));
		}
		return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexPathsToDeleteForDecorationViewOfKind_Handle, elementKind.Handle));
	}

	[Export("indexPathsToDeleteForSupplementaryViewOfKind:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet GetIndexPathsToDeleteForSupplementaryView(NSString elementKind)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIndexPathsToDeleteForSupplementaryViewOfKind_Handle, elementKind.Handle));
		}
		return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexPathsToDeleteForSupplementaryViewOfKind_Handle, elementKind.Handle));
	}

	[Export("indexPathsToInsertForDecorationViewOfKind:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet GetIndexPathsToInsertForDecorationView(NSString elementKind)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIndexPathsToInsertForDecorationViewOfKind_Handle, elementKind.Handle));
		}
		return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexPathsToInsertForDecorationViewOfKind_Handle, elementKind.Handle));
	}

	[Export("indexPathsToInsertForSupplementaryViewOfKind:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet GetIndexPathsToInsertForSupplementaryView(NSString elementKind)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIndexPathsToInsertForSupplementaryViewOfKind_Handle, elementKind.Handle));
		}
		return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIndexPathsToInsertForSupplementaryViewOfKind_Handle, elementKind.Handle));
	}

	[Export("initialLayoutAttributesForAppearingDecorationElementOfKind:atIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutAttributes? GetInitialLayoutAttributesForAppearingDecorationElement(NSString elementKind, NSIndexPath decorationIndexPath)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (decorationIndexPath == null)
		{
			throw new ArgumentNullException("decorationIndexPath");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitialLayoutAttributesForAppearingDecorationElementOfKind_AtIndexPath_Handle, elementKind.Handle, decorationIndexPath.Handle));
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitialLayoutAttributesForAppearingDecorationElementOfKind_AtIndexPath_Handle, elementKind.Handle, decorationIndexPath.Handle));
	}

	[Export("initialLayoutAttributesForAppearingItemAtIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutAttributes? GetInitialLayoutAttributesForAppearingItem(NSIndexPath itemIndexPath)
	{
		NSApplication.EnsureUIThread();
		if (itemIndexPath == null)
		{
			throw new ArgumentNullException("itemIndexPath");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitialLayoutAttributesForAppearingItemAtIndexPath_Handle, itemIndexPath.Handle));
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitialLayoutAttributesForAppearingItemAtIndexPath_Handle, itemIndexPath.Handle));
	}

	[Export("initialLayoutAttributesForAppearingSupplementaryElementOfKind:atIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutAttributes? GetInitialLayoutAttributesForAppearingSupplementaryElement(NSString elementKind, NSIndexPath elementIndexPath)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (elementIndexPath == null)
		{
			throw new ArgumentNullException("elementIndexPath");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitialLayoutAttributesForAppearingSupplementaryElementOfKind_AtIndexPath_Handle, elementKind.Handle, elementIndexPath.Handle));
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitialLayoutAttributesForAppearingSupplementaryElementOfKind_AtIndexPath_Handle, elementKind.Handle, elementIndexPath.Handle));
	}

	[Export("invalidationContextForBoundsChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutInvalidationContext GetInvalidationContext(CGRect newBounds)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewLayoutInvalidationContext>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInvalidationContextForBoundsChange_Handle, newBounds));
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutInvalidationContext>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInvalidationContextForBoundsChange_Handle, newBounds));
	}

	[Export("invalidationContextForPreferredLayoutAttributes:withOriginalAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutInvalidationContext GetInvalidationContext(NSCollectionViewLayoutAttributes preferredAttributes, NSCollectionViewLayoutAttributes originalAttributes)
	{
		NSApplication.EnsureUIThread();
		if (preferredAttributes == null)
		{
			throw new ArgumentNullException("preferredAttributes");
		}
		if (originalAttributes == null)
		{
			throw new ArgumentNullException("originalAttributes");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewLayoutInvalidationContext>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInvalidationContextForPreferredLayoutAttributes_WithOriginalAttributes_Handle, preferredAttributes.Handle, originalAttributes.Handle));
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutInvalidationContext>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInvalidationContextForPreferredLayoutAttributes_WithOriginalAttributes_Handle, preferredAttributes.Handle, originalAttributes.Handle));
	}

	[Export("layoutAttributesForDecorationViewOfKind:atIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutAttributes? GetLayoutAttributesForDecorationView(NSString elementKind, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selLayoutAttributesForDecorationViewOfKind_AtIndexPath_Handle, elementKind.Handle, indexPath.Handle));
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLayoutAttributesForDecorationViewOfKind_AtIndexPath_Handle, elementKind.Handle, indexPath.Handle));
	}

	[Export("layoutAttributesForDropTargetAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutAttributes? GetLayoutAttributesForDropTarget(CGPoint pointInCollectionView)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_CGPoint(base.Handle, selLayoutAttributesForDropTargetAtPoint_Handle, pointInCollectionView));
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSendSuper_CGPoint(base.SuperHandle, selLayoutAttributesForDropTargetAtPoint_Handle, pointInCollectionView));
	}

	[Export("layoutAttributesForElementsInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutAttributes[] GetLayoutAttributesForElements(CGRect rect)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selLayoutAttributesForElementsInRect_Handle, rect));
		}
		return NSArray.ArrayFromHandle<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selLayoutAttributesForElementsInRect_Handle, rect));
	}

	[Export("layoutAttributesForInterItemGapBeforeIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutAttributes? GetLayoutAttributesForInterItemGap(NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLayoutAttributesForInterItemGapBeforeIndexPath_Handle, indexPath.Handle));
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLayoutAttributesForInterItemGapBeforeIndexPath_Handle, indexPath.Handle));
	}

	[Export("layoutAttributesForItemAtIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutAttributes? GetLayoutAttributesForItem(NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLayoutAttributesForItemAtIndexPath_Handle, indexPath.Handle));
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLayoutAttributesForItemAtIndexPath_Handle, indexPath.Handle));
	}

	[Export("layoutAttributesForSupplementaryViewOfKind:atIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewLayoutAttributes? GetLayoutAttributesForSupplementaryView(NSString elementKind, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selLayoutAttributesForSupplementaryViewOfKind_AtIndexPath_Handle, elementKind.Handle, indexPath.Handle));
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLayoutAttributesForSupplementaryViewOfKind_AtIndexPath_Handle, elementKind.Handle, indexPath.Handle));
	}

	[Export("targetContentOffsetForProposedContentOffset:withScrollingVelocity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint GetTargetContentOffset(CGPoint proposedContentOffset, CGPoint velocity)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint_CGPoint(base.Handle, selTargetContentOffsetForProposedContentOffset_WithScrollingVelocity_Handle, proposedContentOffset, velocity);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint_CGPoint(base.SuperHandle, selTargetContentOffsetForProposedContentOffset_WithScrollingVelocity_Handle, proposedContentOffset, velocity);
	}

	[Export("targetContentOffsetForProposedContentOffset:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint GetTargetContentOffset(CGPoint proposedContentOffset)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_CGPoint(base.Handle, selTargetContentOffsetForProposedContentOffset_Handle, proposedContentOffset);
		}
		return Messaging.CGPoint_objc_msgSendSuper_CGPoint(base.SuperHandle, selTargetContentOffsetForProposedContentOffset_Handle, proposedContentOffset);
	}

	[Export("invalidateLayout")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateLayout()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateLayoutHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateLayoutHandle);
		}
	}

	[Export("invalidateLayoutWithContext:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void InvalidateLayout(NSCollectionViewLayoutInvalidationContext context)
	{
		NSApplication.EnsureUIThread();
		if (context == null)
		{
			throw new ArgumentNullException("context");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selInvalidateLayoutWithContext_Handle, context.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selInvalidateLayoutWithContext_Handle, context.Handle);
		}
	}

	[Export("prepareForAnimatedBoundsChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareForAnimatedBoundsChange(CGRect oldBounds)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selPrepareForAnimatedBoundsChange_Handle, oldBounds);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selPrepareForAnimatedBoundsChange_Handle, oldBounds);
		}
	}

	[Export("prepareForCollectionViewUpdates:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareForCollectionViewUpdates(NSCollectionViewUpdateItem[] updateItems)
	{
		NSApplication.EnsureUIThread();
		if (updateItems == null)
		{
			throw new ArgumentNullException("updateItems");
		}
		NSArray nSArray = NSArray.FromNSObjects(updateItems);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPrepareForCollectionViewUpdates_Handle, nSArray.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrepareForCollectionViewUpdates_Handle, nSArray.Handle);
		}
		nSArray.Dispose();
	}

	[Export("prepareForTransitionFromLayout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareForTransitionFromLayout(NSCollectionViewLayout oldLayout)
	{
		NSApplication.EnsureUIThread();
		if (oldLayout == null)
		{
			throw new ArgumentNullException("oldLayout");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPrepareForTransitionFromLayout_Handle, oldLayout.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrepareForTransitionFromLayout_Handle, oldLayout.Handle);
		}
	}

	[Export("prepareForTransitionToLayout:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareForTransitionToLayout(NSCollectionViewLayout newLayout)
	{
		NSApplication.EnsureUIThread();
		if (newLayout == null)
		{
			throw new ArgumentNullException("newLayout");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPrepareForTransitionToLayout_Handle, newLayout.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPrepareForTransitionToLayout_Handle, newLayout.Handle);
		}
	}

	[Export("prepareLayout")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareLayout()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPrepareLayoutHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPrepareLayoutHandle);
		}
	}

	[Export("registerNib:forDecorationViewOfKind:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RegisterNib(NSNib? nib, NSString elementKind)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRegisterNib_ForDecorationViewOfKind_Handle, nib?.Handle ?? IntPtr.Zero, elementKind.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRegisterNib_ForDecorationViewOfKind_Handle, nib?.Handle ?? IntPtr.Zero, elementKind.Handle);
		}
	}

	[Export("shouldInvalidateLayoutForBoundsChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldInvalidateLayout(CGRect newBounds)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CGRect(base.Handle, selShouldInvalidateLayoutForBoundsChange_Handle, newBounds);
		}
		return Messaging.bool_objc_msgSendSuper_CGRect(base.SuperHandle, selShouldInvalidateLayoutForBoundsChange_Handle, newBounds);
	}

	[Export("shouldInvalidateLayoutForPreferredLayoutAttributes:withOriginalAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldInvalidateLayout(NSCollectionViewLayoutAttributes preferredAttributes, NSCollectionViewLayoutAttributes originalAttributes)
	{
		NSApplication.EnsureUIThread();
		if (preferredAttributes == null)
		{
			throw new ArgumentNullException("preferredAttributes");
		}
		if (originalAttributes == null)
		{
			throw new ArgumentNullException("originalAttributes");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selShouldInvalidateLayoutForPreferredLayoutAttributes_WithOriginalAttributes_Handle, preferredAttributes.Handle, originalAttributes.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selShouldInvalidateLayoutForPreferredLayoutAttributes_WithOriginalAttributes_Handle, preferredAttributes.Handle, originalAttributes.Handle);
	}

	[Export("registerClass:forDecorationViewOfKind:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _RegisterClassForDecorationView(IntPtr viewClass, NSString elementKind)
	{
		NSApplication.EnsureUIThread();
		if (elementKind == null)
		{
			throw new ArgumentNullException("elementKind");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRegisterClass_ForDecorationViewOfKind_Handle, viewClass, elementKind.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRegisterClass_ForDecorationViewOfKind_Handle, viewClass, elementKind.Handle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_CollectionView_var = null;
		}
	}
}
