using System;
using CoreImage;
using CoreMedia;
using Foundation;
using ObjCRuntime;

namespace Photos;

internal sealed class PHLivePhotoFrameWrapper : BaseWrapper, IPHLivePhotoFrame, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CIImage Image
	{
		[Export("image")]
		get
		{
			return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("image")));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CMTime Time
	{
		[Export("time")]
		get
		{
			Messaging.CMTime_objc_msgSend_stret(out var retval, base.Handle, Selector.GetHandle("time"));
			return retval;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PHLivePhotoFrameType Type
	{
		[Export("type")]
		get
		{
			return (PHLivePhotoFrameType)Messaging.Int64_objc_msgSend(base.Handle, Selector.GetHandle("type"));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nfloat RenderScale
	{
		[Export("renderScale")]
		get
		{
			return Messaging.nfloat_objc_msgSend(base.Handle, Selector.GetHandle("renderScale"));
		}
	}

	[Preserve(Conditional = true)]
	public PHLivePhotoFrameWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
