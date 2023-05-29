using System;
using System.Collections.Generic;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSNotificationCenter", true)]
public class NSNotificationCenter : NSObject
{
	private class ObservedData
	{
		public NSObject Observer;

		public string Name;

		public NSObject Object;
	}

	private const string postSelector = "post:";

	private List<ObservedData> __mt_ObserverList_var = new List<ObservedData>();

	private static readonly IntPtr selDefaultCenterHandle = Selector.GetHandle("defaultCenter");

	private static readonly IntPtr selAddObserverSelectorNameObject_Handle = Selector.GetHandle("addObserver:selector:name:object:");

	private static readonly IntPtr selPostNotification_Handle = Selector.GetHandle("postNotification:");

	private static readonly IntPtr selPostNotificationNameObject_Handle = Selector.GetHandle("postNotificationName:object:");

	private static readonly IntPtr selPostNotificationNameObjectUserInfo_Handle = Selector.GetHandle("postNotificationName:object:userInfo:");

	private static readonly IntPtr selRemoveObserver_Handle = Selector.GetHandle("removeObserver:");

	private static readonly IntPtr selRemoveObserverNameObject_Handle = Selector.GetHandle("removeObserver:name:object:");

	private static readonly IntPtr selAddObserverForNameObjectQueueUsingBlock_Handle = Selector.GetHandle("addObserverForName:object:queue:usingBlock:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSNotificationCenter");

	private static object __mt_DefaultCenter_var_static;

	public override IntPtr ClassHandle => class_ptr;

	public static NSNotificationCenter DefaultCenter
	{
		[Export("defaultCenter")]
		get
		{
			return (NSNotificationCenter)(__mt_DefaultCenter_var_static = (NSNotificationCenter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultCenterHandle)));
		}
	}

	[Advice("Use AddObserver(NSString, Action<NSNotification>, NSObject)")]
	public NSObject AddObserver(string aName, Action<NSNotification> notify, NSObject fromObject)
	{
		return AddObserver(new NSString(aName), notify, fromObject);
	}

	public NSObject AddObserver(NSString aName, Action<NSNotification> notify, NSObject fromObject)
	{
		if (notify == null)
		{
			throw new ArgumentNullException("notify");
		}
		InternalNSNotificationHandler internalNSNotificationHandler = new InternalNSNotificationHandler(this, notify);
		AddObserver(internalNSNotificationHandler, new Selector("post:"), aName, fromObject);
		return internalNSNotificationHandler;
	}

	public NSObject AddObserver(NSString aName, Action<NSNotification> notify)
	{
		return AddObserver(aName, notify, null);
	}

	[Advice("Use AddObserver(NSString, Action<NSNotification>) instead")]
	public NSObject AddObserver(string aName, Action<NSNotification> notify)
	{
		return AddObserver(aName, notify, null);
	}

	[Advice("Use AddObserver(NSObject, Selector, NSString, NSObject) instead")]
	public void AddObserver(NSObject observer, Selector aSelector, string aname, NSObject anObject)
	{
		AddObserver(observer, aSelector, new NSString(aname), anObject);
	}

	public void RemoveObservers(IEnumerable<NSObject> keys)
	{
		if (keys == null)
		{
			return;
		}
		foreach (NSObject key in keys)
		{
			RemoveObserver(key);
		}
	}

	private void AddObserverToList(NSObject observer, string aName, NSObject anObject)
	{
		__mt_ObserverList_var.Add(new ObservedData
		{
			Observer = observer,
			Name = aName,
			Object = anObject
		});
	}

	private void RemoveObserversFromList(NSObject observer, string aName, NSObject anObject)
	{
		for (int num = __mt_ObserverList_var.Count - 1; num >= 0; num--)
		{
			ObservedData observedData = __mt_ObserverList_var[num];
			if (observer == observedData.Observer && (aName == null || !(aName != observedData.Name)) && (anObject == null || anObject == observedData.Object))
			{
				__mt_ObserverList_var.RemoveAt(num);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSNotificationCenter()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSNotificationCenter(NSCoder coder)
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
	public NSNotificationCenter(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSNotificationCenter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addObserver:selector:name:object:")]
	public virtual void AddObserver(NSObject observer, Selector aSelector, NSString aName, NSObject anObject)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (aSelector == null)
		{
			throw new ArgumentNullException("aSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selAddObserverSelectorNameObject_Handle, observer.Handle, aSelector.Handle, (aName == null) ? IntPtr.Zero : aName.Handle, anObject?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddObserverSelectorNameObject_Handle, observer.Handle, aSelector.Handle, (aName == null) ? IntPtr.Zero : aName.Handle, anObject?.Handle ?? IntPtr.Zero);
		}
		AddObserverToList(observer, aName, anObject);
	}

	[Export("postNotification:")]
	public virtual void PostNotification(NSNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPostNotification_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPostNotification_Handle, notification.Handle);
		}
	}

	[Export("postNotificationName:object:")]
	public virtual void PostNotificationName(string aName, NSObject anObject)
	{
		if (aName == null)
		{
			throw new ArgumentNullException("aName");
		}
		IntPtr arg = NSString.CreateNative(aName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPostNotificationNameObject_Handle, arg, anObject?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPostNotificationNameObject_Handle, arg, anObject?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("postNotificationName:object:userInfo:")]
	public virtual void PostNotificationName(string aName, NSObject anObject, NSDictionary aUserInfo)
	{
		if (aName == null)
		{
			throw new ArgumentNullException("aName");
		}
		IntPtr arg = NSString.CreateNative(aName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selPostNotificationNameObjectUserInfo_Handle, arg, anObject?.Handle ?? IntPtr.Zero, aUserInfo?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPostNotificationNameObjectUserInfo_Handle, arg, anObject?.Handle ?? IntPtr.Zero, aUserInfo?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeObserver:")]
	public virtual void RemoveObserver(NSObject observer)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveObserver_Handle, observer.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveObserver_Handle, observer.Handle);
		}
		RemoveObserversFromList(observer, null, null);
	}

	[Export("removeObserver:name:object:")]
	public virtual void RemoveObserver(NSObject observer, string aName, NSObject anObject)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		IntPtr arg = NSString.CreateNative(aName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRemoveObserverNameObject_Handle, observer.Handle, arg, anObject?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRemoveObserverNameObject_Handle, observer.Handle, arg, anObject?.Handle ?? IntPtr.Zero);
		}
		RemoveObserversFromList(observer, aName, anObject);
		NSString.ReleaseNative(arg);
	}

	[Export("addObserverForName:object:queue:usingBlock:")]
	public unsafe virtual NSObject AddObserver(string name, NSObject obj, NSOperationQueue queue, NSNotificationHandler handler)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		if (queue == null)
		{
			throw new ArgumentNullException("queue");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		IntPtr arg = NSString.CreateNative(name);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSNotificationHandler.Handler, handler);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddObserverForNameObjectQueueUsingBlock_Handle, arg, obj.Handle, queue.Handle, (IntPtr)ptr)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selAddObserverForNameObjectQueueUsingBlock_Handle, arg, obj.Handle, queue.Handle, (IntPtr)ptr)));
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
		return result;
	}
}
