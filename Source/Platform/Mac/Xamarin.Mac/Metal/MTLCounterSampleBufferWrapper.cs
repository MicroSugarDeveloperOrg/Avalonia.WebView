using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Metal;

internal sealed class MTLCounterSampleBufferWrapper : BaseWrapper, IMTLCounterSampleBuffer, INativeObject, IDisposable
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
	public string Label
	{
		[Export("label")]
		get
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("label")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint SampleCount
	{
		[Export("sampleCount")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("sampleCount"));
		}
	}

	[Preserve(Conditional = true)]
	public MTLCounterSampleBufferWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("resolveCounterRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSData? ResolveCounterRange(NSRange range)
	{
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, Selector.GetHandle("resolveCounterRange:"), range));
	}
}
