using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public static class NSTextStorageDelegate_Extensions
{
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use WillProcessEditing instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void TextStorageWillProcessEditing(this INSTextStorageDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("textStorageWillProcessEditing:"), notification.Handle);
	}

	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, "Use DidProcessEditing instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void TextStorageDidProcessEditing(this INSTextStorageDelegate This, NSNotification notification)
	{
		NSApplication.EnsureUIThread();
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("textStorageDidProcessEditing:"), notification.Handle);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillProcessEditing(this INSTextStorageDelegate This, NSTextStorage textStorage, NSTextStorageEditActions editedMask, NSRange editedRange, nint delta)
	{
		NSApplication.EnsureUIThread();
		if (textStorage == null)
		{
			throw new ArgumentNullException("textStorage");
		}
		Messaging.void_objc_msgSend_IntPtr_UInt64_NSRange_nint(This.Handle, Selector.GetHandle("textStorage:willProcessEditing:range:changeInLength:"), textStorage.Handle, (ulong)editedMask, editedRange, delta);
	}

	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidProcessEditing(this INSTextStorageDelegate This, NSTextStorage textStorage, NSTextStorageEditActions editedMask, NSRange editedRange, nint delta)
	{
		NSApplication.EnsureUIThread();
		if (textStorage == null)
		{
			throw new ArgumentNullException("textStorage");
		}
		Messaging.void_objc_msgSend_IntPtr_UInt64_NSRange_nint(This.Handle, Selector.GetHandle("textStorage:didProcessEditing:range:changeInLength:"), textStorage.Handle, (ulong)editedMask, editedRange, delta);
	}
}
