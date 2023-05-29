using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMAbstractView", true)]
public class DomAbstractView : DomObject
{
	private static readonly IntPtr selDocumentHandle = Selector.GetHandle("document");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMAbstractView");

	private object __mt_Document_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual DomDocument Document
	{
		[Export("document")]
		get
		{
			return (DomDocument)(__mt_Document_var = ((!IsDirectBinding) ? ((DomDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentHandle))) : ((DomDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomAbstractView(NSCoder coder)
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
	public DomAbstractView(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomAbstractView(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Document_var = null;
		}
	}
}
