using System;
using ObjCRuntime;

namespace Foundation;

[Register("NSAutoreleasePool", true)]
public class NSAutoreleasePool : NSObject, IDisposable
{
	public override IntPtr ClassHandle => Class.GetHandle("NSAutoreleasePool");

	[Export("init")]
	public NSAutoreleasePool()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.intptr_objc_msgSend(base.Handle, Selector.GetHandle("init"));
		}
		else
		{
			base.Handle = Messaging.intptr_objc_msgSendSuper(base.SuperHandle, Selector.GetHandle("init"));
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

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}
}
