using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSEditorRegistrationWrapper : BaseWrapper, INSEditorRegistration, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSEditorRegistrationWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
