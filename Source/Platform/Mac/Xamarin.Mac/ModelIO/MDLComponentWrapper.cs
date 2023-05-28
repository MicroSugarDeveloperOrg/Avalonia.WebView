using System;
using Foundation;
using ObjCRuntime;

namespace ModelIO;

internal sealed class MDLComponentWrapper : BaseWrapper, IMDLComponent, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public MDLComponentWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
