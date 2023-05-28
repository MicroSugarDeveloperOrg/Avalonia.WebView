using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;
using Security;

namespace NetworkExtension;

[Register("NEVPNManager", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NEVpnManager : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveConfigurationChange(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ConfigurationChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveConfigurationChange(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(ConfigurationChangeNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConnection = "connection";

	private static readonly IntPtr selConnectionHandle = Selector.GetHandle("connection");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEnabled = "isEnabled";

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsOnDemandEnabled = "isOnDemandEnabled";

	private static readonly IntPtr selIsOnDemandEnabledHandle = Selector.GetHandle("isOnDemandEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadFromPreferencesWithCompletionHandler_ = "loadFromPreferencesWithCompletionHandler:";

	private static readonly IntPtr selLoadFromPreferencesWithCompletionHandler_Handle = Selector.GetHandle("loadFromPreferencesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedDescription = "localizedDescription";

	private static readonly IntPtr selLocalizedDescriptionHandle = Selector.GetHandle("localizedDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOnDemandRules = "onDemandRules";

	private static readonly IntPtr selOnDemandRulesHandle = Selector.GetHandle("onDemandRules");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProtocol = "protocol";

	private static readonly IntPtr selProtocolHandle = Selector.GetHandle("protocol");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProtocolConfiguration = "protocolConfiguration";

	private static readonly IntPtr selProtocolConfigurationHandle = Selector.GetHandle("protocolConfiguration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveFromPreferencesWithCompletionHandler_ = "removeFromPreferencesWithCompletionHandler:";

	private static readonly IntPtr selRemoveFromPreferencesWithCompletionHandler_Handle = Selector.GetHandle("removeFromPreferencesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveToPreferencesWithCompletionHandler_ = "saveToPreferencesWithCompletionHandler:";

	private static readonly IntPtr selSaveToPreferencesWithCompletionHandler_Handle = Selector.GetHandle("saveToPreferencesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAuthorization_ = "setAuthorization:";

	private static readonly IntPtr selSetAuthorization_Handle = Selector.GetHandle("setAuthorization:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnabled_ = "setEnabled:";

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLocalizedDescription_ = "setLocalizedDescription:";

	private static readonly IntPtr selSetLocalizedDescription_Handle = Selector.GetHandle("setLocalizedDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOnDemandEnabled_ = "setOnDemandEnabled:";

	private static readonly IntPtr selSetOnDemandEnabled_Handle = Selector.GetHandle("setOnDemandEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOnDemandRules_ = "setOnDemandRules:";

	private static readonly IntPtr selSetOnDemandRules_Handle = Selector.GetHandle("setOnDemandRules:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProtocol_ = "setProtocol:";

	private static readonly IntPtr selSetProtocol_Handle = Selector.GetHandle("setProtocol:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProtocolConfiguration_ = "setProtocolConfiguration:";

	private static readonly IntPtr selSetProtocolConfiguration_Handle = Selector.GetHandle("setProtocolConfiguration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedManager = "sharedManager";

	private static readonly IntPtr selSharedManagerHandle = Selector.GetHandle("sharedManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEVPNManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ConfigurationChangeNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorDomain;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEVpnConnection Connection
	{
		[Export("connection")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NEVpnConnection>(Messaging.IntPtr_objc_msgSend(base.Handle, selConnectionHandle));
			}
			return Runtime.GetNSObject<NEVpnConnection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selConnectionHandle));
		}
	}

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
	public virtual bool OnDemandEnabled
	{
		[Export("isOnDemandEnabled")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOnDemandEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOnDemandEnabledHandle);
		}
		[Export("setOnDemandEnabled:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetOnDemandEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetOnDemandEnabled_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEOnDemandRule[]? OnDemandRules
	{
		[Export("onDemandRules", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NEOnDemandRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selOnDemandRulesHandle));
			}
			return NSArray.ArrayFromHandle<NEOnDemandRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOnDemandRulesHandle));
		}
		[Export("setOnDemandRules:", ArgumentSemantic.Copy)]
		set
		{
			NSArray nSArray = ((value == null) ? null : NSArray.FromNSObjects(value));
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOnDemandRules_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOnDemandRules_Handle, nSArray?.Handle ?? IntPtr.Zero);
			}
			nSArray?.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'ProtocolConfiguration' instead.")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'ProtocolConfiguration' instead.")]
	public virtual NEVpnProtocol? Protocol
	{
		[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'ProtocolConfiguration' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'ProtocolConfiguration' instead.")]
		[Export("protocol", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NEVpnProtocol>(Messaging.IntPtr_objc_msgSend(base.Handle, selProtocolHandle));
			}
			return Runtime.GetNSObject<NEVpnProtocol>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProtocolHandle));
		}
		[Deprecated(PlatformName.iOS, 9, 0, PlatformArchitecture.None, "Use 'ProtocolConfiguration' instead.")]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'ProtocolConfiguration' instead.")]
		[Export("setProtocol:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProtocol_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProtocol_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public virtual NEVpnProtocol? ProtocolConfiguration
	{
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("protocolConfiguration", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NEVpnProtocol>(Messaging.IntPtr_objc_msgSend(base.Handle, selProtocolConfigurationHandle));
			}
			return Runtime.GetNSObject<NEVpnProtocol>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selProtocolConfigurationHandle));
		}
		[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		[Export("setProtocolConfiguration:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetProtocolConfiguration_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetProtocolConfiguration_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NEVpnManager SharedManager
	{
		[Export("sharedManager")]
		get
		{
			return Runtime.GetNSObject<NEVpnManager>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedManagerHandle));
		}
	}

	[Field("NEVPNConfigurationChangeNotification", "NetworkExtension")]
	[Advice("Use NEVpnManager.Notifications.ObserveConfigurationChange helper method instead.")]
	public static NSString ConfigurationChangeNotification
	{
		get
		{
			if (_ConfigurationChangeNotification == null)
			{
				_ConfigurationChangeNotification = Dlfcn.GetStringConstant(Libraries.NetworkExtension.Handle, "NEVPNConfigurationChangeNotification");
			}
			return _ConfigurationChangeNotification;
		}
	}

	[Field("NEVPNErrorDomain", "NetworkExtension")]
	public static NSString ErrorDomain
	{
		get
		{
			if (_ErrorDomain == null)
			{
				_ErrorDomain = Dlfcn.GetStringConstant(Libraries.NetworkExtension.Handle, "NEVPNErrorDomain");
			}
			return _ErrorDomain;
		}
	}

	[Mac(10, 11)]
	public void SetAuthorization(Authorization authorization)
	{
		if (authorization == null)
		{
			throw new ArgumentNullException("authorization");
		}
		_SetAuthorization(authorization.Handle);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NEVpnManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEVpnManager(IntPtr handle)
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
	public unsafe virtual void RemoveFromPreferences([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveFromPreferencesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveFromPreferencesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
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
	public unsafe virtual void SaveToPreferences([BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSaveToPreferencesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSaveToPreferencesWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
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

	[Export("setAuthorization:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetAuthorization(IntPtr auth)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAuthorization_Handle, auth);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAuthorization_Handle, auth);
		}
	}
}
