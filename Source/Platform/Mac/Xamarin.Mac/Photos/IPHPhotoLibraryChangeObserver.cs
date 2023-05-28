using System;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Protocol(Name = "PHPhotoLibraryChangeObserver", WrapperType = typeof(PHPhotoLibraryChangeObserverWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PhotoLibraryDidChange", Selector = "photoLibraryDidChange:", ParameterType = new Type[] { typeof(PHChange) }, ParameterByRef = new bool[] { false })]
public interface IPHPhotoLibraryChangeObserver : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("photoLibraryDidChange:")]
	[Preserve(Conditional = true)]
	void PhotoLibraryDidChange(PHChange changeInstance);
}
