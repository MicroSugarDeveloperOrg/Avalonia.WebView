using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSPasteboardWriting", false)]
[Model]
public class NSPasteboardWriting : NSObject, INSPasteboardWriting, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPasteboardWriting()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSPasteboardWriting(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPasteboardWriting(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("pasteboardPropertyListForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetPasteboardPropertyListForType(string type)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("writableTypesForPasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetWritableTypesForPasteboard(NSPasteboard pasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("writingOptionsForType:pasteboard:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPasteboardWritingOptions GetWritingOptionsForType(string type, NSPasteboard pasteboard)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
