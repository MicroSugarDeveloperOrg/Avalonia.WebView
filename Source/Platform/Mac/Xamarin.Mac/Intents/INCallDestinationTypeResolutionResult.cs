using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INCallDestinationTypeResolutionResult", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class INCallDestinationTypeResolutionResult : INIntentResolutionResult
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfirmationRequiredWithCallDestinationTypeToConfirm_ = "confirmationRequiredWithCallDestinationTypeToConfirm:";

	private static readonly IntPtr selConfirmationRequiredWithCallDestinationTypeToConfirm_Handle = Selector.GetHandle("confirmationRequiredWithCallDestinationTypeToConfirm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsValue = "needsValue";

	private static readonly IntPtr selNeedsValueHandle = Selector.GetHandle("needsValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotRequired = "notRequired";

	private static readonly IntPtr selNotRequiredHandle = Selector.GetHandle("notRequired");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuccessWithResolvedCallDestinationType_ = "successWithResolvedCallDestinationType:";

	private static readonly IntPtr selSuccessWithResolvedCallDestinationType_Handle = Selector.GetHandle("successWithResolvedCallDestinationType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnsupported = "unsupported";

	private static readonly IntPtr selUnsupportedHandle = Selector.GetHandle("unsupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INCallDestinationTypeResolutionResult");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INCallDestinationTypeResolutionResult NeedsValue
	{
		[Export("needsValue")]
		get
		{
			return Runtime.GetNSObject<INCallDestinationTypeResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNeedsValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INCallDestinationTypeResolutionResult NotRequired
	{
		[Export("notRequired")]
		get
		{
			return Runtime.GetNSObject<INCallDestinationTypeResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNotRequiredHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INCallDestinationTypeResolutionResult Unsupported
	{
		[Export("unsupported")]
		get
		{
			return Runtime.GetNSObject<INCallDestinationTypeResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selUnsupportedHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected INCallDestinationTypeResolutionResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INCallDestinationTypeResolutionResult(IntPtr handle)
		: base(handle)
	{
	}

	[Export("confirmationRequiredWithCallDestinationTypeToConfirm:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INCallDestinationTypeResolutionResult GetConfirmationRequired(INCallDestinationType callDestinationTypeToConfirm)
	{
		return Runtime.GetNSObject<INCallDestinationTypeResolutionResult>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selConfirmationRequiredWithCallDestinationTypeToConfirm_Handle, (long)callDestinationTypeToConfirm));
	}

	[Export("successWithResolvedCallDestinationType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INCallDestinationTypeResolutionResult GetSuccess(INCallDestinationType resolvedCallDestinationType)
	{
		return Runtime.GetNSObject<INCallDestinationTypeResolutionResult>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selSuccessWithResolvedCallDestinationType_Handle, (long)resolvedCallDestinationType));
	}
}
