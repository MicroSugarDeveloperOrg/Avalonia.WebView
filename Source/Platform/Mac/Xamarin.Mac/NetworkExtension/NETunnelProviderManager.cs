using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NETunnelProviderManager", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NETunnelProviderManager : NEVpnManager
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppRules = "appRules";

	private static readonly IntPtr selAppRulesHandle = Selector.GetHandle("appRules");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCalendarDomains = "calendarDomains";

	private static readonly IntPtr selCalendarDomainsHandle = Selector.GetHandle("calendarDomains");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContactsDomains = "contactsDomains";

	private static readonly IntPtr selContactsDomainsHandle = Selector.GetHandle("contactsDomains");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyAppRules = "copyAppRules";

	private static readonly IntPtr selCopyAppRulesHandle = Selector.GetHandle("copyAppRules");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selForPerAppVPN = "forPerAppVPN";

	private static readonly IntPtr selForPerAppVPNHandle = Selector.GetHandle("forPerAppVPN");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadAllFromPreferencesWithCompletionHandler_ = "loadAllFromPreferencesWithCompletionHandler:";

	private static readonly IntPtr selLoadAllFromPreferencesWithCompletionHandler_Handle = Selector.GetHandle("loadAllFromPreferencesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMailDomains = "mailDomains";

	private static readonly IntPtr selMailDomainsHandle = Selector.GetHandle("mailDomains");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRoutingMethod = "routingMethod";

	private static readonly IntPtr selRoutingMethodHandle = Selector.GetHandle("routingMethod");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSafariDomains = "safariDomains";

	private static readonly IntPtr selSafariDomainsHandle = Selector.GetHandle("safariDomains");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAppRules_ = "setAppRules:";

	private static readonly IntPtr selSetAppRules_Handle = Selector.GetHandle("setAppRules:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCalendarDomains_ = "setCalendarDomains:";

	private static readonly IntPtr selSetCalendarDomains_Handle = Selector.GetHandle("setCalendarDomains:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetContactsDomains_ = "setContactsDomains:";

	private static readonly IntPtr selSetContactsDomains_Handle = Selector.GetHandle("setContactsDomains:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMailDomains_ = "setMailDomains:";

	private static readonly IntPtr selSetMailDomains_Handle = Selector.GetHandle("setMailDomains:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSafariDomains_ = "setSafariDomains:";

	private static readonly IntPtr selSetSafariDomains_Handle = Selector.GetHandle("setSafariDomains:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NETunnelProviderManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ErrorDomain;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	public virtual NEAppRule[] AppRules
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Export("appRules", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NEAppRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selAppRulesHandle));
			}
			return NSArray.ArrayFromHandle<NEAppRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAppRulesHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Export("setAppRules:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAppRules_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAppRules_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	public virtual string[] CalendarDomains
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Export("calendarDomains", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCalendarDomainsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCalendarDomainsHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Export("setCalendarDomains:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCalendarDomains_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCalendarDomains_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	public virtual string[] ContactsDomains
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Export("contactsDomains", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selContactsDomainsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContactsDomainsHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Export("setContactsDomains:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContactsDomains_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContactsDomains_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	public virtual string[] MailDomains
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Export("mailDomains", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMailDomainsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMailDomainsHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Export("setMailDomains:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMailDomains_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMailDomains_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NETunnelProviderRoutingMethod RoutingMethod
	{
		[Export("routingMethod")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NETunnelProviderRoutingMethod)Messaging.Int64_objc_msgSend(base.Handle, selRoutingMethodHandle);
			}
			return (NETunnelProviderRoutingMethod)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selRoutingMethodHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	public virtual string[] SafariDomains
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Export("safariDomains", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSafariDomainsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSafariDomainsHandle));
		}
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
		[Export("setSafariDomains:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSafariDomains_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSafariDomains_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[Field("NETunnelProviderErrorDomain", "NetworkExtension")]
	public new static NSString ErrorDomain
	{
		get
		{
			if (_ErrorDomain == null)
			{
				_ErrorDomain = Dlfcn.GetStringConstant(Libraries.NetworkExtension.Handle, "NETunnelProviderErrorDomain");
			}
			return _ErrorDomain;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NETunnelProviderManager()
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
	protected NETunnelProviderManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NETunnelProviderManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyAppRules")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NEAppRule[]? CopyAppRules()
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NEAppRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selCopyAppRulesHandle));
		}
		return NSArray.ArrayFromHandle<NEAppRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCopyAppRulesHandle));
	}

	[Export("forPerAppVPN")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NETunnelProviderManager CreatePerAppVpn()
	{
		return Runtime.GetNSObject<NETunnelProviderManager>(Messaging.IntPtr_objc_msgSend(class_ptr, selForPerAppVPNHandle));
	}

	[Export("loadAllFromPreferencesWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void LoadAllFromPreferences([BlockProxy(typeof(Trampolines.NIDActionArity2V73))] Action<NSArray, NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V73.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selLoadAllFromPreferencesWithCompletionHandler_Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NSArray> LoadAllFromPreferencesAsync()
	{
		TaskCompletionSource<NSArray> tcs = new TaskCompletionSource<NSArray>();
		LoadAllFromPreferences(delegate(NSArray arg1_, NSError arg2_)
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
