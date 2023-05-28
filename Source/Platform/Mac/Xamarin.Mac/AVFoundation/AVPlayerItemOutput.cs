using System;
using System.ComponentModel;
using CoreMedia;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayerItemOutput", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
public class AVPlayerItemOutput : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemTimeForCVTimeStamp_ = "itemTimeForCVTimeStamp:";

	private static readonly IntPtr selItemTimeForCVTimeStamp_Handle = Selector.GetHandle("itemTimeForCVTimeStamp:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemTimeForHostTime_ = "itemTimeForHostTime:";

	private static readonly IntPtr selItemTimeForHostTime_Handle = Selector.GetHandle("itemTimeForHostTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemTimeForMachAbsoluteTime_ = "itemTimeForMachAbsoluteTime:";

	private static readonly IntPtr selItemTimeForMachAbsoluteTime_Handle = Selector.GetHandle("itemTimeForMachAbsoluteTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSuppressesPlayerRendering_ = "setSuppressesPlayerRendering:";

	private static readonly IntPtr selSetSuppressesPlayerRendering_Handle = Selector.GetHandle("setSuppressesPlayerRendering:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuppressesPlayerRendering = "suppressesPlayerRendering";

	private static readonly IntPtr selSuppressesPlayerRenderingHandle = Selector.GetHandle("suppressesPlayerRendering");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVPlayerItemOutput");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SuppressesPlayerRendering
	{
		[Export("suppressesPlayerRendering")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSuppressesPlayerRenderingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSuppressesPlayerRenderingHandle);
		}
		[Export("setSuppressesPlayerRendering:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSuppressesPlayerRendering_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSuppressesPlayerRendering_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVPlayerItemOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPlayerItemOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("itemTimeForHostTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime GetItemTime(double hostTimeInSeconds)
	{
		CMTime retval;
		if (base.IsDirectBinding)
		{
			Messaging.CMTime_objc_msgSend_stret_Double(out retval, base.Handle, selItemTimeForHostTime_Handle, hostTimeInSeconds);
		}
		else
		{
			Messaging.CMTime_objc_msgSendSuper_stret_Double(out retval, base.SuperHandle, selItemTimeForHostTime_Handle, hostTimeInSeconds);
		}
		return retval;
	}

	[Export("itemTimeForMachAbsoluteTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime GetItemTime(long machAbsoluteTime)
	{
		CMTime retval;
		if (base.IsDirectBinding)
		{
			Messaging.CMTime_objc_msgSend_stret_Int64(out retval, base.Handle, selItemTimeForMachAbsoluteTime_Handle, machAbsoluteTime);
		}
		else
		{
			Messaging.CMTime_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selItemTimeForMachAbsoluteTime_Handle, machAbsoluteTime);
		}
		return retval;
	}

	[Export("itemTimeForCVTimeStamp:")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime GetItemTime(CVTimeStamp timestamp)
	{
		CMTime retval;
		if (base.IsDirectBinding)
		{
			Messaging.CMTime_objc_msgSend_stret_CVTimeStamp(out retval, base.Handle, selItemTimeForCVTimeStamp_Handle, timestamp);
		}
		else
		{
			Messaging.CMTime_objc_msgSendSuper_stret_CVTimeStamp(out retval, base.SuperHandle, selItemTimeForCVTimeStamp_Handle, timestamp);
		}
		return retval;
	}
}
