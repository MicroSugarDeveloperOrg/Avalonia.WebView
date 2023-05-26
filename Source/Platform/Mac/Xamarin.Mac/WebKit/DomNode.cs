using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMNode", true)]
public class DomNode : DomObject
{
	internal class DomNodeEventProxy : DomEventListener
	{
		private DomEventListenerHandler handler;

		private DomNode root;

		public DomNodeEventProxy(DomNode root, DomEventListenerHandler handler)
		{
			this.root = root;
			this.handler = handler;
		}

		public override void HandleEvent(DomEvent evt)
		{
			handler(root, new DomEventArgs(evt));
		}
	}

	internal class DomNodeEventProxy2 : DomEventListener
	{
		private Action<DomEvent> callback;

		public DomNodeEventProxy2(Action<DomEvent> callback)
		{
			this.callback = callback;
		}

		public override void HandleEvent(DomEvent evt)
		{
			callback(evt);
		}
	}

	private static readonly IntPtr selNodeNameHandle = Selector.GetHandle("nodeName");

	private static readonly IntPtr selNodeValueHandle = Selector.GetHandle("nodeValue");

	private static readonly IntPtr selSetNodeValue_Handle = Selector.GetHandle("setNodeValue:");

	private static readonly IntPtr selNodeTypeHandle = Selector.GetHandle("nodeType");

	private static readonly IntPtr selParentNodeHandle = Selector.GetHandle("parentNode");

	private static readonly IntPtr selChildNodesHandle = Selector.GetHandle("childNodes");

	private static readonly IntPtr selFirstChildHandle = Selector.GetHandle("firstChild");

	private static readonly IntPtr selLastChildHandle = Selector.GetHandle("lastChild");

	private static readonly IntPtr selPreviousSiblingHandle = Selector.GetHandle("previousSibling");

	private static readonly IntPtr selNextSiblingHandle = Selector.GetHandle("nextSibling");

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	private static readonly IntPtr selOwnerDocumentHandle = Selector.GetHandle("ownerDocument");

	private static readonly IntPtr selNamespaceURIHandle = Selector.GetHandle("namespaceURI");

	private static readonly IntPtr selPrefixHandle = Selector.GetHandle("prefix");

	private static readonly IntPtr selSetPrefix_Handle = Selector.GetHandle("setPrefix:");

	private static readonly IntPtr selLocalNameHandle = Selector.GetHandle("localName");

	private static readonly IntPtr selBaseURIHandle = Selector.GetHandle("baseURI");

	private static readonly IntPtr selTextContentHandle = Selector.GetHandle("textContent");

	private static readonly IntPtr selSetTextContent_Handle = Selector.GetHandle("setTextContent:");

	private static readonly IntPtr selParentElementHandle = Selector.GetHandle("parentElement");

	private static readonly IntPtr selIsContentEditableHandle = Selector.GetHandle("isContentEditable");

	private static readonly IntPtr selInsertBeforeRefChild_Handle = Selector.GetHandle("insertBefore:refChild:");

	private static readonly IntPtr selReplaceChildOldChild_Handle = Selector.GetHandle("replaceChild:oldChild:");

	private static readonly IntPtr selRemoveChild_Handle = Selector.GetHandle("removeChild:");

	private static readonly IntPtr selAppendChild_Handle = Selector.GetHandle("appendChild:");

	private static readonly IntPtr selHasChildNodesHandle = Selector.GetHandle("hasChildNodes");

	private static readonly IntPtr selCloneNode_Handle = Selector.GetHandle("cloneNode:");

	private static readonly IntPtr selNormalizeHandle = Selector.GetHandle("normalize");

	private static readonly IntPtr selIsSupportedVersion_Handle = Selector.GetHandle("isSupported:version:");

	private static readonly IntPtr selHasAttributesHandle = Selector.GetHandle("hasAttributes");

	private static readonly IntPtr selIsSameNode_Handle = Selector.GetHandle("isSameNode:");

	private static readonly IntPtr selIsEqualNode_Handle = Selector.GetHandle("isEqualNode:");

