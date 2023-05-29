using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTSampleBuffer", true)]
public class QTSampleBuffer : NSObject
{
	private static readonly IntPtr selBytesForAllSamplesHandle = Selector.GetHandle("bytesForAllSamples");

	private static readonly IntPtr selLengthForAllSamplesHandle = Selector.GetHandle("lengthForAllSamples");

	private static readonly IntPtr selFormatDescriptionHandle = Selector.GetHandle("formatDescription");

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	private static readonly IntPtr selDecodeTimeHandle = Selector.GetHandle("decodeTime");

	private static readonly IntPtr selPresentationTimeHandle = Selector.GetHandle("presentationTime");

	private static readonly IntPtr selNumberOfSamplesHandle = Selector.GetHandle("numberOfSamples");

	private static readonly IntPtr selSampleBufferAttributesHandle = Selector.GetHandle("sampleBufferAttributes");

	private static readonly IntPtr selSampleUseCountHandle = Selector.GetHandle("sampleUseCount");

	private static readonly IntPtr selAttributeForKey_Handle = Selector.GetHandle("attributeForKey:");

	private static readonly IntPtr selIncrementSampleUseCountHandle = Selector.GetHandle("incrementSampleUseCount");

	private static readonly IntPtr selDecrementSampleUseCountHandle = Selector.GetHandle("decrementSampleUseCount");

	private static readonly IntPtr class_ptr = Class.GetHandle("QTSampleBuffer");

	private object __mt_FormatDescription_var;

	private object __mt_SampleBufferAttributes_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual IntPtr BytesForAllSamples
	{
		[Export("bytesForAllSamples")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selBytesForAllSamplesHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBytesForAllSamplesHandle);
		}
	}

	public virtual uint LengthForAllSamples
	{
		[Export("lengthForAllSamples")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selLengthForAllSamplesHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selLengthForAllSamplesHandle);
		}
	}

	public virtual QTFormatDescription FormatDescription
	{
		[Export("formatDescription")]
		get
		{
			return (QTFormatDescription)(__mt_FormatDescription_var = ((!IsDirectBinding) ? ((QTFormatDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatDescriptionHandle))) : ((QTFormatDescription)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatDescriptionHandle)))));
		}
	}

	public virtual QTTime Duration
	{
		[Export("duration")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.QTTime_objc_msgSend(base.Handle, selDurationHandle);
			}
			return Messaging.QTTime_objc_msgSendSuper(base.SuperHandle, selDurationHandle);
		}
	}

	public virtual QTTime DecodeTime
	{
		[Export("decodeTime")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.QTTime_objc_msgSend(base.Handle, selDecodeTimeHandle);
			}
			return Messaging.QTTime_objc_msgSendSuper(base.SuperHandle, selDecodeTimeHandle);
		}
	}

	public virtual QTTime PresentationTime
	{
		[Export("presentationTime")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.QTTime_objc_msgSend(base.Handle, selPresentationTimeHandle);
			}
			return Messaging.QTTime_objc_msgSendSuper(base.SuperHandle, selPresentationTimeHandle);
		}
	}

	public virtual int SampleCount
	{
		[Export("numberOfSamples")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selNumberOfSamplesHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selNumberOfSamplesHandle);
		}
	}

	public virtual NSDictionary SampleBufferAttributes
	{
		[Export("sampleBufferAttributes")]
		get
		{
			return (NSDictionary)(__mt_SampleBufferAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSampleBufferAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSampleBufferAttributesHandle)))));
		}
	}

	public virtual int SampleUseCount
	{
		[Export("sampleUseCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selSampleUseCountHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selSampleUseCountHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public QTSampleBuffer(NSCoder coder)
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
	public QTSampleBuffer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public QTSampleBuffer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("attributeForKey:")]
	public virtual NSObject GetAttribute(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttributeForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAttributeForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("incrementSampleUseCount")]
	public virtual void IncrementSampleUseCount()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selIncrementSampleUseCountHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selIncrementSampleUseCountHandle);
		}
	}

	[Export("decrementSampleUseCount")]
	public virtual void DecrementSampleUseCount()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDecrementSampleUseCountHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDecrementSampleUseCountHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_FormatDescription_var = null;
			__mt_SampleBufferAttributes_var = null;
		}
	}
}
