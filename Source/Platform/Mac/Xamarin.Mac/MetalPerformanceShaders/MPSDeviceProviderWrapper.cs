using System;
using Foundation;
using Metal;
using ObjCRuntime;

namespace MetalPerformanceShaders;

internal sealed class MPSDeviceProviderWrapper : BaseWrapper, IMPSDeviceProvider, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MPSDeviceProviderWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("mpsMTLDevice")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IMTLDevice GetMTLDevice()
	{
		return Runtime.GetINativeObject<IMTLDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("mpsMTLDevice")), owns: false);
	}
}
