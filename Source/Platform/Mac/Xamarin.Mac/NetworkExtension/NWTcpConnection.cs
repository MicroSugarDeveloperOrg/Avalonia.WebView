using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace NetworkExtension;

[Register("NWTCPConnection", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NWTcpConnection : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnectedPath = "connectedPath";

	private static readonly IntPtr selConnectedPathHandle = Selector.GetHandle("connectedPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndpoint = "endpoint";

	private static readonly IntPtr selEndpointHandle = Selector.GetHandle("endpoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selError = "error";

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasBetterPath = "hasBetterPath";

	private static readonly IntPtr selHasBetterPathHandle = Selector.GetHandle("hasBetterPath");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithUpgradeForConnection_ = "initWithUpgradeForConnection:";

	private static readonly IntPtr selInitWithUpgradeForConnection_Handle = Selector.GetHandle("initWithUpgradeForConnection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsViable = "isViable";

	private static readonly IntPtr selIsViableHandle = Selector.GetHandle("isViable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalAddress = "localAddress";

	private static readonly IntPtr selLocalAddressHandle = Selector.GetHandle("localAddress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadLength_CompletionHandler_ = "readLength:completionHandler:";

	private static readonly IntPtr selReadLength_CompletionHandler_Handle = Selector.GetHandle("readLength:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadMinimumLength_MaximumLength_CompletionHandler_ = "readMinimumLength:maximumLength:completionHandler:";

	private static readonly IntPtr selReadMinimumLength_MaximumLength_CompletionHandler_Handle = Selector.GetHandle("readMinimumLength:maximumLength:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoteAddress = "remoteAddress";

	private static readonly IntPtr selRemoteAddressHandle = Selector.GetHandle("remoteAddress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selState = "state";

	private static readonly IntPtr selStateHandle = Selector.GetHandle("state");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTxtRecord = "txtRecord";

	private static readonly IntPtr selTxtRecordHandle = Selector.GetHandle("txtRecord");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWrite_CompletionHandler_ = "write:completionHandler:";

	private static readonly IntPtr selWrite_CompletionHandler_Handle = Selector.GetHandle("write:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteClose = "writeClose";

	private static readonly IntPtr selWriteCloseHandle = Selector.GetHandle("writeClose");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NWTCPConnection");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWPath? ConnectedPath
	{
		[Export("connectedPath")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NWPath>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectedPathHandle));
			}
			return Runtime.GetNSObject<NWPath>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectedPathHandle));
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
	public virtual NSError? Error
	{
		[Export("error")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle));
			}
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle));
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
	public virtual NWEndpoint? LocalAddress
	{
		[Export("localAddress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NWEndpoint>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalAddressHandle));
			}
			return Runtime.GetNSObject<NWEndpoint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalAddressHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWEndpoint? RemoteAddress
	{
		[Export("remoteAddress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NWEndpoint>(Messaging.IntPtr_objc_msgSend(base.Handle, selRemoteAddressHandle));
			}
			return Runtime.GetNSObject<NWEndpoint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRemoteAddressHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWTcpConnectionState State
	{
		[Export("state")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NWTcpConnectionState)Messaging.Int64_objc_msgSend(base.Handle, selStateHandle);
			}
			return (NWTcpConnectionState)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStateHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? TxtRecord
	{
		[Export("txtRecord")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selTxtRecordHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTxtRecordHandle));
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
	public NWTcpConnection()
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
	protected NWTcpConnection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NWTcpConnection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithUpgradeForConnection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NWTcpConnection(NWTcpConnection connection)
		: base(NSObjectFlag.Empty)
	{
		if (connection == null)
		{
			throw new ArgumentNullException("connection");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithUpgradeForConnection_Handle, connection.Handle), "initWithUpgradeForConnection:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithUpgradeForConnection_Handle, connection.Handle), "initWithUpgradeForConnection:");
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

	[Export("readLength:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ReadLength(nuint length, [BlockProxy(typeof(Trampolines.NIDActionArity2V3))] Action<NSData, NSError> completion)
	{
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V3.Handler, completion);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint_IntPtr(base.Handle, selReadLength_CompletionHandler_Handle, length, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint_IntPtr(base.SuperHandle, selReadLength_CompletionHandler_Handle, length, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> ReadLengthAsync(nuint length)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		ReadLength(length, delegate(NSData arg1_, NSError arg2_)
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

	[Export("readMinimumLength:maximumLength:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ReadMinimumLength(nuint minimum, nuint maximum, [BlockProxy(typeof(Trampolines.NIDActionArity2V3))] Action<NSData, NSError> completion)
	{
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V3.Handler, completion);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nuint_nuint_IntPtr(base.Handle, selReadMinimumLength_MaximumLength_CompletionHandler_Handle, minimum, maximum, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nuint_nuint_IntPtr(base.SuperHandle, selReadMinimumLength_MaximumLength_CompletionHandler_Handle, minimum, maximum, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> ReadMinimumLengthAsync(nuint minimum, nuint maximum)
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		ReadMinimumLength(minimum, maximum, delegate(NSData arg1_, NSError arg2_)
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

	[Export("write:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void Write(NSData data, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completion)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completion);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selWrite_CompletionHandler_Handle, data.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWrite_CompletionHandler_Handle, data.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task WriteAsync(NSData data)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Write(data, delegate(NSError obj_)
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

	[Export("writeClose")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WriteClose()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selWriteCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selWriteCloseHandle);
		}
	}
}
