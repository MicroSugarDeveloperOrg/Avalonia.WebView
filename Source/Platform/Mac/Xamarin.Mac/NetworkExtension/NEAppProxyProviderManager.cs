using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NEAppProxyProviderManager", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NEAppProxyProviderManager : NETunnelProviderManager
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadAllFromPreferencesWithCompletionHandler_ = "loadAllFromPreferencesWithCompletionHandler:";

	private static readonly IntPtr selLoadAllFromPreferencesWithCompletionHandler_Handle = Selector.GetHandle("loadAllFromPreferencesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NEAppProxyProviderManager");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NEAppProxyProviderManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NEAppProxyProviderManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("loadAllFromPreferencesWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new unsafe static void LoadAllFromPreferences([BlockProxy(typeof(Trampolines.NIDActionArity2V73))] Action<NSArray, NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V73.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selLoadAllFromPreferencesWithCompletionHandler_Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static Task<NSArray> LoadAllFromPreferencesAsync()
	{
		TaskCompletionSource<NSArray> tcs = new TaskCompletionSource<NSArray>();
		LoadAllFromPreferences(delegate(NSArray arg1_, NSError arg2_)
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
}
