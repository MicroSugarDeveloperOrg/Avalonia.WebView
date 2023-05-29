using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAScrollLayer", true)]
public class CAScrollLayer : CALayer
{
	private static readonly IntPtr selScrollModeHandle = Selector.GetHandle("scrollMode");

	private static readonly IntPtr selSetScrollMode_Handle = Selector.GetHandle("setScrollMode:");

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	private static readonly IntPtr selScrollToPoint_Handle = Selector.GetHandle("scrollToPoint:");

	private static readonly IntPtr selScrollToRect_Handle = Selector.GetHandle("scrollToRect:");

	private static readonly IntPtr class_ptr = Class.GetHandle("CAScrollLayer");

	private object __mt_ScrollMode_var;

	private static NSString _ScrollNone;

	private static NSString _ScrollVertically;

	private static NSString _ScrollHorizontally;

	private static NSString _ScrollBoth;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSString ScrollMode
	{
		[Export("scrollMode")]
		get
		{
			return (NSString)(__mt_ScrollMode_var = ((!IsDirectBinding) ? ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScrollModeHandle))) : ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selScrollModeHandle)))));
		}
		[Export("setScrollMode:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetScrollMode_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetScrollMode_Handle, value.Handle);
			}
			__mt_ScrollMode_var = value;
		}
	}

	[Field("kCAScrollNone", "CoreAnimation")]
	public static NSString ScrollNone
	{
		get
		{
			if (_ScrollNone == null)
			{
				_ScrollNone = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAScrollNone");
			}
			return _ScrollNone;
		}
	}

	[Field("kCAScrollVertically", "CoreAnimation")]
	public static NSString ScrollVertically
	{
		get
		{
			if (_ScrollVertically == null)
			{
				_ScrollVertically = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAScrollVertically");
			}
			return _ScrollVertically;
		}
	}

	[Field("kCAScrollHorizontally", "CoreAnimation")]
	public static NSString ScrollHorizontally
	{
		get
		{
			if (_ScrollHorizontally == null)
			{
				_ScrollHorizontally = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAScrollHorizontally");
			}
			return _ScrollHorizontally;
		}
	}

	[Field("kCAScrollBoth", "CoreAnimation")]
	public static NSString ScrollBoth
	{
		get
		{
			if (_ScrollBoth == null)
			{
				_ScrollBoth = Dlfcn.GetStringConstant(Libraries.CoreAnimation.Handle, "kCAScrollBoth");
			}
			return _ScrollBoth;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAScrollLayer()
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
	public CAScrollLayer(NSCoder coder)
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
	public CAScrollLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public CAScrollLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layer")]
	public new static CALayer Create()
	{
		return (CALayer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selLayerHandle));
	}

	[Export("scrollToPoint:")]
	public virtual void ScrollToPoint(CGPoint p)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selScrollToPoint_Handle, p);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selScrollToPoint_Handle, p);
		}
	}

	[Export("scrollToRect:")]
	public virtual void ScrollToRect(CGRect r)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selScrollToRect_Handle, r);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selScrollToRect_Handle, r);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ScrollMode_var = null;
		}
	}
}
