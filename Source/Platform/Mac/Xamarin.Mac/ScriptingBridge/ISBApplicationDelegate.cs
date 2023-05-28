using System;
using Foundation;
using ObjCRuntime;

namespace ScriptingBridge;

[Protocol(Name = "SBApplicationDelegate", WrapperType = typeof(SBApplicationDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EventDidFailwithError", Selector = "eventDidFail:withError:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(IntPtr),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
public interface ISBApplicationDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("eventDidFail:withError:")]
	[Preserve(Conditional = true)]
	NSObject EventDidFailwithError(IntPtr appleEvent, NSError error);
}
