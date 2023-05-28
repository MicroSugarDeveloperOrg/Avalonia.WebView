using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEAppProxyTCPFlow", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NEAppProxyTcpFlow : NEAppProxyFlow
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadDataWithCompletionHandler_ = "readDataWithCompletionHandler:";

	private static readonly IntPtr selReadDataWithCompletionHandler_Handle = Selector.GetHandle("readDataWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoteEndpoint = "remoteEndpoint";

	private static readonly IntPtr selRemoteEndpointHandle = Selector.GetHandle("remoteEndpoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteData_WithCompletionHandler_ = "writeData:withCompletionHandler:";

	private static readonly IntPtr selWriteData_WithCompletionHandler_Handle = Selector.GetHandle("writeData:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEAppProxyTCPFlow");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWEndpoint RemoteEndpoint
	{
		[Export("remoteEndpoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NWEndpoint>(Messaging.IntPtr_objc_msgSend(base.Handle, selRemoteEndpointHandle));
			}
			return Runtime.GetNSObject<NWEndpoint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRemoteEndpointHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NEAppProxyTcpFlow(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEAppProxyTcpFlow(IntPtr handle)
		: base(handle)
	{
	}

	[Export("readDataWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ReadData([BlockProxy(typeof(Trampolines.NIDActionArity2V3))] Action<NSData, NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V3.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReadDataWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReadDataWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSData> ReadDataAsync()
	{
		TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
		ReadData(delegate(NSData arg1_, NSError arg2_)
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

	[Export("writeData:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void WriteData(NSData data, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
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
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteData_WithCompletionHandler_Handle, data.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteData_WithCompletionHandler_Handle, data.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task WriteDataAsync(NSData data)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		WriteData(data, delegate(NSError obj_)
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
