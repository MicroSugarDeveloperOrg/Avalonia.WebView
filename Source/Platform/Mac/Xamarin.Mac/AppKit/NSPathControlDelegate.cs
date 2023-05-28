using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSPathControlDelegate", false)]
[Model]
public class NSPathControlDelegate : NSObject, INSPathControlDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPathControlDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSPathControlDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPathControlDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("pathControl:acceptDrop:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AcceptDrop(NSPathControl pathControl, NSDraggingInfo info)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pathControl:shouldDragItem:withPasteboard:")]
	[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldDragItem(NSPathControl pathControl, NSPathControlItem pathItem, NSPasteboard pasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pathControl:shouldDragPathComponentCell:withPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ShouldDragPathComponentCell(NSPathControl pathControl, NSPathComponentCell pathComponentCell, NSPasteboard pasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pathControl:validateDrop:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDragOperation ValidateDrop(NSPathControl pathControl, NSDraggingInfo info)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pathControl:willDisplayOpenPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillDisplayOpenPanel(NSPathControl pathControl, NSOpenPanel openPanel)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pathControl:willPopUpMenu:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WillPopUpMenu(NSPathControl pathControl, NSMenu menu)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
