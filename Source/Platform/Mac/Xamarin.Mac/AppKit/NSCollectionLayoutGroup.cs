using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionLayoutGroup", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSCollectionLayoutGroup : NSCollectionLayoutItem, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomGroupWithLayoutSize_ItemProvider_ = "customGroupWithLayoutSize:itemProvider:";

	private static readonly IntPtr selCustomGroupWithLayoutSize_ItemProvider_Handle = Selector.GetHandle("customGroupWithLayoutSize:itemProvider:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHorizontalGroupWithLayoutSize_Subitem_Count_ = "horizontalGroupWithLayoutSize:subitem:count:";

	private static readonly IntPtr selHorizontalGroupWithLayoutSize_Subitem_Count_Handle = Selector.GetHandle("horizontalGroupWithLayoutSize:subitem:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHorizontalGroupWithLayoutSize_Subitems_ = "horizontalGroupWithLayoutSize:subitems:";

	private static readonly IntPtr selHorizontalGroupWithLayoutSize_Subitems_Handle = Selector.GetHandle("horizontalGroupWithLayoutSize:subitems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterItemSpacing = "interItemSpacing";

	private static readonly IntPtr selInterItemSpacingHandle = Selector.GetHandle("interItemSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInterItemSpacing_ = "setInterItemSpacing:";

	private static readonly IntPtr selSetInterItemSpacing_Handle = Selector.GetHandle("setInterItemSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSupplementaryItems_ = "setSupplementaryItems:";

	private static readonly IntPtr selSetSupplementaryItems_Handle = Selector.GetHandle("setSupplementaryItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubitems = "subitems";

	private static readonly IntPtr selSubitemsHandle = Selector.GetHandle("subitems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupplementaryItems = "supplementaryItems";

	private static readonly IntPtr selSupplementaryItemsHandle = Selector.GetHandle("supplementaryItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVerticalGroupWithLayoutSize_Subitem_Count_ = "verticalGroupWithLayoutSize:subitem:count:";

	private static readonly IntPtr selVerticalGroupWithLayoutSize_Subitem_Count_Handle = Selector.GetHandle("verticalGroupWithLayoutSize:subitem:count:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVerticalGroupWithLayoutSize_Subitems_ = "verticalGroupWithLayoutSize:subitems:";

	private static readonly IntPtr selVerticalGroupWithLayoutSize_Subitems_Handle = Selector.GetHandle("verticalGroupWithLayoutSize:subitems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVisualDescription = "visualDescription";

	private static readonly IntPtr selVisualDescriptionHandle = Selector.GetHandle("visualDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionLayoutGroup");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutSpacing? InterItemSpacing
	{
		[Export("interItemSpacing", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCollectionLayoutSpacing>(Messaging.IntPtr_objc_msgSend(base.Handle, selInterItemSpacingHandle));
			}
			return Runtime.GetNSObject<NSCollectionLayoutSpacing>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInterItemSpacingHandle));
		}
		[Export("setInterItemSpacing:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInterItemSpacing_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInterItemSpacing_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutItem[] Subitems
	{
		[Export("subitems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSCollectionLayoutItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubitemsHandle));
			}
			return NSArray.ArrayFromHandle<NSCollectionLayoutItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubitemsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSCollectionLayoutSupplementaryItem[] SupplementaryItems
	{
		[Export("supplementaryItems", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSCollectionLayoutSupplementaryItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selSupplementaryItemsHandle));
			}
			return NSArray.ArrayFromHandle<NSCollectionLayoutSupplementaryItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSupplementaryItemsHandle));
		}
		[Export("setSupplementaryItems:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSupplementaryItems_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSupplementaryItems_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string VisualDescription
	{
		[Export("visualDescription")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVisualDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVisualDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCollectionLayoutGroup(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionLayoutGroup(IntPtr handle)
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

	[Export("customGroupWithLayoutSize:itemProvider:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static NSCollectionLayoutGroup CreateCustomGroup(NSCollectionLayoutSize layoutSize, [BlockProxy(typeof(Trampolines.NIDNSCollectionLayoutGroupCustomItemProvider))] NSCollectionLayoutGroupCustomItemProvider itemProvider)
	{
		NSApplication.EnsureUIThread();
		if (layoutSize == null)
		{
			throw new ArgumentNullException("layoutSize");
		}
		if (itemProvider == null)
		{
			throw new ArgumentNullException("itemProvider");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSCollectionLayoutGroupCustomItemProvider.Handler, itemProvider);
		NSCollectionLayoutGroup nSObject = Runtime.GetNSObject<NSCollectionLayoutGroup>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selCustomGroupWithLayoutSize_ItemProvider_Handle, layoutSize.Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("horizontalGroupWithLayoutSize:subitem:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutGroup CreateHorizontalGroup(NSCollectionLayoutSize layoutSize, NSCollectionLayoutItem subitem, nint count)
	{
		NSApplication.EnsureUIThread();
		if (layoutSize == null)
		{
			throw new ArgumentNullException("layoutSize");
		}
		if (subitem == null)
		{
			throw new ArgumentNullException("subitem");
		}
		return Runtime.GetNSObject<NSCollectionLayoutGroup>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint(class_ptr, selHorizontalGroupWithLayoutSize_Subitem_Count_Handle, layoutSize.Handle, subitem.Handle, count));
	}

	[Export("horizontalGroupWithLayoutSize:subitems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutGroup CreateHorizontalGroup(NSCollectionLayoutSize layoutSize, NSCollectionLayoutItem[] subitems)
	{
		NSApplication.EnsureUIThread();
		if (layoutSize == null)
		{
			throw new ArgumentNullException("layoutSize");
		}
		if (subitems == null)
		{
			throw new ArgumentNullException("subitems");
		}
		NSArray nSArray = NSArray.FromNSObjects(subitems);
		NSCollectionLayoutGroup nSObject = Runtime.GetNSObject<NSCollectionLayoutGroup>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selHorizontalGroupWithLayoutSize_Subitems_Handle, layoutSize.Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("verticalGroupWithLayoutSize:subitem:count:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutGroup CreateVerticalGroup(NSCollectionLayoutSize layoutSize, NSCollectionLayoutItem subitem, nint count)
	{
		NSApplication.EnsureUIThread();
		if (layoutSize == null)
		{
			throw new ArgumentNullException("layoutSize");
		}
		if (subitem == null)
		{
			throw new ArgumentNullException("subitem");
		}
		return Runtime.GetNSObject<NSCollectionLayoutGroup>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint(class_ptr, selVerticalGroupWithLayoutSize_Subitem_Count_Handle, layoutSize.Handle, subitem.Handle, count));
	}

	[Export("verticalGroupWithLayoutSize:subitems:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutGroup CreateVerticalGroup(NSCollectionLayoutSize layoutSize, NSCollectionLayoutItem[] subitems)
	{
		NSApplication.EnsureUIThread();
		if (layoutSize == null)
		{
			throw new ArgumentNullException("layoutSize");
		}
		if (subitems == null)
		{
			throw new ArgumentNullException("subitems");
		}
		NSArray nSArray = NSArray.FromNSObjects(subitems);
		NSCollectionLayoutGroup nSObject = Runtime.GetNSObject<NSCollectionLayoutGroup>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selVerticalGroupWithLayoutSize_Subitems_Handle, layoutSize.Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}
}
