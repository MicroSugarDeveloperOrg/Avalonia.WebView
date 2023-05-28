using System;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Obsolete("This API is not available on this platform.")]
public abstract class AVCaptureDataOutputSynchronizerDelegate : NSObject, IAVCaptureDataOutputSynchronizerDelegate, INativeObject, IDisposable
{
	protected AVCaptureDataOutputSynchronizerDelegate()
		: base(NSObjectFlag.Empty)
	{
		throw new PlatformNotSupportedException();
	}

	protected AVCaptureDataOutputSynchronizerDelegate(NSObjectFlag t)
		: base(t)
	{
		throw new PlatformNotSupportedException();
	}

	protected internal AVCaptureDataOutputSynchronizerDelegate(IntPtr handle)
		: base(handle)
	{
		throw new PlatformNotSupportedException();
	}

	public abstract void DidOutputSynchronizedDataCollection(AVCaptureDataOutputSynchronizer synchronizer, AVCaptureSynchronizedDataCollection synchronizedDataCollection);
}
