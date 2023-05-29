using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace CoreData;

[Register("NSFetchedPropertyDescription", true)]
public class NSFetchedPropertyDescription : NSPropertyDescription
{
	private static readonly IntPtr selFetchRequestHandle = Selector.GetHandle("fetchRequest");

	private static readonly IntPtr selSetFetchRequest_Handle = Selector.GetHandle("setFetchRequest:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSFetchedPropertyDescription");

	private object __mt_FetchRequest_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSFetchRequest FetchRequest
	{
		[Export("fetchRequest")]
		get
		{
			return (NSFetchRequest)(__mt_FetchRequest_var = ((!IsDirectBinding) ? ((NSFetchRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFetchRequestHandle))) : ((NSFetchRequest)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFetchRequestHandle)))));
		}
		[Export("setFetchRequest:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFetchRequest_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFetchRequest_Handle, value.Handle);
			}
			__mt_FetchRequest_var = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSFetchedPropertyDescription()
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
	public NSFetchedPropertyDescription(NSCoder coder)
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
	public NSFetchedPropertyDescription(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSFetchedPropertyDescription(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_FetchRequest_var = null;
		}
	}
}
