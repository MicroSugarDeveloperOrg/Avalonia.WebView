using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLAuthenticationChallenge", true)]
public class NSUrlAuthenticationChallenge : NSObject
{
	private static readonly IntPtr selProtectionSpaceHandle = Selector.GetHandle("protectionSpace");

	private static readonly IntPtr selProposedCredentialHandle = Selector.GetHandle("proposedCredential");

	private static readonly IntPtr selPreviousFailureCountHandle = Selector.GetHandle("previousFailureCount");

	private static readonly IntPtr selFailureResponseHandle = Selector.GetHandle("failureResponse");

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	private static readonly IntPtr selSenderHandle = Selector.GetHandle("sender");

	private static readonly IntPtr selInitWithProtectionSpaceProposedCredentialPreviousFailureCountFailureResponseErrorSender_Handle = Selector.GetHandle("initWithProtectionSpace:proposedCredential:previousFailureCount:failureResponse:error:sender:");

	private static readonly IntPtr selInitWithAuthenticationChallengeSender_Handle = Selector.GetHandle("initWithAuthenticationChallenge:sender:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSURLAuthenticationChallenge");

	private object __mt_ProtectionSpace_var;

	private object __mt_ProposedCredential_var;

	private object __mt_FailureResponse_var;

	private object __mt_Error_var;

	private object __mt_Sender_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSUrlProtectionSpace ProtectionSpace
	{
		[Export("protectionSpace")]
		get
		{
			return (NSUrlProtectionSpace)(__mt_ProtectionSpace_var = ((!IsDirectBinding) ? ((NSUrlProtectionSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProtectionSpaceHandle))) : ((NSUrlProtectionSpace)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selProtectionSpaceHandle)))));
		}
	}

	public virtual NSUrlCredential ProposedCredential
	{
		[Export("proposedCredential")]
		get
		{
			return (NSUrlCredential)(__mt_ProposedCredential_var = ((!IsDirectBinding) ? ((NSUrlCredential)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProposedCredentialHandle))) : ((NSUrlCredential)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selProposedCredentialHandle)))));
		}
	}

	public virtual long PreviousFailureCount
	{
		[Export("previousFailureCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selPreviousFailureCountHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPreviousFailureCountHandle);
		}
	}

	public virtual NSUrlResponse FailureResponse
	{
		[Export("failureResponse")]
		get
		{
			return (NSUrlResponse)(__mt_FailureResponse_var = ((!IsDirectBinding) ? ((NSUrlResponse)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFailureResponseHandle))) : ((NSUrlResponse)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFailureResponseHandle)))));
		}
	}

	public virtual NSError Error
	{
		[Export("error")]
		get
		{
			return (NSError)(__mt_Error_var = ((!IsDirectBinding) ? ((NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle))) : ((NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle)))));
		}
	}

	public virtual NSUrlConnection Sender
	{
		[Export("sender")]
		get
		{
			return (NSUrlConnection)(__mt_Sender_var = ((!IsDirectBinding) ? ((NSUrlConnection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSenderHandle))) : ((NSUrlConnection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSenderHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSUrlAuthenticationChallenge(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrlAuthenticationChallenge(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSUrlAuthenticationChallenge(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithProtectionSpace:proposedCredential:previousFailureCount:failureResponse:error:sender:")]
	public NSUrlAuthenticationChallenge(NSUrlProtectionSpace space, NSUrlCredential credential, long previousFailureCount, NSUrlResponse response, NSError error, NSUrlConnection sender)
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
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_Int64_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithProtectionSpaceProposedCredentialPreviousFailureCountFailureResponseErrorSender_Handle, space.Handle, credential.Handle, previousFailureCount, response.Handle, error?.Handle ?? IntPtr.Zero, sender.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Int64_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithProtectionSpaceProposedCredentialPreviousFailureCountFailureResponseErrorSender_Handle, space.Handle, credential.Handle, previousFailureCount, response.Handle, error?.Handle ?? IntPtr.Zero, sender.Handle);
		}
	}

	[Export("initWithAuthenticationChallenge:sender:")]
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
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAuthenticationChallengeSender_Handle, challenge.Handle, sender.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAuthenticationChallengeSender_Handle, challenge.Handle, sender.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ProtectionSpace_var = null;
			__mt_ProposedCredential_var = null;
			__mt_FailureResponse_var = null;
			__mt_Error_var = null;
			__mt_Sender_var = null;
		}
	}
}
