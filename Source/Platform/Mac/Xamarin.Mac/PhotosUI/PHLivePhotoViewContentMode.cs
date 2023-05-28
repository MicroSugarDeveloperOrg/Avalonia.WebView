using ObjCRuntime;

namespace PhotosUI;

[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Native]
public enum PHLivePhotoViewContentMode : long
{
	AspectFit,
	AspectFill
}
