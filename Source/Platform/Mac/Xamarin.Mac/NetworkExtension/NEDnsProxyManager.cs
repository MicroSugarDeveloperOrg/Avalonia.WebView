using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEDNSProxyManager", true)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NEDnsProxyManager : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveProxyConfigurationDidChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ProxyConfigurationDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveProxyConfigurationDidChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ProxyConfigurationDidChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadFromPreferencesWithCompletionHandler_ = "loadFromPreferencesWithCompletionHandler:";

	private static readonly IntPtr selLoadFromPreferencesWithCompletionHandler_Handle = Selector.GetHandle("loadFromPreferencesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedDescription = "localizedDescription";

	private static readonly IntPtr selLocalizedDescriptionHandle = Selector.GetHandle("localizedDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProviderProtocol = "providerProtocol";

	private static readonly IntPtr selProviderProtocolHandle = Selector.GetHandle("providerProtocol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFromPreferencesWithCompletionHandler_ = "removeFromPreferencesWithCompletionHandler:";

	private static readonly IntPtr selRemoveFromPreferencesWithCompletionHandler_Handle = Selector.GetHandle("removeFromPreferencesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveToPreferencesWithCompletionHandler_ = "saveToPreferencesWithCompletionHandler:";

	private static readonly IntPtr selSaveToPreferencesWithCompletionHandler_Handle = Selector.GetHandle("saveToPreferencesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocalizedDescription_ = "setLocalizedDescription:";

	private static readonly IntPtr selSetLocalizedDescription_Handle = Selector.GetHandle("setLocalizedDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProviderProtocol_ = "setProviderProtocol:";

	private static readonly IntPtr selSetProviderProtocol_Handle = Selector.GetHandle("setProviderProtocol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedManager = "sharedManager";

	private static readonly IntPtr selSharedManagerHandle = Selector.GetHandle("sharedManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEDNSProxyManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ProxyConfigurationDidChangeNotification;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? LocalizedDescription
	{
		[Export("localizedDescription")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedDescriptionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedDescriptionHandle));
		}
		[Export("setLocalizedDescription:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLocalizedDescription_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLocalizedDescription_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEDnsProxyProviderProtocol? ProviderProtocol
	{
		[Export("providerProtocol", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NEDnsProxyProviderProtocol>(Messaging.IntPtr_objc_msgSend(base.Handle, selProviderProtocolHandle));
			}
			return Runtime.GetNSObject<NEDnsProxyProviderProtocol>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProviderProtocolHandle));
		}
		[Export("setProviderProtocol:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProviderProtocol_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProviderProtocol_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NEDnsProxyManager SharedManager
	{
		[Export("sharedManager")]
		get
		{
			return Runtime.GetNSObject<NEDnsProxyManager>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedManagerHandle));
		}
	}

	[Field("NEDNSProxyConfigurationDidChangeNotification", "NetworkExtension")]
	[Advice("Use NEDnsProxyManager.Notifications.ObserveProxyConfigurationDidChange helper method instead.")]
	public static NSString ProxyConfigurationDidChangeNotification
	{
		get
		{
			if (_ProxyConfigurationDidChangeNotification == null)
			{
				_ProxyConfigurationDidChangeNotification = Dlfcn.GetStringConstant(Libraries.NetworkExtension.Handle, "NEDNSProxyConfigurationDidChangeNotification");
			}
			return _ProxyConfigurationDidChangeNotification;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NEDnsProxyManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEDnsProxyManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("loadFromPreferencesWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void LoadFromPreferences([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLoadFromPreferencesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLoadFromPreferencesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task LoadFromPreferencesAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		LoadFromPreferences(delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}

	[Export("removeFromPreferencesWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RemoveFromPreferences([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveFromPreferencesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveFromPreferencesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task RemoveFromPreferencesAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		RemoveFromPreferences(delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}

	[Export("saveToPreferencesWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SaveToPreferences([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSaveToPreferencesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSaveToPreferencesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SaveToPreferencesAsync()
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SaveToPreferences(delegate(NSError obj_)
		{
			if (obj_ != null)
			{
				tcs.SetException(new NSErrorException(obj_));
			}
			else
			{
				tcs.SetResult(result: true);
			}
		});
		return tcs.Task;
	}
}
