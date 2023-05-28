using System.ComponentModel;
using System.Threading.Tasks;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSURLSessionWebSocketTask", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class NSUrlSessionWebSocketTask : NSUrlSessionTask
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelWithCloseCode_Reason_ = "cancelWithCloseCode:reason:";

	private static readonly IntPtr selCancelWithCloseCode_Reason_Handle = Selector.GetHandle("cancelWithCloseCode:reason:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCloseCode = "closeCode";

	private static readonly IntPtr selCloseCodeHandle = Selector.GetHandle("closeCode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCloseReason = "closeReason";

	private static readonly IntPtr selCloseReasonHandle = Selector.GetHandle("closeReason");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumMessageSize = "maximumMessageSize";

	private static readonly IntPtr selMaximumMessageSizeHandle = Selector.GetHandle("maximumMessageSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReceiveMessageWithCompletionHandler_ = "receiveMessageWithCompletionHandler:";

	private static readonly IntPtr selReceiveMessageWithCompletionHandler_Handle = Selector.GetHandle("receiveMessageWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendMessage_CompletionHandler_ = "sendMessage:completionHandler:";

	private static readonly IntPtr selSendMessage_CompletionHandler_Handle = Selector.GetHandle("sendMessage:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSendPingWithPongReceiveHandler_ = "sendPingWithPongReceiveHandler:";

	private static readonly IntPtr selSendPingWithPongReceiveHandler_Handle = Selector.GetHandle("sendPingWithPongReceiveHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMaximumMessageSize_ = "setMaximumMessageSize:";

	private static readonly IntPtr selSetMaximumMessageSize_Handle = Selector.GetHandle("setMaximumMessageSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSURLSessionWebSocketTask");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlSessionWebSocketCloseCode CloseCode
	{
		[Export("closeCode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSUrlSessionWebSocketCloseCode)Messaging.Int64_objc_msgSend(base.Handle, selCloseCodeHandle);
			}
			return (NSUrlSessionWebSocketCloseCode)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selCloseCodeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? CloseReason
	{
		[Export("closeReason", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selCloseReasonHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCloseReasonHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MaximumMessageSize
	{
		[Export("maximumMessageSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaximumMessageSizeHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaximumMessageSizeHandle);
		}
		[Export("setMaximumMessageSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetMaximumMessageSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetMaximumMessageSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlSessionWebSocketTask(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlSessionWebSocketTask(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancelWithCloseCode:reason:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cancel(NSUrlSessionWebSocketCloseCode closeCode, NSData? reason)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr(base.Handle, selCancelWithCloseCode_Reason_Handle, (long)closeCode, reason?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr(base.SuperHandle, selCancelWithCloseCode_Reason_Handle, (long)closeCode, reason?.Handle ?? IntPtr.Zero);
		}
	}

	[Export("receiveMessageWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ReceiveMessage([BlockProxy(typeof(Trampolines.NIDActionArity2V46))] Action<NSUrlSessionWebSocketMessage, NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V46.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReceiveMessageWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReceiveMessageWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlSessionWebSocketMessage> ReceiveMessageAsync()
	{
		TaskCompletionSource<NSUrlSessionWebSocketMessage> tcs = new TaskCompletionSource<NSUrlSessionWebSocketMessage>();
		ReceiveMessage(delegate(NSUrlSessionWebSocketMessage arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("sendMessage:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SendMessage(NSUrlSessionWebSocketMessage message, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSendMessage_CompletionHandler_Handle, message.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSendMessage_CompletionHandler_Handle, message.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SendMessageAsync(NSUrlSessionWebSocketMessage message)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SendMessage(message, delegate(NSError obj_)
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

	[Export("sendPingWithPongReceiveHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SendPing([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> pongReceiveHandler)
	{
		if (pongReceiveHandler == null)
		{
			throw new ArgumentNullException("pongReceiveHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, pongReceiveHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSendPingWithPongReceiveHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSendPingWithPongReceiveHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SendPingAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SendPing(delegate(NSError obj_)
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
