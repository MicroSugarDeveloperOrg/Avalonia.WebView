using System;
using ObjCRuntime;

namespace AppKit;

public static class NSCollectionViewSectionHeaderView_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSButton GetSectionCollapseButton(this INSCollectionViewSectionHeaderView This)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSButton>(Messaging.IntPtr_objc_msgSend(This.Handle, Selector.GetHandle("sectionCollapseButton")));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetSectionCollapseButton(this INSCollectionViewSectionHeaderView This, NSButton value)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_IntPtr(This.Handle, Selector.GetHandle("setSectionCollapseButton:"), value?.Handle ?? IntPtr.Zero);
	}
}
