using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMElement", true)]
public class DomElement : DomNode
{
	private static readonly IntPtr selOffsetLeftHandle = Selector.GetHandle("offsetLeft");

	private static readonly IntPtr selOffsetTopHandle = Selector.GetHandle("offsetTop");

	private static readonly IntPtr selOffsetWidthHandle = Selector.GetHandle("offsetWidth");

	private static readonly IntPtr selOffsetHeightHandle = Selector.GetHandle("offsetHeight");

	private static readonly IntPtr selOffsetParentHandle = Selector.GetHandle("offsetParent");

	private static readonly IntPtr selClientLeftHandle = Selector.GetHandle("clientLeft");

	private static readonly IntPtr selClientTopHandle = Selector.GetHandle("clientTop");

	private static readonly IntPtr selClientWidthHandle = Selector.GetHandle("clientWidth");

	private static readonly IntPtr selClientHeightHandle = Selector.GetHandle("clientHeight");

	private static readonly IntPtr selScrollLeftHandle = Selector.GetHandle("scrollLeft");

	private static readonly IntPtr selSetScrollLeft_Handle = Selector.GetHandle("setScrollLeft:");

	private static readonly IntPtr selScrollTopHandle = Selector.GetHandle("scrollTop");

	private static readonly IntPtr selSetScrollTop_Handle = Selector.GetHandle("setScrollTop:");

	private static readonly IntPtr selScrollWidthHandle = Selector.GetHandle("scrollWidth");

	private static readonly IntPtr selScrollHeightHandle = Selector.GetHandle("scrollHeight");

	private static readonly IntPtr selFirstElementChildHandle = Selector.GetHandle("firstElementChild");

	private static readonly IntPtr selLastElementChildHandle = Selector.GetHandle("lastElementChild");

	private static readonly IntPtr selPreviousElementSiblingHandle = Selector.GetHandle("previousElementSibling");

	private static readonly IntPtr selNextElementSiblingHandle = Selector.GetHandle("nextElementSibling");

	private static readonly IntPtr selChildElementCountHandle = Selector.GetHandle("childElementCount");

	private static readonly IntPtr selInnerTextHandle = Selector.GetHandle("innerText");

	private static readonly IntPtr selGetAttribute_Handle = Selector.GetHandle("getAttribute:");

	private static readonly IntPtr selSetAttributeValue_Handle = Selector.GetHandle("setAttribute:value:");

	private static readonly IntPtr selRemoveAttribute_Handle = Selector.GetHandle("removeAttribute:");

	private static readonly IntPtr selGetAttributeNode_Handle = Selector.GetHandle("getAttributeNode:");

	private static readonly IntPtr selSetAttributeNode_Handle = Selector.GetHandle("setAttributeNode:");

	private static readonly IntPtr selRemoveAttributeNode_Handle = Selector.GetHandle("removeAttributeNode:");

	private static readonly IntPtr selGetElementsByTagName_Handle = Selector.GetHandle("getElementsByTagName:");

	private static readonly IntPtr selGetAttributeNSLocalName_Handle = Selector.GetHandle("getAttributeNS:localName:");

	private static readonly IntPtr selSetAttributeNSQualifiedNameValue_Handle = Selector.GetHandle("setAttributeNS:qualifiedName:value:");

	private static readonly IntPtr selRemoveAttributeNSLocalName_Handle = Selector.GetHandle("removeAttributeNS:localName:");

	private static readonly IntPtr selGetElementsByTagNameNSLocalName_Handle = Selector.GetHandle("getElementsByTagNameNS:localName:");

	private static readonly IntPtr selGetAttributeNodeNSLocalName_Handle = Selector.GetHandle("getAttributeNodeNS:localName:");

	private static readonly IntPtr selSetAttributeNodeNS_Handle = Selector.GetHandle("setAttributeNodeNS:");

	private static readonly IntPtr selHasAttribute_Handle = Selector.GetHandle("hasAttribute:");

	private static readonly IntPtr selHasAttributeNSLocalName_Handle = Selector.GetHandle("hasAttributeNS:localName:");

