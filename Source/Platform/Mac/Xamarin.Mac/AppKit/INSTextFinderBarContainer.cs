using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSTextFinderBarContainer", WrapperType = typeof(NSTextFinderBarContainerWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FindBarViewDidChangeHeight", Selector = "findBarViewDidChangeHeight")]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "FindBarVisible", Selector = "findBarVisible", PropertyType = typeof(bool), GetterSelector = "isFindBarVisible", SetterSelector = "setFindBarVisible:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "FindBarView", Selector = "findBarView", PropertyType = typeof(NSView), GetterSelector = "findBarView", SetterSelector = "setFindBarView:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ContentView", Selector = "contentView", PropertyType = typeof(NSView), GetterSelector = "contentView", ArgumentSemantic = ArgumentSemantic.None)]
public interface INSTextFinderBarContainer : INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	bool FindBarVisible
	{
		[Export("isFindBarVisible")]
		get;
		[Export("setFindBarVisible:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSView FindBarView
	{
		[Export("findBarView", ArgumentSemantic.Retain)]
		get;
		[Export("setFindBarView:", ArgumentSemantic.Retain)]
		set;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("findBarViewDidChangeHeight")]
	[Preserve(Conditional = true)]
	void FindBarViewDidChangeHeight();
}
