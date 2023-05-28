using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMNode", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomNode : DomObject, IDomEventTarget, INativeObject, IDisposable, INSCopying
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddEventListener_Listener_UseCapture_ = "addEventListener:listener:useCapture:";

	private static readonly IntPtr selAddEventListener_Listener_UseCapture_Handle = Selector.GetHandle("addEventListener:listener:useCapture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendChild_ = "appendChild:";

	private static readonly IntPtr selAppendChild_Handle = Selector.GetHandle("appendChild:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributes = "attributes";

	private static readonly IntPtr selAttributesHandle = Selector.GetHandle("attributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBaseURI = "baseURI";

	private static readonly IntPtr selBaseURIHandle = Selector.GetHandle("baseURI");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChildNodes = "childNodes";

	private static readonly IntPtr selChildNodesHandle = Selector.GetHandle("childNodes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCloneNode_ = "cloneNode:";

	private static readonly IntPtr selCloneNode_Handle = Selector.GetHandle("cloneNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompareDocumentPosition_ = "compareDocumentPosition:";

	private static readonly IntPtr selCompareDocumentPosition_Handle = Selector.GetHandle("compareDocumentPosition:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDispatchEvent_ = "dispatchEvent:";

	private static readonly IntPtr selDispatchEvent_Handle = Selector.GetHandle("dispatchEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstChild = "firstChild";

	private static readonly IntPtr selFirstChildHandle = Selector.GetHandle("firstChild");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasAttributes = "hasAttributes";

	private static readonly IntPtr selHasAttributesHandle = Selector.GetHandle("hasAttributes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasChildNodes = "hasChildNodes";

	private static readonly IntPtr selHasChildNodesHandle = Selector.GetHandle("hasChildNodes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertBefore_RefChild_ = "insertBefore:refChild:";

	private static readonly IntPtr selInsertBefore_RefChild_Handle = Selector.GetHandle("insertBefore:refChild:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsContentEditable = "isContentEditable";

	private static readonly IntPtr selIsContentEditableHandle = Selector.GetHandle("isContentEditable");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsDefaultNamespace_ = "isDefaultNamespace:";

	private static readonly IntPtr selIsDefaultNamespace_Handle = Selector.GetHandle("isDefaultNamespace:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualNode_ = "isEqualNode:";

	private static readonly IntPtr selIsEqualNode_Handle = Selector.GetHandle("isEqualNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSameNode_ = "isSameNode:";

	private static readonly IntPtr selIsSameNode_Handle = Selector.GetHandle("isSameNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSupported_Version_ = "isSupported:version:";

	private static readonly IntPtr selIsSupported_Version_Handle = Selector.GetHandle("isSupported:version:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastChild = "lastChild";

	private static readonly IntPtr selLastChildHandle = Selector.GetHandle("lastChild");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalName = "localName";

	private static readonly IntPtr selLocalNameHandle = Selector.GetHandle("localName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLookupNamespaceURI_ = "lookupNamespaceURI:";

	private static readonly IntPtr selLookupNamespaceURI_Handle = Selector.GetHandle("lookupNamespaceURI:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLookupPrefix_ = "lookupPrefix:";

	private static readonly IntPtr selLookupPrefix_Handle = Selector.GetHandle("lookupPrefix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNamespaceURI = "namespaceURI";

	private static readonly IntPtr selNamespaceURIHandle = Selector.GetHandle("namespaceURI");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextSibling = "nextSibling";

	private static readonly IntPtr selNextSiblingHandle = Selector.GetHandle("nextSibling");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeName = "nodeName";

	private static readonly IntPtr selNodeNameHandle = Selector.GetHandle("nodeName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeType = "nodeType";

	private static readonly IntPtr selNodeTypeHandle = Selector.GetHandle("nodeType");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNodeValue = "nodeValue";

	private static readonly IntPtr selNodeValueHandle = Selector.GetHandle("nodeValue");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNormalize = "normalize";

	private static readonly IntPtr selNormalizeHandle = Selector.GetHandle("normalize");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOwnerDocument = "ownerDocument";

	private static readonly IntPtr selOwnerDocumentHandle = Selector.GetHandle("ownerDocument");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParentElement = "parentElement";

	private static readonly IntPtr selParentElementHandle = Selector.GetHandle("parentElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParentNode = "parentNode";

	private static readonly IntPtr selParentNodeHandle = Selector.GetHandle("parentNode");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPrefix = "prefix";

	private static readonly IntPtr selPrefixHandle = Selector.GetHandle("prefix");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviousSibling = "previousSibling";

	private static readonly IntPtr selPreviousSiblingHandle = Selector.GetHandle("previousSibling");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveChild_ = "removeChild:";

	private static readonly IntPtr selRemoveChild_Handle = Selector.GetHandle("removeChild:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveEventListener_Listener_UseCapture_ = "removeEventListener:listener:useCapture:";

	private static readonly IntPtr selRemoveEventListener_Listener_UseCapture_Handle = Selector.GetHandle("removeEventListener:listener:useCapture:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceChild_OldChild_ = "replaceChild:oldChild:";

	private static readonly IntPtr selReplaceChild_OldChild_Handle = Selector.GetHandle("replaceChild:oldChild:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetNodeValue_ = "setNodeValue:";

	private static readonly IntPtr selSetNodeValue_Handle = Selector.GetHandle("setNodeValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPrefix_ = "setPrefix:";

	private static readonly IntPtr selSetPrefix_Handle = Selector.GetHandle("setPrefix:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTextContent_ = "setTextContent:";

	private static readonly IntPtr selSetTextContent_Handle = Selector.GetHandle("setTextContent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTextContent = "textContent";

	private static readonly IntPtr selTextContentHandle = Selector.GetHandle("textContent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMNode");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNamedNodeMap Attributes
	{
		[Export("attributes", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomNamedNodeMap>(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributesHandle));
			}
			return Runtime.GetNSObject<DomNamedNodeMap>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string BaseURI
	{
		[Export("baseURI", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBaseURIHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBaseURIHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNodeList ChildNodes
	{
		[Export("childNodes", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomNodeList>(Messaging.IntPtr_objc_msgSend(base.Handle, selChildNodesHandle));
			}
			return Runtime.GetNSObject<DomNodeList>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChildNodesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode FirstChild
	{
		[Export("firstChild", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selFirstChildHandle));
			}
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFirstChildHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsContentEditable
	{
		[Export("isContentEditable")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsContentEditableHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsContentEditableHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode LastChild
	{
		[Export("lastChild", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selLastChildHandle));
			}
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastChildHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LocalName
	{
		[Export("localName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Name
	{
		[Export("nodeName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNodeNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNodeNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string NamespaceURI
	{
		[Export("namespaceURI", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNamespaceURIHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNamespaceURIHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode NextSibling
	{
		[Export("nextSibling", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selNextSiblingHandle));
			}
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextSiblingHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNodeType NodeType
	{
		[Export("nodeType")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (DomNodeType)Messaging.UInt16_objc_msgSend(base.Handle, selNodeTypeHandle);
			}
			return (DomNodeType)Messaging.UInt16_objc_msgSendSuper(base.SuperHandle, selNodeTypeHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string NodeValue
	{
		[Export("nodeValue", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selNodeValueHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNodeValueHandle));
		}
		[Export("setNodeValue:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomDocument OwnerDocument
	{
		[Export("ownerDocument", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomDocument>(Messaging.IntPtr_objc_msgSend(base.Handle, selOwnerDocumentHandle));
			}
			return Runtime.GetNSObject<DomDocument>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOwnerDocumentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomElement ParentElement
	{
		[Export("parentElement", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentElementHandle));
			}
			return Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentElementHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode ParentNode
	{
		[Export("parentNode", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentNodeHandle));
			}
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentNodeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Prefix
	{
		[Export("prefix", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPrefixHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPrefixHandle));
		}
		[Export("setPrefix:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode PreviousSibling
	{
		[Export("previousSibling", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviousSiblingHandle));
			}
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviousSiblingHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string TextContent
	{
		[Export("textContent", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTextContentHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextContentHandle));
		}
		[Export("setTextContent:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomNode(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomNode(IntPtr handle)
		: base(handle)
	{
	}

	[Export("addEventListener:listener:useCapture:")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddEventListener(string type, IDomEventListener listener, bool useCapture)
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selAddEventListener_Listener_UseCapture_Handle, arg, listener.Handle, useCapture);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selAddEventListener_Listener_UseCapture_Handle, arg, listener.Handle, useCapture);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("appendChild:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode AppendChild(DomNode newChild)
	{
		if (newChild == null)
		{
			throw new ArgumentNullException("newChild");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAppendChild_Handle, newChild.Handle));
		}
		return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendChild_Handle, newChild.Handle));
	}

	[Export("cloneNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode CloneNode(bool deep)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_bool(base.Handle, selCloneNode_Handle, deep));
		}
		return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_bool(base.SuperHandle, selCloneNode_Handle, deep));
	}

	[Export("compareDocumentPosition:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomDocumentPosition CompareDocumentPosition(DomNode other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			return (DomDocumentPosition)Messaging.UInt16_objc_msgSend_IntPtr(base.Handle, selCompareDocumentPosition_Handle, other.Handle);
		}
		return (DomDocumentPosition)Messaging.UInt16_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompareDocumentPosition_Handle, other.Handle);
	}

	[Export("copyWithZone:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: Release]
	public new virtual NSObject Copy(NSZone? zone)
	{
		NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
		if (nSObject != null)
		{
			Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
		}
		return nSObject;
	}

	[Export("dispatchEvent:")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DispatchEvent(DomEvent evt)
	{
		if (evt == null)
		{
			throw new ArgumentNullException("evt");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selDispatchEvent_Handle, evt.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selDispatchEvent_Handle, evt.Handle);
	}

	[Export("hasAttributes")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasAttributes()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selHasAttributesHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasAttributesHandle);
	}

	[Export("hasChildNodes")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasChildNodes()
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selHasChildNodesHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasChildNodesHandle);
	}

	[Export("insertBefore:refChild:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode InsertBefore(DomNode newChild, DomNode? refChild)
	{
		if (newChild == null)
		{
			throw new ArgumentNullException("newChild");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInsertBefore_RefChild_Handle, newChild.Handle, refChild?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInsertBefore_RefChild_Handle, newChild.Handle, refChild?.Handle ?? IntPtr.Zero));
	}

	[Export("isDefaultNamespace:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsDefaultNamespace(string namespaceURI)
	{
		if (namespaceURI == null)
		{
			throw new ArgumentNullException("namespaceURI");
		}
		IntPtr arg = NSString.CreateNative(namespaceURI);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsDefaultNamespace_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsDefaultNamespace_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isEqualNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqualNode(DomNode? other)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualNode_Handle, other?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualNode_Handle, other?.Handle ?? IntPtr.Zero);
	}

	[Export("isSameNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSameNode(DomNode? other)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsSameNode_Handle, other?.Handle ?? IntPtr.Zero);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsSameNode_Handle, other?.Handle ?? IntPtr.Zero);
	}

	[Export("isSupported:version:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selIsSupported_Version_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selIsSupported_Version_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("lookupNamespaceURI:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LookupNamespace(string prefix)
	{
		if (prefix == null)
		{
			throw new ArgumentNullException("prefix");
		}
		IntPtr arg = NSString.CreateNative(prefix);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLookupNamespaceURI_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLookupNamespaceURI_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("lookupPrefix:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LookupPrefix(string namespaceURI)
	{
		if (namespaceURI == null)
		{
			throw new ArgumentNullException("namespaceURI");
		}
		IntPtr arg = NSString.CreateNative(namespaceURI);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLookupPrefix_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLookupPrefix_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("normalize")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Normalize()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selNormalizeHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selNormalizeHandle);
		}
	}

	[Export("removeChild:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode RemoveChild(DomNode oldChild)
	{
		if (oldChild == null)
		{
			throw new ArgumentNullException("oldChild");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRemoveChild_Handle, oldChild.Handle));
		}
		return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveChild_Handle, oldChild.Handle));
	}

	[Export("removeEventListener:listener:useCapture:")]
	[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveEventListener(string type, IDomEventListener listener, bool useCapture)
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selRemoveEventListener_Listener_UseCapture_Handle, arg, listener.Handle, useCapture);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selRemoveEventListener_Listener_UseCapture_Handle, arg, listener.Handle, useCapture);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("replaceChild:oldChild:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selReplaceChild_OldChild_Handle, newChild.Handle, oldChild.Handle));
		}
		return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selReplaceChild_OldChild_Handle, newChild.Handle, oldChild.Handle));
	}
}
