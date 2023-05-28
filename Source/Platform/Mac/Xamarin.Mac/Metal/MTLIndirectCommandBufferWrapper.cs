using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLIndirectCommandBufferWrapper : BaseWrapper, IMTLIndirectCommandBuffer, INativeObject, IDisposable, IMTLResource
{
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
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
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
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public IMTLDevice Device
	{
		[Export("device")]
		get
		{
			return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("device")), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public MTLCpuCacheMode CpuCacheMode
	{
		[Export("cpuCacheMode")]
		get
		{
			return (MTLCpuCacheMode)Messaging.UInt64_objc_msgSend(base.Handle, Selector.GetHandle("cpuCacheMode"));
		}
	}

	[Preserve(Conditional = true)]
	public MTLIndirectCommandBufferWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("resetWithRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void Reset(NSRange range)
	{
		Messaging.void_objc_msgSend_NSRange(base.Handle, Selector.GetHandle("resetWithRange:"), range);
	}

	[Export("indirectRenderCommandAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLIndirectRenderCommand GetCommand(nuint commandIndex)
	{
		return Runtime.GetINativeObject<IMTLIndirectRenderCommand>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, Selector.GetHandle("indirectRenderCommandAtIndex:"), commandIndex), owns: false);
	}

	[Export("setPurgeableState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MTLPurgeableState SetPurgeableState(MTLPurgeableState state)
	{
		return (MTLPurgeableState)Messaging.UInt64_objc_msgSend_UInt64(base.Handle, Selector.GetHandle("setPurgeableState:"), (ulong)state);
	}
}
