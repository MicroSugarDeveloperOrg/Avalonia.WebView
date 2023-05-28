using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Protocol]
[Register("AVSpeechSynthesizerDelegate", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
public class AVSpeechSynthesizerDelegate : NSObject, IAVSpeechSynthesizerDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVSpeechSynthesizerDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVSpeechSynthesizerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVSpeechSynthesizerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("speechSynthesizer:didCancelSpeechUtterance:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidCancelSpeechUtterance(AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechSynthesizer:didContinueSpeechUtterance:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidContinueSpeechUtterance(AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechSynthesizer:didFinishSpeechUtterance:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishSpeechUtterance(AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechSynthesizer:didPauseSpeechUtterance:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidPauseSpeechUtterance(AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechSynthesizer:didStartSpeechUtterance:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidStartSpeechUtterance(AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechSynthesizer:willSpeakRangeOfSpeechString:utterance:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillSpeakRangeOfSpeechString(AVSpeechSynthesizer synthesizer, NSRange characterRange, AVSpeechUtterance utterance)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
