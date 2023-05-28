using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

[Register("SCNSceneSource", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
public class SCNSceneSource : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntriesPassingTest_ = "entriesPassingTest:";

	private static readonly IntPtr selEntriesPassingTest_Handle = Selector.GetHandle("entriesPassingTest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEntryWithIdentifier_WithClass_ = "entryWithIdentifier:withClass:";

	private static readonly IntPtr selEntryWithIdentifier_WithClass_Handle = Selector.GetHandle("entryWithIdentifier:withClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIdentifiersOfEntriesWithClass_ = "identifiersOfEntriesWithClass:";

	private static readonly IntPtr selIdentifiersOfEntriesWithClass_Handle = Selector.GetHandle("identifiersOfEntriesWithClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_Options_ = "initWithData:options:";

	private static readonly IntPtr selInitWithData_Options_Handle = Selector.GetHandle("initWithData:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_Options_ = "initWithURL:options:";

	private static readonly IntPtr selInitWithURL_Options_Handle = Selector.GetHandle("initWithURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPropertyForKey_ = "propertyForKey:";

	private static readonly IntPtr selPropertyForKey_Handle = Selector.GetHandle("propertyForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSceneSourceWithData_Options_ = "sceneSourceWithData:options:";

	private static readonly IntPtr selSceneSourceWithData_Options_Handle = Selector.GetHandle("sceneSourceWithData:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSceneSourceWithURL_Options_ = "sceneSourceWithURL:options:";

	private static readonly IntPtr selSceneSourceWithURL_Options_Handle = Selector.GetHandle("sceneSourceWithURL:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSceneWithOptions_Error_ = "sceneWithOptions:error:";

	private static readonly IntPtr selSceneWithOptions_Error_Handle = Selector.GetHandle("sceneWithOptions:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSceneWithOptions_StatusHandler_ = "sceneWithOptions:statusHandler:";

	private static readonly IntPtr selSceneWithOptions_StatusHandler_Handle = Selector.GetHandle("sceneWithOptions:statusHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUrl = "url";

	private static readonly IntPtr selUrlHandle = Selector.GetHandle("url");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SCNSceneSource");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData Data
	{
		[Export("data")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl Url
	{
		[Export("url")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend(base.Handle, selUrlHandle));
			}
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUrlHandle));
		}
	}

	public NSObject GetEntryWithIdentifier<T>(string uid)
	{
		return GetEntryWithIdentifier(uid, new Class(typeof(T)));
	}

	public string[] GetIdentifiersOfEntries<T>()
	{
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("identifiersOfEntriesWithClass:"), new Class(typeof(T)).Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SCNSceneSource(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SCNSceneSource(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithURL:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNSceneSource(NSUrl url, NSDictionary? options)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithURL_Options_Handle, url.Handle, options?.Handle ?? IntPtr.Zero), "initWithURL:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithURL_Options_Handle, url.Handle, options?.Handle ?? IntPtr.Zero), "initWithURL:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNSceneSource(NSUrl url, SCNSceneLoadingOptions options)
		: this(url, options.GetDictionary())
	{
	}

	[Export("initWithData:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNSceneSource(NSData data, NSDictionary? options)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithData_Options_Handle, data.Handle, options?.Handle ?? IntPtr.Zero), "initWithData:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithData_Options_Handle, data.Handle, options?.Handle ?? IntPtr.Zero), "initWithData:options:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNSceneSource(NSData data, SCNSceneLoadingOptions options)
		: this(data, options.GetDictionary())
	{
	}

	[Export("entriesPassingTest:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual NSObject[] EntriesPassingTest([BlockProxy(typeof(Trampolines.NIDSCNSceneSourceFilter))] SCNSceneSourceFilter predicate)
	{
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNSceneSourceFilter.Handler, predicate);
		NSObject[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selEntriesPassingTest_Handle, (IntPtr)ptr)) : NSArray.ArrayFromHandle<NSObject>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selEntriesPassingTest_Handle, (IntPtr)ptr)));
		ptr->CleanupBlock();
		return result;
	}

	[Export("sceneSourceWithData:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNSceneSource FromData(NSData data, NSDictionary? options)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject<SCNSceneSource>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selSceneSourceWithData_Options_Handle, data.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNSceneSource FromData(NSData data, SCNSceneLoadingOptions options)
	{
		return FromData(data, options.GetDictionary());
	}

	[Export("sceneSourceWithURL:options:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static SCNSceneSource FromUrl(NSUrl url, NSDictionary? options)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<SCNSceneSource>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selSceneSourceWithURL_Options_Handle, url.Handle, options?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNSceneSource FromUrl(NSUrl url, SCNSceneLoadingOptions options)
	{
		return FromUrl(url, options.GetDictionary());
	}

	[Export("entryWithIdentifier:withClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetEntryWithIdentifier(string uid, Class entryClass)
	{
		if (uid == null)
		{
			throw new ArgumentNullException("uid");
		}
		if (entryClass == null)
		{
			throw new ArgumentNullException("entryClass");
		}
		IntPtr arg = NSString.CreateNative(uid);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selEntryWithIdentifier_WithClass_Handle, arg, entryClass.Handle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selEntryWithIdentifier_WithClass_Handle, arg, entryClass.Handle)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("identifiersOfEntriesWithClass:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetIdentifiersOfEntries(Class entryClass)
	{
		if (entryClass == null)
		{
			throw new ArgumentNullException("entryClass");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selIdentifiersOfEntriesWithClass_Handle, entryClass.Handle));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selIdentifiersOfEntriesWithClass_Handle, entryClass.Handle));
	}

	[Export("propertyForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetProperty(NSString key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPropertyForKey_Handle, key.Handle));
		}
		return Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPropertyForKey_Handle, key.Handle));
	}

	[Export("sceneWithOptions:statusHandler:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual SCNScene SceneFromOptions(NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDSCNSceneSourceStatusHandler))] SCNSceneSourceStatusHandler statusHandler)
	{
		if (statusHandler == null)
		{
			throw new ArgumentNullException("statusHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDSCNSceneSourceStatusHandler.Handler, statusHandler);
		SCNScene result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SCNScene>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSceneWithOptions_StatusHandler_Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr)) : Runtime.GetNSObject<SCNScene>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selSceneWithOptions_StatusHandler_Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr)));
		ptr->CleanupBlock();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNScene SceneFromOptions(SCNSceneLoadingOptions options, [BlockProxy(typeof(Trampolines.NIDSCNSceneSourceStatusHandler))] SCNSceneSourceStatusHandler statusHandler)
	{
		return SceneFromOptions(options.GetDictionary(), statusHandler);
	}

	[Export("sceneWithOptions:error:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual SCNScene SceneWithOption(NSDictionary? options, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		SCNScene result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<SCNScene>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selSceneWithOptions_Error_Handle, options?.Handle ?? IntPtr.Zero, ref arg)) : Runtime.GetNSObject<SCNScene>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selSceneWithOptions_Error_Handle, options?.Handle ?? IntPtr.Zero, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public SCNScene SceneWithOption(SCNSceneLoadingOptions options, out NSError error)
	{
		return SceneWithOption(options.GetDictionary(), out error);
	}
}
