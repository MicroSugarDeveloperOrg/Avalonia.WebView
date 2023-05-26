using Foundation;

namespace QTKit;

public class QTCaptureDeviceTransportControl
{
	public QTCaptureDeviceControlsSpeed? Speed { get; set; }

	public QTCaptureDevicePlaybackMode? PlaybackMode { get; set; }

	public QTCaptureDeviceTransportControl()
	{
	}

	internal QTCaptureDeviceTransportControl(NSDictionary dict)
	{
		NSNumber nSNumber = (NSNumber)dict[QTCaptureDevice.AVCTransportControlsSpeedKey];
		if (nSNumber != null)
		{
			Speed = (QTCaptureDeviceControlsSpeed)nSNumber.Int32Value;
		}
		nSNumber = (NSNumber)dict[QTCaptureDevice.AVCTransportControlsPlaybackModeKey];
		if (nSNumber != null)
		{
			PlaybackMode = (QTCaptureDevicePlaybackMode)nSNumber.Int32Value;
		}
	}
}
