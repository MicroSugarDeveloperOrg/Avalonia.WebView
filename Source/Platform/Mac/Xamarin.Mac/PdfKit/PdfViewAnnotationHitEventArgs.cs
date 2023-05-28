using System;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

public class PdfViewAnnotationHitEventArgs : NSNotificationEventArgs
{
	[Field("PDFAnnotationHit", "PdfKit")]
	private static IntPtr k0;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public PdfAnnotation AnnotationHit
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.PdfKit.Handle, "PDFAnnotationHit");
			}
			IntPtr ptr = base.Notification.UserInfo?.LowlevelObjectForKey(k0) ?? IntPtr.Zero;
			return Runtime.GetNSObject<PdfAnnotation>(ptr);
		}
	}

	public PdfViewAnnotationHitEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
