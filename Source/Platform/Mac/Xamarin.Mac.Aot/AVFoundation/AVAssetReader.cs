using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetReader", true)]
public class AVAssetReader : NSObject
{
	private static readonly IntPtr selAssetHandle = Selector.GetHandle("asset");

	private static readonly IntPtr selStatusHandle = Selector.GetHandle("status");

	private static readonly IntPtr selErrorHandle = Selector.GetHandle("error");

	private static readonly IntPtr selTimeRangeHandle = Selector.GetHandle("timeRange");

	private static readonly IntPtr selSetTimeRange_Handle = Selector.GetHandle("setTimeRange:");

	private static readonly IntPtr selOutputsHandle = Selector.GetHandle("outputs");

	private static readonly IntPtr selAssetReaderWithAssetError_Handle = Selector.GetHandle("assetReaderWithAsset:error:");

	private static readonly IntPtr selInitWithAssetError_Handle = Selector.GetHandle("initWithAsset:error:");

	private static readonly IntPtr selCanAddOutput_Handle = Selector.GetHandle("canAddOutput:");

	private static readonly IntPtr selAddOutput_Handle = Selector.GetHandle("addOutput:");

	private static readonly IntPtr selStartReadingHandle = Selector.GetHandle("startReading");

	private static readonly IntPtr selCancelReadingHandle = Selector.GetHandle("cancelReading");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAssetReader");

	private object __mt_Asset_var;

	private object __mt_Error_var;

	private object __mt_Outputs_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVAsset Asset
	{
		[Export("asset")]
		get
		{
			return (AVAsset)(__mt_Asset_var = ((!IsDirectBinding) ? ((AVAsset)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetHandle))) : ((AVAsset)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetHandle)))));
		}
	}

	public virtual AVAssetReaderStatus Status
	{
		[Export("status")]
		get
		{
			if (IsDirectBinding)
			{
				return (AVAssetReaderStatus)Messaging.int_objc_msgSend(base.Handle, selStatusHandle);
			}
			return (AVAssetReaderStatus)Messaging.int_objc_msgSendSuper(base.SuperHandle, selStatusHandle);
		}
	}

	public virtual NSError Error
	{
		[Export("error")]
		get
		{
			return (NSError)(__mt_Error_var = ((!IsDirectBinding) ? ((NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selErrorHandle))) : ((NSError)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selErrorHandle)))));
		}
	}

	public virtual CMTimeRange TimeRange
	{
		[Export("timeRange")]
		get
		{
			CMTimeRange retval;
			if (IsDirectBinding)
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
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTimeRange(base.Handle, selSetTimeRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTimeRange(base.SuperHandle, selSetTimeRange_Handle, value);
			}
		}
	}

	public virtual AVAssetReaderOutput[] Outputs
	{
		[Export("outputs")]
		get
		{
			return (AVAssetReaderOutput[])(__mt_Outputs_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVAssetReaderOutput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputsHandle)) : NSArray.ArrayFromHandle<AVAssetReaderOutput>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputsHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVAssetReader(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAssetReader(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAssetReader(IntPtr handle)
		: base(handle)
	{
	}

	[Export("assetReaderWithAsset:error:")]
	public static AVAssetReader FromAsset(AVAsset asset, out NSError error)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		AVAssetReader result = (AVAssetReader)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selAssetReaderWithAssetError_Handle, asset.Handle, intPtr));
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("initWithAsset:error:")]
	public AVAssetReader(AVAsset asset, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAssetError_Handle, asset.Handle, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAssetError_Handle, asset.Handle, intPtr);
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		error = ((intPtr2 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("canAddOutput:")]
	public virtual bool CanAddOutput(AVAssetReaderOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selCanAddOutput_Handle, output.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selCanAddOutput_Handle, output.Handle);
	}

	[Export("addOutput:")]
	public virtual void AddOutput(AVAssetReaderOutput output)
	{
		if (output == null)
		{
			throw new ArgumentNullException("output");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddOutput_Handle, output.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddOutput_Handle, output.Handle);
		}
	}

	[Export("startReading")]
	public virtual bool StartReading()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selStartReadingHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selStartReadingHandle);
	}

	[Export("cancelReading")]
	public virtual void CancelReading()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCancelReadingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCancelReadingHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Asset_var = null;
			__mt_Error_var = null;
			__mt_Outputs_var = null;
		}
	}
}
