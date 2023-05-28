using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SCNSceneExportDelegate", WrapperType = typeof(SCNSceneExportDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteImage", Selector = "writeImage:withSceneDocumentURL:originalImageURL:", ReturnType = typeof(NSUrl), ParameterType = new Type[]
{
	typeof(NSImage),
	typeof(NSUrl),
	typeof(NSUrl)
}, ParameterByRef = new bool[] { false, false, false })]
public interface ISCNSceneExportDelegate : INativeObject, IDisposable
{
}
