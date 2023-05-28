using System;
using Foundation;
using ImageCaptureCore;

namespace ImageKit;

public class IKScannerDeviceViewScanBandDataEventArgs : EventArgs
{
	public ICScannerBandData Data { get; set; }

	public NSError Error { get; set; }

	public NSDictionary ScanInfo { get; set; }

	public IKScannerDeviceViewScanBandDataEventArgs(ICScannerBandData data, NSDictionary scanInfo, NSError error)
	{
		Data = data;
		Error = error;
		ScanInfo = scanInfo;
	}
}
