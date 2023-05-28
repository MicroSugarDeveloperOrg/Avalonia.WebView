using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLCaptureScopeWrapper : BaseWrapper, IMTLCaptureScope, INativeObject, IDisposable
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
	public IMTLCommandQueue? CommandQueue
	{
		[Export("commandQueue")]
		get
		{
			return Runtime.GetINativeObject<IMTLCommandQueue>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("commandQueue")), owns: false);
		}
	}

	[Preserve(Conditional = true)]
	public MTLCaptureScopeWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("beginScope")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void BeginScope()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("beginScope"));
	}

	[Export("endScope")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void EndScope()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("endScope"));
	}
}
