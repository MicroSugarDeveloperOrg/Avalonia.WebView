using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVComposition", true)]
public class AVComposition : AVAsset
{
	private static readonly IntPtr selTracksHandle = Selector.GetHandle("tracks");

	private static readonly IntPtr selNaturalSizeHandle = Selector.GetHandle("naturalSize");

	private static readonly IntPtr selSetNaturalSize_Handle = Selector.GetHandle("setNaturalSize:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVComposition");

	private object __mt_Tracks_var;

	public override IntPtr ClassHandle => class_ptr;

	public new virtual AVCompositionTrack[] Tracks
	{
		[Export("tracks")]
		get
		{
			return (AVCompositionTrack[])(__mt_Tracks_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVCompositionTrack>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTracksHandle)) : NSArray.ArrayFromHandle<AVCompositionTrack>(Messaging.IntPtr_objc_msgSend(base.Handle, selTracksHandle))));
		}
	}

	[Obsolete("Deprecated in iOS 5.0 and OSX 10.8", false)]
	public new virtual CGSize NaturalSize
	{
		[Export("naturalSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selNaturalSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selNaturalSizeHandle);
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVComposition()
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
	public AVComposition(NSCoder coder)
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
	public AVComposition(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVComposition(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Tracks_var = null;
		}
	}
}
