using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVVideoCompositionLayerInstruction", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVVideoCompositionLayerInstruction : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSMutableCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetCropRectangleRampForTime_StartCropRectangle_EndCropRectangle_TimeRange_ = "getCropRectangleRampForTime:startCropRectangle:endCropRectangle:timeRange:";

	private static readonly IntPtr selGetCropRectangleRampForTime_StartCropRectangle_EndCropRectangle_TimeRange_Handle = Selector.GetHandle("getCropRectangleRampForTime:startCropRectangle:endCropRectangle:timeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetOpacityRampForTime_StartOpacity_EndOpacity_TimeRange_ = "getOpacityRampForTime:startOpacity:endOpacity:timeRange:";

	private static readonly IntPtr selGetOpacityRampForTime_StartOpacity_EndOpacity_TimeRange_Handle = Selector.GetHandle("getOpacityRampForTime:startOpacity:endOpacity:timeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetTransformRampForTime_StartTransform_EndTransform_TimeRange_ = "getTransformRampForTime:startTransform:endTransform:timeRange:";

	private static readonly IntPtr selGetTransformRampForTime_StartTransform_EndTransform_TimeRange_Handle = Selector.GetHandle("getTransformRampForTime:startTransform:endTransform:timeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

	private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTrackID = "trackID";

	private static readonly IntPtr selTrackIDHandle = Selector.GetHandle("trackID");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVVideoCompositionLayerInstruction");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int TrackID
	{
		[Export("trackID")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTrackIDHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTrackIDHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVVideoCompositionLayerInstruction()
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
	public AVVideoCompositionLayerInstruction(NSCoder coder)
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
	protected AVVideoCompositionLayerInstruction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVVideoCompositionLayerInstruction(IntPtr handle)
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

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
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

	[Export("getCropRectangleRampForTime:startCropRectangle:endCropRectangle:timeRange:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetCrop(CMTime time, ref CGRect startCropRectangle, ref CGRect endCropRectangle, ref CMTimeRange timeRange)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CMTime_ref_CGRect_ref_CGRect_ref_CMTimeRange(base.Handle, selGetCropRectangleRampForTime_StartCropRectangle_EndCropRectangle_TimeRange_Handle, time, ref startCropRectangle, ref endCropRectangle, ref timeRange);
		}
		return Messaging.bool_objc_msgSendSuper_CMTime_ref_CGRect_ref_CGRect_ref_CMTimeRange(base.SuperHandle, selGetCropRectangleRampForTime_StartCropRectangle_EndCropRectangle_TimeRange_Handle, time, ref startCropRectangle, ref endCropRectangle, ref timeRange);
	}

	[Export("getOpacityRampForTime:startOpacity:endOpacity:timeRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetOpacityRamp(CMTime time, ref float startOpacity, ref float endOpacity, ref CMTimeRange timeRange)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CMTime_ref_Single_ref_Single_ref_CMTimeRange(base.Handle, selGetOpacityRampForTime_StartOpacity_EndOpacity_TimeRange_Handle, time, ref startOpacity, ref endOpacity, ref timeRange);
		}
		return Messaging.bool_objc_msgSendSuper_CMTime_ref_Single_ref_Single_ref_CMTimeRange(base.SuperHandle, selGetOpacityRampForTime_StartOpacity_EndOpacity_TimeRange_Handle, time, ref startOpacity, ref endOpacity, ref timeRange);
	}

	[Export("getTransformRampForTime:startTransform:endTransform:timeRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetTransformRamp(CMTime time, ref CGAffineTransform startTransform, ref CGAffineTransform endTransform, ref CMTimeRange timeRange)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_CMTime_ref_CGAffineTransform_ref_CGAffineTransform_ref_CMTimeRange(base.Handle, selGetTransformRampForTime_StartTransform_EndTransform_TimeRange_Handle, time, ref startTransform, ref endTransform, ref timeRange);
		}
		return Messaging.bool_objc_msgSendSuper_CMTime_ref_CGAffineTransform_ref_CGAffineTransform_ref_CMTimeRange(base.SuperHandle, selGetTransformRampForTime_StartTransform_EndTransform_TimeRange_Handle, time, ref startTransform, ref endTransform, ref timeRange);
	}

	[Export("mutableCopyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject MutableCopy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}
