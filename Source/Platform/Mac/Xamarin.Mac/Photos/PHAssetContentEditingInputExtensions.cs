using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Photos;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public static class PHAssetContentEditingInputExtensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelContentEditingInputRequest_ = "cancelContentEditingInputRequest:";

	private static readonly IntPtr selCancelContentEditingInputRequest_Handle = Selector.GetHandle("cancelContentEditingInputRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestContentEditingInputWithOptions_CompletionHandler_ = "requestContentEditingInputWithOptions:completionHandler:";

	private static readonly IntPtr selRequestContentEditingInputWithOptions_CompletionHandler_Handle = Selector.GetHandle("requestContentEditingInputWithOptions:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("PHAsset");

	[Export("cancelContentEditingInputRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void CancelContentEditingInputRequest(this PHAsset This, nuint requestID)
	{
		Messaging.void_objc_msgSend_nuint(This.Handle, selCancelContentEditingInputRequest_Handle, requestID);
	}

	[Export("requestContentEditingInputWithOptions:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static nuint RequestContentEditingInput(this PHAsset This, PHContentEditingInputRequestOptions? options, [BlockProxy(typeof(Trampolines.NIDPHContentEditingHandler))] PHContentEditingHandler completionHandler)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDPHContentEditingHandler.Handler, completionHandler);
		nuint result = Messaging.nuint_objc_msgSend_IntPtr_IntPtr(This.Handle, selRequestContentEditingInputWithOptions_CompletionHandler_Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		ptr->CleanupBlock();
		return result;
	}
}
