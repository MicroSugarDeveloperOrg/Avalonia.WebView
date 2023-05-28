using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

public class NSFileHandleConnectionAcceptedEventArgs : NSNotificationEventArgs
{
	[Field("NSFileHandleNotificationFileHandleItem", "Foundation")]
	private static IntPtr k0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSFileHandle NearSocketConnection
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.Foundation.Handle, "NSFileHandleNotificationFileHandleItem");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<NSFileHandle>(ptr);
		}
	}

	public nint UnixErrorCode
	{
		get
		{
			IntPtr intPtr;
			using (NSString nSString = new NSString("NSFileHandleError"))
			{
				intPtr = base.Notification.UserInfo?.LowlevelObjectForKey(nSString.Handle) ?? IntPtr.Zero;
			}
			if (intPtr == IntPtr.Zero)
			{
				return default(nint);
			}
			using NSNumber nSNumber = Runtime.GetNSObject<NSNumber>(intPtr);
			return nSNumber.NIntValue;
		}
	}

	public NSFileHandleConnectionAcceptedEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
