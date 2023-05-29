using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVVideoCompositionInstruction", true)]
public class AVVideoCompositionInstruction : NSObject
{
	private static readonly IntPtr selTimeRangeHandle = Selector.GetHandle("timeRange");

	private static readonly IntPtr selBackgroundColorHandle = Selector.GetHandle("backgroundColor");

	private static readonly IntPtr selSetBackgroundColor_Handle = Selector.GetHandle("setBackgroundColor:");

	private static readonly IntPtr selLayerInstructionsHandle = Selector.GetHandle("layerInstructions");

	private static readonly IntPtr selEnablePostProcessingHandle = Selector.GetHandle("enablePostProcessing");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVVideoCompositionInstruction");

	private object __mt_LayerInstructions_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CMTimeRange TimeRange
	{
		[Export("timeRange")]
		get
		{
			CMTimeRange retval;
			if (IsDirectBinding)
			{
				Messaging.CMTimeRange_objc_msgSend_stret(out retval, base.Handle, selTimeRangeHandle);
			}
			else
			{
				Messaging.CMTimeRange_objc_msgSendSuper_stret(out retval, base.SuperHandle, selTimeRangeHandle);
			}
			return retval;
		}
	}

	public virtual CGColor BackgroundColor
	{
		[Export("backgroundColor")]
		get
		{
			if (IsDirectBinding)
			{
				return new CGColor(Messaging.IntPtr_objc_msgSend(base.Handle, selBackgroundColorHandle));
			}
			return new CGColor(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBackgroundColorHandle));
		}
		[Export("setBackgroundColor:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBackgroundColor_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBackgroundColor_Handle, value.Handle);
			}
		}
	}

	public virtual AVVideoCompositionLayerInstruction[] LayerInstructions
	{
		[Export("layerInstructions", ArgumentSemantic.Copy)]
		get
		{
			return (AVVideoCompositionLayerInstruction[])(__mt_LayerInstructions_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVVideoCompositionLayerInstruction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLayerInstructionsHandle)) : NSArray.ArrayFromHandle<AVVideoCompositionLayerInstruction>(Messaging.IntPtr_objc_msgSend(base.Handle, selLayerInstructionsHandle))));
		}
	}

	public virtual bool EnablePostProcessing
	{
		[Export("enablePostProcessing")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selEnablePostProcessingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selEnablePostProcessingHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVVideoCompositionInstruction()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public AVVideoCompositionInstruction(NSCoder coder)
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
	public AVVideoCompositionInstruction(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVVideoCompositionInstruction(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_LayerInstructions_var = null;
		}
	}
}
