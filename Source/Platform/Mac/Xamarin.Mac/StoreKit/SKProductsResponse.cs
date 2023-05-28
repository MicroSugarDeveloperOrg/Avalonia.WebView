using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Register("SKProductsResponse", true)]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
public class SKProductsResponse : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidProductIdentifiers = "invalidProductIdentifiers";

	private static readonly IntPtr selInvalidProductIdentifiersHandle = Selector.GetHandle("invalidProductIdentifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProducts = "products";

	private static readonly IntPtr selProductsHandle = Selector.GetHandle("products");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKProductsResponse");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] InvalidProducts
	{
		[Export("invalidProductIdentifiers")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInvalidProductIdentifiersHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInvalidProductIdentifiersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKProduct[] Products
	{
		[Export("products")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SKProduct>(Messaging.IntPtr_objc_msgSend(base.Handle, selProductsHandle));
			}
			return NSArray.ArrayFromHandle<SKProduct>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProductsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKProductsResponse()
		: base(NSObjectFlag.Empty)
	{
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
	protected SKProductsResponse(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKProductsResponse(IntPtr handle)
		: base(handle)
	{
	}
}
