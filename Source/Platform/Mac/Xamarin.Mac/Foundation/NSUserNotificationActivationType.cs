using ObjCRuntime;

namespace Foundation;

[Native]
[Advice("'NSUserNotification' usages should be replaced with 'UserNotifications' framework.")]
public enum NSUserNotificationActivationType : long
{
	None,
	ContentsClicked,
	ActionButtonClicked,
	Replied,
	AdditionalActionClicked
}
