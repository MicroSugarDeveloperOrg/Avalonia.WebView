using System;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

internal sealed class SKPhysicsContactDelegateWrapper : BaseWrapper, ISKPhysicsContactDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SKPhysicsContactDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
