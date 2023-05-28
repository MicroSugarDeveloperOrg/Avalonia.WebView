using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreAnimation;

[Register("CAScrollLayer", true)]
public class CAScrollLayer : CALayer
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLayer = "layer";

	private static readonly IntPtr selLayerHandle = Selector.GetHandle("layer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollMode = "scrollMode";

	private static readonly IntPtr selScrollModeHandle = Selector.GetHandle("scrollMode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollToPoint_ = "scrollToPoint:";

	private static readonly IntPtr selScrollToPoint_Handle = Selector.GetHandle("scrollToPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollToRect_ = "scrollToRect:";

	private static readonly IntPtr selScrollToRect_Handle = Selector.GetHandle("scrollToRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScrollMode_ = "setScrollMode:";

	private static readonly IntPtr selSetScrollMode_Handle = Selector.GetHandle("setScrollMode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CAScrollLayer");

	[Obsolete("Use CAScroll enum")]
	public static NSString ScrollBoth => CAScroll.Both.GetConstant();

	[Obsolete("Use CAScroll enum")]
	public static NSString ScrollHorizontally => CAScroll.Horizontally.GetConstant();

	[Obsolete("Use CAScroll enum")]
	public static NSString ScrollNone => CAScroll.None.GetConstant();

	[Obsolete("Use CAScroll enum")]
	public static NSString ScrollVertically => CAScroll.Vertically.GetConstant();

	public CAScroll Scroll
	{
		get
		{
			return CAScrollExtensions.GetValue(ScrollMode);
		}
		set
		{
			ScrollMode = value.GetConstant();
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString ScrollMode
	{
		[Export("scrollMode", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selScrollModeHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScrollModeHandle));
		}
		[Export("setScrollMode:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetScrollMode_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetScrollMode_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CAScrollLayer()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public CAScrollLayer(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected CAScrollLayer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CAScrollLayer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("layer")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new static CALayer Create()
	{
		return Runtime.GetNSObject<CALayer>(Messaging.IntPtr_objc_msgSend(class_ptr, selLayerHandle));
	}

	[Export("scrollToPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollToPoint(CGPoint p)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selScrollToPoint_Handle, p);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selScrollToPoint_Handle, p);
		}
	}

	[Export("scrollToRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollToRect(CGRect r)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selScrollToRect_Handle, r);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selScrollToRect_Handle, r);
		}
	}
}
