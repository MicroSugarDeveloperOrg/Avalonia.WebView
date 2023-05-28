using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace ImageCaptureCore;

[Register("ICDeviceBrowser", true)]
public class ICDeviceBrowser : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBrowsedDeviceTypeMask = "browsedDeviceTypeMask";

	private static readonly IntPtr selBrowsedDeviceTypeMaskHandle = Selector.GetHandle("browsedDeviceTypeMask");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelegate = "delegate";

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDevices = "devices";

	private static readonly IntPtr selDevicesHandle = Selector.GetHandle("devices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsBrowsing = "isBrowsing";

	private static readonly IntPtr selIsBrowsingHandle = Selector.GetHandle("isBrowsing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredDevice = "preferredDevice";

	private static readonly IntPtr selPreferredDeviceHandle = Selector.GetHandle("preferredDevice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBrowsedDeviceTypeMask_ = "setBrowsedDeviceTypeMask:";

	private static readonly IntPtr selSetBrowsedDeviceTypeMask_Handle = Selector.GetHandle("setBrowsedDeviceTypeMask:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDelegate_ = "setDelegate:";

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStart = "start";

	private static readonly IntPtr selStartHandle = Selector.GetHandle("start");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStop = "stop";

	private static readonly IntPtr selStopHandle = Selector.GetHandle("stop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ICDeviceBrowser");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICBrowsedDeviceType BrowsedDeviceTypeMask
	{
		[Export("browsedDeviceTypeMask", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (ICBrowsedDeviceType)Messaging.UInt64_objc_msgSend(base.Handle, selBrowsedDeviceTypeMaskHandle);
			}
			return (ICBrowsedDeviceType)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selBrowsedDeviceTypeMaskHandle);
		}
		[Export("setBrowsedDeviceTypeMask:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetBrowsedDeviceTypeMask_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetBrowsedDeviceTypeMask_Handle, (ulong)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Browsing
	{
		[Export("isBrowsing")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsBrowsingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsBrowsingHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IICDeviceBrowserDelegate? Delegate
	{
		get
		{
			return WeakDelegate as IICDeviceBrowserDelegate;
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
	public virtual ICDevice[]? Devices
	{
		[Export("devices")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<ICDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selDevicesHandle));
			}
			return NSArray.ArrayFromHandle<ICDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDevicesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ICDevice? PreferredDevice
	{
		[Export("preferredDevice")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<ICDevice>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferredDeviceHandle));
			}
			return Runtime.GetNSObject<ICDevice>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferredDeviceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject? WeakDelegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle)));
			MarkDirty();
			__mt_WeakDelegate_var = nSObject;
			return nSObject;
		}
		[Export("setDelegate:", ArgumentSemantic.Assign)]
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
	[Export("init")]
	public ICDeviceBrowser()
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
	protected ICDeviceBrowser(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ICDeviceBrowser(IntPtr handle)
		: base(handle)
	{
	}

	[Export("start")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Start()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStartHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStartHandle);
		}
	}

	[Export("stop")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Stop()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selStopHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selStopHandle);
		}
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
