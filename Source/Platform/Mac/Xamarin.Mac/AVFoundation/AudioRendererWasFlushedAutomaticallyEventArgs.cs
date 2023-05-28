using System;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[TV(11, 0)]
[NoWatch]
[Mac(10, 13)]
[iOS(11, 0)]
public class AudioRendererWasFlushedAutomaticallyEventArgs : NSNotificationEventArgs
{
	[Field("AVSampleBufferAudioRendererFlushTimeKey", "AVFoundation")]
	private static IntPtr k0;

	public CMTime AudioRendererFlushTime => _AudioRendererFlushTime.CMTimeValue;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal NSValue _AudioRendererFlushTime
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.AVFoundation.Handle, "AVSampleBufferAudioRendererFlushTimeKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSValue>(ptr);
		}
	}

	public AudioRendererWasFlushedAutomaticallyEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
