using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetTrackSegment", true)]
public class AVAssetTrackSegment : NSObject
{
	private static readonly IntPtr selIsEmptyHandle = Selector.GetHandle("isEmpty");

	private static readonly IntPtr selTimeMappingHandle = Selector.GetHandle("timeMapping");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAssetTrackSegment");

	public override IntPtr ClassHandle => class_ptr;

	public virtual bool Empty
	{
		[Export("isEmpty")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEmptyHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEmptyHandle);
		}
	}

	public virtual CMTimeMapping TimeMapping
	{
		[Export("timeMapping")]
		get
		{
			CMTimeMapping retval;
			if (IsDirectBinding)
			{
				Messaging.CMTimeMapping_objc_msgSend_stret(out retval, base.Handle, selTimeMappingHandle);
			}
			else
			{
				Messaging.CMTimeMapping_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTimeMappingHandle);
			}
			return retval;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAssetTrackSegment()
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
	public AVAssetTrackSegment(NSCoder coder)
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
	public AVAssetTrackSegment(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAssetTrackSegment(IntPtr handle)
		: base(handle)
	{
	}
}
