using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INSearchForMessagesIntent", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INSearchForMessagesIntent : INIntent
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributes = "attributes";

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConversationIdentifiers = "conversationIdentifiers";

	private static readonly IntPtr selConversationIdentifiersHandle = Selector.GetHandle("conversationIdentifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConversationIdentifiersOperator = "conversationIdentifiersOperator";

	private static readonly IntPtr selConversationIdentifiersOperatorHandle = Selector.GetHandle("conversationIdentifiersOperator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateTimeRange = "dateTimeRange";

	private static readonly IntPtr selDateTimeRangeHandle = Selector.GetHandle("dateTimeRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupNames = "groupNames";

	private static readonly IntPtr selGroupNamesHandle = Selector.GetHandle("groupNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupNamesOperator = "groupNamesOperator";

	private static readonly IntPtr selGroupNamesOperatorHandle = Selector.GetHandle("groupNamesOperator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifiers = "identifiers";

	private static readonly IntPtr selIdentifiersHandle = Selector.GetHandle("identifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifiersOperator = "identifiersOperator";

	private static readonly IntPtr selIdentifiersOperatorHandle = Selector.GetHandle("identifiersOperator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRecipients_Senders_SearchTerms_Attributes_DateTimeRange_Identifiers_NotificationIdentifiers_GroupNames_ = "initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:groupNames:";

	private static readonly IntPtr selInitWithRecipients_Senders_SearchTerms_Attributes_DateTimeRange_Identifiers_NotificationIdentifiers_GroupNames_Handle = Selector.GetHandle("initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:groupNames:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRecipients_Senders_SearchTerms_Attributes_DateTimeRange_Identifiers_NotificationIdentifiers_SpeakableGroupNames_ = "initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:";

	private static readonly IntPtr selInitWithRecipients_Senders_SearchTerms_Attributes_DateTimeRange_Identifiers_NotificationIdentifiers_SpeakableGroupNames_Handle = Selector.GetHandle("initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRecipients_Senders_SearchTerms_Attributes_DateTimeRange_Identifiers_NotificationIdentifiers_SpeakableGroupNames_ConversationIdentifiers_ = "initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:conversationIdentifiers:";

	private static readonly IntPtr selInitWithRecipients_Senders_SearchTerms_Attributes_DateTimeRange_Identifiers_NotificationIdentifiers_SpeakableGroupNames_ConversationIdentifiers_Handle = Selector.GetHandle("initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:conversationIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotificationIdentifiers = "notificationIdentifiers";

	private static readonly IntPtr selNotificationIdentifiersHandle = Selector.GetHandle("notificationIdentifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotificationIdentifiersOperator = "notificationIdentifiersOperator";

	private static readonly IntPtr selNotificationIdentifiersOperatorHandle = Selector.GetHandle("notificationIdentifiersOperator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecipients = "recipients";

	private static readonly IntPtr selRecipientsHandle = Selector.GetHandle("recipients");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecipientsOperator = "recipientsOperator";

	private static readonly IntPtr selRecipientsOperatorHandle = Selector.GetHandle("recipientsOperator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchTerms = "searchTerms";

	private static readonly IntPtr selSearchTermsHandle = Selector.GetHandle("searchTerms");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSearchTermsOperator = "searchTermsOperator";

	private static readonly IntPtr selSearchTermsOperatorHandle = Selector.GetHandle("searchTermsOperator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSenders = "senders";

	private static readonly IntPtr selSendersHandle = Selector.GetHandle("senders");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendersOperator = "sendersOperator";

	private static readonly IntPtr selSendersOperatorHandle = Selector.GetHandle("sendersOperator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeakableGroupNames = "speakableGroupNames";

	private static readonly IntPtr selSpeakableGroupNamesHandle = Selector.GetHandle("speakableGroupNames");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeakableGroupNamesOperator = "speakableGroupNamesOperator";

	private static readonly IntPtr selSpeakableGroupNamesOperatorHandle = Selector.GetHandle("speakableGroupNamesOperator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INSearchForMessagesIntent");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INMessageAttributeOptions Attributes
	{
		[Export("attributes", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INMessageAttributeOptions)Messaging.UInt64_objc_msgSend(base.Handle, selAttributesHandle);
			}
			return (INMessageAttributeOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selAttributesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual string[]? ConversationIdentifiers
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("conversationIdentifiers", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selConversationIdentifiersHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConversationIdentifiersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual INConditionalOperator ConversationIdentifiersOperator
	{
		[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("conversationIdentifiersOperator", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INConditionalOperator)Messaging.Int64_objc_msgSend(base.Handle, selConversationIdentifiersOperatorHandle);
			}
			return (INConditionalOperator)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selConversationIdentifiersOperatorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INDateComponentsRange? DateTimeRange
	{
		[Export("dateTimeRange", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<INDateComponentsRange>(Messaging.IntPtr_objc_msgSend(base.Handle, selDateTimeRangeHandle));
			}
			return Runtime.GetNSObject<INDateComponentsRange>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateTimeRangeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SpeakableGroupNames' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SpeakableGroupNames' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SpeakableGroupNames' instead.")]
	public virtual string[]? GroupNames
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SpeakableGroupNames' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SpeakableGroupNames' instead.")]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SpeakableGroupNames' instead.")]
		[Export("groupNames", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGroupNamesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGroupNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SpeakableGroupNamesOperator' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SpeakableGroupNamesOperator' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SpeakableGroupNamesOperator' instead.")]
	public virtual INConditionalOperator GroupNamesOperator
	{
		[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'SpeakableGroupNamesOperator' instead.")]
		[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use 'SpeakableGroupNamesOperator' instead.")]
		[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'SpeakableGroupNamesOperator' instead.")]
		[Export("groupNamesOperator", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INConditionalOperator)Messaging.Int64_objc_msgSend(base.Handle, selGroupNamesOperatorHandle);
			}
			return (INConditionalOperator)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selGroupNamesOperatorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? Identifiers
	{
		[Export("identifiers", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifiersHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifiersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INConditionalOperator IdentifiersOperator
	{
		[Export("identifiersOperator", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INConditionalOperator)Messaging.Int64_objc_msgSend(base.Handle, selIdentifiersOperatorHandle);
			}
			return (INConditionalOperator)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selIdentifiersOperatorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? NotificationIdentifiers
	{
		[Export("notificationIdentifiers", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNotificationIdentifiersHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNotificationIdentifiersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INConditionalOperator NotificationIdentifiersOperator
	{
		[Export("notificationIdentifiersOperator", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INConditionalOperator)Messaging.Int64_objc_msgSend(base.Handle, selNotificationIdentifiersOperatorHandle);
			}
			return (INConditionalOperator)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNotificationIdentifiersOperatorHandle);
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
	public virtual INConditionalOperator RecipientsOperator
	{
		[Export("recipientsOperator", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INConditionalOperator)Messaging.Int64_objc_msgSend(base.Handle, selRecipientsOperatorHandle);
			}
			return (INConditionalOperator)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRecipientsOperatorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[]? SearchTerms
	{
		[Export("searchTerms", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSearchTermsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSearchTermsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INConditionalOperator SearchTermsOperator
	{
		[Export("searchTermsOperator", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INConditionalOperator)Messaging.Int64_objc_msgSend(base.Handle, selSearchTermsOperatorHandle);
			}
			return (INConditionalOperator)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSearchTermsOperatorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INPerson[]? Senders
	{
		[Export("senders", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<INPerson>(Messaging.IntPtr_objc_msgSend(base.Handle, selSendersHandle));
			}
			return NSArray.ArrayFromHandle<INPerson>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSendersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INConditionalOperator SendersOperator
	{
		[Export("sendersOperator", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INConditionalOperator)Messaging.Int64_objc_msgSend(base.Handle, selSendersOperatorHandle);
			}
			return (INConditionalOperator)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSendersOperatorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual INSpeakableString[]? SpeakableGroupNames
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("speakableGroupNames", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<INSpeakableString>(Messaging.IntPtr_objc_msgSend(base.Handle, selSpeakableGroupNamesHandle));
			}
			return NSArray.ArrayFromHandle<INSpeakableString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSpeakableGroupNamesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual INConditionalOperator SpeakableGroupNamesOperator
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("speakableGroupNamesOperator", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INConditionalOperator)Messaging.Int64_objc_msgSend(base.Handle, selSpeakableGroupNamesOperatorHandle);
			}
			return (INConditionalOperator)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selSpeakableGroupNamesOperatorHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public INSearchForMessagesIntent()
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
	public INSearchForMessagesIntent(NSCoder coder)
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
	protected INSearchForMessagesIntent(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INSearchForMessagesIntent(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use the overload that takes 'conversationIdentifiers' instead.")]
	[Deprecated(PlatformName.WatchOS, 5, 0, PlatformArchitecture.None, "Use the overload that takes 'conversationIdentifiers' instead.")]
	[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use the overload that takes 'conversationIdentifiers' instead.")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSearchForMessagesIntent(INPerson[]? recipients, INPerson[]? senders, string[]? searchTerms, INMessageAttributeOptions attributes, INDateComponentsRange? dateTimeRange, string[]? identifiers, string[]? notificationIdentifiers, INSpeakableString[]? speakableGroupNames)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((recipients == null) ? null : NSArray.FromNSObjects(recipients));
		NSArray nSArray2 = ((senders == null) ? null : NSArray.FromNSObjects(senders));
		NSArray nSArray3 = ((searchTerms == null) ? null : NSArray.FromStrings(searchTerms));
		NSArray nSArray4 = ((identifiers == null) ? null : NSArray.FromStrings(identifiers));
		NSArray nSArray5 = ((notificationIdentifiers == null) ? null : NSArray.FromStrings(notificationIdentifiers));
		NSArray nSArray6 = ((speakableGroupNames == null) ? null : NSArray.FromNSObjects(speakableGroupNames));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithRecipients_Senders_SearchTerms_Attributes_DateTimeRange_Identifiers_NotificationIdentifiers_SpeakableGroupNames_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, nSArray3?.Handle ?? IntPtr.Zero, (ulong)attributes, dateTimeRange?.Handle ?? IntPtr.Zero, nSArray4?.Handle ?? IntPtr.Zero, nSArray5?.Handle ?? IntPtr.Zero, nSArray6?.Handle ?? IntPtr.Zero), "initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithRecipients_Senders_SearchTerms_Attributes_DateTimeRange_Identifiers_NotificationIdentifiers_SpeakableGroupNames_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, nSArray3?.Handle ?? IntPtr.Zero, (ulong)attributes, dateTimeRange?.Handle ?? IntPtr.Zero, nSArray4?.Handle ?? IntPtr.Zero, nSArray5?.Handle ?? IntPtr.Zero, nSArray6?.Handle ?? IntPtr.Zero), "initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:");
		}
		nSArray?.Dispose();
		nSArray2?.Dispose();
		nSArray3?.Dispose();
		nSArray4?.Dispose();
		nSArray5?.Dispose();
		nSArray6?.Dispose();
	}

	[Export("initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:conversationIdentifiers:")]
	[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSearchForMessagesIntent(INPerson[]? recipients, INPerson[]? senders, string[]? searchTerms, INMessageAttributeOptions attributes, INDateComponentsRange? dateTimeRange, string[]? identifiers, string[]? notificationIdentifiers, INSpeakableString[]? speakableGroupNames, string[]? conversationIdentifiers)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((recipients == null) ? null : NSArray.FromNSObjects(recipients));
		NSArray nSArray2 = ((senders == null) ? null : NSArray.FromNSObjects(senders));
		NSArray nSArray3 = ((searchTerms == null) ? null : NSArray.FromStrings(searchTerms));
		NSArray nSArray4 = ((identifiers == null) ? null : NSArray.FromStrings(identifiers));
		NSArray nSArray5 = ((notificationIdentifiers == null) ? null : NSArray.FromStrings(notificationIdentifiers));
		NSArray nSArray6 = ((speakableGroupNames == null) ? null : NSArray.FromNSObjects(speakableGroupNames));
		NSArray nSArray7 = ((conversationIdentifiers == null) ? null : NSArray.FromStrings(conversationIdentifiers));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithRecipients_Senders_SearchTerms_Attributes_DateTimeRange_Identifiers_NotificationIdentifiers_SpeakableGroupNames_ConversationIdentifiers_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, nSArray3?.Handle ?? IntPtr.Zero, (ulong)attributes, dateTimeRange?.Handle ?? IntPtr.Zero, nSArray4?.Handle ?? IntPtr.Zero, nSArray5?.Handle ?? IntPtr.Zero, nSArray6?.Handle ?? IntPtr.Zero, nSArray7?.Handle ?? IntPtr.Zero), "initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:conversationIdentifiers:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithRecipients_Senders_SearchTerms_Attributes_DateTimeRange_Identifiers_NotificationIdentifiers_SpeakableGroupNames_ConversationIdentifiers_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, nSArray3?.Handle ?? IntPtr.Zero, (ulong)attributes, dateTimeRange?.Handle ?? IntPtr.Zero, nSArray4?.Handle ?? IntPtr.Zero, nSArray5?.Handle ?? IntPtr.Zero, nSArray6?.Handle ?? IntPtr.Zero, nSArray7?.Handle ?? IntPtr.Zero), "initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:speakableGroupNames:conversationIdentifiers:");
		}
		nSArray?.Dispose();
		nSArray2?.Dispose();
		nSArray3?.Dispose();
		nSArray4?.Dispose();
		nSArray5?.Dispose();
		nSArray6?.Dispose();
		nSArray7?.Dispose();
	}

	[Export("initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:groupNames:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use '.ctor (INPerson [], INPerson [], string [], INMessageAttributeOptions, INDateComponentsRange, string [], string [], INSpeakableString [])' instead.")]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, "Use '.ctor (INPerson [], INPerson [], string [], INMessageAttributeOptions, INDateComponentsRange, string [], string [], INSpeakableString [])' instead.")]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use '.ctor (INPerson [], INPerson [], string [], INMessageAttributeOptions, INDateComponentsRange, string [], string [], INSpeakableString [])' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSearchForMessagesIntent(INPerson[]? recipients, INPerson[]? senders, string[]? searchTerms, INMessageAttributeOptions attributes, INDateComponentsRange? dateTimeRange, string[]? identifiers, string[]? notificationIdentifiers, string[]? groupNames)
		: base(NSObjectFlag.Empty)
	{
		NSArray nSArray = ((recipients == null) ? null : NSArray.FromNSObjects(recipients));
		NSArray nSArray2 = ((senders == null) ? null : NSArray.FromNSObjects(senders));
		NSArray nSArray3 = ((searchTerms == null) ? null : NSArray.FromStrings(searchTerms));
		NSArray nSArray4 = ((identifiers == null) ? null : NSArray.FromStrings(identifiers));
		NSArray nSArray5 = ((notificationIdentifiers == null) ? null : NSArray.FromStrings(notificationIdentifiers));
		NSArray nSArray6 = ((groupNames == null) ? null : NSArray.FromStrings(groupNames));
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithRecipients_Senders_SearchTerms_Attributes_DateTimeRange_Identifiers_NotificationIdentifiers_GroupNames_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, nSArray3?.Handle ?? IntPtr.Zero, (ulong)attributes, dateTimeRange?.Handle ?? IntPtr.Zero, nSArray4?.Handle ?? IntPtr.Zero, nSArray5?.Handle ?? IntPtr.Zero, nSArray6?.Handle ?? IntPtr.Zero), "initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:groupNames:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithRecipients_Senders_SearchTerms_Attributes_DateTimeRange_Identifiers_NotificationIdentifiers_GroupNames_Handle, nSArray?.Handle ?? IntPtr.Zero, nSArray2?.Handle ?? IntPtr.Zero, nSArray3?.Handle ?? IntPtr.Zero, (ulong)attributes, dateTimeRange?.Handle ?? IntPtr.Zero, nSArray4?.Handle ?? IntPtr.Zero, nSArray5?.Handle ?? IntPtr.Zero, nSArray6?.Handle ?? IntPtr.Zero), "initWithRecipients:senders:searchTerms:attributes:dateTimeRange:identifiers:notificationIdentifiers:groupNames:");
		}
		nSArray?.Dispose();
		nSArray2?.Dispose();
		nSArray3?.Dispose();
		nSArray4?.Dispose();
		nSArray5?.Dispose();
		nSArray6?.Dispose();
	}
}
