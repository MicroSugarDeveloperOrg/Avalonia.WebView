using System;
using CoreVideo;

namespace QTKit;

public class QTCaptureVideoFrameEventArgs : EventArgs
{
	public CVImageBuffer VideoFrame { get; set; }

	public QTSampleBuffer SampleBuffer { get; set; }

	public QTCaptureConnection Connection { get; set; }

	public QTCaptureVideoFrameEventArgs(CVImageBuffer videoFrame, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
	{
		VideoFrame = videoFrame;
		SampleBuffer = sampleBuffer;
		Connection = connection;
	}
}
