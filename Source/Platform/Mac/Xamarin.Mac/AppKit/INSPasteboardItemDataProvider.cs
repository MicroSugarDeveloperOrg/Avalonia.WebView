using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSPasteboardItemDataProvider", WrapperType = typeof(NSPasteboardItemDataProviderWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ProvideDataForType", Selector = "pasteboard:item:provideDataForType:", ParameterType = new Type[]
{
	typeof(NSPasteboard),
	typeof(NSPasteboardItem),
	typeof(string)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "FinishedWithDataProvider", Selector = "pasteboardFinishedWithDataProvider:", ParameterType = new Type[] { typeof(NSPasteboard) }, ParameterByRef = new bool[] { false })]
public interface INSPasteboardItemDataProvider : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("pasteboard:item:provideDataForType:")]
	[Preserve(Conditional = true)]
	void ProvideDataForType(NSPasteboard pasteboard, NSPasteboardItem item, string type);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("pasteboardFinishedWithDataProvider:")]
	[Preserve(Conditional = true)]
	void FinishedWithDataProvider(NSPasteboard pasteboard);
}
