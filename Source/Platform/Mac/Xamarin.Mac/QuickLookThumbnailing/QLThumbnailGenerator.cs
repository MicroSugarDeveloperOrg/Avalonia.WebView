using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace QuickLookThumbnailing;

[Register("QLThumbnailGenerator", true)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class QLThumbnailGenerator : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelRequest_ = "cancelRequest:";

	private static readonly IntPtr selCancelRequest_Handle = Selector.GetHandle("cancelRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateBestRepresentationForRequest_CompletionHandler_ = "generateBestRepresentationForRequest:completionHandler:";

	private static readonly IntPtr selGenerateBestRepresentationForRequest_CompletionHandler_Handle = Selector.GetHandle("generateBestRepresentationForRequest:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGenerateRepresentationsForRequest_UpdateHandler_ = "generateRepresentationsForRequest:updateHandler:";

	private static readonly IntPtr selGenerateRepresentationsForRequest_UpdateHandler_Handle = Selector.GetHandle("generateRepresentationsForRequest:updateHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveBestRepresentationForRequest_ToFileAtURL_WithContentType_CompletionHandler_ = "saveBestRepresentationForRequest:toFileAtURL:withContentType:completionHandler:";

	private static readonly IntPtr selSaveBestRepresentationForRequest_ToFileAtURL_WithContentType_CompletionHandler_Handle = Selector.GetHandle("saveBestRepresentationForRequest:toFileAtURL:withContentType:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedGenerator = "sharedGenerator";

	private static readonly IntPtr selSharedGeneratorHandle = Selector.GetHandle("sharedGenerator");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QLThumbnailGenerator");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static QLThumbnailGenerator SharedGenerator
	{
		[Export("sharedGenerator")]
		get
		{
			return Runtime.GetNSObject<QLThumbnailGenerator>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedGeneratorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QLThumbnailGenerator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QLThumbnailGenerator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancelRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelRequest(QLThumbnailGenerationRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selCancelRequest_Handle, request.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selCancelRequest_Handle, request.Handle);
		}
	}

	[Export("generateBestRepresentationForRequest:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GenerateBestRepresentation(QLThumbnailGenerationRequest request, [BlockProxy(typeof(Trampolines.NIDActionArity2V79))] Action<QLThumbnailRepresentation, NSError> completionHandler)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V79.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selGenerateBestRepresentationForRequest_CompletionHandler_Handle, request.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGenerateBestRepresentationForRequest_CompletionHandler_Handle, request.Handle, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<QLThumbnailRepresentation> GenerateBestRepresentationAsync(QLThumbnailGenerationRequest request)
	{
		TaskCompletionSource<QLThumbnailRepresentation> tcs = new TaskCompletionSource<QLThumbnailRepresentation>();
		GenerateBestRepresentation(request, delegate(QLThumbnailRepresentation arg1_, NSError arg2_)
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

	[Export("generateRepresentationsForRequest:updateHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void GenerateRepresentations(QLThumbnailGenerationRequest request, [BlockProxy(typeof(Trampolines.NIDActionArity3V4))] Action<QLThumbnailRepresentation, QLThumbnailRepresentationType, NSError>? updateHandler)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		BlockLiteral* ptr;
		if (updateHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity3V4.Handler, updateHandler);
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selGenerateRepresentationsForRequest_UpdateHandler_Handle, request.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGenerateRepresentationsForRequest_UpdateHandler_Handle, request.Handle, (IntPtr)ptr);
		}
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<QLThumbnailGeneratorResult> GenerateRepresentationsAsync(QLThumbnailGenerationRequest request)
	{
		TaskCompletionSource<QLThumbnailGeneratorResult> tcs = new TaskCompletionSource<QLThumbnailGeneratorResult>();
		GenerateRepresentations(request, delegate(QLThumbnailRepresentation arg1_, QLThumbnailRepresentationType arg2_, NSError arg3_)
		{
			if (arg3_ != null)
			{
				tcs.SetException(new NSErrorException(arg3_));
			}
			else
			{
				tcs.SetResult(new QLThumbnailGeneratorResult(arg1_, arg2_));
			}
		});
		return tcs.Task;
	}

	[Export("saveBestRepresentationForRequest:toFileAtURL:withContentType:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void SaveBestRepresentation(QLThumbnailGenerationRequest request, NSUrl fileUrl, string contentType, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		if (contentType == null)
		{
			throw new ArgumentNullException("contentType");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(contentType);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selSaveBestRepresentationForRequest_ToFileAtURL_WithContentType_CompletionHandler_Handle, request.Handle, fileUrl.Handle, arg, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSaveBestRepresentationForRequest_ToFileAtURL_WithContentType_CompletionHandler_Handle, request.Handle, fileUrl.Handle, arg, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task SaveBestRepresentationAsync(QLThumbnailGenerationRequest request, NSUrl fileUrl, string contentType)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		SaveBestRepresentation(request, fileUrl, contentType, delegate(NSError obj_)
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
