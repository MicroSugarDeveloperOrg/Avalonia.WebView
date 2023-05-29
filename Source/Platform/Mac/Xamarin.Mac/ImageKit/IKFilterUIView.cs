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
	private static readonly IntPtr selFilterHandle = Selector.GetHandle("filter");

	private static readonly IntPtr selObjectControllerHandle = Selector.GetHandle("objectController");

	private static readonly IntPtr selInitWithFrameFilter_Handle = Selector.GetHandle("initWithFrame:filter:");

	private static readonly IntPtr selViewForUIConfigurationExcludedKeys_Handle = Selector.GetHandle("viewForUIConfiguration:excludedKeys:");

	private static readonly IntPtr class_ptr = Class.GetHandle("IKFilterUIView");

	private object __mt_Filter_var;

	private object __mt_ObjectController_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual CIFilter Filter
	{
		[Export("filter")]
		get
		{
			return (CIFilter)(__mt_Filter_var = ((!IsDirectBinding) ? ((CIFilter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFilterHandle))) : ((CIFilter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFilterHandle)))));
		}
	}

	public virtual NSObjectController ObjectController
	{
		[Export("objectController")]
		get
		{
			return (NSObjectController)(__mt_ObjectController_var = ((!IsDirectBinding) ? ((NSObjectController)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selObjectControllerHandle))) : ((NSObjectController)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selObjectControllerHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public IKFilterUIView()
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
	public IKFilterUIView(NSCoder coder)
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
	public IKFilterUIView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public IKFilterUIView(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithFrame:filter:")]
	public IKFilterUIView(CGRect frame, CIFilter filter)
		: base(NSObjectFlag.Empty)
	{
		if (filter == null)
		{
			throw new ArgumentNullException("filter");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_CGRect_IntPtr(base.Handle, selInitWithFrameFilter_Handle, frame, filter.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selInitWithFrameFilter_Handle, frame, filter.Handle);
		}
	}

	[Export("viewForUIConfiguration:excludedKeys:")]
	public virtual IKFilterUIView GetFilterUIView(CIFilter filter, NSDictionary configurationOptions, NSArray excludedKeys)
	{
		if (filter == null)
		{
			throw new ArgumentNullException("filter");
		}
		if (configurationOptions == null)
		{
			throw new ArgumentNullException("configurationOptions");
		}
		if (IsDirectBinding)
		{
			return (IKFilterUIView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(filter.Handle, selViewForUIConfigurationExcludedKeys_Handle, configurationOptions.Handle, excludedKeys?.Handle ?? IntPtr.Zero));
		}
		return (IKFilterUIView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selViewForUIConfigurationExcludedKeys_Handle, configurationOptions.Handle, excludedKeys?.Handle ?? IntPtr.Zero));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Filter_var = null;
			__mt_ObjectController_var = null;
		}
	}
}
