using System;
using Foundation;

namespace CoreFoundation;

public class CFNotificationObserverToken
{
	internal IntPtr centerHandle;

	internal IntPtr nameHandle;

	internal IntPtr observedObject;

	internal string stringName;

	internal Action<string, NSDictionary> listener;

	internal CFNotificationObserverToken()
	{
	}
}
