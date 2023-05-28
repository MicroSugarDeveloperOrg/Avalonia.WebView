using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Protocol]
[Register("NSPrintPanelAccessorizing", false)]
[Model]
public abstract class NSPrintPanelAccessorizing : NSObject, INSPrintPanelAccessorizing, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	protected NSPrintPanelAccessorizing()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		base.IsDirectBinding = false;
		InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSPrintPanelAccessorizing(NSObjectFlag t)
		: base(t)
	{
		base.IsDirectBinding = false;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPrintPanelAccessorizing(IntPtr handle)
		: base(handle)
	{
		base.IsDirectBinding = false;
	}

	[Export("keyPathsForValuesAffectingPreview")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSSet KeyPathsForValuesAffectingPreview();

	[Export("localizedSummaryItems")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public abstract NSDictionary[] LocalizedSummaryItems();
}
