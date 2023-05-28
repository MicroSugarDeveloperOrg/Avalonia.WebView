using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSPrintPanelAccessorizing", WrapperType = typeof(NSPrintPanelAccessorizingWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "LocalizedSummaryItems", Selector = "localizedSummaryItems", ReturnType = typeof(NSDictionary[]))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "KeyPathsForValuesAffectingPreview", Selector = "keyPathsForValuesAffectingPreview", ReturnType = typeof(NSSet))]
public interface INSPrintPanelAccessorizing : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("localizedSummaryItems")]
	[Preserve(Conditional = true)]
	NSDictionary[] LocalizedSummaryItems();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("keyPathsForValuesAffectingPreview")]
	[Preserve(Conditional = true)]
	NSSet KeyPathsForValuesAffectingPreview();
}
