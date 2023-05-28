using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEPacketTunnelFlow", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NEPacketTunnelFlow : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadPacketObjectsWithCompletionHandler_ = "readPacketObjectsWithCompletionHandler:";

	private static readonly IntPtr selReadPacketObjectsWithCompletionHandler_Handle = Selector.GetHandle("readPacketObjectsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadPacketsWithCompletionHandler_ = "readPacketsWithCompletionHandler:";

	private static readonly IntPtr selReadPacketsWithCompletionHandler_Handle = Selector.GetHandle("readPacketsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritePacketObjects_ = "writePacketObjects:";

	private static readonly IntPtr selWritePacketObjects_Handle = Selector.GetHandle("writePacketObjects:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritePackets_WithProtocols_ = "writePackets:withProtocols:";

	private static readonly IntPtr selWritePackets_WithProtocols_Handle = Selector.GetHandle("writePackets:withProtocols:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEPacketTunnelFlow");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NEPacketTunnelFlow()
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
	protected NEPacketTunnelFlow(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEPacketTunnelFlow(IntPtr handle)
		: base(handle)
	{
	}

	[Export("readPacketObjectsWithCompletionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ReadPacketObjects([BlockProxy(typeof(Trampolines.NIDActionArity1V67))] Action<NEPacket[]> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V67.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReadPacketObjectsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReadPacketObjectsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NEPacket[]> ReadPacketObjectsAsync()
	{
		TaskCompletionSource<NEPacket[]> tcs = new TaskCompletionSource<NEPacket[]>();
		ReadPacketObjects(delegate(NEPacket[] obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("readPacketsWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ReadPackets([BlockProxy(typeof(Trampolines.NIDActionArity2V74))] Action<NSData[], NSNumber[]> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V74.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReadPacketsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReadPacketsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NEPacketTunnelFlowReadResult> ReadPacketsAsync()
	{
		TaskCompletionSource<NEPacketTunnelFlowReadResult> tcs = new TaskCompletionSource<NEPacketTunnelFlowReadResult>();
		ReadPackets(delegate(NSData[] arg1_, NSNumber[] arg2_)
		{
			tcs.SetResult(new NEPacketTunnelFlowReadResult(arg1_, arg2_));
		});
		return tcs.Task;
	}

	[Export("writePacketObjects:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WritePacketObjects(NEPacket[] packets)
	{
		if (packets == null)
		{
			throw new ArgumentNullException("packets");
		}
		NSArray nSArray = NSArray.FromNSObjects(packets);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selWritePacketObjects_Handle, nSArray.Handle) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selWritePacketObjects_Handle, nSArray.Handle));
		nSArray.Dispose();
		return result;
	}

	[Export("writePackets:withProtocols:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool WritePackets(NSData[] packets, NSNumber[] protocols)
	{
		if (packets == null)
		{
			throw new ArgumentNullException("packets");
		}
		if (protocols == null)
		{
			throw new ArgumentNullException("protocols");
		}
		NSArray nSArray = NSArray.FromNSObjects(packets);
		NSArray nSArray2 = NSArray.FromNSObjects(protocols);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWritePackets_WithProtocols_Handle, nSArray.Handle, nSArray2.Handle) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selWritePackets_WithProtocols_Handle, nSArray.Handle, nSArray2.Handle));
		nSArray.Dispose();
		nSArray2.Dispose();
		return result;
	}
}
