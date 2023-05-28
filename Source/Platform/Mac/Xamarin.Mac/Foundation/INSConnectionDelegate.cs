using System;
using ObjCRuntime;

namespace Foundation;

[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSXpcConnection' instead.")]
[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, "Use 'NSXpcConnection' instead.")]
[Deprecated(PlatformName.WatchOS, 2, 0, PlatformArchitecture.None, "Use 'NSXpcConnection' instead.")]
[Deprecated(PlatformName.TvOS, 11, 0, PlatformArchitecture.None, "Use 'NSXpcConnection' instead.")]
[Protocol(Name = "NSConnectionDelegate", WrapperType = typeof(NSConnectionDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AuthenticateComponents", Selector = "authenticateComponents:withData:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSArray),
	typeof(NSData)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetAuthenticationData", Selector = "authenticationDataForComponents:", ReturnType = typeof(NSData), ParameterType = new Type[] { typeof(NSArray) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldMakeNewConnection", Selector = "connection:shouldMakeNewConnection:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSConnection),
	typeof(NSConnection)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleRequest", Selector = "connection:handleRequest:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSConnection),
	typeof(NSDistantObjectRequest)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateConversation", Selector = "createConversationForConnection:", ReturnType = typeof(NSObject), ParameterType = new Type[] { typeof(NSConnection) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AllowNewConnection", Selector = "makeNewConnection:sender:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSConnection),
	typeof(NSConnection)
}, ParameterByRef = new bool[] { false, false })]
public interface INSConnectionDelegate : INativeObject, IDisposable
{
}
