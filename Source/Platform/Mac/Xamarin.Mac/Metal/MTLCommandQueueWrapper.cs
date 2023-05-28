using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLCommandQueueWrapper : BaseWrapper, IMTLCommandQueue, INativeObject, IDisposable
{
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
	public IMTLDevice Device
	{
		[Export("device")]
		get
		{
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("device")), owns: false);
		}
	}

	[Preserve(Conditional = true)]
	public MTLCommandQueueWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("commandBuffer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLCommandBuffer? CommandBuffer()
	{
		using (new NSAutoreleasePool())
		{
			return Runtime.GetINativeObject<IMTLCommandBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("commandBuffer")), owns: false);
		}
	}

	[Export("commandBufferWithUnretainedReferences")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLCommandBuffer? CommandBufferWithUnretainedReferences()
	{
		using (new NSAutoreleasePool())
		{
			return Runtime.GetINativeObject<IMTLCommandBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("commandBufferWithUnretainedReferences")), owns: false);
		}
	}

	[Export("insertDebugCaptureBoundary")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void InsertDebugCaptureBoundary()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("insertDebugCaptureBoundary"));
	}
}
