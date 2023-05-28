using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSAccessibility
{
	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	[Mac(10, 10)]
	private static extern CGRect NSAccessibilityFrameInView(NSView parentView, CGRect frame);

	public static CGRect GetFrameInView(NSView parentView, CGRect frame)
	{
		return NSAccessibilityFrameInView(parentView, frame);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	[Mac(10, 10)]
	private static extern CGPoint NSAccessibilityPointInView(NSView parentView, CGPoint point);

	public static CGPoint GetPointInView(NSView parentView, CGPoint point)
	{
		return NSAccessibilityPointInView(parentView, point);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern void NSAccessibilityPostNotificationWithUserInfo(IntPtr element, IntPtr notification, IntPtr userInfo);

	public static void PostNotification(NSObject element, NSString notification, NSDictionary userInfo)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		NSAccessibilityPostNotificationWithUserInfo(userInfo: userInfo?.Handle ?? IntPtr.Zero, element: element.Handle, notification: notification.Handle);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern void NSAccessibilityPostNotification(IntPtr element, IntPtr notification);

	public static void PostNotification(NSObject element, NSString notification)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		NSAccessibilityPostNotification(element.Handle, notification.Handle);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern IntPtr NSAccessibilityRoleDescription(IntPtr role, IntPtr subrole);

	public static string GetRoleDescription(NSString role, NSString subrole)
	{
		if (role == null)
		{
			throw new ArgumentNullException("role");
		}
		IntPtr usrhandle = NSAccessibilityRoleDescription(subrole: (!(subrole == null)) ? subrole.Handle : IntPtr.Zero, role: role.Handle);
		return NSString.FromHandle(usrhandle);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern IntPtr NSAccessibilityRoleDescriptionForUIElement(IntPtr element);

	public static string GetRoleDescription(NSObject element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		IntPtr usrhandle = NSAccessibilityRoleDescriptionForUIElement(element.Handle);
		return NSString.FromHandle(usrhandle);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern IntPtr NSAccessibilityActionDescription(IntPtr action);

	public static string GetActionDescription(NSString action)
	{
		if (action == null)
		{
			throw new ArgumentNullException("action");
		}
		IntPtr usrhandle = NSAccessibilityActionDescription(action.Handle);
		return NSString.FromHandle(usrhandle);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern IntPtr NSAccessibilityUnignoredAncestor(IntPtr element);

	public static NSObject GetUnignoredAncestor(NSObject element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		IntPtr ptr = NSAccessibilityUnignoredAncestor(element.Handle);
		return Runtime.GetNSObject(ptr);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern IntPtr NSAccessibilityUnignoredDescendant(IntPtr element);

	public static NSObject GetUnignoredDescendant(NSObject element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		IntPtr ptr = NSAccessibilityUnignoredDescendant(element.Handle);
		return Runtime.GetNSObject(ptr);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern IntPtr NSAccessibilityUnignoredChildren(IntPtr originalChildren);

	public static NSObject[] GetUnignoredChildren(NSArray originalChildren)
	{
		if (originalChildren == null)
		{
			throw new ArgumentNullException("originalChildren");
		}
		IntPtr handle = NSAccessibilityUnignoredChildren(originalChildren.Handle);
		return NSArray.ArrayFromHandle<NSObject>(handle);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	private static extern IntPtr NSAccessibilityUnignoredChildrenForOnlyChild(IntPtr originalChild);

	public static NSObject[] GetUnignoredChildren(NSObject originalChild)
	{
		if (originalChild == null)
		{
			throw new ArgumentNullException("originalChild");
		}
		IntPtr handle = NSAccessibilityUnignoredChildrenForOnlyChild(originalChild.Handle);
		return NSArray.ArrayFromHandle<NSObject>(handle);
	}

	[DllImport("/System/Library/Frameworks/AppKit.framework/AppKit")]
	[Mac(10, 9)]
	private static extern bool NSAccessibilitySetMayContainProtectedContent(bool flag);

	public static bool SetMayContainProtectedContent(bool flag)
	{
		return NSAccessibilitySetMayContainProtectedContent(flag);
	}
}
