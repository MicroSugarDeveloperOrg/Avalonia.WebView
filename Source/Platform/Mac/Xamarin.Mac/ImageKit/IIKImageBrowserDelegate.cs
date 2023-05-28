using AppKit;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ImageKit;

[Protocol(Name = "IKImageBrowserDelegate", WrapperType = typeof(IKImageBrowserDelegateWrapper), IsInformal = true)]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectionDidChange", Selector = "imageBrowserSelectionDidChange:", ParameterType = new Type[] { typeof(IKImageBrowserView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CellWasDoubleClicked", Selector = "imageBrowser:cellWasDoubleClickedAtIndex:", ParameterType = new Type[]
{
	typeof(IKImageBrowserView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "CellWasRightClicked", Selector = "imageBrowser:cellWasRightClickedAtIndex:withEvent:", ParameterType = new Type[]
{
	typeof(IKImageBrowserView),
	typeof(nint),
	typeof(NSEvent)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "BackgroundWasRightClicked", Selector = "imageBrowser:backgroundWasRightClickedWithEvent:", ParameterType = new Type[]
{
	typeof(IKImageBrowserView),
	typeof(NSEvent)
}, ParameterByRef = new bool[] { false, false })]
public interface IIKImageBrowserDelegate : INativeObject, IDisposable
{
}
