using System;
using Foundation;
using ObjCRuntime;

namespace SoundAnalysis;

internal sealed class SNRequestWrapper : BaseWrapper, ISNRequest, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SNRequestWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
