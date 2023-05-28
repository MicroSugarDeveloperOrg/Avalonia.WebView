using System;
using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Protocol(Name = "NSURLSessionDataDelegate", WrapperType = typeof(NSUrlSessionDataDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveResponse", Selector = "URLSession:dataTask:didReceiveResponse:completionHandler:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionDataTask),
	typeof(NSUrlResponse),
	typeof(Action<NSUrlSessionResponseDisposition>)
}, ParameterByRef = new bool[] { false, false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	null,
	typeof(Trampolines.NIDActionArity1V39)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBecomeDownloadTask", Selector = "URLSession:dataTask:didBecomeDownloadTask:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionDataTask),
	typeof(NSUrlSessionDownloadTask)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveData", Selector = "URLSession:dataTask:didReceiveData:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionDataTask),
	typeof(NSData)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillCacheResponse", Selector = "URLSession:dataTask:willCacheResponse:completionHandler:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionDataTask),
	typeof(NSCachedUrlResponse),
	typeof(Action<NSCachedUrlResponse>)
}, ParameterByRef = new bool[] { false, false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	null,
	typeof(Trampolines.NIDActionArity1V36)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBecomeStreamTask", Selector = "URLSession:dataTask:didBecomeStreamTask:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlSessionDataTask),
	typeof(NSUrlSessionStreamTask)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSUrlSessionDataDelegate : INativeObject, IDisposable, INSUrlSessionTaskDelegate, INSUrlSessionDelegate
{
}
