using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionLayoutItem", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSCollectionLayoutItem : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentInsets = "contentInsets";

	private static readonly IntPtr selContentInsetsHandle = Selector.GetHandle("contentInsets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEdgeSpacing = "edgeSpacing";

	private static readonly IntPtr selEdgeSpacingHandle = Selector.GetHandle("edgeSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemWithLayoutSize_ = "itemWithLayoutSize:";

	private static readonly IntPtr selItemWithLayoutSize_Handle = Selector.GetHandle("itemWithLayoutSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemWithLayoutSize_SupplementaryItems_ = "itemWithLayoutSize:supplementaryItems:";

	private static readonly IntPtr selItemWithLayoutSize_SupplementaryItems_Handle = Selector.GetHandle("itemWithLayoutSize:supplementaryItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayoutSize = "layoutSize";

	private static readonly IntPtr selLayoutSizeHandle = Selector.GetHandle("layoutSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContentInsets_ = "setContentInsets:";

	private static readonly IntPtr selSetContentInsets_Handle = Selector.GetHandle("setContentInsets:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEdgeSpacing_ = "setEdgeSpacing:";

	private static readonly IntPtr selSetEdgeSpacing_Handle = Selector.GetHandle("setEdgeSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupplementaryItems = "supplementaryItems";

	private static readonly IntPtr selSupplementaryItemsHandle = Selector.GetHandle("supplementaryItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionLayoutItem");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDirectionalEdgeInsets ContentInsets
	{
		[Export("contentInsets", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSDirectionalEdgeInsets retval;
			if (base.IsDirectBinding)
			{
				Messaging.NSDirectionalEdgeInsets_objc_msgSend_stret(out retval, base.Handle, selContentInsetsHandle);
			}
			else
			{
				Messaging.NSDirectionalEdgeInsets_objc_msgSendSuper_stret(out retval, base.SuperHandle, selContentInsetsHandle);
			}
			return retval;
		}
		[Export("setContentInsets:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_NSDirectionalEdgeInsets(base.Handle, selSetContentInsets_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_NSDirectionalEdgeInsets(base.SuperHandle, selSetContentInsets_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutEdgeSpacing? EdgeSpacing
	{
		[Export("edgeSpacing", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCollectionLayoutEdgeSpacing>(Messaging.IntPtr_objc_msgSend(base.Handle, selEdgeSpacingHandle));
			}
			return Runtime.GetNSObject<NSCollectionLayoutEdgeSpacing>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEdgeSpacingHandle));
		}
		[Export("setEdgeSpacing:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEdgeSpacing_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEdgeSpacing_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutSize LayoutSize
	{
		[Export("layoutSize")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCollectionLayoutSize>(Messaging.IntPtr_objc_msgSend(base.Handle, selLayoutSizeHandle));
			}
			return Runtime.GetNSObject<NSCollectionLayoutSize>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayoutSizeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutSupplementaryItem[] SupplementaryItems
	{
		[Export("supplementaryItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSCollectionLayoutSupplementaryItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupplementaryItemsHandle));
			}
			return NSArray.ArrayFromHandle<NSCollectionLayoutSupplementaryItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupplementaryItemsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCollectionLayoutItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionLayoutItem(IntPtr handle)
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

	[Export("itemWithLayoutSize:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutItem Create(NSCollectionLayoutSize layoutSize)
	{
		NSApplication.EnsureUIThread();
		if (layoutSize == null)
		{
			throw new ArgumentNullException("layoutSize");
		}
		return Runtime.GetNSObject<NSCollectionLayoutItem>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selItemWithLayoutSize_Handle, layoutSize.Handle));
	}

	[Export("itemWithLayoutSize:supplementaryItems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutItem Create(NSCollectionLayoutSize layoutSize, NSCollectionLayoutSupplementaryItem[] supplementaryItems)
	{
		NSApplication.EnsureUIThread();
		if (layoutSize == null)
		{
			throw new ArgumentNullException("layoutSize");
		}
		if (supplementaryItems == null)
		{
			throw new ArgumentNullException("supplementaryItems");
		}
		NSArray nSArray = NSArray.FromNSObjects(supplementaryItems);
		NSCollectionLayoutItem nSObject = Runtime.GetNSObject<NSCollectionLayoutItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selItemWithLayoutSize_SupplementaryItems_Handle, layoutSize.Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}
}
