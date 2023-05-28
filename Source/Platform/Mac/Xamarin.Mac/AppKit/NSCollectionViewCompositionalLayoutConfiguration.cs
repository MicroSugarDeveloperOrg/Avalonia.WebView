using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionViewCompositionalLayoutConfiguration", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSCollectionViewCompositionalLayoutConfiguration : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundarySupplementaryItems = "boundarySupplementaryItems";

	private static readonly IntPtr selBoundarySupplementaryItemsHandle = Selector.GetHandle("boundarySupplementaryItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInterSectionSpacing = "interSectionSpacing";

	private static readonly IntPtr selInterSectionSpacingHandle = Selector.GetHandle("interSectionSpacing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollDirection = "scrollDirection";

	private static readonly IntPtr selScrollDirectionHandle = Selector.GetHandle("scrollDirection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBoundarySupplementaryItems_ = "setBoundarySupplementaryItems:";

	private static readonly IntPtr selSetBoundarySupplementaryItems_Handle = Selector.GetHandle("setBoundarySupplementaryItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInterSectionSpacing_ = "setInterSectionSpacing:";

	private static readonly IntPtr selSetInterSectionSpacing_Handle = Selector.GetHandle("setInterSectionSpacing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScrollDirection_ = "setScrollDirection:";

	private static readonly IntPtr selSetScrollDirection_Handle = Selector.GetHandle("setScrollDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionViewCompositionalLayoutConfiguration");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionLayoutBoundarySupplementaryItem[] BoundarySupplementaryItems
	{
		[Export("boundarySupplementaryItems", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSCollectionLayoutBoundarySupplementaryItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selBoundarySupplementaryItemsHandle));
			}
			return NSArray.ArrayFromHandle<NSCollectionLayoutBoundarySupplementaryItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBoundarySupplementaryItemsHandle));
		}
		[Export("setBoundarySupplementaryItems:", ArgumentSemantic.Copy)]
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
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBoundarySupplementaryItems_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBoundarySupplementaryItems_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nfloat InterSectionSpacing
	{
		[Export("interSectionSpacing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.nfloat_objc_msgSend(base.Handle, selInterSectionSpacingHandle);
			}
			return Messaging.nfloat_objc_msgSendSuper(base.SuperHandle, selInterSectionSpacingHandle);
		}
		[Export("setInterSectionSpacing:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nfloat(base.Handle, selSetInterSectionSpacing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nfloat(base.SuperHandle, selSetInterSectionSpacing_Handle, value);
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCollectionViewCompositionalLayoutConfiguration()
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
	protected NSCollectionViewCompositionalLayoutConfiguration(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionViewCompositionalLayoutConfiguration(IntPtr handle)
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
}
