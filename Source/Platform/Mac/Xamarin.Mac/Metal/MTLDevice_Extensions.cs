using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CoreFoundation;
using Foundation;
using IOSurface;
using ObjCRuntime;

namespace Metal;

public static class MTLDevice_Extensions
{
	[BindingImpl(BindingImplOptions.Optimizable)]
	public static IMTLCounterSet[] GetIMTLCounterSets(this IMTLDevice This)
	{
		return NSArray.ArrayFromHandle<IMTLCounterSet>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("counterSets")));
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.Optimizable)]
	public static IMTLCounterSampleBuffer CreateIMTLCounterSampleBuffer(this IMTLDevice This, MTLCounterSampleBufferDescriptor descriptor, out NSError error)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IntPtr arg = IntPtr.Zero;
		IMTLCounterSampleBuffer iNativeObject = Runtime.GetINativeObject<IMTLCounterSampleBuffer>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(This.Handle, Selector.GetHandle("newCounterSampleBufferWithDescriptor:error:"), descriptor.Handle, ref arg), owns: false);
		error = Runtime.GetNSObject<NSError>(arg);
		return iNativeObject;
	}

	public static IMTLBuffer CreateBuffer<T>(this IMTLDevice This, T[] data, MTLResourceOptions options) where T : struct
	{
		GCHandle gCHandle = GCHandle.Alloc(data, GCHandleType.Pinned);
		try
		{
			IntPtr pointer = gCHandle.AddrOfPinnedObject();
			return This.CreateBuffer(pointer, (nuint)(data.Length * Marshal.SizeOf(typeof(T))), options);
		}
		finally
		{
			gCHandle.Free();
		}
	}

	[Obsolete("Use the overload that takes an IntPtr instead. The 'data' parameter must be page-aligned and allocated using vm_allocate or mmap, which won't be the case for managed arrays, so this method will always fail.")]
	public static IMTLBuffer CreateBufferNoCopy<T>(this IMTLDevice This, T[] data, MTLResourceOptions options, MTLDeallocator deallocator) where T : struct
	{
		GCHandle handle = GCHandle.Alloc(data, GCHandleType.Pinned);
		IntPtr pointer2 = handle.AddrOfPinnedObject();
		return This.CreateBufferNoCopy(pointer2, (nuint)(data.Length * Marshal.SizeOf(typeof(T))), options, delegate(IntPtr pointer, nuint length)
		{
			handle.Free();
			deallocator(pointer, length);
		});
	}

	public unsafe static void GetDefaultSamplePositions(this IMTLDevice This, MTLSamplePosition[] positions, nuint count)
	{
		if (positions.Length < (nint)count)
		{
			throw new ArgumentException("Length of 'positions' cannot be less than 'count'.");
		}
		fixed (MTLSamplePosition* ptr = positions)
		{
			void* ptr2 = ptr;
			This.GetDefaultSamplePositions((IntPtr)ptr2, count);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLLibrary CreateLibrary(this IMTLDevice This, DispatchData data, out NSError error)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		IMTLLibrary iNativeObject = Runtime.GetINativeObject<IMTLLibrary>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(This.Handle, Selector.GetHandle("newLibraryWithData:error:"), data.Handle, ref arg), owns: true);
		error = Runtime.GetNSObject<NSError>(arg);
		return iNativeObject;
	}

	public static IMTLLibrary CreateDefaultLibrary(this IMTLDevice This, NSBundle bundle, out NSError error)
	{
		return CreateLibrary(This, bundle, out error);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLSizeAndAlign GetHeapTextureSizeAndAlign(this IMTLDevice This, MTLTextureDescriptor desc)
	{
		if (desc == null)
		{
			throw new ArgumentNullException("desc");
		}
		return Messaging.MTLSizeAndAlign_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("heapTextureSizeAndAlignWithDescriptor:"), desc.Handle);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLSizeAndAlign GetHeapBufferSizeAndAlignWithLength(this IMTLDevice This, nuint length, MTLResourceOptions options)
	{
		return Messaging.MTLSizeAndAlign_objc_msgSend_nuint_UInt64(This.Handle, Selector.GetHandle("heapBufferSizeAndAlignWithLength:options:"), length, (ulong)options);
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLHeap? CreateHeap(this IMTLDevice This, MTLHeapDescriptor descriptor)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IMTLHeap iNativeObject = Runtime.GetINativeObject<IMTLHeap>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("newHeapWithDescriptor:"), descriptor.Handle), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLTexture? CreateTexture(this IMTLDevice This, MTLTextureDescriptor descriptor, global::IOSurface.IOSurface iosurface, nuint plane)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		if (iosurface == null)
		{
			throw new ArgumentNullException("iosurface");
		}
		IMTLTexture iNativeObject = Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nuint(This.Handle, Selector.GetHandle("newTextureWithDescriptor:iosurface:plane:"), descriptor.Handle, iosurface.Handle, plane), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLTexture? CreateSharedTexture(this IMTLDevice This, MTLTextureDescriptor descriptor)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IMTLTexture iNativeObject = Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("newSharedTextureWithDescriptor:"), descriptor.Handle), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLTexture? CreateSharedTexture(this IMTLDevice This, MTLSharedTextureHandle sharedHandle)
	{
		if (sharedHandle == null)
		{
			throw new ArgumentNullException("sharedHandle");
		}
		IMTLTexture iNativeObject = Runtime.GetINativeObject<IMTLTexture>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("newSharedTextureWithHandle:"), sharedHandle.Handle), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Obsolete("Use 'CreateDefaultLibrary' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLLibrary? CreateLibrary(this IMTLDevice This, NSBundle bundle, out NSError error)
	{
		if (bundle == null)
		{
			throw new ArgumentNullException("bundle");
		}
		IntPtr arg = IntPtr.Zero;
		IMTLLibrary iNativeObject = Runtime.GetINativeObject<IMTLLibrary>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(This.Handle, Selector.GetHandle("newDefaultLibraryWithBundle:error:"), bundle.Handle, ref arg), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		error = Runtime.GetNSObject<NSError>(arg);
		return iNativeObject;
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLComputePipelineState CreateComputePipelineState(this IMTLDevice This, MTLComputePipelineDescriptor descriptor, MTLPipelineOption options, out MTLComputePipelineReflection reflection, out NSError error)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		IMTLComputePipelineState iNativeObject = Runtime.GetINativeObject<IMTLComputePipelineState>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr_ref_IntPtr(This.Handle, Selector.GetHandle("newComputePipelineStateWithDescriptor:options:reflection:error:"), descriptor.Handle, (ulong)options, ref arg, ref arg2), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		reflection = Runtime.GetNSObject<MTLComputePipelineReflection>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
		return iNativeObject;
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void CreateComputePipelineState(this IMTLDevice This, MTLComputePipelineDescriptor descriptor, MTLPipelineOption options, [BlockProxy(typeof(Trampolines.NIDMTLNewComputePipelineStateWithReflectionCompletionHandler))] MTLNewComputePipelineStateWithReflectionCompletionHandler completionHandler)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDMTLNewComputePipelineStateWithReflectionCompletionHandler.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_UInt64_IntPtr(This.Handle, Selector.GetHandle("newComputePipelineStateWithDescriptor:options:completionHandler:"), descriptor.Handle, (ulong)options, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLFence CreateFence(this IMTLDevice This)
	{
		IMTLFence iNativeObject = Runtime.GetINativeObject<IMTLFence>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("newFence")), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SupportsTextureSampleCount(this IMTLDevice This, nuint sampleCount)
	{
		return Messaging.bool_objc_msgSend_nuint(This.Handle, Selector.GetHandle("supportsTextureSampleCount:"), sampleCount);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLLibrary? CreateLibrary(this IMTLDevice This, NSUrl url, out NSError? error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		IMTLLibrary iNativeObject = Runtime.GetINativeObject<IMTLLibrary>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(This.Handle, Selector.GetHandle("newLibraryWithURL:error:"), url.Handle, ref arg), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		error = Runtime.GetNSObject<NSError>(arg);
		return iNativeObject;
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetMinimumLinearTextureAlignment(this IMTLDevice This, MTLPixelFormat format)
	{
		return Messaging.nuint_objc_msgSend_UInt64(This.Handle, Selector.GetHandle("minimumLinearTextureAlignmentForPixelFormat:"), (ulong)format);
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetMinimumTextureBufferAlignment(this IMTLDevice This, MTLPixelFormat format)
	{
		return Messaging.nuint_objc_msgSend_UInt64(This.Handle, Selector.GetHandle("minimumTextureBufferAlignmentForPixelFormat:"), (ulong)format);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void GetDefaultSamplePositions(this IMTLDevice This, IntPtr positions, nuint count)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint(This.Handle, Selector.GetHandle("getDefaultSamplePositions:count:"), positions, count);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLArgumentEncoder? CreateArgumentEncoder(this IMTLDevice This, MTLArgumentDescriptor[] arguments)
	{
		if (arguments == null)
		{
			throw new ArgumentNullException("arguments");
		}
		NSArray nSArray = NSArray.FromNSObjects(arguments);
		IMTLArgumentEncoder iNativeObject = Runtime.GetINativeObject<IMTLArgumentEncoder>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("newArgumentEncoderWithArguments:"), nSArray.Handle), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		nSArray.Dispose();
		return iNativeObject;
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLIndirectCommandBuffer? CreateIndirectCommandBuffer(this IMTLDevice This, MTLIndirectCommandBufferDescriptor descriptor, nuint maxCount, MTLResourceOptions options)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IMTLIndirectCommandBuffer iNativeObject = Runtime.GetINativeObject<IMTLIndirectCommandBuffer>(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_UInt64(This.Handle, Selector.GetHandle("newIndirectCommandBufferWithDescriptor:maxCommandCount:options:"), descriptor.Handle, maxCount, (ulong)options), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLEvent? CreateEvent(this IMTLDevice This)
	{
		IMTLEvent iNativeObject = Runtime.GetINativeObject<IMTLEvent>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("newEvent")), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLSharedEvent? CreateSharedEvent(this IMTLDevice This)
	{
		IMTLSharedEvent iNativeObject = Runtime.GetINativeObject<IMTLSharedEvent>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("newSharedEvent")), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public static IMTLSharedEvent? CreateSharedEvent(this IMTLDevice This, MTLSharedEventHandle sharedEventHandle)
	{
		if (sharedEventHandle == null)
		{
			throw new ArgumentNullException("sharedEventHandle");
		}
		IMTLSharedEvent iNativeObject = Runtime.GetINativeObject<IMTLSharedEvent>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("newSharedEventWithHandle:"), sharedEventHandle.Handle), owns: false);
		if (iNativeObject != null)
		{
			Messaging.void_objc_msgSend(iNativeObject.Handle, Selector.GetHandle("release"));
		}
		return iNativeObject;
	}

	[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SupportsVertexAmplification(this IMTLDevice This, nuint count)
	{
		return Messaging.bool_objc_msgSend_nuint(This.Handle, Selector.GetHandle("supportsVertexAmplificationCount:"), count);
	}

	[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SupportsRasterizationRateMap(this IMTLDevice This, nuint layerCount)
	{
		return Messaging.bool_objc_msgSend_nuint(This.Handle, Selector.GetHandle("supportsRasterizationRateMapWithLayerCount:"), layerCount);
	}

	[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMTLRasterizationRateMap? CreateRasterizationRateMap(this IMTLDevice This, MTLRasterizationRateMapDescriptor descriptor)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		return Runtime.GetINativeObject<IMTLRasterizationRateMap>(Messaging.IntPtr_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("newRasterizationRateMapWithDescriptor:"), descriptor.Handle), owns: false);
	}

	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SupportsFamily(this IMTLDevice This, MTLGpuFamily gpuFamily)
	{
		return Messaging.bool_objc_msgSend_Int64(This.Handle, Selector.GetHandle("supportsFamily:"), (long)gpuFamily);
	}

	[Obsolete("Use 'CreateIMTLCounterSampleBuffer' instead.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLCounterSampleBuffer? CreateCounterSampleBuffer(this IMTLDevice This, MTLCounterSampleBufferDescriptor descriptor, out NSError? error)
	{
		if (descriptor == null)
		{
			throw new ArgumentNullException("descriptor");
		}
		IntPtr arg = IntPtr.Zero;
		MTLCounterSampleBuffer nSObject = Runtime.GetNSObject<MTLCounterSampleBuffer>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(This.Handle, Selector.GetHandle("newCounterSampleBufferWithDescriptor:error:"), descriptor.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void GetSampleTimestamps(this IMTLDevice This, nuint cpuTimestamp, nuint gpuTimestamp)
	{
		Messaging.void_objc_msgSend_nuint_nuint(This.Handle, Selector.GetHandle("sampleTimestamps:gpuTimestamp:"), cpuTimestamp, gpuTimestamp);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<IMTLLibrary> CreateLibraryAsync(this IMTLDevice This, string source, MTLCompileOptions options)
	{
		TaskCompletionSource<IMTLLibrary> tcs = new TaskCompletionSource<IMTLLibrary>();
		This.CreateLibrary(source, options, delegate(IMTLLibrary arg1_, NSError arg2_)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLSize GetMaxThreadsPerThreadgroup(this IMTLDevice This)
	{
		Messaging.MTLSize_objc_msgSend_stret(out var retval, This.Handle, Selector.GetHandle("maxThreadsPerThreadgroup"));
		return retval;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetLowPower(this IMTLDevice This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("lowPower"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetHeadless(this IMTLDevice This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("headless"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static ulong GetRecommendedMaxWorkingSetSize(this IMTLDevice This)
	{
		return Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("recommendedMaxWorkingSetSize"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetDepth24Stencil8PixelFormatSupported(this IMTLDevice This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("depth24Stencil8PixelFormatSupported"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetRemovable(this IMTLDevice This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("removable"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLReadWriteTextureTier GetReadWriteTextureSupport(this IMTLDevice This)
	{
		return (MTLReadWriteTextureTier)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("readWriteTextureSupport"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLArgumentBuffersTier GetArgumentBuffersSupport(this IMTLDevice This)
	{
		return (MTLArgumentBuffersTier)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("argumentBuffersSupport"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetRasterOrderGroupsSupported(this IMTLDevice This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("rasterOrderGroupsSupported"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetMaxThreadgroupMemoryLength(this IMTLDevice This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("maxThreadgroupMemoryLength"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetMaxArgumentBufferSamplerCount(this IMTLDevice This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("maxArgumentBufferSamplerCount"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetProgrammableSamplePositionsSupported(this IMTLDevice This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("programmableSamplePositionsSupported"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetMaxBufferLength(this IMTLDevice This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("maxBufferLength"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static ulong GetRegistryId(this IMTLDevice This)
	{
		return Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("registryID"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetCurrentAllocatedSize(this IMTLDevice This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("currentAllocatedSize"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetHasUnifiedMemory(this IMTLDevice This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("hasUnifiedMemory"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetBarycentricCoordsSupported(this IMTLDevice This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("barycentricCoordsSupported"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool GetSupportsShaderBarycentricCoordinates(this IMTLDevice This)
	{
		return Messaging.bool_objc_msgSend(This.Handle, Selector.GetHandle("supportsShaderBarycentricCoordinates"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static uint GetPeerIndex(this IMTLDevice This)
	{
		return Messaging.UInt32_objc_msgSend(This.Handle, Selector.GetHandle("peerIndex"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static uint GetPeerCount(this IMTLDevice This)
	{
		return Messaging.UInt32_objc_msgSend(This.Handle, Selector.GetHandle("peerCount"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLCounterSet[] GetCounterSets(this IMTLDevice This)
	{
		return NSArray.ArrayFromHandle<MTLCounterSet>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("counterSets")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static ulong GetPeerGroupId(this IMTLDevice This)
	{
		return Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("peerGroupID"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static ulong GetMaxTransferRate(this IMTLDevice This)
	{
		return Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("maxTransferRate"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static MTLDeviceLocation GetLocation(this IMTLDevice This)
	{
		return (MTLDeviceLocation)Messaging.UInt64_objc_msgSend(This.Handle, Selector.GetHandle("location"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nuint GetLocationNumber(this IMTLDevice This)
	{
		return Messaging.nuint_objc_msgSend(This.Handle, Selector.GetHandle("locationNumber"));
	}
}
