using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

internal sealed class MTLSamplerStateWrapper : BaseWrapper, IMTLSamplerState, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public string Label
	{
		[Export("label")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("label")));
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
	public MTLSamplerStateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
