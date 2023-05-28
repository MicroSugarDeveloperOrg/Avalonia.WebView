using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSDockTilePlugInWrapper : BaseWrapper, INSDockTilePlugIn, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSDockTilePlugInWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("setDockTile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetDockTile(NSDockTile dockTile)
	{
		NSApplication.EnsureUIThread();
		if (dockTile == null)
		{
			throw new ArgumentNullException("dockTile");
		}
		Messaging.void_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("setDockTile:"), dockTile.Handle);
	}

	[Export("dockMenu")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMenu DockMenu()
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("dockMenu")));
	}
}
