using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

internal sealed class IKImageEditPanelDataSourceWrapper : BaseWrapper, IIKImageEditPanelDataSource, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public CGImage Image
	{
		[Export("image")]
		get
		{
			IntPtr intPtr = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("image"));
			return (intPtr == IntPtr.Zero) ? null : new CGImage(intPtr);
		}
	}

	[Preserve(Conditional = true)]
	public IKImageEditPanelDataSourceWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("setImage:imageProperties:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetImageAndProperties(CGImage image, NSDictionary metaData)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (metaData == null)
		{
			throw new ArgumentNullException("metaData");
		}
		Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("setImage:imageProperties:"), image.Handle, metaData.Handle);
	}
}
