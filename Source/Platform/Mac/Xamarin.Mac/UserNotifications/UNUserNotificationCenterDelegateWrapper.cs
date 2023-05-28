using System;
using Foundation;
using ObjCRuntime;

namespace UserNotifications;

internal sealed class UNUserNotificationCenterDelegateWrapper : BaseWrapper, IUNUserNotificationCenterDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public UNUserNotificationCenterDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
