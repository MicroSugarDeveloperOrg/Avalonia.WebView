using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

[Register("MDLMeshBufferMap", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class MDLMeshBufferMap : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBytes = "bytes";

	private static readonly IntPtr selBytesHandle = Selector.GetHandle("bytes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithBytes_Deallocator_ = "initWithBytes:deallocator:";

	private static readonly IntPtr selInitWithBytes_Deallocator_Handle = Selector.GetHandle("initWithBytes:deallocator:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MDLMeshBufferMap");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr Bytes
	{
		[Export("bytes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selBytesHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBytesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public MDLMeshBufferMap()
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
	protected MDLMeshBufferMap(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MDLMeshBufferMap(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithBytes:deallocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe MDLMeshBufferMap(IntPtr bytes, [BlockProxy(typeof(Trampolines.NIDAction))] Action? deallocator)
		: base(NSObjectFlag.Empty)
	{
		BlockLiteral* ptr;
		if (deallocator == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, deallocator);
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithBytes_Deallocator_Handle, bytes, (IntPtr)ptr), "initWithBytes:deallocator:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithBytes_Deallocator_Handle, bytes, (IntPtr)ptr), "initWithBytes:deallocator:");
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}
}
