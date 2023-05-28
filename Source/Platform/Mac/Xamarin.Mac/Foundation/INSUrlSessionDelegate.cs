using System;
using ObjCRuntime;

namespace Foundation;

[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Protocol(Name = "NSURLSessionDelegate", WrapperType = typeof(NSUrlSessionDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBecomeInvalid", Selector = "URLSession:didBecomeInvalidWithError:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveChallenge", Selector = "URLSession:didReceiveChallenge:completionHandler:", ParameterType = new Type[]
{
	typeof(NSUrlSession),
	typeof(NSUrlAuthenticationChallenge),
	typeof(Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential>)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDActionArity2V44)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFinishEventsForBackgroundSession", Selector = "URLSessionDidFinishEventsForBackgroundURLSession:", ParameterType = new Type[] { typeof(NSUrlSession) }, ParameterByRef = new bool[] { false })]
public interface INSUrlSessionDelegate : INativeObject, IDisposable
{
}
