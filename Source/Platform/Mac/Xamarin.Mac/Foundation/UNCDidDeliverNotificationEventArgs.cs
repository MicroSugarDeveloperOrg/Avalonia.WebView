using System;

namespace Foundation;

public class UNCDidDeliverNotificationEventArgs : EventArgs
{
	public NSUserNotification Notification { get; set; }

	public UNCDidDeliverNotificationEventArgs(NSUserNotification notification)
	{
		Notification = notification;
	}
}
