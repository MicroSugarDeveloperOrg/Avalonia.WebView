using System;
using System.ComponentModel;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace PushKit;

[Register("PKPushRegistry", true)]
[Introduced(PlatformName.MacCatalyst, 13, 0, PlatformArchitecture.None, null)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class PKPushRegistry : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDesiredPushTypes = "desiredPushTypes";

	private static readonly IntPtr selDesiredPushTypesHandle = Selector.GetHandle("desiredPushTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithQueue_ = "initWithQueue:";

	private static readonly IntPtr selInitWithQueue_Handle = Selector.GetHandle("initWithQueue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPushTokenForType_ = "pushTokenForType:";

	private static readonly IntPtr selPushTokenForType_Handle = Selector.GetHandle("pushTokenForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDesiredPushTypes_ = "setDesiredPushTypes:";

	private static readonly IntPtr selSetDesiredPushTypes_Handle = Selector.GetHandle("setDesiredPushTypes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PKPushRegistry");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IPKPushRegistryDelegate Delegate
	{
		get
		{
			return WeakDelegate as IPKPushRegistryDelegate;
		}
		set
		{
			NSObject nSObject = value as NSObject;
			if (value != null && nSObject == null)
			{
				throw new ArgumentException("The object passed of type " + value.GetType()?.ToString() + " does not derive from NSObject");
			}
			WeakDelegate = nSObject;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSSet? DesiredPushTypes
	{
		[Export("desiredPushTypes", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selDesiredPushTypesHandle));
			}
			return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDesiredPushTypesHandle));
		}
		[Export("setDesiredPushTypes:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDesiredPushTypes_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDesiredPushTypes_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Weak)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Weak)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value?.Handle ?? IntPtr.Zero);
			}
			MarkDirty();
			__mt_WeakDelegate_var = value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PKPushRegistry(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PKPushRegistry(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithQueue:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PKPushRegistry(DispatchQueue? queue)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithQueue_Handle, (queue == null) ? IntPtr.Zero : queue.Handle), "initWithQueue:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithQueue_Handle, (queue == null) ? IntPtr.Zero : queue.Handle), "initWithQueue:");
		}
	}

	[Export("pushTokenForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? PushToken(string type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPushTokenForType_Handle, arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPushTokenForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_WeakDelegate_var = null;
		}
	}
}
