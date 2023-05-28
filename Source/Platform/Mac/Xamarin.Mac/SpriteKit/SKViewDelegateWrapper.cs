using System;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

internal sealed class SKViewDelegateWrapper : BaseWrapper, ISKViewDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SKViewDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
