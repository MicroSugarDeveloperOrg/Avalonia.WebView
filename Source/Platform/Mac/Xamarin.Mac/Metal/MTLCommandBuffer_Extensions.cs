using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

public static class MTLCommandBuffer_Extensions
{
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IMTLComputeCommandEncoder? ComputeCommandEncoderDispatch(this IMTLCommandBuffer This, MTLDispatchType dispatchType)
	{
		return Runtime.GetINativeObject<IMTLComputeCommandEncoder>(Messaging.IntPtr_objc_msgSend_UInt64(This.Handle, Selector.GetHandle("computeCommandEncoderWithDispatchType:"), (ulong)dispatchType), owns: false);
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void EncodeWait(this IMTLCommandBuffer This, IMTLEvent @event, ulong value)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("@event");
		}
		Messaging.void_objc_msgSend_IntPtr_UInt64(This.Handle, Selector.GetHandle("encodeWaitForEvent:value:"), @event.Handle, value);
	}

	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void EncodeSignal(this IMTLCommandBuffer This, IMTLEvent @event, ulong value)
	{
		if (@event == null)
		{
			throw new ArgumentNullException("@event");
		}
		Messaging.void_objc_msgSend_IntPtr_UInt64(This.Handle, Selector.GetHandle("encodeSignalEvent:value:"), @event.Handle, value);
	}

	[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
	[Introduced(PlatformName.iOS, 10, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PresentDrawableAfter(this IMTLCommandBuffer This, IMTLDrawable drawable, double duration)
	{
		if (drawable == null)
		{
			throw new ArgumentNullException("drawable");
		}
		Messaging.void_objc_msgSend_IntPtr_Double(This.Handle, Selector.GetHandle("presentDrawable:afterMinimumDuration:"), drawable.Handle, duration);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PushDebugGroup(this IMTLCommandBuffer This, string @string)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		IntPtr intPtr = NSString.CreateNative(@string);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("pushDebugGroup:"), intPtr);
		NSString.ReleaseNative(intPtr);
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void PopDebugGroup(this IMTLCommandBuffer This)
	{
		Messaging.void_objc_msgSend(This.Handle, Selector.GetHandle("popDebugGroup"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static double GetKernelStartTime(this IMTLCommandBuffer This)
	{
		return Messaging.Double_objc_msgSend(This.Handle, Selector.GetHandle("kernelStartTime"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static double GetKernelEndTime(this IMTLCommandBuffer This)
	{
		return Messaging.Double_objc_msgSend(This.Handle, Selector.GetHandle("kernelEndTime"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static double GetGpuStartTime(this IMTLCommandBuffer This)
	{
		return Messaging.Double_objc_msgSend(This.Handle, Selector.GetHandle("GPUStartTime"));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static double GetGpuEndTime(this IMTLCommandBuffer This)
	{
		return Messaging.Double_objc_msgSend(This.Handle, Selector.GetHandle("GPUEndTime"));
	}
}
