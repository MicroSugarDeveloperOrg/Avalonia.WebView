using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKTurnBasedExchange", true)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public class GKTurnBasedExchange : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelWithLocalizableMessageKey_Arguments_CompletionHandler_ = "cancelWithLocalizableMessageKey:arguments:completionHandler:";

	private static readonly IntPtr selCancelWithLocalizableMessageKey_Arguments_CompletionHandler_Handle = Selector.GetHandle("cancelWithLocalizableMessageKey:arguments:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompletionDate = "completionDate";

	private static readonly IntPtr selCompletionDateHandle = Selector.GetHandle("completionDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExchangeID = "exchangeID";

	private static readonly IntPtr selExchangeIDHandle = Selector.GetHandle("exchangeID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMessage = "message";

	private static readonly IntPtr selMessageHandle = Selector.GetHandle("message");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecipients = "recipients";

	private static readonly IntPtr selRecipientsHandle = Selector.GetHandle("recipients");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplies = "replies";

	private static readonly IntPtr selRepliesHandle = Selector.GetHandle("replies");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplyWithLocalizableMessageKey_Arguments_Data_CompletionHandler_ = "replyWithLocalizableMessageKey:arguments:data:completionHandler:";

	private static readonly IntPtr selReplyWithLocalizableMessageKey_Arguments_Data_CompletionHandler_Handle = Selector.GetHandle("replyWithLocalizableMessageKey:arguments:data:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendDate = "sendDate";

	private static readonly IntPtr selSendDateHandle = Selector.GetHandle("sendDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSender = "sender";

	private static readonly IntPtr selSenderHandle = Selector.GetHandle("sender");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatus = "status";

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeoutDate = "timeoutDate";

	private static readonly IntPtr selTimeoutDateHandle = Selector.GetHandle("timeoutDate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKTurnBasedExchange");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate CompletionDate
	{
		[Export("completionDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selCompletionDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCompletionDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData Data
	{
		[Export("data")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ExchangeID
	{
		[Export("exchangeID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selExchangeIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExchangeIDHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Message
	{
		[Export("message")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMessageHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMessageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKTurnBasedParticipant[] Recipients
	{
		[Export("recipients")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKTurnBasedParticipant>(Messaging.IntPtr_objc_msgSend(base.Handle, selRecipientsHandle));
			}
			return NSArray.ArrayFromHandle<GKTurnBasedParticipant>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRecipientsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKTurnBasedExchangeReply[] Replies
	{
		[Export("replies")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<GKTurnBasedExchangeReply>(Messaging.IntPtr_objc_msgSend(base.Handle, selRepliesHandle));
			}
			return NSArray.ArrayFromHandle<GKTurnBasedExchangeReply>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRepliesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate SendDate
	{
		[Export("sendDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selSendDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSendDateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKTurnBasedParticipant Sender
	{
		[Export("sender")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<GKTurnBasedParticipant>(Messaging.IntPtr_objc_msgSend(base.Handle, selSenderHandle));
			}
			return Runtime.GetNSObject<GKTurnBasedParticipant>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSenderHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual GKTurnBasedExchangeStatus Status
	{
		[Export("status", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (GKTurnBasedExchangeStatus)Messaging.SByte_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (GKTurnBasedExchangeStatus)Messaging.SByte_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDate TimeoutDate
	{
		[Export("timeoutDate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSend(base.Handle, selTimeoutDateHandle));
			}
			return Runtime.GetNSObject<NSDate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTimeoutDateHandle));
		}
	}

	[Field("GKExchangeTimeoutDefault", "GameKit")]
	public static double TimeoutDefault => Dlfcn.GetDouble(Libraries.GameKit.Handle, "GKExchangeTimeoutDefault");

	[Field("GKExchangeTimeoutNone", "GameKit")]
	public static double TimeoutNone => Dlfcn.GetDouble(Libraries.GameKit.Handle, "GKExchangeTimeoutNone");

	public override string ToString()
	{
		return "GKTurnBasedExchange";
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKTurnBasedExchange()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected GKTurnBasedExchange(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKTurnBasedExchange(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancelWithLocalizableMessageKey:arguments:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Cancel(string localizableMessage, NSObject[] arguments, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (localizableMessage == null)
		{
			throw new ArgumentNullException("localizableMessage");
		}
		if (arguments == null)
		{
			throw new ArgumentNullException("arguments");
		}
		IntPtr arg = NSString.CreateNative(localizableMessage);
		NSArray nSArray = NSArray.FromNSObjects(arguments);
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCancelWithLocalizableMessageKey_Arguments_CompletionHandler_Handle, arg, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCancelWithLocalizableMessageKey_Arguments_CompletionHandler_Handle, arg, nSArray.Handle, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task CancelAsync(string localizableMessage, NSObject[] arguments)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Cancel(localizableMessage, arguments, delegate(NSError obj_)
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

	[Export("replyWithLocalizableMessageKey:arguments:data:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Reply(string localizableMessage, NSObject[] arguments, NSData data, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (localizableMessage == null)
		{
			throw new ArgumentNullException("localizableMessage");
		}
		if (arguments == null)
		{
			throw new ArgumentNullException("arguments");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(localizableMessage);
		NSArray nSArray = NSArray.FromNSObjects(arguments);
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selReplyWithLocalizableMessageKey_Arguments_Data_CompletionHandler_Handle, arg, nSArray.Handle, data.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selReplyWithLocalizableMessageKey_Arguments_Data_CompletionHandler_Handle, arg, nSArray.Handle, data.Handle, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task ReplyAsync(string localizableMessage, NSObject[] arguments, NSData data)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Reply(localizableMessage, arguments, data, delegate(NSError obj_)
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
}
