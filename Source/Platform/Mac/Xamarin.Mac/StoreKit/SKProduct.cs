using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Register("SKProduct", true)]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
public class SKProduct : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentLengths = "contentLengths";

	private static readonly IntPtr selContentLengthsHandle = Selector.GetHandle("contentLengths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContentVersion = "contentVersion";

	private static readonly IntPtr selContentVersionHandle = Selector.GetHandle("contentVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDiscounts = "discounts";

	private static readonly IntPtr selDiscountsHandle = Selector.GetHandle("discounts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadContentLengths = "downloadContentLengths";

	private static readonly IntPtr selDownloadContentLengthsHandle = Selector.GetHandle("downloadContentLengths");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadContentVersion = "downloadContentVersion";

	private static readonly IntPtr selDownloadContentVersionHandle = Selector.GetHandle("downloadContentVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownloadable = "downloadable";

	private static readonly IntPtr selDownloadableHandle = Selector.GetHandle("downloadable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIntroductoryPrice = "introductoryPrice";

	private static readonly IntPtr selIntroductoryPriceHandle = Selector.GetHandle("introductoryPrice");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDownloadable = "isDownloadable";

	private static readonly IntPtr selIsDownloadableHandle = Selector.GetHandle("isDownloadable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedDescription = "localizedDescription";

	private static readonly IntPtr selLocalizedDescriptionHandle = Selector.GetHandle("localizedDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedTitle = "localizedTitle";

	private static readonly IntPtr selLocalizedTitleHandle = Selector.GetHandle("localizedTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrice = "price";

	private static readonly IntPtr selPriceHandle = Selector.GetHandle("price");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPriceLocale = "priceLocale";

	private static readonly IntPtr selPriceLocaleHandle = Selector.GetHandle("priceLocale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProductIdentifier = "productIdentifier";

	private static readonly IntPtr selProductIdentifierHandle = Selector.GetHandle("productIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubscriptionGroupIdentifier = "subscriptionGroupIdentifier";

	private static readonly IntPtr selSubscriptionGroupIdentifierHandle = Selector.GetHandle("subscriptionGroupIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubscriptionPeriod = "subscriptionPeriod";

	private static readonly IntPtr selSubscriptionPeriodHandle = Selector.GetHandle("subscriptionPeriod");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKProduct");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 9, 0, PlatformArchitecture.None, "Use 'DownloadContentLengths' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'DownloadContentLengths' instead.")]
	public virtual NSNumber[] ContentLengths
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.TvOS, 9, 0, PlatformArchitecture.None, "Use 'DownloadContentLengths' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'DownloadContentLengths' instead.")]
		[Export("contentLengths")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selContentLengthsHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentLengthsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.TvOS, 9, 0, PlatformArchitecture.None, "Use 'DownloadContentVersion' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'DownloadContentVersion' instead.")]
	public virtual string ContentVersion
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.TvOS, 9, 0, PlatformArchitecture.None, "Use 'DownloadContentVersion' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'DownloadContentVersion' instead.")]
		[Export("contentVersion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selContentVersionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentVersionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
	public virtual SKProductDiscount[] Discounts
	{
		[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
		[Export("discounts")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<SKProductDiscount>(Messaging.IntPtr_objc_msgSend(base.Handle, selDiscountsHandle));
			}
			return NSArray.ArrayFromHandle<SKProductDiscount>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDiscountsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual NSNumber[] DownloadContentLengths
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("downloadContentLengths")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selDownloadContentLengthsHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDownloadContentLengthsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual string DownloadContentVersion
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("downloadContentVersion")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDownloadContentVersionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDownloadContentVersionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'IsDownloadable' instead.")]
	public virtual bool Downloadable
	{
		[Deprecated(PlatformName.MacOSX, 10, 15, PlatformArchitecture.None, "Use 'IsDownloadable' instead.")]
		[Export("downloadable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDownloadableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDownloadableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
	public virtual SKProductDiscount? IntroductoryPrice
	{
		[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
		[Export("introductoryPrice")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKProductDiscount>(Messaging.IntPtr_objc_msgSend(base.Handle, selIntroductoryPriceHandle));
			}
			return Runtime.GetNSObject<SKProductDiscount>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIntroductoryPriceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public virtual bool IsDownloadable
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		[Export("isDownloadable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsDownloadableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsDownloadableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LocalizedDescription
	{
		[Export("localizedDescription")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LocalizedTitle
	{
		[Export("localizedTitle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedTitleHandle));
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
	public virtual string ProductIdentifier
	{
		[Export("productIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selProductIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProductIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual string? SubscriptionGroupIdentifier
	{
		[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("subscriptionGroupIdentifier")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSubscriptionGroupIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubscriptionGroupIdentifierHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
	public virtual SKProductSubscriptionPeriod? SubscriptionPeriod
	{
		[Introduced(PlatformName.iOS, 11, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKProduct()
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
	protected SKProduct(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKProduct(IntPtr handle)
		: base(handle)
	{
	}
}
