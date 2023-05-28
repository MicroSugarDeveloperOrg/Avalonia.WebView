using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INSpeakableStringResolutionResult", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INSpeakableStringResolutionResult : INIntentResolutionResult
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfirmationRequiredWithStringToConfirm_ = "confirmationRequiredWithStringToConfirm:";

	private static readonly IntPtr selConfirmationRequiredWithStringToConfirm_Handle = Selector.GetHandle("confirmationRequiredWithStringToConfirm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisambiguationWithStringsToDisambiguate_ = "disambiguationWithStringsToDisambiguate:";

	private static readonly IntPtr selDisambiguationWithStringsToDisambiguate_Handle = Selector.GetHandle("disambiguationWithStringsToDisambiguate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsValue = "needsValue";

	private static readonly IntPtr selNeedsValueHandle = Selector.GetHandle("needsValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotRequired = "notRequired";

	private static readonly IntPtr selNotRequiredHandle = Selector.GetHandle("notRequired");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuccessWithResolvedString_ = "successWithResolvedString:";

	private static readonly IntPtr selSuccessWithResolvedString_Handle = Selector.GetHandle("successWithResolvedString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnsupported = "unsupported";

	private static readonly IntPtr selUnsupportedHandle = Selector.GetHandle("unsupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INSpeakableStringResolutionResult");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INSpeakableStringResolutionResult NeedsValue
	{
		[Export("needsValue")]
		get
		{
			return Runtime.GetNSObject<INSpeakableStringResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNeedsValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INSpeakableStringResolutionResult NotRequired
	{
		[Export("notRequired")]
		get
		{
			return Runtime.GetNSObject<INSpeakableStringResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNotRequiredHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INSpeakableStringResolutionResult Unsupported
	{
		[Export("unsupported")]
		get
		{
			return Runtime.GetNSObject<INSpeakableStringResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selUnsupportedHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected INSpeakableStringResolutionResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INSpeakableStringResolutionResult(IntPtr handle)
		: base(handle)
	{
	}

	[Export("confirmationRequiredWithStringToConfirm:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INSpeakableStringResolutionResult GetConfirmationRequired(INSpeakableString? stringToConfirm)
	{
		return Runtime.GetNSObject<INSpeakableStringResolutionResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selConfirmationRequiredWithStringToConfirm_Handle, stringToConfirm?.Handle ?? IntPtr.Zero));
	}

	[Export("disambiguationWithStringsToDisambiguate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INSpeakableStringResolutionResult GetDisambiguation(INSpeakableString[] stringsToDisambiguate)
	{
		if (stringsToDisambiguate == null)
		{
			throw new ArgumentNullException("stringsToDisambiguate");
		}
		NSArray nSArray = NSArray.FromNSObjects(stringsToDisambiguate);
		INSpeakableStringResolutionResult nSObject = Runtime.GetNSObject<INSpeakableStringResolutionResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDisambiguationWithStringsToDisambiguate_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("successWithResolvedString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INSpeakableStringResolutionResult GetSuccess(INSpeakableString resolvedString)
	{
		if (resolvedString == null)
		{
			throw new ArgumentNullException("resolvedString");
		}
		return Runtime.GetNSObject<INSpeakableStringResolutionResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSuccessWithResolvedString_Handle, resolvedString.Handle));
	}
}
