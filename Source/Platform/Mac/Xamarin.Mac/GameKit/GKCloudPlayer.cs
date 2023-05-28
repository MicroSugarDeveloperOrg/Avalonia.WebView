using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace GameKit;

[Register("GKCloudPlayer", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "Use 'GKPlayer' instead.")]
[Deprecated(PlatformName.TvOS, 12, 0, PlatformArchitecture.None, "Use 'GKPlayer' instead.")]
[Deprecated(PlatformName.iOS, 12, 0, PlatformArchitecture.None, "Use 'GKPlayer' instead.")]
public class GKCloudPlayer : GKBasePlayer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetCurrentSignedInPlayerForContainer_CompletionHandler_ = "getCurrentSignedInPlayerForContainer:completionHandler:";

	private static readonly IntPtr selGetCurrentSignedInPlayerForContainer_CompletionHandler_Handle = Selector.GetHandle("getCurrentSignedInPlayerForContainer:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("GKCloudPlayer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public GKCloudPlayer()
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
	protected GKCloudPlayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal GKCloudPlayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("getCurrentSignedInPlayerForContainer:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void GetCurrentSignedInPlayer(string? containerName, [BlockProxy(typeof(Trampolines.NIDActionArity2V50))] Action<GKCloudPlayer, NSError> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		IntPtr arg = NSString.CreateNative(containerName);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V50.Handler, handler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selGetCurrentSignedInPlayerForContainer_CompletionHandler_Handle, arg, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}
}
