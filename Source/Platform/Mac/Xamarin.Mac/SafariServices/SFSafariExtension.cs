using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace SafariServices;

[Register("SFSafariExtension", true)]
[Introduced(PlatformName.MacOSX, 10, 14, 4, PlatformArchitecture.All, null)]
public class SFSafariExtension : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetBaseURIWithCompletionHandler_ = "getBaseURIWithCompletionHandler:";

	private static readonly IntPtr selGetBaseURIWithCompletionHandler_Handle = Selector.GetHandle("getBaseURIWithCompletionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("SFSafariExtension");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected SFSafariExtension(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal SFSafariExtension(IntPtr handle)
		: base(handle)
	{
	}

	[Export("getBaseURIWithCompletionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void GetBaseUri([BlockProxy(typeof(Trampolines.NIDActionArity1V29))] Action<NSUrl> completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V29.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr(class_ptr, selGetBaseURIWithCompletionHandler_Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NSUrl> GetBaseUriAsync()
	{
		TaskCompletionSource<NSUrl> tcs = new TaskCompletionSource<NSUrl>();
		GetBaseUri(delegate(NSUrl obj_)
		{
			tcs.SetResult(obj_);
		});
		return tcs.Task;
	}
}
