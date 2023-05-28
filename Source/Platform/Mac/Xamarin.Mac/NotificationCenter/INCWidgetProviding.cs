using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace NotificationCenter;

[Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "NCWidgetProviding", WrapperType = typeof(NCWidgetProvidingWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WidgetPerformUpdate", Selector = "widgetPerformUpdateWithCompletionHandler:", ParameterType = new Type[] { typeof(Action<NCUpdateResult>) }, ParameterByRef = new bool[] { false }, ParameterBlockProxy = new Type[] { typeof(Trampolines.NIDActionArity1V69) })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetWidgetMarginInsets", Selector = "widgetMarginInsetsForProposedMarginInsets:", ReturnType = typeof(NSEdgeInsets), ParameterType = new Type[] { typeof(NSEdgeInsets) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WidgetDidBeginEditing", Selector = "widgetDidBeginEditing")]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WidgetDidEndEditing", Selector = "widgetDidEndEditing")]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "WidgetAllowsEditing", Selector = "widgetAllowsEditing", PropertyType = typeof(bool), GetterSelector = "widgetAllowsEditing", ArgumentSemantic = ArgumentSemantic.None)]
public interface INCWidgetProviding : INativeObject, IDisposable
{
}
