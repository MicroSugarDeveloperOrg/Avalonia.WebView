using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace NotificationCenter;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NCWidgetListViewDelegate", WrapperType = typeof(NCWidgetListViewDelegateWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetViewControllerForRow", Selector = "widgetList:viewControllerForRow:", ReturnType = typeof(NSViewController), ParameterType = new Type[]
{
	typeof(NCWidgetListViewController),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PerformAddAction", Selector = "widgetListPerformAddAction:", ParameterType = new Type[] { typeof(NCWidgetListViewController) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldReorderRow", Selector = "widgetList:shouldReorderRow:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NCWidgetListViewController),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidReorderRow", Selector = "widgetList:didReorderRow:toRow:", ParameterType = new Type[]
{
	typeof(NCWidgetListViewController),
	typeof(nuint),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ShouldRemoveRow", Selector = "widgetList:shouldRemoveRow:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NCWidgetListViewController),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveRow", Selector = "widgetList:didRemoveRow:", ParameterType = new Type[]
{
	typeof(NCWidgetListViewController),
	typeof(nuint)
}, ParameterByRef = new bool[] { false, false })]
public interface INCWidgetListViewDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("widgetList:viewControllerForRow:")]
	[Preserve(Conditional = true)]
	NSViewController GetViewControllerForRow(NCWidgetListViewController list, nuint row);
}
