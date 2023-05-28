using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Register("NSCollectionLayoutSupplementaryItem", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSCollectionLayoutSupplementaryItem : NSCollectionLayoutItem, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainerAnchor = "containerAnchor";

	private static readonly IntPtr selContainerAnchorHandle = Selector.GetHandle("containerAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementKind = "elementKind";

	private static readonly IntPtr selElementKindHandle = Selector.GetHandle("elementKind");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemAnchor = "itemAnchor";

	private static readonly IntPtr selItemAnchorHandle = Selector.GetHandle("itemAnchor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetZIndex_ = "setZIndex:";

	private static readonly IntPtr selSetZIndex_Handle = Selector.GetHandle("setZIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupplementaryItemWithLayoutSize_ElementKind_ContainerAnchor_ = "supplementaryItemWithLayoutSize:elementKind:containerAnchor:";

	private static readonly IntPtr selSupplementaryItemWithLayoutSize_ElementKind_ContainerAnchor_Handle = Selector.GetHandle("supplementaryItemWithLayoutSize:elementKind:containerAnchor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSupplementaryItemWithLayoutSize_ElementKind_ContainerAnchor_ItemAnchor_ = "supplementaryItemWithLayoutSize:elementKind:containerAnchor:itemAnchor:";

	private static readonly IntPtr selSupplementaryItemWithLayoutSize_ElementKind_ContainerAnchor_ItemAnchor_Handle = Selector.GetHandle("supplementaryItemWithLayoutSize:elementKind:containerAnchor:itemAnchor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selZIndex = "zIndex";

	private static readonly IntPtr selZIndexHandle = Selector.GetHandle("zIndex");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionLayoutSupplementaryItem");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutAnchor ContainerAnchor
	{
		[Export("containerAnchor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCollectionLayoutAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selContainerAnchorHandle));
			}
			return Runtime.GetNSObject<NSCollectionLayoutAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContainerAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ElementKind
	{
		[Export("elementKind")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selElementKindHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selElementKindHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutAnchor? ItemAnchor
	{
		[Export("itemAnchor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCollectionLayoutAnchor>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemAnchorHandle));
			}
			return Runtime.GetNSObject<NSCollectionLayoutAnchor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemAnchorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint ZIndex
	{
		[Export("zIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selZIndexHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selZIndexHandle);
		}
		[Export("setZIndex:")]
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
	protected NSCollectionLayoutSupplementaryItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionLayoutSupplementaryItem(IntPtr handle)
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

	[Export("supplementaryItemWithLayoutSize:elementKind:containerAnchor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutSupplementaryItem Create(NSCollectionLayoutSize layoutSize, string elementKind, NSCollectionLayoutAnchor containerAnchor)
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
		if (containerAnchor == null)
		{
			throw new ArgumentNullException("containerAnchor");
		}
		IntPtr arg = NSString.CreateNative(elementKind);
		NSCollectionLayoutSupplementaryItem nSObject = Runtime.GetNSObject<NSCollectionLayoutSupplementaryItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selSupplementaryItemWithLayoutSize_ElementKind_ContainerAnchor_Handle, layoutSize.Handle, arg, containerAnchor.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("supplementaryItemWithLayoutSize:elementKind:containerAnchor:itemAnchor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCollectionLayoutSupplementaryItem Create(NSCollectionLayoutSize layoutSize, string elementKind, NSCollectionLayoutAnchor containerAnchor, NSCollectionLayoutAnchor itemAnchor)
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
		if (containerAnchor == null)
		{
			throw new ArgumentNullException("containerAnchor");
		}
		if (itemAnchor == null)
		{
			throw new ArgumentNullException("itemAnchor");
		}
		IntPtr arg = NSString.CreateNative(elementKind);
		NSCollectionLayoutSupplementaryItem nSObject = Runtime.GetNSObject<NSCollectionLayoutSupplementaryItem>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selSupplementaryItemWithLayoutSize_ElementKind_ContainerAnchor_ItemAnchor_Handle, layoutSize.Handle, arg, containerAnchor.Handle, itemAnchor.Handle));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
