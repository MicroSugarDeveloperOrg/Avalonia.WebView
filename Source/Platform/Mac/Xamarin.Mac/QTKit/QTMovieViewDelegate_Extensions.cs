using System;
using CoreImage;
using ObjCRuntime;

namespace QTKit;

public static class QTMovieViewDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CIImage ViewWillDisplayImage(this IQTMovieViewDelegate This, QTMovieView view, CIImage image)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		return Runtime.GetNSObject<CIImage>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(This.Handle, Selector.GetHandle("view:willDisplayImage:"), view.Handle, image.Handle));
	}
}
