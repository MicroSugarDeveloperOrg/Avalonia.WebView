using Foundation;
using ObjCRuntime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Utiles;

namespace WebKit;

[Register("WKContentRuleListStore", true)]
public class WKContentRuleListStore : NSObject
{
    private const string selCompileContentRuleListForIdentifier_EncodedContentRuleList_CompletionHandler_ = "compileContentRuleListForIdentifier:encodedContentRuleList:completionHandler:";

    private static readonly IntPtr selCompileContentRuleListForIdentifier_EncodedContentRuleList_CompletionHandler_Handle = Selector.GetHandle("compileContentRuleListForIdentifier:encodedContentRuleList:completionHandler:");

    private const string selDefaultStore = "defaultStore";

    private static readonly IntPtr selDefaultStoreHandle = Selector.GetHandle("defaultStore");

    private const string selGetAvailableContentRuleListIdentifiers_ = "getAvailableContentRuleListIdentifiers:";

    private static readonly IntPtr selGetAvailableContentRuleListIdentifiers_Handle = Selector.GetHandle("getAvailableContentRuleListIdentifiers:");

    private const string selLookUpContentRuleListForIdentifier_CompletionHandler_ = "lookUpContentRuleListForIdentifier:completionHandler:";

    private static readonly IntPtr selLookUpContentRuleListForIdentifier_CompletionHandler_Handle = Selector.GetHandle("lookUpContentRuleListForIdentifier:completionHandler:");

    private const string selRemoveContentRuleListForIdentifier_CompletionHandler_ = "removeContentRuleListForIdentifier:completionHandler:";

    private static readonly IntPtr selRemoveContentRuleListForIdentifier_CompletionHandler_Handle = Selector.GetHandle("removeContentRuleListForIdentifier:completionHandler:");

    private const string selStoreWithURL_ = "storeWithURL:";

    private static readonly IntPtr selStoreWithURL_Handle = Selector.GetHandle("storeWithURL:");

    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKContentRuleListStore");

    public override IntPtr ClassHandle => class_ptr;

