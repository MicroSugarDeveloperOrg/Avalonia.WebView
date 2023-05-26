using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSToolbarDelegate", true)]
[Model]
public abstract class NSToolbarDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSToolbarDelegate()
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
	public NSToolbarDelegate(NSCoder coder)
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
	public NSToolbarDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSToolbarDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:")]
	public abstract NSToolbarItem WillInsertItem(NSToolbar toolbar, string itemIdentifier, bool willBeInserted);

	[Export("toolbarDefaultItemIdentifiers:")]
	public abstract string[] DefaultItemIdentifiers(NSToolbar toolbar);

	[Export("toolbarAllowedItemIdentifiers:")]
	public abstract string[] AllowedItemIdentifiers(NSToolbar toolbar);

	[Export("toolbarSelectableItemIdentifiers:")]
	public abstract string[] SelectableItemIdentifiers(NSToolbar toolbar);

	[Export("toolbarWillAddItem:")]
	public abstract void WillAddItem(NSNotification notification);

	[Export("toolbarDidRemoveItem:")]
	public abstract void DidRemoveItem(NSNotification notification);
}
