using System;
using Foundation;

namespace AVFoundation;

public class AVSpeechSynthesizerWillSpeakEventArgs : EventArgs
{
	public NSRange CharacterRange { get; set; }

	public AVSpeechUtterance Utterance { get; set; }

	public AVSpeechSynthesizerWillSpeakEventArgs(NSRange characterRange, AVSpeechUtterance utterance)
	{
		CharacterRange = characterRange;
		Utterance = utterance;
	}
}
