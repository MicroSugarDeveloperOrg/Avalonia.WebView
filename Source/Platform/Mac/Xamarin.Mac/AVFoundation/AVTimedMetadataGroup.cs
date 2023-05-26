using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVTimedMetadataGroup", true)]
public class AVTimedMetadataGroup : NSObject
{
	private static readonly IntPtr selTimeRangeHandle = Selector.GetHandle("timeRange");

	private static readonly IntPtr selSetTimeRange_Handle = Selector.GetHandle("setTimeRange:");

	private static readonly IntPtr selItemsHandle = Selector.GetHandle("items");

	private static readonly IntPtr selSetItems_Handle = Selector.GetHandle("setItems:");

	private static readonly IntPtr selInitWithItemsTimeRange_Handle = Selector.GetHandle("initWithItems:timeRange:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVTimedMetadataGroup");

	private object __mt_Items_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CMTimeRange TimeRange
	{
		[Export("timeRange")]
		get
		{
			CMTimeRange retval;
			if (IsDirectBinding)
			{
				Messaging.CMTimeRange_objc_msgSend_stret(out retval, base.Handle, selTimeRangeHandle);
			}
			else
			{
				Messaging.CMTimeRange_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTimeRangeHandle);
			}
			return retval;
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public virtual AVMetadataItem[] Items
	{
		[Export("items")]
		get
		{
			return (AVMetadataItem[])(__mt_Items_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selItemsHandle)) : NSArray.ArrayFromHandle<AVMetadataItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selItemsHandle))));
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVTimedMetadataGroup()
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
	public AVTimedMetadataGroup(NSCoder coder)
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
	public AVTimedMetadataGroup(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVTimedMetadataGroup(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithItems:timeRange:")]
	public AVTimedMetadataGroup(AVMetadataItem[] items, CMTimeRange timeRange)
		: base(NSObjectFlag.Empty)
	{
		if (items == null)
		{
			throw new ArgumentNullException("items");
		}
		NSArray nSArray = NSArray.FromNSObjects(items);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_CMTimeRange(base.Handle, selInitWithItemsTimeRange_Handle, nSArray.Handle, timeRange);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_CMTimeRange(base.SuperHandle, selInitWithItemsTimeRange_Handle, nSArray.Handle, timeRange);
		}
		nSArray.Dispose();
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Items_var = null;
		}
	}
}
