using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionViewLayoutAttributes", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSCollectionViewLayoutAttributes : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlpha = "alpha";

	private static readonly IntPtr selAlphaHandle = Selector.GetHandle("alpha");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrame = "frame";

	private static readonly IntPtr selFrameHandle = Selector.GetHandle("frame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPath = "indexPath";

	private static readonly IntPtr selIndexPathHandle = Selector.GetHandle("indexPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsHidden = "isHidden";

	private static readonly IntPtr selIsHiddenHandle = Selector.GetHandle("isHidden");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttributesForDecorationViewOfKind_WithIndexPath_ = "layoutAttributesForDecorationViewOfKind:withIndexPath:";

	private static readonly IntPtr selLayoutAttributesForDecorationViewOfKind_WithIndexPath_Handle = Selector.GetHandle("layoutAttributesForDecorationViewOfKind:withIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttributesForInterItemGapBeforeIndexPath_ = "layoutAttributesForInterItemGapBeforeIndexPath:";

	private static readonly IntPtr selLayoutAttributesForInterItemGapBeforeIndexPath_Handle = Selector.GetHandle("layoutAttributesForInterItemGapBeforeIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttributesForItemWithIndexPath_ = "layoutAttributesForItemWithIndexPath:";

	private static readonly IntPtr selLayoutAttributesForItemWithIndexPath_Handle = Selector.GetHandle("layoutAttributesForItemWithIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutAttributesForSupplementaryViewOfKind_WithIndexPath_ = "layoutAttributesForSupplementaryViewOfKind:withIndexPath:";

	private static readonly IntPtr selLayoutAttributesForSupplementaryViewOfKind_WithIndexPath_Handle = Selector.GetHandle("layoutAttributesForSupplementaryViewOfKind:withIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepresentedElementCategory = "representedElementCategory";

	private static readonly IntPtr selRepresentedElementCategoryHandle = Selector.GetHandle("representedElementCategory");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRepresentedElementKind = "representedElementKind";

	private static readonly IntPtr selRepresentedElementKindHandle = Selector.GetHandle("representedElementKind");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlpha_ = "setAlpha:";

	private static readonly IntPtr selSetAlpha_Handle = Selector.GetHandle("setAlpha:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrame_ = "setFrame:";

	private static readonly IntPtr selSetFrame_Handle = Selector.GetHandle("setFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHidden_ = "setHidden:";

	private static readonly IntPtr selSetHidden_Handle = Selector.GetHandle("setHidden:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIndexPath_ = "setIndexPath:";

	private static readonly IntPtr selSetIndexPath_Handle = Selector.GetHandle("setIndexPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSize_ = "setSize:";

	private static readonly IntPtr selSetSize_Handle = Selector.GetHandle("setSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZIndex_ = "setZIndex:";

	private static readonly IntPtr selSetZIndex_Handle = Selector.GetHandle("setZIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZIndex = "zIndex";

	private static readonly IntPtr selZIndexHandle = Selector.GetHandle("zIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionViewLayoutAttributes");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat Alpha
	{
		[Export("alpha", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selAlphaHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selAlphaHandle);
		}
		[Export("setAlpha:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetAlpha_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetAlpha_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Frame
	{
		[Export("frame", ArgumentSemantic.Assign)]
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
		[Export("setFrame:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetFrame_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetFrame_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Hidden
	{
		[Export("isHidden")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsHiddenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsHiddenHandle);
		}
		[Export("setHidden:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHidden_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHidden_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexPath? IndexPath
	{
		[Export("indexPath", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selIndexPathHandle));
			}
			return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIndexPathHandle));
		}
		[Export("setIndexPath:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIndexPath_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIndexPath_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionElementCategory RepresentedElementCategory
	{
		[Export("representedElementCategory")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSCollectionElementCategory)Messaging.Int64_objc_msgSend(base.Handle, selRepresentedElementCategoryHandle);
			}
			return (NSCollectionElementCategory)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRepresentedElementCategoryHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? RepresentedElementKind
	{
		[Export("representedElementKind")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selRepresentedElementKindHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepresentedElementKindHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize Size
	{
		[Export("size", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
		[Export("setSize:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ZIndex
	{
		[Export("zIndex", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selZIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selZIndexHandle);
		}
		[Export("setZIndex:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetZIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetZIndex_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCollectionViewLayoutAttributes()
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
	protected NSCollectionViewLayoutAttributes(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionViewLayoutAttributes(IntPtr handle)
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

	[Export("layoutAttributesForDecorationViewOfKind:withIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionViewLayoutAttributes CreateForDecorationView(NSString decorationViewKind, NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (decorationViewKind == null)
		{
			throw new ArgumentNullException("decorationViewKind");
		}
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selLayoutAttributesForDecorationViewOfKind_WithIndexPath_Handle, decorationViewKind.Handle, indexPath.Handle));
	}

	[Export("layoutAttributesForInterItemGapBeforeIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionViewLayoutAttributes CreateForInterItemGap(NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLayoutAttributesForInterItemGapBeforeIndexPath_Handle, indexPath.Handle));
	}

	[Export("layoutAttributesForItemWithIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionViewLayoutAttributes CreateForItem(NSIndexPath indexPath)
	{
		NSApplication.EnsureUIThread();
		if (indexPath == null)
		{
			throw new ArgumentNullException("indexPath");
		}
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selLayoutAttributesForItemWithIndexPath_Handle, indexPath.Handle));
	}

	[Export("layoutAttributesForSupplementaryViewOfKind:withIndexPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionViewLayoutAttributes CreateForSupplementaryView(NSString elementKind, NSIndexPath indexPath)
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
		return Runtime.GetNSObject<NSCollectionViewLayoutAttributes>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selLayoutAttributesForSupplementaryViewOfKind_WithIndexPath_Handle, elementKind.Handle, indexPath.Handle));
	}
}
