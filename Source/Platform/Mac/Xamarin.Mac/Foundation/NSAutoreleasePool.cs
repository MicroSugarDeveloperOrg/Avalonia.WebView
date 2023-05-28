using System;
using ObjCRuntime;

namespace Foundation;

[Register("NSAutoreleasePool", true)]
public class NSAutoreleasePool : NSObject, IDisposable
{
	public override IntPtr ClassHandle => ObjCRuntime.Class.GetHandle("NSAutoreleasePool");

	[Export("init")]
	public NSAutoreleasePool()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = GetType() == typeof(NSAutoreleasePool);
		if (base.IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("init"));
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.GetHandle("init"));
		}
	}

	public NSAutoreleasePool(NSObjectFlag t)
		: base(t)
	{
	}

	public NSAutoreleasePool(IntPtr handle)
		: base(handle)
	{
	}
}
