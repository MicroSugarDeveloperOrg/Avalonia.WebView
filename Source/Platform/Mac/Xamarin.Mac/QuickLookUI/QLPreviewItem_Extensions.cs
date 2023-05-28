using Foundation;
using ObjCRuntime;

namespace QuickLookUI;

public static class QLPreviewItem_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl GetPreviewItemURL(this IQLPreviewItem This)
	{
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("previewItemURL")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetPreviewItemTitle(this IQLPreviewItem This)
	{
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("previewItemTitle")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSObject GetPreviewItemDisplayState(this IQLPreviewItem This)
	{
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("previewItemDisplayState")));
	}
}
