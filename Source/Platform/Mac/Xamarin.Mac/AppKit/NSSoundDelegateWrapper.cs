using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

internal sealed class NSSoundDelegateWrapper : BaseWrapper, INSSoundDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public NSSoundDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
