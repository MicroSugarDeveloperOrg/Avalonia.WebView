using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Protocol]
[Register("AVAsynchronousKeyValueLoading", true)]
[Model]
public abstract class AVAsynchronousKeyValueLoading : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAsynchronousKeyValueLoading()
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
	public AVAsynchronousKeyValueLoading(NSCoder coder)
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
	public AVAsynchronousKeyValueLoading(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAsynchronousKeyValueLoading(IntPtr handle)
		: base(handle)
	{
	}

	[Export("statusOfValueForKey:error:")]
	public abstract AVKeyValueStatus StatusOfValueForKeyerror(string key, IntPtr outError);

	[Export("loadValuesAsynchronouslyForKeys:completionHandler:")]
	public abstract void LoadValuesAsynchronously(string[] keys, NSAction handler);
}