	private static readonly IntPtr selLookupPrefix_Handle = Selector.GetHandle("lookupPrefix:");

	private static readonly IntPtr selIsDefaultNamespace_Handle = Selector.GetHandle("isDefaultNamespace:");

	private static readonly IntPtr selLookupNamespaceURI_Handle = Selector.GetHandle("lookupNamespaceURI:");

	private static readonly IntPtr selCompareDocumentPosition_Handle = Selector.GetHandle("compareDocumentPosition:");

	private static readonly IntPtr selAddEventListenerListenerUseCapture_Handle = Selector.GetHandle("addEventListener:listener:useCapture:");

	private static readonly IntPtr selRemoveEventListenerListenerUseCapture_Handle = Selector.GetHandle("removeEventListener:listener:useCapture:");

	private static readonly IntPtr selDispatchEvent_Handle = Selector.GetHandle("dispatchEvent:");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMNode");

	private object __mt_ParentNode_var;

	private object __mt_ChildNodes_var;

	private object __mt_FirstChild_var;

	private object __mt_LastChild_var;

	private object __mt_PreviousSibling_var;

	private object __mt_NextSibling_var;

	private object __mt_Attributes_var;

	private object __mt_OwnerDocument_var;

	private object __mt_ParentElement_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Name
	{
		[Export("nodeName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNodeNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNodeNameHandle));
		}
	}

