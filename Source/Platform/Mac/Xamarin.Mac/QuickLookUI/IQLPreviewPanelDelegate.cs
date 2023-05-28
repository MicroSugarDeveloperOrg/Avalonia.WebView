using System;
using AppKit;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace QuickLookUI;

[Protocol(Name = "QLPreviewPanelDelegate", WrapperType = typeof(QLPreviewPanelDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleEvent", Selector = "previewPanel:handleEvent:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(QLPreviewPanel),
	typeof(NSEvent)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SourceFrameOnScreenForPreviewItem", Selector = "previewPanel:sourceFrameOnScreenForPreviewItem:", ReturnType = typeof(CGRect), ParameterType = new Type[]
{
	typeof(QLPreviewPanel),
	typeof(QLPreviewItem)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "TransitionImageForPreviewItem", Selector = "previewPanel:transitionImageForPreviewItem:contentRect:", ReturnType = typeof(NSObject), ParameterType = new Type[]
{
	typeof(QLPreviewPanel),
	typeof(QLPreviewItem),
	typeof(CGRect)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IQLPreviewPanelDelegate : INativeObject, IDisposable, INSWindowDelegate
{
}
