using System;
using Foundation;
using ObjCRuntime;

namespace SafariServices;

[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
[Protocol(Name = "SFSafariExtensionHandling", WrapperType = typeof(SFSafariExtensionHandlingWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MessageReceived", Selector = "messageReceivedWithName:fromPage:userInfo:", ParameterType = new Type[]
{
	typeof(string),
	typeof(SFSafariPage),
	typeof(NSDictionary)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ToolbarItemClicked", Selector = "toolbarItemClickedInWindow:", ParameterType = new Type[] { typeof(SFSafariWindow) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateToolbarItem", Selector = "validateToolbarItemInWindow:validationHandler:", ParameterType = new Type[]
{
	typeof(SFSafariWindow),
	typeof(Action<bool, NSString>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity2V82)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContextMenuItemSelected", Selector = "contextMenuItemSelectedWithCommand:inPage:userInfo:", ParameterType = new Type[]
{
	typeof(string),
	typeof(SFSafariPage),
	typeof(NSDictionary)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PopoverWillShow", Selector = "popoverWillShowInWindow:", ParameterType = new Type[] { typeof(SFSafariWindow) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "PopoverDidClose", Selector = "popoverDidCloseInWindow:", ParameterType = new Type[] { typeof(SFSafariWindow) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ValidateContextMenuItem", Selector = "validateContextMenuItemWithCommand:inPage:userInfo:validationHandler:", ParameterType = new Type[]
{
	typeof(string),
	typeof(SFSafariPage),
	typeof(NSDictionary<NSString, NSObject>),
	typeof(SFExtensionValidationHandler)
}, ParameterByRef = new bool[] { false, false, false, false }, ParameterBlockProxy = new Type[]
{
	null,
	null,
	null,
	typeof(Trampolines.NIDSFExtensionValidationHandler)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MessageReceivedFromContainingApp", Selector = "messageReceivedFromContainingAppWithName:userInfo:", ParameterType = new Type[]
{
	typeof(string),
	typeof(NSDictionary<NSString, NSObject>)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AdditionalRequestHeaders", Selector = "additionalRequestHeadersForURL:completionHandler:", ParameterType = new Type[]
{
	typeof(NSUrl),
	typeof(Action<NSDictionary<NSString, NSString>>)
}, ParameterByRef = new bool[] { false, false }, ParameterBlockProxy = new Type[]
{
	null,
	typeof(Trampolines.NIDActionArity1V77)
})]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ContentBlocker", Selector = "contentBlockerWithIdentifier:blockedResourcesWithURLs:onPage:", ParameterType = new Type[]
{
	typeof(string),
	typeof(NSUrl[]),
	typeof(SFSafariPage)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillNavigate", Selector = "page:willNavigateToURL:", ParameterType = new Type[]
{
	typeof(SFSafariPage),
	typeof(NSUrl)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = true, IsStatic = false, Name = "PopoverViewController", Selector = "popoverViewController", PropertyType = typeof(SFSafariExtensionViewController), GetterSelector = "popoverViewController", ArgumentSemantic = ArgumentSemantic.None)]
public interface ISFSafariExtensionHandling : INativeObject, IDisposable
{
}
