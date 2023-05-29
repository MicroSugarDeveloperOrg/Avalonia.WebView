using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSCustomImageRep", true)]
public class NSCustomImageRep : NSImageRep
{
	private static readonly IntPtr selDrawSelectorHandle = Selector.GetHandle("drawSelector");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selInitWithDrawSelectorDelegate_Handle = Selector.GetHandle("initWithDrawSelector:delegate:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSCustomImageRep");

	private object __mt_Delegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual Selector DrawSelector
	{
		[Export("drawSelector")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Selector.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDrawSelectorHandle));
			}
			return Selector.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDrawSelectorHandle));
		}
	}

	public virtual NSObject Delegate
	{
		[Export("delegate", ArgumentSemantic.Assign)]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_Delegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSCustomImageRep(NSCoder coder)
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
	public NSCustomImageRep(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSCustomImageRep(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithDrawSelector:delegate:")]
	public NSCustomImageRep(Selector drawSelectorMethod, NSObject delegateObject)
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
		if (drawSelectorMethod == null)
		{
			throw new ArgumentNullException("drawSelectorMethod");
		}
		if (delegateObject == null)
		{
			throw new ArgumentNullException("delegateObject");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDrawSelectorDelegate_Handle, drawSelectorMethod.Handle, delegateObject.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDrawSelectorDelegate_Handle, drawSelectorMethod.Handle, delegateObject.Handle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Delegate_var = null;
		}
	}
}
