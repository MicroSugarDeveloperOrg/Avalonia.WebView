using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Register("SKProductsRequest", true)]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
public class SKProductsRequest : SKRequest
{
	[Register]
	internal class _SKProductsRequestDelegate : _SKRequestDelegate, ISKProductsRequestDelegate, INativeObject, IDisposable, ISKRequestDelegate
	{
		internal EventHandler<SKProductsRequestResponseEventArgs>? receivedResponse;

		public _SKProductsRequestDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("productsRequest:didReceiveResponse:")]
		public void ReceivedResponse(SKProductsRequest request, SKProductsResponse response)
		{
			EventHandler<SKProductsRequestResponseEventArgs> eventHandler = receivedResponse;
			if (eventHandler != null)
			{
				SKProductsRequestResponseEventArgs e = new SKProductsRequestResponseEventArgs(response);
				eventHandler(request, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithProductIdentifiers_ = "initWithProductIdentifiers:";

	private static readonly IntPtr selInitWithProductIdentifiers_Handle = Selector.GetHandle("initWithProductIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKProductsRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new ISKProductsRequestDelegate Delegate
	{
		get
		{
			return WeakDelegate as ISKProductsRequestDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal override Type GetInternalEventDelegateType => typeof(_SKProductsRequestDelegate);

	public event EventHandler<SKProductsRequestResponseEventArgs> ReceivedResponse
	{
		add
		{
			_SKProductsRequestDelegate sKProductsRequestDelegate = EnsureSKProductsRequestDelegate();
			sKProductsRequestDelegate.receivedResponse = (EventHandler<SKProductsRequestResponseEventArgs>)System.Delegate.Combine(sKProductsRequestDelegate.receivedResponse, value);
		}
		remove
		{
			_SKProductsRequestDelegate sKProductsRequestDelegate = EnsureSKProductsRequestDelegate();
			sKProductsRequestDelegate.receivedResponse = (EventHandler<SKProductsRequestResponseEventArgs>)System.Delegate.Remove(sKProductsRequestDelegate.receivedResponse, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKProductsRequest()
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
	protected SKProductsRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKProductsRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithProductIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKProductsRequest(NSSet productIdentifiersStringSet)
		: base(NSObjectFlag.Empty)
	{
		if (productIdentifiersStringSet == null)
		{
			throw new ArgumentNullException("productIdentifiersStringSet");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithProductIdentifiers_Handle, productIdentifiersStringSet.Handle), "initWithProductIdentifiers:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithProductIdentifiers_Handle, productIdentifiersStringSet.Handle), "initWithProductIdentifiers:");
		}
	}

	internal override _SKRequestDelegate CreateInternalEventDelegateType()
	{
		return new _SKProductsRequestDelegate();
	}

	internal _SKProductsRequestDelegate EnsureSKProductsRequestDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_SKProductsRequestDelegate sKProductsRequestDelegate = Delegate as _SKProductsRequestDelegate;
		if (sKProductsRequestDelegate == null)
		{
			sKProductsRequestDelegate = (_SKProductsRequestDelegate)(Delegate = (_SKProductsRequestDelegate)CreateInternalEventDelegateType());
		}
		return sKProductsRequestDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
