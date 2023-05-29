using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVVideoComposition", true)]
public class AVVideoComposition : NSObject
{
	private static readonly IntPtr selFrameDurationHandle = Selector.GetHandle("frameDuration");

	private static readonly IntPtr selRenderSizeHandle = Selector.GetHandle("renderSize");

	private static readonly IntPtr selInstructionsHandle = Selector.GetHandle("instructions");

	private static readonly IntPtr selAnimationToolHandle = Selector.GetHandle("animationTool");

	private static readonly IntPtr selIsValidForAssetTimeRangeValidationDelegate_Handle = Selector.GetHandle("isValidForAsset:timeRange:validationDelegate:");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVVideoComposition");

	private object __mt_Instructions_var;

	private object __mt_AnimationTool_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CMTime FrameDuration
	{
		[Export("frameDuration")]
		get
		{
			CMTime retval;
			if (IsDirectBinding)
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

	public virtual CGSize RenderSize
	{
		[Export("renderSize")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selRenderSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selRenderSizeHandle);
		}
	}

	public virtual AVVideoCompositionInstruction[] Instructions
	{
		[Export("instructions", ArgumentSemantic.Copy)]
		get
		{
			return (AVVideoCompositionInstruction[])(__mt_Instructions_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVVideoCompositionInstruction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInstructionsHandle)) : NSArray.ArrayFromHandle<AVVideoCompositionInstruction>(Messaging.IntPtr_objc_msgSend(base.Handle, selInstructionsHandle))));
		}
	}

	public virtual AVVideoCompositionCoreAnimationTool AnimationTool
	{
		[Export("animationTool", ArgumentSemantic.Retain)]
		get
		{
			return (AVVideoCompositionCoreAnimationTool)(__mt_AnimationTool_var = ((!IsDirectBinding) ? ((AVVideoCompositionCoreAnimationTool)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationToolHandle))) : ((AVVideoCompositionCoreAnimationTool)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationToolHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVVideoComposition()
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
	public AVVideoComposition(NSCoder coder)
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
	public AVVideoComposition(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVVideoComposition(IntPtr handle)
		: base(handle)
	{
	}

	[Export("isValidForAsset:timeRange:validationDelegate:")]
	public virtual bool IsValidForAsset(AVAsset asset, CMTimeRange timeRange, AVVideoCompositionValidationHandling validationDelegate)
	{
		if (asset == null)
		{
			throw new ArgumentNullException("asset");
		}
		if (validationDelegate == null)
		{
			throw new ArgumentNullException("validationDelegate");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_CMTimeRange_IntPtr(base.Handle, selIsValidForAssetTimeRangeValidationDelegate_Handle, asset.Handle, timeRange, validationDelegate.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_CMTimeRange_IntPtr(base.SuperHandle, selIsValidForAssetTimeRangeValidationDelegate_Handle, asset.Handle, timeRange, validationDelegate.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Instructions_var = null;
			__mt_AnimationTool_var = null;
		}
	}
}
