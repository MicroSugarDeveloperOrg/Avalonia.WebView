using System;
using System.ComponentModel;
using CoreAnimation;
using CoreGraphics;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayerLayer", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVPlayerLayer : CALayer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsReadyForDisplay = "isReadyForDisplay";

	private static readonly IntPtr selIsReadyForDisplayHandle = Selector.GetHandle("isReadyForDisplay");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelBufferAttributes = "pixelBufferAttributes";

	private static readonly IntPtr selPixelBufferAttributesHandle = Selector.GetHandle("pixelBufferAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayer = "player";

	private static readonly IntPtr selPlayerHandle = Selector.GetHandle("player");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPlayerLayerWithPlayer_ = "playerLayerWithPlayer:";

	private static readonly IntPtr selPlayerLayerWithPlayer_Handle = Selector.GetHandle("playerLayerWithPlayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPixelBufferAttributes_ = "setPixelBufferAttributes:";

	private static readonly IntPtr selSetPixelBufferAttributes_Handle = Selector.GetHandle("setPixelBufferAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPlayer_ = "setPlayer:";

	private static readonly IntPtr selSetPlayer_Handle = Selector.GetHandle("setPlayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetVideoGravity_ = "setVideoGravity:";

	private static readonly IntPtr selSetVideoGravity_Handle = Selector.GetHandle("setVideoGravity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoGravity = "videoGravity";

	private static readonly IntPtr selVideoGravityHandle = Selector.GetHandle("videoGravity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoRect = "videoRect";

	private static readonly IntPtr selVideoRectHandle = Selector.GetHandle("videoRect");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVPlayerLayer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GravityResize;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GravityResizeAspect;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _GravityResizeAspectFill;

	public AVLayerVideoGravity VideoGravity
	{
		get
		{
			return KeyToEnum(WeakVideoGravity);
		}
		set
		{
			WeakVideoGravity = EnumToKey(value);
		}
	}

	[iOS(9, 0)]
	[Mac(10, 11)]
	public CVPixelBufferAttributes PixelBufferAttributes
	{
		get
		{
			if (WeakPixelBufferAttributes != null)
			{
				return new CVPixelBufferAttributes(WeakPixelBufferAttributes);
			}
			return null;
		}
		set
		{
			WeakPixelBufferAttributes = value?.Dictionary;
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPlayer? Player
	{
		[Export("player", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVPlayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selPlayerHandle));
			}
			return Runtime.GetNSObject<AVPlayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlayerHandle));
		}
		[Export("setPlayer:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPlayer_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPlayer_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReadyForDisplay
	{
		[Export("isReadyForDisplay")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsReadyForDisplayHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsReadyForDisplayHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual CGRect VideoRect
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("videoRect")]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selVideoRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selVideoRectHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSDictionary? WeakPixelBufferAttributes
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("pixelBufferAttributes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selPixelBufferAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPixelBufferAttributesHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setPixelBufferAttributes:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPixelBufferAttributes_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPixelBufferAttributes_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual NSString WeakVideoGravity
	{
		[Export("videoGravity", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoGravityHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoGravityHandle));
		}
		[Export("setVideoGravity:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVideoGravity_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVideoGravity_Handle, value.Handle);
			}
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

	internal static AVLayerVideoGravity KeyToEnum(NSString key, bool clamp = true)
	{
		if (key == GravityResize)
		{
			return AVLayerVideoGravity.Resize;
		}
		if (key == GravityResizeAspectFill)
		{
			return AVLayerVideoGravity.ResizeAspectFill;
		}
		if (key == GravityResizeAspect)
		{
			return AVLayerVideoGravity.ResizeAspect;
		}
		if (clamp)
		{
			return AVLayerVideoGravity.ResizeAspect;
		}
		return (AVLayerVideoGravity)(-1);
	}

	internal static NSString EnumToKey(AVLayerVideoGravity vg)
	{
		return vg switch
		{
			AVLayerVideoGravity.ResizeAspect => GravityResizeAspect, 
			AVLayerVideoGravity.ResizeAspectFill => GravityResizeAspectFill, 
			AVLayerVideoGravity.Resize => GravityResize, 
			_ => null, 
		};
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPlayerLayer()
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
	public AVPlayerLayer(NSCoder coder)
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
	protected AVPlayerLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPlayerLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("playerLayerWithPlayer:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVPlayerLayer FromPlayer(AVPlayer? player)
	{
		return Runtime.GetNSObject<AVPlayerLayer>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPlayerLayerWithPlayer_Handle, player?.Handle ?? IntPtr.Zero));
	}
}
