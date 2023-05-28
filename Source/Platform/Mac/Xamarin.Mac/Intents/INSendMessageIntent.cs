using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INSendMessageIntent", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INSendMessageIntent : INIntent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContent = "content";

	private static readonly IntPtr selContentHandle = Selector.GetHandle("content");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConversationIdentifier = "conversationIdentifier";

	private static readonly IntPtr selConversationIdentifierHandle = Selector.GetHandle("conversationIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupName = "groupName";

	private static readonly IntPtr selGroupNameHandle = Selector.GetHandle("groupName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRecipients_Content_GroupName_ServiceName_Sender_ = "initWithRecipients:content:groupName:serviceName:sender:";

	private static readonly IntPtr selInitWithRecipients_Content_GroupName_ServiceName_Sender_Handle = Selector.GetHandle("initWithRecipients:content:groupName:serviceName:sender:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRecipients_Content_SpeakableGroupName_ConversationIdentifier_ServiceName_Sender_ = "initWithRecipients:content:speakableGroupName:conversationIdentifier:serviceName:sender:";

	private static readonly IntPtr selInitWithRecipients_Content_SpeakableGroupName_ConversationIdentifier_ServiceName_Sender_Handle = Selector.GetHandle("initWithRecipients:content:speakableGroupName:conversationIdentifier:serviceName:sender:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecipients = "recipients";

	private static readonly IntPtr selRecipientsHandle = Selector.GetHandle("recipients");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSender = "sender";

	private static readonly IntPtr selSenderHandle = Selector.GetHandle("sender");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selServiceName = "serviceName";

	private static readonly IntPtr selServiceNameHandle = Selector.GetHandle("serviceName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeakableGroupName = "speakableGroupName";

	private static readonly IntPtr selSpeakableGroupNameHandle = Selector.GetHandle("speakableGroupName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INSendMessageIntent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Content
	{
		[Export("content")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selContentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual string? ConversationIdentifier
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("conversationIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selConversationIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConversationIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SpeakableGroupNames' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SpeakableGroupNames' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SpeakableGroupNames' instead.")]
	public virtual string? GroupName
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SpeakableGroupNames' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SpeakableGroupNames' instead.")]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SpeakableGroupNames' instead.")]
		[Export("groupName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGroupNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGroupNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INPerson[]? Recipients
	{
		[Export("recipients", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<INPerson>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecipientsHandle));
			}
			return NSArray.ArrayFromHandle<INPerson>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecipientsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INPerson? Sender
	{
		[Export("sender", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<INPerson>(Messaging.IntPtr_objc_msgSend(base.Handle, selSenderHandle));
			}
			return Runtime.GetNSObject<INPerson>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSenderHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? ServiceName
	{
		[Export("serviceName")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selServiceNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selServiceNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual INSpeakableString? SpeakableGroupName
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("speakableGroupName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<INSpeakableString>(Messaging.IntPtr_objc_msgSend(base.Handle, selSpeakableGroupNameHandle));
			}
			return Runtime.GetNSObject<INSpeakableString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSpeakableGroupNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public INSendMessageIntent()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public INSendMessageIntent(NSCoder coder)
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
	protected INSendMessageIntent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INSendMessageIntent(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRecipients:content:speakableGroupName:conversationIdentifier:serviceName:sender:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSendMessageIntent(INPerson[]? recipients, string? content, INSpeakableString? speakableGroupName, string? conversationIdentifier, string? serviceName, INPerson? sender)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((recipients == null) ? null : NSArray.FromNSObjects(recipients));
		IntPtr arg = NSString.CreateNative(content);
		IntPtr arg2 = NSString.CreateNative(conversationIdentifier);
		IntPtr arg3 = NSString.CreateNative(serviceName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithRecipients_Content_SpeakableGroupName_ConversationIdentifier_ServiceName_Sender_Handle, nSArray?.Handle ?? IntPtr.Zero, arg, speakableGroupName?.Handle ?? IntPtr.Zero, arg2, arg3, sender?.Handle ?? IntPtr.Zero), "initWithRecipients:content:speakableGroupName:conversationIdentifier:serviceName:sender:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithRecipients_Content_SpeakableGroupName_ConversationIdentifier_ServiceName_Sender_Handle, nSArray?.Handle ?? IntPtr.Zero, arg, speakableGroupName?.Handle ?? IntPtr.Zero, arg2, arg3, sender?.Handle ?? IntPtr.Zero), "initWithRecipients:content:speakableGroupName:conversationIdentifier:serviceName:sender:");
		}
		nSArray?.Dispose();
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("initWithRecipients:content:groupName:serviceName:sender:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use '.ctor (INPerson [], string, INSpeakableString, string, string, INPerson)' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use '.ctor (INPerson [], string, INSpeakableString, string, string, INPerson)' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use '.ctor (INPerson [], string, INSpeakableString, string, string, INPerson)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSendMessageIntent(INPerson[]? recipients, string? content, string? groupName, string? serviceName, INPerson? sender)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((recipients == null) ? null : NSArray.FromNSObjects(recipients));
		IntPtr arg = NSString.CreateNative(content);
		IntPtr arg2 = NSString.CreateNative(groupName);
		IntPtr arg3 = NSString.CreateNative(serviceName);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithRecipients_Content_GroupName_ServiceName_Sender_Handle, nSArray?.Handle ?? IntPtr.Zero, arg, arg2, arg3, sender?.Handle ?? IntPtr.Zero), "initWithRecipients:content:groupName:serviceName:sender:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithRecipients_Content_GroupName_ServiceName_Sender_Handle, nSArray?.Handle ?? IntPtr.Zero, arg, arg2, arg3, sender?.Handle ?? IntPtr.Zero), "initWithRecipients:content:groupName:serviceName:sender:");
		}
		nSArray?.Dispose();
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}
}
