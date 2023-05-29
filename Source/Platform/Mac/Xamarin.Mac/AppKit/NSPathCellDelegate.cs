using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPathCellDelegate", true)]
[Model]
public class NSPathCellDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPathCellDelegate()
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
	public NSPathCellDelegate(NSCoder coder)
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
	public NSPathCellDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPathCellDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("pathCell:willDisplayOpenPanel:")]
	public virtual void WillDisplayOpenPanel(NSPathCell pathCell, NSOpenPanel openPanel)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pathCell:willPopUpMenu:")]
	public virtual void WillPopupMenu(NSPathCell pathCell, NSMenu menu)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
