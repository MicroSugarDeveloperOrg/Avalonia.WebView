using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace StoreKit;

[Register("SKProductDiscount", true)]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
public class SKProductDiscount : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifier = "identifier";

	private static readonly IntPtr selIdentifierHandle = Selector.GetHandle("identifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfPeriods = "numberOfPeriods";

	private static readonly IntPtr selNumberOfPeriodsHandle = Selector.GetHandle("numberOfPeriods");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaymentMode = "paymentMode";

	private static readonly IntPtr selPaymentModeHandle = Selector.GetHandle("paymentMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrice = "price";

	private static readonly IntPtr selPriceHandle = Selector.GetHandle("price");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPriceLocale = "priceLocale";

	private static readonly IntPtr selPriceLocaleHandle = Selector.GetHandle("priceLocale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubscriptionPeriod = "subscriptionPeriod";

	private static readonly IntPtr selSubscriptionPeriodHandle = Selector.GetHandle("subscriptionPeriod");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selType = "type";

	private static readonly IntPtr selTypeHandle = Selector.GetHandle("type");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKProductDiscount");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
	public virtual string? Identifier
	{
		[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
		[Export("identifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumberOfPeriods
	{
		[Export("numberOfPeriods")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfPeriodsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfPeriodsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKProductDiscountPaymentMode PaymentMode
	{
		[Export("paymentMode")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKProductDiscountPaymentMode)Messaging.UInt64_objc_msgSend(base.Handle, selPaymentModeHandle);
			}
			return (SKProductDiscountPaymentMode)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selPaymentModeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDecimalNumber Price
	{
		[Export("price")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selPriceHandle));
			}
			return Runtime.GetNSObject<NSDecimalNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPriceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSLocale PriceLocale
	{
		[Export("priceLocale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSend(base.Handle, selPriceLocaleHandle));
			}
			return Runtime.GetNSObject<NSLocale>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPriceLocaleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SKProductSubscriptionPeriod SubscriptionPeriod
	{
		[Export("subscriptionPeriod")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKProductSubscriptionPeriod>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubscriptionPeriodHandle));
			}
			return Runtime.GetNSObject<SKProductSubscriptionPeriod>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubscriptionPeriodHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
	public virtual SKProductDiscountType Type
	{
		[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
		[Export("type")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (SKProductDiscountType)Messaging.Int64_objc_msgSend(base.Handle, selTypeHandle);
			}
			return (SKProductDiscountType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKProductDiscount()
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
	protected SKProductDiscount(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKProductDiscount(IntPtr handle)
		: base(handle)
	{
	}
}
