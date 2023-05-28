using System;
using Foundation;
using ObjCRuntime;

namespace AutomaticAssessmentConfiguration;

[Unavailable(PlatformName.MacCatalyst, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 4, PlatformArchitecture.All, null)]
[Advice("This API is not available when using UIKit on macOS.")]
[Protocol(Name = "AEAssessmentSessionDelegate", WrapperType = typeof(AEAssessmentSessionDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidBegin", Selector = "assessmentSessionDidBegin:", ParameterType = new Type[] { typeof(AEAssessmentSession) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "FailedToBegin", Selector = "assessmentSession:failedToBeginWithError:", ParameterType = new Type[]
{
	typeof(AEAssessmentSession),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WasInterrupted", Selector = "assessmentSession:wasInterruptedWithError:", ParameterType = new Type[]
{
	typeof(AEAssessmentSession),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEnd", Selector = "assessmentSessionDidEnd:", ParameterType = new Type[] { typeof(AEAssessmentSession) }, ParameterByRef = new bool[] { false })]
public interface IAEAssessmentSessionDelegate : INativeObject, IDisposable
{
}
