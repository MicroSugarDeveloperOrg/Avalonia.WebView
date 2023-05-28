using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace CoreFoundation;

public class CFNotificationCenter : INativeObject, IDisposable
{
	private delegate void CFNotificationCallback(IntPtr center, IntPtr observer, IntPtr name, IntPtr obj, IntPtr userInfo);

	internal IntPtr handle;

	private static CFNotificationCenter darwinnc;

	private static CFNotificationCenter localnc;

	private static CFNotificationCenter distributednc;

	private Dictionary<string, List<CFNotificationObserverToken>> listeners = new Dictionary<string, List<CFNotificationObserverToken>>();

	private const string NullNotificationName = "NullNotificationName";

	public IntPtr Handle => handle;

	public static CFNotificationCenter Darwin => darwinnc ?? (darwinnc = new CFNotificationCenter(CFNotificationCenterGetDarwinNotifyCenter()));

	public static CFNotificationCenter Distributed => distributednc ?? (distributednc = new CFNotificationCenter(CFNotificationCenterGetDistributedCenter()));

	public static CFNotificationCenter Local => localnc ?? (localnc = new CFNotificationCenter(CFNotificationCenterGetLocalCenter()));

	internal CFNotificationCenter(IntPtr handle)
		: this(handle, ownsHandle: false)
	{
	}

	internal CFNotificationCenter(IntPtr handle, bool ownsHandle)
	{
		if (!ownsHandle)
		{
			CFObject.CFRetain(handle);
		}
		this.handle = handle;
	}

	~CFNotificationCenter()
	{
		Dispose(disposing: false);
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFNotificationCenterGetDarwinNotifyCenter();

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFNotificationCenterGetDistributedCenter();

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern IntPtr CFNotificationCenterGetLocalCenter();

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (handle != IntPtr.Zero)
		{
			CFObject.CFRelease(handle);
			handle = IntPtr.Zero;
		}
	}

	public CFNotificationObserverToken AddObserver(string name, INativeObject objectToObserve, Action<string, NSDictionary> notificationHandler, CFNotificationSuspensionBehavior suspensionBehavior = CFNotificationSuspensionBehavior.DeliverImmediately)
	{
		if (darwinnc != null && darwinnc.Handle == Handle && name == null)
		{
			throw new ArgumentNullException("name", "When using the Darwin Notification Center, the value passed must not be null");
		}
		IntPtr intPtr = ((name == null) ? IntPtr.Zero : NSString.CreateNative(name));
		name = name ?? "NullNotificationName";
		CFNotificationObserverToken cFNotificationObserverToken = new CFNotificationObserverToken
		{
			stringName = name,
			centerHandle = handle,
			nameHandle = intPtr,
			observedObject = (objectToObserve?.Handle ?? IntPtr.Zero),
			listener = notificationHandler
		};
		lock (listeners)
		{
			if (!listeners.TryGetValue(name, out var value))
			{
				value = new List<CFNotificationObserverToken>(1);
				CFNotificationCenterAddObserver(handle, handle, NotificationCallback, intPtr, cFNotificationObserverToken.observedObject, (IntPtr)(long)suspensionBehavior);
			}
			else
			{
				value = new List<CFNotificationObserverToken>(value);
			}
			value.Add(cFNotificationObserverToken);
			listeners[name] = value;
		}
		return cFNotificationObserverToken;
	}

	private void notification(string name, NSDictionary userInfo)
	{
		bool flag;
		List<CFNotificationObserverToken> value;
		bool flag2;
		List<CFNotificationObserverToken> value2;
		lock (listeners)
		{
			flag = listeners.TryGetValue(name, out value);
			flag2 = listeners.TryGetValue("NullNotificationName", out value2);
		}
		if (flag)
		{
			foreach (CFNotificationObserverToken item in value)
			{
				item.listener(name, userInfo);
			}
		}
		if (!flag2)
		{
			return;
		}
		foreach (CFNotificationObserverToken item2 in value2)
		{
			item2.listener(name, userInfo);
		}
	}

	[MonoPInvokeCallback(typeof(CFNotificationCallback))]
	private static void NotificationCallback(IntPtr centerPtr, IntPtr observer, IntPtr name, IntPtr obj, IntPtr userInfo)
	{
		CFNotificationCenter cFNotificationCenter;
		if (darwinnc != null && centerPtr == darwinnc.Handle)
		{
			cFNotificationCenter = darwinnc;
		}
		else if (localnc != null && centerPtr == localnc.Handle)
		{
			cFNotificationCenter = localnc;
		}
		else
		{
			if (distributednc == null || !(centerPtr == distributednc.Handle))
			{
				return;
			}
			cFNotificationCenter = distributednc;
		}
		cFNotificationCenter.notification(NSString.FromHandle(name), (userInfo == IntPtr.Zero) ? null : Runtime.GetNSObject<NSDictionary>(userInfo));
	}

	public void PostNotification(string notification, INativeObject objectToObserve, NSDictionary userInfo = null, bool deliverImmediately = false, bool postOnAllSessions = false)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		IntPtr name = NSString.CreateNative(notification);
		CFNotificationCenterPostNotificationWithOptions(handle, name, objectToObserve?.Handle ?? IntPtr.Zero, userInfo?.Handle ?? IntPtr.Zero, (deliverImmediately ? 1 : 0) | (postOnAllSessions ? 2 : 0));
		NSString.ReleaseNative(name);
	}

	public void RemoveObserver(CFNotificationObserverToken token)
	{
		if (token == null)
		{
			throw new ArgumentNullException("token");
		}
		if (token.nameHandle == IntPtr.Zero && token.stringName != "NullNotificationName")
		{
			throw new ObjectDisposedException("token");
		}
		if (token.centerHandle != handle)
		{
			throw new ArgumentException("token", "This token belongs to a different notification center");
		}
		lock (listeners)
		{
			List<CFNotificationObserverToken> list = listeners[token.stringName];
			List<CFNotificationObserverToken> list2 = null;
			foreach (CFNotificationObserverToken item in list)
			{
				if (item != token)
				{
					if (list2 == null)
					{
						list2 = new List<CFNotificationObserverToken>();
					}
					list2.Add(item);
				}
			}
			if (list2 != null)
			{
				listeners[token.stringName] = list2;
				return;
			}
			listeners.Remove(token.stringName);
		}
		CFNotificationCenterRemoveObserver(handle, Handle, token.nameHandle, token.observedObject);
		NSString.ReleaseNative(token.nameHandle);
		token.nameHandle = IntPtr.Zero;
	}

	public void RemoveEveryObserver()
	{
		lock (listeners)
		{
			string[] array = new string[listeners.Keys.Count];
			listeners.Keys.CopyTo(array, 0);
			string[] array2 = array;
			foreach (string key in array2)
			{
				List<CFNotificationObserverToken> collection = listeners[key];
				List<CFNotificationObserverToken> list = new List<CFNotificationObserverToken>(collection);
				foreach (CFNotificationObserverToken item in list)
				{
					RemoveObserver(item);
				}
			}
			listeners.Clear();
		}
	}

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFNotificationCenterAddObserver(IntPtr center, IntPtr observer, CFNotificationCallback callback, IntPtr name, IntPtr obj, IntPtr suspensionBehavior);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFNotificationCenterPostNotificationWithOptions(IntPtr center, IntPtr name, IntPtr obj, IntPtr userInfo, int options);

	[DllImport("/System/Library/Frameworks/CoreFoundation.framework/CoreFoundation")]
	private static extern void CFNotificationCenterRemoveObserver(IntPtr center, IntPtr observer, IntPtr name, IntPtr obj);
}
