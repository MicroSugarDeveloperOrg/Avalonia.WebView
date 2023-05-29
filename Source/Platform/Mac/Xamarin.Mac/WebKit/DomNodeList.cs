using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMNodeList", true)]
public class DomNodeList : DomObject, IIndexedContainer<DomNode>, IEnumerable<DomNode>, IEnumerable
{
	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	private static readonly IntPtr selItem_Handle = Selector.GetHandle("item:");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMNodeList");

	public override IntPtr ClassHandle => class_ptr;

	public virtual int Count
	{
		[Export("length")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
	}

	public DomNode this[int index] => GetItem(index);

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomNodeList(NSCoder coder)
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
	public DomNodeList(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomNodeList(IntPtr handle)
		: base(handle)
	{
	}

	[Export("item:")]
	public virtual DomNode GetItem(int index)
	{
		if (IsDirectBinding)
		{
			return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(base.Handle, selItem_Handle, index));
		}
		return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selItem_Handle, index));
	}

	public IEnumerator<DomNode> GetEnumerator()
	{
		return new IndexedContainerEnumerator<DomNode>(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<DomNode>)this).GetEnumerator();
	}
}
