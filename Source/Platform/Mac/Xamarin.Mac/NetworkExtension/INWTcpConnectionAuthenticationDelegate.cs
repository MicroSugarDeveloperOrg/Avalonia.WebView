using System;
using Foundation;
using ObjCRuntime;
using Security;

namespace NetworkExtension;

[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "NWTCPConnectionAuthenticationDelegate", WrapperType = typeof(NWTcpConnectionAuthenticationDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldProvideIdentity", Selector = "shouldProvideIdentityForConnection:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NWTcpConnection) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ProvideIdentity", Selector = "provideIdentityForConnection:completionHandler:", ParameterType = new Type[]
{
	typeof(NWTcpConnection),
	typeof(Action<SecIdentity, NSArray>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity2V76)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldEvaluateTrust", Selector = "shouldEvaluateTrustForConnection:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NWTcpConnection) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "EvaluateTrust", Selector = "evaluateTrustForConnection:peerCertificateChain:completionHandler:", ParameterType = new Type[]
{
	typeof(NWTcpConnection),
	typeof(NSArray),
	typeof(Action<SecTrust>)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDActionArity1V68)
})]
public interface INWTcpConnectionAuthenticationDelegate : INativeObject, IDisposable
{
}
