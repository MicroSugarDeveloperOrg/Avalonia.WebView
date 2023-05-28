using System;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Protocol(Name = "ICCameraDeviceDownloadDelegate", WrapperType = typeof(ICCameraDeviceDownloadDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidDownloadFile", Selector = "didDownloadFile:error:options:contextInfo:", ParameterType = new Type[]
{
	typeof(ICCameraFile),
	typeof(NSError),
	typeof(NSDictionary<NSString, NSObject>),
	typeof(IntPtr)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReceiveDownloadProgress", Selector = "didReceiveDownloadProgressForFile:downloadedBytes:maxBytes:", ParameterType = new Type[]
{
	typeof(ICCameraFile),
	typeof(long),
	typeof(long)
}, ParameterByRef = new bool[] { false, false, false })]
public interface IICCameraDeviceDownloadDelegate : INativeObject, IDisposable
{
}
