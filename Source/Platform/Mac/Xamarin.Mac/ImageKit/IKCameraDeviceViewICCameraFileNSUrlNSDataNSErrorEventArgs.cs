using System;
using Foundation;
using ImageCaptureCore;

namespace ImageKit;

public class IKCameraDeviceViewICCameraFileNSUrlNSDataNSErrorEventArgs : EventArgs
{
	public NSData Data { get; set; }

	public NSError Error { get; set; }

	public ICCameraFile File { get; set; }

	public NSUrl Url { get; set; }

	public IKCameraDeviceViewICCameraFileNSUrlNSDataNSErrorEventArgs(ICCameraFile file, NSUrl url, NSData data, NSError error)
	{
		Data = data;
		Error = error;
		File = file;
		Url = url;
	}
}
