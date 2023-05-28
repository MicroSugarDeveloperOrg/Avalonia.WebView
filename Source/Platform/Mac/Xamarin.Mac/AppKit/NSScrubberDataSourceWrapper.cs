using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSScrubberDataSourceWrapper : BaseWrapper, INSScrubberDataSource, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSScrubberDataSourceWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("numberOfItemsForScrubber:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint GetNumberOfItems(NSScrubber scrubber)
	{
		NSApplication.EnsureUIThread();
		if (scrubber == null)
		{
			throw new ArgumentNullException("scrubber");
		}
		return Messaging.nint_objc_msgSend_IntPtr(base.Handle, Selector.GetHandle("numberOfItemsForScrubber:"), scrubber.Handle);
	}

	[Export("scrubber:viewForItemAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSScrubberItemView GetViewForItem(NSScrubber scrubber, nint index)
	{
		NSApplication.EnsureUIThread();
		if (scrubber == null)
		{
			throw new ArgumentNullException("scrubber");
		}
		return Runtime.GetNSObject<NSScrubberItemView>(Messaging.IntPtr_objc_msgSend_IntPtr_nint(base.Handle, Selector.GetHandle("scrubber:viewForItemAtIndex:"), scrubber.Handle, index));
	}
}
