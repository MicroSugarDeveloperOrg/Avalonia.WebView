using System;
using Foundation;
using ObjCRuntime;

namespace WebKit;

internal sealed class DomEventTargetWrapper : BaseWrapper, IDomEventTarget, INativeObject, IDisposable, INSCopying
{
	[Preserve(Conditional = true)]
	public DomEventTargetWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("addEventListener:listener:useCapture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void AddEventListener(string type, IDomEventListener listener, bool useCapture)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		IntPtr intPtr = NSString.CreateNative(type);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, Selector.GetHandle("addEventListener:listener:useCapture:"), intPtr, listener.Handle, useCapture);
		NSString.ReleaseNative(intPtr);
	}

	[Export("removeEventListener:listener:useCapture:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RemoveEventListener(string type, IDomEventListener listener, bool useCapture)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		IntPtr intPtr = NSString.CreateNative(type);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, Selector.GetHandle("removeEventListener:listener:useCapture:"), intPtr, listener.Handle, useCapture);
		NSString.ReleaseNative(intPtr);
	}

	[Export("dispatchEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool DispatchEvent(DomEvent evt)
	{
		if (evt == null)
		{
			throw new ArgumentNullException("evt");
		}
		return Messaging.bool_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("dispatchEvent:"), evt.Handle);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("copyWithZone:"), zone?.Handle ?? IntPtr.Zero));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}
