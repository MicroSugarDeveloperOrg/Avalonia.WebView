using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMStyleSheetList", true)]
public class DomStyleSheetList : DomObject, IIndexedContainer<DomStyleSheet>, IEnumerable<DomStyleSheet>, IEnumerable
{
	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	private static readonly IntPtr selItem_Handle = Selector.GetHandle("item:");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMStyleSheetList");

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

	public DomStyleSheet this[int index] => GetItem(index);

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomStyleSheetList(NSCoder coder)
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
	public DomStyleSheetList(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomStyleSheetList(IntPtr handle)
		: base(handle)
	{
	}

	[Export("item:")]
	public virtual DomStyleSheet GetItem(int index)
	{
		if (IsDirectBinding)
		{
			return (DomStyleSheet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(base.Handle, selItem_Handle, index));
		}
		return (DomStyleSheet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selItem_Handle, index));
	}

	public IEnumerator<DomStyleSheet> GetEnumerator()
	{
		return new IndexedContainerEnumerator<DomStyleSheet>(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<DomStyleSheet>)this).GetEnumerator();
	}
}
