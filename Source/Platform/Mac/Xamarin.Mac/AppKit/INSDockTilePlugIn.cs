using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol(Name = "NSDockTilePlugIn", WrapperType = typeof(NSDockTilePlugInWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "SetDockTile", Selector = "setDockTile:", ParameterType = new Type[] { typeof(NSDockTile) }, ParameterByRef = new bool[] { false })]
[ProtocolMember(IsRequired = true, IsProperty = false, IsStatic = false, Name = "DockMenu", Selector = "dockMenu", ReturnType = typeof(NSMenu))]
public interface INSDockTilePlugIn : INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("setDockTile:")]
	[Preserve(Conditional = true)]
	void SetDockTile(NSDockTile dockTile);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Export("dockMenu")]
	[Preserve(Conditional = true)]
	NSMenu DockMenu();
}
