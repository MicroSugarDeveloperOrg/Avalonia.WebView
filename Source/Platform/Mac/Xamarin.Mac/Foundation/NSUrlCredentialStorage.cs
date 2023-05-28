using System;
using System.ComponentModel;
using System.Threading.Tasks;
using ObjCRuntime;

namespace Foundation;

[Register("NSURLCredentialStorage", true)]
public class NSUrlCredentialStorage : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveChanged(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveChanged(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ChangedNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllCredentials = "allCredentials";

	private static readonly IntPtr selAllCredentialsHandle = Selector.GetHandle("allCredentials");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCredentialsForProtectionSpace_ = "credentialsForProtectionSpace:";

	private static readonly IntPtr selCredentialsForProtectionSpace_Handle = Selector.GetHandle("credentialsForProtectionSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultCredentialForProtectionSpace_ = "defaultCredentialForProtectionSpace:";

	private static readonly IntPtr selDefaultCredentialForProtectionSpace_Handle = Selector.GetHandle("defaultCredentialForProtectionSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetCredentialsForProtectionSpace_Task_CompletionHandler_ = "getCredentialsForProtectionSpace:task:completionHandler:";

	private static readonly IntPtr selGetCredentialsForProtectionSpace_Task_CompletionHandler_Handle = Selector.GetHandle("getCredentialsForProtectionSpace:task:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetDefaultCredentialForProtectionSpace_Task_CompletionHandler_ = "getDefaultCredentialForProtectionSpace:task:completionHandler:";

	private static readonly IntPtr selGetDefaultCredentialForProtectionSpace_Task_CompletionHandler_Handle = Selector.GetHandle("getDefaultCredentialForProtectionSpace:task:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveCredential_ForProtectionSpace_ = "removeCredential:forProtectionSpace:";

	private static readonly IntPtr selRemoveCredential_ForProtectionSpace_Handle = Selector.GetHandle("removeCredential:forProtectionSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveCredential_ForProtectionSpace_Options_ = "removeCredential:forProtectionSpace:options:";

	private static readonly IntPtr selRemoveCredential_ForProtectionSpace_Options_Handle = Selector.GetHandle("removeCredential:forProtectionSpace:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveCredential_ForProtectionSpace_Options_Task_ = "removeCredential:forProtectionSpace:options:task:";

	private static readonly IntPtr selRemoveCredential_ForProtectionSpace_Options_Task_Handle = Selector.GetHandle("removeCredential:forProtectionSpace:options:task:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCredential_ForProtectionSpace_ = "setCredential:forProtectionSpace:";

	private static readonly IntPtr selSetCredential_ForProtectionSpace_Handle = Selector.GetHandle("setCredential:forProtectionSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCredential_ForProtectionSpace_Task_ = "setCredential:forProtectionSpace:task:";

	private static readonly IntPtr selSetCredential_ForProtectionSpace_Task_Handle = Selector.GetHandle("setCredential:forProtectionSpace:task:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultCredential_ForProtectionSpace_ = "setDefaultCredential:forProtectionSpace:";

	private static readonly IntPtr selSetDefaultCredential_ForProtectionSpace_Handle = Selector.GetHandle("setDefaultCredential:forProtectionSpace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDefaultCredential_ForProtectionSpace_Task_ = "setDefaultCredential:forProtectionSpace:task:";

	private static readonly IntPtr selSetDefaultCredential_ForProtectionSpace_Task_Handle = Selector.GetHandle("setDefaultCredential:forProtectionSpace:task:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedCredentialStorage = "sharedCredentialStorage";

	private static readonly IntPtr selSharedCredentialStorageHandle = Selector.GetHandle("sharedCredentialStorage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSURLCredentialStorage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ChangedNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _RemoveSynchronizableCredentials;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary AllCredentials
	{
		[Export("allCredentials")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selAllCredentialsHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAllCredentialsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrlCredentialStorage SharedCredentialStorage
	{
		[Export("sharedCredentialStorage", ArgumentSemantic.Retain)]
		get
		{
			return Runtime.GetNSObject<NSUrlCredentialStorage>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedCredentialStorageHandle));
		}
	}

	[Field("NSURLCredentialStorageChangedNotification", "Foundation")]
	[Advice("Use NSUrlCredentialStorage.Notifications.ObserveChanged helper method instead.")]
	public static NSString ChangedNotification
	{
		get
		{
			if (_ChangedNotification == null)
			{
				_ChangedNotification = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLCredentialStorageChangedNotification");
			}
			return _ChangedNotification;
		}
	}

	[Field("NSURLCredentialStorageRemoveSynchronizableCredentials", "Foundation")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public static NSString RemoveSynchronizableCredentials
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		get
		{
			if (_RemoveSynchronizableCredentials == null)
			{
				_RemoveSynchronizableCredentials = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSURLCredentialStorageRemoveSynchronizableCredentials");
			}
			return _RemoveSynchronizableCredentials;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSUrlCredentialStorage(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSUrlCredentialStorage(IntPtr handle)
		: base(handle)
	{
	}

	[Export("credentialsForProtectionSpace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary GetCredentials(NSUrlProtectionSpace forProtectionSpace)
	{
		if (forProtectionSpace == null)
		{
			throw new ArgumentNullException("forProtectionSpace");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCredentialsForProtectionSpace_Handle, forProtectionSpace.Handle));
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCredentialsForProtectionSpace_Handle, forProtectionSpace.Handle));
	}

	[Export("getCredentialsForProtectionSpace:task:completionHandler:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetCredentials(NSUrlProtectionSpace protectionSpace, NSUrlSessionTask task, [BlockProxy(typeof(Trampolines.NIDActionArity1V37))] Action<NSDictionary>? completionHandler)
	{
		if (protectionSpace == null)
		{
			throw new ArgumentNullException("protectionSpace");
		}
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V37.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selGetCredentialsForProtectionSpace_Task_CompletionHandler_Handle, protectionSpace.Handle, task.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selGetCredentialsForProtectionSpace_Task_CompletionHandler_Handle, protectionSpace.Handle, task.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSDictionary> GetCredentialsAsync(NSUrlProtectionSpace protectionSpace, NSUrlSessionTask task)
	{
		TaskCompletionSource<NSDictionary> tcs = new TaskCompletionSource<NSDictionary>();
		GetCredentials(protectionSpace, task, delegate(NSDictionary obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("defaultCredentialForProtectionSpace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrlCredential GetDefaultCredential(NSUrlProtectionSpace forProtectionSpace)
	{
		if (forProtectionSpace == null)
		{
			throw new ArgumentNullException("forProtectionSpace");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSUrlCredential>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selDefaultCredentialForProtectionSpace_Handle, forProtectionSpace.Handle));
		}
		return Runtime.GetNSObject<NSUrlCredential>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selDefaultCredentialForProtectionSpace_Handle, forProtectionSpace.Handle));
	}

	[Export("getDefaultCredentialForProtectionSpace:task:completionHandler:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetDefaultCredential(NSUrlProtectionSpace space, NSUrlSessionTask task, [BlockProxy(typeof(Trampolines.NIDActionArity1V38))] Action<NSUrlCredential>? completionHandler)
	{
		if (space == null)
		{
			throw new ArgumentNullException("space");
		}
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V38.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selGetDefaultCredentialForProtectionSpace_Task_CompletionHandler_Handle, space.Handle, task.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selGetDefaultCredentialForProtectionSpace_Task_CompletionHandler_Handle, space.Handle, task.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSUrlCredential> GetDefaultCredentialAsync(NSUrlProtectionSpace space, NSUrlSessionTask task)
	{
		TaskCompletionSource<NSUrlCredential> tcs = new TaskCompletionSource<NSUrlCredential>();
		GetDefaultCredential(space, task, delegate(NSUrlCredential obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("removeCredential:forProtectionSpace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveCredential(NSUrlCredential credential, NSUrlProtectionSpace forProtectionSpace)
	{
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		if (forProtectionSpace == null)
		{
			throw new ArgumentNullException("forProtectionSpace");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveCredential_ForProtectionSpace_Handle, credential.Handle, forProtectionSpace.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveCredential_ForProtectionSpace_Handle, credential.Handle, forProtectionSpace.Handle);
		}
	}

	[Export("removeCredential:forProtectionSpace:options:")]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveCredential(NSUrlCredential credential, NSUrlProtectionSpace forProtectionSpace, NSDictionary options)
	{
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		if (forProtectionSpace == null)
		{
			throw new ArgumentNullException("forProtectionSpace");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRemoveCredential_ForProtectionSpace_Options_Handle, credential.Handle, forProtectionSpace.Handle, options.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRemoveCredential_ForProtectionSpace_Options_Handle, credential.Handle, forProtectionSpace.Handle, options.Handle);
		}
	}

	[Export("removeCredential:forProtectionSpace:options:task:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveCredential(NSUrlCredential credential, NSUrlProtectionSpace protectionSpace, NSDictionary options, NSUrlSessionTask task)
	{
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		if (protectionSpace == null)
		{
			throw new ArgumentNullException("protectionSpace");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selRemoveCredential_ForProtectionSpace_Options_Task_Handle, credential.Handle, protectionSpace.Handle, options.Handle, task.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRemoveCredential_ForProtectionSpace_Options_Task_Handle, credential.Handle, protectionSpace.Handle, options.Handle, task.Handle);
		}
	}

	[Export("setCredential:forProtectionSpace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCredential(NSUrlCredential credential, NSUrlProtectionSpace forProtectionSpace)
	{
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		if (forProtectionSpace == null)
		{
			throw new ArgumentNullException("forProtectionSpace");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetCredential_ForProtectionSpace_Handle, credential.Handle, forProtectionSpace.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetCredential_ForProtectionSpace_Handle, credential.Handle, forProtectionSpace.Handle);
		}
	}

	[Export("setCredential:forProtectionSpace:task:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetCredential(NSUrlCredential credential, NSUrlProtectionSpace protectionSpace, NSUrlSessionTask task)
	{
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		if (protectionSpace == null)
		{
			throw new ArgumentNullException("protectionSpace");
		}
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSetCredential_ForProtectionSpace_Task_Handle, credential.Handle, protectionSpace.Handle, task.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetCredential_ForProtectionSpace_Task_Handle, credential.Handle, protectionSpace.Handle, task.Handle);
		}
	}

	[Export("setDefaultCredential:forProtectionSpace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDefaultCredential(NSUrlCredential credential, NSUrlProtectionSpace forProtectionSpace)
	{
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		if (forProtectionSpace == null)
		{
			throw new ArgumentNullException("forProtectionSpace");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetDefaultCredential_ForProtectionSpace_Handle, credential.Handle, forProtectionSpace.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetDefaultCredential_ForProtectionSpace_Handle, credential.Handle, forProtectionSpace.Handle);
		}
	}

	[Export("setDefaultCredential:forProtectionSpace:task:")]
	[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetDefaultCredential(NSUrlCredential credential, NSUrlProtectionSpace protectionSpace, NSUrlSessionTask task)
	{
		if (credential == null)
		{
			throw new ArgumentNullException("credential");
		}
		if (protectionSpace == null)
		{
			throw new ArgumentNullException("protectionSpace");
		}
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSetDefaultCredential_ForProtectionSpace_Task_Handle, credential.Handle, protectionSpace.Handle, task.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetDefaultCredential_ForProtectionSpace_Task_Handle, credential.Handle, protectionSpace.Handle, task.Handle);
		}
	}
}
