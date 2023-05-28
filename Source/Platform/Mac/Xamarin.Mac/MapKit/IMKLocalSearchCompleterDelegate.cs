using System;
using Foundation;
using ObjCRuntime;

namespace MapKit;

[Introduced(PlatformName.TvOS, 9, 2, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 3, PlatformArchitecture.All, null)]
[Protocol(Name = "MKLocalSearchCompleterDelegate", WrapperType = typeof(MKLocalSearchCompleterDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidUpdateResults", Selector = "completerDidUpdateResults:", ParameterType = new Type[] { typeof(MKLocalSearchCompleter) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFail", Selector = "completer:didFailWithError:", ParameterType = new Type[]
{
	typeof(MKLocalSearchCompleter),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
public interface IMKLocalSearchCompleterDelegate : INativeObject, IDisposable
{
}
