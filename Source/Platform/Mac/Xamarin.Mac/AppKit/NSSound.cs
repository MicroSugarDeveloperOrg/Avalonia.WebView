using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSound", true)]
public class NSSound : NSObject
{
	[Register]
	private sealed class _NSSoundDelegate : NSSoundDelegate
	{
		internal EventHandler<NSSoundFinishedEventArgs> didFinishPlaying;

		[Preserve(Conditional = true)]
		public override void DidFinishPlaying(NSSound sound, bool finished)
		{
			EventHandler<NSSoundFinishedEventArgs> eventHandler = didFinishPlaying;
			if (eventHandler != null)
			{
				NSSoundFinishedEventArgs e = new NSSoundFinishedEventArgs(finished);
				eventHandler(sound, e);
			}
		}
	}

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	private static readonly IntPtr selCurrentTimeHandle = Selector.GetHandle("currentTime");

	private static readonly IntPtr selSetCurrentTime_Handle = Selector.GetHandle("setCurrentTime:");

	private static readonly IntPtr selLoopsHandle = Selector.GetHandle("loops");

	private static readonly IntPtr selSetLoops_Handle = Selector.GetHandle("setLoops:");

	private static readonly IntPtr selPlaybackDeviceIdentifierHandle = Selector.GetHandle("playbackDeviceIdentifier");

	private static readonly IntPtr selSetPlaybackDeviceIdentifier_Handle = Selector.GetHandle("setPlaybackDeviceIdentifier:");

	private static readonly IntPtr selChannelMappingHandle = Selector.GetHandle("channelMapping");

	private static readonly IntPtr selSetChannelMapping_Handle = Selector.GetHandle("setChannelMapping:");

	private static readonly IntPtr selSoundNamed_Handle = Selector.GetHandle("soundNamed:");

	private static readonly IntPtr selInitWithContentsOfURLByReference_Handle = Selector.GetHandle("initWithContentsOfURL:byReference:");

	private static readonly IntPtr selInitWithContentsOfFileByReference_Handle = Selector.GetHandle("initWithContentsOfFile:byReference:");

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	private static readonly IntPtr selCanInitWithPasteboard_Handle = Selector.GetHandle("canInitWithPasteboard:");

	private static readonly IntPtr selSoundUnfilteredTypesHandle = Selector.GetHandle("soundUnfilteredTypes");

	private static readonly IntPtr selInitWithPasteboard_Handle = Selector.GetHandle("initWithPasteboard:");

	private static readonly IntPtr selWriteToPasteboard_Handle = Selector.GetHandle("writeToPasteboard:");

	private static readonly IntPtr selPlayHandle = Selector.GetHandle("play");

	private static readonly IntPtr selPauseHandle = Selector.GetHandle("pause");

	private static readonly IntPtr selResumeHandle = Selector.GetHandle("resume");

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	private static readonly IntPtr selIsPlayingHandle = Selector.GetHandle("isPlaying");

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSound");

	private object __mt_WeakDelegate_var;

	private object __mt_ChannelMapping_var;

	public string Name
	{
		get
		{
			return GetName();
		}
		set
		{
			SetName(value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSSoundDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSSoundDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual float Volume
	{
		[Export("volume")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVolumeHandle);
		}
		[Export("setVolume:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetVolume_Handle, value);
			}
		}
	}

	public virtual double CurrentTime
	{
		[Export("currentTime")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCurrentTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCurrentTimeHandle);
		}
		[Export("setCurrentTime:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetCurrentTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetCurrentTime_Handle, value);
			}
		}
	}

	public virtual bool Loops
	{
		[Export("loops")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selLoopsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selLoopsHandle);
		}
		[Export("setLoops:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLoops_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLoops_Handle, value);
			}
		}
	}

