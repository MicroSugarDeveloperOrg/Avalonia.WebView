using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreBluetooth;

[Register("CBMutableService", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class CBMutableService : CBService
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacteristics = "characteristics";

	private static readonly IntPtr selCharacteristicsHandle = Selector.GetHandle("characteristics");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncludedServices = "includedServices";

	private static readonly IntPtr selIncludedServicesHandle = Selector.GetHandle("includedServices");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithType_Primary_ = "initWithType:primary:";

	private static readonly IntPtr selInitWithType_Primary_Handle = Selector.GetHandle("initWithType:primary:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCharacteristics_ = "setCharacteristics:";

	private static readonly IntPtr selSetCharacteristics_Handle = Selector.GetHandle("setCharacteristics:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIncludedServices_ = "setIncludedServices:";

	private static readonly IntPtr selSetIncludedServices_Handle = Selector.GetHandle("setIncludedServices:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CBMutableService");

	[Obsolete("The setter is an empty stub (not mutable)")]
	public override bool Primary
	{
		get
		{
			return base.Primary;
		}
		set
		{
		}
	}

	[Obsolete("The setter is an empty stub (not mutable)")]
	public override CBUUID UUID
	{
		get
		{
			return base.UUID;
		}
		set
		{
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override CBCharacteristic[] Characteristics
	{
		[Export("characteristics", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CBCharacteristic>(Messaging.IntPtr_objc_msgSend(base.Handle, selCharacteristicsHandle));
			}
			return NSArray.ArrayFromHandle<CBCharacteristic>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCharacteristicsHandle));
		}
		[Export("setCharacteristics:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCharacteristics_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCharacteristics_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override CBService[] IncludedServices
	{
		[Export("includedServices", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<CBService>(Messaging.IntPtr_objc_msgSend(base.Handle, selIncludedServicesHandle));
			}
			return NSArray.ArrayFromHandle<CBService>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIncludedServicesHandle));
		}
		[Export("setIncludedServices:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIncludedServices_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIncludedServices_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CBMutableService(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CBMutableService(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithType:primary:")]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CBMutableService(CBUUID uuid, bool primary)
		: base(NSObjectFlag.Empty)
	{
		if (uuid == null)
		{
			throw new ArgumentNullException("uuid");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selInitWithType_Primary_Handle, uuid.Handle, primary), "initWithType:primary:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selInitWithType_Primary_Handle, uuid.Handle, primary), "initWithType:primary:");
		}
	}
}
