using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPasteboardItemDataProvider", true)]
[Model]
public abstract class NSPasteboardItemDataProvider : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPasteboardItemDataProvider()
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
	public NSPasteboardItemDataProvider(NSCoder coder)
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
	public NSPasteboardItemDataProvider(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPasteboardItemDataProvider(IntPtr handle)
		: base(handle)
	{
	}

	[Export("pasteboard:item:provideDataForType:")]
	public abstract void ProvideDataForType(NSPasteboard pasteboard, NSPasteboardItem item, string type);

	[Export("pasteboardFinishedWithDataProvider:")]
	public abstract void FinishedWithDataProvider(NSPasteboard pasteboard);
}
