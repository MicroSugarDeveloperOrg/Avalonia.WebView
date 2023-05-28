using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSPrintPanelAccessorizingWrapper : BaseWrapper, INSPrintPanelAccessorizing, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSPrintPanelAccessorizingWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("localizedSummaryItems")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSDictionary[] LocalizedSummaryItems()
	{
		NSApplication.EnsureUIThread();
		return NSArray.ArrayFromHandle<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("localizedSummaryItems")));
	}

	[Export("keyPathsForValuesAffectingPreview")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSSet KeyPathsForValuesAffectingPreview()
	{
		NSApplication.EnsureUIThread();
		return Runtime.GetNSObject<NSSet>(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.GetHandle("keyPathsForValuesAffectingPreview")));
	}
}
