using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPathControlDelegate", true)]
[Model]
public abstract class NSPathControlDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPathControlDelegate()
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
	public NSPathControlDelegate(NSCoder coder)
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
	public NSPathControlDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPathControlDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("pathControl:shouldDragPathComponentCell:withPasteboard:")]
	public abstract bool ShouldDragPathComponentCell(NSPathControl pathControl, NSPathComponentCell pathComponentCell, NSPasteboard pasteboard);

	[Export("pathControl:validateDrop:")]
	public abstract NSDragOperation ValidateDrop(NSPathControl pathControl, NSDraggingInfo info);

	[Export("pathControl:acceptDrop:")]
	public abstract bool AcceptDrop(NSPathControl pathControl, NSDraggingInfo info);

	[Export("pathControl:willDisplayOpenPanel:")]
	public abstract void WillDisplayOpenPanel(NSPathControl pathControl, NSOpenPanel openPanel);

	[Export("pathControl:willPopUpMenu:")]
	public abstract void WillPopUpMenu(NSPathControl pathControl, NSMenu menu);
}
