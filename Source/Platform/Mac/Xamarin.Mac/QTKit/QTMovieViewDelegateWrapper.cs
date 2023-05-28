using System;
using Foundation;
using ObjCRuntime;

namespace QTKit;

internal sealed class QTMovieViewDelegateWrapper : BaseWrapper, IQTMovieViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public QTMovieViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
