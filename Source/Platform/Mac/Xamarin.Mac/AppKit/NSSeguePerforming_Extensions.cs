using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSSeguePerforming_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PrepareForSegue(this INSSeguePerforming This, NSStoryboardSegue segue, NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (segue == null)
		{
			throw new ArgumentNullException("segue");
		}
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("prepareForSegue:sender:"), segue.Handle, sender.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PerformSegue(this INSSeguePerforming This, string identifier, NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		IntPtr intPtr = NSString.CreateNative(identifier);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("performSegueWithIdentifier:sender:"), intPtr, sender.Handle);
		NSString.ReleaseNative(intPtr);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldPerformSegue(this INSSeguePerforming This, string identifier, NSObject sender)
	{
		NSApplication.EnsureUIThread();
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		IntPtr intPtr = NSString.CreateNative(identifier);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("shouldPerformSegueWithIdentifier:sender:"), intPtr, sender.Handle);
		NSString.ReleaseNative(intPtr);
		return result;
	}
}
