using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetReader", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVAssetReader : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddOutput_ = "addOutput:";

	private static readonly IntPtr selAddOutput_Handle = Selector.GetHandle("addOutput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAsset = "asset";

	private static readonly IntPtr selAssetHandle = Selector.GetHandle("asset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetReaderWithAsset_Error_ = "assetReaderWithAsset:error:";

	private static readonly IntPtr selAssetReaderWithAsset_Error_Handle = Selector.GetHandle("assetReaderWithAsset:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCanAddOutput_ = "canAddOutput:";

	private static readonly IntPtr selCanAddOutput_Handle = Selector.GetHandle("canAddOutput:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCancelReading = "cancelReading";

	private static readonly IntPtr selCancelReadingHandle = Selector.GetHandle("cancelReading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selError = "error";

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAsset_Error_ = "initWithAsset:error:";

	private static readonly IntPtr selInitWithAsset_Error_Handle = Selector.GetHandle("initWithAsset:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputs = "outputs";

	private static readonly IntPtr selOutputsHandle = Selector.GetHandle("outputs");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeRange_ = "setTimeRange:";

	private static readonly IntPtr selSetTimeRange_Handle = Selector.GetHandle("setTimeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStartReading = "startReading";

	private static readonly IntPtr selStartReadingHandle = Selector.GetHandle("startReading");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStatus = "status";

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeRange = "timeRange";

	private static readonly IntPtr selTimeRangeHandle = Selector.GetHandle("timeRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetReader");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAsset Asset
	{
		[Export("asset", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAsset>(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetHandle));
			}
			return Runtime.GetNSObject<AVAsset>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSError? Error
	{
		[Export("error")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle));
			}
			return Runtime.GetNSObject<NSError>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetReaderOutput[] Outputs
	{
		[Export("outputs")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVAssetReaderOutput>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputsHandle));
			}
			return NSArray.ArrayFromHandle<AVAssetReaderOutput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetReaderStatus Status
	{
		[Export("status")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVAssetReaderStatus)Messaging.Int64_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (AVAssetReaderStatus)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTimeRange TimeRange
	{
		[Export("timeRange")]
		get
		{
			CMTimeRange retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTimeRange_objc_msgSend_stret(out retval, base.Handle, selTimeRangeHandle);
			}
			else
			{
				Messaging.CMTimeRange_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTimeRangeHandle);
			}
			return retval;
		}
		[Export("setTimeRange:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTimeRange(base.Handle, selSetTimeRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTimeRange(base.SuperHandle, selSetTimeRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetReader(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetReader(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAsset:error:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetReader(AVAsset asset, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithAsset_Error_Handle, asset.Handle, ref arg), "initWithAsset:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithAsset_Error_Handle, asset.Handle, ref arg), "initWithAsset:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("addOutput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddOutput(AVAssetReaderOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddOutput_Handle, output.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddOutput_Handle, output.Handle);
		}
	}

	[Export("canAddOutput:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool CanAddOutput(AVAssetReaderOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanAddOutput_Handle, output.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanAddOutput_Handle, output.Handle);
	}

	[Export("cancelReading")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CancelReading()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelReadingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelReadingHandle);
		}
	}

	[Export("assetReaderWithAsset:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAssetReader? FromAsset(AVAsset asset, out NSError error)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		IntPtr arg = IntPtr.Zero;
		AVAssetReader nSObject = Runtime.GetNSObject<AVAssetReader>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selAssetReaderWithAsset_Error_Handle, asset.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("startReading")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool StartReading()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selStartReadingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selStartReadingHandle);
	}
}
