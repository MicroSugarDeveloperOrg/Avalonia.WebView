using System;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

public static class IKSaveOptionsDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldShowType(this IIKSaveOptionsDelegate This, IKSaveOptions saveOptions, string imageUTType)
	{
		if (saveOptions == null)
		{
			throw new ArgumentNullException("saveOptions");
		}
		if (imageUTType == null)
		{
			throw new ArgumentNullException("imageUTType");
		}
		IntPtr intPtr = NSString.CreateNative(imageUTType);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("saveOptions:shouldShowUTType:"), saveOptions.Handle, intPtr);
		NSString.ReleaseNative(intPtr);
		return result;
	}
}
