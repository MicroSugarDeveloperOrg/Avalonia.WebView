using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AVFoundation;

[Register("AVAudioMix", true)]
public class AVAudioMix : NSObject
{
	private static readonly IntPtr selInputParametersHandle = Selector.GetHandle("inputParameters");

	private static readonly IntPtr class_ptr = Class.GetHandle("AVAudioMix");

	private object __mt_InputParameters_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual AVAudioMixInputParameters[] InputParameters
	{
		[Export("inputParameters", ArgumentSemantic.Copy)]
		get
		{
			return (AVAudioMixInputParameters[])(__mt_InputParameters_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<AVAudioMixInputParameters>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputParametersHandle)) : NSArray.ArrayFromHandle<AVAudioMixInputParameters>(Messaging.IntPtr_objc_msgSend(base.Handle, selInputParametersHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public AVAudioMix()
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
	public AVAudioMix(NSCoder coder)
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
	public AVAudioMix(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public AVAudioMix(IntPtr handle)
		: base(handle)
	{
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
