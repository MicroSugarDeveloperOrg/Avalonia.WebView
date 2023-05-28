using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Register("SKProductSubscriptionPeriod", true)]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
public class SKProductSubscriptionPeriod : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfUnits = "numberOfUnits";

	private static readonly IntPtr selNumberOfUnitsHandle = Selector.GetHandle("numberOfUnits");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnit = "unit";

	private static readonly IntPtr selUnitHandle = Selector.GetHandle("unit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKProductSubscriptionPeriod");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumberOfUnits
	{
		[Export("numberOfUnits")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfUnitsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfUnitsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKProductPeriodUnit Unit
	{
		[Export("unit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKProductPeriodUnit)Messaging.UInt64_objc_msgSend(base.Handle, selUnitHandle);
			}
			return (SKProductPeriodUnit)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selUnitHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKProductSubscriptionPeriod()
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
	protected SKProductSubscriptionPeriod(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKProductSubscriptionPeriod(IntPtr handle)
		: base(handle)
	{
	}
}
