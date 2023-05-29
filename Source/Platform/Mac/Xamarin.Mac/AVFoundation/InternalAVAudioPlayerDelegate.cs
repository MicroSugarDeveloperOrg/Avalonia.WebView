using System;
using Foundation;

namespace AVFoundation;

internal sealed class InternalAVAudioPlayerDelegate : AVAudioPlayerDelegate
{
	internal EventHandler cbEndInterruption;

	internal EventHandler cbBeginInterruption;

	internal EventHandler<AVStatusEventArgs> cbFinishedPlaying;

	internal EventHandler<AVErrorEventArgs> cbDecoderError;

	[Preserve(Conditional = true)]
	public override void FinishedPlaying(AVAudioPlayer player, bool flag)
	{
		if (cbFinishedPlaying != null)
		{
			cbFinishedPlaying(player, new AVStatusEventArgs(flag));
		}
		if (player.Handle == IntPtr.Zero)
		{
			throw new ObjectDisposedException("player", "the player object was Dispose()d during the callback, this has corrupted the state of the program");
		}
	}

	[Preserve(Conditional = true)]
	public override void DecoderError(AVAudioPlayer player, NSError error)
	{
		if (cbDecoderError != null)
		{
			cbDecoderError(player, new AVErrorEventArgs(error));
		}
	}
}
