using System;
using System.ComponentModel;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVCaptureInputPort", true)]
public class AVCaptureInputPort : NSObject
{
	private static readonly IntPtr selMediaTypeHandle = Selector.GetHandle("mediaType");

	private static readonly IntPtr selFormatDescriptionHandle = Selector.GetHandle("formatDescription");

	private static readonly IntPtr selIsEnabledHandle = Selector.GetHandle("isEnabled");

	private static readonly IntPtr selSetEnabled_Handle = Selector.GetHandle("setEnabled:");

	private static readonly IntPtr selInputHandle = Selector.GetHandle("input");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVCaptureInputPort");

	private object __mt_Input_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string MediaType
	{
		[Export("mediaType")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selMediaTypeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMediaTypeHandle));
		}
	}

	public virtual CMFormatDescription FormatDescription
	{
		[Export("formatDescription")]
		get
		{
			if (IsDirectBinding)
			{
				return new CMFormatDescription(Messaging.IntPtr_objc_msgSend(base.Handle, selFormatDescriptionHandle));
			}
			return new CMFormatDescription(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormatDescriptionHandle));
		}
	}

	public virtual bool Enabled
	{
		[Export("isEnabled")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEnabledHandle);
		}
		[Export("setEnabled:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetEnabled_Handle, value);
			}
		}
	}

	public virtual AVCaptureInput Input
	{
		[Export("input")]
		get
		{
			return (AVCaptureInput)(__mt_Input_var = ((!IsDirectBinding) ? ((AVCaptureInput)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputHandle))) : ((AVCaptureInput)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInputHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVCaptureInputPort()
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
	public AVCaptureInputPort(NSCoder coder)
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
	public AVCaptureInputPort(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVCaptureInputPort(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Input_var = null;
		}
	}
}
