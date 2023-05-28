using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMCSSRuleList", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomCssRuleList : DomObject, IIndexedContainer<DomCssRule>, IEnumerable<DomCssRule>, IEnumerable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItem_ = "item:";

	private static readonly IntPtr selItem_Handle = Selector.GetHandle("item:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLength = "length";

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMCSSRuleList");

	public DomCssRule this[int index] => GetItem(index);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Count
	{
		[Export("length")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
	}

	public IEnumerator<DomCssRule> GetEnumerator()
	{
		return new IndexedContainerEnumerator<DomCssRule>(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<DomCssRule>)this).GetEnumerator();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomCssRuleList(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomCssRuleList(IntPtr handle)
		: base(handle)
	{
	}

	[Export("item:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomCssRule GetItem(int index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomCssRule>(Messaging.IntPtr_objc_msgSend_int(base.Handle, selItem_Handle, index));
		}
		return Runtime.GetNSObject<DomCssRule>(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selItem_Handle, index));
	}
}
