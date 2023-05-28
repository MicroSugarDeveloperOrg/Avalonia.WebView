using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

[Protocol]
[Register("NSSpeechSynthesizerDelegate", false)]
[Model]
public class NSSpeechSynthesizerDelegate : NSObject, INSSpeechSynthesizerDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSpeechSynthesizerDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSSpeechSynthesizerDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSpeechSynthesizerDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("speechSynthesizer:didEncounterErrorAtIndex:ofString:message:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEncounterError(NSSpeechSynthesizer sender, nuint characterIndex, string theString, string message)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechSynthesizer:didEncounterSyncMessage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidEncounterSyncMessage(NSSpeechSynthesizer sender, string message)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechSynthesizer:didFinishSpeaking:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidFinishSpeaking(NSSpeechSynthesizer sender, bool finishedSpeaking)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechSynthesizer:willSpeakPhoneme:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillSpeakPhoneme(NSSpeechSynthesizer sender, short phonemeOpcode)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechSynthesizer:willSpeakWord:ofString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillSpeakWord(NSSpeechSynthesizer sender, NSRange wordCharacterRange, string ofString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
