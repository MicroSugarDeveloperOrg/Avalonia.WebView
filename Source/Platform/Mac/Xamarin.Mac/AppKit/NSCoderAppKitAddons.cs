using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSCoderAppKitAddons
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecodeNXColor = "decodeNXColor";

	private static readonly IntPtr selDecodeNXColorHandle = Selector.GetHandle("decodeNXColor");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSCoder");

	[Export("decodeNXColor")]
	[Deprecated(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSColor DecodeNXColor(this NSCoder This)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSColor>(Messaging.IntPtr_objc_msgSend(This.Handle, selDecodeNXColorHandle));
	}
}
