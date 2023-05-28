using System;
using CoreFoundation;
using Foundation;

namespace AVFoundation;

[Obsolete("This API is not available on this platform.")]
public class AVCaptureDataOutputSynchronizer : NSObject
{
	public override IntPtr ClassHandle
	{
		get
		{
			throw new PlatformNotSupportedException();
		}
	}

	public virtual AVCaptureOutput[] DataOutputs
	{
		get
		{
			throw new PlatformNotSupportedException();
		}
	}

	public IAVCaptureDataOutputSynchronizerDelegate Delegate
	{
		get
		{
			throw new PlatformNotSupportedException();
		}
	}

	public virtual DispatchQueue DelegateCallbackQueue
	{
		get
		{
			throw new PlatformNotSupportedException();
		}
	}

	public virtual NSObject WeakDelegate
	{
		get
		{
			throw new PlatformNotSupportedException();
		}
	}

	protected AVCaptureDataOutputSynchronizer(NSObjectFlag t)
		: base(t)
	{
		throw new PlatformNotSupportedException();
	}

	protected internal AVCaptureDataOutputSynchronizer(IntPtr handle)
		: base(handle)
	{
		throw new PlatformNotSupportedException();
	}

	public AVCaptureDataOutputSynchronizer(AVCaptureOutput[] dataOutputs)
		: base(NSObjectFlag.Empty)
	{
		throw new PlatformNotSupportedException();
	}

	public virtual void SetDelegate(IAVCaptureDataOutputSynchronizerDelegate del, DispatchQueue delegateCallbackQueue)
	{
		throw new PlatformNotSupportedException();
	}
}
