using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Protocol]
[Register("NSKeyedUnarchiverDelegate", true)]
[Model]
public class NSKeyedUnarchiverDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSKeyedUnarchiverDelegate()
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
	public NSKeyedUnarchiverDelegate(NSCoder coder)
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
	public NSKeyedUnarchiverDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSKeyedUnarchiverDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("unarchiver:didDecodeObject:")]
	public virtual NSObject DecodedObject(NSKeyedUnarchiver unarchiver, NSObject obj)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("unarchiverDidFinish:")]
	public virtual void Finished(NSKeyedUnarchiver unarchiver)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("unarchiver:cannotDecodeObjectOfClassName:originalClasses:")]
	public virtual Class CannotDecodeClass(NSKeyedUnarchiver unarchiver, string klass, string[] classes)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("unarchiverWillFinish:")]
	public virtual void Finishing(NSKeyedUnarchiver unarchiver)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("unarchiver:willReplaceObject:withObject:")]
	public virtual void ReplacingObject(NSKeyedUnarchiver unarchiver, NSObject oldObject, NSObject newObject)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
