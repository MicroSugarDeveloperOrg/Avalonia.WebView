using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
[Protocol(Name = "INSearchForMessagesIntentHandling", WrapperType = typeof(INSearchForMessagesIntentHandlingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleSearchForMessages", Selector = "handleSearchForMessages:completion:", ParameterType = new Type[]
{
	typeof(INSearchForMessagesIntent),
	typeof(Action<INSearchForMessagesIntentResponse>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V54)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConfirmSearchForMessages", Selector = "confirmSearchForMessages:completion:", ParameterType = new Type[]
{
	typeof(INSearchForMessagesIntent),
	typeof(Action<INSearchForMessagesIntentResponse>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V54)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveRecipients", Selector = "resolveRecipientsForSearchForMessages:withCompletion:", ParameterType = new Type[]
{
	typeof(INSearchForMessagesIntent),
	typeof(Action<INPersonResolutionResult[]>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V55)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveSenders", Selector = "resolveSendersForSearchForMessages:withCompletion:", ParameterType = new Type[]
{
	typeof(INSearchForMessagesIntent),
	typeof(Action<INPersonResolutionResult[]>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V55)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveAttributes", Selector = "resolveAttributesForSearchForMessages:withCompletion:", ParameterType = new Type[]
{
	typeof(INSearchForMessagesIntent),
	typeof(Action<INMessageAttributeOptionsResolutionResult>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V56)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveDateTimeRange", Selector = "resolveDateTimeRangeForSearchForMessages:withCompletion:", ParameterType = new Type[]
{
	typeof(INSearchForMessagesIntent),
	typeof(Action<INDateComponentsRangeResolutionResult>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V51)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveGroupNames", Selector = "resolveGroupNamesForSearchForMessages:withCompletion:", ParameterType = new Type[]
{
	typeof(INSearchForMessagesIntent),
	typeof(Action<INStringResolutionResult[]>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V57)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveSpeakableGroupNames", Selector = "resolveSpeakableGroupNamesForSearchForMessages:withCompletion:", ParameterType = new Type[]
{
	typeof(INSearchForMessagesIntent),
	typeof(Action<INSpeakableStringResolutionResult[]>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V58)
})]
public interface IINSearchForMessagesIntentHandling : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("handleSearchForMessages:completion:")]
	[Preserve(Conditional = true)]
	void HandleSearchForMessages(INSearchForMessagesIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V54))] Action<INSearchForMessagesIntentResponse> completion);
}
