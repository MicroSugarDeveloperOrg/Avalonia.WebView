using Foundation;
using ObjCRuntime;
using System.ComponentModel;
using Xamarin.Utiles;

namespace WebKit;

[Register("WKWebsiteDataStore", true)]
public class WKWebsiteDataStore : NSObject
{
    private const string selAllWebsiteDataTypes = "allWebsiteDataTypes";
    private static readonly IntPtr selAllWebsiteDataTypesHandle = Selector.GetHandle("allWebsiteDataTypes");

    private const string selDefaultDataStore = "defaultDataStore";
    private static readonly IntPtr selDefaultDataStoreHandle = Selector.GetHandle("defaultDataStore");

    private const string selEncodeWithCoder_ = "encodeWithCoder:";
    private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

    private const string selFetchDataRecordsOfTypes_CompletionHandler_ = "fetchDataRecordsOfTypes:completionHandler:";
    private static readonly IntPtr selFetchDataRecordsOfTypes_CompletionHandler_Handle = Selector.GetHandle("fetchDataRecordsOfTypes:completionHandler:");

    private const string selHttpCookieStore = "httpCookieStore";
    private static readonly IntPtr selHttpCookieStoreHandle = Selector.GetHandle("httpCookieStore");

    private const string selInitWithCoder_ = "initWithCoder:";
    private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

    private const string selIsPersistent = "isPersistent";
    private static readonly IntPtr selIsPersistentHandle = Selector.GetHandle("isPersistent");

    private const string selNonPersistentDataStore = "nonPersistentDataStore";
    private static readonly IntPtr selNonPersistentDataStoreHandle = Selector.GetHandle("nonPersistentDataStore");

    private const string selRemoveDataOfTypes_ForDataRecords_CompletionHandler_ = "removeDataOfTypes:forDataRecords:completionHandler:";
    private static readonly IntPtr selRemoveDataOfTypes_ForDataRecords_CompletionHandler_Handle = Selector.GetHandle("removeDataOfTypes:forDataRecords:completionHandler:");

    private const string selRemoveDataOfTypes_ModifiedSince_CompletionHandler_ = "removeDataOfTypes:modifiedSince:completionHandler:";
    private static readonly IntPtr selRemoveDataOfTypes_ModifiedSince_CompletionHandler_Handle = Selector.GetHandle("removeDataOfTypes:modifiedSince:completionHandler:");

    private static readonly IntPtr class_ptr = Class.GetHandle("WKWebsiteDataStore");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKWebsiteDataStore()
       : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("initWithCoder:")]
    public WKWebsiteDataStore(NSCoder coder)
        : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.InitWithCoder, coder);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKWebsiteDataStore(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKWebsiteDataStore(IntPtr handle)
        : base(handle)
    {
    }


    public static NSSet<NSString> AllWebsiteDataTypes
    {
        [Export("allWebsiteDataTypes")]
        get
        {
            return Runtime.GetNSObjectTx<NSSet<NSString>>(Messaging.IntPtr_objc_msgSend(class_ptr, selAllWebsiteDataTypesHandle));
        }
    }

    public static WKWebsiteDataStore DefaultDataStore
    {
        [Export("defaultDataStore")]
        get
        {
            return Runtime.GetNSObjectTx<WKWebsiteDataStore>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultDataStoreHandle));
        }
    }

    public virtual WKHttpCookieStore HttpCookieStore
    {
        [Export("httpCookieStore")]
        get
        {
            if (IsDirectBinding)
            {
                return Runtime.GetNSObjectTx<WKHttpCookieStore>(Messaging.IntPtr_objc_msgSend(Handle, selHttpCookieStoreHandle));
            }
            return Runtime.GetNSObjectTx<WKHttpCookieStore>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selHttpCookieStoreHandle));
        }
    }

    public static WKWebsiteDataStore NonPersistentDataStore
    {
        [Export("nonPersistentDataStore")]
        get
        {
            return Runtime.GetNSObjectTx<WKWebsiteDataStore>(Messaging.IntPtr_objc_msgSend(class_ptr, selNonPersistentDataStoreHandle));
        }
    }

    public virtual bool Persistent
    {
        [Export("isPersistent")]
        get
        {
            if (IsDirectBinding)
                return Messaging.bool_objc_msgSend(Handle, selIsPersistentHandle);

            return Messaging.bool_objc_msgSendSuper(SuperHandle, selIsPersistentHandle);
        }
    }
 
    [Export("fetchDataRecordsOfTypes:completionHandler:")]
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
        BlockLiteral blockLiteral = default;
        BlockLiteral* ptr = &blockLiteral;
        blockLiteral.SetupBlock(Trampolines.SDActionArity1V96.Handler, completionHandler);
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selFetchDataRecordsOfTypes_CompletionHandler_Handle, dataTypes.Handle, (IntPtr)ptr);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selFetchDataRecordsOfTypes_CompletionHandler_Handle, dataTypes.Handle, (IntPtr)ptr);
        }
        ptr->CleanupBlock();
    }

    public virtual Task<NSArray> FetchDataRecordsOfTypesAsync(NSSet<NSString> dataTypes)
    {
        TaskCompletionSource<NSArray> tcs = new TaskCompletionSource<NSArray>();
        FetchDataRecordsOfTypes(dataTypes, delegate (NSArray obj_)
        {
            tcs.SetResult(obj_);
        });
        return tcs.Task;
    }

    [Export("removeDataOfTypes:forDataRecords:completionHandler:")]
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
        blockLiteral.SetupBlock(Trampolines.SDAction.Handler, completionHandler);
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(Handle, selRemoveDataOfTypes_ForDataRecords_CompletionHandler_Handle, dataTypes.Handle, nSArray.Handle, (IntPtr)ptr);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(SuperHandle, selRemoveDataOfTypes_ForDataRecords_CompletionHandler_Handle, dataTypes.Handle, nSArray.Handle, (IntPtr)ptr);
        }
        nSArray.Dispose();
        ptr->CleanupBlock();
    }

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
        blockLiteral.SetupBlock(Trampolines.SDAction.Handler, completionHandler);
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(Handle, selRemoveDataOfTypes_ModifiedSince_CompletionHandler_Handle, websiteDataTypes.Handle, date.Handle, (IntPtr)ptr);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(SuperHandle, selRemoveDataOfTypes_ModifiedSince_CompletionHandler_Handle, websiteDataTypes.Handle, date.Handle, (IntPtr)ptr);
        }
        ptr->CleanupBlock();
    }

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
