using System;
using Foundation;

namespace QTKit;

public class QTCaptureFileErrorEventArgs : EventArgs
{
	public NSUrl OutputFileURL { get; set; }

	public QTCaptureConnection[] Connections { get; set; }

	public NSError Reason { get; set; }

	public QTCaptureFileErrorEventArgs(NSUrl outputFileURL, QTCaptureConnection[] connections, NSError reason)
	{
		OutputFileURL = outputFileURL;
		Connections = connections;
		Reason = reason;
	}
}
