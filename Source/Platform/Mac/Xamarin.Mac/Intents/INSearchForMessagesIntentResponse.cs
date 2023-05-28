using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INSearchForMessagesIntentResponse", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INSearchForMessagesIntentResponse : INIntentResponse
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCode = "code";

	private static readonly IntPtr selCodeHandle = Selector.GetHandle("code");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCode_UserActivity_ = "initWithCode:userActivity:";

	private static readonly IntPtr selInitWithCode_UserActivity_Handle = Selector.GetHandle("initWithCode:userActivity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMessages = "messages";

	private static readonly IntPtr selMessagesHandle = Selector.GetHandle("messages");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMessages_ = "setMessages:";

	private static readonly IntPtr selSetMessages_Handle = Selector.GetHandle("setMessages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INSearchForMessagesIntentResponse");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INSearchForMessagesIntentResponseCode Code
	{
		[Export("code")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INSearchForMessagesIntentResponseCode)Messaging.Int64_objc_msgSend(base.Handle, selCodeHandle);
			}
			return (INSearchForMessagesIntentResponseCode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCodeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INMessage[]? Messages
	{
		[Export("messages", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<INMessage>(Messaging.IntPtr_objc_msgSend(base.Handle, selMessagesHandle));
			}
			return NSArray.ArrayFromHandle<INMessage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMessagesHandle));
		}
		[Export("setMessages:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMessages_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMessages_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public INSearchForMessagesIntentResponse(NSCoder coder)
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
	protected INSearchForMessagesIntentResponse(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INSearchForMessagesIntentResponse(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCode:userActivity:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSearchForMessagesIntentResponse(INSearchForMessagesIntentResponseCode code, NSUserActivity? userActivity)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Int64_IntPtr(base.Handle, selInitWithCode_UserActivity_Handle, (long)code, userActivity?.Handle ?? IntPtr.Zero), "initWithCode:userActivity:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selInitWithCode_UserActivity_Handle, (long)code, userActivity?.Handle ?? IntPtr.Zero), "initWithCode:userActivity:");
		}
	}
}
