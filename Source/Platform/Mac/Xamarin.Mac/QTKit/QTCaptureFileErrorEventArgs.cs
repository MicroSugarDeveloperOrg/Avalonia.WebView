using System;
using Foundation;

namespace QTKit;

public class QTCaptureFileErrorEventArgs : EventArgs
{
	public QTCaptureConnection[] Connections { get; set; }

	public NSUrl OutputFileURL { get; set; }

	public NSError Reason { get; set; }

	public QTCaptureFileErrorEventArgs(NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
	{
		Connections = connections;
		OutputFileURL = outputFileURL;
		Reason = reason;
	}
}
