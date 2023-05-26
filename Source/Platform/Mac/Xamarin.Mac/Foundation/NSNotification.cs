using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSNotification", true)]
public class NSNotification : NSObject
{
	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selObjectHandle = Selector.GetHandle("object");

	private static readonly IntPtr selUserInfoHandle = Selector.GetHandle("userInfo");

	private static readonly IntPtr selNotificationWithNameObject_Handle = Selector.GetHandle("notificationWithName:object:");

	private static readonly IntPtr selNotificationWithNameObjectUserInfo_Handle = Selector.GetHandle("notificationWithName:object:userInfo:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSNotification");

	private object __mt_Object_var;

	private object __mt_UserInfo_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	public virtual NSObject Object
	{
		[Export("object")]
		get
		{
			return (NSObject)(__mt_Object_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectHandle))));
		}
	}

	public virtual NSDictionary UserInfo
	{
		[Export("userInfo")]
		get
		{
			return (NSDictionary)(__mt_UserInfo_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserInfoHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUserInfoHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSNotification(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSNotification(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSNotification(IntPtr handle)
		: base(handle)
	{
	}

	[Export("notificationWithName:object:")]
	public static NSNotification FromName(string name, NSObject obj)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSNotification result = (NSNotification)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selNotificationWithNameObject_Handle, arg, obj.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("notificationWithName:object:userInfo:")]
	public static NSNotification FromName(string name, NSObject obj, NSDictionary userInfo)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (userInfo == null)
		{
			throw new ArgumentNullException("userInfo");
		}
		IntPtr arg = NSString.CreateNative(name);
		NSNotification result = (NSNotification)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selNotificationWithNameObjectUserInfo_Handle, arg, obj.Handle, userInfo.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Object_var = null;
			__mt_UserInfo_var = null;
		}
	}
}
