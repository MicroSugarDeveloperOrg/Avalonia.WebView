using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMNamedNodeMap", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomNamedNodeMap : DomObject, IIndexedContainer<DomNode>, IEnumerable<DomNode>, IEnumerable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetNamedItem_ = "getNamedItem:";

	private static readonly IntPtr selGetNamedItem_Handle = Selector.GetHandle("getNamedItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetNamedItemNS_LocalName_ = "getNamedItemNS:localName:";

	private static readonly IntPtr selGetNamedItemNS_LocalName_Handle = Selector.GetHandle("getNamedItemNS:localName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItem_ = "item:";

	private static readonly IntPtr selItem_Handle = Selector.GetHandle("item:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLength = "length";

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveNamedItem_ = "removeNamedItem:";

	private static readonly IntPtr selRemoveNamedItem_Handle = Selector.GetHandle("removeNamedItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveNamedItemNS_LocalName_ = "removeNamedItemNS:localName:";

	private static readonly IntPtr selRemoveNamedItemNS_LocalName_Handle = Selector.GetHandle("removeNamedItemNS:localName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNamedItem_ = "setNamedItem:";

	private static readonly IntPtr selSetNamedItem_Handle = Selector.GetHandle("setNamedItem:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNamedItemNS_ = "setNamedItemNS:";

	private static readonly IntPtr selSetNamedItemNS_Handle = Selector.GetHandle("setNamedItemNS:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMNamedNodeMap");

	public DomNode this[int index] => GetItem(index);

	public DomNode this[string name] => GetNamedItem(name);

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
	protected DomNamedNodeMap(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomNamedNodeMap(IntPtr handle)
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

	[Export("getNamedItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode GetNamedItem(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		DomNode result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetNamedItem_Handle, arg)) : Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetNamedItem_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getNamedItemNS:localName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode GetNamedItemNS(string namespaceUri, string localName)
	{
		if (namespaceUri == null)
		{
			throw new ArgumentNullException("namespaceUri");
		}
		if (localName == null)
		{
			throw new ArgumentNullException("localName");
		}
		IntPtr arg = NSString.CreateNative(namespaceUri);
		IntPtr arg2 = NSString.CreateNative(localName);
		DomNode result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetNamedItemNS_LocalName_Handle, arg, arg2)) : Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetNamedItemNS_LocalName_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("removeNamedItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode RemoveNamedItem(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		DomNode result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveNamedItem_Handle, arg)) : Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRemoveNamedItem_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeNamedItemNS:localName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode RemoveNamedItemNS(string namespaceURI, string localName)
	{
		if (namespaceURI == null)
		{
			throw new ArgumentNullException("namespaceURI");
		}
		if (localName == null)
		{
			throw new ArgumentNullException("localName");
		}
		IntPtr arg = NSString.CreateNative(namespaceURI);
		IntPtr arg2 = NSString.CreateNative(localName);
		DomNode result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveNamedItemNS_LocalName_Handle, arg, arg2)) : Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveNamedItemNS_LocalName_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("setNamedItem:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode SetNamedItem(DomNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSetNamedItem_Handle, node.Handle));
		}
		return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNamedItem_Handle, node.Handle));
	}

	[Export("setNamedItemNS:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode SetNamedItemNS(DomNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSetNamedItemNS_Handle, node.Handle));
		}
		return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNamedItemNS_Handle, node.Handle));
	}
}
