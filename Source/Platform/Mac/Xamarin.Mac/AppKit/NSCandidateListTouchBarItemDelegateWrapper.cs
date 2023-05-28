using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSCandidateListTouchBarItemDelegateWrapper : BaseWrapper, INSCandidateListTouchBarItemDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSCandidateListTouchBarItemDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
