using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace MetalPerformanceShaders;

internal sealed class MPSImageSizeEncodingStateWrapper : BaseWrapper, IMPSImageSizeEncodingState, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint SourceWidth
	{
		[Export("sourceWidth")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("sourceWidth"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nuint SourceHeight
	{
		[Export("sourceHeight")]
		get
		{
			return Messaging.nuint_objc_msgSend(base.Handle, Selector.GetHandle("sourceHeight"));
		}
	}

	[Preserve(Conditional = true)]
	public MPSImageSizeEncodingStateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
