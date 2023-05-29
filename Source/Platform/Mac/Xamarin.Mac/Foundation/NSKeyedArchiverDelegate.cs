using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSKeyedArchiverDelegate", true)]
[Model]
public class NSKeyedArchiverDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSKeyedArchiverDelegate()
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
	public NSKeyedArchiverDelegate(NSCoder coder)
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
	public NSKeyedArchiverDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSKeyedArchiverDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("archiver:didEncodeObject:")]
	public virtual void EncodedObject(NSKeyedArchiver archiver, NSObject obj)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("archiverDidFinish:")]
	public virtual void Finished(NSKeyedArchiver archiver)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("archiver:willEncodeObject:")]
	public virtual NSObject WillEncode(NSKeyedArchiver archiver, NSObject obj)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("archiverWillFinish:")]
	public virtual void Finishing(NSKeyedArchiver archiver)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("archiver:willReplaceObject:withObject:")]
	public virtual void ReplacingObject(NSKeyedArchiver archiver, NSObject oldObject, NSObject newObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
