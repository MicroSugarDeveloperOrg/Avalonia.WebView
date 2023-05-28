using System;

namespace AVFoundation;

public class AVSpeechSynthesizerUteranceEventArgs : EventArgs
{
	public AVSpeechUtterance Utterance { get; set; }

	public AVSpeechSynthesizerUteranceEventArgs(AVSpeechUtterance utterance)
	{
		Utterance = utterance;
	}
}
