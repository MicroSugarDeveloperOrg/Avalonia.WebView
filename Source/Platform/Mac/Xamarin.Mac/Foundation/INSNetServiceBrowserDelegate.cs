using System;
using ObjCRuntime;

namespace Foundation;

[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Protocol(Name = "NSNetServiceBrowserDelegate", WrapperType = typeof(NSNetServiceBrowserDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SearchStarted", Selector = "netServiceBrowserWillSearch:", ParameterType = new Type[] { typeof(NSNetServiceBrowser) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SearchStopped", Selector = "netServiceBrowserDidStopSearch:", ParameterType = new Type[] { typeof(NSNetServiceBrowser) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "NotSearched", Selector = "netServiceBrowser:didNotSearch:", ParameterType = new Type[]
{
	typeof(NSNetServiceBrowser),
	typeof(NSDictionary)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FoundDomain", Selector = "netServiceBrowser:didFindDomain:moreComing:", ParameterType = new Type[]
{
	typeof(NSNetServiceBrowser),
	typeof(string),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FoundService", Selector = "netServiceBrowser:didFindService:moreComing:", ParameterType = new Type[]
{
	typeof(NSNetServiceBrowser),
	typeof(NSNetService),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DomainRemoved", Selector = "netServiceBrowser:didRemoveDomain:moreComing:", ParameterType = new Type[]
{
	typeof(NSNetServiceBrowser),
	typeof(string),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ServiceRemoved", Selector = "netServiceBrowser:didRemoveService:moreComing:", ParameterType = new Type[]
{
	typeof(NSNetServiceBrowser),
	typeof(NSNetService),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSNetServiceBrowserDelegate : INativeObject, IDisposable
{
}
