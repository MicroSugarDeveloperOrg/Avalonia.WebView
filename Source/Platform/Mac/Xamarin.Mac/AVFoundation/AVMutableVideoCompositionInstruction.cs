using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableVideoCompositionInstruction", true)]
[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
public class AVMutableVideoCompositionInstruction : AVVideoCompositionInstruction
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBackgroundColor = "backgroundColor";

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnablePostProcessing = "enablePostProcessing";

	private static readonly IntPtr selEnablePostProcessingHandle = Selector.GetHandle("enablePostProcessing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayerInstructions = "layerInstructions";

	private static readonly IntPtr selLayerInstructionsHandle = Selector.GetHandle("layerInstructions");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBackgroundColor_ = "setBackgroundColor:";

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetEnablePostProcessing_ = "setEnablePostProcessing:";

	private static readonly IntPtr selSetEnablePostProcessing_Handle = Selector.GetHandle("setEnablePostProcessing:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLayerInstructions_ = "setLayerInstructions:";

	private static readonly IntPtr selSetLayerInstructions_Handle = Selector.GetHandle("setLayerInstructions:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTimeRange_ = "setTimeRange:";

	private static readonly IntPtr selSetTimeRange_Handle = Selector.GetHandle("setTimeRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTimeRange = "timeRange";

	private static readonly IntPtr selTimeRangeHandle = Selector.GetHandle("timeRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selVideoCompositionInstruction = "videoCompositionInstruction";

	private static readonly IntPtr selVideoCompositionInstructionHandle = Selector.GetHandle("videoCompositionInstruction");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("AVMutableVideoCompositionInstruction");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override CGColor? BackgroundColor
	{
		[Export("backgroundColor", ArgumentSemantic.Retain)]
		get
		{
			IntPtr intPtr = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle) : Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			return (intPtr == IntPtr.Zero) ? null : new CGColor(intPtr);
		}
		[Export("setBackgroundColor:", ArgumentSemantic.Retain)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, (value == null) ? IntPtr.Zero : value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override bool EnablePostProcessing
	{
		[Export("enablePostProcessing")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEnablePostProcessingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEnablePostProcessingHandle);
		}
		[Export("setEnablePostProcessing:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnablePostProcessing_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnablePostProcessing_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override AVVideoCompositionLayerInstruction[] LayerInstructions
	{
		[Export("layerInstructions", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<AVVideoCompositionLayerInstruction>(Messaging.IntPtr_objc_msgSend(base.Handle, selLayerInstructionsHandle));
			}
			return NSArray.ArrayFromHandle<AVVideoCompositionLayerInstruction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayerInstructionsHandle));
		}
		[Export("setLayerInstructions:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLayerInstructions_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLayerInstructions_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public override CMTimeRange TimeRange
	{
		[Export("timeRange", ArgumentSemantic.Assign)]
		get
		{
			CMTimeRange retval;
			if (base.IsDirectBinding)
			{
				Messaging.CMTimeRange_objc_msgSend_stret(out retval, base.Handle, selTimeRangeHandle);
			}
			else
			{
				Messaging.CMTimeRange_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTimeRangeHandle);
			}
			return retval;
		}
		[Export("setTimeRange:", ArgumentSemantic.Assign)]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTimeRange(base.Handle, selSetTimeRange_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTimeRange(base.SuperHandle, selSetTimeRange_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMutableVideoCompositionInstruction()
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
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVMutableVideoCompositionInstruction(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected AVMutableVideoCompositionInstruction(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal AVMutableVideoCompositionInstruction(IntPtr handle)
		: base(handle)
	{
	}

	[Export("videoCompositionInstruction")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static AVVideoCompositionInstruction Create()
	{
		return Runtime.GetNSObject<AVVideoCompositionInstruction>(Messaging.IntPtr_objc_msgSend(class_ptr, selVideoCompositionInstructionHandle));
	}
}
