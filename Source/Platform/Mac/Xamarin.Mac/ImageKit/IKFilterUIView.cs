using System;
using System.ComponentModel;
using AppKit;
using CoreGraphics;
using CoreImage;
using Foundation;
using ObjCRuntime;

namespace ImageKit;

[Register("IKFilterUIView", true)]
public class IKFilterUIView : NSView
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFilter = "filter";

	private static readonly IntPtr selFilterHandle = Selector.GetHandle("filter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_ = "initWithFrame:";

	private static readonly IntPtr selInitWithFrame_Handle = Selector.GetHandle("initWithFrame:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithFrame_Filter_ = "initWithFrame:filter:";

	private static readonly IntPtr selInitWithFrame_Filter_Handle = Selector.GetHandle("initWithFrame:filter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selObjectController = "objectController";

	private static readonly IntPtr selObjectControllerHandle = Selector.GetHandle("objectController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selViewWithFrame_Filter_ = "viewWithFrame:filter:";

	private static readonly IntPtr selViewWithFrame_Filter_Handle = Selector.GetHandle("viewWithFrame:filter:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("IKFilterUIView");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CIFilter Filter
	{
		[Export("filter")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSend(base.Handle, selFilterHandle));
			}
			return Runtime.GetNSObject<CIFilter>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilterHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObjectController ObjectController
	{
		[Export("objectController")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSObjectController>(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectControllerHandle));
			}
			return Runtime.GetNSObject<NSObjectController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectControllerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKFilterUIView()
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
	public IKFilterUIView(NSCoder coder)
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
	protected IKFilterUIView(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal IKFilterUIView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IKFilterUIView(CGRect frameRect)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect(base.Handle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect(base.SuperHandle, selInitWithFrame_Handle, frameRect), "initWithFrame:");
		}
	}

	[Export("initWithFrame:filter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public IKFilterUIView(CGRect frame, CIFilter filter)
		: base(NSObjectFlag.Empty)
	{
		if (filter == null)
		{
			throw new ArgumentNullException("filter");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr(base.Handle, selInitWithFrame_Filter_Handle, frame, filter.Handle), "initWithFrame:filter:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selInitWithFrame_Filter_Handle, frame, filter.Handle), "initWithFrame:filter:");
		}
	}

	[Export("viewWithFrame:filter:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static IKFilterUIView Create(CGRect frame, CIFilter filter)
	{
		if (filter == null)
		{
			throw new ArgumentNullException("filter");
		}
		return Runtime.GetNSObject<IKFilterUIView>(Messaging.IntPtr_objc_msgSend_CGRect_IntPtr(class_ptr, selViewWithFrame_Filter_Handle, frame, filter.Handle));
	}
}
