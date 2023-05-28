using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace SceneKit;

public static class SCNSceneExportDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSUrl? WriteImage(this ISCNSceneExportDelegate This, NSImage image, NSUrl documentUrl, NSUrl? originalImageUrl)
	{
		if (image == null)
		{
			throw new ArgumentNullException("image");
		}
		if (documentUrl == null)
		{
			throw new ArgumentNullException("documentUrl");
		}
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(This.Handle, Selector.GetHandle("writeImage:withSceneDocumentURL:originalImageURL:"), image.Handle, documentUrl.Handle, (originalImageUrl == null) ? IntPtr.Zero : originalImageUrl.Handle));
	}
}
