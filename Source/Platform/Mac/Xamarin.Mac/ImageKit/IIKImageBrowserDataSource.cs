using AppKit;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace ImageKit;

[Protocol(Name = "IKImageBrowserDataSource", WrapperType = typeof(IKImageBrowserDataSourceWrapper), IsInformal = true)]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "ItemCount", Selector = "numberOfItemsInImageBrowser:", ReturnType = typeof(nint), ParameterType = new Type[] { typeof(IKImageBrowserView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetItem", Selector = "imageBrowser:itemAtIndex:", ReturnType = typeof(IIKImageBrowserItem), ParameterType = new Type[]
{
	typeof(IKImageBrowserView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoveItems", Selector = "imageBrowser:removeItemsAtIndexes:", ParameterType = new Type[]
{
	typeof(IKImageBrowserView),
	typeof(NSIndexSet)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MoveItems", Selector = "imageBrowser:moveItemsAtIndexes:toIndex:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(IKImageBrowserView),
	typeof(NSIndexSet),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WriteItemsToPasteboard", Selector = "imageBrowser:writeItemsAtIndexes:toPasteboard:", ReturnType = typeof(nint), ParameterType = new Type[]
{
	typeof(IKImageBrowserView),
	typeof(NSIndexSet),
	typeof(NSPasteboard)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GroupCount", Selector = "numberOfGroupsInImageBrowser:", ReturnType = typeof(nint), ParameterType = new Type[] { typeof(IKImageBrowserView) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetGroup", Selector = "imageBrowser:groupAtIndex:", ReturnType = typeof(NSDictionary), ParameterType = new Type[]
{
	typeof(IKImageBrowserView),
	typeof(nint)
}, ParameterByRef = new bool[] { false, false })]
public interface IIKImageBrowserDataSource : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("numberOfItemsInImageBrowser:")]
	[Preserve(Conditional = true)]
	nint ItemCount(IKImageBrowserView aBrowser);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("imageBrowser:itemAtIndex:")]
	[Preserve(Conditional = true)]
	IIKImageBrowserItem GetItem(IKImageBrowserView aBrowser, nint index);
}
