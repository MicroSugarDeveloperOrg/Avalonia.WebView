using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSHapticFeedbackPerformer", WrapperType = typeof(NSHapticFeedbackPerformerWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PerformFeedback", Selector = "performFeedbackPattern:performanceTime:", ParameterType = new Type[]
{
	typeof(NSHapticFeedbackPattern),
	typeof(NSHapticFeedbackPerformanceTime)
}, ParameterByRef = new bool[] { false, false })]
public interface INSHapticFeedbackPerformer : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("performFeedbackPattern:performanceTime:")]
	[Preserve(Conditional = true)]
	void PerformFeedback(NSHapticFeedbackPattern pattern, NSHapticFeedbackPerformanceTime performanceTime);
}
