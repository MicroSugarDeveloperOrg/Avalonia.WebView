using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace AppKit;

public static class NSCandidateListTouchBarItemDelegate_Extensions
{
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void BeginSelectingCandidate(this INSCandidateListTouchBarItemDelegate This, NSCandidateListTouchBarItem anItem, nint index)
	{
		NSApplication.EnsureUIThread();
		if (anItem == null)
		{
			throw new ArgumentNullException("anItem");
		}
		Messaging.void_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("candidateListTouchBarItem:beginSelectingCandidateAtIndex:"), anItem.Handle, index);
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ChangeSelectionFromCandidate(this INSCandidateListTouchBarItemDelegate This, NSCandidateListTouchBarItem anItem, nint previousIndex, nint index)
	{
		NSApplication.EnsureUIThread();
		if (anItem == null)
		{
			throw new ArgumentNullException("anItem");
		}
		Messaging.void_objc_msgSend_IntPtr_nint_nint(This.Handle, Selector.GetHandle("candidateListTouchBarItem:changeSelectionFromCandidateAtIndex:toIndex:"), anItem.Handle, previousIndex, index);
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void EndSelectingCandidate(this INSCandidateListTouchBarItemDelegate This, NSCandidateListTouchBarItem anItem, nint index)
	{
		NSApplication.EnsureUIThread();
		if (anItem == null)
		{
			throw new ArgumentNullException("anItem");
		}
		Messaging.void_objc_msgSend_IntPtr_nint(This.Handle, Selector.GetHandle("candidateListTouchBarItem:endSelectingCandidateAtIndex:"), anItem.Handle, index);
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ChangedCandidateListVisibility(this INSCandidateListTouchBarItemDelegate This, NSCandidateListTouchBarItem anItem, bool isVisible)
	{
		NSApplication.EnsureUIThread();
		if (anItem == null)
		{
			throw new ArgumentNullException("anItem");
		}
		Messaging.void_objc_msgSend_IntPtr_bool(This.Handle, Selector.GetHandle("candidateListTouchBarItem:changedCandidateListVisibility:"), anItem.Handle, isVisible);
	}
}