	public virtual string PlaybackDeviceID
	{
		[Export("playbackDeviceIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPlaybackDeviceIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlaybackDeviceIdentifierHandle));
		}
		[Export("setPlaybackDeviceIdentifier:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPlaybackDeviceIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPlaybackDeviceIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual NSObject ChannelMapping
	{
		[Export("channelMapping")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_ChannelMapping_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChannelMappingHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selChannelMappingHandle))));
		}
		[Export("setChannelMapping:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetChannelMapping_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetChannelMapping_Handle, value.Handle);
			}
			__mt_ChannelMapping_var = value;
		}
	}

	public event EventHandler<NSSoundFinishedEventArgs> DidFinishPlaying
	{
		add
		{
			_NSSoundDelegate nSSoundDelegate = EnsureNSSoundDelegate();
			nSSoundDelegate.didFinishPlaying = (EventHandler<NSSoundFinishedEventArgs>)System.Delegate.Combine(nSSoundDelegate.didFinishPlaying, value);
		}
		remove
		{
			_NSSoundDelegate nSSoundDelegate = EnsureNSSoundDelegate();
			nSSoundDelegate.didFinishPlaying = (EventHandler<NSSoundFinishedEventArgs>)System.Delegate.Remove(nSSoundDelegate.didFinishPlaying, value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSSound(NSCoder coder)
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
	public NSSound(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSound(IntPtr handle)
		: base(handle)
	{
	}

	[Export("soundNamed:")]
	public static NSSound FromName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSSound result = (NSSound)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSoundNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithContentsOfURL:byReference:")]
	public NSSound(NSUrl url, bool byRef)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selInitWithContentsOfURLByReference_Handle, url.Handle, byRef);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selInitWithContentsOfURLByReference_Handle, url.Handle, byRef);
		}
	}

	[Export("initWithContentsOfFile:byReference:")]
	public NSSound(string path, bool byRef)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selInitWithContentsOfFileByReference_Handle, arg, byRef);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selInitWithContentsOfFileByReference_Handle, arg, byRef);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithData:")]
	public NSSound(NSData data)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithData_Handle, data.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithData_Handle, data.Handle);
		}
	}

	[Export("canInitWithPasteboard:")]
	public static bool CanCreateFromPasteboard(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanInitWithPasteboard_Handle, pasteboard.Handle);
	}

	[Export("soundUnfilteredTypes")]
	public static string[] SoundUnfilteredTypes()
	{
		NSApplication.EnsureUIThread();
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selSoundUnfilteredTypesHandle));
	}

	[Export("initWithPasteboard:")]
	public NSSound(NSPasteboard pasteboard)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPasteboard_Handle, pasteboard.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPasteboard_Handle, pasteboard.Handle);
		}
	}

	[Export("writeToPasteboard:")]
	public virtual void WriteToPasteboard(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWriteToPasteboard_Handle, pasteboard.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteToPasteboard_Handle, pasteboard.Handle);
		}
	}

	[Export("play")]
	public virtual bool Play()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selPlayHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPlayHandle);
	}

	[Export("pause")]
	public virtual bool Pause()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selPauseHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPauseHandle);
	}

	[Export("resume")]
	public virtual bool Resume()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selResumeHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selResumeHandle);
	}

	[Export("stop")]
	public virtual bool Stop()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selStopHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selStopHandle);
	}

	[Export("isPlaying")]
	public virtual bool IsPlaying()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selIsPlayingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlayingHandle);
	}

	[Export("duration")]
	public virtual double Duration()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
		}
		return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
	}

	[Export("name")]
	protected virtual string GetName()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
	}

	[Export("setName:")]
	protected virtual bool SetName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	private _NSSoundDelegate EnsureNSSoundDelegate()
	{
		NSObject nSObject = WeakDelegate;
		if (nSObject == null || !(nSObject is _NSSoundDelegate))
		{
			nSObject = (WeakDelegate = new _NSSoundDelegate());
		}
		return (_NSSoundDelegate)nSObject;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
			__mt_ChannelMapping_var = null;
		}
	}
}
