using System;
using System.ComponentModel;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSWorkspaceOpenConfiguration", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NSWorkspaceOpenConfiguration : NSObject, INSCopying, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selActivates = "activates";

	private static readonly IntPtr selActivatesHandle = Selector.GetHandle("activates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddsToRecentItems = "addsToRecentItems";

	private static readonly IntPtr selAddsToRecentItemsHandle = Selector.GetHandle("addsToRecentItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllowsRunningApplicationSubstitution = "allowsRunningApplicationSubstitution";

	private static readonly IntPtr selAllowsRunningApplicationSubstitutionHandle = Selector.GetHandle("allowsRunningApplicationSubstitution");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppleEvent = "appleEvent";

	private static readonly IntPtr selAppleEventHandle = Selector.GetHandle("appleEvent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArchitecture = "architecture";

	private static readonly IntPtr selArchitectureHandle = Selector.GetHandle("architecture");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selArguments = "arguments";

	private static readonly IntPtr selArgumentsHandle = Selector.GetHandle("arguments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConfiguration = "configuration";

	private static readonly IntPtr selConfigurationHandle = Selector.GetHandle("configuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreatesNewApplicationInstance = "createsNewApplicationInstance";

	private static readonly IntPtr selCreatesNewApplicationInstanceHandle = Selector.GetHandle("createsNewApplicationInstance");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnvironment = "environment";

	private static readonly IntPtr selEnvironmentHandle = Selector.GetHandle("environment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHides = "hides";

	private static readonly IntPtr selHidesHandle = Selector.GetHandle("hides");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHidesOthers = "hidesOthers";

	private static readonly IntPtr selHidesOthersHandle = Selector.GetHandle("hidesOthers");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsForPrinting = "isForPrinting";

	private static readonly IntPtr selIsForPrintingHandle = Selector.GetHandle("isForPrinting");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPromptsUserIfNeeded = "promptsUserIfNeeded";

	private static readonly IntPtr selPromptsUserIfNeededHandle = Selector.GetHandle("promptsUserIfNeeded");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequiresUniversalLinks = "requiresUniversalLinks";

	private static readonly IntPtr selRequiresUniversalLinksHandle = Selector.GetHandle("requiresUniversalLinks");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetActivates_ = "setActivates:";

	private static readonly IntPtr selSetActivates_Handle = Selector.GetHandle("setActivates:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAddsToRecentItems_ = "setAddsToRecentItems:";

	private static readonly IntPtr selSetAddsToRecentItems_Handle = Selector.GetHandle("setAddsToRecentItems:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAllowsRunningApplicationSubstitution_ = "setAllowsRunningApplicationSubstitution:";

	private static readonly IntPtr selSetAllowsRunningApplicationSubstitution_Handle = Selector.GetHandle("setAllowsRunningApplicationSubstitution:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAppleEvent_ = "setAppleEvent:";

	private static readonly IntPtr selSetAppleEvent_Handle = Selector.GetHandle("setAppleEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetArchitecture_ = "setArchitecture:";

	private static readonly IntPtr selSetArchitecture_Handle = Selector.GetHandle("setArchitecture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetArguments_ = "setArguments:";

	private static readonly IntPtr selSetArguments_Handle = Selector.GetHandle("setArguments:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCreatesNewApplicationInstance_ = "setCreatesNewApplicationInstance:";

	private static readonly IntPtr selSetCreatesNewApplicationInstance_Handle = Selector.GetHandle("setCreatesNewApplicationInstance:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnvironment_ = "setEnvironment:";

	private static readonly IntPtr selSetEnvironment_Handle = Selector.GetHandle("setEnvironment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetForPrinting_ = "setForPrinting:";

	private static readonly IntPtr selSetForPrinting_Handle = Selector.GetHandle("setForPrinting:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHides_ = "setHides:";

	private static readonly IntPtr selSetHides_Handle = Selector.GetHandle("setHides:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetHidesOthers_ = "setHidesOthers:";

	private static readonly IntPtr selSetHidesOthers_Handle = Selector.GetHandle("setHidesOthers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPromptsUserIfNeeded_ = "setPromptsUserIfNeeded:";

	private static readonly IntPtr selSetPromptsUserIfNeeded_Handle = Selector.GetHandle("setPromptsUserIfNeeded:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRequiresUniversalLinks_ = "setRequiresUniversalLinks:";

	private static readonly IntPtr selSetRequiresUniversalLinks_Handle = Selector.GetHandle("setRequiresUniversalLinks:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSWorkspaceOpenConfiguration");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Activates
	{
		[Export("activates")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selActivatesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selActivatesHandle);
		}
		[Export("setActivates:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetActivates_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetActivates_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AddsToRecentItems
	{
		[Export("addsToRecentItems")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAddsToRecentItemsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAddsToRecentItemsHandle);
		}
		[Export("setAddsToRecentItems:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAddsToRecentItems_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAddsToRecentItems_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AllowsRunningApplicationSubstitution
	{
		[Export("allowsRunningApplicationSubstitution")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsRunningApplicationSubstitutionHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsRunningApplicationSubstitutionHandle);
		}
		[Export("setAllowsRunningApplicationSubstitution:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsRunningApplicationSubstitution_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsRunningApplicationSubstitution_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAppleEventDescriptor? AppleEvent
	{
		[Export("appleEvent", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSend(base.Handle, selAppleEventHandle));
			}
			return Runtime.GetNSObject<NSAppleEventDescriptor>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAppleEventHandle));
		}
		[Export("setAppleEvent:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAppleEvent_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAppleEvent_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] Arguments
	{
		[Export("arguments", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selArgumentsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selArgumentsHandle));
		}
		[Export("setArguments:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromStrings(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetArguments_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetArguments_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CreatesNewApplicationInstance
	{
		[Export("createsNewApplicationInstance")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCreatesNewApplicationInstanceHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCreatesNewApplicationInstanceHandle);
		}
		[Export("setCreatesNewApplicationInstance:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetCreatesNewApplicationInstance_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetCreatesNewApplicationInstance_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, NSString> Environment
	{
		[Export("environment", ArgumentSemantic.Copy)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, NSString>>(Messaging.IntPtr_objc_msgSend(base.Handle, selEnvironmentHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, NSString>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEnvironmentHandle));
		}
		[Export("setEnvironment:", ArgumentSemantic.Copy)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetEnvironment_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetEnvironment_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ForPrinting
	{
		[Export("isForPrinting")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsForPrintingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsForPrintingHandle);
		}
		[Export("setForPrinting:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetForPrinting_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetForPrinting_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Hides
	{
		[Export("hides")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHidesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHidesHandle);
		}
		[Export("setHides:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHides_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHides_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HidesOthers
	{
		[Export("hidesOthers")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHidesOthersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHidesOthersHandle);
		}
		[Export("setHidesOthers:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetHidesOthers_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetHidesOthers_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CFBundle.Architecture LaunchArchitecture
	{
		get
		{
			return (CFBundle.Architecture)_LaunchArchitecture;
		}
		set
		{
			_LaunchArchitecture = (int)value;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PromptsUserIfNeeded
	{
		[Export("promptsUserIfNeeded")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selPromptsUserIfNeededHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selPromptsUserIfNeededHandle);
		}
		[Export("setPromptsUserIfNeeded:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPromptsUserIfNeeded_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPromptsUserIfNeeded_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool RequiresUniversalLinks
	{
		[Export("requiresUniversalLinks")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selRequiresUniversalLinksHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selRequiresUniversalLinksHandle);
		}
		[Export("setRequiresUniversalLinks:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetRequiresUniversalLinks_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetRequiresUniversalLinks_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual int _LaunchArchitecture
	{
		[Export("architecture")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selArchitectureHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selArchitectureHandle);
		}
		[Export("setArchitecture:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetArchitecture_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetArchitecture_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSWorkspaceOpenConfiguration(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSWorkspaceOpenConfiguration(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSApplication.EnsureUIThread();
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("configuration")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSWorkspaceOpenConfiguration Create()
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSWorkspaceOpenConfiguration>(Messaging.IntPtr_objc_msgSend(class_ptr, selConfigurationHandle));
	}
}
