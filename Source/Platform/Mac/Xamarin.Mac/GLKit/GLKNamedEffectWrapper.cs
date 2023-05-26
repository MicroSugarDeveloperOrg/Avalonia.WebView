using System;
using Foundation;
using ObjCRuntime;

namespace GLKit;

internal sealed class GLKNamedEffectWrapper : BaseWrapper, IGLKNamedEffect, INativeObject, IDisposable
{
	[Preserve(Conditional = true)]
	public GLKNamedEffectWrapper(IntPtr handle, bool owns)
		: base(handle, owns)
	{
	}

	[Export("prepareToDraw")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void PrepareToDraw()
	{
		Messaging.void_objc_msgSend(base.Handle, Selector.GetHandle("prepareToDraw"));
	}
}
