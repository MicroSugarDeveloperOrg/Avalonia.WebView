using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace UserNotifications;

[Register("UNTextInputNotificationAction", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class UNTextInputNotificationAction : UNNotificationAction
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActionWithIdentifier_Title_Options_TextInputButtonTitle_TextInputPlaceholder_ = "actionWithIdentifier:title:options:textInputButtonTitle:textInputPlaceholder:";

	private static readonly IntPtr selActionWithIdentifier_Title_Options_TextInputButtonTitle_TextInputPlaceholder_Handle = Selector.GetHandle("actionWithIdentifier:title:options:textInputButtonTitle:textInputPlaceholder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextInputButtonTitle = "textInputButtonTitle";

	private static readonly IntPtr selTextInputButtonTitleHandle = Selector.GetHandle("textInputButtonTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextInputPlaceholder = "textInputPlaceholder";

	private static readonly IntPtr selTextInputPlaceholderHandle = Selector.GetHandle("textInputPlaceholder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("UNTextInputNotificationAction");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string TextInputButtonTitle
	{
		[Export("textInputButtonTitle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTextInputButtonTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextInputButtonTitleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string TextInputPlaceholder
	{
		[Export("textInputPlaceholder")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTextInputPlaceholderHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextInputPlaceholderHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public UNTextInputNotificationAction(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected UNTextInputNotificationAction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal UNTextInputNotificationAction(IntPtr handle)
		: base(handle)
	{
	}

	[Export("actionWithIdentifier:title:options:textInputButtonTitle:textInputPlaceholder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static UNTextInputNotificationAction FromIdentifier(string identifier, string title, UNNotificationActionOptions options, string textInputButtonTitle, string textInputPlaceholder)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (title == null)
		{
			throw new ArgumentNullException("title");
		}
		if (textInputButtonTitle == null)
		{
			throw new ArgumentNullException("textInputButtonTitle");
		}
		if (textInputPlaceholder == null)
		{
			throw new ArgumentNullException("textInputPlaceholder");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		IntPtr arg2 = NSString.CreateNative(title);
		IntPtr arg3 = NSString.CreateNative(textInputButtonTitle);
		IntPtr arg4 = NSString.CreateNative(textInputPlaceholder);
		UNTextInputNotificationAction nSObject = Runtime.GetNSObject<UNTextInputNotificationAction>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_IntPtr(class_ptr, selActionWithIdentifier_Title_Options_TextInputButtonTitle_TextInputPlaceholder_Handle, arg, arg2, (ulong)options, arg3, arg4));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		NSString.ReleaseNative(arg4);
		return nSObject;
	}
}
