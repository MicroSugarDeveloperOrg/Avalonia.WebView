using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetReaderOutput", true)]
public class AVAssetReaderOutput : NSObject
{
	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	private static readonly IntPtr selAlwaysCopiesSampleDataHandle = Selector.GetHandle("alwaysCopiesSampleData");

	private static readonly IntPtr selSetAlwaysCopiesSampleData_Handle = Selector.GetHandle("setAlwaysCopiesSampleData:");

	private static readonly IntPtr selCopyNextSampleBufferHandle = Selector.GetHandle("copyNextSampleBuffer");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAssetReaderOutput");

	public override IntPtr ClassHandle => class_ptr;

	public virtual string MediaType
	{
		[Export("mediaType")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle));
		}
	}

	public virtual bool AlwaysCopiesSampleData
	{
		[Export("alwaysCopiesSampleData")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAlwaysCopiesSampleDataHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAlwaysCopiesSampleDataHandle);
		}
		[Export("setAlwaysCopiesSampleData:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAlwaysCopiesSampleData_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAlwaysCopiesSampleData_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVAssetReaderOutput(NSCoder coder)
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
	public AVAssetReaderOutput(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAssetReaderOutput(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyNextSampleBuffer")]
	public virtual CMSampleBuffer CopyNextSampleBuffer()
	{
		if (IsDirectBinding)
		{
			return new CMSampleBuffer(Messaging.IntPtr_objc_msgSend(base.Handle, selCopyNextSampleBufferHandle));
		}
		return new CMSampleBuffer(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCopyNextSampleBufferHandle));
	}
}
