using System;
using Foundation;
using ObjCRuntime;

namespace AVKit;

[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "AVRoutePickerViewDelegate", WrapperType = typeof(AVRoutePickerViewDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginPresentingRoutes", Selector = "routePickerViewWillBeginPresentingRoutes:", ParameterType = new Type[] { typeof(AVRoutePickerView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEndPresentingRoutes", Selector = "routePickerViewDidEndPresentingRoutes:", ParameterType = new Type[] { typeof(AVRoutePickerView) }, ParameterByRef = new bool[] { false })]
public interface IAVRoutePickerViewDelegate : INativeObject, IDisposable
{
}
