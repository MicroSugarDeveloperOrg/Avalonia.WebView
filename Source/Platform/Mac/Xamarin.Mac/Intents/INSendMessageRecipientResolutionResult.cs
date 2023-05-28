using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Intents;

[Register("INSendMessageRecipientResolutionResult", true)]
[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class INSendMessageRecipientResolutionResult : INPersonResolutionResult
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfirmationRequiredWithPersonToConfirm_ = "confirmationRequiredWithPersonToConfirm:";

	private static readonly IntPtr selConfirmationRequiredWithPersonToConfirm_Handle = Selector.GetHandle("confirmationRequiredWithPersonToConfirm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDisambiguationWithPeopleToDisambiguate_ = "disambiguationWithPeopleToDisambiguate:";

	private static readonly IntPtr selDisambiguationWithPeopleToDisambiguate_Handle = Selector.GetHandle("disambiguationWithPeopleToDisambiguate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPersonResolutionResult_ = "initWithPersonResolutionResult:";

	private static readonly IntPtr selInitWithPersonResolutionResult_Handle = Selector.GetHandle("initWithPersonResolutionResult:");

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
	private const string selUnsupportedForReason_ = "unsupportedForReason:";

	private static readonly IntPtr selUnsupportedForReason_Handle = Selector.GetHandle("unsupportedForReason:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("INSendMessageRecipientResolutionResult");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INSendMessageRecipientResolutionResult NeedsValue
	{
		[Export("needsValue")]
		get
		{
			return Runtime.GetNSObject<INSendMessageRecipientResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNeedsValueHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INSendMessageRecipientResolutionResult NotRequired
	{
		[Export("notRequired")]
		get
		{
			return Runtime.GetNSObject<INSendMessageRecipientResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selNotRequiredHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INSendMessageRecipientResolutionResult Unsupported
	{
		[Export("unsupported")]
		get
		{
			return Runtime.GetNSObject<INSendMessageRecipientResolutionResult>(Messaging.IntPtr_objc_msgSend(class_ptr, selUnsupportedHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected INSendMessageRecipientResolutionResult(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal INSendMessageRecipientResolutionResult(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPersonResolutionResult:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public INSendMessageRecipientResolutionResult(INPersonResolutionResult personResolutionResult)
		: base(NSObjectFlag.Empty)
	{
		if (personResolutionResult == null)
		{
			throw new ArgumentNullException("personResolutionResult");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithPersonResolutionResult_Handle, personResolutionResult.Handle), "initWithPersonResolutionResult:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithPersonResolutionResult_Handle, personResolutionResult.Handle), "initWithPersonResolutionResult:");
		}
	}

	[Export("confirmationRequiredWithPersonToConfirm:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INSendMessageRecipientResolutionResult GetConfirmationRequired(INPerson? personToConfirm)
	{
		return Runtime.GetNSObject<INSendMessageRecipientResolutionResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selConfirmationRequiredWithPersonToConfirm_Handle, personToConfirm?.Handle ?? IntPtr.Zero));
	}

	[Export("disambiguationWithPeopleToDisambiguate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INSendMessageRecipientResolutionResult GetDisambiguation(INPerson[] peopleToDisambiguate)
	{
		if (peopleToDisambiguate == null)
		{
			throw new ArgumentNullException("peopleToDisambiguate");
		}
		NSArray nSArray = NSArray.FromNSObjects(peopleToDisambiguate);
		INSendMessageRecipientResolutionResult nSObject = Runtime.GetNSObject<INSendMessageRecipientResolutionResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDisambiguationWithPeopleToDisambiguate_Handle, nSArray.Handle));
		nSArray.Dispose();
		return nSObject;
	}

	[Export("successWithResolvedPerson:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static INSendMessageRecipientResolutionResult GetSuccess(INPerson resolvedPerson)
	{
		if (resolvedPerson == null)
		{
			throw new ArgumentNullException("resolvedPerson");
		}
		return Runtime.GetNSObject<INSendMessageRecipientResolutionResult>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selSuccessWithResolvedPerson_Handle, resolvedPerson.Handle));
	}

	[Export("unsupportedForReason:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static INSendMessageRecipientResolutionResult GetUnsupported(INSendMessageRecipientUnsupportedReason reason)
	{
		return Runtime.GetNSObject<INSendMessageRecipientResolutionResult>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selUnsupportedForReason_Handle, (long)reason));
	}
}
