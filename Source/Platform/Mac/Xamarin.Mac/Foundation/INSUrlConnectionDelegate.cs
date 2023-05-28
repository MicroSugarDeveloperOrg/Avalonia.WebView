using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSURLConnectionDelegate", WrapperType = typeof(NSUrlConnectionDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanAuthenticateAgainstProtectionSpace", Selector = "connection:canAuthenticateAgainstProtectionSpace:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSUrlConnection),
	typeof(NSUrlProtectionSpace)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ReceivedAuthenticationChallenge", Selector = "connection:didReceiveAuthenticationChallenge:", ParameterType = new Type[]
{
	typeof(NSUrlConnection),
	typeof(NSUrlAuthenticationChallenge)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CanceledAuthenticationChallenge", Selector = "connection:didCancelAuthenticationChallenge:", ParameterType = new Type[]
{
	typeof(NSUrlConnection),
	typeof(NSUrlAuthenticationChallenge)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConnectionShouldUseCredentialStorage", Selector = "connectionShouldUseCredentialStorage:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSUrlConnection) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedWithError", Selector = "connection:didFailWithError:", ParameterType = new Type[]
{
	typeof(NSUrlConnection),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSendRequestForAuthenticationChallenge", Selector = "connection:willSendRequestForAuthenticationChallenge:", ParameterType = new Type[]
{
	typeof(NSUrlConnection),
	typeof(NSUrlAuthenticationChallenge)
}, ParameterByRef = new bool[] { false, false })]
public interface INSUrlConnectionDelegate : INativeObject, IDisposable
{
}
