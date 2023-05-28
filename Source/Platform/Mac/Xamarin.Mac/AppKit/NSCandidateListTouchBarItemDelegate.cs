using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSCandidateListTouchBarItemDelegate", false)]
[Model]
public class NSCandidateListTouchBarItemDelegate : NSObject, INSCandidateListTouchBarItemDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCandidateListTouchBarItemDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSCandidateListTouchBarItemDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCandidateListTouchBarItemDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("candidateListTouchBarItem:beginSelectingCandidateAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginSelectingCandidate(NSCandidateListTouchBarItem anItem, nint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("candidateListTouchBarItem:changeSelectionFromCandidateAtIndex:toIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangeSelectionFromCandidate(NSCandidateListTouchBarItem anItem, nint previousIndex, nint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("candidateListTouchBarItem:changedCandidateListVisibility:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ChangedCandidateListVisibility(NSCandidateListTouchBarItem anItem, bool isVisible)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("candidateListTouchBarItem:endSelectingCandidateAtIndex:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndSelectingCandidate(NSCandidateListTouchBarItem anItem, nint index)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
