using System;
using ObjCRuntime;

namespace Foundation;

internal sealed class NSUserNotificationCenterDelegateWrapper : BaseWrapper, INSUserNotificationCenterDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSUserNotificationCenterDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
