using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVMutableAudioMix", true)]
public class AVMutableAudioMix : AVAudioMix
{
	private static readonly IntPtr selInputParametersHandle = Selector.GetHandle("inputParameters");

	private static readonly IntPtr selSetInputParameters_Handle = Selector.GetHandle("setInputParameters:");

	private static readonly IntPtr selAudioMixHandle = Selector.GetHandle("audioMix");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVMutableAudioMix");

	private object __mt_InputParameters_var;

	public override IntPtr ClassHandle => class_ptr;

	public new virtual AVAudioMixInputParameters[] InputParameters
	{
		[Export("inputParameters", ArgumentSemantic.Copy)]
		get
		{
			return (AVAudioMixInputParameters[])(__mt_InputParameters_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVAudioMixInputParameters>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputParametersHandle)) : NSArray.ArrayFromHandle<AVAudioMixInputParameters>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputParametersHandle))));
		}
		[Export("setInputParameters:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInputParameters_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInputParameters_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_InputParameters_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVMutableAudioMix()
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
	public AVMutableAudioMix(NSCoder coder)
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
	public AVMutableAudioMix(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVMutableAudioMix(IntPtr handle)
		: base(handle)
	{
	}

	[Export("audioMix")]
	public static AVMutableAudioMix Create()
	{
		return (AVMutableAudioMix)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selAudioMixHandle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_InputParameters_var = null;
		}
	}
}
