using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCompositionTrack", true)]
public class AVCompositionTrack : AVAssetTrack
{
	private static readonly IntPtr selSegmentsHandle = Selector.GetHandle("segments");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVCompositionTrack");

	private object __mt_Segments_var;

	public override IntPtr ClassHandle => class_ptr;

	public new virtual AVCompositionTrackSegment[] Segments
	{
		[Export("segments", ArgumentSemantic.Copy)]
		get
		{
			return (AVCompositionTrackSegment[])(__mt_Segments_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVCompositionTrackSegment>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSegmentsHandle)) : NSArray.ArrayFromHandle<AVCompositionTrackSegment>(Messaging.IntPtr_objc_msgSend(base.Handle, selSegmentsHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVCompositionTrack(NSCoder coder)
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
	public AVCompositionTrack(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVCompositionTrack(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Segments_var = null;
		}
	}
}
