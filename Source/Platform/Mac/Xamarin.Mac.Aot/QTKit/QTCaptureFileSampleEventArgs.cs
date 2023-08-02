using System;

namespace QTKit;

public class QTCaptureFileSampleEventArgs : EventArgs
{
	public QTSampleBuffer SampleBuffer { get; set; }

	public QTCaptureConnection Connection { get; set; }

	public QTCaptureFileSampleEventArgs(QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
	{
		SampleBuffer = sampleBuffer;
		Connection = connection;
	}
}
