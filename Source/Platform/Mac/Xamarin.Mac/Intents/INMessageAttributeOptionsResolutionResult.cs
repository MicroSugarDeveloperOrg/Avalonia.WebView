using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INMessageAttributeOptionsResolutionResult", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INMessageAttributeOptionsResolutionResult : INIntentResolutionResult
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfirmationRequiredWithMessageAttributeOptionsToConfirm_ = "confirmationRequiredWithMessageAttributeOptionsToConfirm:";

	private static readonly IntPtr selConfirmationRequiredWithMessageAttributeOptionsToConfirm_Handle = Selector.GetHandle("confirmationRequiredWithMessageAttributeOptionsToConfirm:");

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
	private const string selSuccessWithResolvedMessageAttributeOptions_ = "successWithResolvedMessageAttributeOptions:";

	private static readonly IntPtr selSuccessWithResolvedMessageAttributeOptions_Handle = Selector.GetHandle("successWithResolvedMessageAttributeOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuccessWithResolvedValue_ = "successWithResolvedValue:";

	private static readonly IntPtr selSuccessWithResolvedValue_Handle = Selector.GetHandle("successWithResolvedValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnsupported = "unsupported";

	private static readonly IntPtr selUnsupportedHandle = Selector.GetHandle("unsupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INMessageAttributeOptionsResolutionResult");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INMessageAttributeOptionsResolutionResult NeedsValue
	{
		[Export("needsValue")]
		get
		{
			return Runtime.GetNSObject<INMessageAttributeOptionsResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNeedsValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INMessageAttributeOptionsResolutionResult NotRequired
	{
		[Export("notRequired")]
		get
		{
			return Runtime.GetNSObject<INMessageAttributeOptionsResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNotRequiredHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INMessageAttributeOptionsResolutionResult Unsupported
	{
		[Export("unsupported")]
		get
		{
			return Runtime.GetNSObject<INMessageAttributeOptionsResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selUnsupportedHandle));
		}
	}

	public static INMessageAttributeOptionsResolutionResult GetSuccess(INMessageAttributeOptions resolvedValue)
	{
		if (PlatformHelper.CheckSystemVersion(10, 13))
		{
			return SuccessWithResolvedMessageAttributeOptions(resolvedValue);
		}
		return SuccessWithResolvedValue(resolvedValue);
	}

	public static INMessageAttributeOptionsResolutionResult GetConfirmationRequired(INMessageAttributeOptions valueToConfirm)
	{
		if (PlatformHelper.CheckSystemVersion(10, 13))
		{
			return ConfirmationRequiredWithMessageAttributeOptionsToConfirm(valueToConfirm);
		}
		return ConfirmationRequiredWithValueToConfirm(valueToConfirm);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected INMessageAttributeOptionsResolutionResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INMessageAttributeOptionsResolutionResult(IntPtr handle)
		: base(handle)
	{
	}

	[Export("confirmationRequiredWithMessageAttributeOptionsToConfirm:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static INMessageAttributeOptionsResolutionResult ConfirmationRequiredWithMessageAttributeOptionsToConfirm(INMessageAttributeOptions messageAttributeOptionsToConfirm)
	{
		return Runtime.GetNSObject<INMessageAttributeOptionsResolutionResult>(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selConfirmationRequiredWithMessageAttributeOptionsToConfirm_Handle, (ulong)messageAttributeOptionsToConfirm));
	}

	[Export("confirmationRequiredWithValueToConfirm:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static INMessageAttributeOptionsResolutionResult ConfirmationRequiredWithValueToConfirm(INMessageAttributeOptions valueToConfirm)
	{
		return Runtime.GetNSObject<INMessageAttributeOptionsResolutionResult>(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selConfirmationRequiredWithValueToConfirm_Handle, (ulong)valueToConfirm));
	}

	[Export("successWithResolvedMessageAttributeOptions:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static INMessageAttributeOptionsResolutionResult SuccessWithResolvedMessageAttributeOptions(INMessageAttributeOptions resolvedMessageAttributeOptions)
	{
		return Runtime.GetNSObject<INMessageAttributeOptionsResolutionResult>(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selSuccessWithResolvedMessageAttributeOptions_Handle, (ulong)resolvedMessageAttributeOptions));
	}

	[Export("successWithResolvedValue:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static INMessageAttributeOptionsResolutionResult SuccessWithResolvedValue(INMessageAttributeOptions resolvedValue)
	{
		return Runtime.GetNSObject<INMessageAttributeOptionsResolutionResult>(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selSuccessWithResolvedValue_Handle, (ulong)resolvedValue));
	}
}
