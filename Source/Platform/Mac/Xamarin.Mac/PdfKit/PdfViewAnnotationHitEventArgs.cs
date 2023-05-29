using System;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

public class PdfViewAnnotationHitEventArgs : NSNotificationEventArgs
{
	private static IntPtr k0;

	public PdfAnnotation AnnotationHit
	{
		get
		{
			if (k0 == IntPtr.Zero)
			{
				k0 = Dlfcn.GetIntPtr(Libraries.PdfKit.Handle, "PDFAnnotationHit");
			}
			IntPtr intPtr = base.Notification.UserInfo.LowlevelObjectForKey(k0);
			if (intPtr == IntPtr.Zero)
			{
				return null;
			}
			return (PdfAnnotation)Runtime.GetNSObject(intPtr);
		}
	}

	public PdfViewAnnotationHitEventArgs(NSNotification notification)
		: base(notification)
	{
	}
}
