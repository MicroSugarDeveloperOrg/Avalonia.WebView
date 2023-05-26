using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayerItemErrorLog", true)]
public class AVPlayerItemErrorLog : NSObject
{
	private static readonly IntPtr selEventsHandle = Selector.GetHandle("events");

	private static readonly IntPtr selExtendedLogDataStringEncodingHandle = Selector.GetHandle("extendedLogDataStringEncoding");

	private static readonly IntPtr selExtendedLogDataHandle = Selector.GetHandle("extendedLogData");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVPlayerItemErrorLog");

	private object __mt_Events_var;

	private object __mt_ExtendedLogData_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVPlayerItemErrorLogEvent[] Events
	{
		[Export("events")]
		get
		{
			return (AVPlayerItemErrorLogEvent[])(__mt_Events_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVPlayerItemErrorLogEvent>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEventsHandle)) : NSArray.ArrayFromHandle<AVPlayerItemErrorLogEvent>(Messaging.IntPtr_objc_msgSend(base.Handle, selEventsHandle))));
		}
	}

	public virtual NSStringEncoding ExtendedLogDataStringEncoding
	{
		[Export("extendedLogDataStringEncoding")]
		get
		{
			if (IsDirectBinding)
			{
				return (NSStringEncoding)Messaging.UInt32_objc_msgSend(base.Handle, selExtendedLogDataStringEncodingHandle);
			}
			return (NSStringEncoding)Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selExtendedLogDataStringEncodingHandle);
		}
	}

	public virtual NSData ExtendedLogData
	{
		[Export("extendedLogData")]
		get
		{
			return (NSData)(__mt_ExtendedLogData_var = ((!IsDirectBinding) ? ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtendedLogDataHandle))) : ((NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selExtendedLogDataHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPlayerItemErrorLog()
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
	public AVPlayerItemErrorLog(NSCoder coder)
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
	public AVPlayerItemErrorLog(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVPlayerItemErrorLog(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Events_var = null;
			__mt_ExtendedLogData_var = null;
		}
	}
}
