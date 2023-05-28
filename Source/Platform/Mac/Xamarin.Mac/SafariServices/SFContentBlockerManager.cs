using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace SafariServices;

[Register("SFContentBlockerManager", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacCatalyst, 13, 4, PlatformArchitecture.None, null)]
public class SFContentBlockerManager : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetStateOfContentBlockerWithIdentifier_CompletionHandler_ = "getStateOfContentBlockerWithIdentifier:completionHandler:";

	private static readonly IntPtr selGetStateOfContentBlockerWithIdentifier_CompletionHandler_Handle = Selector.GetHandle("getStateOfContentBlockerWithIdentifier:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReloadContentBlockerWithIdentifier_CompletionHandler_ = "reloadContentBlockerWithIdentifier:completionHandler:";

	private static readonly IntPtr selReloadContentBlockerWithIdentifier_CompletionHandler_Handle = Selector.GetHandle("reloadContentBlockerWithIdentifier:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SFContentBlockerManager");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public SFContentBlockerManager()
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
	protected SFContentBlockerManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SFContentBlockerManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("getStateOfContentBlockerWithIdentifier:completionHandler:")]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void GetStateOfContentBlocker(string identifier, [BlockProxy(typeof(Trampolines.NIDActionArity2V81))] Action<SFContentBlockerState, NSError> completionHandler)
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
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V81.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selGetStateOfContentBlockerWithIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<SFContentBlockerState> GetStateOfContentBlockerAsync(string identifier)
	{
		TaskCompletionSource<SFContentBlockerState> tcs = new TaskCompletionSource<SFContentBlockerState>();
		GetStateOfContentBlocker(identifier, delegate(SFContentBlockerState arg1_, NSError arg2_)
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

	[Export("reloadContentBlockerWithIdentifier:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void ReloadContentBlocker(string identifier, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError>? completionHandler)
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
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selReloadContentBlockerWithIdentifier_CompletionHandler_Handle, arg, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task ReloadContentBlockerAsync(string identifier)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		ReloadContentBlocker(identifier, delegate(NSError obj_)
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
