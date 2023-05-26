using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WKUserContentController", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class WKUserContentController : NSObject, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddContentRuleList_ = "addContentRuleList:";

	private static readonly IntPtr selAddContentRuleList_Handle = Selector.GetHandle("addContentRuleList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddScriptMessageHandler_Name_ = "addScriptMessageHandler:name:";

	private static readonly IntPtr selAddScriptMessageHandler_Name_Handle = Selector.GetHandle("addScriptMessageHandler:name:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddUserScript_ = "addUserScript:";

	private static readonly IntPtr selAddUserScript_Handle = Selector.GetHandle("addUserScript:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllContentRuleLists = "removeAllContentRuleLists";

	private static readonly IntPtr selRemoveAllContentRuleListsHandle = Selector.GetHandle("removeAllContentRuleLists");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAllUserScripts = "removeAllUserScripts";

	private static readonly IntPtr selRemoveAllUserScriptsHandle = Selector.GetHandle("removeAllUserScripts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveContentRuleList_ = "removeContentRuleList:";

	private static readonly IntPtr selRemoveContentRuleList_Handle = Selector.GetHandle("removeContentRuleList:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveScriptMessageHandlerForName_ = "removeScriptMessageHandlerForName:";

	private static readonly IntPtr selRemoveScriptMessageHandlerForName_Handle = Selector.GetHandle("removeScriptMessageHandlerForName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserScripts = "userScripts";

	private static readonly IntPtr selUserScriptsHandle = Selector.GetHandle("userScripts");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKUserContentController");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual WKUserScript[] UserScripts
	{
		[Export("userScripts")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<WKUserScript>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserScriptsHandle));
			}
			return NSArray.ArrayFromHandle<WKUserScript>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserScriptsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WKUserContentController()
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
	public WKUserContentController(NSCoder coder)
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
	protected WKUserContentController(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WKUserContentController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addContentRuleList:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddContentRuleList(WKContentRuleList contentRuleList)
	{
		if (contentRuleList == null)
		{
			throw new ArgumentNullException("contentRuleList");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddContentRuleList_Handle, contentRuleList.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddContentRuleList_Handle, contentRuleList.Handle);
		}
	}

	[Export("addScriptMessageHandler:name:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selAddScriptMessageHandler_Name_Handle, scriptMessageHandler.Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAddScriptMessageHandler_Name_Handle, scriptMessageHandler.Handle, arg);
			}
			NSString.ReleaseNative(arg);
			return;
		}
		throw new ArgumentNullException("scriptMessageHandler");
	}

	[Export("addUserScript:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddUserScript(WKUserScript userScript)
	{
		if (userScript == null)
		{
			throw new ArgumentNullException("userScript");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddUserScript_Handle, userScript.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddUserScript_Handle, userScript.Handle);
		}
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

	[Export("removeAllContentRuleLists")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllContentRuleLists()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllContentRuleListsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllContentRuleListsHandle);
		}
	}

	[Export("removeAllUserScripts")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAllUserScripts()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveAllUserScriptsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveAllUserScriptsHandle);
		}
	}

	[Export("removeContentRuleList:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveContentRuleList(WKContentRuleList contentRuleList)
	{
		if (contentRuleList == null)
		{
			throw new ArgumentNullException("contentRuleList");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveContentRuleList_Handle, contentRuleList.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveContentRuleList_Handle, contentRuleList.Handle);
		}
	}

	[Export("removeScriptMessageHandlerForName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveScriptMessageHandler(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveScriptMessageHandlerForName_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveScriptMessageHandlerForName_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}
}
