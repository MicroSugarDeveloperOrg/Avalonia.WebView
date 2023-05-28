using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace CoreImage;

internal sealed class CIImageProviderWrapper : BaseWrapper, ICIImageProvider, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public CIImageProviderWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("provideImageData:bytesPerRow:origin::size::userInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void ProvideImageData(IntPtr data, nuint rowbytes, nuint x, nuint y, nuint width, nuint height, NSObject? info)
	{
		Messaging.void_objc_msgSend_IntPtr_nuint_nuint_nuint_nuint_nuint_IntPtr(base.Handle, Selector.GetHandle("provideImageData:bytesPerRow:origin::size::userInfo:"), data, rowbytes, x, y, width, height, info?.Handle ?? IntPtr.Zero);
	}
}
