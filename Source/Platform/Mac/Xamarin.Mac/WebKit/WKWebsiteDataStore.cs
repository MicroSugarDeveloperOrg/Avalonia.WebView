using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WKWebsiteDataStore", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class WKWebsiteDataStore : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAllWebsiteDataTypes = "allWebsiteDataTypes";

	private static readonly IntPtr selAllWebsiteDataTypesHandle = Selector.GetHandle("allWebsiteDataTypes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultDataStore = "defaultDataStore";

	private static readonly IntPtr selDefaultDataStoreHandle = Selector.GetHandle("defaultDataStore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFetchDataRecordsOfTypes_CompletionHandler_ = "fetchDataRecordsOfTypes:completionHandler:";

	private static readonly IntPtr selFetchDataRecordsOfTypes_CompletionHandler_Handle = Selector.GetHandle("fetchDataRecordsOfTypes:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHttpCookieStore = "httpCookieStore";

	private static readonly IntPtr selHttpCookieStoreHandle = Selector.GetHandle("httpCookieStore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPersistent = "isPersistent";

	private static readonly IntPtr selIsPersistentHandle = Selector.GetHandle("isPersistent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNonPersistentDataStore = "nonPersistentDataStore";

	private static readonly IntPtr selNonPersistentDataStoreHandle = Selector.GetHandle("nonPersistentDataStore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveDataOfTypes_ForDataRecords_CompletionHandler_ = "removeDataOfTypes:forDataRecords:completionHandler:";

	private static readonly IntPtr selRemoveDataOfTypes_ForDataRecords_CompletionHandler_Handle = Selector.GetHandle("removeDataOfTypes:forDataRecords:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveDataOfTypes_ModifiedSince_CompletionHandler_ = "removeDataOfTypes:modifiedSince:completionHandler:";

	private static readonly IntPtr selRemoveDataOfTypes_ModifiedSince_CompletionHandler_Handle = Selector.GetHandle("removeDataOfTypes:modifiedSince:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKWebsiteDataStore");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSet<NSString> AllWebsiteDataTypes
	{
		[Export("allWebsiteDataTypes")]
		get
		{
			return Runtime.GetNSObject<NSSet<NSString>>(Messaging.IntPtr_objc_msgSend(class_ptr, selAllWebsiteDataTypesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static WKWebsiteDataStore DefaultDataStore
	{
		[Export("defaultDataStore")]
		get
		{
			return Runtime.GetNSObject<WKWebsiteDataStore>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultDataStoreHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual WKHttpCookieStore HttpCookieStore
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("httpCookieStore")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<WKHttpCookieStore>(Messaging.IntPtr_objc_msgSend(base.Handle, selHttpCookieStoreHandle));
			}
			return Runtime.GetNSObject<WKHttpCookieStore>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selHttpCookieStoreHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static WKWebsiteDataStore NonPersistentDataStore
	{
		[Export("nonPersistentDataStore")]
		get
		{
			return Runtime.GetNSObject<WKWebsiteDataStore>(Messaging.IntPtr_objc_msgSend(class_ptr, selNonPersistentDataStoreHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Persistent
	{
		[Export("isPersistent")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPersistentHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPersistentHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WKWebsiteDataStore()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public WKWebsiteDataStore(NSCoder coder)
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
	protected WKWebsiteDataStore(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WKWebsiteDataStore(IntPtr handle)
		: base(handle)
	{
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("fetchDataRecordsOfTypes:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void FetchDataRecordsOfTypes(NSSet<NSString> dataTypes, [BlockProxy(typeof(Trampolines.NIDActionArity1V96))] Action<NSArray> completionHandler)
	{
		if (dataTypes == null)
		{
			throw new ArgumentNullException("dataTypes");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V96.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selFetchDataRecordsOfTypes_CompletionHandler_Handle, dataTypes.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selFetchDataRecordsOfTypes_CompletionHandler_Handle, dataTypes.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSArray> FetchDataRecordsOfTypesAsync(NSSet<NSString> dataTypes)
	{
		TaskCompletionSource<NSArray> tcs = new TaskCompletionSource<NSArray>();
		FetchDataRecordsOfTypes(dataTypes, delegate(NSArray obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("removeDataOfTypes:forDataRecords:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RemoveDataOfTypes(NSSet<NSString> dataTypes, WKWebsiteDataRecord[] dataRecords, [BlockProxy(typeof(Trampolines.NIDAction))] Action completionHandler)
	{
		if (dataTypes == null)
		{
			throw new ArgumentNullException("dataTypes");
		}
		if (dataRecords == null)
		{
			throw new ArgumentNullException("dataRecords");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		NSArray nSArray = NSArray.FromNSObjects(dataRecords);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRemoveDataOfTypes_ForDataRecords_CompletionHandler_Handle, dataTypes.Handle, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRemoveDataOfTypes_ForDataRecords_CompletionHandler_Handle, dataTypes.Handle, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task RemoveDataOfTypesAsync(NSSet<NSString> dataTypes, WKWebsiteDataRecord[] dataRecords)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		RemoveDataOfTypes(dataTypes, dataRecords, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("removeDataOfTypes:modifiedSince:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void RemoveDataOfTypes(NSSet<NSString> websiteDataTypes, NSDate date, [BlockProxy(typeof(Trampolines.NIDAction))] Action completionHandler)
	{
		if (websiteDataTypes == null)
		{
			throw new ArgumentNullException("websiteDataTypes");
		}
		if (date == null)
		{
			throw new ArgumentNullException("date");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selRemoveDataOfTypes_ModifiedSince_CompletionHandler_Handle, websiteDataTypes.Handle, date.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRemoveDataOfTypes_ModifiedSince_CompletionHandler_Handle, websiteDataTypes.Handle, date.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task RemoveDataOfTypesAsync(NSSet<NSString> websiteDataTypes, NSDate date)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		RemoveDataOfTypes(websiteDataTypes, date, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}
}
