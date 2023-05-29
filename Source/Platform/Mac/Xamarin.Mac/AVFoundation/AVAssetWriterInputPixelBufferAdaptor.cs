using System;
using System.ComponentModel;
using CoreMedia;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetWriterInputPixelBufferAdaptor", true)]
public class AVAssetWriterInputPixelBufferAdaptor : NSObject
{
	private static readonly IntPtr selAssetWriterInputHandle = Selector.GetHandle("assetWriterInput");

	private static readonly IntPtr selSourcePixelBufferAttributesHandle = Selector.GetHandle("sourcePixelBufferAttributes");

	private static readonly IntPtr selPixelBufferPoolHandle = Selector.GetHandle("pixelBufferPool");

	private static readonly IntPtr selAssetWriterInputPixelBufferAdaptorWithAssetWriterInputSourcePixelBufferAttributes_Handle = Selector.GetHandle("assetWriterInputPixelBufferAdaptorWithAssetWriterInput:sourcePixelBufferAttributes:");

	private static readonly IntPtr selInitWithAssetWriterInputSourcePixelBufferAttributes_Handle = Selector.GetHandle("initWithAssetWriterInput:sourcePixelBufferAttributes:");

	private static readonly IntPtr selAppendPixelBufferWithPresentationTime_Handle = Selector.GetHandle("appendPixelBuffer:withPresentationTime:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAssetWriterInputPixelBufferAdaptor");

	private object __mt_AssetWriterInput_var;

	private object __mt_SourcePixelBufferAttributes_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVAssetWriterInput AssetWriterInput
	{
		[Export("assetWriterInput")]
		get
		{
			return (AVAssetWriterInput)(__mt_AssetWriterInput_var = ((!IsDirectBinding) ? ((AVAssetWriterInput)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetWriterInputHandle))) : ((AVAssetWriterInput)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetWriterInputHandle)))));
		}
	}

	public virtual NSDictionary SourcePixelBufferAttributes
	{
		[Export("sourcePixelBufferAttributes")]
		get
		{
			return (NSDictionary)(__mt_SourcePixelBufferAttributes_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourcePixelBufferAttributesHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSourcePixelBufferAttributesHandle)))));
		}
	}

	public CVPixelBufferAttributes Attributes
	{
		get
		{
			NSDictionary sourcePixelBufferAttributes = SourcePixelBufferAttributes;
			if (sourcePixelBufferAttributes != null)
			{
				return new CVPixelBufferAttributes(sourcePixelBufferAttributes);
			}
			return null;
		}
	}

	public virtual CVPixelBufferPool PixelBufferPool
	{
		[Export("pixelBufferPool")]
		get
		{
			if (IsDirectBinding)
			{
				return new CVPixelBufferPool(Messaging.IntPtr_objc_msgSend(base.Handle, selPixelBufferPoolHandle));
			}
			return new CVPixelBufferPool(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPixelBufferPoolHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVAssetWriterInputPixelBufferAdaptor(NSCoder coder)
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
	public AVAssetWriterInputPixelBufferAdaptor(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAssetWriterInputPixelBufferAdaptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("assetWriterInputPixelBufferAdaptorWithAssetWriterInput:sourcePixelBufferAttributes:")]
	public static AVAssetWriterInputPixelBufferAdaptor FromInput(AVAssetWriterInput input, NSDictionary sourcePixelBufferAttributes)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return (AVAssetWriterInputPixelBufferAdaptor)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selAssetWriterInputPixelBufferAdaptorWithAssetWriterInputSourcePixelBufferAttributes_Handle, input.Handle, sourcePixelBufferAttributes?.Handle ?? IntPtr.Zero));
	}

	public static AVAssetWriterInputPixelBufferAdaptor Create(AVAssetWriterInput input, CVPixelBufferAttributes attributes)
	{
		return FromInput(input, attributes?.Dictionary);
	}

	[Export("initWithAssetWriterInput:sourcePixelBufferAttributes:")]
	public AVAssetWriterInputPixelBufferAdaptor(AVAssetWriterInput input, NSDictionary sourcePixelBufferAttributes)
		: base(NSObjectFlag.Empty)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAssetWriterInputSourcePixelBufferAttributes_Handle, input.Handle, sourcePixelBufferAttributes?.Handle ?? IntPtr.Zero);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAssetWriterInputSourcePixelBufferAttributes_Handle, input.Handle, sourcePixelBufferAttributes?.Handle ?? IntPtr.Zero);
		}
	}

	public AVAssetWriterInputPixelBufferAdaptor(AVAssetWriterInput input, CVPixelBufferAttributes attributes)
		: this(input, attributes?.Dictionary)
	{
	}

	[Export("appendPixelBuffer:withPresentationTime:")]
	public virtual bool AppendPixelBufferWithPresentationTime(CVPixelBuffer pixelBuffer, CMTime presentationTime)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CMTime(base.Handle, selAppendPixelBufferWithPresentationTime_Handle, pixelBuffer.Handle, presentationTime);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CMTime(base.SuperHandle, selAppendPixelBufferWithPresentationTime_Handle, pixelBuffer.Handle, presentationTime);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AssetWriterInput_var = null;
			__mt_SourcePixelBufferAttributes_var = null;
		}
	}
}
