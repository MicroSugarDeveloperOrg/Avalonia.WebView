using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSPredicateEditor", true)]
public class NSPredicateEditor : NSRuleEditor
{
	private static readonly IntPtr selRowTemplatesHandle = Selector.GetHandle("rowTemplates");

	private static readonly IntPtr selSetRowTemplates_Handle = Selector.GetHandle("setRowTemplates:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSPredicateEditor");

	private object __mt_RowTemplates_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSPredicateEditorRowTemplate[] RowTemplates
	{
		[Export("rowTemplates")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPredicateEditorRowTemplate[])(__mt_RowTemplates_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSPredicateEditorRowTemplate>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selRowTemplatesHandle)) : NSArray.ArrayFromHandle<NSPredicateEditorRowTemplate>(Messaging.IntPtr_objc_msgSend(base.Handle, selRowTemplatesHandle))));
		}
		[Export("setRowTemplates:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetRowTemplates_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetRowTemplates_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
			__mt_RowTemplates_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPredicateEditor()
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
	public NSPredicateEditor(NSCoder coder)
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
	public NSPredicateEditor(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSPredicateEditor(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_RowTemplates_var = null;
		}
	}
}
