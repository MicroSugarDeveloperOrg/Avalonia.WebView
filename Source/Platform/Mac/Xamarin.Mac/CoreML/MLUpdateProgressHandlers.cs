using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreML;

[Register("MLUpdateProgressHandlers", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class MLUpdateProgressHandlers : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitForEvents_ProgressHandler_CompletionHandler_ = "initForEvents:progressHandler:completionHandler:";

	private static readonly IntPtr selInitForEvents_ProgressHandler_CompletionHandler_Handle = Selector.GetHandle("initForEvents:progressHandler:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("MLUpdateProgressHandlers");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected MLUpdateProgressHandlers(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal MLUpdateProgressHandlers(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initForEvents:progressHandler:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe MLUpdateProgressHandlers(MLUpdateProgressEvent interestedEvents, [BlockProxy(typeof(Trampolines.NIDActionArity1V25))] Action<MLUpdateContext>? progressHandler, [BlockProxy(typeof(Trampolines.NIDActionArity1V25))] Action<MLUpdateContext> completionHandler)
		: base(NSObjectFlag.Empty)
	{
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral* ptr;
		if (progressHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V25.Handler, progressHandler);
		}
		BlockLiteral blockLiteral2 = default(BlockLiteral);
		BlockLiteral* ptr2 = &blockLiteral2;
		blockLiteral2.SetupBlockUnsafe(Trampolines.SDActionArity1V25.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr(base.Handle, selInitForEvents_ProgressHandler_CompletionHandler_Handle, (ulong)interestedEvents, (IntPtr)ptr, (IntPtr)ptr2), "initForEvents:progressHandler:completionHandler:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr(base.SuperHandle, selInitForEvents_ProgressHandler_CompletionHandler_Handle, (ulong)interestedEvents, (IntPtr)ptr, (IntPtr)ptr2), "initForEvents:progressHandler:completionHandler:");
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		ptr2->CleanupBlock();
	}
}
