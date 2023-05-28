using System;
using System.ComponentModel;
using AVFoundation;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace Speech;

[Register("SFSpeechAudioBufferRecognitionRequest", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class SFSpeechAudioBufferRecognitionRequest : SFSpeechRecognitionRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendAudioPCMBuffer_ = "appendAudioPCMBuffer:";

	private static readonly IntPtr selAppendAudioPCMBuffer_Handle = Selector.GetHandle("appendAudioPCMBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendAudioSampleBuffer_ = "appendAudioSampleBuffer:";

	private static readonly IntPtr selAppendAudioSampleBuffer_Handle = Selector.GetHandle("appendAudioSampleBuffer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndAudio = "endAudio";

	private static readonly IntPtr selEndAudioHandle = Selector.GetHandle("endAudio");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNativeAudioFormat = "nativeAudioFormat";

	private static readonly IntPtr selNativeAudioFormatHandle = Selector.GetHandle("nativeAudioFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SFSpeechAudioBufferRecognitionRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioFormat NativeAudioFormat
	{
		[Export("nativeAudioFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSend(base.Handle, selNativeAudioFormatHandle));
			}
			return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNativeAudioFormatHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SFSpeechAudioBufferRecognitionRequest()
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
	protected SFSpeechAudioBufferRecognitionRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SFSpeechAudioBufferRecognitionRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("appendAudioPCMBuffer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Append(AVAudioPcmBuffer audioPcmBuffer)
	{
		if (audioPcmBuffer == null)
		{
			throw new ArgumentNullException("audioPcmBuffer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendAudioPCMBuffer_Handle, audioPcmBuffer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendAudioPCMBuffer_Handle, audioPcmBuffer.Handle);
		}
	}

	[Export("appendAudioSampleBuffer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Append(CMSampleBuffer sampleBuffer)
	{
		if (sampleBuffer == null)
		{
			throw new ArgumentNullException("sampleBuffer");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendAudioSampleBuffer_Handle, sampleBuffer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendAudioSampleBuffer_Handle, sampleBuffer.Handle);
		}
	}

	[Export("endAudio")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndAudio()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEndAudioHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEndAudioHandle);
		}
	}
}
