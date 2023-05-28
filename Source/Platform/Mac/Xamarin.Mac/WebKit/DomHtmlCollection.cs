using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMHTMLCollection", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomHtmlCollection : DomObject, IIndexedContainer<DomNode>, IEnumerable<DomNode>, IEnumerable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItem_ = "item:";

	private static readonly IntPtr selItem_Handle = Selector.GetHandle("item:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLength = "length";

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNamedItem_ = "namedItem:";

	private static readonly IntPtr selNamedItem_Handle = Selector.GetHandle("namedItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTags_ = "tags:";

	private static readonly IntPtr selTags_Handle = Selector.GetHandle("tags:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMHTMLCollection");

	public DomNode this[int index] => GetItem(index);

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

	public IEnumerator<DomNode> GetEnumerator()
	{
		return new IndexedContainerEnumerator<DomNode>(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<DomNode>)this).GetEnumerator();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomHtmlCollection(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomHtmlCollection(IntPtr handle)
		: base(handle)
	{
	}

	[Export("item:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode GetItem(int index)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_int(base.Handle, selItem_Handle, index));
		}
		return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selItem_Handle, index));
	}

	[Export("namedItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode GetNamedItem(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		DomNode result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selNamedItem_Handle, arg)) : Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selNamedItem_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("tags:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNodeList GetTags(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		DomNodeList result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomNodeList>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selTags_Handle, arg)) : Runtime.GetNSObject<DomNodeList>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selTags_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}
}
