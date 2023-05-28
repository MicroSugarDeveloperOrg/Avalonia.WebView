using System;
using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVSpeechSynthesizer", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class AVSpeechSynthesizer : NSObject
{
	[Register]
	internal class _AVSpeechSynthesizerDelegate : NSObject, IAVSpeechSynthesizerDelegate, INativeObject, IDisposable
	{
		internal EventHandler<AVSpeechSynthesizerUteranceEventArgs>? didCancelSpeechUtterance;

		internal EventHandler<AVSpeechSynthesizerUteranceEventArgs>? didContinueSpeechUtterance;

		internal EventHandler<AVSpeechSynthesizerUteranceEventArgs>? didFinishSpeechUtterance;

		internal EventHandler<AVSpeechSynthesizerUteranceEventArgs>? didPauseSpeechUtterance;

		internal EventHandler<AVSpeechSynthesizerUteranceEventArgs>? didStartSpeechUtterance;

		internal EventHandler<AVSpeechSynthesizerWillSpeakEventArgs>? willSpeakRangeOfSpeechString;

		public _AVSpeechSynthesizerDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("speechSynthesizer:didCancelSpeechUtterance:")]
		public void DidCancelSpeechUtterance(AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			EventHandler<AVSpeechSynthesizerUteranceEventArgs> eventHandler = didCancelSpeechUtterance;
			if (eventHandler != null)
			{
				AVSpeechSynthesizerUteranceEventArgs e = new AVSpeechSynthesizerUteranceEventArgs(utterance);
				eventHandler(synthesizer, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("speechSynthesizer:didContinueSpeechUtterance:")]
		public void DidContinueSpeechUtterance(AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			EventHandler<AVSpeechSynthesizerUteranceEventArgs> eventHandler = didContinueSpeechUtterance;
			if (eventHandler != null)
			{
				AVSpeechSynthesizerUteranceEventArgs e = new AVSpeechSynthesizerUteranceEventArgs(utterance);
				eventHandler(synthesizer, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("speechSynthesizer:didFinishSpeechUtterance:")]
		public void DidFinishSpeechUtterance(AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			EventHandler<AVSpeechSynthesizerUteranceEventArgs> eventHandler = didFinishSpeechUtterance;
			if (eventHandler != null)
			{
				AVSpeechSynthesizerUteranceEventArgs e = new AVSpeechSynthesizerUteranceEventArgs(utterance);
				eventHandler(synthesizer, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("speechSynthesizer:didPauseSpeechUtterance:")]
		public void DidPauseSpeechUtterance(AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			EventHandler<AVSpeechSynthesizerUteranceEventArgs> eventHandler = didPauseSpeechUtterance;
			if (eventHandler != null)
			{
				AVSpeechSynthesizerUteranceEventArgs e = new AVSpeechSynthesizerUteranceEventArgs(utterance);
				eventHandler(synthesizer, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("speechSynthesizer:didStartSpeechUtterance:")]
		public void DidStartSpeechUtterance(AVSpeechSynthesizer synthesizer, AVSpeechUtterance utterance)
		{
			EventHandler<AVSpeechSynthesizerUteranceEventArgs> eventHandler = didStartSpeechUtterance;
			if (eventHandler != null)
			{
				AVSpeechSynthesizerUteranceEventArgs e = new AVSpeechSynthesizerUteranceEventArgs(utterance);
				eventHandler(synthesizer, e);
			}
		}

		[Preserve(Conditional = true)]
		[Export("speechSynthesizer:willSpeakRangeOfSpeechString:utterance:")]
		public void WillSpeakRangeOfSpeechString(AVSpeechSynthesizer synthesizer, NSRange characterRange, AVSpeechUtterance utterance)
		{
			EventHandler<AVSpeechSynthesizerWillSpeakEventArgs> eventHandler = willSpeakRangeOfSpeechString;
			if (eventHandler != null)
			{
				AVSpeechSynthesizerWillSpeakEventArgs e = new AVSpeechSynthesizerWillSpeakEventArgs(characterRange, utterance);
				eventHandler(synthesizer, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContinueSpeaking = "continueSpeaking";

	private static readonly IntPtr selContinueSpeakingHandle = Selector.GetHandle("continueSpeaking");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPaused = "isPaused";

	private static readonly IntPtr selIsPausedHandle = Selector.GetHandle("isPaused");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSpeaking = "isSpeaking";

	private static readonly IntPtr selIsSpeakingHandle = Selector.GetHandle("isSpeaking");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPauseSpeakingAtBoundary_ = "pauseSpeakingAtBoundary:";

	private static readonly IntPtr selPauseSpeakingAtBoundary_Handle = Selector.GetHandle("pauseSpeakingAtBoundary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpeakUtterance_ = "speakUtterance:";

	private static readonly IntPtr selSpeakUtterance_Handle = Selector.GetHandle("speakUtterance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStopSpeakingAtBoundary_ = "stopSpeakingAtBoundary:";

	private static readonly IntPtr selStopSpeakingAtBoundary_Handle = Selector.GetHandle("stopSpeakingAtBoundary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteUtterance_ToBufferCallback_ = "writeUtterance:toBufferCallback:";

	private static readonly IntPtr selWriteUtterance_ToBufferCallback_Handle = Selector.GetHandle("writeUtterance:toBufferCallback:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVSpeechSynthesizer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IAVSpeechSynthesizerDelegate? Delegate
	{
		get
		{
			return WeakDelegate as IAVSpeechSynthesizerDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Paused
	{
		[Export("isPaused")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPausedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPausedHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Speaking
	{
		[Export("isSpeaking")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsSpeakingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsSpeakingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	internal virtual Type GetInternalEventDelegateType => typeof(_AVSpeechSynthesizerDelegate);

	public event EventHandler<AVSpeechSynthesizerUteranceEventArgs> DidCancelSpeechUtterance
	{
		add
		{
			_AVSpeechSynthesizerDelegate aVSpeechSynthesizerDelegate = EnsureAVSpeechSynthesizerDelegate();
			aVSpeechSynthesizerDelegate.didCancelSpeechUtterance = (EventHandler<AVSpeechSynthesizerUteranceEventArgs>)System.Delegate.Combine(aVSpeechSynthesizerDelegate.didCancelSpeechUtterance, value);
		}
		remove
		{
			_AVSpeechSynthesizerDelegate aVSpeechSynthesizerDelegate = EnsureAVSpeechSynthesizerDelegate();
			aVSpeechSynthesizerDelegate.didCancelSpeechUtterance = (EventHandler<AVSpeechSynthesizerUteranceEventArgs>)System.Delegate.Remove(aVSpeechSynthesizerDelegate.didCancelSpeechUtterance, value);
		}
	}

	public event EventHandler<AVSpeechSynthesizerUteranceEventArgs> DidContinueSpeechUtterance
	{
		add
		{
			_AVSpeechSynthesizerDelegate aVSpeechSynthesizerDelegate = EnsureAVSpeechSynthesizerDelegate();
			aVSpeechSynthesizerDelegate.didContinueSpeechUtterance = (EventHandler<AVSpeechSynthesizerUteranceEventArgs>)System.Delegate.Combine(aVSpeechSynthesizerDelegate.didContinueSpeechUtterance, value);
		}
		remove
		{
			_AVSpeechSynthesizerDelegate aVSpeechSynthesizerDelegate = EnsureAVSpeechSynthesizerDelegate();
			aVSpeechSynthesizerDelegate.didContinueSpeechUtterance = (EventHandler<AVSpeechSynthesizerUteranceEventArgs>)System.Delegate.Remove(aVSpeechSynthesizerDelegate.didContinueSpeechUtterance, value);
		}
	}

	public event EventHandler<AVSpeechSynthesizerUteranceEventArgs> DidFinishSpeechUtterance
	{
		add
		{
			_AVSpeechSynthesizerDelegate aVSpeechSynthesizerDelegate = EnsureAVSpeechSynthesizerDelegate();
			aVSpeechSynthesizerDelegate.didFinishSpeechUtterance = (EventHandler<AVSpeechSynthesizerUteranceEventArgs>)System.Delegate.Combine(aVSpeechSynthesizerDelegate.didFinishSpeechUtterance, value);
		}
		remove
		{
			_AVSpeechSynthesizerDelegate aVSpeechSynthesizerDelegate = EnsureAVSpeechSynthesizerDelegate();
			aVSpeechSynthesizerDelegate.didFinishSpeechUtterance = (EventHandler<AVSpeechSynthesizerUteranceEventArgs>)System.Delegate.Remove(aVSpeechSynthesizerDelegate.didFinishSpeechUtterance, value);
		}
	}

	public event EventHandler<AVSpeechSynthesizerUteranceEventArgs> DidPauseSpeechUtterance
	{
		add
		{
			_AVSpeechSynthesizerDelegate aVSpeechSynthesizerDelegate = EnsureAVSpeechSynthesizerDelegate();
			aVSpeechSynthesizerDelegate.didPauseSpeechUtterance = (EventHandler<AVSpeechSynthesizerUteranceEventArgs>)System.Delegate.Combine(aVSpeechSynthesizerDelegate.didPauseSpeechUtterance, value);
		}
		remove
		{
			_AVSpeechSynthesizerDelegate aVSpeechSynthesizerDelegate = EnsureAVSpeechSynthesizerDelegate();
			aVSpeechSynthesizerDelegate.didPauseSpeechUtterance = (EventHandler<AVSpeechSynthesizerUteranceEventArgs>)System.Delegate.Remove(aVSpeechSynthesizerDelegate.didPauseSpeechUtterance, value);
		}
	}

	public event EventHandler<AVSpeechSynthesizerUteranceEventArgs> DidStartSpeechUtterance
	{
		add
		{
			_AVSpeechSynthesizerDelegate aVSpeechSynthesizerDelegate = EnsureAVSpeechSynthesizerDelegate();
			aVSpeechSynthesizerDelegate.didStartSpeechUtterance = (EventHandler<AVSpeechSynthesizerUteranceEventArgs>)System.Delegate.Combine(aVSpeechSynthesizerDelegate.didStartSpeechUtterance, value);
		}
		remove
		{
			_AVSpeechSynthesizerDelegate aVSpeechSynthesizerDelegate = EnsureAVSpeechSynthesizerDelegate();
			aVSpeechSynthesizerDelegate.didStartSpeechUtterance = (EventHandler<AVSpeechSynthesizerUteranceEventArgs>)System.Delegate.Remove(aVSpeechSynthesizerDelegate.didStartSpeechUtterance, value);
		}
	}

	public event EventHandler<AVSpeechSynthesizerWillSpeakEventArgs> WillSpeakRangeOfSpeechString
	{
		add
		{
			_AVSpeechSynthesizerDelegate aVSpeechSynthesizerDelegate = EnsureAVSpeechSynthesizerDelegate();
			aVSpeechSynthesizerDelegate.willSpeakRangeOfSpeechString = (EventHandler<AVSpeechSynthesizerWillSpeakEventArgs>)System.Delegate.Combine(aVSpeechSynthesizerDelegate.willSpeakRangeOfSpeechString, value);
		}
		remove
		{
			_AVSpeechSynthesizerDelegate aVSpeechSynthesizerDelegate = EnsureAVSpeechSynthesizerDelegate();
			aVSpeechSynthesizerDelegate.willSpeakRangeOfSpeechString = (EventHandler<AVSpeechSynthesizerWillSpeakEventArgs>)System.Delegate.Remove(aVSpeechSynthesizerDelegate.willSpeakRangeOfSpeechString, value);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVSpeechSynthesizer()
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
	protected AVSpeechSynthesizer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVSpeechSynthesizer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("continueSpeaking")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ContinueSpeaking()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selContinueSpeakingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selContinueSpeakingHandle);
	}

	[Export("pauseSpeakingAtBoundary:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PauseSpeaking(AVSpeechBoundary boundary)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selPauseSpeakingAtBoundary_Handle, (long)boundary);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selPauseSpeakingAtBoundary_Handle, (long)boundary);
	}

	[Export("speakUtterance:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SpeakUtterance(AVSpeechUtterance utterance)
	{
		if (utterance == null)
		{
			throw new ArgumentNullException("utterance");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSpeakUtterance_Handle, utterance.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSpeakUtterance_Handle, utterance.Handle);
		}
	}

	[Export("stopSpeakingAtBoundary:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StopSpeaking(AVSpeechBoundary boundary)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selStopSpeakingAtBoundary_Handle, (long)boundary);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selStopSpeakingAtBoundary_Handle, (long)boundary);
	}

	[Export("writeUtterance:toBufferCallback:")]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void WriteUtterance(AVSpeechUtterance utterance, [BlockProxy(typeof(Trampolines.NIDActionArity1V6))] Action<AVAudioBuffer> bufferCallback)
	{
		if (utterance == null)
		{
			throw new ArgumentNullException("utterance");
		}
		if (bufferCallback == null)
		{
			throw new ArgumentNullException("bufferCallback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V6.Handler, bufferCallback);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selWriteUtterance_ToBufferCallback_Handle, utterance.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWriteUtterance_ToBufferCallback_Handle, utterance.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<AVAudioBuffer> WriteUtteranceAsync(AVSpeechUtterance utterance)
	{
		TaskCompletionSource<AVAudioBuffer> tcs = new TaskCompletionSource<AVAudioBuffer>();
		WriteUtterance(utterance, delegate(AVAudioBuffer obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	internal virtual _AVSpeechSynthesizerDelegate CreateInternalEventDelegateType()
	{
		return new _AVSpeechSynthesizerDelegate();
	}

	internal _AVSpeechSynthesizerDelegate EnsureAVSpeechSynthesizerDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_AVSpeechSynthesizerDelegate aVSpeechSynthesizerDelegate = Delegate as _AVSpeechSynthesizerDelegate;
		if (aVSpeechSynthesizerDelegate == null)
		{
			aVSpeechSynthesizerDelegate = (_AVSpeechSynthesizerDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return aVSpeechSynthesizerDelegate;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
