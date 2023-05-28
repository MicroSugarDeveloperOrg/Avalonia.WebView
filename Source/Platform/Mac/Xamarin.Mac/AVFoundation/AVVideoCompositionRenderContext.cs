using System;
using System.ComponentModel;
using CoreGraphics;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVVideoCompositionRenderContext", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class AVVideoCompositionRenderContext : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEdgeWidths = "edgeWidths";

	private static readonly IntPtr selEdgeWidthsHandle = Selector.GetHandle("edgeWidths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHighQualityRendering = "highQualityRendering";

	private static readonly IntPtr selHighQualityRenderingHandle = Selector.GetHandle("highQualityRendering");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewPixelBuffer = "newPixelBuffer";

	private static readonly IntPtr selNewPixelBufferHandle = Selector.GetHandle("newPixelBuffer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelAspectRatio = "pixelAspectRatio";

	private static readonly IntPtr selPixelAspectRatioHandle = Selector.GetHandle("pixelAspectRatio");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderScale = "renderScale";

	private static readonly IntPtr selRenderScaleHandle = Selector.GetHandle("renderScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderTransform = "renderTransform";

	private static readonly IntPtr selRenderTransformHandle = Selector.GetHandle("renderTransform");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoComposition = "videoComposition";

	private static readonly IntPtr selVideoCompositionHandle = Selector.GetHandle("videoComposition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVVideoCompositionRenderContext");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVEdgeWidths EdgeWidths
	{
		[Export("edgeWidths", ArgumentSemantic.Copy)]
		get
		{
			AVEdgeWidths retval;
			if (base.IsDirectBinding)
			{
				Messaging.AVEdgeWidths_objc_msgSend_stret(out retval, base.Handle, selEdgeWidthsHandle);
			}
			else
			{
				Messaging.AVEdgeWidths_objc_msgSendSuper_stret(out retval, base.SuperHandle, selEdgeWidthsHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HighQualityRendering
	{
		[Export("highQualityRendering")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHighQualityRenderingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHighQualityRenderingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPixelAspectRatio PixelAspectRatio
	{
		[Export("pixelAspectRatio", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.AVPixelAspectRatio_objc_msgSend(base.Handle, selPixelAspectRatioHandle);
			}
			return Messaging.AVPixelAspectRatio_objc_msgSendSuper(base.SuperHandle, selPixelAspectRatioHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float RenderScale
	{
		[Export("renderScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRenderScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRenderScaleHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGAffineTransform RenderTransform
	{
		[Export("renderTransform", ArgumentSemantic.Copy)]
		get
		{
			CGAffineTransform retval;
			if (base.IsDirectBinding)
			{
				Messaging.CGAffineTransform_objc_msgSend_stret(out retval, base.Handle, selRenderTransformHandle);
			}
			else
			{
				Messaging.CGAffineTransform_objc_msgSendSuper_stret(out retval, base.SuperHandle, selRenderTransformHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize Size
	{
		[Export("size", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVVideoComposition VideoComposition
	{
		[Export("videoComposition", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVVideoComposition>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoCompositionHandle));
			}
			return Runtime.GetNSObject<AVVideoComposition>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoCompositionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVVideoCompositionRenderContext()
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
	protected AVVideoCompositionRenderContext(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVVideoCompositionRenderContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("newPixelBuffer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CVPixelBuffer? CreatePixelBuffer()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selNewPixelBufferHandle), owns: false);
		}
		return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNewPixelBufferHandle), owns: false);
	}
}
