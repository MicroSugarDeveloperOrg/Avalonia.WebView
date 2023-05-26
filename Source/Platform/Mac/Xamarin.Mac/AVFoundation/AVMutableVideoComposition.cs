using System;
using System.ComponentModel;
using CoreGraphics;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableVideoComposition", true)]
public class AVMutableVideoComposition : AVVideoComposition
{
	private static readonly IntPtr selFrameDurationHandle = Selector.GetHandle("frameDuration");

	private static readonly IntPtr selSetFrameDuration_Handle = Selector.GetHandle("setFrameDuration:");

	private static readonly IntPtr selRenderSizeHandle = Selector.GetHandle("renderSize");

	private static readonly IntPtr selSetRenderSize_Handle = Selector.GetHandle("setRenderSize:");

	private static readonly IntPtr selInstructionsHandle = Selector.GetHandle("instructions");

	private static readonly IntPtr selSetInstructions_Handle = Selector.GetHandle("setInstructions:");

	private static readonly IntPtr selAnimationToolHandle = Selector.GetHandle("animationTool");

	private static readonly IntPtr selSetAnimationTool_Handle = Selector.GetHandle("setAnimationTool:");

	private static readonly IntPtr selVideoCompositionHandle = Selector.GetHandle("videoComposition");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVMutableVideoComposition");

	private object __mt_Instructions_var;

	private object __mt_AnimationTool_var;

	public override IntPtr ClassHandle => class_ptr;

	public new virtual CMTime FrameDuration
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
		[Export("setFrameDuration:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CMTime(base.Handle, selSetFrameDuration_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CMTime(base.SuperHandle, selSetFrameDuration_Handle, value);
			}
		}
	}

	public new virtual CGSize RenderSize
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
		[Export("setRenderSize:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_CGSize(base.Handle, selSetRenderSize_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_CGSize(base.SuperHandle, selSetRenderSize_Handle, value);
			}
		}
	}

	public new virtual AVVideoCompositionInstruction[] Instructions
	{
		[Export("instructions", ArgumentSemantic.Copy)]
		get
		{
			return (AVVideoCompositionInstruction[])(__mt_Instructions_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVVideoCompositionInstruction>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInstructionsHandle)) : NSArray.ArrayFromHandle<AVVideoCompositionInstruction>(Messaging.IntPtr_objc_msgSend(base.Handle, selInstructionsHandle))));
		}
		[Export("setInstructions:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInstructions_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInstructions_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_Instructions_var = value;
		}
	}

	public new virtual AVVideoCompositionCoreAnimationTool AnimationTool
	{
		[Export("animationTool")]
		get
		{
			return (AVVideoCompositionCoreAnimationTool)(__mt_AnimationTool_var = ((!IsDirectBinding) ? ((AVVideoCompositionCoreAnimationTool)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnimationToolHandle))) : ((AVVideoCompositionCoreAnimationTool)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAnimationToolHandle)))));
		}
		[Export("setAnimationTool:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAnimationTool_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAnimationTool_Handle, value.Handle);
			}
			__mt_AnimationTool_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMutableVideoComposition()
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
	public AVMutableVideoComposition(NSCoder coder)
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
	public AVMutableVideoComposition(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVMutableVideoComposition(IntPtr handle)
		: base(handle)
	{
	}

	[Export("videoComposition")]
	public static AVMutableVideoComposition Create()
	{
		return (AVMutableVideoComposition)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selVideoCompositionHandle));
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
