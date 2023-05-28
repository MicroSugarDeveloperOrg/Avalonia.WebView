using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVVideoComposition", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVVideoComposition : NSObject, INSCopying, INativeObject, IDisposable, INSMutableCopying
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
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

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
	private const string selIsValidForAsset_TimeRange_ValidationDelegate_ = "isValidForAsset:timeRange:validationDelegate:";

	private static readonly IntPtr selIsValidForAsset_TimeRange_ValidationDelegate_Handle = Selector.GetHandle("isValidForAsset:timeRange:validationDelegate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

	private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderScale = "renderScale";

	private static readonly IntPtr selRenderScaleHandle = Selector.GetHandle("renderScale");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRenderSize = "renderSize";

	private static readonly IntPtr selRenderSizeHandle = Selector.GetHandle("renderSize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoCompositionWithAsset_ApplyingCIFiltersWithHandler_ = "videoCompositionWithAsset:applyingCIFiltersWithHandler:";

	private static readonly IntPtr selVideoCompositionWithAsset_ApplyingCIFiltersWithHandler_Handle = Selector.GetHandle("videoCompositionWithAsset:applyingCIFiltersWithHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoCompositionWithPropertiesOfAsset_ = "videoCompositionWithPropertiesOfAsset:";

	private static readonly IntPtr selVideoCompositionWithPropertiesOfAsset_Handle = Selector.GetHandle("videoCompositionWithPropertiesOfAsset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVVideoComposition");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	public virtual AVVideoCompositionCoreAnimationTool? AnimationTool
	{
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Export("animationTool", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<AVVideoCompositionCoreAnimationTool>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationToolHandle));
			}
			return Runtime.GetNSObject<AVVideoCompositionCoreAnimationTool>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationToolHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual string? ColorPrimaries
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual string? ColorTransferFunction
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public virtual string? ColorYCbCrMatrix
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual Class? CustomVideoCompositorClass
	{
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("customVideoCompositorClass", ArgumentSemantic.Copy)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCustomVideoCompositorClassHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selCustomVideoCompositorClassHandle));
			return (intPtr == IntPtr.Zero) ? null : new Class(intPtr);
		}
		[Introduced(PlatformName.iOS, 7, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CMTime FrameDuration
	{
		[Export("frameDuration")]
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual AVVideoCompositionInstruction[] Instructions
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
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
	public virtual float RenderScale
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
		[NotImplemented]
		set
		{
			throw new NotImplementedException();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize RenderSize
	{
		[Export("renderSize")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selRenderSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selRenderSizeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVVideoComposition()
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
	protected AVVideoComposition(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVVideoComposition(IntPtr handle)
		: base(handle)
	{
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("videoCompositionWithAsset:applyingCIFiltersWithHandler:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static AVVideoComposition CreateVideoComposition(AVAsset asset, [BlockProxy(typeof(Trampolines.NIDActionArity1V4))] Action<AVAsynchronousCIImageFilteringRequest> applier)
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
		AVVideoComposition nSObject = Runtime.GetNSObject<AVVideoComposition>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selVideoCompositionWithAsset_ApplyingCIFiltersWithHandler_Handle, asset.Handle, (IntPtr)ptr));
		ptr->CleanupBlock();
		return nSObject;
	}

	[Export("videoCompositionWithPropertiesOfAsset:")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVVideoComposition FromAssetProperties(AVAsset asset)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		return Runtime.GetNSObject<AVVideoComposition>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selVideoCompositionWithPropertiesOfAsset_Handle, asset.Handle));
	}

	[Export("isValidForAsset:timeRange:validationDelegate:")]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsValidForAsset(AVAsset? asset, CMTimeRange timeRange, IAVVideoCompositionValidationHandling? validationDelegate)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CMTimeRange_IntPtr(base.Handle, selIsValidForAsset_TimeRange_ValidationDelegate_Handle, asset?.Handle ?? IntPtr.Zero, timeRange, validationDelegate?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CMTimeRange_IntPtr(base.SuperHandle, selIsValidForAsset_TimeRange_ValidationDelegate_Handle, asset?.Handle ?? IntPtr.Zero, timeRange, validationDelegate?.Handle ?? IntPtr.Zero);
	}

	[Export("mutableCopyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public virtual NSObject MutableCopy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}
}
