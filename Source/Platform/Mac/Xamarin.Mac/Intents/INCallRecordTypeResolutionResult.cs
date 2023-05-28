using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INCallRecordTypeResolutionResult", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INCallRecordTypeResolutionResult : INIntentResolutionResult
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfirmationRequiredWithCallRecordTypeToConfirm_ = "confirmationRequiredWithCallRecordTypeToConfirm:";

	private static readonly IntPtr selConfirmationRequiredWithCallRecordTypeToConfirm_Handle = Selector.GetHandle("confirmationRequiredWithCallRecordTypeToConfirm:");

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
	private const string selSuccessWithResolvedCallRecordType_ = "successWithResolvedCallRecordType:";

	private static readonly IntPtr selSuccessWithResolvedCallRecordType_Handle = Selector.GetHandle("successWithResolvedCallRecordType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuccessWithResolvedValue_ = "successWithResolvedValue:";

	private static readonly IntPtr selSuccessWithResolvedValue_Handle = Selector.GetHandle("successWithResolvedValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnsupported = "unsupported";

	private static readonly IntPtr selUnsupportedHandle = Selector.GetHandle("unsupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INCallRecordTypeResolutionResult");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INCallRecordTypeResolutionResult NeedsValue
	{
		[Export("needsValue")]
		get
		{
			return Runtime.GetNSObject<INCallRecordTypeResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNeedsValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INCallRecordTypeResolutionResult NotRequired
	{
		[Export("notRequired")]
		get
		{
			return Runtime.GetNSObject<INCallRecordTypeResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNotRequiredHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INCallRecordTypeResolutionResult Unsupported
	{
		[Export("unsupported")]
		get
		{
			return Runtime.GetNSObject<INCallRecordTypeResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selUnsupportedHandle));
		}
	}

	public static INCallRecordTypeResolutionResult GetSuccess(INCallRecordType resolvedValue)
	{
		if (PlatformHelper.CheckSystemVersion(10, 13))
		{
			return SuccessWithResolvedCallRecordType(resolvedValue);
		}
		return SuccessWithResolvedValue(resolvedValue);
	}

	public static INCallRecordTypeResolutionResult GetConfirmationRequired(INCallRecordType valueToConfirm)
	{
		if (PlatformHelper.CheckSystemVersion(10, 13))
		{
			return ConfirmationRequiredWithCallRecordTypeToConfirm(valueToConfirm);
		}
		return ConfirmationRequiredWithValueToConfirm(valueToConfirm);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected INCallRecordTypeResolutionResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INCallRecordTypeResolutionResult(IntPtr handle)
		: base(handle)
	{
	}

	[Export("confirmationRequiredWithCallRecordTypeToConfirm:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static INCallRecordTypeResolutionResult ConfirmationRequiredWithCallRecordTypeToConfirm(INCallRecordType callRecordTypeToConfirm)
	{
		return Runtime.GetNSObject<INCallRecordTypeResolutionResult>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selConfirmationRequiredWithCallRecordTypeToConfirm_Handle, (long)callRecordTypeToConfirm));
	}

	[Export("confirmationRequiredWithValueToConfirm:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static INCallRecordTypeResolutionResult ConfirmationRequiredWithValueToConfirm(INCallRecordType valueToConfirm)
	{
		return Runtime.GetNSObject<INCallRecordTypeResolutionResult>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selConfirmationRequiredWithValueToConfirm_Handle, (long)valueToConfirm));
	}

	[Export("successWithResolvedCallRecordType:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static INCallRecordTypeResolutionResult SuccessWithResolvedCallRecordType(INCallRecordType resolvedCallRecordType)
	{
		return Runtime.GetNSObject<INCallRecordTypeResolutionResult>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selSuccessWithResolvedCallRecordType_Handle, (long)resolvedCallRecordType));
	}

	[Export("successWithResolvedValue:")]
	[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.WatchOS, 4, 0, PlatformArchitecture.None, null)]
	[Deprecated(PlatformName.iOS, 11, 0, PlatformArchitecture.None, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static INCallRecordTypeResolutionResult SuccessWithResolvedValue(INCallRecordType resolvedValue)
	{
		return Runtime.GetNSObject<INCallRecordTypeResolutionResult>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selSuccessWithResolvedValue_Handle, (long)resolvedValue));
	}
}
