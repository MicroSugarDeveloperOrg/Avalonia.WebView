using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
[Protocol(Name = "INSearchCallHistoryIntentHandling", WrapperType = typeof(INSearchCallHistoryIntentHandlingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleSearchCallHistory", Selector = "handleSearchCallHistory:completion:", ParameterType = new Type[]
{
	typeof(INSearchCallHistoryIntent),
	typeof(Action<INSearchCallHistoryIntentResponse>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V47)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConfirmSearchCallHistory", Selector = "confirmSearchCallHistory:completion:", ParameterType = new Type[]
{
	typeof(INSearchCallHistoryIntent),
	typeof(Action<INSearchCallHistoryIntentResponse>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V47)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveCallType", Selector = "resolveCallTypeForSearchCallHistory:withCompletion:", ParameterType = new Type[]
{
	typeof(INSearchCallHistoryIntent),
	typeof(Action<INCallRecordTypeResolutionResult>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V50)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveDateCreated", Selector = "resolveDateCreatedForSearchCallHistory:withCompletion:", ParameterType = new Type[]
{
	typeof(INSearchCallHistoryIntent),
	typeof(Action<INDateComponentsRangeResolutionResult>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V51)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveRecipient", Selector = "resolveRecipientForSearchCallHistory:withCompletion:", ParameterType = new Type[]
{
	typeof(INSearchCallHistoryIntent),
	typeof(Action<INPersonResolutionResult>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V52)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveCallTypes", Selector = "resolveCallTypesForSearchCallHistory:withCompletion:", ParameterType = new Type[]
{
	typeof(INSearchCallHistoryIntent),
	typeof(Action<INCallRecordTypeOptionsResolutionResult>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V53)
})]
public interface IINSearchCallHistoryIntentHandling : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("handleSearchCallHistory:completion:")]
	[Preserve(Conditional = true)]
	void HandleSearchCallHistory(INSearchCallHistoryIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V47))] Action<INSearchCallHistoryIntentResponse> completion);
}
