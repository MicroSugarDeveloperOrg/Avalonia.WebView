using System;
using System.ComponentModel;
using AVFoundation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

[Register("SKVideoNode", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
public class SKVideoNode : SKNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnchorPoint = "anchorPoint";

	private static readonly IntPtr selAnchorPointHandle = Selector.GetHandle("anchorPoint");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAVPlayer_ = "initWithAVPlayer:";

	private static readonly IntPtr selInitWithAVPlayer_Handle = Selector.GetHandle("initWithAVPlayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFileNamed_ = "initWithFileNamed:";

	private static readonly IntPtr selInitWithFileNamed_Handle = Selector.GetHandle("initWithFileNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_ = "initWithURL:";

	private static readonly IntPtr selInitWithURL_Handle = Selector.GetHandle("initWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithVideoFileNamed_ = "initWithVideoFileNamed:";

	private static readonly IntPtr selInitWithVideoFileNamed_Handle = Selector.GetHandle("initWithVideoFileNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithVideoURL_ = "initWithVideoURL:";

	private static readonly IntPtr selInitWithVideoURL_Handle = Selector.GetHandle("initWithVideoURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPause = "pause";

	private static readonly IntPtr selPauseHandle = Selector.GetHandle("pause");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlay = "play";

	private static readonly IntPtr selPlayHandle = Selector.GetHandle("play");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnchorPoint_ = "setAnchorPoint:";

	private static readonly IntPtr selSetAnchorPoint_Handle = Selector.GetHandle("setAnchorPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSize_ = "setSize:";

	private static readonly IntPtr selSetSize_Handle = Selector.GetHandle("setSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoNodeWithAVPlayer_ = "videoNodeWithAVPlayer:";

	private static readonly IntPtr selVideoNodeWithAVPlayer_Handle = Selector.GetHandle("videoNodeWithAVPlayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoNodeWithFileNamed_ = "videoNodeWithFileNamed:";

	private static readonly IntPtr selVideoNodeWithFileNamed_Handle = Selector.GetHandle("videoNodeWithFileNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoNodeWithURL_ = "videoNodeWithURL:";

	private static readonly IntPtr selVideoNodeWithURL_Handle = Selector.GetHandle("videoNodeWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoNodeWithVideoFileNamed_ = "videoNodeWithVideoFileNamed:";

	private static readonly IntPtr selVideoNodeWithVideoFileNamed_Handle = Selector.GetHandle("videoNodeWithVideoFileNamed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoNodeWithVideoURL_ = "videoNodeWithVideoURL:";

	private static readonly IntPtr selVideoNodeWithVideoURL_Handle = Selector.GetHandle("videoNodeWithVideoURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKVideoNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGPoint AnchorPoint
	{
		[Export("anchorPoint")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGPoint_objc_msgSend(base.Handle, selAnchorPointHandle);
			}
			return Messaging.CGPoint_objc_msgSendSuper(base.SuperHandle, selAnchorPointHandle);
		}
		[Export("setAnchorPoint:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGPoint(base.Handle, selSetAnchorPoint_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selSetAnchorPoint_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize Size
	{
		[Export("size")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
		[Export("setSize:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetSize_Handle, value);
			}
		}
	}

	private static bool CheckSystemVersion()
	{
		return PlatformHelper.CheckSystemVersion(10, 10);
	}

	public static SKVideoNode FromFile(string videoFile)
	{
		if (CheckSystemVersion())
		{
			return VideoNodeWithFileNamed(videoFile);
		}
		return VideoNodeWithVideoFileNamed(videoFile);
	}

	public static SKVideoNode FromUrl(NSUrl videoUrl)
	{
		if (CheckSystemVersion())
		{
			return VideoNodeWithURL(videoUrl);
		}
		return VideoNodeWithVideoURL(videoUrl);
	}

	[DesignatedInitializer]
	public SKVideoNode(string videoFile)
	{
		if (CheckSystemVersion())
		{
			base.Handle = InitWithFileNamed(videoFile);
		}
		else
		{
			base.Handle = InitWithVideoFileNamed(videoFile);
		}
	}

	[DesignatedInitializer]
	public SKVideoNode(NSUrl url)
	{
		if (CheckSystemVersion())
		{
			base.Handle = InitWithURL(url);
		}
		else
		{
			base.Handle = InitWithVideoURL(url);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKVideoNode()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SKVideoNode(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
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
	protected SKVideoNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKVideoNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAVPlayer:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKVideoNode(AVPlayer player)
		: base(NSObjectFlag.Empty)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAVPlayer_Handle, player.Handle), "initWithAVPlayer:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAVPlayer_Handle, player.Handle), "initWithAVPlayer:");
		}
	}

	[Export("videoNodeWithAVPlayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKVideoNode FromPlayer(AVPlayer player)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		return Runtime.GetNSObject<SKVideoNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selVideoNodeWithAVPlayer_Handle, player.Handle));
	}

	[Export("initWithFileNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithFileNamed(string videoFile)
	{
		if (videoFile == null)
		{
			throw new ArgumentNullException("videoFile");
		}
		IntPtr arg = NSString.CreateNative(videoFile);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithFileNamed_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithFileNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithURL(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithURL_Handle, url.Handle);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithURL_Handle, url.Handle);
	}

	[Export("initWithVideoFileNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithVideoFileNamed(string videoFile)
	{
		if (videoFile == null)
		{
			throw new ArgumentNullException("videoFile");
		}
		IntPtr arg = NSString.CreateNative(videoFile);
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithVideoFileNamed_Handle, arg) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithVideoFileNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithVideoURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithVideoURL(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithVideoURL_Handle, url.Handle);
		}
		return Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithVideoURL_Handle, url.Handle);
	}

	[Export("pause")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Pause()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPauseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPauseHandle);
		}
	}

	[Export("play")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Play()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selPlayHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selPlayHandle);
		}
	}

	[Export("videoNodeWithFileNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static SKVideoNode VideoNodeWithFileNamed(string videoFile)
	{
		if (videoFile == null)
		{
			throw new ArgumentNullException("videoFile");
		}
		IntPtr arg = NSString.CreateNative(videoFile);
		SKVideoNode nSObject = Runtime.GetNSObject<SKVideoNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selVideoNodeWithFileNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("videoNodeWithURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static SKVideoNode VideoNodeWithURL(NSUrl videoURL)
	{
		if (videoURL == null)
		{
			throw new ArgumentNullException("videoURL");
		}
		return Runtime.GetNSObject<SKVideoNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selVideoNodeWithURL_Handle, videoURL.Handle));
	}

	[Export("videoNodeWithVideoFileNamed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static SKVideoNode VideoNodeWithVideoFileNamed(string videoFile)
	{
		if (videoFile == null)
		{
			throw new ArgumentNullException("videoFile");
		}
		IntPtr arg = NSString.CreateNative(videoFile);
		SKVideoNode nSObject = Runtime.GetNSObject<SKVideoNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selVideoNodeWithVideoFileNamed_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("videoNodeWithVideoURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static SKVideoNode VideoNodeWithVideoURL(NSUrl videoURL)
	{
		if (videoURL == null)
		{
			throw new ArgumentNullException("videoURL");
		}
		return Runtime.GetNSObject<SKVideoNode>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selVideoNodeWithVideoURL_Handle, videoURL.Handle));
	}
}
