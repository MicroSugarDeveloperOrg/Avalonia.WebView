using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMCSSRuleList", true)]
public class DomCssRuleList : DomObject, IIndexedContainer<DomCssRule>, IEnumerable<DomCssRule>, IEnumerable
{
	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	private static readonly IntPtr selItem_Handle = Selector.GetHandle("item:");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMCSSRuleList");

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

	public DomCssRule this[int index] => GetItem(index);

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomCssRuleList(NSCoder coder)
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
	public DomCssRuleList(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomCssRuleList(IntPtr handle)
		: base(handle)
	{
	}

	[Export("item:")]
	public virtual DomCssRule GetItem(int index)
	{
		if (IsDirectBinding)
		{
			return (DomCssRule)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int(base.Handle, selItem_Handle, index));
		}
		return (DomCssRule)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selItem_Handle, index));
	}

	public IEnumerator<DomCssRule> GetEnumerator()
	{
		return new IndexedContainerEnumerator<DomCssRule>(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<DomCssRule>)this).GetEnumerator();
	}
}
