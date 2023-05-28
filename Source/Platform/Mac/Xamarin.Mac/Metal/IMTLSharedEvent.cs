using System;
using Foundation;
using ObjCRuntime;

namespace Metal;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "MTLSharedEvent", WrapperType = typeof(MTLSharedEventWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "NotifyListener", Selector = "notifyListener:atValue:block:", ParameterType = new Type[]
{
	typeof(MTLSharedEventListener),
	typeof(ulong),
	typeof(MTLSharedEventNotificationBlock)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDMTLSharedEventNotificationBlock)
})]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateSharedEventHandle", Selector = "newSharedEventHandle", ReturnType = typeof(MTLSharedEventHandle))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "SignaledValue", Selector = "signaledValue", PropertyType = typeof(ulong), GetterSelector = "signaledValue", SetterSelector = "setSignaledValue:", ArgumentSemantic = ArgumentSemantic.None)]
public interface IMTLSharedEvent : INativeObject, IDisposable, IMTLEvent
{
	[Preserve(Conditional = true)]
	ulong SignaledValue
	{
		[Export("signaledValue")]
		get;
		[Export("setSignaledValue:")]
		set;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("notifyListener:atValue:block:")]
	[Preserve(Conditional = true)]
	void NotifyListener(MTLSharedEventListener listener, ulong atValue, [BlockProxy(typeof(Trampolines.NIDMTLSharedEventNotificationBlock))] MTLSharedEventNotificationBlock block);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("newSharedEventHandle")]
	[Preserve(Conditional = true)]
	[return: Release]
	MTLSharedEventHandle CreateSharedEventHandle();
}
