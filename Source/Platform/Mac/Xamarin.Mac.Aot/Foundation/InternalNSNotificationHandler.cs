using System;

namespace Foundation;

[Register]
internal class InternalNSNotificationHandler : NSObject
{
	private NSNotificationCenter notificationCenter;

	private Action<NSNotification> notify;

	public InternalNSNotificationHandler(NSNotificationCenter notificationCenter, Action<NSNotification> notify)
	{
		this.notificationCenter = notificationCenter;
		this.notify = notify;
	}

	[Export("post:")]
	[Preserve(Conditional = true)]
	public void Post(NSNotification s)
	{
		notify(s);
		s.Dispose();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && notificationCenter != null)
		{
			notificationCenter.RemoveObserver(this);
			notificationCenter = null;
		}
		base.Dispose(disposing);
	}
}
