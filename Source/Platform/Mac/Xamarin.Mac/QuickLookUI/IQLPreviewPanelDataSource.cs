using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace QuickLookUI;

[Protocol(Name = "QLPreviewPanelDataSource", WrapperType = typeof(QLPreviewPanelDataSourceWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "NumberOfPreviewItemsInPreviewPanel", Selector = "numberOfPreviewItemsInPreviewPanel:", ReturnType = typeof(nint), ParameterType = new Type[] { typeof(QLPreviewPanel) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "PreviewItemAtIndex", Selector = "previewPanel:previewItemAtIndex:", ReturnType = typeof(QLPreviewItem), ParameterType = new Type[]
{
	typeof(QLPreviewPanel),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
public interface IQLPreviewPanelDataSource : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("numberOfPreviewItemsInPreviewPanel:")]
	[Preserve(Conditional = true)]
	nint NumberOfPreviewItemsInPreviewPanel(QLPreviewPanel panel);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("previewPanel:previewItemAtIndex:")]
	[Preserve(Conditional = true)]
	IQLPreviewItem PreviewItemAtIndex(QLPreviewPanel panel, nint index);
}
