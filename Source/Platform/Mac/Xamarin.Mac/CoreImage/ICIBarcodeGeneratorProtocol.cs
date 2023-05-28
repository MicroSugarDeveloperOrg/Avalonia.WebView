using System;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIBarcodeGenerator", WrapperType = typeof(CIBarcodeGeneratorProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "BarcodeDescriptor", Selector = "barcodeDescriptor", PropertyType = typeof(CIBarcodeDescriptor), GetterSelector = "barcodeDescriptor", SetterSelector = "setBarcodeDescriptor:", ArgumentSemantic = ArgumentSemantic.Retain)]
public interface ICIBarcodeGeneratorProtocol : INativeObject, IDisposable, ICIFilterProtocol
{
	[Preserve(Conditional = true)]
	CIBarcodeDescriptor BarcodeDescriptor
	{
		[Export("barcodeDescriptor", ArgumentSemantic.Retain)]
		get;
		[Export("setBarcodeDescriptor:", ArgumentSemantic.Retain)]
		set;
	}
}
