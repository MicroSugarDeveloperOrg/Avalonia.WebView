using System;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "PHPhotoLibraryAvailabilityObserver", WrapperType = typeof(PHPhotoLibraryAvailabilityObserverWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PhotoLibraryDidBecomeUnavailable", Selector = "photoLibraryDidBecomeUnavailable:", ParameterType = new Type[] { typeof(PHPhotoLibrary) }, ParameterByRef = new bool[] { false })]
public interface IPHPhotoLibraryAvailabilityObserver : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("photoLibraryDidBecomeUnavailable:")]
	[Preserve(Conditional = true)]
	void PhotoLibraryDidBecomeUnavailable(PHPhotoLibrary photoLibrary);
}
