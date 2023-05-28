using System;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Protocol(Name = "SCNActionable", WrapperType = typeof(SCNActionableWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RunAction", Selector = "runAction:", ParameterType = new Type[] { typeof(SCNAction) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RunAction", Selector = "runAction:completionHandler:", ParameterType = new Type[]
{
	typeof(SCNAction),
	typeof(Action)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDAction)
})]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RunAction", Selector = "runAction:forKey:", ParameterType = new Type[]
{
	typeof(SCNAction),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RunAction", Selector = "runAction:forKey:completionHandler:", ParameterType = new Type[]
{
	typeof(SCNAction),
	typeof(string),
	typeof(Action)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDAction)
})]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "HasActions", Selector = "hasActions", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAction", Selector = "actionForKey:", ReturnType = typeof(SCNAction), ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAction", Selector = "removeActionForKey:", ParameterType = new Type[] { typeof(string) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "RemoveAllActions", Selector = "removeAllActions")]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ActionKeys", Selector = "actionKeys", PropertyType = typeof(string[]), GetterSelector = "actionKeys", ArgumentSemantic = ArgumentSemantic.None)]
public interface ISCNActionable : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("runAction:")]
	[Preserve(Conditional = true)]
	void RunAction(SCNAction action);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("runAction:completionHandler:")]
	[Preserve(Conditional = true)]
	void RunAction(SCNAction action, [BlockProxy(typeof(Trampolines.NIDAction))] Action? block);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("runAction:forKey:")]
	[Preserve(Conditional = true)]
	void RunAction(SCNAction action, string? key);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("runAction:forKey:completionHandler:")]
	[Preserve(Conditional = true)]
	void RunAction(SCNAction action, string? key, [BlockProxy(typeof(Trampolines.NIDAction))] Action? block);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("hasActions")]
	[Preserve(Conditional = true)]
	bool HasActions();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("actionForKey:")]
	[Preserve(Conditional = true)]
	SCNAction GetAction(string key);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("removeActionForKey:")]
	[Preserve(Conditional = true)]
	void RemoveAction(string key);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("removeAllActions")]
	[Preserve(Conditional = true)]
	void RemoveAllActions();
}
