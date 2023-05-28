using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Protocol(Name = "CIImageProvider", WrapperType = typeof(CIImageProviderWrapper), IsInformal = true)]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ProvideImageData", Selector = "provideImageData:bytesPerRow:origin::size::userInfo:", ParameterType = new Type[]
{
	typeof(IntPtr),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint),
	typeof(nuint),
	typeof(NSObject)
}, ParameterByRef = new bool[] { false, false, false, false, false, false, false })]
public interface ICIImageProvider : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("provideImageData:bytesPerRow:origin::size::userInfo:")]
	[Preserve(Conditional = true)]
	void ProvideImageData(IntPtr data, nuint rowbytes, nuint x, nuint y, nuint width, nuint height, NSObject? info);
}
