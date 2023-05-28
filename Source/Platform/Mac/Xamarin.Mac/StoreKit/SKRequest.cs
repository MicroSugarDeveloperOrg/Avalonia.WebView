using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Register("SKRequest", true)]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
public class SKRequest : NSObject
{
	[Register]
	internal class _SKRequestDelegate : NSObject, ISKRequestDelegate, INativeObject, IDisposable
	{
		internal EventHandler<SKRequestErrorEventArgs>? requestFailed;

		internal EventHandler? requestFinished;

		public _SKRequestDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("request:didFailWithError:")]
		public void RequestFailed(SKRequest request, NSError error)
		{
			EventHandler<SKRequestErrorEventArgs> eventHandler = requestFailed;
			if (eventHandler != null)
			{
				SKRequestErrorEventArgs e = new SKRequestErrorEventArgs(error);
				eventHandler(request, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("requestDidFinish:")]
		public void RequestFinished(SKRequest request)
		{
			requestFinished?.Invoke(request, EventArgs.Empty);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStart = "start";

	private static readonly IntPtr selStartHandle = Selector.GetHandle("start");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public ISKRequestDelegate Delegate
	{
		get
		{
			return WeakDelegate as ISKRequestDelegate;
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
	public virtual NSObject? WeakDelegate
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

	internal virtual Type GetInternalEventDelegateType => typeof(_SKRequestDelegate);

	public event EventHandler<SKRequestErrorEventArgs> RequestFailed
	{
		add
		{
			_SKRequestDelegate sKRequestDelegate = EnsureSKRequestDelegate();
			sKRequestDelegate.requestFailed = (EventHandler<SKRequestErrorEventArgs>)System.Delegate.Combine(sKRequestDelegate.requestFailed, value);
		}
		remove
		{
			_SKRequestDelegate sKRequestDelegate = EnsureSKRequestDelegate();
			sKRequestDelegate.requestFailed = (EventHandler<SKRequestErrorEventArgs>)System.Delegate.Remove(sKRequestDelegate.requestFailed, value);
		}
	}

	public event EventHandler RequestFinished
	{
		add
		{
			_SKRequestDelegate sKRequestDelegate = EnsureSKRequestDelegate();
			sKRequestDelegate.requestFinished = (EventHandler)System.Delegate.Combine(sKRequestDelegate.requestFinished, value);
		}
		remove
		{
			_SKRequestDelegate sKRequestDelegate = EnsureSKRequestDelegate();
			sKRequestDelegate.requestFinished = (EventHandler)System.Delegate.Remove(sKRequestDelegate.requestFinished, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKRequest()
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
	protected SKRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cancel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[Export("start")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Start()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartHandle);
		}
	}

	internal virtual _SKRequestDelegate CreateInternalEventDelegateType()
	{
		return new _SKRequestDelegate();
	}

	internal _SKRequestDelegate EnsureSKRequestDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_SKRequestDelegate sKRequestDelegate = Delegate as _SKRequestDelegate;
		if (sKRequestDelegate == null)
		{
			sKRequestDelegate = (_SKRequestDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return sKRequestDelegate;
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
