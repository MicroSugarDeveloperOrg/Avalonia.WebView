using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSSharingServiceDelegate", WrapperType = typeof(NSSharingServiceDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillShareItems", Selector = "sharingService:willShareItems:", ParameterType = new Type[]
{
	typeof(NSSharingService),
	typeof(NSObject[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidFailToShareItems", Selector = "sharingService:didFailToShareItems:error:", ParameterType = new Type[]
{
	typeof(NSSharingService),
	typeof(NSObject[]),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidShareItems", Selector = "sharingService:didShareItems:", ParameterType = new Type[]
{
	typeof(NSSharingService),
	typeof(NSObject[])
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SourceFrameOnScreenForShareItem", Selector = "sharingService:sourceFrameOnScreenForShareItem:", ReturnType = typeof(CGRect), ParameterType = new Type[]
{
	typeof(NSSharingService),
	typeof(INSPasteboardWriting)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TransitionImageForShareItem", Selector = "sharingService:transitionImageForShareItem:contentRect:", ReturnType = typeof(NSImage), ParameterType = new Type[]
{
	typeof(NSSharingService),
	typeof(INSPasteboardWriting),
	typeof(CGRect)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SourceWindowForShareItems", Selector = "sharingService:sourceWindowForShareItems:sharingContentScope:", ReturnType = typeof(NSWindow), ParameterType = new Type[]
{
	typeof(NSSharingService),
	typeof(NSObject[]),
	typeof(NSSharingContentScope)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CreateAnchoringView", Selector = "anchoringViewForSharingService:showRelativeToRect:preferredEdge:", ReturnType = typeof(NSView), ParameterType = new Type[]
{
	typeof(NSSharingService),
	typeof(CGRect),
	typeof(NSRectEdge)
}, ParameterByRef = new bool[] { false, true, true })]
public interface INSSharingServiceDelegate : INativeObject, IDisposable
{
}
