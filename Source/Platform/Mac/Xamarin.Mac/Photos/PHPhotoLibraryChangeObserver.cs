using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Photos;

[Protocol]
[Register("PHPhotoLibraryChangeObserver", false)]
[Model]
[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public abstract class PHPhotoLibraryChangeObserver : NSObject, IPHPhotoLibraryChangeObserver, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected PHPhotoLibraryChangeObserver()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PHPhotoLibraryChangeObserver(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHPhotoLibraryChangeObserver(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("photoLibraryDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void PhotoLibraryDidChange(PHChange changeInstance);
}
