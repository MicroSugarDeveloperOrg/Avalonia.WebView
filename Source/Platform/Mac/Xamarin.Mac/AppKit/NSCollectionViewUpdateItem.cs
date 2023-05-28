using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCollectionViewUpdateItem", true)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSCollectionViewUpdateItem : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathAfterUpdate = "indexPathAfterUpdate";

	private static readonly IntPtr selIndexPathAfterUpdateHandle = Selector.GetHandle("indexPathAfterUpdate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIndexPathBeforeUpdate = "indexPathBeforeUpdate";

	private static readonly IntPtr selIndexPathBeforeUpdateHandle = Selector.GetHandle("indexPathBeforeUpdate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateAction = "updateAction";

	private static readonly IntPtr selUpdateActionHandle = Selector.GetHandle("updateAction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCollectionViewUpdateItem");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexPath? IndexPathAfterUpdate
	{
		[Export("indexPathAfterUpdate")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selIndexPathAfterUpdateHandle));
			}
			return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIndexPathAfterUpdateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSIndexPath? IndexPathBeforeUpdate
	{
		[Export("indexPathBeforeUpdate")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selIndexPathBeforeUpdateHandle));
			}
			return Runtime.GetNSObject<NSIndexPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIndexPathBeforeUpdateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCollectionUpdateAction UpdateAction
	{
		[Export("updateAction")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return (NSCollectionUpdateAction)Messaging.Int64_objc_msgSend(base.Handle, selUpdateActionHandle);
			}
			return (NSCollectionUpdateAction)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selUpdateActionHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCollectionViewUpdateItem()
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
	protected NSCollectionViewUpdateItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCollectionViewUpdateItem(IntPtr handle)
		: base(handle)
	{
	}
}
