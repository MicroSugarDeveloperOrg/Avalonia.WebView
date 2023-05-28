using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLCommandBufferWrapper : BaseWrapper, IMTLCommandBuffer, INativeObject, IDisposable
{
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
	public IMTLCommandQueue CommandQueue
	{
		[Export("commandQueue")]
		get
		{
			return Runtime.GetINativeObject<IMTLCommandQueue>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("commandQueue")), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool RetainedReferences
	{
		[Export("retainedReferences")]
		get
		{
			return Messaging.bool_objc_msgSend(base.Handle, Selector.GetHandle("retainedReferences"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string Label
	{
		[Export("label")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("label")));
		}
		[Export("setLabel:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr intPtr = NSString.CreateNative(value);
			Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setLabel:"), intPtr);
			NSString.ReleaseNative(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLCommandBufferStatus Status
	{
		[Export("status")]
		get
		{
			return (MTLCommandBufferStatus)Messaging.UInt64_objc_msgSend(base.Handle, Selector.GetHandle("status"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSError Error
	{
		[Export("error")]
		get
		{
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("error")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLBlitCommandEncoder BlitCommandEncoder
	{
		[Export("blitCommandEncoder")]
		get
		{
			return Runtime.GetINativeObject<IMTLBlitCommandEncoder>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("blitCommandEncoder")), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLComputeCommandEncoder ComputeCommandEncoder
	{
		[Export("computeCommandEncoder")]
		get
		{
			return Runtime.GetINativeObject<IMTLComputeCommandEncoder>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("computeCommandEncoder")), owns: false);
		}
	}

	[Preserve(Conditional = true)]
	public MTLCommandBufferWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("enqueue")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Enqueue()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("enqueue"));
	}

	[Export("commit")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Commit()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("commit"));
	}

	[Export("addScheduledHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void AddScheduledHandler([BlockProxy(typeof(Trampolines.NIDActionArity1V64))] Action<IMTLCommandBuffer> block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V64.Handler, block);
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("addScheduledHandler:"), (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Export("waitUntilScheduled")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void WaitUntilScheduled()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("waitUntilScheduled"));
	}

	[Export("addCompletedHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe void AddCompletedHandler([BlockProxy(typeof(Trampolines.NIDActionArity1V64))] Action<IMTLCommandBuffer> block)
	{
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V64.Handler, block);
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("addCompletedHandler:"), (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Export("waitUntilCompleted")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void WaitUntilCompleted()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("waitUntilCompleted"));
	}

	[Export("parallelRenderCommandEncoderWithDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLParallelRenderCommandEncoder? CreateParallelRenderCommandEncoder(MTLRenderPassDescriptor renderPassDescriptor)
	{
		if (renderPassDescriptor == null)
		{
			throw new ArgumentNullException("renderPassDescriptor");
		}
		return Runtime.GetINativeObject<IMTLParallelRenderCommandEncoder>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("parallelRenderCommandEncoderWithDescriptor:"), renderPassDescriptor.Handle), owns: false);
	}

	[Export("presentDrawable:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PresentDrawable(IMTLDrawable drawable)
	{
		if (drawable == null)
		{
			throw new ArgumentNullException("drawable");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("presentDrawable:"), drawable.Handle);
	}

	[Export("presentDrawable:atTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PresentDrawable(IMTLDrawable drawable, double presentationTime)
	{
		if (drawable == null)
		{
			throw new ArgumentNullException("drawable");
		}
		Messaging.void_objc_msgSend_IntPtr_Double(base.Handle, Selector.GetHandle("presentDrawable:atTime:"), drawable.Handle, presentationTime);
	}

	[Export("renderCommandEncoderWithDescriptor:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLRenderCommandEncoder CreateRenderCommandEncoder(MTLRenderPassDescriptor renderPassDescriptor)
	{
		if (renderPassDescriptor == null)
		{
			throw new ArgumentNullException("renderPassDescriptor");
		}
		return Runtime.GetINativeObject<IMTLRenderCommandEncoder>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("renderCommandEncoderWithDescriptor:"), renderPassDescriptor.Handle), owns: false);
	}
}
