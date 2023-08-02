using Foundation;
using ObjCRuntime;
using System.ComponentModel;

namespace WebKit;

[Register("WKUserContentController", true)]
public class WKUserContentController : NSObject
{
    private const string selAddContentRuleList_ = "addContentRuleList:";
    private static readonly IntPtr selAddContentRuleList_Handle = Selector.GetHandle("addContentRuleList:");

    private const string selAddScriptMessageHandler_Name_ = "addScriptMessageHandler:name:";
    private static readonly IntPtr selAddScriptMessageHandler_Name_Handle = Selector.GetHandle("addScriptMessageHandler:name:");

    private const string selAddUserScript_ = "addUserScript:";
    private static readonly IntPtr selAddUserScript_Handle = Selector.GetHandle("addUserScript:");

    private const string selEncodeWithCoder_ = "encodeWithCoder:";
    private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

    private const string selInitWithCoder_ = "initWithCoder:";
    private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

    private const string selRemoveAllContentRuleLists = "removeAllContentRuleLists";
    private static readonly IntPtr selRemoveAllContentRuleListsHandle = Selector.GetHandle("removeAllContentRuleLists");

    private const string selRemoveAllUserScripts = "removeAllUserScripts";
    private static readonly IntPtr selRemoveAllUserScriptsHandle = Selector.GetHandle("removeAllUserScripts");

    private const string selRemoveContentRuleList_ = "removeContentRuleList:";
    private static readonly IntPtr selRemoveContentRuleList_Handle = Selector.GetHandle("removeContentRuleList:");

    private const string selRemoveScriptMessageHandlerForName_ = "removeScriptMessageHandlerForName:";
    private static readonly IntPtr selRemoveScriptMessageHandlerForName_Handle = Selector.GetHandle("removeScriptMessageHandlerForName:");

    private const string selUserScripts = "userScripts";
    private static readonly IntPtr selUserScriptsHandle = Selector.GetHandle("userScripts");

    private static readonly IntPtr class_ptr = Class.GetHandle("WKUserContentController");

    public override IntPtr ClassHandle => class_ptr;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public WKUserContentController()
    : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.Init);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("initWithCoder:")]
    public WKUserContentController(NSCoder coder)
        : base(NSObjectFlag.Empty)
    {
        InitializeHandle(Selector.InitWithCoder, coder);
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected WKUserContentController(NSObjectFlag t)
        : base(t)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal WKUserContentController(IntPtr handle)
        : base(handle)
    {
    }

    public virtual WKUserScript[] UserScripts
    {
        [Export("userScripts")]
        get
        {
            if (IsDirectBinding)
                return NSArray.ArrayFromHandle<WKUserScript>(Messaging.IntPtr_objc_msgSend(Handle, selUserScriptsHandle));

            return NSArray.ArrayFromHandle<WKUserScript>(Messaging.IntPtr_objc_msgSendSuper(SuperHandle, selUserScriptsHandle));
        }
    }

    [Export("addContentRuleList:")]
    public virtual void AddContentRuleList(WKContentRuleList contentRuleList)
    {
        if (contentRuleList == null)
        {
            throw new ArgumentNullException("contentRuleList");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selAddContentRuleList_Handle, contentRuleList.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selAddContentRuleList_Handle, contentRuleList.Handle);
        }
    }

    [Export("addScriptMessageHandler:name:")]
    public virtual void AddScriptMessageHandler(IWKScriptMessageHandler scriptMessageHandler, string name)
    {
        if (scriptMessageHandler != null)
        {
            if (!(scriptMessageHandler is NSObject))
            {
                throw new ArgumentException("The object passed of type " + scriptMessageHandler.GetType()?.ToString() + " does not derive from NSObject");
            }
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            IntPtr arg = NSString.CreateNative(name);
            if (IsDirectBinding)
            {
                Messaging.void_objc_msgSend_IntPtr_IntPtr(Handle, selAddScriptMessageHandler_Name_Handle, scriptMessageHandler.Handle, arg);
            }
            else
            {
                Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(SuperHandle, selAddScriptMessageHandler_Name_Handle, scriptMessageHandler.Handle, arg);
            }
            NSString.ReleaseNative(arg);
            return;
        }
        throw new ArgumentNullException("scriptMessageHandler");
    }

    [Export("addUserScript:")]
    public virtual void AddUserScript(WKUserScript userScript)
    {
        if (userScript == null)
        {
            throw new ArgumentNullException("userScript");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selAddUserScript_Handle, userScript.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selAddUserScript_Handle, userScript.Handle);
        }
    }

    [Export("removeAllContentRuleLists")]
    public virtual void RemoveAllContentRuleLists()
    {
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend(Handle, selRemoveAllContentRuleListsHandle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper(SuperHandle, selRemoveAllContentRuleListsHandle);
        }
    }

    [Export("removeAllUserScripts")]
    public virtual void RemoveAllUserScripts()
    {
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend(Handle, selRemoveAllUserScriptsHandle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper(SuperHandle, selRemoveAllUserScriptsHandle);
        }
    }

    [Export("removeContentRuleList:")]
    public virtual void RemoveContentRuleList(WKContentRuleList contentRuleList)
    {
        if (contentRuleList == null)
        {
            throw new ArgumentNullException("contentRuleList");
        }
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selRemoveContentRuleList_Handle, contentRuleList.Handle);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selRemoveContentRuleList_Handle, contentRuleList.Handle);
        }
    }

    [Export("removeScriptMessageHandlerForName:")]
    public virtual void RemoveScriptMessageHandler(string name)
    {
        if (name == null)
        {
            throw new ArgumentNullException("name");
        }
        IntPtr arg = NSString.CreateNative(name);
        if (IsDirectBinding)
        {
            Messaging.void_objc_msgSend_IntPtr(Handle, selRemoveScriptMessageHandlerForName_Handle, arg);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_IntPtr(SuperHandle, selRemoveScriptMessageHandlerForName_Handle, arg);
        }
        NSString.ReleaseNative(arg);
    }
}