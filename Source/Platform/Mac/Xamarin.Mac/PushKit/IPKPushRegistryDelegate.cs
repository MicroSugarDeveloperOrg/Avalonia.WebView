using System;
using Foundation;
using ObjCRuntime;

namespace PushKit;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "PKPushRegistryDelegate", WrapperType = typeof(PKPushRegistryDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DidUpdatePushCredentials", Selector = "pushRegistry:didUpdatePushCredentials:forType:", ParameterType = new Type[]
{
	typeof(PKPushRegistry),
	typeof(PKPushCredentials),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveIncomingPush", Selector = "pushRegistry:didReceiveIncomingPushWithPayload:forType:withCompletionHandler:", ParameterType = new Type[]
{
	typeof(PKPushRegistry),
	typeof(PKPushPayload),
	typeof(string),
	typeof(Action)
}, ParameterByRef = new bool[] { false, false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	null,
	typeof(Trampolines.NIDAction)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidInvalidatePushToken", Selector = "pushRegistry:didInvalidatePushTokenForType:", ParameterType = new Type[]
{
	typeof(PKPushRegistry),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
public interface IPKPushRegistryDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("pushRegistry:didUpdatePushCredentials:forType:")]
	[Preserve(Conditional = true)]
	void DidUpdatePushCredentials(PKPushRegistry registry, PKPushCredentials credentials, string type);
}
