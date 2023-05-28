using System;
using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "NSURLSessionStreamDelegate", WrapperType = typeof(NSUrlSessionStreamDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReadClosed", Selector = "URLSession:readClosedForStreamTask:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionStreamTask)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteClosed", Selector = "URLSession:writeClosedForStreamTask:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionStreamTask)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "BetterRouteDiscovered", Selector = "URLSession:betterRouteDiscoveredForStreamTask:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionStreamTask)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CompletedTaskCaptureStreams", Selector = "URLSession:streamTask:didBecomeInputStream:outputStream:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionStreamTask),
	typeof(NSInputStream),
	typeof(NSOutputStream)
}, ParameterByRef = new bool[] { false, false, false, false })]
public interface INSUrlSessionStreamDelegate : INativeObject, IDisposable, INSUrlSessionTaskDelegate, INSUrlSessionDelegate
{
}
