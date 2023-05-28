using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public static class AVContentKeySession_AVContentKeyRecipients
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddContentKeyRecipient_ = "addContentKeyRecipient:";

	private static readonly IntPtr selAddContentKeyRecipient_Handle = Selector.GetHandle("addContentKeyRecipient:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentKeyRecipients = "contentKeyRecipients";

	private static readonly IntPtr selContentKeyRecipientsHandle = Selector.GetHandle("contentKeyRecipients");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveContentKeyRecipient_ = "removeContentKeyRecipient:";

	private static readonly IntPtr selRemoveContentKeyRecipient_Handle = Selector.GetHandle("removeContentKeyRecipient:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("AVContentKeySession");

	[Export("addContentKeyRecipient:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Add(this AVContentKeySession This, IAVContentKeyRecipient recipient)
	{
		if (recipient == null)
		{
			throw new ArgumentNullException("recipient");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selAddContentKeyRecipient_Handle, recipient.Handle);
	}

	[Export("contentKeyRecipients")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IAVContentKeyRecipient[] GetContentKeyRecipients(this AVContentKeySession This)
	{
		return NSArray.ArrayFromHandle<IAVContentKeyRecipient>(Messaging.IntPtr_objc_msgSend(This.Handle, selContentKeyRecipientsHandle));
	}

	[Export("removeContentKeyRecipient:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void Remove(this AVContentKeySession This, IAVContentKeyRecipient recipient)
	{
		if (recipient == null)
		{
			throw new ArgumentNullException("recipient");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selRemoveContentKeyRecipient_Handle, recipient.Handle);
	}
}
