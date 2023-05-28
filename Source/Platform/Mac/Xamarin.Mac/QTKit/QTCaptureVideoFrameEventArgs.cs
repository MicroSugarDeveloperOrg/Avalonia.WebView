using System;
using CoreVideo;

namespace QTKit;

public class QTCaptureVideoFrameEventArgs : EventArgs
{
	public QTCaptureConnection Connection { get; set; }

	public QTSampleBuffer SampleBuffer { get; set; }

	public CVImageBuffer VideoFrame { get; set; }

	public QTCaptureVideoFrameEventArgs(CVImageBuffer videoFrame, QTSampleBuffer sampleBuffer, QTCaptureConnection connection)
	{
		Connection = connection;
		SampleBuffer = sampleBuffer;
		VideoFrame = videoFrame;
	}
}
