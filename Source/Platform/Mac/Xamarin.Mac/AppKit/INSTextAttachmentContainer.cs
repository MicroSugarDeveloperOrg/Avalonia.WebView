using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
[Protocol(Name = "NSTextAttachmentContainer", WrapperType = typeof(NSTextAttachmentContainerWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetImage", Selector = "imageForBounds:textContainer:characterIndex:", ReturnType = typeof(NSImage), ParameterType = new Type[]
{
	typeof(CGRect),
	typeof(NSTextContainer),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetAttachmentBounds", Selector = "attachmentBoundsForTextContainer:proposedLineFragment:glyphPosition:characterIndex:", ReturnType = typeof(CGRect), ParameterType = new Type[]
{
	typeof(NSTextContainer),
	typeof(CGRect),
	typeof(CGPoint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false, false })]
public interface INSTextAttachmentContainer : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("imageForBounds:textContainer:characterIndex:")]
	[Preserve(Conditional = true)]
	NSImage? GetImage(CGRect imageBounds, NSTextContainer? textContainer, nuint charIndex);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("attachmentBoundsForTextContainer:proposedLineFragment:glyphPosition:characterIndex:")]
	[Preserve(Conditional = true)]
	CGRect GetAttachmentBounds(NSTextContainer? textContainer, CGRect lineFrag, CGPoint position, nuint charIndex);
}
