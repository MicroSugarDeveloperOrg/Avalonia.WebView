using System;
using System.ComponentModel;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKImageBrowserDelegate", true)]
[Model]
public class IKImageBrowserDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKImageBrowserDelegate()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public IKImageBrowserDelegate(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKImageBrowserDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKImageBrowserDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("imageBrowserSelectionDidChange:")]
	public virtual void SelectionDidChange(IKImageBrowserView browser)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("imageBrowser:cellWasDoubleClickedAtIndex:")]
	public virtual void CellWasDoubleClicked(IKImageBrowserView browser, int index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("imageBrowser:cellWasRightClickedAtIndex:withEvent:")]
	public virtual void CellWasRightClicked(IKImageBrowserView browser, int index, NSEvent nsevent)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("imageBrowser:backgroundWasRightClickedWithEvent:")]
	public virtual void BackgroundWasRightClicked(IKImageBrowserView browser, NSEvent nsevent)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
