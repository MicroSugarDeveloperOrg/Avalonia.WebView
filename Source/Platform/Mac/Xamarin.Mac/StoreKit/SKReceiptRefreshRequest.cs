using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Foundation;
using ObjCRuntime;

namespace StoreKit;

[Register("SKReceiptRefreshRequest", true)]
[Introduced(PlatformName.WatchOS, 6, 2, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
public class SKReceiptRefreshRequest : SKRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithReceiptProperties_ = "initWithReceiptProperties:";

	private static readonly IntPtr selInitWithReceiptProperties_Handle = Selector.GetHandle("initWithReceiptProperties:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReceiptProperties = "receiptProperties";

	private static readonly IntPtr selReceiptPropertiesHandle = Selector.GetHandle("receiptProperties");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SKReceiptRefreshRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKReceiptProperties? ReceiptProperties
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((WeakReceiptProperties != null) ? new NSMutableDictionary(WeakReceiptProperties) : null);
			return (nSMutableDictionary == null) ? null : new SKReceiptProperties(nSMutableDictionary);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? WeakReceiptProperties
	{
		[Export("receiptProperties")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selReceiptPropertiesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReceiptPropertiesHandle));
		}
	}

	[DllImport("/System/Library/Frameworks/StoreKit.framework/StoreKit", EntryPoint = "SKTerminateForInvalidReceipt")]
	[Watch(6, 2)]
	[iOS(7, 1)]
	[Mac(10, 14)]
	public static extern void TerminateForInvalidReceipt();

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SKReceiptRefreshRequest()
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
	protected SKReceiptRefreshRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SKReceiptRefreshRequest(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithReceiptProperties:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKReceiptRefreshRequest(NSDictionary? properties)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithReceiptProperties_Handle, properties?.Handle ?? IntPtr.Zero), "initWithReceiptProperties:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithReceiptProperties_Handle, properties?.Handle ?? IntPtr.Zero), "initWithReceiptProperties:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SKReceiptRefreshRequest(SKReceiptProperties? receiptProperties)
		: this(receiptProperties.GetDictionary())
	{
	}
}
