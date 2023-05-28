using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Register("SKMutablePayment", true)]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
public class SKMutablePayment : SKPayment
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplicationUsername = "applicationUsername";

	private static readonly IntPtr selApplicationUsernameHandle = Selector.GetHandle("applicationUsername");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaymentDiscount = "paymentDiscount";

	private static readonly IntPtr selPaymentDiscountHandle = Selector.GetHandle("paymentDiscount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaymentWithProduct_ = "paymentWithProduct:";

	private static readonly IntPtr selPaymentWithProduct_Handle = Selector.GetHandle("paymentWithProduct:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPaymentWithProductIdentifier_ = "paymentWithProductIdentifier:";

	private static readonly IntPtr selPaymentWithProductIdentifier_Handle = Selector.GetHandle("paymentWithProductIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProductIdentifier = "productIdentifier";

	private static readonly IntPtr selProductIdentifierHandle = Selector.GetHandle("productIdentifier");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuantity = "quantity";

	private static readonly IntPtr selQuantityHandle = Selector.GetHandle("quantity");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestData = "requestData";

	private static readonly IntPtr selRequestDataHandle = Selector.GetHandle("requestData");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetApplicationUsername_ = "setApplicationUsername:";

	private static readonly IntPtr selSetApplicationUsername_Handle = Selector.GetHandle("setApplicationUsername:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPaymentDiscount_ = "setPaymentDiscount:";

	private static readonly IntPtr selSetPaymentDiscount_Handle = Selector.GetHandle("setPaymentDiscount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProductIdentifier_ = "setProductIdentifier:";

	private static readonly IntPtr selSetProductIdentifier_Handle = Selector.GetHandle("setProductIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetQuantity_ = "setQuantity:";

	private static readonly IntPtr selSetQuantity_Handle = Selector.GetHandle("setQuantity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequestData_ = "setRequestData:";

	private static readonly IntPtr selSetRequestData_Handle = Selector.GetHandle("setRequestData:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSimulatesAskToBuyInSandbox_ = "setSimulatesAskToBuyInSandbox:";

	private static readonly IntPtr selSetSimulatesAskToBuyInSandbox_Handle = Selector.GetHandle("setSimulatesAskToBuyInSandbox:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSimulatesAskToBuyInSandbox = "simulatesAskToBuyInSandbox";

	private static readonly IntPtr selSimulatesAskToBuyInSandboxHandle = Selector.GetHandle("simulatesAskToBuyInSandbox");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKMutablePayment");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public new virtual string? ApplicationUsername
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("applicationUsername", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selApplicationUsernameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selApplicationUsernameHandle));
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setApplicationUsername:", ArgumentSemantic.Copy)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetApplicationUsername_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetApplicationUsername_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
	public new virtual SKPaymentDiscount? PaymentDiscount
	{
		[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
		[Export("paymentDiscount", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<SKPaymentDiscount>(Messaging.IntPtr_objc_msgSend(base.Handle, selPaymentDiscountHandle));
			}
			return Runtime.GetNSObject<SKPaymentDiscount>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPaymentDiscountHandle));
		}
		[Introduced(PlatformName.iOS, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 12, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
		[Export("setPaymentDiscount:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPaymentDiscount_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPaymentDiscount_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual string ProductIdentifier
	{
		[Export("productIdentifier", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selProductIdentifierHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProductIdentifierHandle));
		}
		[Export("setProductIdentifier:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProductIdentifier_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProductIdentifier_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual nint Quantity
	{
		[Export("quantity")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selQuantityHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selQuantityHandle);
		}
		[Export("setQuantity:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetQuantity_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetQuantity_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override NSData? RequestData
	{
		[Export("requestData", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selRequestDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequestDataHandle));
		}
		[Export("setRequestData:", ArgumentSemantic.Copy)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRequestData_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRequestData_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public new virtual bool SimulatesAskToBuyInSandbox
	{
		[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("simulatesAskToBuyInSandbox")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selSimulatesAskToBuyInSandboxHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selSimulatesAskToBuyInSandboxHandle);
		}
		[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("setSimulatesAskToBuyInSandbox:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetSimulatesAskToBuyInSandbox_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetSimulatesAskToBuyInSandbox_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKMutablePayment()
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
	protected SKMutablePayment(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKMutablePayment(IntPtr handle)
		: base(handle)
	{
	}

	[Export("paymentWithProduct:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static SKMutablePayment PaymentWithProduct(SKProduct product)
	{
		if (product == null)
		{
			throw new ArgumentNullException("product");
		}
		return Runtime.GetNSObject<SKMutablePayment>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPaymentWithProduct_Handle, product.Handle));
	}

	[Export("paymentWithProductIdentifier:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.iOS, 5, 0, PlatformArchitecture.All, "Use 'PaymentWithProduct (SKProduct)' after fetching the list of available products from 'SKProductRequest' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SKMutablePayment PaymentWithProduct(string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		SKMutablePayment nSObject = Runtime.GetNSObject<SKMutablePayment>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPaymentWithProductIdentifier_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}
}
