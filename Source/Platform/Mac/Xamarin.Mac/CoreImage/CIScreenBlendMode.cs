using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

public class CIScreenBlendMode : CIBlendFilter
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIScreenBlendMode()
		: base("CIScreenBlendMode")
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIScreenBlendMode(IntPtr handle)
		: base(handle)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CIScreenBlendMode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CIScreenBlendMode(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (coder == null)
		{
			throw new ArgumentNullException("coder");
		}
		InitializeHandle((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.GetHandle("initWithCoder:"), coder.Handle) : Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("initWithCoder:"), coder.Handle), "initWithCoder:");
	}
}
