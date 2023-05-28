using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSPasteboardWriting_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetWritableTypesForPasteboard(this INSPasteboardWriting This, NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("writableTypesForPasteboard:"), pasteboard.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPasteboardWritingOptions GetWritingOptionsForType(this INSPasteboardWriting This, string type, NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		IntPtr intPtr = NSString.CreateNative(type);
		NSPasteboardWritingOptions result = (NSPasteboardWritingOptions)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("writingOptionsForType:pasteboard:"), intPtr, pasteboard.Handle);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject GetPasteboardPropertyListForType(this INSPasteboardWriting This, string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr intPtr = NSString.CreateNative(type);
		NSObject nSObject = Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("pasteboardPropertyListForType:"), intPtr));
		NSString.ReleaseNative(intPtr);
		return nSObject;
	}
}
