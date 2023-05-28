using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INInteraction", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INInteraction : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDateInterval = "dateInterval";

	private static readonly IntPtr selDateIntervalHandle = Selector.GetHandle("dateInterval");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteAllInteractionsWithCompletion_ = "deleteAllInteractionsWithCompletion:";

	private static readonly IntPtr selDeleteAllInteractionsWithCompletion_Handle = Selector.GetHandle("deleteAllInteractionsWithCompletion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteInteractionsWithGroupIdentifier_Completion_ = "deleteInteractionsWithGroupIdentifier:completion:";

	private static readonly IntPtr selDeleteInteractionsWithGroupIdentifier_Completion_Handle = Selector.GetHandle("deleteInteractionsWithGroupIdentifier:completion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteInteractionsWithIdentifiers_Completion_ = "deleteInteractionsWithIdentifiers:completion:";

	private static readonly IntPtr selDeleteInteractionsWithIdentifiers_Completion_Handle = Selector.GetHandle("deleteInteractionsWithIdentifiers:completion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDirection = "direction";

	private static readonly IntPtr selDirectionHandle = Selector.GetHandle("direction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDonateInteractionWithCompletion_ = "donateInteractionWithCompletion:";

	private static readonly IntPtr selDonateInteractionWithCompletion_Handle = Selector.GetHandle("donateInteractionWithCompletion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGroupIdentifier = "groupIdentifier";

	private static readonly IntPtr selGroupIdentifierHandle = Selector.GetHandle("groupIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIntent_Response_ = "initWithIntent:response:";

	private static readonly IntPtr selInitWithIntent_Response_Handle = Selector.GetHandle("initWithIntent:response:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntent = "intent";

	private static readonly IntPtr selIntentHandle = Selector.GetHandle("intent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntentHandlingStatus = "intentHandlingStatus";

	private static readonly IntPtr selIntentHandlingStatusHandle = Selector.GetHandle("intentHandlingStatus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntentResponse = "intentResponse";

	private static readonly IntPtr selIntentResponseHandle = Selector.GetHandle("intentResponse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDateInterval_ = "setDateInterval:";

	private static readonly IntPtr selSetDateInterval_Handle = Selector.GetHandle("setDateInterval:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDirection_ = "setDirection:";

	private static readonly IntPtr selSetDirection_Handle = Selector.GetHandle("setDirection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGroupIdentifier_ = "setGroupIdentifier:";

	private static readonly IntPtr selSetGroupIdentifier_Handle = Selector.GetHandle("setGroupIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIdentifier_ = "setIdentifier:";

	private static readonly IntPtr selSetIdentifier_Handle = Selector.GetHandle("setIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INInteraction");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDateInterval? DateInterval
	{
		[Export("dateInterval", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDateInterval>(Messaging.IntPtr_objc_msgSend(base.Handle, selDateIntervalHandle));
			}
			return Runtime.GetNSObject<NSDateInterval>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateIntervalHandle));
		}
		[Export("setDateInterval:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDateInterval_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDateInterval_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INInteractionDirection Direction
	{
		[Export("direction", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INInteractionDirection)Messaging.Int64_objc_msgSend(base.Handle, selDirectionHandle);
			}
			return (INInteractionDirection)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selDirectionHandle);
		}
		[Export("setDirection:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetDirection_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetDirection_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? GroupIdentifier
	{
		[Export("groupIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selGroupIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGroupIdentifierHandle));
		}
		[Export("setGroupIdentifier:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGroupIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGroupIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
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
		[Export("setIdentifier:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INIntent Intent
	{
		[Export("intent", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<INIntent>(Messaging.IntPtr_objc_msgSend(base.Handle, selIntentHandle));
			}
			return Runtime.GetNSObject<INIntent>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIntentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INIntentHandlingStatus IntentHandlingStatus
	{
		[Export("intentHandlingStatus")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (INIntentHandlingStatus)Messaging.Int64_objc_msgSend(base.Handle, selIntentHandlingStatusHandle);
			}
			return (INIntentHandlingStatus)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selIntentHandlingStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual INIntentResponse? IntentResponse
	{
		[Export("intentResponse", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<INIntentResponse>(Messaging.IntPtr_objc_msgSend(base.Handle, selIntentResponseHandle));
			}
			return Runtime.GetNSObject<INIntentResponse>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIntentResponseHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public INInteraction(NSCoder coder)
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
	protected INInteraction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INInteraction(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIntent:response:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INInteraction(INIntent intent, INIntentResponse? response)
		: base(NSObjectFlag.Empty)
	{
		if (intent == null)
		{
			throw new ArgumentNullException("intent");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithIntent_Response_Handle, intent.Handle, response?.Handle ?? IntPtr.Zero), "initWithIntent:response:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithIntent_Response_Handle, intent.Handle, response?.Handle ?? IntPtr.Zero), "initWithIntent:response:");
		}
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

	[Export("deleteAllInteractionsWithCompletion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void DeleteAllInteractions([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completion)
	{
		BlockLiteral* ptr;
		if (completion == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completion);
		}
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selDeleteAllInteractionsWithCompletion_Handle, (IntPtr)ptr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task DeleteAllInteractionsAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		DeleteAllInteractions(delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}

	[Export("deleteInteractionsWithGroupIdentifier:completion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void DeleteGroupedInteractions(string groupIdentifier, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completion)
	{
		if (groupIdentifier == null)
		{
			throw new ArgumentNullException("groupIdentifier");
		}
		IntPtr arg = NSString.CreateNative(groupIdentifier);
		BlockLiteral* ptr;
		if (completion == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completion);
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selDeleteInteractionsWithGroupIdentifier_Completion_Handle, arg, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task DeleteGroupedInteractionsAsync(string groupIdentifier)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		DeleteGroupedInteractions(groupIdentifier, delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}

	[Export("deleteInteractionsWithIdentifiers:completion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void DeleteInteractions(string[] identifiers, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completion)
	{
		if (identifiers == null)
		{
			throw new ArgumentNullException("identifiers");
		}
		NSArray nSArray = NSArray.FromStrings(identifiers);
		BlockLiteral* ptr;
		if (completion == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completion);
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selDeleteInteractionsWithIdentifiers_Completion_Handle, nSArray.Handle, (IntPtr)ptr);
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task DeleteInteractionsAsync(string[] identifiers)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		DeleteInteractions(identifiers, delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}

	[Export("donateInteractionWithCompletion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void DonateInteraction([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completion)
	{
		BlockLiteral* ptr;
		if (completion == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completion);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDonateInteractionWithCompletion_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDonateInteractionWithCompletion_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task DonateInteractionAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		DonateInteraction(delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
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
