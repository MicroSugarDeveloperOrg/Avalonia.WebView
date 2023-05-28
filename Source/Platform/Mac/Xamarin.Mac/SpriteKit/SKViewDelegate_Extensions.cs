using System;
using ObjCRuntime;

namespace SpriteKit;

public static class SKViewDelegate_Extensions
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ShouldRender(this ISKViewDelegate This, SKView view, double time)
	{
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		return Messaging.bool_objc_msgSend_IntPtr_Double(This.Handle, Selector.GetHandle("view:shouldRenderAtTime:"), view.Handle, time);
	}
}
