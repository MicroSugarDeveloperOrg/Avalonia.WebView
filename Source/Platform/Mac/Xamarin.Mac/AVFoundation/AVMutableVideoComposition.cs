using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableVideoComposition", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVMutableVideoComposition : AVVideoComposition
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnimationTool = "animationTool";

	private static readonly IntPtr selAnimationToolHandle = Selector.GetHandle("animationTool");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorPrimaries = "colorPrimaries";

	private static readonly IntPtr selColorPrimariesHandle = Selector.GetHandle("colorPrimaries");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorTransferFunction = "colorTransferFunction";

	private static readonly IntPtr selColorTransferFunctionHandle = Selector.GetHandle("colorTransferFunction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selColorYCbCrMatrix = "colorYCbCrMatrix";

	private static readonly IntPtr selColorYCbCrMatrixHandle = Selector.GetHandle("colorYCbCrMatrix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCustomVideoCompositorClass = "customVideoCompositorClass";

	private static readonly IntPtr selCustomVideoCompositorClassHandle = Selector.GetHandle("customVideoCompositorClass");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFrameDuration = "frameDuration";

	private static readonly IntPtr selFrameDurationHandle = Selector.GetHandle("frameDuration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInstructions = "instructions";

	private static readonly IntPtr selInstructionsHandle = Selector.GetHandle("instructions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderScale = "renderScale";

	private static readonly IntPtr selRenderScaleHandle = Selector.GetHandle("renderScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderSize = "renderSize";

	private static readonly IntPtr selRenderSizeHandle = Selector.GetHandle("renderSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAnimationTool_ = "setAnimationTool:";

	private static readonly IntPtr selSetAnimationTool_Handle = Selector.GetHandle("setAnimationTool:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColorPrimaries_ = "setColorPrimaries:";

	private static readonly IntPtr selSetColorPrimaries_Handle = Selector.GetHandle("setColorPrimaries:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColorTransferFunction_ = "setColorTransferFunction:";

	private static readonly IntPtr selSetColorTransferFunction_Handle = Selector.GetHandle("setColorTransferFunction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetColorYCbCrMatrix_ = "setColorYCbCrMatrix:";

	private static readonly IntPtr selSetColorYCbCrMatrix_Handle = Selector.GetHandle("setColorYCbCrMatrix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCustomVideoCompositorClass_ = "setCustomVideoCompositorClass:";

	private static readonly IntPtr selSetCustomVideoCompositorClass_Handle = Selector.GetHandle("setCustomVideoCompositorClass:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetFrameDuration_ = "setFrameDuration:";

	private static readonly IntPtr selSetFrameDuration_Handle = Selector.GetHandle("setFrameDuration:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetInstructions_ = "setInstructions:";

	private static readonly IntPtr selSetInstructions_Handle = Selector.GetHandle("setInstructions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRenderScale_ = "setRenderScale:";

	private static readonly IntPtr selSetRenderScale_Handle = Selector.GetHandle("setRenderScale:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetRenderSize_ = "setRenderSize:";

	private static readonly IntPtr selSetRenderSize_Handle = Selector.GetHandle("setRenderSize:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSourceTrackIDForFrameTiming_ = "setSourceTrackIDForFrameTiming:";

	private static readonly IntPtr selSetSourceTrackIDForFrameTiming_Handle = Selector.GetHandle("setSourceTrackIDForFrameTiming:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSourceTrackIDForFrameTiming = "sourceTrackIDForFrameTiming";

	private static readonly IntPtr selSourceTrackIDForFrameTimingHandle = Selector.GetHandle("sourceTrackIDForFrameTiming");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoComposition = "videoComposition";

	private static readonly IntPtr selVideoCompositionHandle = Selector.GetHandle("videoComposition");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoCompositionWithAsset_ApplyingCIFiltersWithHandler_ = "videoCompositionWithAsset:applyingCIFiltersWithHandler:";

	private static readonly IntPtr selVideoCompositionWithAsset_ApplyingCIFiltersWithHandler_Handle = Selector.GetHandle("videoCompositionWithAsset:applyingCIFiltersWithHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoCompositionWithPropertiesOfAsset_ = "videoCompositionWithPropertiesOfAsset:";

	private static readonly IntPtr selVideoCompositionWithPropertiesOfAsset_Handle = Selector.GetHandle("videoCompositionWithPropertiesOfAsset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoCompositionWithPropertiesOfAsset_PrototypeInstruction_ = "videoCompositionWithPropertiesOfAsset:prototypeInstruction:";

	private static readonly IntPtr selVideoCompositionWithPropertiesOfAsset_PrototypeInstruction_Handle = Selector.GetHandle("videoCompositionWithPropertiesOfAsset:prototypeInstruction:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMutableVideoComposition");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual AVVideoCompositionCoreAnimationTool? AnimationTool
	{
		[Export("animationTool", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVVideoCompositionCoreAnimationTool>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationToolHandle));
			}
			return Runtime.GetNSObject<AVVideoCompositionCoreAnimationTool>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationToolHandle));
		}
		[Export("setAnimationTool:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimationTool_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimationTool_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public new virtual string? ColorPrimaries
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("colorPrimaries")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selColorPrimariesHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorPrimariesHandle));
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setColorPrimaries:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColorPrimaries_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColorPrimaries_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public new virtual string? ColorTransferFunction
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("colorTransferFunction")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selColorTransferFunctionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorTransferFunctionHandle));
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setColorTransferFunction:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColorTransferFunction_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColorTransferFunction_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public new virtual string? ColorYCbCrMatrix
	{
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("colorYCbCrMatrix")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selColorYCbCrMatrixHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selColorYCbCrMatrixHandle));
		}
		[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("setColorYCbCrMatrix:")]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetColorYCbCrMatrix_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetColorYCbCrMatrix_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public override Class? CustomVideoCompositorClass
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("customVideoCompositorClass", ArgumentSemantic.Retain)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomVideoCompositorClassHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCustomVideoCompositorClassHandle));
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setCustomVideoCompositorClass:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCustomVideoCompositorClass_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCustomVideoCompositorClass_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CMTime FrameDuration
	{
		[Export("frameDuration", ArgumentSemantic.Assign)]
		get
		{
			CMTime retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTime_objc_msgSend_stret(out retval, base.Handle, selFrameDurationHandle);
			}
			else
			{
				Messaging.CMTime_objc_msgSendSuper_stret(out retval, base.SuperHandle, selFrameDurationHandle);
			}
			return retval;
		}
		[Export("setFrameDuration:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetFrameDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetFrameDuration_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual AVVideoCompositionInstruction[] Instructions
	{
		[Export("instructions", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVVideoCompositionInstruction>(Messaging.IntPtr_objc_msgSend(base.Handle, selInstructionsHandle));
			}
			return NSArray.ArrayFromHandle<AVVideoCompositionInstruction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInstructionsHandle));
		}
		[Export("setInstructions:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInstructions_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInstructions_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public new virtual float RenderScale
	{
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("renderScale")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selRenderScaleHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selRenderScaleHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
		[Export("setRenderScale:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetRenderScale_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetRenderScale_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual CGSize RenderSize
	{
		[Export("renderSize", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selRenderSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selRenderSizeHandle);
		}
		[Export("setRenderSize:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetRenderSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetRenderSize_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual int SourceTrackIdForFrameTiming
	{
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("sourceTrackIDForFrameTiming")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selSourceTrackIDForFrameTimingHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selSourceTrackIDForFrameTimingHandle);
		}
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("setSourceTrackIDForFrameTiming:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetSourceTrackIDForFrameTiming_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetSourceTrackIDForFrameTiming_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMutableVideoComposition()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVMutableVideoComposition(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMutableVideoComposition(IntPtr handle)
		: base(handle)
	{
	}

	[Export("videoComposition")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableVideoComposition Create()
	{
		return Runtime.GetNSObject<AVMutableVideoComposition>(Messaging.IntPtr_objc_msgSend(class_ptr, selVideoCompositionHandle));
	}

	[Export("videoCompositionWithPropertiesOfAsset:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableVideoComposition Create(AVAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return Runtime.GetNSObject<AVMutableVideoComposition>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selVideoCompositionWithPropertiesOfAsset_Handle, asset.Handle));
	}

	[Export("videoCompositionWithPropertiesOfAsset:prototypeInstruction:")]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVMutableVideoComposition Create(AVAsset asset, AVVideoCompositionInstruction prototypeInstruction)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (prototypeInstruction == null)
		{
			throw new ArgumentNullException("prototypeInstruction");
		}
		return Runtime.GetNSObject<AVMutableVideoComposition>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selVideoCompositionWithPropertiesOfAsset_PrototypeInstruction_Handle, asset.Handle, prototypeInstruction.Handle));
	}

	[Export("videoCompositionWithAsset:applyingCIFiltersWithHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static AVMutableVideoComposition GetVideoComposition(AVAsset asset, [BlockProxy(typeof(Trampolines.NIDActionArity1V4))] Action<AVAsynchronousCIImageFilteringRequest> applier)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (applier == null)
		{
			throw new ArgumentNullException("applier");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity1V4.Handler, applier);
		AVMutableVideoComposition nSObject = Runtime.GetNSObject<AVMutableVideoComposition>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selVideoCompositionWithAsset_ApplyingCIFiltersWithHandler_Handle, asset.Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}
}
