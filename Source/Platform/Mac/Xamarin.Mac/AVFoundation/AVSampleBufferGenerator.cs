using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVSampleBufferGenerator", true)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
public class AVSampleBufferGenerator : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateSampleBufferForRequest_ = "createSampleBufferForRequest:";

	private static readonly IntPtr selCreateSampleBufferForRequest_Handle = Selector.GetHandle("createSampleBufferForRequest:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAsset_Timebase_ = "initWithAsset:timebase:";

	private static readonly IntPtr selInitWithAsset_Timebase_Handle = Selector.GetHandle("initWithAsset:timebase:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNotifyOfDataReadyForSampleBuffer_CompletionHandler_ = "notifyOfDataReadyForSampleBuffer:completionHandler:";

	private static readonly IntPtr selNotifyOfDataReadyForSampleBuffer_CompletionHandler_Handle = Selector.GetHandle("notifyOfDataReadyForSampleBuffer:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVSampleBufferGenerator");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVSampleBufferGenerator(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVSampleBufferGenerator(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAsset:timebase:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVSampleBufferGenerator(AVAsset asset, CMTimebase? timebase)
		: base(NSObjectFlag.Empty)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAsset_Timebase_Handle, asset.Handle, timebase?.Handle ?? IntPtr.Zero), "initWithAsset:timebase:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAsset_Timebase_Handle, asset.Handle, timebase?.Handle ?? IntPtr.Zero), "initWithAsset:timebase:");
		}
	}

	[Export("createSampleBufferForRequest:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual CMSampleBuffer? CreateSampleBuffer(AVSampleBufferRequest request)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateSampleBufferForRequest_Handle, request.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateSampleBufferForRequest_Handle, request.Handle));
		CMSampleBuffer result = null;
		if (intPtr != IntPtr.Zero)
		{
			result = new CMSampleBuffer(intPtr);
			Messaging.void_objc_msgSend(intPtr, Selector.GetHandle("release"));
		}
		return result;
	}

	[Export("notifyOfDataReadyForSampleBuffer:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void NotifyOfDataReady(CMSampleBuffer sbuf, [BlockProxy(typeof(Trampolines.NIDActionArity2V4))] Action<bool, NSError> completionHandler)
	{
		if (sbuf == null)
		{
			throw new ArgumentNullException("sbuf");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V4.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr(class_ptr, selNotifyOfDataReadyForSampleBuffer_CompletionHandler_Handle, sbuf.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<Tuple<bool, NSError>> NotifyOfDataReadyAsync(CMSampleBuffer sbuf)
	{
		TaskCompletionSource<Tuple<bool, NSError>> tcs = new TaskCompletionSource<Tuple<bool, NSError>>();
		NotifyOfDataReady(sbuf, delegate(bool arg1_, NSError arg2_)
		{
			tcs.SetResult(new Tuple<bool, NSError>(arg1_, arg2_));
		});
		return tcs.Task;
	}
}
