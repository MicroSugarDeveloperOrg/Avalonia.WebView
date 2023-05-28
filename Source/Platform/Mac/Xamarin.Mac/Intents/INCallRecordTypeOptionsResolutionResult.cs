using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INCallRecordTypeOptionsResolutionResult", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class INCallRecordTypeOptionsResolutionResult : INIntentResolutionResult
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfirmationRequiredWithCallRecordTypeOptionsToConfirm_ = "confirmationRequiredWithCallRecordTypeOptionsToConfirm:";

	private static readonly IntPtr selConfirmationRequiredWithCallRecordTypeOptionsToConfirm_Handle = Selector.GetHandle("confirmationRequiredWithCallRecordTypeOptionsToConfirm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsValue = "needsValue";

	private static readonly IntPtr selNeedsValueHandle = Selector.GetHandle("needsValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotRequired = "notRequired";

	private static readonly IntPtr selNotRequiredHandle = Selector.GetHandle("notRequired");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuccessWithResolvedCallRecordTypeOptions_ = "successWithResolvedCallRecordTypeOptions:";

	private static readonly IntPtr selSuccessWithResolvedCallRecordTypeOptions_Handle = Selector.GetHandle("successWithResolvedCallRecordTypeOptions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnsupported = "unsupported";

	private static readonly IntPtr selUnsupportedHandle = Selector.GetHandle("unsupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INCallRecordTypeOptionsResolutionResult");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INCallRecordTypeOptionsResolutionResult NeedsValue
	{
		[Export("needsValue")]
		get
		{
			return Runtime.GetNSObject<INCallRecordTypeOptionsResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNeedsValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INCallRecordTypeOptionsResolutionResult NotRequired
	{
		[Export("notRequired")]
		get
		{
			return Runtime.GetNSObject<INCallRecordTypeOptionsResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNotRequiredHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INCallRecordTypeOptionsResolutionResult Unsupported
	{
		[Export("unsupported")]
		get
		{
			return Runtime.GetNSObject<INCallRecordTypeOptionsResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selUnsupportedHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected INCallRecordTypeOptionsResolutionResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INCallRecordTypeOptionsResolutionResult(IntPtr handle)
		: base(handle)
	{
	}

	[Export("confirmationRequiredWithCallRecordTypeOptionsToConfirm:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INCallRecordTypeOptionsResolutionResult GetConfirmationRequired(INCallRecordTypeOptions callRecordTypeOptionsToConfirm)
	{
		return Runtime.GetNSObject<INCallRecordTypeOptionsResolutionResult>(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selConfirmationRequiredWithCallRecordTypeOptionsToConfirm_Handle, (ulong)callRecordTypeOptionsToConfirm));
	}

	[Export("successWithResolvedCallRecordTypeOptions:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INCallRecordTypeOptionsResolutionResult GetSuccess(INCallRecordTypeOptions resolvedCallRecordTypeOptions)
	{
		return Runtime.GetNSObject<INCallRecordTypeOptionsResolutionResult>(Messaging.IntPtr_objc_msgSend_UInt64(class_ptr, selSuccessWithResolvedCallRecordTypeOptions_Handle, (ulong)resolvedCallRecordTypeOptions));
	}
}
