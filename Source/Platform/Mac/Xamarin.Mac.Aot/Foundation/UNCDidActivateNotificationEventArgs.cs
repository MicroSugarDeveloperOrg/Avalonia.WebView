using System;

namespace Foundation;

public class UNCDidActivateNotificationEventArgs : EventArgs
{
	public NSUserNotification Notification { get; set; }

	public UNCDidActivateNotificationEventArgs(NSUserNotification notification)
	{
		Notification = notification;
	}
}
