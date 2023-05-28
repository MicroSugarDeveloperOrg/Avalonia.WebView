using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INMessage", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INMessage : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContent = "content";

	private static readonly IntPtr selContentHandle = Selector.GetHandle("content");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConversationIdentifier = "conversationIdentifier";

	private static readonly IntPtr selConversationIdentifierHandle = Selector.GetHandle("conversationIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateSent = "dateSent";

	private static readonly IntPtr selDateSentHandle = Selector.GetHandle("dateSent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupName = "groupName";

	private static readonly IntPtr selGroupNameHandle = Selector.GetHandle("groupName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_Content_DateSent_Sender_Recipients_ = "initWithIdentifier:content:dateSent:sender:recipients:";

	private static readonly IntPtr selInitWithIdentifier_Content_DateSent_Sender_Recipients_Handle = Selector.GetHandle("initWithIdentifier:content:dateSent:sender:recipients:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_ConversationIdentifier_Content_DateSent_Sender_Recipients_GroupName_MessageType_ = "initWithIdentifier:conversationIdentifier:content:dateSent:sender:recipients:groupName:messageType:";

	private static readonly IntPtr selInitWithIdentifier_ConversationIdentifier_Content_DateSent_Sender_Recipients_GroupName_MessageType_Handle = Selector.GetHandle("initWithIdentifier:conversationIdentifier:content:dateSent:sender:recipients:groupName:messageType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_ConversationIdentifier_Content_DateSent_Sender_Recipients_MessageType_ = "initWithIdentifier:conversationIdentifier:content:dateSent:sender:recipients:messageType:";

	private static readonly IntPtr selInitWithIdentifier_ConversationIdentifier_Content_DateSent_Sender_Recipients_MessageType_Handle = Selector.GetHandle("initWithIdentifier:conversationIdentifier:content:dateSent:sender:recipients:messageType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMessageType = "messageType";

	private static readonly IntPtr selMessageTypeHandle = Selector.GetHandle("messageType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecipients = "recipients";

	private static readonly IntPtr selRecipientsHandle = Selector.GetHandle("recipients");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSender = "sender";

	private static readonly IntPtr selSenderHandle = Selector.GetHandle("sender");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INMessage");

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
	public virtual NSDate? DateSent
	{
		[Export("dateSent", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selDateSentHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateSentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual INSpeakableString? GroupName
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("groupName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<INSpeakableString>(Messaging.IntPtr_objc_msgSend(base.Handle, selGroupNameHandle));
			}
			return Runtime.GetNSObject<INSpeakableString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGroupNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual INMessageType MessageType
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("messageType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INMessageType)Messaging.Int64_objc_msgSend(base.Handle, selMessageTypeHandle);
			}
			return (INMessageType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selMessageTypeHandle);
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public INMessage(NSCoder coder)
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
	protected INMessage(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INMessage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifier:conversationIdentifier:content:dateSent:sender:recipients:groupName:messageType:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INMessage(string identifier, string? conversationIdentifier, string? content, NSDate? dateSent, INPerson? sender, INPerson[]? recipients, INSpeakableString? groupName, INMessageType messageType)
		: base(NSObjectFlag.Empty)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		IntPtr arg2 = NSString.CreateNative(conversationIdentifier);
		IntPtr arg3 = NSString.CreateNative(content);
		NSArray nSArray = ((recipients == null) ? null : NSArray.FromNSObjects(recipients));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int64(base.Handle, selInitWithIdentifier_ConversationIdentifier_Content_DateSent_Sender_Recipients_GroupName_MessageType_Handle, arg, arg2, arg3, dateSent?.Handle ?? IntPtr.Zero, sender?.Handle ?? IntPtr.Zero, nSArray?.Handle ?? IntPtr.Zero, groupName?.Handle ?? IntPtr.Zero, (long)messageType), "initWithIdentifier:conversationIdentifier:content:dateSent:sender:recipients:groupName:messageType:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int64(base.SuperHandle, selInitWithIdentifier_ConversationIdentifier_Content_DateSent_Sender_Recipients_GroupName_MessageType_Handle, arg, arg2, arg3, dateSent?.Handle ?? IntPtr.Zero, sender?.Handle ?? IntPtr.Zero, nSArray?.Handle ?? IntPtr.Zero, groupName?.Handle ?? IntPtr.Zero, (long)messageType), "initWithIdentifier:conversationIdentifier:content:dateSent:sender:recipients:groupName:messageType:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		nSArray?.Dispose();
	}

	[Export("initWithIdentifier:conversationIdentifier:content:dateSent:sender:recipients:messageType:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INMessage(string identifier, string? conversationIdentifier, string? content, NSDate? dateSent, INPerson? sender, INPerson[]? recipients, INMessageType messageType)
		: base(NSObjectFlag.Empty)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		IntPtr arg2 = NSString.CreateNative(conversationIdentifier);
		IntPtr arg3 = NSString.CreateNative(content);
		NSArray nSArray = ((recipients == null) ? null : NSArray.FromNSObjects(recipients));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int64(base.Handle, selInitWithIdentifier_ConversationIdentifier_Content_DateSent_Sender_Recipients_MessageType_Handle, arg, arg2, arg3, dateSent?.Handle ?? IntPtr.Zero, sender?.Handle ?? IntPtr.Zero, nSArray?.Handle ?? IntPtr.Zero, (long)messageType), "initWithIdentifier:conversationIdentifier:content:dateSent:sender:recipients:messageType:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_Int64(base.SuperHandle, selInitWithIdentifier_ConversationIdentifier_Content_DateSent_Sender_Recipients_MessageType_Handle, arg, arg2, arg3, dateSent?.Handle ?? IntPtr.Zero, sender?.Handle ?? IntPtr.Zero, nSArray?.Handle ?? IntPtr.Zero, (long)messageType), "initWithIdentifier:conversationIdentifier:content:dateSent:sender:recipients:messageType:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		nSArray?.Dispose();
	}

	[Export("initWithIdentifier:content:dateSent:sender:recipients:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INMessage(string identifier, string? content, NSDate? dateSent, INPerson? sender, INPerson[]? recipients)
		: base(NSObjectFlag.Empty)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		IntPtr arg2 = NSString.CreateNative(content);
		NSArray nSArray = ((recipients == null) ? null : NSArray.FromNSObjects(recipients));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithIdentifier_Content_DateSent_Sender_Recipients_Handle, arg, arg2, dateSent?.Handle ?? IntPtr.Zero, sender?.Handle ?? IntPtr.Zero, nSArray?.Handle ?? IntPtr.Zero), "initWithIdentifier:content:dateSent:sender:recipients:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithIdentifier_Content_DateSent_Sender_Recipients_Handle, arg, arg2, dateSent?.Handle ?? IntPtr.Zero, sender?.Handle ?? IntPtr.Zero, nSArray?.Handle ?? IntPtr.Zero), "initWithIdentifier:content:dateSent:sender:recipients:");
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		nSArray?.Dispose();
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}
}
