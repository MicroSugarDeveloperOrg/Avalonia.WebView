using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace Accounts;

[Register("ACAccountStore", true)]
public class ACAccountStore : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccountTypeWithAccountTypeIdentifier_ = "accountTypeWithAccountTypeIdentifier:";

	private static readonly IntPtr selAccountTypeWithAccountTypeIdentifier_Handle = Selector.GetHandle("accountTypeWithAccountTypeIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccountWithIdentifier_ = "accountWithIdentifier:";

	private static readonly IntPtr selAccountWithIdentifier_Handle = Selector.GetHandle("accountWithIdentifier:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccounts = "accounts";

	private static readonly IntPtr selAccountsHandle = Selector.GetHandle("accounts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccountsWithAccountType_ = "accountsWithAccountType:";

	private static readonly IntPtr selAccountsWithAccountType_Handle = Selector.GetHandle("accountsWithAccountType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAccount_WithCompletionHandler_ = "removeAccount:withCompletionHandler:";

	private static readonly IntPtr selRemoveAccount_WithCompletionHandler_Handle = Selector.GetHandle("removeAccount:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenewCredentialsForAccount_Completion_ = "renewCredentialsForAccount:completion:";

	private static readonly IntPtr selRenewCredentialsForAccount_Completion_Handle = Selector.GetHandle("renewCredentialsForAccount:completion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestAccessToAccountsWithType_Options_Completion_ = "requestAccessToAccountsWithType:options:completion:";

	private static readonly IntPtr selRequestAccessToAccountsWithType_Options_Completion_Handle = Selector.GetHandle("requestAccessToAccountsWithType:options:completion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestAccessToAccountsWithType_WithCompletionHandler_ = "requestAccessToAccountsWithType:withCompletionHandler:";

	private static readonly IntPtr selRequestAccessToAccountsWithType_WithCompletionHandler_Handle = Selector.GetHandle("requestAccessToAccountsWithType:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveAccount_WithCompletionHandler_ = "saveAccount:withCompletionHandler:";

	private static readonly IntPtr selSaveAccount_WithCompletionHandler_Handle = Selector.GetHandle("saveAccount:withCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("ACAccountStore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private object? __mt_Accounts_var;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChangeNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ACAccount[] Accounts
	{
		[Export("accounts", ArgumentSemantic.Weak)]
		get
		{
			ACAccount[] array = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<ACAccount>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccountsHandle)) : NSArray.ArrayFromHandle<ACAccount>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccountsHandle)));
			MarkDirty();
			__mt_Accounts_var = array;
			return array;
		}
	}

	[Field("ACAccountStoreDidChangeNotification", "Accounts")]
	[Advice("Use ACAccountStore.Notifications.ObserveChange helper method instead.")]
	public static NSString ChangeNotification
	{
		get
		{
			if (_ChangeNotification == null)
			{
				_ChangeNotification = Dlfcn.GetStringConstant(Libraries.Accounts.Handle, "ACAccountStoreDidChangeNotification");
			}
			return _ChangeNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public ACAccountStore()
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
	protected ACAccountStore(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal ACAccountStore(IntPtr handle)
		: base(handle)
	{
	}

	[Export("accountWithIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ACAccount FindAccount(string identifier)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		ACAccount result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<ACAccount>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAccountWithIdentifier_Handle, arg)) : Runtime.GetNSObject<ACAccount>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAccountWithIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("accountTypeWithAccountTypeIdentifier:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ACAccountType FindAccountType(string typeIdentifier)
	{
		if (typeIdentifier == null)
		{
			throw new ArgumentNullException("typeIdentifier");
		}
		IntPtr arg = NSString.CreateNative(typeIdentifier);
		ACAccountType result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<ACAccountType>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAccountTypeWithAccountTypeIdentifier_Handle, arg)) : Runtime.GetNSObject<ACAccountType>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAccountTypeWithAccountTypeIdentifier_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("accountsWithAccountType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual ACAccount[] FindAccounts(ACAccountType accountType)
	{
		if (accountType == null)
		{
			throw new ArgumentNullException("accountType");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<ACAccount>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAccountsWithAccountType_Handle, accountType.Handle));
		}
		return NSArray.ArrayFromHandle<ACAccount>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAccountsWithAccountType_Handle, accountType.Handle));
	}

	[Export("removeAccount:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RemoveAccount(ACAccount account, [BlockProxy(typeof(Trampolines.NIDACAccountStoreRemoveCompletionHandler))] ACAccountStoreRemoveCompletionHandler completionHandler)
	{
		if (account == null)
		{
			throw new ArgumentNullException("account");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDACAccountStoreRemoveCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveAccount_WithCompletionHandler_Handle, account.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveAccount_WithCompletionHandler_Handle, account.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<Tuple<bool, NSError>> RemoveAccountAsync(ACAccount account)
	{
		TaskCompletionSource<Tuple<bool, NSError>> tcs = new TaskCompletionSource<Tuple<bool, NSError>>();
		RemoveAccount(account, delegate(bool success_, NSError error_)
		{
			tcs.SetResult(new Tuple<bool, NSError>(success_, error_));
		});
		return tcs.Task;
	}

	[Export("renewCredentialsForAccount:completion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RenewCredentials(ACAccount account, [BlockProxy(typeof(Trampolines.NIDActionArity2V5))] Action<ACAccountCredentialRenewResult, NSError> completionHandler)
	{
		if (account == null)
		{
			throw new ArgumentNullException("account");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V5.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRenewCredentialsForAccount_Completion_Handle, account.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRenewCredentialsForAccount_Completion_Handle, account.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<ACAccountCredentialRenewResult> RenewCredentialsAsync(ACAccount account)
	{
		TaskCompletionSource<ACAccountCredentialRenewResult> tcs = new TaskCompletionSource<ACAccountCredentialRenewResult>();
		RenewCredentials(account, delegate(ACAccountCredentialRenewResult arg1_, NSError arg2_)
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

	[Export("requestAccessToAccountsWithType:withCompletionHandler:")]
	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.All, "Use 'RequestAccess (ACAccountType, AccountStoreOptions, ACRequestCompletionHandler)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RequestAccess(ACAccountType accountType, [BlockProxy(typeof(Trampolines.NIDACRequestCompletionHandler))] ACRequestCompletionHandler completionHandler)
	{
		if (accountType == null)
		{
			throw new ArgumentNullException("accountType");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDACRequestCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRequestAccessToAccountsWithType_WithCompletionHandler_Handle, accountType.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRequestAccessToAccountsWithType_WithCompletionHandler_Handle, accountType.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Deprecated(PlatformName.iOS, 6, 0, PlatformArchitecture.All, "Use 'RequestAccess (ACAccountType, AccountStoreOptions, ACRequestCompletionHandler)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<Tuple<bool, NSError>> RequestAccessAsync(ACAccountType accountType)
	{
		TaskCompletionSource<Tuple<bool, NSError>> tcs = new TaskCompletionSource<Tuple<bool, NSError>>();
		RequestAccess(accountType, delegate(bool granted_, NSError error_)
		{
			tcs.SetResult(new Tuple<bool, NSError>(granted_, error_));
		});
		return tcs.Task;
	}

	[Export("requestAccessToAccountsWithType:options:completion:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected unsafe virtual void RequestAccess(ACAccountType accountType, NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDACRequestCompletionHandler))] ACRequestCompletionHandler completion)
	{
		if (accountType == null)
		{
			throw new ArgumentNullException("accountType");
		}
		if (completion == null)
		{
			throw new ArgumentNullException("completion");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDACRequestCompletionHandler.Handler, completion);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRequestAccessToAccountsWithType_Options_Completion_Handle, accountType.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRequestAccessToAccountsWithType_Options_Completion_Handle, accountType.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual Task<Tuple<bool, NSError>> RequestAccessAsync(ACAccountType accountType, NSDictionary? options)
	{
		TaskCompletionSource<Tuple<bool, NSError>> tcs = new TaskCompletionSource<Tuple<bool, NSError>>();
		RequestAccess(accountType, options, delegate(bool granted_, NSError error_)
		{
			tcs.SetResult(new Tuple<bool, NSError>(granted_, error_));
		});
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void RequestAccess(ACAccountType accountType, AccountStoreOptions? options, [BlockProxy(typeof(Trampolines.NIDACRequestCompletionHandler))] ACRequestCompletionHandler completion)
	{
		RequestAccess(accountType, options.GetDictionary(), completion);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<Tuple<bool, NSError>> RequestAccessAsync(ACAccountType accountType, AccountStoreOptions? options)
	{
		TaskCompletionSource<Tuple<bool, NSError>> tcs = new TaskCompletionSource<Tuple<bool, NSError>>();
		RequestAccess(accountType, options, delegate(bool granted_, NSError error_)
		{
			tcs.SetResult(new Tuple<bool, NSError>(granted_, error_));
		});
		return tcs.Task;
	}

	[Export("saveAccount:withCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SaveAccount(ACAccount account, [BlockProxy(typeof(Trampolines.NIDACAccountStoreSaveCompletionHandler))] ACAccountStoreSaveCompletionHandler completionHandler)
	{
		if (account == null)
		{
			throw new ArgumentNullException("account");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDACAccountStoreSaveCompletionHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSaveAccount_WithCompletionHandler_Handle, account.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSaveAccount_WithCompletionHandler_Handle, account.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<Tuple<bool, NSError>> SaveAccountAsync(ACAccount account)
	{
		TaskCompletionSource<Tuple<bool, NSError>> tcs = new TaskCompletionSource<Tuple<bool, NSError>>();
		SaveAccount(account, delegate(bool success_, NSError error_)
		{
			tcs.SetResult(new Tuple<bool, NSError>(success_, error_));
		});
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Accounts_var = null;
		}
	}
}
