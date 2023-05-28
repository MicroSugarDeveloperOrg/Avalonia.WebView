using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSCollectionViewFlowLayout", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSCollectionViewFlowLayout : NSCollectionViewLayout
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCollapseSectionAtIndex_ = "collapseSectionAtIndex:";

	private static readonly IntPtr selCollapseSectionAtIndex_Handle = Selector.GetHandle("collapseSectionAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEstimatedItemSize = "estimatedItemSize";

	private static readonly IntPtr selEstimatedItemSizeHandle = Selector.GetHandle("estimatedItemSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExpandSectionAtIndex_ = "expandSectionAtIndex:";

	private static readonly IntPtr selExpandSectionAtIndex_Handle = Selector.GetHandle("expandSectionAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFooterReferenceSize = "footerReferenceSize";

	private static readonly IntPtr selFooterReferenceSizeHandle = Selector.GetHandle("footerReferenceSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHeaderReferenceSize = "headerReferenceSize";

	private static readonly IntPtr selHeaderReferenceSizeHandle = Selector.GetHandle("headerReferenceSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemSize = "itemSize";

	private static readonly IntPtr selItemSizeHandle = Selector.GetHandle("itemSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumInteritemSpacing = "minimumInteritemSpacing";

	private static readonly IntPtr selMinimumInteritemSpacingHandle = Selector.GetHandle("minimumInteritemSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMinimumLineSpacing = "minimumLineSpacing";

	private static readonly IntPtr selMinimumLineSpacingHandle = Selector.GetHandle("minimumLineSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollDirection = "scrollDirection";

	private static readonly IntPtr selScrollDirectionHandle = Selector.GetHandle("scrollDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSectionAtIndexIsCollapsed_ = "sectionAtIndexIsCollapsed:";

	private static readonly IntPtr selSectionAtIndexIsCollapsed_Handle = Selector.GetHandle("sectionAtIndexIsCollapsed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSectionFootersPinToVisibleBounds = "sectionFootersPinToVisibleBounds";

	private static readonly IntPtr selSectionFootersPinToVisibleBoundsHandle = Selector.GetHandle("sectionFootersPinToVisibleBounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSectionHeadersPinToVisibleBounds = "sectionHeadersPinToVisibleBounds";

	private static readonly IntPtr selSectionHeadersPinToVisibleBoundsHandle = Selector.GetHandle("sectionHeadersPinToVisibleBounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSectionInset = "sectionInset";

	private static readonly IntPtr selSectionInsetHandle = Selector.GetHandle("sectionInset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEstimatedItemSize_ = "setEstimatedItemSize:";

	private static readonly IntPtr selSetEstimatedItemSize_Handle = Selector.GetHandle("setEstimatedItemSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFooterReferenceSize_ = "setFooterReferenceSize:";

	private static readonly IntPtr selSetFooterReferenceSize_Handle = Selector.GetHandle("setFooterReferenceSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHeaderReferenceSize_ = "setHeaderReferenceSize:";

	private static readonly IntPtr selSetHeaderReferenceSize_Handle = Selector.GetHandle("setHeaderReferenceSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetItemSize_ = "setItemSize:";

	private static readonly IntPtr selSetItemSize_Handle = Selector.GetHandle("setItemSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumInteritemSpacing_ = "setMinimumInteritemSpacing:";

	private static readonly IntPtr selSetMinimumInteritemSpacing_Handle = Selector.GetHandle("setMinimumInteritemSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMinimumLineSpacing_ = "setMinimumLineSpacing:";

	private static readonly IntPtr selSetMinimumLineSpacing_Handle = Selector.GetHandle("setMinimumLineSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScrollDirection_ = "setScrollDirection:";

	private static readonly IntPtr selSetScrollDirection_Handle = Selector.GetHandle("setScrollDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSectionFootersPinToVisibleBounds_ = "setSectionFootersPinToVisibleBounds:";

	private static readonly IntPtr selSetSectionFootersPinToVisibleBounds_Handle = Selector.GetHandle("setSectionFootersPinToVisibleBounds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSectionHeadersPinToVisibleBounds_ = "setSectionHeadersPinToVisibleBounds:";

	private static readonly IntPtr selSetSectionHeadersPinToVisibleBounds_Handle = Selector.GetHandle("setSectionHeadersPinToVisibleBounds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSectionInset_ = "setSectionInset:";

	private static readonly IntPtr selSetSectionInset_Handle = Selector.GetHandle("setSectionInset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionViewFlowLayout");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize EstimatedItemSize
	{
		[Export("estimatedItemSize", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selEstimatedItemSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selEstimatedItemSizeHandle);
		}
		[Export("setEstimatedItemSize:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetEstimatedItemSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetEstimatedItemSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize FooterReferenceSize
	{
		[Export("footerReferenceSize", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selFooterReferenceSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selFooterReferenceSizeHandle);
		}
		[Export("setFooterReferenceSize:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetFooterReferenceSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetFooterReferenceSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize HeaderReferenceSize
	{
		[Export("headerReferenceSize", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selHeaderReferenceSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selHeaderReferenceSizeHandle);
		}
		[Export("setHeaderReferenceSize:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetHeaderReferenceSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetHeaderReferenceSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize ItemSize
	{
		[Export("itemSize", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selItemSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selItemSizeHandle);
		}
		[Export("setItemSize:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetItemSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetItemSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MinimumInteritemSpacing
	{
		[Export("minimumInteritemSpacing", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinimumInteritemSpacingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinimumInteritemSpacingHandle);
		}
		[Export("setMinimumInteritemSpacing:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMinimumInteritemSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMinimumInteritemSpacing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat MinimumLineSpacing
	{
		[Export("minimumLineSpacing", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selMinimumLineSpacingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selMinimumLineSpacingHandle);
		}
		[Export("setMinimumLineSpacing:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetMinimumLineSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetMinimumLineSpacing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionViewScrollDirection ScrollDirection
	{
		[Export("scrollDirection", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSCollectionViewScrollDirection)Messaging.Int64_objc_msgSend(base.Handle, selScrollDirectionHandle);
			}
			return (NSCollectionViewScrollDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selScrollDirectionHandle);
		}
		[Export("setScrollDirection:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetScrollDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetScrollDirection_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool SectionFootersPinToVisibleBounds
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("sectionFootersPinToVisibleBounds")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSectionFootersPinToVisibleBoundsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSectionFootersPinToVisibleBoundsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setSectionFootersPinToVisibleBounds:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSectionFootersPinToVisibleBounds_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSectionFootersPinToVisibleBounds_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual bool SectionHeadersPinToVisibleBounds
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("sectionHeadersPinToVisibleBounds")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSectionHeadersPinToVisibleBoundsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSectionHeadersPinToVisibleBoundsHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setSectionHeadersPinToVisibleBounds:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSectionHeadersPinToVisibleBounds_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSectionHeadersPinToVisibleBounds_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSEdgeInsets SectionInset
	{
		[Export("sectionInset", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSEdgeInsets retval;
			if (base.IsDirectBinding)
			{
				Messaging.NSEdgeInsets_objc_msgSend_stret(out retval, base.Handle, selSectionInsetHandle);
			}
			else
			{
				Messaging.NSEdgeInsets_objc_msgSendSuper_stret(out retval, base.SuperHandle, selSectionInsetHandle);
			}
			return retval;
		}
		[Export("setSectionInset:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSEdgeInsets(base.Handle, selSetSectionInset_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSEdgeInsets(base.SuperHandle, selSetSectionInset_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCollectionViewFlowLayout()
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
	public NSCollectionViewFlowLayout(NSCoder coder)
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
	protected NSCollectionViewFlowLayout(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionViewFlowLayout(IntPtr handle)
		: base(handle)
	{
	}

	[Export("collapseSectionAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CollapseSectionAtIndex(nuint sectionIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint(base.Handle, selCollapseSectionAtIndex_Handle, sectionIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selCollapseSectionAtIndex_Handle, sectionIndex);
		}
	}

	[Export("expandSectionAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ExpandSectionAtIndex(nuint sectionIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint(base.Handle, selExpandSectionAtIndex_Handle, sectionIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint(base.SuperHandle, selExpandSectionAtIndex_Handle, sectionIndex);
		}
	}

	[Export("sectionAtIndexIsCollapsed:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SectionAtIndexIsCollapsed(nuint sectionIndex)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_nuint(base.Handle, selSectionAtIndexIsCollapsed_Handle, sectionIndex);
		}
		return Messaging.bool_objc_msgSendSuper_nuint(base.SuperHandle, selSectionAtIndexIsCollapsed_Handle, sectionIndex);
	}
}
