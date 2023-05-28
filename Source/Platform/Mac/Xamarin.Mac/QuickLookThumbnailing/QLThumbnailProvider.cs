using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QuickLookThumbnailing;

[Register("QLThumbnailProvider", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
public class QLThumbnailProvider : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProvideThumbnailForFileRequest_CompletionHandler_ = "provideThumbnailForFileRequest:completionHandler:";

	private static readonly IntPtr selProvideThumbnailForFileRequest_CompletionHandler_Handle = Selector.GetHandle("provideThumbnailForFileRequest:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QLThumbnailProvider");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QLThumbnailProvider()
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
	protected QLThumbnailProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QLThumbnailProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("provideThumbnailForFileRequest:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ProvideThumbnail(QLFileThumbnailRequest request, [BlockProxy(typeof(Trampolines.NIDActionArity2V80))] Action<QLThumbnailReply, NSError> handler)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V80.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selProvideThumbnailForFileRequest_CompletionHandler_Handle, request.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selProvideThumbnailForFileRequest_CompletionHandler_Handle, request.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}
}
