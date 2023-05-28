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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObserver_Selector_Name_Object_ = "addObserver:selector:name:object:";

	private static readonly IntPtr selAddObserver_Selector_Name_Object_Handle = Selector.GetHandle("addObserver:selector:name:object:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddObserverForName_Object_Queue_UsingBlock_ = "addObserverForName:object:queue:usingBlock:";

	private static readonly IntPtr selAddObserverForName_Object_Queue_UsingBlock_Handle = Selector.GetHandle("addObserverForName:object:queue:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultCenter = "defaultCenter";

	private static readonly IntPtr selDefaultCenterHandle = Selector.GetHandle("defaultCenter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPostNotification_ = "postNotification:";

	private static readonly IntPtr selPostNotification_Handle = Selector.GetHandle("postNotification:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPostNotificationName_Object_ = "postNotificationName:object:";

	private static readonly IntPtr selPostNotificationName_Object_Handle = Selector.GetHandle("postNotificationName:object:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPostNotificationName_Object_UserInfo_ = "postNotificationName:object:userInfo:";

	private static readonly IntPtr selPostNotificationName_Object_UserInfo_Handle = Selector.GetHandle("postNotificationName:object:userInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObserver_ = "removeObserver:";

	private static readonly IntPtr selRemoveObserver_Handle = Selector.GetHandle("removeObserver:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveObserver_Name_Object_ = "removeObserver:name:object:";

	private static readonly IntPtr selRemoveObserver_Name_Object_Handle = Selector.GetHandle("removeObserver:name:object:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSNotificationCenter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSNotificationCenter DefaultCenter
	{
		[Export("defaultCenter", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSNotificationCenter>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultCenterHandle));
		}
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
		lock (__mt_ObserverList_var)
		{
			__mt_ObserverList_var.Add(new ObservedData
			{
				Observer = observer,
				Name = aName,
				Object = anObject
			});
		}
		MarkDirty();
	}

	private void RemoveObserversFromList(NSObject observer, string aName, NSObject anObject)
	{
		lock (__mt_ObserverList_var)
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSNotificationCenter()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSNotificationCenter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSNotificationCenter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addObserver:selector:name:object:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddObserver(NSObject observer, Selector aSelector, NSString? aName, NSObject? anObject)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (aSelector == null)
		{
			throw new ArgumentNullException("aSelector");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selAddObserver_Selector_Name_Object_Handle, observer.Handle, aSelector.Handle, (aName == null) ? IntPtr.Zero : aName.Handle, anObject?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddObserver_Selector_Name_Object_Handle, observer.Handle, aSelector.Handle, (aName == null) ? IntPtr.Zero : aName.Handle, anObject?.Handle ?? IntPtr.Zero);
		}
		AddObserverToList(observer, aName, anObject);
	}

	[Export("addObserverForName:object:queue:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSObject AddObserver(string? name, NSObject? obj, NSOperationQueue? queue, [BlockProxy(typeof(Trampolines.NIDActionArity1V32))] Action<NSNotification> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		IntPtr arg = NSString.CreateNative(name);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V32.Handler, handler);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selAddObserverForName_Object_Queue_UsingBlock_Handle, arg, obj?.Handle ?? IntPtr.Zero, queue?.Handle ?? IntPtr.Zero, (IntPtr)ptr)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selAddObserverForName_Object_Queue_UsingBlock_Handle, arg, obj?.Handle ?? IntPtr.Zero, queue?.Handle ?? IntPtr.Zero, (IntPtr)ptr)));
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
		return result;
	}

	[Export("postNotification:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PostNotification(NSNotification notification)
	{
		if (notification == null)
		{
			throw new ArgumentNullException("notification");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selPostNotification_Handle, notification.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selPostNotification_Handle, notification.Handle);
		}
	}

	[Export("postNotificationName:object:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PostNotificationName(string aName, NSObject? anObject)
	{
		if (aName == null)
		{
			throw new ArgumentNullException("aName");
		}
		IntPtr arg = NSString.CreateNative(aName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selPostNotificationName_Object_Handle, arg, anObject?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPostNotificationName_Object_Handle, arg, anObject?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("postNotificationName:object:userInfo:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PostNotificationName(string aName, NSObject? anObject, NSDictionary? aUserInfo)
	{
		if (aName == null)
		{
			throw new ArgumentNullException("aName");
		}
		IntPtr arg = NSString.CreateNative(aName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selPostNotificationName_Object_UserInfo_Handle, arg, anObject?.Handle ?? IntPtr.Zero, aUserInfo?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selPostNotificationName_Object_UserInfo_Handle, arg, anObject?.Handle ?? IntPtr.Zero, aUserInfo?.Handle ?? IntPtr.Zero);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeObserver:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObserver(NSObject observer)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		if (base.IsDirectBinding)
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
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveObserver(NSObject observer, string? aName, NSObject? anObject)
	{
		if (observer == null)
		{
			throw new ArgumentNullException("observer");
		}
		IntPtr arg = NSString.CreateNative(aName);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRemoveObserver_Name_Object_Handle, observer.Handle, arg, anObject?.Handle ?? IntPtr.Zero);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRemoveObserver_Name_Object_Handle, observer.Handle, arg, anObject?.Handle ?? IntPtr.Zero);
		}
		RemoveObserversFromList(observer, aName, anObject);
		NSString.ReleaseNative(arg);
	}
}
