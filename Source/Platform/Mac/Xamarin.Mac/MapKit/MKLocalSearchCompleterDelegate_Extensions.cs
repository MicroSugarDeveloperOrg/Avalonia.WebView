using System;
using Foundation;
using ObjCRuntime;

namespace MapKit;

public static class MKLocalSearchCompleterDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidUpdateResults(this IMKLocalSearchCompleterDelegate This, MKLocalSearchCompleter completer)
	{
		if (completer == null)
		{
			throw new ArgumentNullException("completer");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("completerDidUpdateResults:"), completer.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidFail(this IMKLocalSearchCompleterDelegate This, MKLocalSearchCompleter completer, NSError error)
	{
		if (completer == null)
		{
			throw new ArgumentNullException("completer");
		}
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("completer:didFailWithError:"), completer.Handle, error.Handle);
	}
}
