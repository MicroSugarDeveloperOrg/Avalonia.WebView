using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSURLAuthenticationChallenge", true)]
public class NSUrlAuthenticationChallenge : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selError = "error";

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFailureResponse = "failureResponse";

	private static readonly IntPtr selFailureResponseHandle = Selector.GetHandle("failureResponse");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAuthenticationChallenge_Sender_ = "initWithAuthenticationChallenge:sender:";

	private static readonly IntPtr selInitWithAuthenticationChallenge_Sender_Handle = Selector.GetHandle("initWithAuthenticationChallenge:sender:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithProtectionSpace_ProposedCredential_PreviousFailureCount_FailureResponse_Error_Sender_ = "initWithProtectionSpace:proposedCredential:previousFailureCount:failureResponse:error:sender:";

	private static readonly IntPtr selInitWithProtectionSpace_ProposedCredential_PreviousFailureCount_FailureResponse_Error_Sender_Handle = Selector.GetHandle("initWithProtectionSpace:proposedCredential:previousFailureCount:failureResponse:error:sender:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviousFailureCount = "previousFailureCount";

	private static readonly IntPtr selPreviousFailureCountHandle = Selector.GetHandle("previousFailureCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProposedCredential = "proposedCredential";

	private static readonly IntPtr selProposedCredentialHandle = Selector.GetHandle("proposedCredential");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProtectionSpace = "protectionSpace";

	private static readonly IntPtr selProtectionSpaceHandle = Selector.GetHandle("protectionSpace");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSender = "sender";

	private static readonly IntPtr selSenderHandle = Selector.GetHandle("sender");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSURLAuthenticationChallenge");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSError Error
	{
		[Export("error")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle));
			}
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlResponse FailureResponse
	{
		[Export("failureResponse")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrlResponse>(Messaging.IntPtr_objc_msgSend(base.Handle, selFailureResponseHandle));
			}
			return Runtime.GetNSObject<NSUrlResponse>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFailureResponseHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint PreviousFailureCount
	{
		[Export("previousFailureCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selPreviousFailureCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selPreviousFailureCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlCredential ProposedCredential
	{
		[Export("proposedCredential")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrlCredential>(Messaging.IntPtr_objc_msgSend(base.Handle, selProposedCredentialHandle));
			}
			return Runtime.GetNSObject<NSUrlCredential>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProposedCredentialHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlProtectionSpace ProtectionSpace
	{
		[Export("protectionSpace")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrlProtectionSpace>(Messaging.IntPtr_objc_msgSend(base.Handle, selProtectionSpaceHandle));
			}
			return Runtime.GetNSObject<NSUrlProtectionSpace>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProtectionSpaceHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlConnection Sender
	{
		[Export("sender")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrlConnection>(Messaging.IntPtr_objc_msgSend(base.Handle, selSenderHandle));
			}
			return Runtime.GetNSObject<NSUrlConnection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSenderHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUrlAuthenticationChallenge(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlAuthenticationChallenge(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlAuthenticationChallenge(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithProtectionSpace:proposedCredential:previousFailureCount:failureResponse:error:sender:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrlAuthenticationChallenge(NSUrlProtectionSpace space, NSUrlCredential credential, nint previousFailureCount, NSUrlResponse response, NSError? error, NSUrlConnection sender)
		: base(NSObjectFlag.Empty)
	{
		if (space == null)
		{
			throw new ArgumentNullException("space");
		}
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		if (response == null)
		{
			throw new ArgumentNullException("response");
		}
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithProtectionSpace_ProposedCredential_PreviousFailureCount_FailureResponse_Error_Sender_Handle, space.Handle, credential.Handle, previousFailureCount, response.Handle, error?.Handle ?? IntPtr.Zero, sender.Handle), "initWithProtectionSpace:proposedCredential:previousFailureCount:failureResponse:error:sender:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nint_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithProtectionSpace_ProposedCredential_PreviousFailureCount_FailureResponse_Error_Sender_Handle, space.Handle, credential.Handle, previousFailureCount, response.Handle, error?.Handle ?? IntPtr.Zero, sender.Handle), "initWithProtectionSpace:proposedCredential:previousFailureCount:failureResponse:error:sender:");
		}
	}

	[Export("initWithAuthenticationChallenge:sender:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSUrlAuthenticationChallenge(NSUrlAuthenticationChallenge challenge, NSUrlConnection sender)
		: base(NSObjectFlag.Empty)
	{
		if (challenge == null)
		{
			throw new ArgumentNullException("challenge");
		}
		if (sender == null)
		{
			throw new ArgumentNullException("sender");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAuthenticationChallenge_Sender_Handle, challenge.Handle, sender.Handle), "initWithAuthenticationChallenge:sender:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAuthenticationChallenge_Sender_Handle, challenge.Handle, sender.Handle), "initWithAuthenticationChallenge:sender:");
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}
}
