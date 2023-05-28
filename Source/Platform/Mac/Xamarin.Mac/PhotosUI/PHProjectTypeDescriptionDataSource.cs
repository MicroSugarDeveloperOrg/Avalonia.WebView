using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace PhotosUI;

[Protocol]
[Register("PHProjectTypeDescriptionDataSource", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
public abstract class PHProjectTypeDescriptionDataSource : NSObject, IPHProjectTypeDescriptionDataSource, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected PHProjectTypeDescriptionDataSource()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected PHProjectTypeDescriptionDataSource(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal PHProjectTypeDescriptionDataSource(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("footerTextForSubtypesOfProjectType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSAttributedString? GetFooterTextForSubtypes(NSString projectType);

	[Export("subtypesForProjectType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract PHProjectTypeDescription[] GetSubtypes(NSString projectType);

	[Export("typeDescriptionForProjectType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract PHProjectTypeDescription? GetTypeDescription(NSString projectType);

	[Export("extensionWillDiscardDataSource")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillDiscardDataSource()
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
