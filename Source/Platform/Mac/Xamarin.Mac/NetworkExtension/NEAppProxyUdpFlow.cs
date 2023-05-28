using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEAppProxyUDPFlow", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NEAppProxyUdpFlow : NEAppProxyFlow
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalEndpoint = "localEndpoint";

	private static readonly IntPtr selLocalEndpointHandle = Selector.GetHandle("localEndpoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadDatagramsWithCompletionHandler_ = "readDatagramsWithCompletionHandler:";

	private static readonly IntPtr selReadDatagramsWithCompletionHandler_Handle = Selector.GetHandle("readDatagramsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteDatagrams_SentByEndpoints_CompletionHandler_ = "writeDatagrams:sentByEndpoints:completionHandler:";

	private static readonly IntPtr selWriteDatagrams_SentByEndpoints_CompletionHandler_Handle = Selector.GetHandle("writeDatagrams:sentByEndpoints:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEAppProxyUDPFlow");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NWEndpoint? LocalEndpoint
	{
		[Export("localEndpoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NWEndpoint>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalEndpointHandle));
			}
			return Runtime.GetNSObject<NWEndpoint>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalEndpointHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NEAppProxyUdpFlow(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEAppProxyUdpFlow(IntPtr handle)
		: base(handle)
	{
	}

	[Export("readDatagramsWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ReadDatagrams([BlockProxy(typeof(Trampolines.NIDNEDatagramRead))] NEDatagramRead completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNEDatagramRead.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReadDatagramsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReadDatagramsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NEDatagramReadResult> ReadDatagramsAsync()
	{
		TaskCompletionSource<NEDatagramReadResult> tcs = new TaskCompletionSource<NEDatagramReadResult>();
		ReadDatagrams(delegate(NSData[] datagrams_, NWEndpoint[] remoteEndpoints_, NSError error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NEDatagramReadResult(datagrams_, remoteEndpoints_));
			}
		});
		return tcs.Task;
	}

	[Export("writeDatagrams:sentByEndpoints:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void WriteDatagrams(NSData[] datagrams, NWEndpoint[] remoteEndpoints, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (datagrams == null)
		{
			throw new ArgumentNullException("datagrams");
		}
		if (remoteEndpoints == null)
		{
			throw new ArgumentNullException("remoteEndpoints");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		NSArray nSArray = NSArray.FromNSObjects(datagrams);
		NSArray nSArray2 = NSArray.FromNSObjects(remoteEndpoints);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selWriteDatagrams_SentByEndpoints_CompletionHandler_Handle, nSArray.Handle, nSArray2.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selWriteDatagrams_SentByEndpoints_CompletionHandler_Handle, nSArray.Handle, nSArray2.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		nSArray2.Dispose();
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task WriteDatagramsAsync(NSData[] datagrams, NWEndpoint[] remoteEndpoints)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		WriteDatagrams(datagrams, remoteEndpoints, delegate(NSError obj_)
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
