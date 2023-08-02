using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMNamedNodeMap", true)]
public class DomNamedNodeMap : DomObject, IIndexedContainer<DomNode>, IEnumerable<DomNode>, IEnumerable
{
	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	private static readonly IntPtr selGetNamedItem_Handle = Selector.GetHandle("getNamedItem:");

	private static readonly IntPtr selSetNamedItem_Handle = Selector.GetHandle("setNamedItem:");

	private static readonly IntPtr selRemoveNamedItem_Handle = Selector.GetHandle("removeNamedItem:");

	private static readonly IntPtr selItem_Handle = Selector.GetHandle("item:");

	private static readonly IntPtr selGetNamedItemNSLocalName_Handle = Selector.GetHandle("getNamedItemNS:localName:");

	private static readonly IntPtr selSetNamedItemNS_Handle = Selector.GetHandle("setNamedItemNS:");

	private static readonly IntPtr selRemoveNamedItemNSLocalName_Handle = Selector.GetHandle("removeNamedItemNS:localName:");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMNamedNodeMap");

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

	public DomNode this[string name] => GetNamedItem(name);

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomNamedNodeMap(NSCoder coder)
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
	public DomNamedNodeMap(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomNamedNodeMap(IntPtr handle)
		: base(handle)
	{
	}

	[Export("getNamedItem:")]
	public virtual DomNode GetNamedItem(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		DomNode result = ((!IsDirectBinding) ? ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetNamedItem_Handle, arg))) : ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetNamedItem_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setNamedItem:")]
	public virtual DomNode SetNamedItem(DomNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (IsDirectBinding)
		{
			return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSetNamedItem_Handle, node.Handle));
		}
		return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNamedItem_Handle, node.Handle));
	}

	[Export("removeNamedItem:")]
	public virtual DomNode RemoveNamedItem(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		DomNode result = ((!IsDirectBinding) ? ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveNamedItem_Handle, arg))) : ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRemoveNamedItem_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
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

	[Export("getNamedItemNS:localName:")]
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
		DomNode result = ((!IsDirectBinding) ? ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetNamedItemNSLocalName_Handle, arg, arg2))) : ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetNamedItemNSLocalName_Handle, arg, arg2))));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("setNamedItemNS:")]
	public virtual DomNode SetNamedItemNS(DomNode node)
	{
		if (node == null)
		{
			throw new ArgumentNullException("node");
		}
		if (IsDirectBinding)
		{
			return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSetNamedItemNS_Handle, node.Handle));
		}
		return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNamedItemNS_Handle, node.Handle));
	}

	[Export("removeNamedItemNS:localName:")]
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
		DomNode result = ((!IsDirectBinding) ? ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveNamedItemNSLocalName_Handle, arg, arg2))) : ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveNamedItemNSLocalName_Handle, arg, arg2))));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
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
