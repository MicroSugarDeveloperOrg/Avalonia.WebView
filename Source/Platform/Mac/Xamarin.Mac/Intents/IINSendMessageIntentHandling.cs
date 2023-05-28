using System;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
[Protocol(Name = "INSendMessageIntentHandling", WrapperType = typeof(INSendMessageIntentHandlingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "HandleSendMessage", Selector = "handleSendMessage:completion:", ParameterType = new Type[]
{
	typeof(INSendMessageIntent),
	typeof(Action<INSendMessageIntentResponse>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V59)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConfirmSendMessage", Selector = "confirmSendMessage:completion:", ParameterType = new Type[]
{
	typeof(INSendMessageIntent),
	typeof(Action<INSendMessageIntentResponse>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V59)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveRecipients", Selector = "resolveRecipientsForSendMessage:withCompletion:", ParameterType = new Type[]
{
	typeof(INSendMessageIntent),
	typeof(Action<INPersonResolutionResult[]>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V55)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveRecipients", Selector = "resolveRecipientsForSendMessage:completion:", ParameterType = new Type[]
{
	typeof(INSendMessageIntent),
	typeof(Action<INSendMessageRecipientResolutionResult[]>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V60)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveContent", Selector = "resolveContentForSendMessage:withCompletion:", ParameterType = new Type[]
{
	typeof(INSendMessageIntent),
	typeof(Action<INStringResolutionResult>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V61)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveGroupName", Selector = "resolveGroupNameForSendMessage:withCompletion:", ParameterType = new Type[]
{
	typeof(INSendMessageIntent),
	typeof(Action<INStringResolutionResult>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V61)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResolveSpeakableGroupName", Selector = "resolveSpeakableGroupNameForSendMessage:withCompletion:", ParameterType = new Type[]
{
	typeof(INSendMessageIntent),
	typeof(Action<INSpeakableStringResolutionResult>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V62)
})]
public interface IINSendMessageIntentHandling : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("handleSendMessage:completion:")]
	[Preserve(Conditional = true)]
	void HandleSendMessage(INSendMessageIntent intent, [BlockProxy(typeof(Trampolines.NIDActionArity1V59))] Action<INSendMessageIntentResponse> completion);
}
