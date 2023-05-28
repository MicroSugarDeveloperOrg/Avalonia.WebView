using System;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Protocol(Name = "CAAction", WrapperType = typeof(CAActionWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RunAction", Selector = "runActionForKey:object:arguments:", ParameterType = new Type[]
{
	typeof(string),
	typeof(NSObject),
	typeof(NSDictionary)
}, ParameterByRef = new bool[] { false, false, false })]
public interface ICAAction : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("runActionForKey:object:arguments:")]
	[Preserve(Conditional = true)]
	void RunAction(string eventKey, NSObject obj, NSDictionary? arguments);
}
