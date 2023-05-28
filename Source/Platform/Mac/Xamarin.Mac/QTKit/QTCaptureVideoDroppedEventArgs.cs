using System;

namespace QTKit;

public class QTCaptureVideoDroppedEventArgs : EventArgs
{
	public QTCaptureConnection Connection { get; set; }

	public QTSampleBuffer SampleBuffer { get; set; }

	public QTCaptureVideoDroppedEventArgs(QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
	{
		Connection = connection;
		SampleBuffer = sampleBuffer;
	}
}
