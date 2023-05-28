using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioConverter", true)]
[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class AVAudioConverter : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplicableEncodeBitRates = "applicableEncodeBitRates";

	private static readonly IntPtr selApplicableEncodeBitRatesHandle = Selector.GetHandle("applicableEncodeBitRates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplicableEncodeSampleRates = "applicableEncodeSampleRates";

	private static readonly IntPtr selApplicableEncodeSampleRatesHandle = Selector.GetHandle("applicableEncodeSampleRates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableEncodeBitRates = "availableEncodeBitRates";

	private static readonly IntPtr selAvailableEncodeBitRatesHandle = Selector.GetHandle("availableEncodeBitRates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableEncodeChannelLayoutTags = "availableEncodeChannelLayoutTags";

	private static readonly IntPtr selAvailableEncodeChannelLayoutTagsHandle = Selector.GetHandle("availableEncodeChannelLayoutTags");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableEncodeSampleRates = "availableEncodeSampleRates";

	private static readonly IntPtr selAvailableEncodeSampleRatesHandle = Selector.GetHandle("availableEncodeSampleRates");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBitRate = "bitRate";

	private static readonly IntPtr selBitRateHandle = Selector.GetHandle("bitRate");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBitRateStrategy = "bitRateStrategy";

	private static readonly IntPtr selBitRateStrategyHandle = Selector.GetHandle("bitRateStrategy");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChannelMap = "channelMap";

	private static readonly IntPtr selChannelMapHandle = Selector.GetHandle("channelMap");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertToBuffer_Error_WithInputFromBlock_ = "convertToBuffer:error:withInputFromBlock:";

	private static readonly IntPtr selConvertToBuffer_Error_WithInputFromBlock_Handle = Selector.GetHandle("convertToBuffer:error:withInputFromBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selConvertToBuffer_FromBuffer_Error_ = "convertToBuffer:fromBuffer:error:";

	private static readonly IntPtr selConvertToBuffer_FromBuffer_Error_Handle = Selector.GetHandle("convertToBuffer:fromBuffer:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDither = "dither";

	private static readonly IntPtr selDitherHandle = Selector.GetHandle("dither");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDownmix = "downmix";

	private static readonly IntPtr selDownmixHandle = Selector.GetHandle("downmix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitFromFormat_ToFormat_ = "initFromFormat:toFormat:";

	private static readonly IntPtr selInitFromFormat_ToFormat_Handle = Selector.GetHandle("initFromFormat:toFormat:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputFormat = "inputFormat";

	private static readonly IntPtr selInputFormatHandle = Selector.GetHandle("inputFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMagicCookie = "magicCookie";

	private static readonly IntPtr selMagicCookieHandle = Selector.GetHandle("magicCookie");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMaximumOutputPacketSize = "maximumOutputPacketSize";

	private static readonly IntPtr selMaximumOutputPacketSizeHandle = Selector.GetHandle("maximumOutputPacketSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOutputFormat = "outputFormat";

	private static readonly IntPtr selOutputFormatHandle = Selector.GetHandle("outputFormat");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimeInfo = "primeInfo";

	private static readonly IntPtr selPrimeInfoHandle = Selector.GetHandle("primeInfo");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrimeMethod = "primeMethod";

	private static readonly IntPtr selPrimeMethodHandle = Selector.GetHandle("primeMethod");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReset = "reset";

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleRateConverterAlgorithm = "sampleRateConverterAlgorithm";

	private static readonly IntPtr selSampleRateConverterAlgorithmHandle = Selector.GetHandle("sampleRateConverterAlgorithm");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSampleRateConverterQuality = "sampleRateConverterQuality";

	private static readonly IntPtr selSampleRateConverterQualityHandle = Selector.GetHandle("sampleRateConverterQuality");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBitRate_ = "setBitRate:";

	private static readonly IntPtr selSetBitRate_Handle = Selector.GetHandle("setBitRate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBitRateStrategy_ = "setBitRateStrategy:";

	private static readonly IntPtr selSetBitRateStrategy_Handle = Selector.GetHandle("setBitRateStrategy:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetChannelMap_ = "setChannelMap:";

	private static readonly IntPtr selSetChannelMap_Handle = Selector.GetHandle("setChannelMap:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDither_ = "setDither:";

	private static readonly IntPtr selSetDither_Handle = Selector.GetHandle("setDither:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDownmix_ = "setDownmix:";

	private static readonly IntPtr selSetDownmix_Handle = Selector.GetHandle("setDownmix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetMagicCookie_ = "setMagicCookie:";

	private static readonly IntPtr selSetMagicCookie_Handle = Selector.GetHandle("setMagicCookie:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimeInfo_ = "setPrimeInfo:";

	private static readonly IntPtr selSetPrimeInfo_Handle = Selector.GetHandle("setPrimeInfo:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrimeMethod_ = "setPrimeMethod:";

	private static readonly IntPtr selSetPrimeMethod_Handle = Selector.GetHandle("setPrimeMethod:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSampleRateConverterAlgorithm_ = "setSampleRateConverterAlgorithm:";

	private static readonly IntPtr selSetSampleRateConverterAlgorithm_Handle = Selector.GetHandle("setSampleRateConverterAlgorithm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSampleRateConverterQuality_ = "setSampleRateConverterQuality:";

	private static readonly IntPtr selSetSampleRateConverterQuality_Handle = Selector.GetHandle("setSampleRateConverterQuality:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVAudioConverter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[]? ApplicableEncodeBitRates
	{
		[Export("applicableEncodeBitRates")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selApplicableEncodeBitRatesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selApplicableEncodeBitRatesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[]? ApplicableEncodeSampleRates
	{
		[Export("applicableEncodeSampleRates")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selApplicableEncodeSampleRatesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selApplicableEncodeSampleRatesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[]? AvailableEncodeBitRates
	{
		[Export("availableEncodeBitRates")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableEncodeBitRatesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableEncodeBitRatesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[]? AvailableEncodeChannelLayoutTags
	{
		[Export("availableEncodeChannelLayoutTags")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableEncodeChannelLayoutTagsHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableEncodeChannelLayoutTagsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[]? AvailableEncodeSampleRates
	{
		[Export("availableEncodeSampleRates")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableEncodeSampleRatesHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableEncodeSampleRatesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint BitRate
	{
		[Export("bitRate", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selBitRateHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selBitRateHandle);
		}
		[Export("setBitRate:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetBitRate_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetBitRate_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? BitRateStrategy
	{
		[Export("bitRateStrategy", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBitRateStrategyHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBitRateStrategyHandle));
		}
		[Export("setBitRateStrategy:", ArgumentSemantic.Retain)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBitRateStrategy_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBitRateStrategy_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSNumber[] ChannelMap
	{
		[Export("channelMap", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSend(base.Handle, selChannelMapHandle));
			}
			return NSArray.ArrayFromHandle<NSNumber>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChannelMapHandle));
		}
		[Export("setChannelMap:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetChannelMap_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetChannelMap_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Dither
	{
		[Export("dither")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDitherHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDitherHandle);
		}
		[Export("setDither:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDither_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDither_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Downmix
	{
		[Export("downmix")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selDownmixHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selDownmixHandle);
		}
		[Export("setDownmix:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetDownmix_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetDownmix_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioFormat InputFormat
	{
		[Export("inputFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputFormatHandle));
			}
			return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputFormatHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData? MagicCookie
	{
		[Export("magicCookie", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selMagicCookieHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMagicCookieHandle));
		}
		[Export("setMagicCookie:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetMagicCookie_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetMagicCookie_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint MaximumOutputPacketSize
	{
		[Export("maximumOutputPacketSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selMaximumOutputPacketSizeHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selMaximumOutputPacketSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioFormat OutputFormat
	{
		[Export("outputFormat")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSend(base.Handle, selOutputFormatHandle));
			}
			return Runtime.GetNSObject<AVAudioFormat>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOutputFormatHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioConverterPrimeInfo PrimeInfo
	{
		[Export("primeInfo", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.AVAudioConverterPrimeInfo_objc_msgSend(base.Handle, selPrimeInfoHandle);
			}
			return Messaging.AVAudioConverterPrimeInfo_objc_msgSendSuper(base.SuperHandle, selPrimeInfoHandle);
		}
		[Export("setPrimeInfo:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_AVAudioConverterPrimeInfo(base.Handle, selSetPrimeInfo_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_AVAudioConverterPrimeInfo(base.SuperHandle, selSetPrimeInfo_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVAudioConverterPrimeMethod PrimeMethod
	{
		[Export("primeMethod", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (AVAudioConverterPrimeMethod)Messaging.Int64_objc_msgSend(base.Handle, selPrimeMethodHandle);
			}
			return (AVAudioConverterPrimeMethod)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selPrimeMethodHandle);
		}
		[Export("setPrimeMethod:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetPrimeMethod_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetPrimeMethod_Handle, (long)value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? SampleRateConverterAlgorithm
	{
		[Export("sampleRateConverterAlgorithm", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSampleRateConverterAlgorithmHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSampleRateConverterAlgorithmHandle));
		}
		[Export("setSampleRateConverterAlgorithm:", ArgumentSemantic.Retain)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSampleRateConverterAlgorithm_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSampleRateConverterAlgorithm_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint SampleRateConverterQuality
	{
		[Export("sampleRateConverterQuality", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nint_objc_msgSend(base.Handle, selSampleRateConverterQualityHandle);
			}
			return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selSampleRateConverterQualityHandle);
		}
		[Export("setSampleRateConverterQuality:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_nint(base.Handle, selSetSampleRateConverterQuality_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selSetSampleRateConverterQuality_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVAudioConverter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVAudioConverter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initFromFormat:toFormat:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public AVAudioConverter(AVAudioFormat fromFormat, AVAudioFormat toFormat)
		: base(NSObjectFlag.Empty)
	{
		if (fromFormat == null)
		{
			throw new ArgumentNullException("fromFormat");
		}
		if (toFormat == null)
		{
			throw new ArgumentNullException("toFormat");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitFromFormat_ToFormat_Handle, fromFormat.Handle, toFormat.Handle), "initFromFormat:toFormat:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitFromFormat_ToFormat_Handle, fromFormat.Handle, toFormat.Handle), "initFromFormat:toFormat:");
		}
	}

	[Export("convertToBuffer:fromBuffer:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ConvertToBuffer(AVAudioPcmBuffer outputBuffer, AVAudioPcmBuffer inputBuffer, out NSError? outError)
	{
		if (outputBuffer == null)
		{
			throw new ArgumentNullException("outputBuffer");
		}
		if (inputBuffer == null)
		{
			throw new ArgumentNullException("inputBuffer");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selConvertToBuffer_FromBuffer_Error_Handle, outputBuffer.Handle, inputBuffer.Handle, ref arg) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selConvertToBuffer_FromBuffer_Error_Handle, outputBuffer.Handle, inputBuffer.Handle, ref arg));
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("convertToBuffer:error:withInputFromBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual AVAudioConverterOutputStatus ConvertToBuffer(AVAudioBuffer outputBuffer, out NSError? outError, [BlockProxy(typeof(Trampolines.NIDAVAudioConverterInputHandler))] AVAudioConverterInputHandler inputHandler)
	{
		if (outputBuffer == null)
		{
			throw new ArgumentNullException("outputBuffer");
		}
		if (inputHandler == null)
		{
			throw new ArgumentNullException("inputHandler");
		}
		IntPtr arg = IntPtr.Zero;
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDAVAudioConverterInputHandler.Handler, inputHandler);
		AVAudioConverterOutputStatus result = (AVAudioConverterOutputStatus)((!base.IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr_ref_IntPtr_IntPtr(base.SuperHandle, selConvertToBuffer_Error_WithInputFromBlock_Handle, outputBuffer.Handle, ref arg, (IntPtr)ptr) : Messaging.Int64_objc_msgSend_IntPtr_ref_IntPtr_IntPtr(base.Handle, selConvertToBuffer_Error_WithInputFromBlock_Handle, outputBuffer.Handle, ref arg, (IntPtr)ptr));
		ptr->CleanupBlock();
		outError = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[Export("reset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reset()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}
}
