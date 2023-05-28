using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INDateComponentsRangeResolutionResult", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INDateComponentsRangeResolutionResult : INIntentResolutionResult
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfirmationRequiredWithDateComponentsRangeToConfirm_ = "confirmationRequiredWithDateComponentsRangeToConfirm:";

	private static readonly IntPtr selConfirmationRequiredWithDateComponentsRangeToConfirm_Handle = Selector.GetHandle("confirmationRequiredWithDateComponentsRangeToConfirm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisambiguationWithDateComponentsRangesToDisambiguate_ = "disambiguationWithDateComponentsRangesToDisambiguate:";

	private static readonly IntPtr selDisambiguationWithDateComponentsRangesToDisambiguate_Handle = Selector.GetHandle("disambiguationWithDateComponentsRangesToDisambiguate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsValue = "needsValue";

	private static readonly IntPtr selNeedsValueHandle = Selector.GetHandle("needsValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotRequired = "notRequired";

	private static readonly IntPtr selNotRequiredHandle = Selector.GetHandle("notRequired");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuccessWithResolvedDateComponentsRange_ = "successWithResolvedDateComponentsRange:";

	private static readonly IntPtr selSuccessWithResolvedDateComponentsRange_Handle = Selector.GetHandle("successWithResolvedDateComponentsRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnsupported = "unsupported";

	private static readonly IntPtr selUnsupportedHandle = Selector.GetHandle("unsupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INDateComponentsRangeResolutionResult");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INDateComponentsRangeResolutionResult NeedsValue
	{
		[Export("needsValue")]
		get
		{
			return Runtime.GetNSObject<INDateComponentsRangeResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNeedsValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INDateComponentsRangeResolutionResult NotRequired
	{
		[Export("notRequired")]
		get
		{
			return Runtime.GetNSObject<INDateComponentsRangeResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNotRequiredHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INDateComponentsRangeResolutionResult Unsupported
	{
		[Export("unsupported")]
		get
		{
			return Runtime.GetNSObject<INDateComponentsRangeResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selUnsupportedHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected INDateComponentsRangeResolutionResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INDateComponentsRangeResolutionResult(IntPtr handle)
		: base(handle)
	{
	}

	[Export("confirmationRequiredWithDateComponentsRangeToConfirm:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INDateComponentsRangeResolutionResult GetConfirmationRequired(INDateComponentsRange? dateComponentsRangeToConfirm)
	{
		return Runtime.GetNSObject<INDateComponentsRangeResolutionResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selConfirmationRequiredWithDateComponentsRangeToConfirm_Handle, dateComponentsRangeToConfirm?.Handle ?? IntPtr.Zero));
	}

	[Export("disambiguationWithDateComponentsRangesToDisambiguate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INDateComponentsRangeResolutionResult GetDisambiguation(INDateComponentsRange[] dateComponentsRangesToDisambiguate)
	{
		if (dateComponentsRangesToDisambiguate == null)
		{
			throw new ArgumentNullException("dateComponentsRangesToDisambiguate");
		}
		NSArray nSArray = NSArray.FromNSObjects(dateComponentsRangesToDisambiguate);
		INDateComponentsRangeResolutionResult nSObject = Runtime.GetNSObject<INDateComponentsRangeResolutionResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDisambiguationWithDateComponentsRangesToDisambiguate_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("successWithResolvedDateComponentsRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INDateComponentsRangeResolutionResult GetSuccess(INDateComponentsRange resolvedDateComponentsRange)
	{
		if (resolvedDateComponentsRange == null)
		{
			throw new ArgumentNullException("resolvedDateComponentsRange");
		}
		return Runtime.GetNSObject<INDateComponentsRangeResolutionResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSuccessWithResolvedDateComponentsRange_Handle, resolvedDateComponentsRange.Handle));
	}
}
