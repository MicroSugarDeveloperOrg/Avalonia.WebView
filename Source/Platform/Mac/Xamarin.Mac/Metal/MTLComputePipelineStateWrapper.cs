using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

internal sealed class MTLComputePipelineStateWrapper : BaseWrapper, IMTLComputePipelineState, INativeObject, IDisposable
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
	public nuint MaxTotalThreadsPerThreadgroup
	{
		[Export("maxTotalThreadsPerThreadgroup")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("maxTotalThreadsPerThreadgroup"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint ThreadExecutionWidth
	{
		[Export("threadExecutionWidth")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("threadExecutionWidth"));
		}
	}

	[Preserve(Conditional = true)]
	public MTLComputePipelineStateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
