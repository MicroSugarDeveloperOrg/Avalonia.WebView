using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ImageKit;

[Protocol(IsInformal = true)]
[Register("IKImageBrowserDelegate", false)]
[Model]
public class IKImageBrowserDelegate : NSObject, IIKImageBrowserDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKImageBrowserDelegate()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected IKImageBrowserDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKImageBrowserDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("imageBrowser:backgroundWasRightClickedWithEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BackgroundWasRightClicked(IKImageBrowserView browser, NSEvent nsevent)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("imageBrowser:cellWasDoubleClickedAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CellWasDoubleClicked(IKImageBrowserView browser, nint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("imageBrowser:cellWasRightClickedAtIndex:withEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CellWasRightClicked(IKImageBrowserView browser, nint index, NSEvent nsevent)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("imageBrowserSelectionDidChange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SelectionDidChange(IKImageBrowserView browser)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
