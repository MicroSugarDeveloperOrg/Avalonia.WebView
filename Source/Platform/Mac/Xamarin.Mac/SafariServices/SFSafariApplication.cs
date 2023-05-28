using System;
using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace SafariServices;

[Register("SFSafariApplication", true)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class SFSafariApplication : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDispatchMessageWithName_ToExtensionWithIdentifier_UserInfo_CompletionHandler_ = "dispatchMessageWithName:toExtensionWithIdentifier:userInfo:completionHandler:";

	private static readonly IntPtr selDispatchMessageWithName_ToExtensionWithIdentifier_UserInfo_CompletionHandler_Handle = Selector.GetHandle("dispatchMessageWithName:toExtensionWithIdentifier:userInfo:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetActiveWindowWithCompletionHandler_ = "getActiveWindowWithCompletionHandler:";

	private static readonly IntPtr selGetActiveWindowWithCompletionHandler_Handle = Selector.GetHandle("getActiveWindowWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetAllWindowsWithCompletionHandler_ = "getAllWindowsWithCompletionHandler:";

	private static readonly IntPtr selGetAllWindowsWithCompletionHandler_Handle = Selector.GetHandle("getAllWindowsWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetHostApplicationWithCompletionHandler_ = "getHostApplicationWithCompletionHandler:";

	private static readonly IntPtr selGetHostApplicationWithCompletionHandler_Handle = Selector.GetHandle("getHostApplicationWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOpenWindowWithURL_CompletionHandler_ = "openWindowWithURL:completionHandler:";

	private static readonly IntPtr selOpenWindowWithURL_CompletionHandler_Handle = Selector.GetHandle("openWindowWithURL:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetToolbarItemsNeedUpdate = "setToolbarItemsNeedUpdate";

	private static readonly IntPtr selSetToolbarItemsNeedUpdateHandle = Selector.GetHandle("setToolbarItemsNeedUpdate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowPreferencesForExtensionWithIdentifier_CompletionHandler_ = "showPreferencesForExtensionWithIdentifier:completionHandler:";

	private static readonly IntPtr selShowPreferencesForExtensionWithIdentifier_CompletionHandler_Handle = Selector.GetHandle("showPreferencesForExtensionWithIdentifier:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SFSafariApplication");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SFSafariApplication(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SFSafariApplication(IntPtr handle)
		: base(handle)
	{
	}

	[Export("dispatchMessageWithName:toExtensionWithIdentifier:userInfo:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Unavailable to extensions.")]
	public unsafe static void DispatchMessage(string messageName, string identifier, NSDictionary<NSString, NSObject>? userInfo, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (messageName == null)
		{
			throw new ArgumentNullException("messageName");
		}
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(messageName);
		IntPtr arg2 = NSString.CreateNative(identifier);
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(class_ptr, selDispatchMessageWithName_ToExtensionWithIdentifier_UserInfo_CompletionHandler_Handle, arg, arg2, userInfo?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Unavailable to extensions.")]
	public static Task DispatchMessageAsync(string messageName, string identifier, NSDictionary<NSString, NSObject>? userInfo)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		DispatchMessage(messageName, identifier, userInfo, delegate(NSError obj_)
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

	[Export("getActiveWindowWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void GetActiveWindow([BlockProxy(typeof(Trampolines.NIDActionArity1V74))] Action<SFSafariWindow> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V74.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selGetActiveWindowWithCompletionHandler_Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<SFSafariWindow> GetActiveWindowAsync()
	{
		TaskCompletionSource<SFSafariWindow> tcs = new TaskCompletionSource<SFSafariWindow>();
		GetActiveWindow(delegate(SFSafariWindow obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("getAllWindowsWithCompletionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void GetAllWindows([BlockProxy(typeof(Trampolines.NIDActionArity1V75))] Action<SFSafariWindow[]> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V75.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selGetAllWindowsWithCompletionHandler_Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<SFSafariWindow[]> GetAllWindowsAsync()
	{
		TaskCompletionSource<SFSafariWindow[]> tcs = new TaskCompletionSource<SFSafariWindow[]>();
		GetAllWindows(delegate(SFSafariWindow[] obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("getHostApplicationWithCompletionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void GetHostApplication([BlockProxy(typeof(Trampolines.NIDActionArity1V76))] Action<NSRunningApplication> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V76.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selGetHostApplicationWithCompletionHandler_Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NSRunningApplication> GetHostApplicationAsync()
	{
		TaskCompletionSource<NSRunningApplication> tcs = new TaskCompletionSource<NSRunningApplication>();
		GetHostApplication(delegate(NSRunningApplication obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("openWindowWithURL:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void OpenWindow(NSUrl url, [BlockProxy(typeof(Trampolines.NIDActionArity1V74))] Action<SFSafariWindow>? completionHandler)
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
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V74.Handler, completionHandler);
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selOpenWindowWithURL_CompletionHandler_Handle, url.Handle, (IntPtr)ptr);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<SFSafariWindow> OpenWindowAsync(NSUrl url)
	{
		TaskCompletionSource<SFSafariWindow> tcs = new TaskCompletionSource<SFSafariWindow>();
		OpenWindow(url, delegate(SFSafariWindow obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}

	[Export("setToolbarItemsNeedUpdate")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetToolbarItemsNeedUpdate()
	{
		Messaging.void_objc_msgSend(class_ptr, selSetToolbarItemsNeedUpdateHandle);
	}

	[Export("showPreferencesForExtensionWithIdentifier:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ShowPreferencesForExtension(string identifier, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
	{
		if (identifier == null)
		{
			throw new ArgumentNullException("identifier");
		}
		IntPtr arg = NSString.CreateNative(identifier);
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selShowPreferencesForExtensionWithIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}
}
