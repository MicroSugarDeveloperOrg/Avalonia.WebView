using System;
using System.ComponentModel;
using System.Threading.Tasks;
using ObjCRuntime;

namespace Foundation;

[Register("NSExtensionContext", true)]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class NSExtensionContext : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelRequestWithError_ = "cancelRequestWithError:";

	private static readonly IntPtr selCancelRequestWithError_Handle = Selector.GetHandle("cancelRequestWithError:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompleteRequestReturningItems_CompletionHandler_ = "completeRequestReturningItems:completionHandler:";

	private static readonly IntPtr selCompleteRequestReturningItems_CompletionHandler_Handle = Selector.GetHandle("completeRequestReturningItems:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputItems = "inputItems";

	private static readonly IntPtr selInputItemsHandle = Selector.GetHandle("inputItems");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenURL_CompletionHandler_ = "openURL:completionHandler:";

	private static readonly IntPtr selOpenURL_CompletionHandler_Handle = Selector.GetHandle("openURL:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSExtensionContext");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ItemsAndErrorsKey;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSExtensionItem[] InputItems
	{
		[Export("inputItems", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSExtensionItem>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputItemsHandle));
			}
			return NSArray.ArrayFromHandle<NSExtensionItem>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputItemsHandle));
		}
	}

	[Field("NSExtensionItemsAndErrorsKey", "Foundation")]
	public static NSString ItemsAndErrorsKey
	{
		get
		{
			if (_ItemsAndErrorsKey == null)
			{
				_ItemsAndErrorsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSExtensionItemsAndErrorsKey");
			}
			return _ItemsAndErrorsKey;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSExtensionContext()
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
	protected NSExtensionContext(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSExtensionContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancelRequestWithError:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelRequest(NSError error)
	{
		if (error == null)
		{
			throw new ArgumentNullException("error");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancelRequestWithError_Handle, error.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancelRequestWithError_Handle, error.Handle);
		}
	}

	[Export("completeRequestReturningItems:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void CompleteRequest(NSExtensionItem[] returningItems, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool>? completionHandler)
	{
		if (returningItems == null)
		{
			throw new ArgumentNullException("returningItems");
		}
		NSArray nSArray = NSArray.FromNSObjects(returningItems);
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V0.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selCompleteRequestReturningItems_CompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCompleteRequestReturningItems_CompletionHandler_Handle, nSArray.Handle, (IntPtr)ptr);
		}
		nSArray.Dispose();
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<bool> CompleteRequestAsync(NSExtensionItem[] returningItems)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		CompleteRequest(returningItems, delegate(bool obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("openURL:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void OpenUrl(NSUrl url, [BlockProxy(typeof(Trampolines.NIDActionArity1V0))] Action<bool>? completionHandler)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V0.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selOpenURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selOpenURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<bool> OpenUrlAsync(NSUrl url)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		OpenUrl(url, delegate(bool obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}
}
