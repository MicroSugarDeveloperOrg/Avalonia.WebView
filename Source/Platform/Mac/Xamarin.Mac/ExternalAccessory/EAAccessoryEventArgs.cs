using System;
using Foundation;
using ObjCRuntime;

namespace ExternalAccessory;

public class EAAccessoryEventArgs : NSNotificationEventArgs
{
	[Field("EAAccessoryKey", "ExternalAccessory")]
	private static IntPtr k0;

	[Field("EAAccessorySelectedKey", "ExternalAccessory")]
	private static IntPtr k1;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public EAAccessory Accessory
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.ExternalAccessory.Handle, "EAAccessoryKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<EAAccessory>(ptr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public EAAccessory Selected
	{
		get
		{
			if (k1 == IntPtr.Zero)
			{
				k1 = Dlfcn.GetIntPtr(Libraries.ExternalAccessory.Handle, "EAAccessorySelectedKey");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k1) ?? IntPtr.Zero;
			return Runtime.GetNSObject<EAAccessory>(ptr);
		}
	}

	public EAAccessoryEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
