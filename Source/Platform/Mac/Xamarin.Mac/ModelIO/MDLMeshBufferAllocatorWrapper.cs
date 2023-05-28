using System;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

internal sealed class MDLMeshBufferAllocatorWrapper : BaseWrapper, IMDLMeshBufferAllocator, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MDLMeshBufferAllocatorWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("newZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMDLMeshBufferZone CreateZone(nuint capacity)
	{
		return Runtime.GetINativeObject<IMDLMeshBufferZone>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, Selector.GetHandle("newZone:"), capacity), owns: false);
	}

	[Export("newZoneForBuffersWithSize:andType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMDLMeshBufferZone CreateZone(NSNumber[] sizes, NSNumber[] types)
	{
		if (sizes == null)
		{
			throw new ArgumentNullException("sizes");
		}
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		NSArray nSArray = NSArray.FromNSObjects(sizes);
		NSArray nSArray2 = NSArray.FromNSObjects(types);
		IMDLMeshBufferZone iNativeObject = Runtime.GetINativeObject<IMDLMeshBufferZone>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("newZoneForBuffersWithSize:andType:"), nSArray.Handle, nSArray2.Handle), owns: false);
		nSArray.Dispose();
		nSArray2.Dispose();
		return iNativeObject;
	}

	[Export("newBuffer:type:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMDLMeshBuffer CreateBuffer(nuint length, MDLMeshBufferType type)
	{
		return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend_nuint_UInt64(base.Handle, Selector.GetHandle("newBuffer:type:"), length, (ulong)type), owns: false);
	}

	[Export("newBufferWithData:type:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMDLMeshBuffer CreateBuffer(NSData data, MDLMeshBufferType type)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, Selector.GetHandle("newBufferWithData:type:"), data.Handle, (ulong)type), owns: false);
	}

	[Export("newBufferFromZone:length:type:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMDLMeshBuffer? CreateBuffer(IMDLMeshBufferZone? zone, nuint length, MDLMeshBufferType type)
	{
		return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_UInt64(base.Handle, Selector.GetHandle("newBufferFromZone:length:type:"), zone?.Handle ?? IntPtr.Zero, length, (ulong)type), owns: false);
	}

	[Export("newBufferFromZone:data:type:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMDLMeshBuffer? CreateBuffer(IMDLMeshBufferZone? zone, NSData data, MDLMeshBufferType type)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetINativeObject<IMDLMeshBuffer>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64(base.Handle, Selector.GetHandle("newBufferFromZone:data:type:"), zone?.Handle ?? IntPtr.Zero, data.Handle, (ulong)type), owns: false);
	}
}
