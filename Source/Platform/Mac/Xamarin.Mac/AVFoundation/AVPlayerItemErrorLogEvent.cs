using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPlayerItemErrorLogEvent", true)]
public class AVPlayerItemErrorLogEvent : NSObject
{
	private static readonly IntPtr selDateHandle = Selector.GetHandle("date");

	private static readonly IntPtr selURIHandle = Selector.GetHandle("URI");

	private static readonly IntPtr selServerAddressHandle = Selector.GetHandle("serverAddress");

	private static readonly IntPtr selPlaybackSessionIDHandle = Selector.GetHandle("playbackSessionID");

	private static readonly IntPtr selErrorStatusCodeHandle = Selector.GetHandle("errorStatusCode");

	private static readonly IntPtr selErrorDomainHandle = Selector.GetHandle("errorDomain");

	private static readonly IntPtr selErrorCommentHandle = Selector.GetHandle("errorComment");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVPlayerItemErrorLogEvent");

	private object __mt_Date_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSDate Date
	{
		[Export("date")]
		get
		{
			return (NSDate)(__mt_Date_var = ((!IsDirectBinding) ? ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDateHandle))) : ((NSDate)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDateHandle)))));
		}
	}

	public virtual string Uri
	{
		[Export("URI")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selURIHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURIHandle));
		}
	}

	public virtual string ServerAddress
	{
		[Export("serverAddress")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selServerAddressHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selServerAddressHandle));
		}
	}

	public virtual string PlaybackSessionID
	{
		[Export("playbackSessionID")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPlaybackSessionIDHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPlaybackSessionIDHandle));
		}
	}

	public virtual int ErrorStatusCode
	{
		[Export("errorStatusCode")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selErrorStatusCodeHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selErrorStatusCodeHandle);
		}
	}

	public virtual string ErrorDomain
	{
		[Export("errorDomain")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorDomainHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorDomainHandle));
		}
	}

	public virtual string ErrorComment
	{
		[Export("errorComment")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorCommentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorCommentHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVPlayerItemErrorLogEvent()
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
	public AVPlayerItemErrorLogEvent(NSCoder coder)
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
	public AVPlayerItemErrorLogEvent(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVPlayerItemErrorLogEvent(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Date_var = null;
		}
	}
}