	private static readonly IntPtr selFocusHandle = Selector.GetHandle("focus");

	private static readonly IntPtr selBlurHandle = Selector.GetHandle("blur");

	private static readonly IntPtr selScrollIntoView_Handle = Selector.GetHandle("scrollIntoView:");

	private static readonly IntPtr selContains_Handle = Selector.GetHandle("contains:");

	private static readonly IntPtr selScrollIntoViewIfNeeded_Handle = Selector.GetHandle("scrollIntoViewIfNeeded:");

	private static readonly IntPtr selScrollByLines_Handle = Selector.GetHandle("scrollByLines:");

	private static readonly IntPtr selScrollByPages_Handle = Selector.GetHandle("scrollByPages:");

	private static readonly IntPtr selGetElementsByClassName_Handle = Selector.GetHandle("getElementsByClassName:");

	private static readonly IntPtr selQuerySelector_Handle = Selector.GetHandle("querySelector:");

	private static readonly IntPtr selQuerySelectorAll_Handle = Selector.GetHandle("querySelectorAll:");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMElement");

	private object __mt_OffsetParent_var;

	private object __mt_FirstElementChild_var;

	private object __mt_LastElementChild_var;

	private object __mt_PreviousElementSibling_var;

	private object __mt_NextElementSibling_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual int OffsetLeft
	{
		[Export("offsetLeft")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selOffsetLeftHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selOffsetLeftHandle);
		}
	}

	public virtual int OffsetTop
	{
		[Export("offsetTop")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selOffsetTopHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selOffsetTopHandle);
		}
	}

	public virtual int OffsetWidth
	{
		[Export("offsetWidth")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selOffsetWidthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selOffsetWidthHandle);
		}
	}

	public virtual int OffsetHeight
	{
		[Export("offsetHeight")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selOffsetHeightHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selOffsetHeightHandle);
		}
	}

	public virtual DomElement OffsetParent
	{
		[Export("offsetParent")]
		get
		{
			return (DomElement)(__mt_OffsetParent_var = ((!IsDirectBinding) ? ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOffsetParentHandle))) : ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOffsetParentHandle)))));
		}
	}

	public virtual int ClientLeft
	{
		[Export("clientLeft")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selClientLeftHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selClientLeftHandle);
		}
	}

	public virtual int ClientTop
	{
		[Export("clientTop")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selClientTopHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selClientTopHandle);
		}
	}

	public virtual int ClientWidth
	{
		[Export("clientWidth")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selClientWidthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selClientWidthHandle);
		}
	}

	public virtual int ClientHeight
	{
		[Export("clientHeight")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selClientHeightHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selClientHeightHandle);
		}
	}

	public virtual int ScrollLeft
	{
		[Export("scrollLeft")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selScrollLeftHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selScrollLeftHandle);
		}
		[Export("setScrollLeft:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetScrollLeft_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetScrollLeft_Handle, value);
			}
		}
	}

	public virtual int ScrollTop
	{
		[Export("scrollTop")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selScrollTopHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selScrollTopHandle);
		}
		[Export("setScrollTop:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetScrollTop_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetScrollTop_Handle, value);
			}
		}
	}

	public virtual int ScrollWidth
	{
		[Export("scrollWidth")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selScrollWidthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selScrollWidthHandle);
		}
	}

	public virtual int ScrollHeight
	{
		[Export("scrollHeight")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selScrollHeightHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selScrollHeightHandle);
		}
	}

	public virtual DomElement FirstElementChild
	{
		[Export("firstElementChild")]
		get
		{
			return (DomElement)(__mt_FirstElementChild_var = ((!IsDirectBinding) ? ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFirstElementChildHandle))) : ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFirstElementChildHandle)))));
		}
	}

	public virtual DomElement LastElementChild
	{
		[Export("lastElementChild")]
		get
		{
			return (DomElement)(__mt_LastElementChild_var = ((!IsDirectBinding) ? ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastElementChildHandle))) : ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLastElementChildHandle)))));
		}
	}

	public virtual DomElement PreviousElementSibling
	{
		[Export("previousElementSibling")]
		get
		{
			return (DomElement)(__mt_PreviousElementSibling_var = ((!IsDirectBinding) ? ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviousElementSiblingHandle))) : ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviousElementSiblingHandle)))));
		}
	}

	public virtual DomElement NextElementSibling
	{
		[Export("nextElementSibling")]
		get
		{
			return (DomElement)(__mt_NextElementSibling_var = ((!IsDirectBinding) ? ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextElementSiblingHandle))) : ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selNextElementSiblingHandle)))));
		}
	}

	public virtual uint ChildElementCount
	{
		[Export("childElementCount")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selChildElementCountHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selChildElementCountHandle);
		}
	}

	public virtual string InnerText
	{
		[Export("innerText")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInnerTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInnerTextHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomElement(NSCoder coder)
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
	public DomElement(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomElement(IntPtr handle)
		: base(handle)
	{
	}

	[Export("getAttribute:")]
	public virtual string GetAttribute(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetAttribute_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetAttribute_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setAttribute:value:")]
	public virtual void SetAttribute(string name, string value)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr arg = NSString.CreateNative(name);
		IntPtr arg2 = NSString.CreateNative(value);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetAttributeValue_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetAttributeValue_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("removeAttribute:")]
	public virtual void RemoveAttribute(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAttribute_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAttribute_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("getAttributeNode:")]
	public virtual DomAttr GetAttributeNode(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		DomAttr result = ((!IsDirectBinding) ? ((DomAttr)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetAttributeNode_Handle, arg))) : ((DomAttr)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetAttributeNode_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setAttributeNode:")]
	public virtual DomAttr SetAttributeNode(DomAttr newAttr)
	{
		if (newAttr == null)
		{
			throw new ArgumentNullException("newAttr");
		}
		if (IsDirectBinding)
		{
			return (DomAttr)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSetAttributeNode_Handle, newAttr.Handle));
		}
		return (DomAttr)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributeNode_Handle, newAttr.Handle));
	}

	[Export("removeAttributeNode:")]
	public virtual DomAttr RemoveAttributeNode(DomAttr oldAttr)
	{
		if (oldAttr == null)
		{
			throw new ArgumentNullException("oldAttr");
		}
		if (IsDirectBinding)
		{
			return (DomAttr)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRemoveAttributeNode_Handle, oldAttr.Handle));
		}
		return (DomAttr)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAttributeNode_Handle, oldAttr.Handle));
	}

	[Export("getElementsByTagName:")]
	public virtual DomNodeList GetElementsByTagName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		DomNodeList result = ((!IsDirectBinding) ? ((DomNodeList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetElementsByTagName_Handle, arg))) : ((DomNodeList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetElementsByTagName_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getAttributeNS:localName:")]
	public virtual string GetAttributeNS(string namespaceURI, string localName)
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
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetAttributeNSLocalName_Handle, arg, arg2)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetAttributeNSLocalName_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("setAttributeNS:qualifiedName:value:")]
	public virtual void SetAttributeNS(string namespaceURI, string qualifiedName, string value)
	{
		if (namespaceURI == null)
		{
			throw new ArgumentNullException("namespaceURI");
		}
		if (qualifiedName == null)
		{
			throw new ArgumentNullException("qualifiedName");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr arg = NSString.CreateNative(namespaceURI);
		IntPtr arg2 = NSString.CreateNative(qualifiedName);
		IntPtr arg3 = NSString.CreateNative(value);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSetAttributeNSQualifiedNameValue_Handle, arg, arg2, arg3);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetAttributeNSQualifiedNameValue_Handle, arg, arg2, arg3);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("removeAttributeNS:localName:")]
	public virtual void RemoveAttributeNS(string namespaceURI, string localName)
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
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveAttributeNSLocalName_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveAttributeNSLocalName_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("getElementsByTagNameNS:localName:")]
	public virtual DomNodeList GetElementsByTagNameNS(string namespaceURI, string localName)
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
		DomNodeList result = ((!IsDirectBinding) ? ((DomNodeList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetElementsByTagNameNSLocalName_Handle, arg, arg2))) : ((DomNodeList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetElementsByTagNameNSLocalName_Handle, arg, arg2))));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("getAttributeNodeNS:localName:")]
	public virtual DomAttr GetAttributeNodeNS(string namespaceURI, string localName)
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
		DomAttr result = ((!IsDirectBinding) ? ((DomAttr)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetAttributeNodeNSLocalName_Handle, arg, arg2))) : ((DomAttr)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetAttributeNodeNSLocalName_Handle, arg, arg2))));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("setAttributeNodeNS:")]
	public virtual DomAttr SetAttributeNodeNS(DomAttr newAttr)
	{
		if (newAttr == null)
		{
			throw new ArgumentNullException("newAttr");
		}
		if (IsDirectBinding)
		{
			return (DomAttr)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSetAttributeNodeNS_Handle, newAttr.Handle));
		}
		return (DomAttr)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributeNodeNS_Handle, newAttr.Handle));
	}

	[Export("hasAttribute:")]
	public virtual bool HasAttribute(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasAttribute_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasAttribute_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("hasAttributeNS:localName:")]
	public virtual bool HasAttributeNS(string namespaceURI, string localName)
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
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selHasAttributeNSLocalName_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selHasAttributeNSLocalName_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("focus")]
	public virtual void Focus()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFocusHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFocusHandle);
		}
	}

	[Export("blur")]
	public virtual void Blur()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBlurHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBlurHandle);
		}
	}

	[Export("scrollIntoView:")]
	public virtual void ScrollIntoView(bool alignWithTop)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selScrollIntoView_Handle, alignWithTop);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selScrollIntoView_Handle, alignWithTop);
		}
	}

	[Export("contains:")]
	public virtual bool Contains(DomElement element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContains_Handle, element.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContains_Handle, element.Handle);
	}

	[Export("scrollIntoViewIfNeeded:")]
	public virtual void ScrollIntoViewIfNeeded(bool centerIfNeeded)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selScrollIntoViewIfNeeded_Handle, centerIfNeeded);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selScrollIntoViewIfNeeded_Handle, centerIfNeeded);
		}
	}

	[Export("scrollByLines:")]
	public virtual void ScrollByLines(int lines)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selScrollByLines_Handle, lines);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selScrollByLines_Handle, lines);
		}
	}

	[Export("scrollByPages:")]
	public virtual void ScrollByPages(int pages)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selScrollByPages_Handle, pages);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selScrollByPages_Handle, pages);
		}
	}

	[Export("getElementsByClassName:")]
	public virtual DomNodeList GetElementsByClassName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		DomNodeList result = ((!IsDirectBinding) ? ((DomNodeList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetElementsByClassName_Handle, arg))) : ((DomNodeList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetElementsByClassName_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("querySelector:")]
	public virtual DomElement QuerySelector(string selectors)
	{
		if (selectors == null)
		{
			throw new ArgumentNullException("selectors");
		}
		IntPtr arg = NSString.CreateNative(selectors);
		DomElement result = ((!IsDirectBinding) ? ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selQuerySelector_Handle, arg))) : ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selQuerySelector_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("querySelectorAll:")]
	public virtual DomNodeList QuerySelectorAll(string selectors)
	{
		if (selectors == null)
		{
			throw new ArgumentNullException("selectors");
		}
		IntPtr arg = NSString.CreateNative(selectors);
		DomNodeList result = ((!IsDirectBinding) ? ((DomNodeList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selQuerySelectorAll_Handle, arg))) : ((DomNodeList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selQuerySelectorAll_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_OffsetParent_var = null;
			__mt_FirstElementChild_var = null;
			__mt_LastElementChild_var = null;
			__mt_PreviousElementSibling_var = null;
			__mt_NextElementSibling_var = null;
		}
	}
}
