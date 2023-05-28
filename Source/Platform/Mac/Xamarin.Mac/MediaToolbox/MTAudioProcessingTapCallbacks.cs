using System;

namespace MediaToolbox;

public class MTAudioProcessingTapCallbacks
{
	public MTAudioProcessingTapInitCallback Initialize { get; set; }

	public new Action<MTAudioProcessingTap> Finalize { get; set; }

	public MTAudioProcessingTapPrepareCallback Prepare { get; set; }

	public Action<MTAudioProcessingTap> Unprepare { get; set; }

	public MTAudioProcessingTapProcessDelegate Processing { get; private set; }

	public MTAudioProcessingTapCallbacks(MTAudioProcessingTapProcessDelegate process)
	{
		if (process == null)
		{
			throw new ArgumentNullException("process");
		}
		Processing = process;
	}
}
