using System;
using System.ComponentModel;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureAudioDataOutput", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class AVCaptureAudioDataOutput : AVCaptureOutput
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioSettings = "audioSettings";

	private static readonly IntPtr selAudioSettingsHandle = Selector.GetHandle("audioSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecommendedAudioSettingsForAssetWriterWithOutputFileType_ = "recommendedAudioSettingsForAssetWriterWithOutputFileType:";

	private static readonly IntPtr selRecommendedAudioSettingsForAssetWriterWithOutputFileType_Handle = Selector.GetHandle("recommendedAudioSettingsForAssetWriterWithOutputFileType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleBufferCallbackQueue = "sampleBufferCallbackQueue";

	private static readonly IntPtr selSampleBufferCallbackQueueHandle = Selector.GetHandle("sampleBufferCallbackQueue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleBufferDelegate = "sampleBufferDelegate";

	private static readonly IntPtr selSampleBufferDelegateHandle = Selector.GetHandle("sampleBufferDelegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioSettings_ = "setAudioSettings:";

	private static readonly IntPtr selSetAudioSettings_Handle = Selector.GetHandle("setAudioSettings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSampleBufferDelegate_Queue_ = "setSampleBufferDelegate:queue:";

	private static readonly IntPtr selSetSampleBufferDelegate_Queue_Handle = Selector.GetHandle("setSampleBufferDelegate:queue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureAudioDataOutput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	public AudioSettings? AudioSettings
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakAudioSettings != null) ? new NSMutableDictionary(WeakAudioSettings) : null);
			return (nSMutableDictionary == null) ? null : new AudioSettings(nSMutableDictionary);
		}
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		set
		{
			WeakAudioSettings = value.GetDictionary();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DispatchQueue? SampleBufferCallbackQueue
	{
		[Export("sampleBufferCallbackQueue")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSampleBufferCallbackQueueHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selSampleBufferCallbackQueueHandle));
			return (intPtr == IntPtr.Zero) ? null : new DispatchQueue(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IAVCaptureAudioDataOutputSampleBufferDelegate? SampleBufferDelegate
	{
		[Export("sampleBufferDelegate")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<IAVCaptureAudioDataOutputSampleBufferDelegate>(Messaging.IntPtr_objc_msgSend(base.Handle, selSampleBufferDelegateHandle), owns: false);
			}
			return Runtime.GetINativeObject<IAVCaptureAudioDataOutputSampleBufferDelegate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSampleBufferDelegateHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	public virtual NSDictionary? WeakAudioSettings
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Export("audioSettings", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioSettingsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioSettingsHandle));
		}
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Export("setAudioSettings:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAudioSettings_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAudioSettings_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureAudioDataOutput()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVCaptureAudioDataOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureAudioDataOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("recommendedAudioSettingsForAssetWriterWithOutputFileType:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? GetRecommendedAudioSettingsForAssetWriter(string outputFileType)
	{
		if (outputFileType == null)
		{
			throw new ArgumentNullException("outputFileType");
		}
		IntPtr arg = NSString.CreateNative(outputFileType);
		NSDictionary result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRecommendedAudioSettingsForAssetWriterWithOutputFileType_Handle, arg)) : Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRecommendedAudioSettingsForAssetWriterWithOutputFileType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetSampleBufferDelegateQueue(IAVCaptureAudioDataOutputSampleBufferDelegate? sampleBufferDelegate, DispatchQueue? sampleBufferCallbackDispatchQueue)
	{
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetSampleBufferDelegate_Queue_Handle, sampleBufferDelegate?.Handle ?? IntPtr.Zero, (sampleBufferCallbackDispatchQueue == null) ? IntPtr.Zero : sampleBufferCallbackDispatchQueue.Handle);
	}

	[Export("setSampleBufferDelegate:queue:")]
	[Obsolete("Use overload accepting a 'IAVCaptureVideoDataOutputSampleBufferDelegate'.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetSampleBufferDelegateQueue(AVCaptureAudioDataOutputSampleBufferDelegate? sampleBufferDelegate, DispatchQueue? sampleBufferCallbackDispatchQueue)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetSampleBufferDelegate_Queue_Handle, sampleBufferDelegate?.Handle ?? IntPtr.Zero, (sampleBufferCallbackDispatchQueue == null) ? IntPtr.Zero : sampleBufferCallbackDispatchQueue.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetSampleBufferDelegate_Queue_Handle, sampleBufferDelegate?.Handle ?? IntPtr.Zero, (sampleBufferCallbackDispatchQueue == null) ? IntPtr.Zero : sampleBufferCallbackDispatchQueue.Handle);
		}
	}
}
