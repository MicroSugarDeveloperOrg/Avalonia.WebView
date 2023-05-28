using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace AuthenticationServices;

[Register("ASAuthorizationAppleIDProvider", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class ASAuthorizationAppleIdProvider : NSObject, IASAuthorizationProvider, INativeObject, IDisposable
{
	public static class Notifications
	{
		public static NSObject ObserveCredentialRevoked(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(CredentialRevokedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveCredentialRevoked(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(CredentialRevokedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateRequest = "createRequest";

	private static readonly IntPtr selCreateRequestHandle = Selector.GetHandle("createRequest");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetCredentialStateForUserID_Completion_ = "getCredentialStateForUserID:completion:";

	private static readonly IntPtr selGetCredentialStateForUserID_Completion_Handle = Selector.GetHandle("getCredentialStateForUserID:completion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ASAuthorizationAppleIDProvider");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CredentialRevokedNotification;

	public override IntPtr ClassHandle => class_ptr;

	[Field("ASAuthorizationAppleIDProviderCredentialRevokedNotification", "AuthenticationServices")]
	[Advice("Use ASAuthorizationAppleIdProvider.Notifications.ObserveCredentialRevoked helper method instead.")]
	public static NSString CredentialRevokedNotification
	{
		get
		{
			if (_CredentialRevokedNotification == null)
			{
				_CredentialRevokedNotification = Dlfcn.GetStringConstant(Libraries.AuthenticationServices.Handle, "ASAuthorizationAppleIDProviderCredentialRevokedNotification");
			}
			return _CredentialRevokedNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public ASAuthorizationAppleIdProvider()
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
	protected ASAuthorizationAppleIdProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ASAuthorizationAppleIdProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("createRequest")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ASAuthorizationAppleIdRequest CreateRequest()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<ASAuthorizationAppleIdRequest>(Messaging.IntPtr_objc_msgSend(base.Handle, selCreateRequestHandle));
		}
		return Runtime.GetNSObject<ASAuthorizationAppleIdRequest>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreateRequestHandle));
	}

	[Export("getCredentialStateForUserID:completion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetCredentialState(string userID, [BlockProxy(typeof(Trampolines.NIDActionArity2V13))] Action<ASAuthorizationAppleIdProviderCredentialState, NSError> completion)
	{
		if (userID == null)
		{
			throw new ArgumentNullException("userID");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		IntPtr arg = NSString.CreateNative(userID);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V13.Handler, completion);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetCredentialStateForUserID_Completion_Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetCredentialStateForUserID_Completion_Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<ASAuthorizationAppleIdProviderCredentialState> GetCredentialStateAsync(string userID)
	{
		TaskCompletionSource<ASAuthorizationAppleIdProviderCredentialState> tcs = new TaskCompletionSource<ASAuthorizationAppleIdProviderCredentialState>();
		GetCredentialState(userID, delegate(ASAuthorizationAppleIdProviderCredentialState arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}
}
