using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSOpenSavePanelDelegate", false)]
[Model]
public class NSOpenSavePanelDelegate : NSObject, INSOpenSavePanelDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSOpenSavePanelDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSOpenSavePanelDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSOpenSavePanelDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("panel:compareFilename:with:caseSensitive:")]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "This method does not control sorting order.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSComparisonResult CompareFilenames(NSSavePanel panel, string name1, string name2, bool caseSensitive)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panel:didChangeToDirectoryURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DidChangeToDirectory(NSSavePanel panel, NSUrl newDirectoryUrl)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panel:directoryDidChange:")]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use DidChangeToDirectory instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DirectoryDidChange(NSSavePanel panel, string path)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panel:isValidFilename:")]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use ValidateUrl instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsValidFilename(NSSavePanel panel, string fileName)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panelSelectionDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectionDidChange(NSSavePanel panel)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panel:shouldEnableURL:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldEnableUrl(NSSavePanel panel, NSUrl url)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panel:shouldShowFilename:")]
	[Deprecated(PlatformName.MacOSX, 10, 6, PlatformArchitecture.All, "Use ShouldEnableUrl instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldShowFilename(NSSavePanel panel, string filename)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panel:userEnteredFilename:confirmed:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string UserEnteredFilename(NSSavePanel panel, string filename, bool confirmed)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panel:validateURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ValidateUrl(NSSavePanel panel, NSUrl url, out NSError? outError)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("panel:willExpand:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillExpand(NSSavePanel panel, bool expanding)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
