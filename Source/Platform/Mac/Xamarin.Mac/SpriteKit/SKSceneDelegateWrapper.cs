using System;
using Foundation;
using ObjCRuntime;

namespace SpriteKit;

internal sealed class SKSceneDelegateWrapper : BaseWrapper, ISKSceneDelegate, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public SKSceneDelegateWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}
}
