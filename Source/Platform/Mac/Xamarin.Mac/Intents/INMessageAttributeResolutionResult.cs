using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INMessageAttributeResolutionResult", true)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INMessageAttributeResolutionResult : INIntentResolutionResult
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfirmationRequiredWithMessageAttributeToConfirm_ = "confirmationRequiredWithMessageAttributeToConfirm:";

	private static readonly IntPtr selConfirmationRequiredWithMessageAttributeToConfirm_Handle = Selector.GetHandle("confirmationRequiredWithMessageAttributeToConfirm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfirmationRequiredWithValueToConfirm_ = "confirmationRequiredWithValueToConfirm:";

	private static readonly IntPtr selConfirmationRequiredWithValueToConfirm_Handle = Selector.GetHandle("confirmationRequiredWithValueToConfirm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsValue = "needsValue";

	private static readonly IntPtr selNeedsValueHandle = Selector.GetHandle("needsValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotRequired = "notRequired";

	private static readonly IntPtr selNotRequiredHandle = Selector.GetHandle("notRequired");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuccessWithResolvedMessageAttribute_ = "successWithResolvedMessageAttribute:";

	private static readonly IntPtr selSuccessWithResolvedMessageAttribute_Handle = Selector.GetHandle("successWithResolvedMessageAttribute:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuccessWithResolvedValue_ = "successWithResolvedValue:";

	private static readonly IntPtr selSuccessWithResolvedValue_Handle = Selector.GetHandle("successWithResolvedValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnsupported = "unsupported";

	private static readonly IntPtr selUnsupportedHandle = Selector.GetHandle("unsupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INMessageAttributeResolutionResult");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INMessageAttributeResolutionResult NeedsValue
	{
		[Export("needsValue")]
		get
		{
			return Runtime.GetNSObject<INMessageAttributeResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNeedsValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INMessageAttributeResolutionResult NotRequired
	{
		[Export("notRequired")]
		get
		{
			return Runtime.GetNSObject<INMessageAttributeResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNotRequiredHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INMessageAttributeResolutionResult Unsupported
	{
		[Export("unsupported")]
		get
		{
			return Runtime.GetNSObject<INMessageAttributeResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selUnsupportedHandle));
		}
	}

	public static INMessageAttributeResolutionResult GetSuccess(INMessageAttribute resolvedValue)
	{
		if (PlatformHelper.CheckSystemVersion(10, 13))
		{
			return SuccessWithResolvedMessageAttribute(resolvedValue);
		}
		return SuccessWithResolvedValue(resolvedValue);
	}

	public static INMessageAttributeResolutionResult GetConfirmationRequired(INMessageAttribute valueToConfirm)
	{
		if (PlatformHelper.CheckSystemVersion(10, 13))
		{
			return ConfirmationRequiredWithMessageAttributeToConfirm(valueToConfirm);
		}
		return ConfirmationRequiredWithValueToConfirm(valueToConfirm);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected INMessageAttributeResolutionResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INMessageAttributeResolutionResult(IntPtr handle)
		: base(handle)
	{
	}

	[Export("confirmationRequiredWithMessageAttributeToConfirm:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static INMessageAttributeResolutionResult ConfirmationRequiredWithMessageAttributeToConfirm(INMessageAttribute messageAttributeToConfirm)
	{
		return Runtime.GetNSObject<INMessageAttributeResolutionResult>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selConfirmationRequiredWithMessageAttributeToConfirm_Handle, (long)messageAttributeToConfirm));
	}

	[Export("confirmationRequiredWithValueToConfirm:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static INMessageAttributeResolutionResult ConfirmationRequiredWithValueToConfirm(INMessageAttribute valueToConfirm)
	{
		return Runtime.GetNSObject<INMessageAttributeResolutionResult>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selConfirmationRequiredWithValueToConfirm_Handle, (long)valueToConfirm));
	}

	[Export("successWithResolvedMessageAttribute:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static INMessageAttributeResolutionResult SuccessWithResolvedMessageAttribute(INMessageAttribute resolvedMessageAttribute)
	{
		return Runtime.GetNSObject<INMessageAttributeResolutionResult>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selSuccessWithResolvedMessageAttribute_Handle, (long)resolvedMessageAttribute));
	}

	[Export("successWithResolvedValue:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static INMessageAttributeResolutionResult SuccessWithResolvedValue(INMessageAttribute resolvedValue)
	{
		return Runtime.GetNSObject<INMessageAttributeResolutionResult>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selSuccessWithResolvedValue_Handle, (long)resolvedValue));
	}
}
