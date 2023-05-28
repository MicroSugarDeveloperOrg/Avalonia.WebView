using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;
using Security;

namespace LocalAuthentication;

[Register("LAContext", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class LAContext : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBiometryType = "biometryType";

	private static readonly IntPtr selBiometryTypeHandle = Selector.GetHandle("biometryType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanEvaluatePolicy_Error_ = "canEvaluatePolicy:error:";

	private static readonly IntPtr selCanEvaluatePolicy_Error_Handle = Selector.GetHandle("canEvaluatePolicy:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvaluateAccessControl_Operation_LocalizedReason_Reply_ = "evaluateAccessControl:operation:localizedReason:reply:";

	private static readonly IntPtr selEvaluateAccessControl_Operation_LocalizedReason_Reply_Handle = Selector.GetHandle("evaluateAccessControl:operation:localizedReason:reply:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvaluatePolicy_LocalizedReason_Reply_ = "evaluatePolicy:localizedReason:reply:";

	private static readonly IntPtr selEvaluatePolicy_LocalizedReason_Reply_Handle = Selector.GetHandle("evaluatePolicy:localizedReason:reply:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEvaluatedPolicyDomainState = "evaluatedPolicyDomainState";

	private static readonly IntPtr selEvaluatedPolicyDomainStateHandle = Selector.GetHandle("evaluatedPolicyDomainState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInteractionNotAllowed = "interactionNotAllowed";

	private static readonly IntPtr selInteractionNotAllowedHandle = Selector.GetHandle("interactionNotAllowed");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvalidate = "invalidate";

	private static readonly IntPtr selInvalidateHandle = Selector.GetHandle("invalidate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsCredentialSet_ = "isCredentialSet:";

	private static readonly IntPtr selIsCredentialSet_Handle = Selector.GetHandle("isCredentialSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedCancelTitle = "localizedCancelTitle";

	private static readonly IntPtr selLocalizedCancelTitleHandle = Selector.GetHandle("localizedCancelTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedFallbackTitle = "localizedFallbackTitle";

	private static readonly IntPtr selLocalizedFallbackTitleHandle = Selector.GetHandle("localizedFallbackTitle");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedReason = "localizedReason";

	private static readonly IntPtr selLocalizedReasonHandle = Selector.GetHandle("localizedReason");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCredential_Type_ = "setCredential:type:";

	private static readonly IntPtr selSetCredential_Type_Handle = Selector.GetHandle("setCredential:type:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInteractionNotAllowed_ = "setInteractionNotAllowed:";

	private static readonly IntPtr selSetInteractionNotAllowed_Handle = Selector.GetHandle("setInteractionNotAllowed:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocalizedCancelTitle_ = "setLocalizedCancelTitle:";

	private static readonly IntPtr selSetLocalizedCancelTitle_Handle = Selector.GetHandle("setLocalizedCancelTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocalizedFallbackTitle_ = "setLocalizedFallbackTitle:";

	private static readonly IntPtr selSetLocalizedFallbackTitle_Handle = Selector.GetHandle("setLocalizedFallbackTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocalizedReason_ = "setLocalizedReason:";

	private static readonly IntPtr selSetLocalizedReason_Handle = Selector.GetHandle("setLocalizedReason:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTouchIDAuthenticationAllowableReuseDuration_ = "setTouchIDAuthenticationAllowableReuseDuration:";

	private static readonly IntPtr selSetTouchIDAuthenticationAllowableReuseDuration_Handle = Selector.GetHandle("setTouchIDAuthenticationAllowableReuseDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTouchIDAuthenticationAllowableReuseDuration = "touchIDAuthenticationAllowableReuseDuration";

	private static readonly IntPtr selTouchIDAuthenticationAllowableReuseDurationHandle = Selector.GetHandle("touchIDAuthenticationAllowableReuseDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("LAContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorDomain;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual LABiometryType BiometryType
	{
		[Introduced(PlatformName.MacOSX, 10, 13, 2, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("biometryType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (LABiometryType)Messaging.Int64_objc_msgSend(base.Handle, selBiometryTypeHandle);
			}
			return (LABiometryType)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selBiometryTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NSData? EvaluatedPolicyDomainState
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("evaluatedPolicyDomainState")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selEvaluatedPolicyDomainStateHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEvaluatedPolicyDomainStateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual bool InteractionNotAllowed
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("interactionNotAllowed")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selInteractionNotAllowedHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selInteractionNotAllowedHandle);
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setInteractionNotAllowed:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetInteractionNotAllowed_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetInteractionNotAllowed_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual string? LocalizedCancelTitle
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("localizedCancelTitle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedCancelTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedCancelTitleHandle));
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setLocalizedCancelTitle:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocalizedCancelTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocalizedCancelTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? LocalizedFallbackTitle
	{
		[Export("localizedFallbackTitle")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedFallbackTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedFallbackTitleHandle));
		}
		[Export("setLocalizedFallbackTitle:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocalizedFallbackTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocalizedFallbackTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual string LocalizedReason
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("localizedReason")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedReasonHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedReasonHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setLocalizedReason:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocalizedReason_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocalizedReason_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	public virtual double TouchIdAuthenticationAllowableReuseDuration
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
		[Export("touchIDAuthenticationAllowableReuseDuration")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.Double_objc_msgSend(base.Handle, selTouchIDAuthenticationAllowableReuseDurationHandle);
			}
			return Messaging.Double_objc_msgSendSuper(base.SuperHandle, selTouchIDAuthenticationAllowableReuseDurationHandle);
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
		[Export("setTouchIDAuthenticationAllowableReuseDuration:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Double(base.Handle, selSetTouchIDAuthenticationAllowableReuseDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Double(base.SuperHandle, selSetTouchIDAuthenticationAllowableReuseDuration_Handle, value);
			}
		}
	}

	[Field("LAErrorDomain", "LocalAuthentication")]
	[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	public static NSString ErrorDomain
	{
		[Introduced(PlatformName.iOS, 8, 3, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
		get
		{
			if (_ErrorDomain == null)
			{
				_ErrorDomain = Dlfcn.GetStringConstant(Libraries.LocalAuthentication.Handle, "LAErrorDomain");
			}
			return _ErrorDomain;
		}
	}

	[Field("LATouchIDAuthenticationMaximumAllowableReuseDuration", "LocalAuthentication")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	public static double TouchIdAuthenticationMaximumAllowableReuseDuration
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetDouble(Libraries.LocalAuthentication.Handle, "LATouchIDAuthenticationMaximumAllowableReuseDuration");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public LAContext()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected LAContext(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal LAContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("canEvaluatePolicy:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanEvaluatePolicy(LAPolicy policy, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_Int64_ref_IntPtr(base.SuperHandle, selCanEvaluatePolicy_Error_Handle, (long)policy, ref arg) : Messaging.bool_objc_msgSend_Int64_ref_IntPtr(base.Handle, selCanEvaluatePolicy_Error_Handle, (long)policy, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("evaluateAccessControl:operation:localizedReason:reply:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EvaluateAccessControl(SecAccessControl accessControl, LAAccessControlOperation operation, string localizedReason, [BlockProxy(typeof(Trampolines.NIDActionArity2V4))] Action<bool, NSError> reply)
	{
		if (accessControl == null)
		{
			throw new ArgumentNullException("accessControl");
		}
		if (localizedReason == null)
		{
			throw new ArgumentNullException("localizedReason");
		}
		if (reply == null)
		{
			throw new ArgumentNullException("reply");
		}
		IntPtr arg = NSString.CreateNative(localizedReason);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V4.Handler, reply);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64_IntPtr_IntPtr(base.Handle, selEvaluateAccessControl_Operation_LocalizedReason_Reply_Handle, accessControl.Handle, (long)operation, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64_IntPtr_IntPtr(base.SuperHandle, selEvaluateAccessControl_Operation_LocalizedReason_Reply_Handle, accessControl.Handle, (long)operation, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("evaluatePolicy:localizedReason:reply:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EvaluatePolicy(LAPolicy policy, string localizedReason, [BlockProxy(typeof(Trampolines.NIDLAContextReplyHandler))] LAContextReplyHandler reply)
	{
		if (localizedReason == null)
		{
			throw new ArgumentNullException("localizedReason");
		}
		if (reply == null)
		{
			throw new ArgumentNullException("reply");
		}
		IntPtr arg = NSString.CreateNative(localizedReason);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDLAContextReplyHandler.Handler, reply);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr_IntPtr(base.Handle, selEvaluatePolicy_LocalizedReason_Reply_Handle, (long)policy, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr_IntPtr(base.SuperHandle, selEvaluatePolicy_LocalizedReason_Reply_Handle, (long)policy, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<Tuple<bool, NSError>> EvaluatePolicyAsync(LAPolicy policy, string localizedReason)
	{
		TaskCompletionSource<Tuple<bool, NSError>> tcs = new TaskCompletionSource<Tuple<bool, NSError>>();
		EvaluatePolicy(policy, localizedReason, delegate(bool success_, NSError error_)
		{
			tcs.SetResult(new Tuple<bool, NSError>(success_, error_));
		});
		return tcs.Task;
	}

	[Export("invalidate")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Invalidate()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selInvalidateHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selInvalidateHandle);
		}
	}

	[Export("isCredentialSet:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsCredentialSet(LACredentialType type)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selIsCredentialSet_Handle, (long)type);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selIsCredentialSet_Handle, (long)type);
	}

	[Export("setCredential:type:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool SetCredentialType(NSData? credential, LACredentialType type)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_Int64(base.Handle, selSetCredential_Type_Handle, credential?.Handle ?? IntPtr.Zero, (long)type);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selSetCredential_Type_Handle, credential?.Handle ?? IntPtr.Zero, (long)type);
	}
}
