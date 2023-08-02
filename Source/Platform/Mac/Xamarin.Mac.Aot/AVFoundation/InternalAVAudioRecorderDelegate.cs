using System;
using Foundation;

namespace AVFoundation;

internal class InternalAVAudioRecorderDelegate : AVAudioRecorderDelegate
{
	internal EventHandler cbEndInterruption;

	internal EventHandler cbBeginInterruption;

	internal EventHandler<AVStatusEventArgs> cbFinishedRecording;

	internal EventHandler<AVErrorEventArgs> cbEncoderError;

	[Preserve(Conditional = true)]
	public override void FinishedRecording(AVAudioRecorder recorder, bool flag)
	{
		if (cbFinishedRecording != null)
		{
			cbFinishedRecording(recorder, new AVStatusEventArgs(flag));
		}
	}

	[Preserve(Conditional = true)]
	public override void EncoderError(AVAudioRecorder recorder, NSError error)
	{
		if (cbEncoderError != null)
		{
			cbEncoderError(recorder, new AVErrorEventArgs(error));
		}
	}
}
