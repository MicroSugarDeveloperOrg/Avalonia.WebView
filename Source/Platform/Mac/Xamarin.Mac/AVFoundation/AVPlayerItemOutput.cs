using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayerItemOutput", true)]
public class AVPlayerItemOutput : NSObject
{
	private static readonly IntPtr selSuppressesPlayerRenderingHandle = Selector.GetHandle("suppressesPlayerRendering");

	private static readonly IntPtr selSetSuppressesPlayerRendering_Handle = Selector.GetHandle("setSuppressesPlayerRendering:");

	private static readonly IntPtr selItemTimeForHostTime_Handle = Selector.GetHandle("itemTimeForHostTime:");

	private static readonly IntPtr selItemTimeForMachAbsoluteTime_Handle = Selector.GetHandle("itemTimeForMachAbsoluteTime:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVPlayerItemOutput");

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool SuppressesPlayerRendering
	{
		[Export("suppressesPlayerRendering")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSuppressesPlayerRenderingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSuppressesPlayerRenderingHandle);
		}
		[Export("setSuppressesPlayerRendering:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSuppressesPlayerRendering_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSuppressesPlayerRendering_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVPlayerItemOutput(NSCoder coder)
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
	public AVPlayerItemOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVPlayerItemOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("itemTimeForHostTime:")]
	public virtual CMTime GetItemTime(double hostTimeInSeconds)
	{
		CMTime retval;
		if (IsDirectBinding)
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
	public virtual CMTime GetItemTime(long machAbsoluteTime)
	{
		CMTime retval;
		if (IsDirectBinding)
		{
			Messaging.CMTime_objc_msgSend_stret_Int64(out retval, base.Handle, selItemTimeForMachAbsoluteTime_Handle, machAbsoluteTime);
		}
		else
		{
			Messaging.CMTime_objc_msgSendSuper_stret_Int64(out retval, base.SuperHandle, selItemTimeForMachAbsoluteTime_Handle, machAbsoluteTime);
		}
		return retval;
	}
}
