using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLDeviceWrapper : BaseWrapper, IMTLDevice, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string Name
	{
		[Export("name")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("name")));
		}
	}

	[Preserve(Conditional = true)]
	public MTLDeviceWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("newCommandQueue")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLCommandQueue? CreateCommandQueue()
	{
		IMTLCommandQueue iNativeObject = Runtime.GetINativeObject<IMTLCommandQueue>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("newCommandQueue")), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Export("newCommandQueueWithMaxCommandBufferCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLCommandQueue? CreateCommandQueue(nuint maxCommandBufferCount)
	{
		IMTLCommandQueue iNativeObject = Runtime.GetINativeObject<IMTLCommandQueue>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, Selector.GetHandle("newCommandQueueWithMaxCommandBufferCount:"), maxCommandBufferCount), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
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

	[Export("newBufferWithBytes:length:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLBuffer? CreateBuffer(IntPtr pointer, nuint length, MTLResourceOptions options)
	{
		IMTLBuffer iNativeObject = Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_UInt64(base.Handle, Selector.GetHandle("newBufferWithBytes:length:options:"), pointer, length, (ulong)options), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Export("newBufferWithBytesNoCopy:length:options:deallocator:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public unsafe IMTLBuffer? CreateBufferNoCopy(IntPtr pointer, nuint length, MTLResourceOptions options, [BlockProxy(typeof(Trampolines.NIDMTLDeallocator))] MTLDeallocator deallocator)
	{
		if (deallocator == null)
		{
			throw new ArgumentNullException("deallocator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMTLDeallocator.Handler, deallocator);
		IMTLBuffer iNativeObject = Runtime.GetINativeObject<IMTLBuffer>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_UInt64_IntPtr(base.Handle, Selector.GetHandle("newBufferWithBytesNoCopy:length:options:deallocator:"), pointer, length, (ulong)options, (IntPtr)ptr), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		ptr->CleanupBlock();
		return iNativeObject;
	}

	[Export("newDepthStencilStateWithDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLDepthStencilState? CreateDepthStencilState(MTLDepthStencilDescriptor descriptor)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IMTLDepthStencilState iNativeObject = Runtime.GetINativeObject<IMTLDepthStencilState>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("newDepthStencilStateWithDescriptor:"), descriptor.Handle), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Export("newTextureWithDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLTexture? CreateTexture(MTLTextureDescriptor descriptor)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IMTLTexture iNativeObject = Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("newTextureWithDescriptor:"), descriptor.Handle), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Export("newSamplerStateWithDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLSamplerState? CreateSamplerState(MTLSamplerDescriptor descriptor)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IMTLSamplerState iNativeObject = Runtime.GetINativeObject<IMTLSamplerState>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("newSamplerStateWithDescriptor:"), descriptor.Handle), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Export("newDefaultLibrary")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLLibrary CreateDefaultLibrary()
	{
		IMTLLibrary iNativeObject = Runtime.GetINativeObject<IMTLLibrary>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("newDefaultLibrary")), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Export("newLibraryWithFile:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLLibrary CreateLibrary(string filepath, out NSError error)
	{
		if (filepath == null)
		{
			throw new ArgumentNullException("filepath");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr intPtr = NSString.CreateNative(filepath);
		IMTLLibrary iNativeObject = Runtime.GetINativeObject<IMTLLibrary>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, Selector.GetHandle("newLibraryWithFile:error:"), intPtr, ref arg), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		NSString.ReleaseNative(intPtr);
		error = Runtime.GetNSObject<NSError>(arg);
		return iNativeObject;
	}

	[Export("newLibraryWithData:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLLibrary CreateLibrary(NSObject data, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		IMTLLibrary iNativeObject = Runtime.GetINativeObject<IMTLLibrary>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, Selector.GetHandle("newLibraryWithData:error:"), data.Handle, ref arg), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		error = Runtime.GetNSObject<NSError>(arg);
		return iNativeObject;
	}

	[Export("newLibraryWithSource:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLLibrary CreateLibrary(string source, MTLCompileOptions options, out NSError error)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr intPtr = NSString.CreateNative(source);
		IMTLLibrary iNativeObject = Runtime.GetINativeObject<IMTLLibrary>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, Selector.GetHandle("newLibraryWithSource:options:error:"), intPtr, options.Handle, ref arg), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		NSString.ReleaseNative(intPtr);
		error = Runtime.GetNSObject<NSError>(arg);
		return iNativeObject;
	}

	[Export("newLibraryWithSource:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void CreateLibrary(string source, MTLCompileOptions options, [BlockProxy(typeof(Trampolines.NIDActionArity2V67))] Action<IMTLLibrary, NSError> completionHandler)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr intPtr = NSString.CreateNative(source);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V67.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, Selector.GetHandle("newLibraryWithSource:options:completionHandler:"), intPtr, options.Handle, (IntPtr)ptr);
		NSString.ReleaseNative(intPtr);
		ptr->CleanupBlock();
	}

	[Export("newRenderPipelineStateWithDescriptor:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLRenderPipelineState CreateRenderPipelineState(MTLRenderPipelineDescriptor descriptor, out NSError error)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IntPtr arg = IntPtr.Zero;
		IMTLRenderPipelineState iNativeObject = Runtime.GetINativeObject<IMTLRenderPipelineState>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, Selector.GetHandle("newRenderPipelineStateWithDescriptor:error:"), descriptor.Handle, ref arg), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		error = Runtime.GetNSObject<NSError>(arg);
		return iNativeObject;
	}

	[Export("newRenderPipelineStateWithDescriptor:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void CreateRenderPipelineState(MTLRenderPipelineDescriptor descriptor, [BlockProxy(typeof(Trampolines.NIDActionArity2V68))] Action<IMTLRenderPipelineState, NSError> completionHandler)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V68.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("newRenderPipelineStateWithDescriptor:completionHandler:"), descriptor.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Export("newRenderPipelineStateWithDescriptor:options:reflection:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLRenderPipelineState CreateRenderPipelineState(MTLRenderPipelineDescriptor descriptor, MTLPipelineOption options, out MTLRenderPipelineReflection reflection, out NSError error)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		IMTLRenderPipelineState iNativeObject = Runtime.GetINativeObject<IMTLRenderPipelineState>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr_ref_IntPtr(base.Handle, Selector.GetHandle("newRenderPipelineStateWithDescriptor:options:reflection:error:"), descriptor.Handle, (ulong)options, ref arg, ref arg2), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		reflection = Runtime.GetNSObject<MTLRenderPipelineReflection>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
		return iNativeObject;
	}

	[Export("newRenderPipelineStateWithDescriptor:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void CreateRenderPipelineState(MTLRenderPipelineDescriptor descriptor, MTLPipelineOption options, [BlockProxy(typeof(Trampolines.NIDActionArity3V2))] Action<IMTLRenderPipelineState, MTLRenderPipelineReflection, NSError> completionHandler)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity3V2.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, Selector.GetHandle("newRenderPipelineStateWithDescriptor:options:completionHandler:"), descriptor.Handle, (ulong)options, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Export("newComputePipelineStateWithFunction:options:reflection:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLComputePipelineState CreateComputePipelineState(IMTLFunction computeFunction, MTLPipelineOption options, out MTLComputePipelineReflection reflection, out NSError error)
	{
		if (computeFunction == null)
		{
			throw new ArgumentNullException("computeFunction");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		IMTLComputePipelineState iNativeObject = Runtime.GetINativeObject<IMTLComputePipelineState>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr_ref_IntPtr(base.Handle, Selector.GetHandle("newComputePipelineStateWithFunction:options:reflection:error:"), computeFunction.Handle, (ulong)options, ref arg, ref arg2), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		reflection = Runtime.GetNSObject<MTLComputePipelineReflection>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
		return iNativeObject;
	}

	[Export("newComputePipelineStateWithFunction:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void CreateComputePipelineState(IMTLFunction computeFunction, [BlockProxy(typeof(Trampolines.NIDActionArity2V69))] Action<IMTLComputePipelineState, NSError> completionHandler)
	{
		if (computeFunction == null)
		{
			throw new ArgumentNullException("computeFunction");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V69.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("newComputePipelineStateWithFunction:completionHandler:"), computeFunction.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Export("newComputePipelineStateWithFunction:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public IMTLComputePipelineState CreateComputePipelineState(IMTLFunction computeFunction, out NSError error)
	{
		if (computeFunction == null)
		{
			throw new ArgumentNullException("computeFunction");
		}
		IntPtr arg = IntPtr.Zero;
		IMTLComputePipelineState iNativeObject = Runtime.GetINativeObject<IMTLComputePipelineState>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, Selector.GetHandle("newComputePipelineStateWithFunction:error:"), computeFunction.Handle, ref arg), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		error = Runtime.GetNSObject<NSError>(arg);
		return iNativeObject;
	}

	[Export("newComputePipelineStateWithFunction:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void CreateComputePipelineState(IMTLFunction computeFunction, MTLPipelineOption options, [BlockProxy(typeof(Trampolines.NIDActionArity3V3))] Action<IMTLComputePipelineState, MTLComputePipelineReflection, NSError> completionHandler)
	{
		if (computeFunction == null)
		{
			throw new ArgumentNullException("computeFunction");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity3V3.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr(base.Handle, Selector.GetHandle("newComputePipelineStateWithFunction:options:completionHandler:"), computeFunction.Handle, (ulong)options, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Export("supportsFeatureSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool SupportsFeatureSet(MTLFeatureSet featureSet)
	{
		return Messaging.bool_objc_msgSend_UInt64(base.Handle, Selector.GetHandle("supportsFeatureSet:"), (ulong)featureSet);
	}
}
