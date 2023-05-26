using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMetadataQueryAttributeValueTuple", true)]
public class NSMetadataQueryAttributeValueTuple : NSObject
{
	private static readonly IntPtr selAttributeHandle = Selector.GetHandle("attribute");

	private static readonly IntPtr selValueHandle = Selector.GetHandle("value");

	private static readonly IntPtr selCountHandle = Selector.GetHandle("count");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMetadataQueryAttributeValueTuple");

	private object __mt_Value_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Attribute
	{
		[Export("attribute")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributeHandle));
		}
	}

	public virtual NSObject Value
	{
		[Export("value")]
		get
		{
			return (NSObject)(__mt_Value_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selValueHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selValueHandle))));
		}
	}

	public virtual ulong Count
	{
		[Export("count")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selCountHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selCountHandle);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMetadataQueryAttributeValueTuple()
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
	public NSMetadataQueryAttributeValueTuple(NSCoder coder)
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
	public NSMetadataQueryAttributeValueTuple(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMetadataQueryAttributeValueTuple(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Value_var = null;
		}
	}
}
