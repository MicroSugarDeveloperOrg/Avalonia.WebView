using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSpeechSynthesizerDelegate", true)]
[Model]
public class NSSpeechSynthesizerDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSpeechSynthesizerDelegate()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSSpeechSynthesizerDelegate(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSpeechSynthesizerDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSpeechSynthesizerDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("speechSynthesizer:didFinishSpeaking:")]
	public virtual void DidFinishSpeaking(NSSpeechSynthesizer sender, bool finishedSpeaking)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechSynthesizer:willSpeakWord:ofString:")]
	public virtual void WillSpeakWord(NSSpeechSynthesizer sender, NSRange wordCharacterRange, string ofString)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechSynthesizer:willSpeakPhoneme:")]
	public virtual void WillSpeakPhoneme(NSSpeechSynthesizer sender, short phonemeOpcode)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechSynthesizer:didEncounterErrorAtIndex:ofString:message:")]
	public virtual void DidEncounterError(NSSpeechSynthesizer sender, uint characterIndex, string theString, string message)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("speechSynthesizer:didEncounterSyncMessage:")]
	public virtual void DidEncounterSyncMessage(NSSpeechSynthesizer sender, string message)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
