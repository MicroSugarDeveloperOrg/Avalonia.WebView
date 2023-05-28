using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSObject_NSFontPanelValidationAdditions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selValidModesForFontPanel_ = "validModesForFontPanel:";

	private static readonly IntPtr selValidModesForFontPanel_Handle = Selector.GetHandle("validModesForFontPanel:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSObject");

	[Export("validModesForFontPanel:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSFontPanelModeMask GetValidModes(this NSObject This, NSFontPanel fontPanel)
	{
		NSApplication.EnsureUIThread();
		if (fontPanel == null)
		{
			throw new ArgumentNullException("fontPanel");
		}
		return (NSFontPanelModeMask)Messaging.UInt64_objc_msgSend_IntPtr(This.Handle, selValidModesForFontPanel_Handle, fontPanel.Handle);
	}
}
