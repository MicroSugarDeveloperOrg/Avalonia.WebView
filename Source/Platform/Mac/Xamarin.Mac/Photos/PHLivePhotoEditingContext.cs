using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreGraphics;
using CoreImage;
using CoreMedia;
using Foundation;
using ImageIO;
using ObjCRuntime;

namespace Photos;

[Register("PHLivePhotoEditingContext", true)]
[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
public class PHLivePhotoEditingContext : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAudioVolume = "audioVolume";

	private static readonly IntPtr selAudioVolumeHandle = Selector.GetHandle("audioVolume");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancel = "cancel";

	private static readonly IntPtr selCancelHandle = Selector.GetHandle("cancel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameProcessor = "frameProcessor";

	private static readonly IntPtr selFrameProcessorHandle = Selector.GetHandle("frameProcessor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFullSizeImage = "fullSizeImage";

	private static readonly IntPtr selFullSizeImageHandle = Selector.GetHandle("fullSizeImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithLivePhotoEditingInput_ = "initWithLivePhotoEditingInput:";

	private static readonly IntPtr selInitWithLivePhotoEditingInput_Handle = Selector.GetHandle("initWithLivePhotoEditingInput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrientation = "orientation";

	private static readonly IntPtr selOrientationHandle = Selector.GetHandle("orientation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPhotoTime = "photoTime";

	private static readonly IntPtr selPhotoTimeHandle = Selector.GetHandle("photoTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrepareLivePhotoForPlaybackWithTargetSize_Options_CompletionHandler_ = "prepareLivePhotoForPlaybackWithTargetSize:options:completionHandler:";

	private static readonly IntPtr selPrepareLivePhotoForPlaybackWithTargetSize_Options_CompletionHandler_Handle = Selector.GetHandle("prepareLivePhotoForPlaybackWithTargetSize:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSaveLivePhotoToOutput_Options_CompletionHandler_ = "saveLivePhotoToOutput:options:completionHandler:";

	private static readonly IntPtr selSaveLivePhotoToOutput_Options_CompletionHandler_Handle = Selector.GetHandle("saveLivePhotoToOutput:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAudioVolume_ = "setAudioVolume:";

	private static readonly IntPtr selSetAudioVolume_Handle = Selector.GetHandle("setAudioVolume:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameProcessor_ = "setFrameProcessor:";

	private static readonly IntPtr selSetFrameProcessor_Handle = Selector.GetHandle("setFrameProcessor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("PHLivePhotoEditingContext");

	[Obsolete("Use 'FrameProcessor2' instead.", true)]
	public virtual PHLivePhotoFrameProcessingBlock FrameProcessor { get; set; }

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual float AudioVolume
	{
		[Export("audioVolume")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selAudioVolumeHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selAudioVolumeHandle);
		}
		[Export("setAudioVolume:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetAudioVolume_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetAudioVolume_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime Duration
	{
		[Export("duration")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDurationHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual PHLivePhotoFrameProcessingBlock2? FrameProcessor2
	{
		[Export("frameProcessor", ArgumentSemantic.Copy)]
		[return: DelegateProxy(typeof(Trampolines.SDPHLivePhotoFrameProcessingBlock2))]
		get
		{
			IntPtr block = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFrameProcessorHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selFrameProcessorHandle));
			return Trampolines.NIDPHLivePhotoFrameProcessingBlock2.Create(block);
		}
		[Export("setFrameProcessor:", ArgumentSemantic.Copy)]
		[param: BlockProxy(typeof(Trampolines.NIDPHLivePhotoFrameProcessingBlock2))]
		set
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			BlockLiteral* ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDPHLivePhotoFrameProcessingBlock2.Handler, value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFrameProcessor_Handle, (IntPtr)ptr);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFrameProcessor_Handle, (IntPtr)ptr);
			}
			ptr->CleanupBlock();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage FullSizeImage
	{
		[Export("fullSizeImage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, selFullSizeImageHandle));
			}
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFullSizeImageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGImagePropertyOrientation Orientation
	{
		[Export("orientation")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CGImagePropertyOrientation)Messaging.int_objc_msgSend(base.Handle, selOrientationHandle);
			}
			return (CGImagePropertyOrientation)Messaging.int_objc_msgSendSuper(base.SuperHandle, selOrientationHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime PhotoTime
	{
		[Export("photoTime")]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selPhotoTimeHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPhotoTimeHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PHLivePhotoEditingContext(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHLivePhotoEditingContext(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithLivePhotoEditingInput:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PHLivePhotoEditingContext(PHContentEditingInput livePhotoInput)
		: base(NSObjectFlag.Empty)
	{
		if (livePhotoInput == null)
		{
			throw new ArgumentNullException("livePhotoInput");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithLivePhotoEditingInput_Handle, livePhotoInput.Handle), "initWithLivePhotoEditingInput:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithLivePhotoEditingInput_Handle, livePhotoInput.Handle), "initWithLivePhotoEditingInput:");
		}
	}

	[Export("cancel")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Cancel()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PrepareLivePhotoForPlayback(CGSize targetSize, [BlockProxy(typeof(Trampolines.NIDActionArity2V78))] Action<PHLivePhoto, NSError> handler)
	{
		_PrepareLivePhotoForPlayback(targetSize, null, handler);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<PHLivePhoto> PrepareLivePhotoForPlaybackAsync(CGSize targetSize)
	{
		TaskCompletionSource<PHLivePhoto> tcs = new TaskCompletionSource<PHLivePhoto>();
		PrepareLivePhotoForPlayback(targetSize, delegate(PHLivePhoto arg1_, NSError arg2_)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void PrepareLivePhotoForPlayback(CGSize targetSize, NSDictionary<NSString, NSObject>? options, [BlockProxy(typeof(Trampolines.NIDActionArity2V78))] Action<PHLivePhoto, NSError> handler)
	{
		_PrepareLivePhotoForPlayback(targetSize, options, handler);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<PHLivePhoto> PrepareLivePhotoForPlaybackAsync(CGSize targetSize, NSDictionary<NSString, NSObject>? options)
	{
		TaskCompletionSource<PHLivePhoto> tcs = new TaskCompletionSource<PHLivePhoto>();
		PrepareLivePhotoForPlayback(targetSize, options, delegate(PHLivePhoto arg1_, NSError arg2_)
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

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PrepareLivePhotoForPlayback(CGSize targetSize, PHLivePhotoEditingOption? options, [BlockProxy(typeof(Trampolines.NIDActionArity2V78))] Action<PHLivePhoto, NSError> handler)
	{
		_PrepareLivePhotoForPlayback(targetSize, options.GetDictionary(), handler);
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<PHLivePhoto> PrepareLivePhotoForPlaybackAsync(CGSize targetSize, PHLivePhotoEditingOption? options)
	{
		TaskCompletionSource<PHLivePhoto> tcs = new TaskCompletionSource<PHLivePhoto>();
		PrepareLivePhotoForPlayback(targetSize, options, delegate(PHLivePhoto arg1_, NSError arg2_)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SaveLivePhoto(PHContentEditingOutput output, [BlockProxy(typeof(Trampolines.NIDActionArity2V4))] Action<bool, NSError> handler)
	{
		_SaveLivePhoto(output, null, handler);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<Tuple<bool, NSError>> SaveLivePhotoAsync(PHContentEditingOutput output)
	{
		TaskCompletionSource<Tuple<bool, NSError>> tcs = new TaskCompletionSource<Tuple<bool, NSError>>();
		SaveLivePhoto(output, delegate(bool arg1_, NSError arg2_)
		{
			tcs.SetResult(new Tuple<bool, NSError>(arg1_, arg2_));
		});
		return tcs.Task;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SaveLivePhoto(PHContentEditingOutput output, NSDictionary<NSString, NSObject>? options, [BlockProxy(typeof(Trampolines.NIDActionArity2V4))] Action<bool, NSError> handler)
	{
		_SaveLivePhoto(output, options, handler);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<Tuple<bool, NSError>> SaveLivePhotoAsync(PHContentEditingOutput output, NSDictionary<NSString, NSObject>? options)
	{
		TaskCompletionSource<Tuple<bool, NSError>> tcs = new TaskCompletionSource<Tuple<bool, NSError>>();
		SaveLivePhoto(output, options, delegate(bool arg1_, NSError arg2_)
		{
			tcs.SetResult(new Tuple<bool, NSError>(arg1_, arg2_));
		});
		return tcs.Task;
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SaveLivePhoto(PHContentEditingOutput output, PHLivePhotoEditingOption? options, [BlockProxy(typeof(Trampolines.NIDActionArity2V4))] Action<bool, NSError> handler)
	{
		_SaveLivePhoto(output, options.GetDictionary(), handler);
	}

	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public Task<Tuple<bool, NSError>> SaveLivePhotoAsync(PHContentEditingOutput output, PHLivePhotoEditingOption? options)
	{
		TaskCompletionSource<Tuple<bool, NSError>> tcs = new TaskCompletionSource<Tuple<bool, NSError>>();
		SaveLivePhoto(output, options, delegate(bool arg1_, NSError arg2_)
		{
			tcs.SetResult(new Tuple<bool, NSError>(arg1_, arg2_));
		});
		return tcs.Task;
	}

	[Export("prepareLivePhotoForPlaybackWithTargetSize:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal unsafe virtual void _PrepareLivePhotoForPlayback(CGSize targetSize, NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDActionArity2V78))] Action<PHLivePhoto, NSError> handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V78.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize_IntPtr_IntPtr(base.Handle, selPrepareLivePhotoForPlaybackWithTargetSize_Options_CompletionHandler_Handle, targetSize, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize_IntPtr_IntPtr(base.SuperHandle, selPrepareLivePhotoForPlaybackWithTargetSize_Options_CompletionHandler_Handle, targetSize, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("saveLivePhotoToOutput:options:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal unsafe virtual void _SaveLivePhoto(PHContentEditingOutput output, NSDictionary? options, [BlockProxy(typeof(Trampolines.NIDActionArity2V4))] Action<bool, NSError> handler)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V4.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSaveLivePhotoToOutput_Options_CompletionHandler_Handle, output.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSaveLivePhotoToOutput_Options_CompletionHandler_Handle, output.Handle, options?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}
}
