using System;
using Foundation;
using ObjCRuntime;

namespace Photos;

internal sealed class PHPhotoLibraryAvailabilityObserverWrapper : BaseWrapper, IPHPhotoLibraryAvailabilityObserver, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public PHPhotoLibraryAvailabilityObserverWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("photoLibraryDidBecomeUnavailable:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PhotoLibraryDidBecomeUnavailable(PHPhotoLibrary photoLibrary)
	{
		if (photoLibrary == null)
		{
			throw new ArgumentNullException("photoLibrary");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("photoLibraryDidBecomeUnavailable:"), photoLibrary.Handle);
	}
}
