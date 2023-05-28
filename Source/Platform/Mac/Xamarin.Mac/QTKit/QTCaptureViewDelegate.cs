using System;
using System.ComponentModel;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace QTKit;

[Protocol(IsInformal = true)]
[Register("QTCaptureView_Delegate", false)]
[Model]
public class QTCaptureViewDelegate : NSObject, IQTCaptureViewDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public QTCaptureViewDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QTCaptureViewDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QTCaptureViewDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("view:willDisplayImage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIImage WillDisplayImage(QTCaptureView view, CIImage image)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
