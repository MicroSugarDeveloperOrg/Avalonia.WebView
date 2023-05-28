using System;
using System.ComponentModel;
using CoreGraphics;
using CoreVideo;
using Foundation;
using Metal;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CARenderer", true)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class CARenderer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddUpdateRect_ = "addUpdateRect:";

	private static readonly IntPtr selAddUpdateRect_Handle = Selector.GetHandle("addUpdateRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginFrameAtTime_TimeStamp_ = "beginFrameAtTime:timeStamp:";

	private static readonly IntPtr selBeginFrameAtTime_TimeStamp_Handle = Selector.GetHandle("beginFrameAtTime:timeStamp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBounds = "bounds";

	private static readonly IntPtr selBoundsHandle = Selector.GetHandle("bounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndFrame = "endFrame";

	private static readonly IntPtr selEndFrameHandle = Selector.GetHandle("endFrame");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayer = "layer";

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextFrameTime = "nextFrameTime";

	private static readonly IntPtr selNextFrameTimeHandle = Selector.GetHandle("nextFrameTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRender = "render";

	private static readonly IntPtr selRenderHandle = Selector.GetHandle("render");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRendererWithMTLTexture_Options_ = "rendererWithMTLTexture:options:";

	private static readonly IntPtr selRendererWithMTLTexture_Options_Handle = Selector.GetHandle("rendererWithMTLTexture:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBounds_ = "setBounds:";

	private static readonly IntPtr selSetBounds_Handle = Selector.GetHandle("setBounds:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDestination_ = "setDestination:";

	private static readonly IntPtr selSetDestination_Handle = Selector.GetHandle("setDestination:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLayer_ = "setLayer:";

	private static readonly IntPtr selSetLayer_Handle = Selector.GetHandle("setLayer:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateBounds = "updateBounds";

	private static readonly IntPtr selUpdateBoundsHandle = Selector.GetHandle("updateBounds");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CARenderer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect Bounds
	{
		[Export("bounds", ArgumentSemantic.Assign)]
		get
		{
			CGRect retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selBoundsHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selBoundsHandle);
			}
			return retval;
		}
		[Export("setBounds:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGRect(base.Handle, selSetBounds_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selSetBounds_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CALayer? Layer
	{
		[Export("layer", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend(base.Handle, selLayerHandle));
			}
			return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayerHandle));
		}
		[Export("setLayer:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLayer_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLayer_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CARenderer()
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
	protected CARenderer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CARenderer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addUpdateRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddUpdate(CGRect r)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selAddUpdateRect_Handle, r);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selAddUpdateRect_Handle, r);
		}
	}

	[Export("beginFrameAtTime:timeStamp:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginFrame(double timeInSeconds, ref CVTimeStamp ts)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Double_ref_CVTimeStamp(base.Handle, selBeginFrameAtTime_TimeStamp_Handle, timeInSeconds, ref ts);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Double_ref_CVTimeStamp(base.SuperHandle, selBeginFrameAtTime_TimeStamp_Handle, timeInSeconds, ref ts);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal void BeginFrame(double timeInSeconds, IntPtr ts)
	{
		Messaging.void_objc_msgSend_Double_IntPtr(base.Handle, selBeginFrameAtTime_TimeStamp_Handle, timeInSeconds, ts);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void BeginFrame(double timeInSeconds)
	{
		BeginFrame(timeInSeconds, IntPtr.Zero);
	}

	[Export("rendererWithMTLTexture:options:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CARenderer Create(IMTLTexture tex, NSDictionary? dict)
	{
		if (tex == null)
		{
			throw new ArgumentNullException("tex");
		}
		return Runtime.GetNSObject<CARenderer>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selRendererWithMTLTexture_Options_Handle, tex.Handle, dict?.Handle ?? IntPtr.Zero));
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CARenderer Create(IMTLTexture tex, CARendererOptions? options)
	{
		return Create(tex, options.GetDictionary());
	}

	[Export("endFrame")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndFrame()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEndFrameHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEndFrameHandle);
		}
	}

	[Export("nextFrameTime")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual double GetNextFrameTime()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend(base.Handle, selNextFrameTimeHandle);
		}
		return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selNextFrameTimeHandle);
	}

	[Export("render")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Render()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRenderHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRenderHandle);
		}
	}

	[Export("setDestination:")]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDestination(IMTLTexture tex)
	{
		if (tex == null)
		{
			throw new ArgumentNullException("tex");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDestination_Handle, tex.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDestination_Handle, tex.Handle);
		}
	}

	[Export("updateBounds")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect UpdateBounds()
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selUpdateBoundsHandle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selUpdateBoundsHandle);
		}
		return retval;
	}
}
