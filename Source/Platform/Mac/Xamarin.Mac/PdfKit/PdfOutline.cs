using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace PdfKit;

[Register("PDFOutline", true)]
public class PdfOutline : NSObject
{
	private static readonly IntPtr selDocumentHandle = Selector.GetHandle("document");

	private static readonly IntPtr selParentHandle = Selector.GetHandle("parent");

	private static readonly IntPtr selNumberOfChildrenHandle = Selector.GetHandle("numberOfChildren");

	private static readonly IntPtr selIndexHandle = Selector.GetHandle("index");

	private static readonly IntPtr selLabelHandle = Selector.GetHandle("label");

	private static readonly IntPtr selSetLabel_Handle = Selector.GetHandle("setLabel:");

	private static readonly IntPtr selIsOpenHandle = Selector.GetHandle("isOpen");

	private static readonly IntPtr selSetIsOpen_Handle = Selector.GetHandle("setIsOpen:");

	private static readonly IntPtr selDestinationHandle = Selector.GetHandle("destination");

	private static readonly IntPtr selSetDestination_Handle = Selector.GetHandle("setDestination:");

	private static readonly IntPtr selActionHandle = Selector.GetHandle("action");

	private static readonly IntPtr selSetAction_Handle = Selector.GetHandle("setAction:");

	private static readonly IntPtr selChildAtIndex_Handle = Selector.GetHandle("childAtIndex:");

	private static readonly IntPtr selInsertChildAtIndex_Handle = Selector.GetHandle("insertChild:atIndex:");

	private static readonly IntPtr selRemoveFromParentHandle = Selector.GetHandle("removeFromParent");

	private static readonly IntPtr class_ptr = Class.GetHandle("PDFOutline");

	private object __mt_Document_var;

	private object __mt_Parent_var;

	private object __mt_Destination_var;

	private object __mt_Action_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual PdfDocument Document
	{
		[Export("document")]
		get
		{
			return (PdfDocument)(__mt_Document_var = ((!IsDirectBinding) ? ((PdfDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentHandle))) : ((PdfDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentHandle)))));
		}
	}

	public virtual PdfOutline Parent
	{
		[Export("parent")]
		get
		{
			return (PdfOutline)(__mt_Parent_var = ((!IsDirectBinding) ? ((PdfOutline)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentHandle))) : ((PdfOutline)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selParentHandle)))));
		}
	}

	public virtual int ChildrenCount
	{
		[Export("numberOfChildren")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selNumberOfChildrenHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selNumberOfChildrenHandle);
		}
	}

	public virtual int Index
	{
		[Export("index")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selIndexHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selIndexHandle);
		}
	}

	public virtual string Label
	{
		[Export("label")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLabelHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLabelHandle));
		}
		[Export("setLabel:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLabel_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLabel_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool IsOpen
	{
		[Export("isOpen")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsOpenHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsOpenHandle);
		}
		[Export("setIsOpen:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetIsOpen_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetIsOpen_Handle, value);
			}
		}
	}

	public virtual PdfDestination Destination
	{
		[Export("destination")]
		get
		{
			return (PdfDestination)(__mt_Destination_var = ((!IsDirectBinding) ? ((PdfDestination)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDestinationHandle))) : ((PdfDestination)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDestinationHandle)))));
		}
		[Export("setDestination:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDestination_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDestination_Handle, value.Handle);
			}
			__mt_Destination_var = value;
		}
	}

	public virtual PdfAction Action
	{
		[Export("action")]
		get
		{
			return (PdfAction)(__mt_Action_var = ((!IsDirectBinding) ? ((PdfAction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActionHandle))) : ((PdfAction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selActionHandle)))));
		}
		[Export("setAction:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAction_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAction_Handle, value.Handle);
			}
			__mt_Action_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public PdfOutline()
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
	public PdfOutline(NSCoder coder)
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
	public PdfOutline(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public PdfOutline(IntPtr handle)
		: base(handle)
	{
	}

	[Export("childAtIndex:")]
	public virtual PdfOutline Child(int index)
	{
		if (IsDirectBinding)
		{
			return (PdfOutline)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(base.Handle, selChildAtIndex_Handle, index));
		}
		return (PdfOutline)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selChildAtIndex_Handle, index));
	}

	[Export("insertChild:atIndex:")]
	public virtual void InsertChild(PdfOutline child, int index)
	{
		if (child == null)
		{
			throw new ArgumentNullException("child");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_int(base.Handle, selInsertChildAtIndex_Handle, child.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_int(base.SuperHandle, selInsertChildAtIndex_Handle, child.Handle, index);
		}
	}

	[Export("removeFromParent")]
	public virtual void RemoveFromParent()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selRemoveFromParentHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selRemoveFromParentHandle);
		}
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Document_var = null;
			__mt_Parent_var = null;
			__mt_Destination_var = null;
			__mt_Action_var = null;
		}
	}
}
