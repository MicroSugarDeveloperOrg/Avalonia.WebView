using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSController", true)]
public class NSController : NSObject
{
	private static readonly IntPtr selCommitEditingHandle = Selector.GetHandle("commitEditing");

	private static readonly IntPtr selIsEditingHandle = Selector.GetHandle("isEditing");

	private static readonly IntPtr selObjectDidBeginEditing_Handle = Selector.GetHandle("objectDidBeginEditing:");

	private static readonly IntPtr selObjectDidEndEditing_Handle = Selector.GetHandle("objectDidEndEditing:");

	private static readonly IntPtr selDiscardEditingHandle = Selector.GetHandle("discardEditing");

	private static readonly IntPtr selCommitEditingWithDelegateDidCommitSelectorContextInfo_Handle = Selector.GetHandle("commitEditingWithDelegate:didCommitSelector:contextInfo:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSController");

	public override IntPtr ClassHandle => class_ptr;

	public new virtual bool CommitEditing
	{
		[Export("commitEditing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selCommitEditingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selCommitEditingHandle);
		}
	}

	public virtual bool IsEditing
	{
		[Export("isEditing")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsEditingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsEditingHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSController()
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
	public NSController(NSCoder coder)
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
	public NSController(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSController(IntPtr handle)
		: base(handle)
	{
	}

	[Export("objectDidBeginEditing:")]
	public virtual void ObjectDidBeginEditing(NSObject editor)
	{
		NSApplication.EnsureUIThread();
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selObjectDidBeginEditing_Handle, editor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectDidBeginEditing_Handle, editor.Handle);
		}
	}

	[Export("objectDidEndEditing:")]
	public new virtual void ObjectDidEndEditing(NSObject editor)
	{
		NSApplication.EnsureUIThread();
		if (editor == null)
		{
			throw new ArgumentNullException("editor");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selObjectDidEndEditing_Handle, editor.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selObjectDidEndEditing_Handle, editor.Handle);
		}
	}

	[Export("discardEditing")]
	public virtual void DiscardEditing()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selDiscardEditingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selDiscardEditingHandle);
		}
	}

	[Export("commitEditingWithDelegate:didCommitSelector:contextInfo:")]
	public virtual void CommitEditingWithDelegate(NSObject delegate1, Selector didCommitSelector, IntPtr contextInfo)
	{
		NSApplication.EnsureUIThread();
		if (delegate1 == null)
		{
			throw new ArgumentNullException("delegate1");
		}
		if (didCommitSelector == null)
		{
			throw new ArgumentNullException("didCommitSelector");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selCommitEditingWithDelegateDidCommitSelectorContextInfo_Handle, delegate1.Handle, didCommitSelector.Handle, contextInfo);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selCommitEditingWithDelegateDidCommitSelectorContextInfo_Handle, delegate1.Handle, didCommitSelector.Handle, contextInfo);
		}
	}
}
