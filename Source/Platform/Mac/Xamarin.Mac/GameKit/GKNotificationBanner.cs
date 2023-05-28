using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKNotificationBanner", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class GKNotificationBanner : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowBannerWithTitle_Message_CompletionHandler_ = "showBannerWithTitle:message:completionHandler:";

	private static readonly IntPtr selShowBannerWithTitle_Message_CompletionHandler_Handle = Selector.GetHandle("showBannerWithTitle:message:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowBannerWithTitle_Message_Duration_CompletionHandler_ = "showBannerWithTitle:message:duration:completionHandler:";

	private static readonly IntPtr selShowBannerWithTitle_Message_Duration_CompletionHandler_Handle = Selector.GetHandle("showBannerWithTitle:message:duration:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKNotificationBanner");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKNotificationBanner()
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
	protected GKNotificationBanner(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKNotificationBanner(IntPtr handle)
		: base(handle)
	{
	}

	[Export("showBannerWithTitle:message:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void Show(string? title, string? message, [BlockProxy(typeof(Trampolines.NIDAction))] Action? onCompleted)
	{
		IntPtr arg = NSString.CreateNative(title);
		IntPtr arg2 = NSString.CreateNative(message);
		BlockLiteral* ptr;
		if (onCompleted == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, onCompleted);
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selShowBannerWithTitle_Message_CompletionHandler_Handle, arg, arg2, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task ShowAsync(string? title, string? message)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Show(title, message, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}

	[Export("showBannerWithTitle:message:duration:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void Show(string? title, string? message, double durationSeconds, [BlockProxy(typeof(Trampolines.NIDAction))] Action? completionHandler)
	{
		IntPtr arg = NSString.CreateNative(title);
		IntPtr arg2 = NSString.CreateNative(message);
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDAction.Handler, completionHandler);
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr_Double_IntPtr(class_ptr, selShowBannerWithTitle_Message_Duration_CompletionHandler_Handle, arg, arg2, durationSeconds, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task ShowAsync(string? title, string? message, double durationSeconds)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		Show(title, message, durationSeconds, delegate
		{
			tcs.SetResult(result: true);
		});
		return tcs.Task;
	}
}
