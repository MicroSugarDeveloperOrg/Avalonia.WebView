using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Register("QTSampleBuffer", true)]
public class QTSampleBuffer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributeForKey_ = "attributeForKey:";

	private static readonly IntPtr selAttributeForKey_Handle = Selector.GetHandle("attributeForKey:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBytesForAllSamples = "bytesForAllSamples";

	private static readonly IntPtr selBytesForAllSamplesHandle = Selector.GetHandle("bytesForAllSamples");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeTime = "decodeTime";

	private static readonly IntPtr selDecodeTimeHandle = Selector.GetHandle("decodeTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecrementSampleUseCount = "decrementSampleUseCount";

	private static readonly IntPtr selDecrementSampleUseCountHandle = Selector.GetHandle("decrementSampleUseCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDuration = "duration";

	private static readonly IntPtr selDurationHandle = Selector.GetHandle("duration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFormatDescription = "formatDescription";

	private static readonly IntPtr selFormatDescriptionHandle = Selector.GetHandle("formatDescription");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIncrementSampleUseCount = "incrementSampleUseCount";

	private static readonly IntPtr selIncrementSampleUseCountHandle = Selector.GetHandle("incrementSampleUseCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLengthForAllSamples = "lengthForAllSamples";

	private static readonly IntPtr selLengthForAllSamplesHandle = Selector.GetHandle("lengthForAllSamples");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfSamples = "numberOfSamples";

	private static readonly IntPtr selNumberOfSamplesHandle = Selector.GetHandle("numberOfSamples");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPresentationTime = "presentationTime";

	private static readonly IntPtr selPresentationTimeHandle = Selector.GetHandle("presentationTime");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleBufferAttributes = "sampleBufferAttributes";

	private static readonly IntPtr selSampleBufferAttributesHandle = Selector.GetHandle("sampleBufferAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleUseCount = "sampleUseCount";

	private static readonly IntPtr selSampleUseCountHandle = Selector.GetHandle("sampleUseCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("QTSampleBuffer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr BytesForAllSamples
	{
		[Export("bytesForAllSamples")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selBytesForAllSamplesHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBytesForAllSamplesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTTime DecodeTime
	{
		[Export("decodeTime")]
		get
		{
			QTTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.QTTime_objc_msgSend_stret(out retval, base.Handle, selDecodeTimeHandle);
			}
			else
			{
				Messaging.QTTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDecodeTimeHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTTime Duration
	{
		[Export("duration")]
		get
		{
			QTTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.QTTime_objc_msgSend_stret(out retval, base.Handle, selDurationHandle);
			}
			else
			{
				Messaging.QTTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selDurationHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTFormatDescription FormatDescription
	{
		[Export("formatDescription")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<QTFormatDescription>(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatDescriptionHandle));
			}
			return Runtime.GetNSObject<QTFormatDescription>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatDescriptionHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint LengthForAllSamples
	{
		[Export("lengthForAllSamples")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selLengthForAllSamplesHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selLengthForAllSamplesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual QTTime PresentationTime
	{
		[Export("presentationTime")]
		get
		{
			QTTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.QTTime_objc_msgSend_stret(out retval, base.Handle, selPresentationTimeHandle);
			}
			else
			{
				Messaging.QTTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selPresentationTimeHandle);
			}
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary SampleBufferAttributes
	{
		[Export("sampleBufferAttributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selSampleBufferAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSampleBufferAttributesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SampleCount
	{
		[Export("numberOfSamples")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selNumberOfSamplesHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selNumberOfSamplesHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SampleUseCount
	{
		[Export("sampleUseCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSampleUseCountHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSampleUseCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QTSampleBuffer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTSampleBuffer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("decrementSampleUseCount")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DecrementSampleUseCount()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDecrementSampleUseCountHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDecrementSampleUseCountHandle);
		}
	}

	[Export("attributeForKey:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetAttribute(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		IntPtr arg = NSString.CreateNative(key);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAttributeForKey_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAttributeForKey_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("incrementSampleUseCount")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void IncrementSampleUseCount()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selIncrementSampleUseCountHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selIncrementSampleUseCountHandle);
		}
	}
}
