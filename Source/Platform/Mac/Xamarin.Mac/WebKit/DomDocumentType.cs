using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMDocumentType", true)]
public class DomDocumentType : DomNode
{
	private static readonly IntPtr selNameHandle = Selector.GetHandle("name");

	private static readonly IntPtr selEntitiesHandle = Selector.GetHandle("entities");

	private static readonly IntPtr selNotationsHandle = Selector.GetHandle("notations");

	private static readonly IntPtr selPublicIdHandle = Selector.GetHandle("publicId");

	private static readonly IntPtr selSystemIdHandle = Selector.GetHandle("systemId");

	private static readonly IntPtr selInternalSubsetHandle = Selector.GetHandle("internalSubset");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMDocumentType");

	private object __mt_Entities_var;

	private object __mt_Notations_var;

	public override IntPtr ClassHandle => class_ptr;

	public new virtual string Name
	{
		[Export("name")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNameHandle));
		}
	}

	public virtual DomNamedNodeMap Entities
	{
		[Export("entities")]
		get
		{
			return (DomNamedNodeMap)(__mt_Entities_var = ((!IsDirectBinding) ? ((DomNamedNodeMap)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEntitiesHandle))) : ((DomNamedNodeMap)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEntitiesHandle)))));
		}
	}

	public virtual DomNamedNodeMap Notations
	{
		[Export("notations")]
		get
		{
			return (DomNamedNodeMap)(__mt_Notations_var = ((!IsDirectBinding) ? ((DomNamedNodeMap)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNotationsHandle))) : ((DomNamedNodeMap)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selNotationsHandle)))));
		}
	}

	public virtual string PublicId
	{
		[Export("publicId")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPublicIdHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPublicIdHandle));
		}
	}

	public virtual string SystemId
	{
		[Export("systemId")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSystemIdHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSystemIdHandle));
		}
	}

	public virtual string InternalSubset
	{
		[Export("internalSubset")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInternalSubsetHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInternalSubsetHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomDocumentType(NSCoder coder)
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
	public DomDocumentType(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomDocumentType(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Entities_var = null;
			__mt_Notations_var = null;
		}
	}
}
