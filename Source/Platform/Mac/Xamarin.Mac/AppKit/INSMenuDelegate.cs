using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSMenuDelegate", WrapperType = typeof(NSMenuDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "NeedsUpdate", Selector = "menuNeedsUpdate:", ParameterType = new Type[] { typeof(NSMenu) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MenuItemCount", Selector = "numberOfItemsInMenu:", ReturnType = typeof(nint), ParameterType = new Type[] { typeof(NSMenu) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "UpdateItem", Selector = "menu:updateItem:atIndex:shouldCancel:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSMenu),
	typeof(NSMenuItem),
	typeof(nint),
	typeof(bool)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "HasKeyEquivalentForEvent", Selector = "menuHasKeyEquivalent:forEvent:target:action:", ReturnType = typeof(bool), ParameterType = new Type[]
{
	typeof(NSMenu),
	typeof(NSEvent),
	typeof(NSObject),
	typeof(Selector)
}, ParameterByRef = new bool[] { false, false, false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MenuWillOpen", Selector = "menuWillOpen:", ParameterType = new Type[] { typeof(NSMenu) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "MenuDidClose", Selector = "menuDidClose:", ParameterType = new Type[] { typeof(NSMenu) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "MenuWillHighlightItem", Selector = "menu:willHighlightItem:", ParameterType = new Type[]
{
	typeof(NSMenu),
	typeof(NSMenuItem)
}, ParameterByRef = new bool[] { false, false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConfinementRectForMenu", Selector = "confinementRectForMenu:onScreen:", ReturnType = typeof(CGRect), ParameterType = new Type[]
{
	typeof(NSMenu),
	typeof(NSScreen)
}, ParameterByRef = new bool[] { false, false })]
public interface INSMenuDelegate : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("menu:willHighlightItem:")]
	[Preserve(Conditional = true)]
	void MenuWillHighlightItem(NSMenu menu, NSMenuItem item);
}
