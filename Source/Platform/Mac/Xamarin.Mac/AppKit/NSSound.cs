using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSound", true)]
public class NSSound : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSPasteboardReading, INSPasteboardWriting, INSSecureCoding
{
	[Register]
	internal class _NSSoundDelegate : NSObject, INSSoundDelegate, INativeObject, IDisposable
	{
		internal EventHandler<NSSoundFinishedEventArgs>? didFinishPlaying;

		public _NSSoundDelegate()
		{
			base.IsDirectBinding = false;
		}

		[Preserve(Conditional = true)]
		[Export("sound:didFinishPlaying:")]
		public void DidFinishPlaying(NSSound sound, bool finished)
		{
			EventHandler<NSSoundFinishedEventArgs> eventHandler = didFinishPlaying;
			if (eventHandler != null)
			{
				NSSoundFinishedEventArgs e = new NSSoundFinishedEventArgs(finished);
				eventHandler(sound, e);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanInitWithPasteboard_ = "canInitWithPasteboard:";

	private static readonly IntPtr selCanInitWithPasteboard_Handle = Selector.GetHandle("canInitWithPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChannelMapping = "channelMapping";

	private static readonly IntPtr selChannelMappingHandle = Selector.GetHandle("channelMapping");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCurrentTime = "currentTime";

	private static readonly IntPtr selCurrentTimeHandle = Selector.GetHandle("currentTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfFile_ByReference_ = "initWithContentsOfFile:byReference:";

	private static readonly IntPtr selInitWithContentsOfFile_ByReference_Handle = Selector.GetHandle("initWithContentsOfFile:byReference:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfURL_ByReference_ = "initWithContentsOfURL:byReference:";

	private static readonly IntPtr selInitWithContentsOfURL_ByReference_Handle = Selector.GetHandle("initWithContentsOfURL:byReference:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_ = "initWithData:";

	private static readonly IntPtr selInitWithData_Handle = Selector.GetHandle("initWithData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPasteboard_ = "initWithPasteboard:";

	private static readonly IntPtr selInitWithPasteboard_Handle = Selector.GetHandle("initWithPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlaying = "isPlaying";

	private static readonly IntPtr selIsPlayingHandle = Selector.GetHandle("isPlaying");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoops = "loops";

	private static readonly IntPtr selLoopsHandle = Selector.GetHandle("loops");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selName = "name";

	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteboardPropertyListForType_ = "pasteboardPropertyListForType:";

	private static readonly IntPtr selPasteboardPropertyListForType_Handle = Selector.GetHandle("pasteboardPropertyListForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPause = "pause";

	private static readonly IntPtr selPauseHandle = Selector.GetHandle("pause");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlay = "play";

	private static readonly IntPtr selPlayHandle = Selector.GetHandle("play");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaybackDeviceIdentifier = "playbackDeviceIdentifier";

	private static readonly IntPtr selPlaybackDeviceIdentifierHandle = Selector.GetHandle("playbackDeviceIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadableTypesForPasteboard_ = "readableTypesForPasteboard:";

	private static readonly IntPtr selReadableTypesForPasteboard_Handle = Selector.GetHandle("readableTypesForPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadingOptionsForType_Pasteboard_ = "readingOptionsForType:pasteboard:";

	private static readonly IntPtr selReadingOptionsForType_Pasteboard_Handle = Selector.GetHandle("readingOptionsForType:pasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selResume = "resume";

	private static readonly IntPtr selResumeHandle = Selector.GetHandle("resume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetChannelMapping_ = "setChannelMapping:";

	private static readonly IntPtr selSetChannelMapping_Handle = Selector.GetHandle("setChannelMapping:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCurrentTime_ = "setCurrentTime:";

	private static readonly IntPtr selSetCurrentTime_Handle = Selector.GetHandle("setCurrentTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLoops_ = "setLoops:";

	private static readonly IntPtr selSetLoops_Handle = Selector.GetHandle("setLoops:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetName_ = "setName:";

	private static readonly IntPtr selSetName_Handle = Selector.GetHandle("setName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlaybackDeviceIdentifier_ = "setPlaybackDeviceIdentifier:";

	private static readonly IntPtr selSetPlaybackDeviceIdentifier_Handle = Selector.GetHandle("setPlaybackDeviceIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVolume_ = "setVolume:";

	private static readonly IntPtr selSetVolume_Handle = Selector.GetHandle("setVolume:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSoundNamed_ = "soundNamed:";

	private static readonly IntPtr selSoundNamed_Handle = Selector.GetHandle("soundNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSoundUnfilteredTypes = "soundUnfilteredTypes";

	private static readonly IntPtr selSoundUnfilteredTypesHandle = Selector.GetHandle("soundUnfilteredTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStop = "stop";

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVolume = "volume";

	private static readonly IntPtr selVolumeHandle = Selector.GetHandle("volume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritableTypesForPasteboard_ = "writableTypesForPasteboard:";

	private static readonly IntPtr selWritableTypesForPasteboard_Handle = Selector.GetHandle("writableTypesForPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteToPasteboard_ = "writeToPasteboard:";

	private static readonly IntPtr selWriteToPasteboard_Handle = Selector.GetHandle("writeToPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWritingOptionsForType_Pasteboard_ = "writingOptionsForType:pasteboard:";

	private static readonly IntPtr selWritingOptionsForType_Pasteboard_Handle = Selector.GetHandle("writingOptionsForType:pasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXamarinselector_Removed_ = "xamarinselector:removed:";

	private static readonly IntPtr selXamarinselector_Removed_Handle = Selector.GetHandle("xamarinselector:removed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSound");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
	public virtual NSObject ChannelMapping
	{
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("channelMapping")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selChannelMappingHandle));
			}
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChannelMappingHandle));
		}
		[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.None, null)]
		[Export("setChannelMapping:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetChannelMapping_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetChannelMapping_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double CurrentTime
	{
		[Export("currentTime")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selCurrentTimeHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selCurrentTimeHandle);
		}
		[Export("setCurrentTime:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetCurrentTime_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetCurrentTime_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSSoundDelegate Delegate
	{
		get
		{
			return WeakDelegate as INSSoundDelegate;
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
	public virtual bool Loops
	{
		[Export("loops")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selLoopsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selLoopsHandle);
		}
		[Export("setLoops:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetLoops_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetLoops_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PlaybackDeviceID
	{
		[Export("playbackDeviceIdentifier")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
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
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float Volume
	{
		[Export("volume")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selVolumeHandle);
		}
		[Export("setVolume:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetVolume_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
		set
		{
			NSApplication.EnsureDelegateAssignIsNotOverwritingInternalDelegate(__mt_WeakDelegate_var, value, GetInternalEventDelegateType);
			NSApplication.EnsureUIThread();
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

	internal virtual Type GetInternalEventDelegateType => typeof(_NSSoundDelegate);

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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSSound(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSSound(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSound(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContentsOfURL:byReference:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSound(NSUrl url, bool byRef)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selInitWithContentsOfURL_ByReference_Handle, url.Handle, byRef), "initWithContentsOfURL:byReference:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selInitWithContentsOfURL_ByReference_Handle, url.Handle, byRef), "initWithContentsOfURL:byReference:");
		}
	}

	[Export("initWithContentsOfFile:byReference:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSound(string path, bool byRef)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selInitWithContentsOfFile_ByReference_Handle, arg, byRef), "initWithContentsOfFile:byReference:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selInitWithContentsOfFile_ByReference_Handle, arg, byRef), "initWithContentsOfFile:byReference:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithData:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSound(NSData data)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithData_Handle, data.Handle), "initWithData:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithData_Handle, data.Handle), "initWithData:");
		}
	}

	[Export("initWithPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSound(NSPasteboard pasteboard)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPasteboard_Handle, pasteboard.Handle), "initWithPasteboard:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPasteboard_Handle, pasteboard.Handle), "initWithPasteboard:");
		}
	}

	[Export("canInitWithPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool CanCreateFromPasteboard(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return Messaging.bool_objc_msgSend_IntPtr(class_ptr, selCanInitWithPasteboard_Handle, pasteboard.Handle);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("duration")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double Duration()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend(base.Handle, selDurationHandle);
		}
		return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		NSApplication.EnsureUIThread();
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("soundNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSound FromName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSSound nSObject = Runtime.GetNSObject<NSSound>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSoundNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("name")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual string GetName()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
	}

	[Export("pasteboardPropertyListForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetPasteboardPropertyListForType(string type)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteboardPropertyListForType_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPasteboardPropertyListForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("readableTypesForPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetReadableTypesForPasteboard(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selReadableTypesForPasteboard_Handle, pasteboard.Handle));
	}

	[Export("readingOptionsForType:pasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSPasteboardReadingOptions GetReadingOptionsForType(string type, NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSPasteboardReadingOptions result = (NSPasteboardReadingOptions)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(class_ptr, selReadingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writableTypesForPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetWritableTypesForPasteboard(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selWritableTypesForPasteboard_Handle, pasteboard.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selWritableTypesForPasteboard_Handle, pasteboard.Handle));
	}

	[Export("writingOptionsForType:pasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPasteboardWritingOptions GetWritingOptionsForType(string type, NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSPasteboardWritingOptions result = (NSPasteboardWritingOptions)((!base.IsDirectBinding) ? Messaging.UInt64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWritingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle) : Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(base.Handle, selWritingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("xamarinselector:removed:")]
	[Obsolete("It will never be called.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject InitWithPasteboardPropertyList(NSObject propertyList, string type)
	{
		NSApplication.EnsureUIThread();
		if (propertyList == null)
		{
			throw new ArgumentNullException("propertyList");
		}
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selXamarinselector_Removed_Handle, propertyList.Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selXamarinselector_Removed_Handle, propertyList.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isPlaying")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsPlaying()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selIsPlayingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlayingHandle);
	}

	[Export("pause")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Pause()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selPauseHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPauseHandle);
	}

	[Export("play")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Play()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selPlayHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPlayHandle);
	}

	[Export("resume")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Resume()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selResumeHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selResumeHandle);
	}

	[Export("setName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual bool SetName(string name)
	{
		NSApplication.EnsureUIThread();
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetName_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetName_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("soundUnfilteredTypes")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] SoundUnfilteredTypes()
	{
		NSApplication.EnsureUIThread();
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selSoundUnfilteredTypesHandle));
	}

	[Export("stop")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Stop()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selStopHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selStopHandle);
	}

	[Export("writeToPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WriteToPasteboard(NSPasteboard pasteboard)
	{
		NSApplication.EnsureUIThread();
		if (pasteboard == null)
		{
			throw new ArgumentNullException("pasteboard");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWriteToPasteboard_Handle, pasteboard.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteToPasteboard_Handle, pasteboard.Handle);
		}
	}

	internal virtual _NSSoundDelegate CreateInternalEventDelegateType()
	{
		return new _NSSoundDelegate();
	}

	internal _NSSoundDelegate EnsureNSSoundDelegate()
	{
		if (WeakDelegate != null)
		{
			NSApplication.EnsureEventAndDelegateAreNotMismatched(WeakDelegate, GetInternalEventDelegateType);
		}
		_NSSoundDelegate nSSoundDelegate = Delegate as _NSSoundDelegate;
		if (nSSoundDelegate == null)
		{
			nSSoundDelegate = (_NSSoundDelegate)(Delegate = CreateInternalEventDelegateType());
		}
		return nSSoundDelegate;
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
