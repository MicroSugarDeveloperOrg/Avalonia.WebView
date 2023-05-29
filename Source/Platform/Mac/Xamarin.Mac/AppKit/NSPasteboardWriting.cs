using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPasteboardWriting", true)]
[Model]
public class NSPasteboardWriting : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPasteboardWriting()
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
	public NSPasteboardWriting(NSCoder coder)
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
	public NSPasteboardWriting(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPasteboardWriting(IntPtr handle)
		: base(handle)
	{
	}

	[Export("writableTypesForPasteboard:")]
	public virtual string[] GetWritableTypesForPasteboard(NSPasteboard pasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("writingOptionsForType:pasteboard:")]
	public virtual NSPasteboardWritingOptions GetWritingOptionsForType(string type, NSPasteboard pasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("pasteboardPropertyListForType:")]
	public virtual NSObject GetPasteboardPropertyListForType(string type)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
