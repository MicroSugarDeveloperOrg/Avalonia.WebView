using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace NetworkExtension;

[Register("NETransparentProxyManager", true)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class NETransparentProxyManager : NEVpnManager
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadAllFromPreferencesWithCompletionHandler_ = "loadAllFromPreferencesWithCompletionHandler:";

	private static readonly IntPtr selLoadAllFromPreferencesWithCompletionHandler_Handle = Selector.GetHandle("loadAllFromPreferencesWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NETransparentProxyManager");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NETransparentProxyManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NETransparentProxyManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("loadAllFromPreferencesWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void LoadAllFromPreferences([BlockProxy(typeof(Trampolines.NIDActionArity2V75))] Action<NETransparentProxyManager[], NSError> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V75.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selLoadAllFromPreferencesWithCompletionHandler_Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NETransparentProxyManager[]> LoadAllFromPreferencesAsync()
	{
		TaskCompletionSource<NETransparentProxyManager[]> tcs = new TaskCompletionSource<NETransparentProxyManager[]>();
		LoadAllFromPreferences(delegate(NETransparentProxyManager[] arg1_, NSError arg2_)
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
