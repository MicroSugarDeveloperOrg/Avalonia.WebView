using System;
using ObjCRuntime;

namespace Foundation;

public static class NSUserActivityDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UserActivityWillSave(this INSUserActivityDelegate This, NSUserActivity userActivity)
	{
		if (userActivity == null)
		{
			throw new ArgumentNullException("userActivity");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("userActivityWillSave:"), userActivity.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UserActivityWasContinued(this INSUserActivityDelegate This, NSUserActivity userActivity)
	{
		if (userActivity == null)
		{
			throw new ArgumentNullException("userActivity");
		}
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("userActivityWasContinued:"), userActivity.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UserActivityReceivedData(this INSUserActivityDelegate This, NSUserActivity userActivity, NSInputStream inputStream, NSOutputStream outputStream)
	{
		if (userActivity == null)
		{
			throw new ArgumentNullException("userActivity");
		}
		if (inputStream == null)
		{
			throw new ArgumentNullException("inputStream");
		}
		if (outputStream == null)
		{
			throw new ArgumentNullException("outputStream");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("userActivity:didReceiveInputStream:outputStream:"), userActivity.Handle, inputStream.Handle, outputStream.Handle);
	}
}
