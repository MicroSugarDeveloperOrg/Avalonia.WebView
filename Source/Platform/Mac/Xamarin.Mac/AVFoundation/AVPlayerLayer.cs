using System;
using System.ComponentModel;
using CoreAnimation;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayerLayer", true)]
public class AVPlayerLayer : CALayer
{
	private static readonly IntPtr selPlayerHandle = Selector.GetHandle("player");

	private static readonly IntPtr selSetPlayer_Handle = Selector.GetHandle("setPlayer:");

	private static readonly IntPtr selVideoGravityHandle = Selector.GetHandle("videoGravity");

	private static readonly IntPtr selSetVideoGravity_Handle = Selector.GetHandle("setVideoGravity:");

	private static readonly IntPtr selIsReadyForDisplayHandle = Selector.GetHandle("isReadyForDisplay");

	private static readonly IntPtr selPlayerLayerWithPlayer_Handle = Selector.GetHandle("playerLayerWithPlayer:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVPlayerLayer");

	private object __mt_Player_var;

	private object __mt_WeakVideoGravity_var;

	private static NSString _GravityResizeAspect;

	private static NSString _GravityResizeAspectFill;

	private static NSString _GravityResize;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVPlayer Player
	{
		[Export("player")]
		get
		{
			return (AVPlayer)(__mt_Player_var = ((!IsDirectBinding) ? ((AVPlayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlayerHandle))) : ((AVPlayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPlayerHandle)))));
		}
		[Export("setPlayer:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPlayer_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPlayer_Handle, value.Handle);
			}
			__mt_Player_var = value;
		}
	}

	public string VideoGravity
	{
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoGravityHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoGravityHandle));
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoGravity_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoGravity_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	protected virtual NSString WeakVideoGravity
	{
		[Export("videoGravity")]
		get
		{
			return (NSString)(__mt_WeakVideoGravity_var = ((!IsDirectBinding) ? ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoGravityHandle))) : ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoGravityHandle)))));
		}
		[Export("setVideoGravity:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoGravity_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoGravity_Handle, value.Handle);
			}
			__mt_WeakVideoGravity_var = value;
		}
	}

	public virtual bool ReadyForDisplay
	{
		[Export("isReadyForDisplay")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsReadyForDisplayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsReadyForDisplayHandle);
		}
	}

	[Field("AVLayerVideoGravityResizeAspect", "AVFoundation")]
	public new static NSString GravityResizeAspect
	{
		get
		{
			if (_GravityResizeAspect == null)
			{
				_GravityResizeAspect = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVLayerVideoGravityResizeAspect");
			}
			return _GravityResizeAspect;
		}
	}

	[Field("AVLayerVideoGravityResizeAspectFill", "AVFoundation")]
	public new static NSString GravityResizeAspectFill
	{
		get
		{
			if (_GravityResizeAspectFill == null)
			{
				_GravityResizeAspectFill = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVLayerVideoGravityResizeAspectFill");
			}
			return _GravityResizeAspectFill;
		}
	}

	[Field("AVLayerVideoGravityResize", "AVFoundation")]
	public new static NSString GravityResize
	{
		get
		{
			if (_GravityResize == null)
			{
				_GravityResize = Dlfcn.GetStringConstant(Libraries.AVFoundation.Handle, "AVLayerVideoGravityResize");
			}
			return _GravityResize;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPlayerLayer()
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
	public AVPlayerLayer(NSCoder coder)
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
	public AVPlayerLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVPlayerLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("playerLayerWithPlayer:")]
	public static AVPlayerLayer FromPlayer(AVPlayer player)
	{
		if (player == null)
		{
			throw new ArgumentNullException("player");
		}
		return (AVPlayerLayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPlayerLayerWithPlayer_Handle, player.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Player_var = null;
			__mt_WeakVideoGravity_var = null;
		}
	}
}
