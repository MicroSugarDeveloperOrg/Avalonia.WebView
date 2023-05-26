using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPasteboardReading", true)]
[Model]
public abstract class NSPasteboardReading : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPasteboardReading()
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
	public NSPasteboardReading(NSCoder coder)
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
	public NSPasteboardReading(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPasteboardReading(IntPtr handle)
		: base(handle)
	{
	}

	[Export("readableTypesForPasteboard:")]
	public abstract string[] GetReadableTypesForPasteboard(NSPasteboard pasteboard);

	[Export("readingOptionsForType:pasteboard:")]
	public abstract NSPasteboardReadingOptions GetReadingOptionsForType(string type, NSPasteboard pasteboard);

	[Export("initWithPasteboardPropertyList:ofType:")]
	public abstract NSObject InitWithPasteboardPropertyList(NSObject propertyList, string type);
}
