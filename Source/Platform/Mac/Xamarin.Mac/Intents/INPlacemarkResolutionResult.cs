using System;
using System.ComponentModel;
using CoreLocation;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INPlacemarkResolutionResult", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INPlacemarkResolutionResult : INIntentResolutionResult
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfirmationRequiredWithPlacemarkToConfirm_ = "confirmationRequiredWithPlacemarkToConfirm:";

	private static readonly IntPtr selConfirmationRequiredWithPlacemarkToConfirm_Handle = Selector.GetHandle("confirmationRequiredWithPlacemarkToConfirm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisambiguationWithPlacemarksToDisambiguate_ = "disambiguationWithPlacemarksToDisambiguate:";

	private static readonly IntPtr selDisambiguationWithPlacemarksToDisambiguate_Handle = Selector.GetHandle("disambiguationWithPlacemarksToDisambiguate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsValue = "needsValue";

	private static readonly IntPtr selNeedsValueHandle = Selector.GetHandle("needsValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotRequired = "notRequired";

	private static readonly IntPtr selNotRequiredHandle = Selector.GetHandle("notRequired");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuccessWithResolvedPlacemark_ = "successWithResolvedPlacemark:";

	private static readonly IntPtr selSuccessWithResolvedPlacemark_Handle = Selector.GetHandle("successWithResolvedPlacemark:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnsupported = "unsupported";

	private static readonly IntPtr selUnsupportedHandle = Selector.GetHandle("unsupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INPlacemarkResolutionResult");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INPlacemarkResolutionResult NeedsValue
	{
		[Export("needsValue")]
		get
		{
			return Runtime.GetNSObject<INPlacemarkResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNeedsValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INPlacemarkResolutionResult NotRequired
	{
		[Export("notRequired")]
		get
		{
			return Runtime.GetNSObject<INPlacemarkResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNotRequiredHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INPlacemarkResolutionResult Unsupported
	{
		[Export("unsupported")]
		get
		{
			return Runtime.GetNSObject<INPlacemarkResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selUnsupportedHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected INPlacemarkResolutionResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INPlacemarkResolutionResult(IntPtr handle)
		: base(handle)
	{
	}

	[Export("confirmationRequiredWithPlacemarkToConfirm:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INPlacemarkResolutionResult GetConfirmationRequired(CLPlacemark? placemarkToConfirm)
	{
		return Runtime.GetNSObject<INPlacemarkResolutionResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selConfirmationRequiredWithPlacemarkToConfirm_Handle, placemarkToConfirm?.Handle ?? IntPtr.Zero));
	}

	[Export("disambiguationWithPlacemarksToDisambiguate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INPlacemarkResolutionResult GetDisambiguation(CLPlacemark[] placemarksToDisambiguate)
	{
		if (placemarksToDisambiguate == null)
		{
			throw new ArgumentNullException("placemarksToDisambiguate");
		}
		NSArray nSArray = NSArray.FromNSObjects(placemarksToDisambiguate);
		INPlacemarkResolutionResult nSObject = Runtime.GetNSObject<INPlacemarkResolutionResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDisambiguationWithPlacemarksToDisambiguate_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("successWithResolvedPlacemark:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INPlacemarkResolutionResult GetSuccess(CLPlacemark resolvedPlacemark)
	{
		if (resolvedPlacemark == null)
		{
			throw new ArgumentNullException("resolvedPlacemark");
		}
		return Runtime.GetNSObject<INPlacemarkResolutionResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSuccessWithResolvedPlacemark_Handle, resolvedPlacemark.Handle));
	}
}
