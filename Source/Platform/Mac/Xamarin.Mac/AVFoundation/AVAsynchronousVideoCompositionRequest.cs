using System;
using System.ComponentModel;
using CoreMedia;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAsynchronousVideoCompositionRequest", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class AVAsynchronousVideoCompositionRequest : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompositionTime = "compositionTime";

	private static readonly IntPtr selCompositionTimeHandle = Selector.GetHandle("compositionTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinishCancelledRequest = "finishCancelledRequest";

	private static readonly IntPtr selFinishCancelledRequestHandle = Selector.GetHandle("finishCancelledRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinishWithComposedVideoFrame_ = "finishWithComposedVideoFrame:";

	private static readonly IntPtr selFinishWithComposedVideoFrame_Handle = Selector.GetHandle("finishWithComposedVideoFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFinishWithError_ = "finishWithError:";

	private static readonly IntPtr selFinishWithError_Handle = Selector.GetHandle("finishWithError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderContext = "renderContext";

	private static readonly IntPtr selRenderContextHandle = Selector.GetHandle("renderContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceFrameByTrackID_ = "sourceFrameByTrackID:";

	private static readonly IntPtr selSourceFrameByTrackID_Handle = Selector.GetHandle("sourceFrameByTrackID:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceTrackIDs = "sourceTrackIDs";

	private static readonly IntPtr selSourceTrackIDsHandle = Selector.GetHandle("sourceTrackIDs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoCompositionInstruction = "videoCompositionInstruction";

	private static readonly IntPtr selVideoCompositionInstructionHandle = Selector.GetHandle("videoCompositionInstruction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAsynchronousVideoCompositionRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime CompositionTime
	{
		[Export("compositionTime", ArgumentSemantic.Copy)]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selCompositionTimeHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selCompositionTimeHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVVideoCompositionRenderContext RenderContext
	{
		[Export("renderContext", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVVideoCompositionRenderContext>(Messaging.IntPtr_objc_msgSend(base.Handle, selRenderContextHandle));
			}
			return Runtime.GetNSObject<AVVideoCompositionRenderContext>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRenderContextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[] SourceTrackIDs
	{
		[Export("sourceTrackIDs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourceTrackIDsHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourceTrackIDsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVVideoCompositionInstruction VideoCompositionInstruction
	{
		[Export("videoCompositionInstruction", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVVideoCompositionInstruction>(Messaging.IntPtr_objc_msgSend(base.Handle, selVideoCompositionInstructionHandle));
			}
			return Runtime.GetNSObject<AVVideoCompositionInstruction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVideoCompositionInstructionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAsynchronousVideoCompositionRequest()
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
	protected AVAsynchronousVideoCompositionRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAsynchronousVideoCompositionRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("finishCancelledRequest")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinishCancelledRequest()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFinishCancelledRequestHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFinishCancelledRequestHandle);
		}
	}

	[Export("finishWithComposedVideoFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinishWithComposedVideoFrame(CVPixelBuffer composedVideoFrame)
	{
		if (composedVideoFrame == null)
		{
			throw new ArgumentNullException("composedVideoFrame");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFinishWithComposedVideoFrame_Handle, composedVideoFrame.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFinishWithComposedVideoFrame_Handle, composedVideoFrame.Handle);
		}
	}

	[Export("finishWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void FinishWithError(NSError error)
	{
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selFinishWithError_Handle, error.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selFinishWithError_Handle, error.Handle);
		}
	}

	[Export("sourceFrameByTrackID:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CVPixelBuffer? SourceFrameByTrackID(int trackID)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSend_int(base.Handle, selSourceFrameByTrackID_Handle, trackID), owns: false);
		}
		return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selSourceFrameByTrackID_Handle, trackID), owns: false);
	}
}