    public static WKContentRuleListStore DefaultStore
    {
        [Export("defaultStore")]
        get
        {
            return Runtime.GetNSObjectTx<WKContentRuleListStore>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultStoreHandle));
        }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKContentRuleListStore()
        : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKContentRuleListStore(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKContentRuleListStore(IntPtr handle)
        : base(handle)
    {
    }

    [Export("compileContentRuleListForIdentifier:encodedContentRuleList:completionHandler:")]
    public unsafe virtual void CompileContentRuleList(string identifier, string encodedContentRuleList, [BlockProxy(typeof(Trampolines.NIDActionArity2V84))] Action<WKContentRuleList, NSError> completionHandler)
    {
        if (identifier == null)
        {
            throw new ArgumentNullException("identifier");
        }
        if (encodedContentRuleList == null)
        {
            throw new ArgumentNullException("encodedContentRuleList");
        }
        if (completionHandler == null)
        {
            throw new ArgumentNullException("completionHandler");
        }
        IntPtr arg = NSString.CreateNative(identifier);
        IntPtr arg2 = NSString.CreateNative(encodedContentRuleList);
        BlockLiteral blockLiteral = default(BlockLiteral);
        BlockLiteral* ptr = &blockLiteral;
        blockLiteral.SetupBlock(Trampolines.SDActionArity2V84.Handler, completionHandler);
        if (base.IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCompileContentRuleListForIdentifier_EncodedContentRuleList_CompletionHandler_Handle, arg, arg2, (IntPtr)ptr);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCompileContentRuleListForIdentifier_EncodedContentRuleList_CompletionHandler_Handle, arg, arg2, (IntPtr)ptr);
        }
        NSString.ReleaseNative(arg);
        NSString.ReleaseNative(arg2);
        ptr->CleanupBlock();
    }

    public virtual Task<WKContentRuleList> CompileContentRuleListAsync(string identifier, string encodedContentRuleList)
    {
        TaskCompletionSource<WKContentRuleList> tcs = new TaskCompletionSource<WKContentRuleList>();
        CompileContentRuleList(identifier, encodedContentRuleList, delegate (WKContentRuleList arg1_, NSError arg2_)
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

    [Export("storeWithURL:")]
    public static WKContentRuleListStore FromUrl(NSUrl url)
    {
        if (url == null)
        {
            throw new ArgumentNullException("url");
        }
        return Runtime.GetNSObjectTx<WKContentRuleListStore>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selStoreWithURL_Handle, url.Handle));
    }

    [Export("getAvailableContentRuleListIdentifiers:")]
    public unsafe virtual void GetAvailableContentRuleListIdentifiers([BlockProxy(typeof(Trampolines.NIDActionArity1V1))] Action<string[]> callback)
    {
        if (callback == null)
        {
            throw new ArgumentNullException("callback");
        }
        BlockLiteral blockLiteral = default(BlockLiteral);
        BlockLiteral* ptr = &blockLiteral;
        blockLiteral.SetupBlock(Trampolines.SDActionArity1V1.Handler, callback);
        if (base.IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetAvailableContentRuleListIdentifiers_Handle, (IntPtr)ptr);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetAvailableContentRuleListIdentifiers_Handle, (IntPtr)ptr);
        }
        ptr->CleanupBlock();
    }

    public virtual Task<string[]> GetAvailableContentRuleListIdentifiersAsync()
    {
        TaskCompletionSource<string[]> tcs = new TaskCompletionSource<string[]>();
        GetAvailableContentRuleListIdentifiers(delegate (string[] obj_)
        {
            tcs.SetResult(obj_);
        });
        return tcs.Task;
    }

    [Export("lookUpContentRuleListForIdentifier:completionHandler:")]
    public unsafe virtual void LookUpContentRuleList(string identifier, [BlockProxy(typeof(Trampolines.NIDActionArity2V84))] Action<WKContentRuleList, NSError> completionHandler)
    {
        if (identifier == null)
        {
            throw new ArgumentNullException("identifier");
        }
        if (completionHandler == null)
        {
            throw new ArgumentNullException("completionHandler");
        }
        IntPtr arg = NSString.CreateNative(identifier);
        BlockLiteral blockLiteral = default(BlockLiteral);
        BlockLiteral* ptr = &blockLiteral;
        blockLiteral.SetupBlock(Trampolines.SDActionArity2V84.Handler, completionHandler);
        if (base.IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selLookUpContentRuleListForIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLookUpContentRuleListForIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr);
        }
        NSString.ReleaseNative(arg);
        ptr->CleanupBlock();
    }

    public virtual Task<WKContentRuleList> LookUpContentRuleListAsync(string identifier)
    {
        TaskCompletionSource<WKContentRuleList> tcs = new TaskCompletionSource<WKContentRuleList>();
        LookUpContentRuleList(identifier, delegate (WKContentRuleList arg1_, NSError arg2_)
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

    [Export("removeContentRuleListForIdentifier:completionHandler:")]
    public unsafe virtual void RemoveContentRuleList(string identifier, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
    {
        if (identifier == null)
        {
            throw new ArgumentNullException("identifier");
        }
        if (completionHandler == null)
        {
            throw new ArgumentNullException("completionHandler");
        }
        IntPtr arg = NSString.CreateNative(identifier);
        BlockLiteral blockLiteral = default(BlockLiteral);
        BlockLiteral* ptr = &blockLiteral;
        blockLiteral.SetupBlock(Trampolines.SDActionArity1V11.Handler, completionHandler);
        if (base.IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveContentRuleListForIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveContentRuleListForIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr);
        }
        NSString.ReleaseNative(arg);
        ptr->CleanupBlock();
    }

    public virtual Task RemoveContentRuleListAsync(string identifier)
    {
        TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
        RemoveContentRuleList(identifier, delegate (NSError obj_)
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