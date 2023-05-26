using System;

namespace QTKit;

public class QTCaptureVideoDroppedEventArgs : EventArgs
{
	public QTSampleBuffer SampleBuffer { get; set; }

	public QTCaptureConnection Connection { get; set; }

	public QTCaptureVideoDroppedEventArgs(QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
	{
		SampleBuffer = sampleBuffer;
		Connection = connection;
	}
}
