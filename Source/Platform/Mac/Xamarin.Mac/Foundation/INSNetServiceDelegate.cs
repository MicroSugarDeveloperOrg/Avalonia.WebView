using System;
using ObjCRuntime;

namespace Foundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "NSNetServiceDelegate", WrapperType = typeof(NSNetServiceDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillPublish", Selector = "netServiceWillPublish:", ParameterType = new Type[] { typeof(NSNetService) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Published", Selector = "netServiceDidPublish:", ParameterType = new Type[] { typeof(NSNetService) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PublishFailure", Selector = "netService:didNotPublish:", ParameterType = new Type[]
{
	typeof(NSNetService),
	typeof(NSDictionary)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillResolve", Selector = "netServiceWillResolve:", ParameterType = new Type[] { typeof(NSNetService) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddressResolved", Selector = "netServiceDidResolveAddress:", ParameterType = new Type[] { typeof(NSNetService) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveFailure", Selector = "netService:didNotResolve:", ParameterType = new Type[]
{
	typeof(NSNetService),
	typeof(NSDictionary)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "Stopped", Selector = "netServiceDidStop:", ParameterType = new Type[] { typeof(NSNetService) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdatedTxtRecordData", Selector = "netService:didUpdateTXTRecordData:", ParameterType = new Type[]
{
	typeof(NSNetService),
	typeof(NSData)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidAcceptConnection", Selector = "netService:didAcceptConnectionWithInputStream:outputStream:", ParameterType = new Type[]
{
	typeof(NSNetService),
	typeof(NSInputStream),
	typeof(NSOutputStream)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSNetServiceDelegate : INativeObject, IDisposable
{
}
