using System;
using AppKit;
using Foundation;
using ObjCRuntime;

namespace FinderSync;

[Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
[Protocol(Name = "FIFinderSync", WrapperType = typeof(FIFinderSyncProtocolWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetMenu", Selector = "menuForMenuKind:", ReturnType = typeof(NSMenu), ParameterType = new Type[] { typeof(FIMenuKind) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "BeginObservingDirectory", Selector = "beginObservingDirectoryAtURL:", ParameterType = new Type[] { typeof(NSUrl) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "EndObservingDirectory", Selector = "endObservingDirectoryAtURL:", ParameterType = new Type[] { typeof(NSUrl) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestBadgeIdentifier", Selector = "requestBadgeIdentifierForURL:", ParameterType = new Type[] { typeof(NSUrl) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SupportedServiceNames", Selector = "supportedServiceNamesForItemWithURL:", ReturnType = typeof(string[]), ParameterType = new Type[] { typeof(NSUrl) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetValues", Selector = "valuesForAttributes:forItemWithURL:completion:", ParameterType = new Type[]
{
	typeof(string[]),
	typeof(NSUrl),
	typeof(GetValuesCompletionHandler)
}, ParameterByRef = new bool[] { false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	typeof(Trampolines.NIDGetValuesCompletionHandler)
})]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ToolbarItemName", Selector = "toolbarItemName", PropertyType = typeof(string), GetterSelector = "toolbarItemName", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ToolbarItemImage", Selector = "toolbarItemImage", PropertyType = typeof(NSImage), GetterSelector = "toolbarItemImage", ArgumentSemantic = ArgumentSemantic.Copy)]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "ToolbarItemToolTip", Selector = "toolbarItemToolTip", PropertyType = typeof(string), GetterSelector = "toolbarItemToolTip", ArgumentSemantic = ArgumentSemantic.None)]
public interface IFIFinderSyncProtocol : INativeObject, IDisposable
{
}
