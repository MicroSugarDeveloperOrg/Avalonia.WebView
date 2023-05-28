using System;
using System.ComponentModel;
using CoreVideo;
using Foundation;
using ImageIO;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVPortraitEffectsMatte", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
public class AVPortraitEffectsMatte : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDictionaryRepresentationForAuxiliaryDataType_ = "dictionaryRepresentationForAuxiliaryDataType:";

	private static readonly IntPtr selDictionaryRepresentationForAuxiliaryDataType_Handle = Selector.GetHandle("dictionaryRepresentationForAuxiliaryDataType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMattingImage = "mattingImage";

	private static readonly IntPtr selMattingImageHandle = Selector.GetHandle("mattingImage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPixelFormatType = "pixelFormatType";

	private static readonly IntPtr selPixelFormatTypeHandle = Selector.GetHandle("pixelFormatType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPortraitEffectsMatteByApplyingExifOrientation_ = "portraitEffectsMatteByApplyingExifOrientation:";

	private static readonly IntPtr selPortraitEffectsMatteByApplyingExifOrientation_Handle = Selector.GetHandle("portraitEffectsMatteByApplyingExifOrientation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPortraitEffectsMatteByReplacingPortraitEffectsMatteWithPixelBuffer_Error_ = "portraitEffectsMatteByReplacingPortraitEffectsMatteWithPixelBuffer:error:";

	private static readonly IntPtr selPortraitEffectsMatteByReplacingPortraitEffectsMatteWithPixelBuffer_Error_Handle = Selector.GetHandle("portraitEffectsMatteByReplacingPortraitEffectsMatteWithPixelBuffer:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPortraitEffectsMatteFromDictionaryRepresentation_Error_ = "portraitEffectsMatteFromDictionaryRepresentation:error:";

	private static readonly IntPtr selPortraitEffectsMatteFromDictionaryRepresentation_Error_Handle = Selector.GetHandle("portraitEffectsMatteFromDictionaryRepresentation:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVPortraitEffectsMatte");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CVPixelBuffer MattingImage
	{
		[Export("mattingImage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSend(base.Handle, selMattingImageHandle), owns: false);
			}
			return Runtime.GetINativeObject<CVPixelBuffer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMattingImageHandle), owns: false);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint PixelFormatType
	{
		[Export("pixelFormatType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selPixelFormatTypeHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selPixelFormatTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVPortraitEffectsMatte(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVPortraitEffectsMatte(IntPtr handle)
		: base(handle)
	{
	}

	[Export("portraitEffectsMatteFromDictionaryRepresentation:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVPortraitEffectsMatte? Create(NSDictionary imageSourceAuxDataInfoDictionary, out NSError? outError)
	{
		if (imageSourceAuxDataInfoDictionary == null)
		{
			throw new ArgumentNullException("imageSourceAuxDataInfoDictionary");
		}
		IntPtr arg = IntPtr.Zero;
		AVPortraitEffectsMatte nSObject = Runtime.GetNSObject<AVPortraitEffectsMatte>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selPortraitEffectsMatteFromDictionaryRepresentation_Error_Handle, imageSourceAuxDataInfoDictionary.Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("portraitEffectsMatteByApplyingExifOrientation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPortraitEffectsMatte Create(CGImagePropertyOrientation exifOrientation)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<AVPortraitEffectsMatte>(Messaging.IntPtr_objc_msgSend_int(base.Handle, selPortraitEffectsMatteByApplyingExifOrientation_Handle, (int)exifOrientation));
		}
		return Runtime.GetNSObject<AVPortraitEffectsMatte>(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selPortraitEffectsMatteByApplyingExifOrientation_Handle, (int)exifOrientation));
	}

	[Export("portraitEffectsMatteByReplacingPortraitEffectsMatteWithPixelBuffer:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVPortraitEffectsMatte? Create(CVPixelBuffer pixelBuffer, out NSError? outError)
	{
		if (pixelBuffer == null)
		{
			throw new ArgumentNullException("pixelBuffer");
		}
		IntPtr arg = IntPtr.Zero;
		AVPortraitEffectsMatte result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<AVPortraitEffectsMatte>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selPortraitEffectsMatteByReplacingPortraitEffectsMatteWithPixelBuffer_Error_Handle, pixelBuffer.Handle, ref arg)) : Runtime.GetNSObject<AVPortraitEffectsMatte>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selPortraitEffectsMatteByReplacingPortraitEffectsMatteWithPixelBuffer_Error_Handle, pixelBuffer.Handle, ref arg)));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("dictionaryRepresentationForAuxiliaryDataType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary? GetDictionaryRepresentation(out string? outAuxDataType)
	{
		IntPtr arg = IntPtr.Zero;
		NSDictionary result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_ref_IntPtr(base.SuperHandle, selDictionaryRepresentationForAuxiliaryDataType_Handle, ref arg)) : Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_ref_IntPtr(base.Handle, selDictionaryRepresentationForAuxiliaryDataType_Handle, ref arg)));
		outAuxDataType = NSString.FromHandle(arg);
		return result;
	}
}
