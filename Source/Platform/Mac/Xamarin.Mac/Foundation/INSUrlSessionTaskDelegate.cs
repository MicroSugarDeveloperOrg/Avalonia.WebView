using System;
using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Protocol(Name = "NSURLSessionTaskDelegate", WrapperType = typeof(NSUrlSessionTaskDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPerformHttpRedirection", Selector = "URLSession:task:willPerformHTTPRedirection:newRequest:completionHandler:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionTask),
	typeof(NSHttpUrlResponse),
	typeof(NSUrlRequest),
	typeof(Action<NSUrlRequest>)
}, ParameterByRef = new bool[] { false, false, false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	null,
	null,
	typeof(Trampolines.NIDActionArity1V40)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveChallenge", Selector = "URLSession:task:didReceiveChallenge:completionHandler:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionTask),
	typeof(NSUrlAuthenticationChallenge),
	typeof(Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential>)
}, ParameterByRef = new bool[] { false, false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	null,
	typeof(Trampolines.NIDActionArity2V44)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "NeedNewBodyStream", Selector = "URLSession:task:needNewBodyStream:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionTask),
	typeof(Action<NSInputStream>)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDActionArity1V41)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSendBodyData", Selector = "URLSession:task:didSendBodyData:totalBytesSent:totalBytesExpectedToSend:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionTask),
	typeof(long),
	typeof(long),
	typeof(long)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidCompleteWithError", Selector = "URLSession:task:didCompleteWithError:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionTask),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishCollectingMetrics", Selector = "URLSession:task:didFinishCollectingMetrics:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionTask),
	typeof(NSUrlSessionTaskMetrics)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillBeginDelayedRequest", Selector = "URLSession:task:willBeginDelayedRequest:completionHandler:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionTask),
	typeof(NSUrlRequest),
	typeof(Action<NSUrlSessionDelayedRequestDisposition, NSUrlRequest>)
}, ParameterByRef = new bool[] { false, false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	null,
	typeof(Trampolines.NIDActionArity2V45)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TaskIsWaitingForConnectivity", Selector = "URLSession:taskIsWaitingForConnectivity:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionTask)
}, ParameterByRef = new bool[] { false, false })]
public interface INSUrlSessionTaskDelegate : INativeObject, IDisposable, INSUrlSessionDelegate
{
}
