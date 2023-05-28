using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Register("PHAssetResourceManager", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
public class PHAssetResourceManager : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelDataRequest_ = "cancelDataRequest:";

	private static readonly IntPtr selCancelDataRequest_Handle = Selector.GetHandle("cancelDataRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultManager = "defaultManager";

	private static readonly IntPtr selDefaultManagerHandle = Selector.GetHandle("defaultManager");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestDataForAssetResource_Options_DataReceivedHandler_CompletionHandler_ = "requestDataForAssetResource:options:dataReceivedHandler:completionHandler:";

	private static readonly IntPtr selRequestDataForAssetResource_Options_DataReceivedHandler_CompletionHandler_Handle = Selector.GetHandle("requestDataForAssetResource:options:dataReceivedHandler:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteDataForAssetResource_ToFile_Options_CompletionHandler_ = "writeDataForAssetResource:toFile:options:completionHandler:";

	private static readonly IntPtr selWriteDataForAssetResource_ToFile_Options_CompletionHandler_Handle = Selector.GetHandle("writeDataForAssetResource:toFile:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHAssetResourceManager");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static PHAssetResourceManager DefaultManager
	{
		[Export("defaultManager")]
		get
		{
			return Runtime.GetNSObject<PHAssetResourceManager>(Messaging.IntPtr_objc_msgSend(class_ptr, selDefaultManagerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PHAssetResourceManager(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHAssetResourceManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("cancelDataRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelDataRequest(int requestID)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selCancelDataRequest_Handle, requestID);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selCancelDataRequest_Handle, requestID);
		}
	}

	[Export("requestDataForAssetResource:options:dataReceivedHandler:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual int RequestData(PHAssetResource forResource, PHAssetResourceRequestOptions? options, [BlockProxy(typeof(Trampolines.NIDActionArity1V28))] Action<NSData> handler, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (forResource == null)
		{
			throw new ArgumentNullException("forResource");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V28.Handler, handler);
		BlockLiteral blockLiteral2 = default(BlockLiteral);
		BlockLiteral* ptr2 = &blockLiteral2;
		blockLiteral2.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		int result = ((!base.IsDirectBinding) ? Messaging.int_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selRequestDataForAssetResource_Options_DataReceivedHandler_CompletionHandler_Handle, forResource.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr, (IntPtr)ptr2) : Messaging.int_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selRequestDataForAssetResource_Options_DataReceivedHandler_CompletionHandler_Handle, forResource.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr, (IntPtr)ptr2));
		ptr->CleanupBlock();
		ptr2->CleanupBlock();
		return result;
	}

	[Export("writeDataForAssetResource:toFile:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void WriteData(PHAssetResource forResource, NSUrl fileURL, PHAssetResourceRequestOptions? options, [BlockProxy(typeof(Trampolines.NIDActionArity1V11))] Action<NSError> completionHandler)
	{
		if (forResource == null)
		{
			throw new ArgumentNullException("forResource");
		}
		if (fileURL == null)
		{
			throw new ArgumentNullException("fileURL");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V11.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selWriteDataForAssetResource_ToFile_Options_CompletionHandler_Handle, forResource.Handle, fileURL.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selWriteDataForAssetResource_ToFile_Options_CompletionHandler_Handle, forResource.Handle, fileURL.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task WriteDataAsync(PHAssetResource forResource, NSUrl fileURL, PHAssetResourceRequestOptions? options)
	{
		TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>();
		WriteData(forResource, fileURL, options, delegate(NSError obj_)
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
