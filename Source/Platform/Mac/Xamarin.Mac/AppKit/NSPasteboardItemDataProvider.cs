using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSPasteboardItemDataProvider", false)]
[Model]
public abstract class NSPasteboardItemDataProvider : NSObject, INSPasteboardItemDataProvider, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSPasteboardItemDataProvider()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSPasteboardItemDataProvider(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPasteboardItemDataProvider(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("pasteboardFinishedWithDataProvider:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void FinishedWithDataProvider(NSPasteboard pasteboard);

	[Export("pasteboard:item:provideDataForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract void ProvideDataForType(NSPasteboard pasteboard, NSPasteboardItem item, string type);
}
