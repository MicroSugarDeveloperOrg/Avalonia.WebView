using System;
using Foundation;

namespace QTKit;

public class QTCaptureFileUrlEventArgs : EventArgs
{
	public QTCaptureConnection[] Connections { get; set; }

	public NSUrl FileUrl { get; set; }

	public QTCaptureFileUrlEventArgs(NSUrl fileUrl, QTCaptureConnection[] connections)
	{
		Connections = connections;
		FileUrl = fileUrl;
	}
}
