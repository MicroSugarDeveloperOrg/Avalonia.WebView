using System;
using Foundation;

namespace QTKit;

public class QTCaptureFileUrlEventArgs : EventArgs
{
	public NSUrl FileUrl { get; set; }

	public QTCaptureConnection[] Connections { get; set; }

	public QTCaptureFileUrlEventArgs(NSUrl fileUrl, QTCaptureConnection[] connections)
	{
		FileUrl = fileUrl;
		Connections = connections;
	}
}
