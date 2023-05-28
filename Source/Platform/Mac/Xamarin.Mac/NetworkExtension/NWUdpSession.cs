using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace NetworkExtension;

[Register("NWUDPSession", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NWUdpSession : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentPath = "currentPath";

	private static readonly IntPtr selCurrentPathHandle = Selector.GetHandle("currentPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndpoint = "endpoint";

	private static readonly IntPtr selEndpointHandle = Selector.GetHandle("endpoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasBetterPath = "hasBetterPath";

	private static readonly IntPtr selHasBetterPathHandle = Selector.GetHandle("hasBetterPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithUpgradeForSession_ = "initWithUpgradeForSession:";

	private static readonly IntPtr selInitWithUpgradeForSession_Handle = Selector.GetHandle("initWithUpgradeForSession:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsViable = "isViable";

	private static readonly IntPtr selIsViableHandle = Selector.GetHandle("isViable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumDatagramLength = "maximumDatagramLength";

	private static readonly IntPtr selMaximumDatagramLengthHandle = Selector.GetHandle("maximumDatagramLength");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResolvedEndpoint = "resolvedEndpoint";

	private static readonly IntPtr selResolvedEndpointHandle = Selector.GetHandle("resolvedEndpoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetReadHandler_MaxDatagrams_ = "setReadHandler:maxDatagrams:";

	private static readonly IntPtr selSetReadHandler_MaxDatagrams_Handle = Selector.GetHandle("setReadHandler:maxDatagrams:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selState = "state";

	private static readonly IntPtr selStateHandle = Selector.GetHandle("state");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTryNextResolvedEndpoint = "tryNextResolvedEndpoint";

	private static readonly IntPtr selTryNextResolvedEndpointHandle = Selector.GetHandle("tryNextResolvedEndpoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteDatagram_CompletionHandler_ = "writeDatagram:completionHandler:";

	private static readonly IntPtr selWriteDatagram_CompletionHandler_Handle = Selector.GetHandle("writeDatagram:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteMultipleDatagrams_CompletionHandler_ = "writeMultipleDatagrams:completionHandler:";

	private static readonly IntPtr selWriteMultipleDatagrams_CompletionHandler_Handle = Selector.GetHandle("writeMultipleDatagrams:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NWUDPSession");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWPath? CurrentPath
	{
		[Export("currentPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NWPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selCurrentPathHandle));
			}
			return Runtime.GetNSObject<NWPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCurrentPathHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWEndpoint Endpoint
	{
		[Export("endpoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NWEndpoint>(Messaging.IntPtr_objc_msgSend(base.Handle, selEndpointHandle));
			}
			return Runtime.GetNSObject<NWEndpoint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEndpointHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasBetterPath
	{
		[Export("hasBetterPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasBetterPathHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasBetterPathHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint MaximumDatagramLength
	{
		[Export("maximumDatagramLength")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selMaximumDatagramLengthHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selMaximumDatagramLengthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWEndpoint? ResolvedEndpoint
	{
		[Export("resolvedEndpoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NWEndpoint>(Messaging.IntPtr_objc_msgSend(base.Handle, selResolvedEndpointHandle));
			}
			return Runtime.GetNSObject<NWEndpoint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selResolvedEndpointHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWUdpSessionState State
	{
		[Export("state")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NWUdpSessionState)Messaging.Int64_objc_msgSend(base.Handle, selStateHandle);
			}
			return (NWUdpSessionState)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Viable
	{
		[Export("isViable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsViableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsViableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NWUdpSession()
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
	protected NWUdpSession(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NWUdpSession(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithUpgradeForSession:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NWUdpSession(NWUdpSession session)
		: base(NSObjectFlag.Empty)
	{
		if (session == null)
		{
			throw new ArgumentNullException("session");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithUpgradeForSession_Handle, session.Handle), "initWithUpgradeForSession:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithUpgradeForSession_Handle, session.Handle), "initWithUpgradeForSession:");
		}
	}

	[Export("cancel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cancel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[Export("setReadHandler:maxDatagrams:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SetReadHandler([BlockProxy(typeof(Trampolines.NIDActionArity2V73))] Action<NSArray, NSError> handler, nuint maxDatagrams)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V73.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nuint(base.Handle, selSetReadHandler_MaxDatagrams_Handle, (IntPtr)ptr, maxDatagrams);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selSetReadHandler_MaxDatagrams_Handle, (IntPtr)ptr, maxDatagrams);
		}
		ptr->CleanupBlock();
	}

	[Export("tryNextResolvedEndpoint")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void TryNextResolvedEndpoint()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selTryNextResolvedEndpointHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selTryNextResolvedEndpointHandle);
		}
	}

	[Export("writeDatagram:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void WriteDatagram(NSData datagram, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (datagram == null)
		{
			throw new ArgumentNullException("datagram");
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteDatagram_CompletionHandler_Handle, datagram.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteDatagram_CompletionHandler_Handle, datagram.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task WriteDatagramAsync(NSData datagram)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		WriteDatagram(datagram, delegate(NSError obj_)
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

	[Export("writeMultipleDatagrams:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void WriteMultipleDatagrams(NSData[] datagramArray, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (datagramArray == null)
		{
			throw new ArgumentNullException("datagramArray");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		NSArray nSArray = NSArray.FromNSObjects(datagramArray);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteMultipleDatagrams_CompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteMultipleDatagrams_CompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task WriteMultipleDatagramsAsync(NSData[] datagramArray)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		WriteMultipleDatagrams(datagramArray, delegate(NSError obj_)
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
