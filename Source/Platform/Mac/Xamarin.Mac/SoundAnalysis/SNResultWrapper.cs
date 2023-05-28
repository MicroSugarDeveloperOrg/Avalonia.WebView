using System;
using Foundation;
using ObjCRuntime;

namespace SoundAnalysis;

internal sealed class SNResultWrapper : BaseWrapper, ISNResult, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SNResultWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
