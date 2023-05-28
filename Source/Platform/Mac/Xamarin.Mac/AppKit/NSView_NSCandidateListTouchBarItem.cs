using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSView_NSCandidateListTouchBarItem
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCandidateListTouchBarItem = "candidateListTouchBarItem";

	private static readonly IntPtr selCandidateListTouchBarItemHandle = Selector.GetHandle("candidateListTouchBarItem");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSView");

	[Export("candidateListTouchBarItem")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCandidateListTouchBarItem GetCandidateListTouchBarItem(this NSView This)
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSCandidateListTouchBarItem>(Messaging.IntPtr_objc_msgSend(This.Handle, selCandidateListTouchBarItemHandle));
	}
}
