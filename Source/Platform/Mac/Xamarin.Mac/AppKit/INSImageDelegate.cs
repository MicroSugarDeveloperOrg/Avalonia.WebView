using CoreGraphics;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol(Name = "NSImageDelegate", WrapperType = typeof(NSImageDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ImageDidNotDraw", Selector = "imageDidNotDraw:inRect:", ReturnType = typeof(NSImage), ParameterType = new Type[]
{
	typeof(NSObject),
	typeof(CGRect)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillLoadRepresentation", Selector = "image:willLoadRepresentation:", ParameterType = new Type[]
{
	typeof(NSImage),
	typeof(NSImageRep)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLoadRepresentationHeader", Selector = "image:didLoadRepresentationHeader:", ParameterType = new Type[]
{
	typeof(NSImage),
	typeof(NSImageRep)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLoadPartOfRepresentation", Selector = "image:didLoadPartOfRepresentation:withValidRows:", ParameterType = new Type[]
{
	typeof(NSImage),
	typeof(NSImageRep),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidLoadRepresentation", Selector = "image:didLoadRepresentation:withStatus:", ParameterType = new Type[]
{
	typeof(NSImage),
	typeof(NSImageRep),
	typeof(NSImageLoadStatus)
}, ParameterByRef = new bool[] { false, false, false })]
public interface INSImageDelegate : INativeObject, IDisposable
{
}
