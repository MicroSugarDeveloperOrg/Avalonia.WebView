using System;
using Foundation;
using ImageCaptureCore;
using ObjCRuntime;

namespace ImageKit;

[Protocol(Name = "IKDeviceBrowserViewDelegate", WrapperType = typeof(IKDeviceBrowserViewDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SelectionDidChange", Selector = "deviceBrowserView:selectionDidChange:", ParameterType = new Type[]
{
	typeof(IKDeviceBrowserView),
	typeof(ICDevice)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEncounterError", Selector = "deviceBrowserView:didEncounterError:", ParameterType = new Type[]
{
	typeof(IKDeviceBrowserView),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
public interface IIKDeviceBrowserViewDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("deviceBrowserView:selectionDidChange:")]
	[Preserve(Conditional = true)]
	void SelectionDidChange(IKDeviceBrowserView deviceBrowserView, ICDevice device);
}
