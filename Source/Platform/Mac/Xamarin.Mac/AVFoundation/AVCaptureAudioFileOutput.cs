using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureAudioFileOutput", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public class AVCaptureAudioFileOutput : AVCaptureFileOutput
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioSettings = "audioSettings";

	private static readonly IntPtr selAudioSettingsHandle = Selector.GetHandle("audioSettings");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableOutputFileTypes = "availableOutputFileTypes";

	private static readonly IntPtr selAvailableOutputFileTypesHandle = Selector.GetHandle("availableOutputFileTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMetadata = "metadata";

	private static readonly IntPtr selMetadataHandle = Selector.GetHandle("metadata");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioSettings_ = "setAudioSettings:";

	private static readonly IntPtr selSetAudioSettings_Handle = Selector.GetHandle("setAudioSettings:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMetadata_ = "setMetadata:";

	private static readonly IntPtr selSetMetadata_Handle = Selector.GetHandle("setMetadata:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartRecordingToOutputFileURL_OutputFileType_RecordingDelegate_ = "startRecordingToOutputFileURL:outputFileType:recordingDelegate:";

	private static readonly IntPtr selStartRecordingToOutputFileURL_OutputFileType_RecordingDelegate_Handle = Selector.GetHandle("startRecordingToOutputFileURL:outputFileType:recordingDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVCaptureAudioFileOutput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AudioSettings? AudioSettings
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakAudioSettings != null) ? new NSMutableDictionary(WeakAudioSettings) : null);
			return (nSMutableDictionary == null) ? null : new AudioSettings(nSMutableDictionary);
		}
		set
		{
			WeakAudioSettings = value.GetDictionary();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVMetadataItem[] Metadata
	{
		[Export("metadata", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selMetadataHandle));
			}
			return NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMetadataHandle));
		}
		[Export("setMetadata:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMetadata_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMetadata_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? WeakAudioSettings
	{
		[Export("audioSettings", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAudioSettingsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAudioSettingsHandle));
		}
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
	public AVCaptureAudioFileOutput()
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
	protected AVCaptureAudioFileOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVCaptureAudioFileOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("availableOutputFileTypes")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString[] AvailableOutputFileTypes()
	{
		return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(class_ptr, selAvailableOutputFileTypesHandle));
	}

	[Export("startRecordingToOutputFileURL:outputFileType:recordingDelegate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StartRecording(NSUrl outputFileUrl, string fileType, IAVCaptureFileOutputRecordingDelegate recordingDelegate)
	{
		if (outputFileUrl == null)
		{
			throw new ArgumentNullException("outputFileUrl");
		}
		if (fileType == null)
		{
			throw new ArgumentNullException("fileType");
		}
		if (recordingDelegate != null)
		{
			if (!(recordingDelegate is NSObject))
			{
				throw new ArgumentException("The object passed of type " + recordingDelegate.GetType()?.ToString() + " does not derive from NSObject");
			}
			IntPtr arg = NSString.CreateNative(fileType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selStartRecordingToOutputFileURL_OutputFileType_RecordingDelegate_Handle, outputFileUrl.Handle, arg, recordingDelegate.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selStartRecordingToOutputFileURL_OutputFileType_RecordingDelegate_Handle, outputFileUrl.Handle, arg, recordingDelegate.Handle);
			}
			NSString.ReleaseNative(arg);
			return;
		}
		throw new ArgumentNullException("recordingDelegate");
	}
}
