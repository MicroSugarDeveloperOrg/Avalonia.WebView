using System;

namespace QTKit;

public class QTCaptureFileSampleEventArgs : EventArgs
{
	public QTCaptureConnection Connection { get; set; }

	public QTSampleBuffer SampleBuffer { get; set; }

	public QTCaptureFileSampleEventArgs(QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
	{
		Connection = connection;
		SampleBuffer = sampleBuffer;
	}
}
