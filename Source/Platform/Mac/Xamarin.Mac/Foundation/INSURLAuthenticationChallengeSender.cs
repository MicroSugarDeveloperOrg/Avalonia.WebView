using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSURLAuthenticationChallengeSender", WrapperType = typeof(NSURLAuthenticationChallengeSenderWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "UseCredential", Selector = "useCredential:forAuthenticationChallenge:", ParameterType = new Type[]
{
	typeof(NSUrlCredential),
	typeof(NSUrlAuthenticationChallenge)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ContinueWithoutCredential", Selector = "continueWithoutCredentialForAuthenticationChallenge:", ParameterType = new Type[] { typeof(NSUrlAuthenticationChallenge) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CancelAuthenticationChallenge", Selector = "cancelAuthenticationChallenge:", ParameterType = new Type[] { typeof(NSUrlAuthenticationChallenge) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformDefaultHandling", Selector = "performDefaultHandlingForAuthenticationChallenge:", ParameterType = new Type[] { typeof(NSUrlAuthenticationChallenge) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RejectProtectionSpaceAndContinue", Selector = "rejectProtectionSpaceAndContinueWithChallenge:", ParameterType = new Type[] { typeof(NSUrlAuthenticationChallenge) }, ParameterByRef = new bool[] { false })]
public interface INSURLAuthenticationChallengeSender : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("useCredential:forAuthenticationChallenge:")]
	[Preserve(Conditional = true)]
	void UseCredential(NSUrlCredential credential, NSUrlAuthenticationChallenge challenge);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("continueWithoutCredentialForAuthenticationChallenge:")]
	[Preserve(Conditional = true)]
	void ContinueWithoutCredential(NSUrlAuthenticationChallenge challenge);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("cancelAuthenticationChallenge:")]
	[Preserve(Conditional = true)]
	void CancelAuthenticationChallenge(NSUrlAuthenticationChallenge challenge);
}
