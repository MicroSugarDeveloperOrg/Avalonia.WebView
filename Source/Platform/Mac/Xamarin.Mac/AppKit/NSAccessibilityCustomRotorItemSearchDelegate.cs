using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSAccessibilityCustomRotorItemSearchDelegate", false)]
[Model]
[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
public abstract class NSAccessibilityCustomRotorItemSearchDelegate : NSObject, INSAccessibilityCustomRotorItemSearchDelegate, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSAccessibilityCustomRotorItemSearchDelegate()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSAccessibilityCustomRotorItemSearchDelegate(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAccessibilityCustomRotorItemSearchDelegate(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("rotor:resultForSearchParameters:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSAccessibilityCustomRotorItemResult? GetResult(NSAccessibilityCustomRotor rotor, NSAccessibilityCustomRotorSearchParameters searchParameters);
}
