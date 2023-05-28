using System;
using System.ComponentModel;
using CoreMedia;
using CoreVideo;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAssetWriterInputPixelBufferAdaptor", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVAssetWriterInputPixelBufferAdaptor : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendPixelBuffer_WithPresentationTime_ = "appendPixelBuffer:withPresentationTime:";

	private static readonly IntPtr selAppendPixelBuffer_WithPresentationTime_Handle = Selector.GetHandle("appendPixelBuffer:withPresentationTime:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetWriterInput = "assetWriterInput";

	private static readonly IntPtr selAssetWriterInputHandle = Selector.GetHandle("assetWriterInput");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAssetWriterInputPixelBufferAdaptorWithAssetWriterInput_SourcePixelBufferAttributes_ = "assetWriterInputPixelBufferAdaptorWithAssetWriterInput:sourcePixelBufferAttributes:";

	private static readonly IntPtr selAssetWriterInputPixelBufferAdaptorWithAssetWriterInput_SourcePixelBufferAttributes_Handle = Selector.GetHandle("assetWriterInputPixelBufferAdaptorWithAssetWriterInput:sourcePixelBufferAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAssetWriterInput_SourcePixelBufferAttributes_ = "initWithAssetWriterInput:sourcePixelBufferAttributes:";

	private static readonly IntPtr selInitWithAssetWriterInput_SourcePixelBufferAttributes_Handle = Selector.GetHandle("initWithAssetWriterInput:sourcePixelBufferAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelBufferPool = "pixelBufferPool";

	private static readonly IntPtr selPixelBufferPoolHandle = Selector.GetHandle("pixelBufferPool");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourcePixelBufferAttributes = "sourcePixelBufferAttributes";

	private static readonly IntPtr selSourcePixelBufferAttributesHandle = Selector.GetHandle("sourcePixelBufferAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAssetWriterInputPixelBufferAdaptor");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAssetWriterInput AssetWriterInput
	{
		[Export("assetWriterInput")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAssetWriterInput>(Messaging.IntPtr_objc_msgSend(base.Handle, selAssetWriterInputHandle));
			}
			return Runtime.GetNSObject<AVAssetWriterInput>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAssetWriterInputHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CVPixelBufferAttributes Attributes
	{
		get
		{
			NSMutableDictionary nSMutableDictionary = ((SourcePixelBufferAttributes != null) ? new NSMutableDictionary(SourcePixelBufferAttributes) : null);
			return (nSMutableDictionary == null) ? null : new CVPixelBufferAttributes(nSMutableDictionary);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CVPixelBufferPool? PixelBufferPool
	{
		[Export("pixelBufferPool")]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPixelBufferPoolHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selPixelBufferPoolHandle));
			return (intPtr == IntPtr.Zero) ? null : new CVPixelBufferPool(intPtr);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? SourcePixelBufferAttributes
	{
		[Export("sourcePixelBufferAttributes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selSourcePixelBufferAttributesHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSourcePixelBufferAttributesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAssetWriterInputPixelBufferAdaptor(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAssetWriterInputPixelBufferAdaptor(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithAssetWriterInput:sourcePixelBufferAttributes:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetWriterInputPixelBufferAdaptor(AVAssetWriterInput input, NSDictionary? sourcePixelBufferAttributes)
		: base(NSObjectFlag.Empty)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithAssetWriterInput_SourcePixelBufferAttributes_Handle, input.Handle, sourcePixelBufferAttributes?.Handle ?? IntPtr.Zero), "initWithAssetWriterInput:sourcePixelBufferAttributes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithAssetWriterInput_SourcePixelBufferAttributes_Handle, input.Handle, sourcePixelBufferAttributes?.Handle ?? IntPtr.Zero), "initWithAssetWriterInput:sourcePixelBufferAttributes:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAssetWriterInputPixelBufferAdaptor(AVAssetWriterInput input, CVPixelBufferAttributes? attributes)
		: this(input, attributes.GetDictionary())
	{
	}

	[Export("appendPixelBuffer:withPresentationTime:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AppendPixelBufferWithPresentationTime(CVPixelBuffer pixelBuffer, CMTime presentationTime)
	{
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CMTime(base.Handle, selAppendPixelBuffer_WithPresentationTime_Handle, pixelBuffer.Handle, presentationTime);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CMTime(base.SuperHandle, selAppendPixelBuffer_WithPresentationTime_Handle, pixelBuffer.Handle, presentationTime);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVAssetWriterInputPixelBufferAdaptor Create(AVAssetWriterInput input, CVPixelBufferAttributes? attributes)
	{
		return FromInput(input, attributes.GetDictionary());
	}

	[Export("assetWriterInputPixelBufferAdaptorWithAssetWriterInput:sourcePixelBufferAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Advice("Use 'Create' method.")]
	public static AVAssetWriterInputPixelBufferAdaptor FromInput(AVAssetWriterInput input, NSDictionary? sourcePixelBufferAttributes)
	{
		if (input == null)
		{
			throw new ArgumentNullException("input");
		}
		return Runtime.GetNSObject<AVAssetWriterInputPixelBufferAdaptor>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selAssetWriterInputPixelBufferAdaptorWithAssetWriterInput_SourcePixelBufferAttributes_Handle, input.Handle, sourcePixelBufferAttributes?.Handle ?? IntPtr.Zero));
	}
}
