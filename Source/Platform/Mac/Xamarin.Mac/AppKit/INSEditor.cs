using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Protocol(Name = "NSEditor", WrapperType = typeof(NSEditorWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DiscardEditing", Selector = "discardEditing")]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CommitEditing", Selector = "commitEditing", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CommitEditing", Selector = "commitEditingWithDelegate:didCommitSelector:contextInfo:", ParameterType = new Type[]
{
	typeof(NSObject),
	typeof(Selector),
	typeof(IntPtr)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "CommitEditing", Selector = "commitEditingAndReturnError:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSError) }, ParameterByRef = new bool[] { true })]
public interface INSEditor : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("discardEditing")]
	[Preserve(Conditional = true)]
	void DiscardEditing();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("commitEditing")]
	[Preserve(Conditional = true)]
	bool CommitEditing();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("commitEditingWithDelegate:didCommitSelector:contextInfo:")]
	[Preserve(Conditional = true)]
	void CommitEditing(NSObject? delegateObject, Selector? didCommitSelector, IntPtr contextInfo);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("commitEditingAndReturnError:")]
	[Preserve(Conditional = true)]
	bool CommitEditing(out NSError? error);
}
