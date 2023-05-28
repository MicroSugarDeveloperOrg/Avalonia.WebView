using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSToolbarDelegate", WrapperType = typeof(NSToolbarDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillInsertItem", Selector = "toolbar:itemForItemIdentifier:willBeInsertedIntoToolbar:", ReturnType = typeof(NSToolbarItem), ParameterType = new Type[]
{
	typeof(NSToolbar),
	typeof(string),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DefaultItemIdentifiers", Selector = "toolbarDefaultItemIdentifiers:", ReturnType = typeof(string[]), ParameterType = new Type[] { typeof(NSToolbar) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "AllowedItemIdentifiers", Selector = "toolbarAllowedItemIdentifiers:", ReturnType = typeof(string[]), ParameterType = new Type[] { typeof(NSToolbar) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "SelectableItemIdentifiers", Selector = "toolbarSelectableItemIdentifiers:", ReturnType = typeof(string[]), ParameterType = new Type[] { typeof(NSToolbar) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "WillAddItem", Selector = "toolbarWillAddItem:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DidRemoveItem", Selector = "toolbarDidRemoveItem:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
public interface INSToolbarDelegate : INativeObject, IDisposable
{
}
