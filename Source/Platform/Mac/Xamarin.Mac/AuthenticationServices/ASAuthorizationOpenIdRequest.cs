using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Register("ASAuthorizationOpenIDRequest", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class ASAuthorizationOpenIdRequest : ASAuthorizationRequest
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNonce = "nonce";

	private static readonly IntPtr selNonceHandle = Selector.GetHandle("nonce");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestedOperation = "requestedOperation";

	private static readonly IntPtr selRequestedOperationHandle = Selector.GetHandle("requestedOperation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestedScopes = "requestedScopes";

	private static readonly IntPtr selRequestedScopesHandle = Selector.GetHandle("requestedScopes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNonce_ = "setNonce:";

	private static readonly IntPtr selSetNonce_Handle = Selector.GetHandle("setNonce:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequestedOperation_ = "setRequestedOperation:";

	private static readonly IntPtr selSetRequestedOperation_Handle = Selector.GetHandle("setRequestedOperation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequestedScopes_ = "setRequestedScopes:";

	private static readonly IntPtr selSetRequestedScopes_Handle = Selector.GetHandle("setRequestedScopes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetState_ = "setState:";

	private static readonly IntPtr selSetState_Handle = Selector.GetHandle("setState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selState = "state";

	private static readonly IntPtr selStateHandle = Selector.GetHandle("state");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ASAuthorizationOpenIDRequest");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? Nonce
	{
		[Export("nonce")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNonceHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNonceHandle));
		}
		[Export("setNonce:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNonce_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNonce_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[BindAs(typeof(ASAuthorizationOperation), OriginalType = typeof(NSString))]
	public virtual ASAuthorizationOperation RequestedOperation
	{
		[Export("requestedOperation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return ASAuthorizationOperationExtensions.GetValue(Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selRequestedOperationHandle)));
			}
			return ASAuthorizationOperationExtensions.GetValue(Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequestedOperationHandle)));
		}
		[Export("setRequestedOperation:")]
		set
		{
			NSString constant = value.GetConstant();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRequestedOperation_Handle, (constant == null) ? IntPtr.Zero : constant.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRequestedOperation_Handle, (constant == null) ? IntPtr.Zero : constant.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[BindAs(typeof(ASAuthorizationScope[]), OriginalType = typeof(NSString[]))]
	public virtual ASAuthorizationScope[]? RequestedScopes
	{
		[Export("requestedScopes", ArgumentSemantic.Copy)]
		get
		{
			IntPtr intPtr;
			if (base.IsDirectBinding)
			{
				return ((intPtr = Messaging.IntPtr_objc_msgSend(base.Handle, selRequestedScopesHandle)) == IntPtr.Zero) ? null : NSArray.ArrayFromHandleFunc(intPtr, delegate(IntPtr ptr)
				{
					using NSString constant2 = Runtime.GetNSObject<NSString>(ptr);
					return ASAuthorizationScopeExtensions.GetValue(constant2);
				});
			}
			IntPtr intPtr2;
			return ((intPtr2 = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRequestedScopesHandle)) == IntPtr.Zero) ? null : NSArray.ArrayFromHandleFunc(intPtr2, delegate(IntPtr ptr)
			{
				using NSString constant = Runtime.GetNSObject<NSString>(ptr);
				return ASAuthorizationScopeExtensions.GetValue(constant);
			});
		}
		[Export("setRequestedScopes:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = NSArray.FromNSObjects((ASAuthorizationScope o) => o.GetConstant(), value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRequestedScopes_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRequestedScopes_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? State
	{
		[Export("state")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStateHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStateHandle));
		}
		[Export("setState:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetState_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetState_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public ASAuthorizationOpenIdRequest(NSCoder coder)
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
	protected ASAuthorizationOpenIdRequest(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ASAuthorizationOpenIdRequest(IntPtr handle)
		: base(handle)
	{
	}
}
