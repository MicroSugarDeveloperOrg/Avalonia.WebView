using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSTextViewDidChangeSelectionEventArgs : NSNotificationEventArgs
{
	[Field("NSOldSelectedCharacterRange", "AppKit")]
	private static IntPtr k0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSValue OldSelectedCharacterRange
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AppKit.Handle, "NSOldSelectedCharacterRange");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSValue>(ptr);
		}
	}

	public NSTextViewDidChangeSelectionEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