	public virtual string NodeValue
	{
		[Export("nodeValue")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNodeValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNodeValueHandle));
		}
		[Export("setNodeValue:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetNodeValue_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetNodeValue_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual DomNodeType NodeType
	{
		[Export("nodeType")]
		get
		{
			if (IsDirectBinding)
			{
				return (DomNodeType)Messaging.UInt16_objc_msgSend(base.Handle, selNodeTypeHandle);
			}
			return (DomNodeType)Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selNodeTypeHandle);
		}
	}

	public virtual DomNode ParentNode
	{
		[Export("parentNode")]
		get
		{
			return (DomNode)(__mt_ParentNode_var = ((!IsDirectBinding) ? ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentNodeHandle))) : ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selParentNodeHandle)))));
		}
	}

	public virtual DomNodeList ChildNodes
	{
		[Export("childNodes")]
		get
		{
			return (DomNodeList)(__mt_ChildNodes_var = ((!IsDirectBinding) ? ((DomNodeList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChildNodesHandle))) : ((DomNodeList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selChildNodesHandle)))));
		}
	}

	public virtual DomNode FirstChild
	{
		[Export("firstChild")]
		get
		{
			return (DomNode)(__mt_FirstChild_var = ((!IsDirectBinding) ? ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFirstChildHandle))) : ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFirstChildHandle)))));
		}
	}

	public virtual DomNode LastChild
	{
		[Export("lastChild")]
		get
		{
			return (DomNode)(__mt_LastChild_var = ((!IsDirectBinding) ? ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastChildHandle))) : ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLastChildHandle)))));
		}
	}

	public virtual DomNode PreviousSibling
	{
		[Export("previousSibling")]
		get
		{
			return (DomNode)(__mt_PreviousSibling_var = ((!IsDirectBinding) ? ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviousSiblingHandle))) : ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviousSiblingHandle)))));
		}
	}

	public virtual DomNode NextSibling
	{
		[Export("nextSibling")]
		get
		{
			return (DomNode)(__mt_NextSibling_var = ((!IsDirectBinding) ? ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextSiblingHandle))) : ((DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selNextSiblingHandle)))));
		}
	}

	public virtual DomNamedNodeMap Attributes
	{
		[Export("attributes")]
		get
		{
			return (DomNamedNodeMap)(__mt_Attributes_var = ((!IsDirectBinding) ? ((DomNamedNodeMap)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesHandle))) : ((DomNamedNodeMap)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesHandle)))));
		}
	}

	public virtual DomDocument OwnerDocument
	{
		[Export("ownerDocument")]
		get
		{
			return (DomDocument)(__mt_OwnerDocument_var = ((!IsDirectBinding) ? ((DomDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOwnerDocumentHandle))) : ((DomDocument)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selOwnerDocumentHandle)))));
		}
	}

	public virtual string NamespaceURI
	{
		[Export("namespaceURI")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNamespaceURIHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNamespaceURIHandle));
		}
	}

	public virtual string Prefix
	{
		[Export("prefix")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPrefixHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrefixHandle));
		}
		[Export("setPrefix:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetPrefix_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetPrefix_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string LocalName
	{
		[Export("localName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalNameHandle));
		}
	}

	public virtual string BaseURI
	{
		[Export("baseURI")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBaseURIHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBaseURIHandle));
		}
	}

	public virtual string TextContent
	{
		[Export("textContent")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTextContentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextContentHandle));
		}
		[Export("setTextContent:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextContent_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextContent_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual DomElement ParentElement
	{
		[Export("parentElement")]
		get
		{
			return (DomElement)(__mt_ParentElement_var = ((!IsDirectBinding) ? ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentElementHandle))) : ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selParentElementHandle)))));
		}
	}

	public virtual bool IsContentEditable
	{
		[Export("isContentEditable")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsContentEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsContentEditableHandle);
		}
	}

	public DomEventListener AddEventListener(string type, DomEventListenerHandler handler, bool useCapture)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		DomNodeEventProxy domNodeEventProxy = new DomNodeEventProxy(this, handler);
		AddEventListener(type, domNodeEventProxy, useCapture);
		return domNodeEventProxy;
	}

	public DomEventListener AddEventListener(string type, Action<DomEvent> callback, bool useCapture)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		DomNodeEventProxy2 domNodeEventProxy = new DomNodeEventProxy2(callback);
		AddEventListener(type, domNodeEventProxy, useCapture);
		return domNodeEventProxy;
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomNode(NSCoder coder)
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
	public DomNode(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("insertBefore:refChild:")]
	public virtual DomNode InsertBefore(DomNode newChild, DomNode refChild)
	{
		if (newChild == null)
		{
			throw new ArgumentNullException("newChild");
		}
		if (IsDirectBinding)
		{
			return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertBeforeRefChild_Handle, newChild.Handle, refChild?.Handle ?? IntPtr.Zero));
		}
		return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertBeforeRefChild_Handle, newChild.Handle, refChild?.Handle ?? IntPtr.Zero));
	}

	[Export("replaceChild:oldChild:")]
	public virtual DomNode ReplaceChild(DomNode newChild, DomNode oldChild)
	{
		if (newChild == null)
		{
			throw new ArgumentNullException("newChild");
		}
		if (oldChild == null)
		{
			throw new ArgumentNullException("oldChild");
		}
		if (IsDirectBinding)
		{
			return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selReplaceChildOldChild_Handle, newChild.Handle, oldChild.Handle));
		}
		return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReplaceChildOldChild_Handle, newChild.Handle, oldChild.Handle));
	}

	[Export("removeChild:")]
	public virtual DomNode RemoveChild(DomNode oldChild)
	{
		if (oldChild == null)
		{
			throw new ArgumentNullException("oldChild");
		}
		if (IsDirectBinding)
		{
			return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRemoveChild_Handle, oldChild.Handle));
		}
		return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveChild_Handle, oldChild.Handle));
	}

	[Export("appendChild:")]
	public virtual DomNode AppendChild(DomNode newChild)
	{
		if (newChild == null)
		{
			throw new ArgumentNullException("newChild");
		}
		if (IsDirectBinding)
		{
			return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAppendChild_Handle, newChild.Handle));
		}
		return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendChild_Handle, newChild.Handle));
	}

	[Export("hasChildNodes")]
	public virtual bool HasChildNodes()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selHasChildNodesHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasChildNodesHandle);
	}

	[Export("cloneNode:")]
	public virtual DomNode CloneNode(bool deep)
	{
		if (IsDirectBinding)
		{
			return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_bool(base.Handle, selCloneNode_Handle, deep));
		}
		return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_bool(base.SuperHandle, selCloneNode_Handle, deep));
	}

	[Export("normalize")]
	public virtual void Normalize()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selNormalizeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selNormalizeHandle);
		}
	}

	[Export("isSupported:version:")]
	public virtual bool IsSupported(string feature, string version)
	{
		if (feature == null)
		{
			throw new ArgumentNullException("feature");
		}
		if (version == null)
		{
			throw new ArgumentNullException("version");
		}
		IntPtr arg = NSString.CreateNative(feature);
		IntPtr arg2 = NSString.CreateNative(version);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selIsSupportedVersion_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selIsSupportedVersion_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("hasAttributes")]
	public virtual bool HasAttributes()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selHasAttributesHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasAttributesHandle);
	}

	[Export("isSameNode:")]
	public virtual bool IsSameNode(DomNode other)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsSameNode_Handle, other?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsSameNode_Handle, other?.Handle ?? IntPtr.Zero);
	}

	[Export("isEqualNode:")]
	public virtual bool IsEqualNode(DomNode other)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualNode_Handle, other?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualNode_Handle, other?.Handle ?? IntPtr.Zero);
	}

	[Export("lookupPrefix:")]
	public virtual string LookupPrefix(string namespaceURI)
	{
		if (namespaceURI == null)
		{
			throw new ArgumentNullException("namespaceURI");
		}
		IntPtr arg = NSString.CreateNative(namespaceURI);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLookupPrefix_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLookupPrefix_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isDefaultNamespace:")]
	public virtual bool IsDefaultNamespace(string namespaceURI)
	{
		if (namespaceURI == null)
		{
			throw new ArgumentNullException("namespaceURI");
		}
		IntPtr arg = NSString.CreateNative(namespaceURI);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsDefaultNamespace_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsDefaultNamespace_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("lookupNamespaceURI:")]
	public virtual string LookupNamespace(string prefix)
	{
		if (prefix == null)
		{
			throw new ArgumentNullException("prefix");
		}
		IntPtr arg = NSString.CreateNative(prefix);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLookupNamespaceURI_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLookupNamespaceURI_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("compareDocumentPosition:")]
	public virtual DomDocumentPosition CompareDocumentPosition(DomNode other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			return (DomDocumentPosition)Messaging.UInt16_objc_msgSend_IntPtr(base.Handle, selCompareDocumentPosition_Handle, other.Handle);
		}
		return (DomDocumentPosition)Messaging.UInt16_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompareDocumentPosition_Handle, other.Handle);
	}

	[Export("addEventListener:listener:useCapture:")]
	public virtual void AddEventListener(string type, DomEventListener listener, bool useCapture)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		IntPtr arg = NSString.CreateNative(type);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selAddEventListenerListenerUseCapture_Handle, arg, listener.Handle, useCapture);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selAddEventListenerListenerUseCapture_Handle, arg, listener.Handle, useCapture);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeEventListener:listener:useCapture:")]
	public virtual void RemoveEventListener(string type, DomEventListener listener, bool useCapture)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		if (listener == null)
		{
			throw new ArgumentNullException("listener");
		}
		IntPtr arg = NSString.CreateNative(type);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selRemoveEventListenerListenerUseCapture_Handle, arg, listener.Handle, useCapture);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selRemoveEventListenerListenerUseCapture_Handle, arg, listener.Handle, useCapture);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("dispatchEvent:")]
	public virtual bool DispatchEvent(DomEvent evt)
	{
		if (evt == null)
		{
			throw new ArgumentNullException("evt");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selDispatchEvent_Handle, evt.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selDispatchEvent_Handle, evt.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ParentNode_var = null;
			__mt_ChildNodes_var = null;
			__mt_FirstChild_var = null;
			__mt_LastChild_var = null;
			__mt_PreviousSibling_var = null;
			__mt_NextSibling_var = null;
			__mt_Attributes_var = null;
			__mt_OwnerDocument_var = null;
			__mt_ParentElement_var = null;
		}
	}
}
