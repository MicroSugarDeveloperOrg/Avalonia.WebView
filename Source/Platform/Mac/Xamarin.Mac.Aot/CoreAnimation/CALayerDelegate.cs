using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Protocol]
[Register("CALayerDelegate", true)]
[Model]
public class CALayerDelegate : NSObject
{
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CALayerDelegate()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CALayerDelegate(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CALayerDelegate(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CALayerDelegate(IntPtr handle)
		: base(handle)
	{
	}

	[Export("displayLayer:")]
	public virtual void DisplayLayer(CALayer layer)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("drawLayer:inContext:")]
	public virtual void DrawLayer(CALayer layer, CGContext context)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("layoutSublayersOfLayer:")]
	public virtual void LayoutSublayersOfLayer(CALayer layer)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}

	[Export("actionForLayer:forKey:")]
	public virtual NSObject ActionForLayer(CALayer layer, string eventKey)
	{
		throw new You_Should_Not_Call_base_In_This_Method();
	}
}
