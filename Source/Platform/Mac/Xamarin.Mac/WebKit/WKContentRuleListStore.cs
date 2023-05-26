using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("WKContentRuleListStore", true)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class WKContentRuleListStore : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompileContentRuleListForIdentifier_EncodedContentRuleList_CompletionHandler_ = "compileContentRuleListForIdentifier:encodedContentRuleList:completionHandler:";

	private static readonly IntPtr selCompileContentRuleListForIdentifier_EncodedContentRuleList_CompletionHandler_Handle = Selector.GetHandle("compileContentRuleListForIdentifier:encodedContentRuleList:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultStore = "defaultStore";

	private static readonly IntPtr selDefaultStoreHandle = Selector.GetHandle("defaultStore");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetAvailableContentRuleListIdentifiers_ = "getAvailableContentRuleListIdentifiers:";

	private static readonly IntPtr selGetAvailableContentRuleListIdentifiers_Handle = Selector.GetHandle("getAvailableContentRuleListIdentifiers:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLookUpContentRuleListForIdentifier_CompletionHandler_ = "lookUpContentRuleListForIdentifier:completionHandler:";

	private static readonly IntPtr selLookUpContentRuleListForIdentifier_CompletionHandler_Handle = Selector.GetHandle("lookUpContentRuleListForIdentifier:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveContentRuleListForIdentifier_CompletionHandler_ = "removeContentRuleListForIdentifier:completionHandler:";

	private static readonly IntPtr selRemoveContentRuleListForIdentifier_CompletionHandler_Handle = Selector.GetHandle("removeContentRuleListForIdentifier:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStoreWithURL_ = "storeWithURL:";

	private static readonly IntPtr selStoreWithURL_Handle = Selector.GetHandle("storeWithURL:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("WKContentRuleListStore");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static WKContentRuleListStore DefaultStore
	{
		[Export("defaultStore")]
		get
		{
			return Runtime.GetNSObject<WKContentRuleListStore>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultStoreHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public WKContentRuleListStore()
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
	protected WKContentRuleListStore(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal WKContentRuleListStore(IntPtr handle)
		: base(handle)
	{
	}

	[Export("compileContentRuleListForIdentifier:encodedContentRuleList:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V84.Handler, completionHandler);
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<WKContentRuleList> CompileContentRuleListAsync(string identifier, string encodedContentRuleList)
	{
		TaskCompletionSource<WKContentRuleList> tcs = new TaskCompletionSource<WKContentRuleList>();
		CompileContentRuleList(identifier, encodedContentRuleList, delegate(WKContentRuleList arg1_, NSError arg2_)
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
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static WKContentRuleListStore FromUrl(NSUrl url)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		return Runtime.GetNSObject<WKContentRuleListStore>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selStoreWithURL_Handle, url.Handle));
	}

	[Export("getAvailableContentRuleListIdentifiers:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetAvailableContentRuleListIdentifiers([BlockProxy(typeof(Trampolines.NIDActionArity1V1))] Action<string[]> callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V1.Handler, callback);
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<string[]> GetAvailableContentRuleListIdentifiersAsync()
	{
		TaskCompletionSource<string[]> tcs = new TaskCompletionSource<string[]>();
		GetAvailableContentRuleListIdentifiers(delegate(string[] obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("lookUpContentRuleListForIdentifier:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V84.Handler, completionHandler);
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<WKContentRuleList> LookUpContentRuleListAsync(string identifier)
	{
		TaskCompletionSource<WKContentRuleList> tcs = new TaskCompletionSource<WKContentRuleList>();
		LookUpContentRuleList(identifier, delegate(WKContentRuleList arg1_, NSError arg2_)
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
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task RemoveContentRuleListAsync(string identifier)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		RemoveContentRuleList(identifier, delegate(NSError obj_)
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
