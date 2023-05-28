using System;
using Foundation;
using ImageCaptureCore;
using ObjCRuntime;

namespace ImageKit;

[Protocol(Name = "IKCameraDeviceViewDelegate", WrapperType = typeof(IKCameraDeviceViewDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionDidChange", Selector = "cameraDeviceViewSelectionDidChange:", ParameterType = new Type[] { typeof(IKCameraDeviceView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDownloadFile", Selector = "cameraDeviceView:didDownloadFile:location:fileData:error:", ParameterType = new Type[]
{
	typeof(IKCameraDeviceView),
	typeof(ICCameraFile),
	typeof(NSUrl),
	typeof(NSData),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidEncounterError", Selector = "cameraDeviceView:didEncounterError:", ParameterType = new Type[]
{
	typeof(IKCameraDeviceView),
	typeof(NSError)
}, ParameterByRef = new bool[] { false, false })]
public interface IIKCameraDeviceViewDelegate : INativeObject, IDisposable
{
}
