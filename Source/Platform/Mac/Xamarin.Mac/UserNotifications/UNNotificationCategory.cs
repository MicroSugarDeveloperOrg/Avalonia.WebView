using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace UserNotifications;

[Register("UNNotificationCategory", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class UNNotificationCategory : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActions = "actions";

	private static readonly IntPtr selActionsHandle = Selector.GetHandle("actions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCategorySummaryFormat = "categorySummaryFormat";

	private static readonly IntPtr selCategorySummaryFormatHandle = Selector.GetHandle("categorySummaryFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCategoryWithIdentifier_Actions_IntentIdentifiers_HiddenPreviewsBodyPlaceholder_CategorySummaryFormat_Options_ = "categoryWithIdentifier:actions:intentIdentifiers:hiddenPreviewsBodyPlaceholder:categorySummaryFormat:options:";

	private static readonly IntPtr selCategoryWithIdentifier_Actions_IntentIdentifiers_HiddenPreviewsBodyPlaceholder_CategorySummaryFormat_Options_Handle = Selector.GetHandle("categoryWithIdentifier:actions:intentIdentifiers:hiddenPreviewsBodyPlaceholder:categorySummaryFormat:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCategoryWithIdentifier_Actions_IntentIdentifiers_HiddenPreviewsBodyPlaceholder_Options_ = "categoryWithIdentifier:actions:intentIdentifiers:hiddenPreviewsBodyPlaceholder:options:";

	private static readonly IntPtr selCategoryWithIdentifier_Actions_IntentIdentifiers_HiddenPreviewsBodyPlaceholder_Options_Handle = Selector.GetHandle("categoryWithIdentifier:actions:intentIdentifiers:hiddenPreviewsBodyPlaceholder:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCategoryWithIdentifier_Actions_IntentIdentifiers_Options_ = "categoryWithIdentifier:actions:intentIdentifiers:options:";

	private static readonly IntPtr selCategoryWithIdentifier_Actions_IntentIdentifiers_Options_Handle = Selector.GetHandle("categoryWithIdentifier:actions:intentIdentifiers:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHiddenPreviewsBodyPlaceholder = "hiddenPreviewsBodyPlaceholder";

	private static readonly IntPtr selHiddenPreviewsBodyPlaceholderHandle = Selector.GetHandle("hiddenPreviewsBodyPlaceholder");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntentIdentifiers = "intentIdentifiers";

	private static readonly IntPtr selIntentIdentifiersHandle = Selector.GetHandle("intentIdentifiers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptions = "options";

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("UNNotificationCategory");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual UNNotificationAction[] Actions
	{
		[Export("actions", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<UNNotificationAction>(Messaging.IntPtr_objc_msgSend(base.Handle, selActionsHandle));
			}
			return NSArray.ArrayFromHandle<UNNotificationAction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActionsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	public virtual string CategorySummaryFormat
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Export("categorySummaryFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCategorySummaryFormatHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCategorySummaryFormatHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual string HiddenPreviewsBodyPlaceholder
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("hiddenPreviewsBodyPlaceholder")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selHiddenPreviewsBodyPlaceholderHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHiddenPreviewsBodyPlaceholderHandle));
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
	public virtual string[] IntentIdentifiers
	{
		[Export("intentIdentifiers", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIntentIdentifiersHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIntentIdentifiersHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual UNNotificationCategoryOptions Options
	{
		[Export("options")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (UNNotificationCategoryOptions)Messaging.UInt64_objc_msgSend(base.Handle, selOptionsHandle);
			}
			return (UNNotificationCategoryOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOptionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public UNNotificationCategory(NSCoder coder)
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
	protected UNNotificationCategory(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal UNNotificationCategory(IntPtr handle)
		: base(handle)
	{
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

	[Export("categoryWithIdentifier:actions:intentIdentifiers:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static UNNotificationCategory FromIdentifier(string identifier, UNNotificationAction[] actions, string[] intentIdentifiers, UNNotificationCategoryOptions options)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (actions == null)
		{
			throw new ArgumentNullException("actions");
		}
		if (intentIdentifiers == null)
		{
			throw new ArgumentNullException("intentIdentifiers");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSArray nSArray = NSArray.FromNSObjects(actions);
		NSArray nSArray2 = NSArray.FromStrings(intentIdentifiers);
		UNNotificationCategory nSObject = Runtime.GetNSObject<UNNotificationCategory>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64(class_ptr, selCategoryWithIdentifier_Actions_IntentIdentifiers_Options_Handle, arg, nSArray.Handle, nSArray2.Handle, (ulong)options));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		nSArray2.Dispose();
		return nSObject;
	}

	[Export("categoryWithIdentifier:actions:intentIdentifiers:hiddenPreviewsBodyPlaceholder:options:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static UNNotificationCategory FromIdentifier(string identifier, UNNotificationAction[] actions, string[] intentIdentifiers, string hiddenPreviewsBodyPlaceholder, UNNotificationCategoryOptions options)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (actions == null)
		{
			throw new ArgumentNullException("actions");
		}
		if (intentIdentifiers == null)
		{
			throw new ArgumentNullException("intentIdentifiers");
		}
		if (hiddenPreviewsBodyPlaceholder == null)
		{
			throw new ArgumentNullException("hiddenPreviewsBodyPlaceholder");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSArray nSArray = NSArray.FromNSObjects(actions);
		NSArray nSArray2 = NSArray.FromStrings(intentIdentifiers);
		IntPtr arg2 = NSString.CreateNative(hiddenPreviewsBodyPlaceholder);
		UNNotificationCategory nSObject = Runtime.GetNSObject<UNNotificationCategory>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_UInt64(class_ptr, selCategoryWithIdentifier_Actions_IntentIdentifiers_HiddenPreviewsBodyPlaceholder_Options_Handle, arg, nSArray.Handle, nSArray2.Handle, arg2, (ulong)options));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		nSArray2.Dispose();
		NSString.ReleaseNative(arg2);
		return nSObject;
	}

	[Export("categoryWithIdentifier:actions:intentIdentifiers:hiddenPreviewsBodyPlaceholder:categorySummaryFormat:options:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static UNNotificationCategory FromIdentifier(string identifier, UNNotificationAction[] actions, string[] intentIdentifiers, string? hiddenPreviewsBodyPlaceholder, NSString? categorySummaryFormat, UNNotificationCategoryOptions options)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		if (actions == null)
		{
			throw new ArgumentNullException("actions");
		}
		if (intentIdentifiers == null)
		{
			throw new ArgumentNullException("intentIdentifiers");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		NSArray nSArray = NSArray.FromNSObjects(actions);
		NSArray nSArray2 = NSArray.FromStrings(intentIdentifiers);
		IntPtr arg2 = NSString.CreateNative(hiddenPreviewsBodyPlaceholder);
		UNNotificationCategory nSObject = Runtime.GetNSObject<UNNotificationCategory>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_UInt64(class_ptr, selCategoryWithIdentifier_Actions_IntentIdentifiers_HiddenPreviewsBodyPlaceholder_CategorySummaryFormat_Options_Handle, arg, nSArray.Handle, nSArray2.Handle, arg2, (categorySummaryFormat == null) ? IntPtr.Zero : categorySummaryFormat.Handle, (ulong)options));
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		nSArray2.Dispose();
		NSString.ReleaseNative(arg2);
		return nSObject;
	}
}
