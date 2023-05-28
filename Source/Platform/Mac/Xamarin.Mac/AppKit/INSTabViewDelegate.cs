using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSTabViewDelegate", WrapperType = typeof(NSTabViewDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldSelectTabViewItem", Selector = "tabView:shouldSelectTabViewItem:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSTabView),
	typeof(NSTabViewItem)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillSelect", Selector = "tabView:willSelectTabViewItem:", ParameterType = new Type[]
{
	typeof(NSTabView),
	typeof(NSTabViewItem)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidSelect", Selector = "tabView:didSelectTabViewItem:", ParameterType = new Type[]
{
	typeof(NSTabView),
	typeof(NSTabViewItem)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "NumberOfItemsChanged", Selector = "tabViewDidChangeNumberOfTabViewItems:", ParameterType = new Type[] { typeof(NSTabView) }, ParameterByRef = new bool[] { false })]
public interface INSTabViewDelegate : INativeObject, IDisposable
{
}
