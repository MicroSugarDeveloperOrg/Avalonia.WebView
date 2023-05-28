using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace MediaPlayer;

[Register("MPContentItem", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 1, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class MPContentItem : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArtwork = "artwork";

	private static readonly IntPtr selArtworkHandle = Selector.GetHandle("artwork");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithIdentifier_ = "initWithIdentifier:";

	private static readonly IntPtr selInitWithIdentifier_Handle = Selector.GetHandle("initWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsContainer = "isContainer";

	private static readonly IntPtr selIsContainerHandle = Selector.GetHandle("isContainer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsExplicitContent = "isExplicitContent";

	private static readonly IntPtr selIsExplicitContentHandle = Selector.GetHandle("isExplicitContent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPlayable = "isPlayable";

	private static readonly IntPtr selIsPlayableHandle = Selector.GetHandle("isPlayable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsStreamingContent = "isStreamingContent";

	private static readonly IntPtr selIsStreamingContentHandle = Selector.GetHandle("isStreamingContent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlaybackProgress = "playbackProgress";

	private static readonly IntPtr selPlaybackProgressHandle = Selector.GetHandle("playbackProgress");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetArtwork_ = "setArtwork:";

	private static readonly IntPtr selSetArtwork_Handle = Selector.GetHandle("setArtwork:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContainer_ = "setContainer:";

	private static readonly IntPtr selSetContainer_Handle = Selector.GetHandle("setContainer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetExplicitContent_ = "setExplicitContent:";

	private static readonly IntPtr selSetExplicitContent_Handle = Selector.GetHandle("setExplicitContent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlayable_ = "setPlayable:";

	private static readonly IntPtr selSetPlayable_Handle = Selector.GetHandle("setPlayable:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlaybackProgress_ = "setPlaybackProgress:";

	private static readonly IntPtr selSetPlaybackProgress_Handle = Selector.GetHandle("setPlaybackProgress:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStreamingContent_ = "setStreamingContent:";

	private static readonly IntPtr selSetStreamingContent_Handle = Selector.GetHandle("setStreamingContent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSubtitle_ = "setSubtitle:";

	private static readonly IntPtr selSetSubtitle_Handle = Selector.GetHandle("setSubtitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitle_ = "setTitle:";

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubtitle = "subtitle";

	private static readonly IntPtr selSubtitleHandle = Selector.GetHandle("subtitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MPContentItem");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual MPMediaItemArtwork Artwork
	{
		[Export("artwork")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<MPMediaItemArtwork>(Messaging.IntPtr_objc_msgSend(base.Handle, selArtworkHandle));
			}
			return Runtime.GetNSObject<MPMediaItemArtwork>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArtworkHandle));
		}
		[Export("setArtwork:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetArtwork_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetArtwork_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Container
	{
		[Export("isContainer")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsContainerHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsContainerHandle);
		}
		[Export("setContainer:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetContainer_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetContainer_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual bool ExplicitContent
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("isExplicitContent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsExplicitContentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsExplicitContentHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setExplicitContent:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetExplicitContent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetExplicitContent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Identifier
	{
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Playable
	{
		[Export("isPlayable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPlayableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPlayableHandle);
		}
		[Export("setPlayable:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPlayable_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPlayable_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float PlaybackProgress
	{
		[Export("playbackProgress")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selPlaybackProgressHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selPlaybackProgressHandle);
		}
		[Export("setPlaybackProgress:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetPlaybackProgress_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetPlaybackProgress_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	public virtual bool StreamingContent
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("isStreamingContent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsStreamingContentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsStreamingContentHandle);
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Export("setStreamingContent:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetStreamingContent_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetStreamingContent_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Subtitle
	{
		[Export("subtitle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSubtitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubtitleHandle));
		}
		[Export("setSubtitle:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubtitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubtitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Title
	{
		[Export("title")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MPContentItem(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MPContentItem(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithIdentifier:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public MPContentItem(string identifier)
		: base(NSObjectFlag.Empty)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithIdentifier_Handle, arg), "initWithIdentifier:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithIdentifier_Handle, arg), "initWithIdentifier:");
		}
		NSString.ReleaseNative(arg);
	}
}
