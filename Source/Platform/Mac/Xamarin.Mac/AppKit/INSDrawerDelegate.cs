using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Deprecated(PlatformName.MacOSX, 10, 13, PlatformArchitecture.None, "Use 'NSSplitViewController' instead.")]
[Protocol(Name = "NSDrawerDelegate", WrapperType = typeof(NSDrawerDelegateWrapper))]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawerDidClose", Selector = "drawerDidClose:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawerDidOpen", Selector = "drawerDidOpen:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawerShouldClose", Selector = "drawerShouldClose:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSDrawer) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawerShouldOpen", Selector = "drawerShouldOpen:", ReturnType = typeof(bool), ParameterType = new Type[] { typeof(NSDrawer) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawerWillClose", Selector = "drawerWillClose:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawerWillOpen", Selector = "drawerWillOpen:", ParameterType = new Type[] { typeof(NSNotification) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = false, IsProperty = false, IsStatic = false, Name = "DrawerWillResizeContents", Selector = "drawerWillResizeContents:toSize:", ReturnType = typeof(CGSize), ParameterType = new Type[]
{
	typeof(NSDrawer),
	typeof(CGSize)
}, ParameterByRef = new bool[] { false, false })]
public interface INSDrawerDelegate : INativeObject, IDisposable
{
}
