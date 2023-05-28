using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Protocol(Name = "NSPasteboardTypeOwner", WrapperType = typeof(NSPasteboardTypeOwnerWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ProvideData", Selector = "pasteboard:provideDataForType:", ParameterType = new Type[]
{
	typeof(NSPasteboard),
	typeof(string)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PasteboardChangedOwner", Selector = "pasteboardChangedOwner:", ParameterType = new Type[] { typeof(NSPasteboard) }, ParameterByRef = new bool[] { false })]
public interface INSPasteboardTypeOwner : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("pasteboard:provideDataForType:")]
	[Preserve(Conditional = true)]
	void ProvideData(NSPasteboard sender, string type);
}
