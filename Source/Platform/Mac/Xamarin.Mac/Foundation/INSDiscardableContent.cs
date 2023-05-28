using System;
using ObjCRuntime;

namespace Foundation;

[Protocol(Name = "NSDiscardableContent", WrapperType = typeof(NSDiscardableContentWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "BeginContentAccess", Selector = "beginContentAccess", ReturnType = typeof(bool))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "EndContentAccess", Selector = "endContentAccess")]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DiscardContentIfPossible", Selector = "discardContentIfPossible")]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "IsContentDiscarded", Selector = "isContentDiscarded", PropertyType = typeof(bool), GetterSelector = "isContentDiscarded", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSDiscardableContent : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	bool IsContentDiscarded
	{
		[Export("isContentDiscarded")]
		get;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("beginContentAccess")]
	[Preserve(Conditional = true)]
	bool BeginContentAccess();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("endContentAccess")]
	[Preserve(Conditional = true)]
	void EndContentAccess();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("discardContentIfPossible")]
	[Preserve(Conditional = true)]
	void DiscardContentIfPossible();
}
