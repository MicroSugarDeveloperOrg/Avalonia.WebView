using System;
using Foundation;
using ObjCRuntime;

namespace CoreWlan;

[Protocol(Name = "CWEventDelegate", WrapperType = typeof(CWEventDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ClientConnectionInterrupted", Selector = "clientConnectionInterrupted")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ClientConnectionInvalidated", Selector = "clientConnectionInvalidated")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PowerStateDidChangeForWiFi", Selector = "powerStateDidChangeForWiFiInterfaceWithName:", ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SsidDidChangeForWiFi", Selector = "ssidDidChangeForWiFiInterfaceWithName:", ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "BssidDidChangeForWiFi", Selector = "bssidDidChangeForWiFiInterfaceWithName:", ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CountryCodeDidChangeForWiFi", Selector = "countryCodeDidChangeForWiFiInterfaceWithName:", ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "LinkDidChangeForWiFi", Selector = "linkDidChangeForWiFiInterfaceWithName:", ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "LinkQualityDidChangeForWiFi", Selector = "linkQualityDidChangeForWiFiInterfaceWithName:rssi:transmitRate:", ParameterType = new Type[]
{
	typeof(string),
	typeof(int),
	typeof(double)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ModeDidChangeForWiFi", Selector = "modeDidChangeForWiFiInterfaceWithName:", ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ScanCacheUpdatedForWiFi", Selector = "scanCacheUpdatedForWiFiInterfaceWithName:", ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
public interface ICWEventDelegate : INativeObject, IDisposable
{
}
