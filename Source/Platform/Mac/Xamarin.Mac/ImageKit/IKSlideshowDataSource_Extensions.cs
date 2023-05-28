using System;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

public static class IKSlideshowDataSource_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetNameOfItemAt(this IIKSlideshowDataSource This, nint index)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_nint(This.Handle, Selector.GetHandle("nameOfSlideshowItemAtIndex:"), index));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanExportItemToApplication(this IIKSlideshowDataSource This, nint index, string applicationBundleIdentifier)
	{
		if (applicationBundleIdentifier == null)
		{
			throw new ArgumentNullException("applicationBundleIdentifier");
		}
		IntPtr intPtr = NSString.CreateNative(applicationBundleIdentifier);
		bool result = Messaging.bool_objc_msgSend_nint_IntPtr(This.Handle, Selector.GetHandle("canExportSlideshowItemAtIndex:toApplication:"), index, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void WillStart(this IIKSlideshowDataSource This)
	{
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("slideshowWillStart"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidStop(this IIKSlideshowDataSource This)
	{
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("slideshowDidStop"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void DidChange(this IIKSlideshowDataSource This, nint newIndex)
	{
		Messaging.void_objc_msgSend_nint(This.Handle, Selector.GetHandle("slideshowDidChangeCurrentIndex:"), newIndex);
	}
}
