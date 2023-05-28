using System;
using Foundation;
using ObjCRuntime;

namespace QuickLookUI;

internal sealed class QLPreviewPanelDataSourceWrapper : BaseWrapper, IQLPreviewPanelDataSource, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public QLPreviewPanelDataSourceWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("numberOfPreviewItemsInPreviewPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint NumberOfPreviewItemsInPreviewPanel(QLPreviewPanel panel)
	{
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		return Messaging.nint_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("numberOfPreviewItemsInPreviewPanel:"), panel.Handle);
	}

	[Export("previewPanel:previewItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IQLPreviewItem PreviewItemAtIndex(QLPreviewPanel panel, nint index)
	{
		if (panel == null)
		{
			throw new ArgumentNullException("panel");
		}
		return Runtime.GetNSObject<QLPreviewItem>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(base.Handle, Selector.GetHandle("previewPanel:previewItemAtIndex:"), panel.Handle, index));
	}
}
