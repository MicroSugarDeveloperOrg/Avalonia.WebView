using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace QuickLookUI;

[Protocol]
[Register("QLPreviewPanelDataSource", false)]
[Model]
public abstract class QLPreviewPanelDataSource : NSObject, IQLPreviewPanelDataSource, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected QLPreviewPanelDataSource()
		: base(NSObjectFlag.Empty)
	{
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected QLPreviewPanelDataSource(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal QLPreviewPanelDataSource(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("numberOfPreviewItemsInPreviewPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract nint NumberOfPreviewItemsInPreviewPanel(QLPreviewPanel panel);

	[Export("previewPanel:previewItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract IQLPreviewItem PreviewItemAtIndex(QLPreviewPanel panel, nint index);
}
