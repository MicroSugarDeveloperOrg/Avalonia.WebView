using System;
using Foundation;
using ObjCRuntime;

namespace Photos;

internal sealed class PHPhotoLibraryChangeObserverWrapper : BaseWrapper, IPHPhotoLibraryChangeObserver, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public PHPhotoLibraryChangeObserverWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("photoLibraryDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PhotoLibraryDidChange(PHChange changeInstance)
	{
		if (changeInstance == null)
		{
			throw new ArgumentNullException("changeInstance");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("photoLibraryDidChange:"), changeInstance.Handle);
	}
}
