using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSAccessibilityCustomRotorItemSearchDelegateWrapper : BaseWrapper, INSAccessibilityCustomRotorItemSearchDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSAccessibilityCustomRotorItemSearchDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("rotor:resultForSearchParameters:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAccessibilityCustomRotorItemResult? GetResult(NSAccessibilityCustomRotor rotor, NSAccessibilityCustomRotorSearchParameters searchParameters)
	{
		NSApplication.EnsureUIThread();
		if (rotor == null)
		{
			throw new ArgumentNullException("rotor");
		}
		if (searchParameters == null)
		{
			throw new ArgumentNullException("searchParameters");
		}
		return Runtime.GetNSObject<NSAccessibilityCustomRotorItemResult>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, Selector.GetHandle("rotor:resultForSearchParameters:"), rotor.Handle, searchParameters.Handle));
	}
}
