using System;
using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "NSURLSessionWebSocketDelegate", WrapperType = typeof(NSUrlSessionWebSocketDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidOpen", Selector = "URLSession:webSocketTask:didOpenWithProtocol:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionWebSocketTask),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidClose", Selector = "URLSession:webSocketTask:didCloseWithCode:reason:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionWebSocketTask),
	typeof(NSUrlSessionWebSocketCloseCode),
	typeof(NSData)
}, ParameterByRef = new bool[] { false, false, false, false })]
public interface INSUrlSessionWebSocketDelegate : INativeObject, IDisposable, INSUrlSessionTaskDelegate, INSUrlSessionDelegate
{
}
