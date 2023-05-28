using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INPersonResolutionResult", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, 0, PlatformArchitecture.Arch64, null)]
[Introduced(PlatformName.WatchOS, 3, 2, PlatformArchitecture.All, null)]
public class INPersonResolutionResult : INIntentResolutionResult
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfirmationRequiredWithPersonToConfirm_ = "confirmationRequiredWithPersonToConfirm:";

	private static readonly IntPtr selConfirmationRequiredWithPersonToConfirm_Handle = Selector.GetHandle("confirmationRequiredWithPersonToConfirm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisambiguationWithPeopleToDisambiguate_ = "disambiguationWithPeopleToDisambiguate:";

	private static readonly IntPtr selDisambiguationWithPeopleToDisambiguate_Handle = Selector.GetHandle("disambiguationWithPeopleToDisambiguate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNeedsValue = "needsValue";

	private static readonly IntPtr selNeedsValueHandle = Selector.GetHandle("needsValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotRequired = "notRequired";

	private static readonly IntPtr selNotRequiredHandle = Selector.GetHandle("notRequired");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuccessWithResolvedPerson_ = "successWithResolvedPerson:";

	private static readonly IntPtr selSuccessWithResolvedPerson_Handle = Selector.GetHandle("successWithResolvedPerson:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnsupported = "unsupported";

	private static readonly IntPtr selUnsupportedHandle = Selector.GetHandle("unsupported");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INPersonResolutionResult");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INPersonResolutionResult NeedsValue
	{
		[Export("needsValue")]
		get
		{
			return Runtime.GetNSObject<INPersonResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNeedsValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INPersonResolutionResult NotRequired
	{
		[Export("notRequired")]
		get
		{
			return Runtime.GetNSObject<INPersonResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNotRequiredHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INPersonResolutionResult Unsupported
	{
		[Export("unsupported")]
		get
		{
			return Runtime.GetNSObject<INPersonResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selUnsupportedHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected INPersonResolutionResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INPersonResolutionResult(IntPtr handle)
		: base(handle)
	{
	}

	[Export("confirmationRequiredWithPersonToConfirm:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INPersonResolutionResult GetConfirmationRequired(INPerson? personToConfirm)
	{
		return Runtime.GetNSObject<INPersonResolutionResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selConfirmationRequiredWithPersonToConfirm_Handle, personToConfirm?.Handle ?? IntPtr.Zero));
	}

	[Export("disambiguationWithPeopleToDisambiguate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INPersonResolutionResult GetDisambiguation(INPerson[] peopleToDisambiguate)
	{
		if (peopleToDisambiguate == null)
		{
			throw new ArgumentNullException("peopleToDisambiguate");
		}
		NSArray nSArray = NSArray.FromNSObjects(peopleToDisambiguate);
		INPersonResolutionResult nSObject = Runtime.GetNSObject<INPersonResolutionResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDisambiguationWithPeopleToDisambiguate_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("successWithResolvedPerson:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INPersonResolutionResult GetSuccess(INPerson resolvedPerson)
	{
		if (resolvedPerson == null)
		{
			throw new ArgumentNullException("resolvedPerson");
		}
		return Runtime.GetNSObject<INPersonResolutionResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSuccessWithResolvedPerson_Handle, resolvedPerson.Handle));
	}
}
