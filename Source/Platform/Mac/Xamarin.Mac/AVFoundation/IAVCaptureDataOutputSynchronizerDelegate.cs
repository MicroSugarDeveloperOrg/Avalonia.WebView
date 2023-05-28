using System;
using ObjCRuntime;

namespace AVFoundation;

[Obsolete("This API is not available on this platform.")]
public interface IAVCaptureDataOutputSynchronizerDelegate : INativeObject, IDisposable
{
	void DidOutputSynchronizedDataCollection(AVCaptureDataOutputSynchronizer synchronizer, AVCaptureSynchronizedDataCollection synchronizedDataCollection);
}
