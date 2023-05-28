using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace SafariServices;

[Register("SFSafariWindow", true)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class SFSafariWindow : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClose = "close";

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetActiveTabWithCompletionHandler_ = "getActiveTabWithCompletionHandler:";

	private static readonly IntPtr selGetActiveTabWithCompletionHandler_Handle = Selector.GetHandle("getActiveTabWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetAllTabsWithCompletionHandler_ = "getAllTabsWithCompletionHandler:";

	private static readonly IntPtr selGetAllTabsWithCompletionHandler_Handle = Selector.GetHandle("getAllTabsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetToolbarItemWithCompletionHandler_ = "getToolbarItemWithCompletionHandler:";

	private static readonly IntPtr selGetToolbarItemWithCompletionHandler_Handle = Selector.GetHandle("getToolbarItemWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenTabWithURL_MakeActiveIfPossible_CompletionHandler_ = "openTabWithURL:makeActiveIfPossible:completionHandler:";

	private static readonly IntPtr selOpenTabWithURL_MakeActiveIfPossible_CompletionHandler_Handle = Selector.GetHandle("openTabWithURL:makeActiveIfPossible:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SFSafariWindow");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public SFSafariWindow(NSCoder coder)
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
	protected SFSafariWindow(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SFSafariWindow(IntPtr handle)
		: base(handle)
	{
	}

	[Export("close")]
	[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Close()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseHandle);
		}
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
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

	[Export("getActiveTabWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetActiveTab([BlockProxy(typeof(Trampolines.NIDActionArity1V78))] Action<SFSafariTab> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V78.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetActiveTabWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetActiveTabWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<SFSafariTab> GetActiveTabAsync()
	{
		TaskCompletionSource<SFSafariTab> tcs = new TaskCompletionSource<SFSafariTab>();
		GetActiveTab(delegate(SFSafariTab obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("getAllTabsWithCompletionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetAllTabs([BlockProxy(typeof(Trampolines.NIDActionArity1V83))] Action<SFSafariTab[]> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V83.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetAllTabsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetAllTabsWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<SFSafariTab[]> GetAllTabsAsync()
	{
		TaskCompletionSource<SFSafariTab[]> tcs = new TaskCompletionSource<SFSafariTab[]>();
		GetAllTabs(delegate(SFSafariTab[] obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("getToolbarItemWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GetToolbarItem([BlockProxy(typeof(Trampolines.NIDActionArity1V84))] Action<SFSafariToolbarItem> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V84.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selGetToolbarItemWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetToolbarItemWithCompletionHandler_Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<SFSafariToolbarItem> GetToolbarItemAsync()
	{
		TaskCompletionSource<SFSafariToolbarItem> tcs = new TaskCompletionSource<SFSafariToolbarItem>();
		GetToolbarItem(delegate(SFSafariToolbarItem obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("openTabWithURL:makeActiveIfPossible:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void OpenTab(NSUrl url, bool activateTab, [BlockProxy(typeof(Trampolines.NIDActionArity1V78))] Action<SFSafariTab>? completionHandler)
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V78.Handler, completionHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_bool_IntPtr(base.Handle, selOpenTabWithURL_MakeActiveIfPossible_CompletionHandler_Handle, url.Handle, activateTab, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_bool_IntPtr(base.SuperHandle, selOpenTabWithURL_MakeActiveIfPossible_CompletionHandler_Handle, url.Handle, activateTab, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<SFSafariTab> OpenTabAsync(NSUrl url, bool activateTab)
	{
		TaskCompletionSource<SFSafariTab> tcs = new TaskCompletionSource<SFSafariTab>();
		OpenTab(url, activateTab, delegate(SFSafariTab obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}
}
