using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLHeapWrapper : BaseWrapper, IMTLHeap, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string? Label
	{
		[Export("label")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("label")));
		}
		[Export("setLabel:")]
		set
		{
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setLabel:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLDevice Device
	{
		[Export("device")]
		get
		{
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("device")), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLStorageMode StorageMode
	{
		[Export("storageMode")]
		get
		{
			return (MTLStorageMode)Messaging.UInt64_objc_msgSend(base.Handle, Selector.GetHandle("storageMode"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLCpuCacheMode CpuCacheMode
	{
		[Export("cpuCacheMode")]
		get
		{
			return (MTLCpuCacheMode)Messaging.UInt64_objc_msgSend(base.Handle, Selector.GetHandle("cpuCacheMode"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint Size
	{
		[Export("size")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("size"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint UsedSize
	{
		[Export("usedSize")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("usedSize"));
		}
	}

	[Preserve(Conditional = true)]
	public MTLHeapWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("maxAvailableSizeWithAlignment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint GetMaxAvailableSize(nuint alignment)
	{
		return Messaging.nuint_objc_msgSend_nuint(base.Handle, Selector.GetHandle("maxAvailableSizeWithAlignment:"), alignment);
	}

	[Export("newBufferWithLength:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLBuffer? CreateBuffer(nuint length, MTLResourceOptions options)
	{
		IMTLBuffer iNativeObject = Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend_nuint_UInt64(base.Handle, Selector.GetHandle("newBufferWithLength:options:"), length, (ulong)options), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Export("newTextureWithDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLTexture? CreateTexture(MTLTextureDescriptor desc)
	{
		if (desc == null)
		{
			throw new ArgumentNullException("desc");
		}
		IMTLTexture iNativeObject = Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("newTextureWithDescriptor:"), desc.Handle), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Export("setPurgeableState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLPurgeableState SetPurgeableState(MTLPurgeableState state)
	{
		return (MTLPurgeableState)Messaging.UInt64_objc_msgSend_UInt64(base.Handle, Selector.GetHandle("setPurgeableState:"), (ulong)state);
	}
}
