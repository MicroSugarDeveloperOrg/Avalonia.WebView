using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMDocument", true)]
public class DomDocument : DomNode
{
	private static readonly IntPtr selDoctypeHandle = Selector.GetHandle("doctype");

	private static readonly IntPtr selImplementationHandle = Selector.GetHandle("implementation");

	private static readonly IntPtr selDocumentElementHandle = Selector.GetHandle("documentElement");

	private static readonly IntPtr selInputEncodingHandle = Selector.GetHandle("inputEncoding");

	private static readonly IntPtr selXmlEncodingHandle = Selector.GetHandle("xmlEncoding");

	private static readonly IntPtr selXmlVersionHandle = Selector.GetHandle("xmlVersion");

	private static readonly IntPtr selSetXmlVersion_Handle = Selector.GetHandle("setXmlVersion:");

	private static readonly IntPtr selXmlStandaloneHandle = Selector.GetHandle("xmlStandalone");

	private static readonly IntPtr selSetXmlStandalone_Handle = Selector.GetHandle("setXmlStandalone:");

	private static readonly IntPtr selDocumentURIHandle = Selector.GetHandle("documentURI");

	private static readonly IntPtr selSetDocumentURI_Handle = Selector.GetHandle("setDocumentURI:");

	private static readonly IntPtr selDefaultViewHandle = Selector.GetHandle("defaultView");

	private static readonly IntPtr selStyleSheetsHandle = Selector.GetHandle("styleSheets");

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	private static readonly IntPtr selReferrerHandle = Selector.GetHandle("referrer");

	private static readonly IntPtr selDomainHandle = Selector.GetHandle("domain");

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	private static readonly IntPtr selCookieHandle = Selector.GetHandle("cookie");

	private static readonly IntPtr selSetCookie_Handle = Selector.GetHandle("setCookie:");

	private static readonly IntPtr selBodyHandle = Selector.GetHandle("body");

	private static readonly IntPtr selSetBody_Handle = Selector.GetHandle("setBody:");

	private static readonly IntPtr selImagesHandle = Selector.GetHandle("images");

	private static readonly IntPtr selAppletsHandle = Selector.GetHandle("applets");

	private static readonly IntPtr selLinksHandle = Selector.GetHandle("links");

	private static readonly IntPtr selFormsHandle = Selector.GetHandle("forms");

	private static readonly IntPtr selAnchorsHandle = Selector.GetHandle("anchors");

	private static readonly IntPtr selLastModifiedHandle = Selector.GetHandle("lastModified");

	private static readonly IntPtr selCharsetHandle = Selector.GetHandle("charset");

	private static readonly IntPtr selSetCharset_Handle = Selector.GetHandle("setCharset:");

	private static readonly IntPtr selDefaultCharsetHandle = Selector.GetHandle("defaultCharset");

	private static readonly IntPtr selReadyStateHandle = Selector.GetHandle("readyState");

	private static readonly IntPtr selCharacterSetHandle = Selector.GetHandle("characterSet");

	private static readonly IntPtr selPreferredStylesheetSetHandle = Selector.GetHandle("preferredStylesheetSet");

	private static readonly IntPtr selSelectedStylesheetSetHandle = Selector.GetHandle("selectedStylesheetSet");

	private static readonly IntPtr selSetSelectedStylesheetSet_Handle = Selector.GetHandle("setSelectedStylesheetSet:");

	private static readonly IntPtr selCreateElement_Handle = Selector.GetHandle("createElement:");

	private static readonly IntPtr selCreateDocumentFragmentHandle = Selector.GetHandle("createDocumentFragment");

	private static readonly IntPtr selCreateTextNode_Handle = Selector.GetHandle("createTextNode:");

	private static readonly IntPtr selCreateComment_Handle = Selector.GetHandle("createComment:");

	private static readonly IntPtr selCreateCDATASection_Handle = Selector.GetHandle("createCDATASection:");

	private static readonly IntPtr selCreateProcessingInstructionData_Handle = Selector.GetHandle("createProcessingInstruction:data:");

	private static readonly IntPtr selCreateAttribute_Handle = Selector.GetHandle("createAttribute:");

	private static readonly IntPtr selCreateEntityReference_Handle = Selector.GetHandle("createEntityReference:");

	private static readonly IntPtr selGetElementsByTagName_Handle = Selector.GetHandle("getElementsByTagName:");

	private static readonly IntPtr selImportNodeDeep_Handle = Selector.GetHandle("importNode:deep:");

	private static readonly IntPtr selCreateElementNSQualifiedName_Handle = Selector.GetHandle("createElementNS:qualifiedName:");

	private static readonly IntPtr selCreateAttributeNSQualifiedName_Handle = Selector.GetHandle("createAttributeNS:qualifiedName:");

	private static readonly IntPtr selGetElementsByTagNameNSLocalName_Handle = Selector.GetHandle("getElementsByTagNameNS:localName:");

	private static readonly IntPtr selGetElementById_Handle = Selector.GetHandle("getElementById:");

	private static readonly IntPtr selAdoptNode_Handle = Selector.GetHandle("adoptNode:");

	private static readonly IntPtr selCreateRangeHandle = Selector.GetHandle("createRange");

	private static readonly IntPtr selGetOverrideStylePseudoElement_Handle = Selector.GetHandle("getOverrideStyle:pseudoElement:");

	private static readonly IntPtr selExecCommandUserInterfaceValue_Handle = Selector.GetHandle("execCommand:userInterface:value:");

	private static readonly IntPtr selExecCommandUserInterface_Handle = Selector.GetHandle("execCommand:userInterface:");

	private static readonly IntPtr selExecCommand_Handle = Selector.GetHandle("execCommand:");

	private static readonly IntPtr selQueryCommandEnabled_Handle = Selector.GetHandle("queryCommandEnabled:");

	private static readonly IntPtr selQueryCommandIndeterm_Handle = Selector.GetHandle("queryCommandIndeterm:");

	private static readonly IntPtr selQueryCommandState_Handle = Selector.GetHandle("queryCommandState:");

	private static readonly IntPtr selQueryCommandSupported_Handle = Selector.GetHandle("queryCommandSupported:");

	private static readonly IntPtr selQueryCommandValue_Handle = Selector.GetHandle("queryCommandValue:");

	private static readonly IntPtr selGetElementsByName_Handle = Selector.GetHandle("getElementsByName:");

	private static readonly IntPtr selElementFromPointY_Handle = Selector.GetHandle("elementFromPoint:y:");

	private static readonly IntPtr selCreateCSSStyleDeclarationHandle = Selector.GetHandle("createCSSStyleDeclaration");

	private static readonly IntPtr selGetComputedStylePseudoElement_Handle = Selector.GetHandle("getComputedStyle:pseudoElement:");

	private static readonly IntPtr selGetMatchedCSSRulesPseudoElement_Handle = Selector.GetHandle("getMatchedCSSRules:pseudoElement:");

	private static readonly IntPtr selGetMatchedCSSRulesPseudoElementAuthorOnly_Handle = Selector.GetHandle("getMatchedCSSRules:pseudoElement:authorOnly:");

	private static readonly IntPtr selGetElementsByClassName_Handle = Selector.GetHandle("getElementsByClassName:");

	private static readonly IntPtr selQuerySelector_Handle = Selector.GetHandle("querySelector:");

	private static readonly IntPtr selQuerySelectorAll_Handle = Selector.GetHandle("querySelectorAll:");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMDocument");

	private object __mt_DocumentType_var;

	private object __mt_Implementation_var;

	private object __mt_DocumentElement_var;

	private object __mt_DefaultView_var;

	private object __mt_StyleSheets_var;

	private object __mt_body_var;

	private object __mt_images_var;

	private object __mt_applets_var;

	private object __mt_links_var;

	private object __mt_forms_var;

	private object __mt_anchors_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual DomDocumentType DocumentType
	{
		[Export("doctype")]
		get
		{
			return (DomDocumentType)(__mt_DocumentType_var = ((!IsDirectBinding) ? ((DomDocumentType)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDoctypeHandle))) : ((DomDocumentType)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDoctypeHandle)))));
		}
	}

	public virtual DomImplementation Implementation
	{
		[Export("implementation")]
		get
		{
			return (DomImplementation)(__mt_Implementation_var = ((!IsDirectBinding) ? ((DomImplementation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImplementationHandle))) : ((DomImplementation)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selImplementationHandle)))));
		}
	}

	public virtual DomElement DocumentElement
	{
		[Export("documentElement")]
		get
		{
			return (DomElement)(__mt_DocumentElement_var = ((!IsDirectBinding) ? ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentElementHandle))) : ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentElementHandle)))));
		}
	}

	public virtual string InputEncoding
	{
		[Export("inputEncoding")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInputEncodingHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputEncodingHandle));
		}
	}

	public virtual string XmlEncoding
	{
		[Export("xmlEncoding")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selXmlEncodingHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selXmlEncodingHandle));
		}
	}

	public virtual string XmlVersion
	{
		[Export("xmlVersion")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selXmlVersionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selXmlVersionHandle));
		}
		[Export("setXmlVersion:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetXmlVersion_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetXmlVersion_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual bool XmlStandalone
	{
		[Export("xmlStandalone")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selXmlStandaloneHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selXmlStandaloneHandle);
		}
		[Export("setXmlStandalone:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetXmlStandalone_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetXmlStandalone_Handle, value);
			}
		}
	}

	public virtual string DocumentURI
	{
		[Export("documentURI")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentURIHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentURIHandle));
		}
		[Export("setDocumentURI:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDocumentURI_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDocumentURI_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual DomAbstractView DefaultView
	{
		[Export("defaultView")]
		get
		{
			return (DomAbstractView)(__mt_DefaultView_var = ((!IsDirectBinding) ? ((DomAbstractView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultViewHandle))) : ((DomAbstractView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultViewHandle)))));
		}
	}

	public virtual DomStyleSheetList StyleSheets
	{
		[Export("styleSheets")]
		get
		{
			return (DomStyleSheetList)(__mt_StyleSheets_var = ((!IsDirectBinding) ? ((DomStyleSheetList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStyleSheetsHandle))) : ((DomStyleSheetList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStyleSheetsHandle)))));
		}
	}

	public virtual string Title
	{
		[Export("title")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTitle_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTitle_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string Referrer
	{
		[Export("referrer")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selReferrerHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReferrerHandle));
		}
	}

	public virtual string Domain
	{
		[Export("domain")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDomainHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDomainHandle));
		}
	}

	public virtual string Url
	{
		[Export("URL")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
	}

	public virtual string Cookie
	{
		[Export("cookie")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCookieHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCookieHandle));
		}
		[Export("setCookie:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCookie_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCookie_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual DomHtmlElement body
	{
		[Export("body")]
		get
		{
			return (DomHtmlElement)(__mt_body_var = ((!IsDirectBinding) ? ((DomHtmlElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBodyHandle))) : ((DomHtmlElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBodyHandle)))));
		}
		[Export("setBody:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBody_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBody_Handle, value.Handle);
			}
			__mt_body_var = value;
		}
	}

	public virtual DomHtmlCollection images
	{
		[Export("images")]
		get
		{
			return (DomHtmlCollection)(__mt_images_var = ((!IsDirectBinding) ? ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImagesHandle))) : ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selImagesHandle)))));
		}
	}

	public virtual DomHtmlCollection applets
	{
		[Export("applets")]
		get
		{
			return (DomHtmlCollection)(__mt_applets_var = ((!IsDirectBinding) ? ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAppletsHandle))) : ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAppletsHandle)))));
		}
	}

	public virtual DomHtmlCollection links
	{
		[Export("links")]
		get
		{
			return (DomHtmlCollection)(__mt_links_var = ((!IsDirectBinding) ? ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLinksHandle))) : ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLinksHandle)))));
		}
	}

	public virtual DomHtmlCollection forms
	{
		[Export("forms")]
		get
		{
			return (DomHtmlCollection)(__mt_forms_var = ((!IsDirectBinding) ? ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormsHandle))) : ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selFormsHandle)))));
		}
	}

	public virtual DomHtmlCollection anchors
	{
		[Export("anchors")]
		get
		{
			return (DomHtmlCollection)(__mt_anchors_var = ((!IsDirectBinding) ? ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnchorsHandle))) : ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAnchorsHandle)))));
		}
	}

	public virtual string LastModified
	{
		[Export("lastModified")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLastModifiedHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastModifiedHandle));
		}
	}

	public virtual string Charset
	{
		[Export("charset")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCharsetHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCharsetHandle));
		}
		[Export("setCharset:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCharset_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCharset_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string DefaultCharset
	{
		[Export("defaultCharset")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultCharsetHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultCharsetHandle));
		}
	}

	public virtual string ReadyState
	{
		[Export("readyState")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selReadyStateHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReadyStateHandle));
		}
	}

	public virtual string CharacterSet
	{
		[Export("characterSet")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCharacterSetHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCharacterSetHandle));
		}
	}

	public virtual string PreferredStylesheetSet
	{
		[Export("preferredStylesheetSet")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferredStylesheetSetHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferredStylesheetSetHandle));
		}
	}

	public virtual string SelectedStylesheetSet
	{
		[Export("selectedStylesheetSet")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedStylesheetSetHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedStylesheetSetHandle));
		}
		[Export("setSelectedStylesheetSet:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSelectedStylesheetSet_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSelectedStylesheetSet_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomDocument(NSCoder coder)
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
	public DomDocument(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomDocument(IntPtr handle)
		: base(handle)
	{
	}

	[Export("createElement:")]
	public virtual DomElement CreateElement(string tagName)
	{
		if (tagName == null)
		{
			throw new ArgumentNullException("tagName");
		}
		IntPtr arg = NSString.CreateNative(tagName);
		DomElement result = ((!IsDirectBinding) ? ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateElement_Handle, arg))) : ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateElement_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("createDocumentFragment")]
	public virtual DomDocumentFragment CreateDocumentFragment()
	{
		if (IsDirectBinding)
		{
			return (DomDocumentFragment)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCreateDocumentFragmentHandle));
		}
		return (DomDocumentFragment)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreateDocumentFragmentHandle));
	}

	[Export("createTextNode:")]
	public virtual DomText CreateTextNode(string data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(data);
		DomText result = ((!IsDirectBinding) ? ((DomText)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateTextNode_Handle, arg))) : ((DomText)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateTextNode_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("createComment:")]
	public virtual DomComment CreateComment(string data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(data);
		DomComment result = ((!IsDirectBinding) ? ((DomComment)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateComment_Handle, arg))) : ((DomComment)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateComment_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("createCDATASection:")]
	public virtual DomCDataSection CreateCDataSection(string data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(data);
		DomCDataSection result = ((!IsDirectBinding) ? ((DomCDataSection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateCDATASection_Handle, arg))) : ((DomCDataSection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateCDATASection_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("createProcessingInstruction:data:")]
	public virtual DomProcessingInstruction CreateProcessingInstruction(string target, string data)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(target);
		IntPtr arg2 = NSString.CreateNative(data);
		DomProcessingInstruction result = ((!IsDirectBinding) ? ((DomProcessingInstruction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCreateProcessingInstructionData_Handle, arg, arg2))) : ((DomProcessingInstruction)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCreateProcessingInstructionData_Handle, arg, arg2))));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("createAttribute:")]
	public virtual DomAttr CreateAttribute(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		DomAttr result = ((!IsDirectBinding) ? ((DomAttr)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateAttribute_Handle, arg))) : ((DomAttr)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateAttribute_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("createEntityReference:")]
	public virtual DomEntityReference CreateEntityReference(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		DomEntityReference result = ((!IsDirectBinding) ? ((DomEntityReference)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateEntityReference_Handle, arg))) : ((DomEntityReference)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateEntityReference_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getElementsByTagName:")]
	public virtual DomNodeList GetElementsByTagName(string tagname)
	{
		if (tagname == null)
		{
			throw new ArgumentNullException("tagname");
		}
		IntPtr arg = NSString.CreateNative(tagname);
		DomNodeList result = ((!IsDirectBinding) ? ((DomNodeList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetElementsByTagName_Handle, arg))) : ((DomNodeList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetElementsByTagName_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("importNode:deep:")]
	public virtual DomNode ImportNode(DomNode importedNode, bool deep)
	{
		if (importedNode == null)
		{
			throw new ArgumentNullException("importedNode");
		}
		if (IsDirectBinding)
		{
			return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selImportNodeDeep_Handle, importedNode.Handle, deep));
		}
		return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selImportNodeDeep_Handle, importedNode.Handle, deep));
	}

	[Export("createElementNS:qualifiedName:")]
	public virtual DomElement CreateElementNS(string namespaceURI, string qualifiedName)
	{
		if (namespaceURI == null)
		{
			throw new ArgumentNullException("namespaceURI");
		}
		if (qualifiedName == null)
		{
			throw new ArgumentNullException("qualifiedName");
		}
		IntPtr arg = NSString.CreateNative(namespaceURI);
		IntPtr arg2 = NSString.CreateNative(qualifiedName);
		DomElement result = ((!IsDirectBinding) ? ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCreateElementNSQualifiedName_Handle, arg, arg2))) : ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCreateElementNSQualifiedName_Handle, arg, arg2))));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("createAttributeNS:qualifiedName:")]
	public virtual DomAttr CreateAttributeNS(string namespaceURI, string qualifiedName)
	{
		if (namespaceURI == null)
		{
			throw new ArgumentNullException("namespaceURI");
		}
		if (qualifiedName == null)
		{
			throw new ArgumentNullException("qualifiedName");
		}
		IntPtr arg = NSString.CreateNative(namespaceURI);
		IntPtr arg2 = NSString.CreateNative(qualifiedName);
		DomAttr result = ((!IsDirectBinding) ? ((DomAttr)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCreateAttributeNSQualifiedName_Handle, arg, arg2))) : ((DomAttr)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCreateAttributeNSQualifiedName_Handle, arg, arg2))));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
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

	[Export("getElementById:")]
	public virtual DomElement GetElementById(string elementId)
	{
		if (elementId == null)
		{
			throw new ArgumentNullException("elementId");
		}
		IntPtr arg = NSString.CreateNative(elementId);
		DomElement result = ((!IsDirectBinding) ? ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetElementById_Handle, arg))) : ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetElementById_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("adoptNode:")]
	public virtual DomNode AdoptNode(DomNode source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (IsDirectBinding)
		{
			return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAdoptNode_Handle, source.Handle));
		}
		return (DomNode)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAdoptNode_Handle, source.Handle));
	}

	[Export("createRange")]
	public virtual DomRange CreateRange()
	{
		if (IsDirectBinding)
		{
			return (DomRange)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCreateRangeHandle));
		}
		return (DomRange)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreateRangeHandle));
	}

	[Export("getOverrideStyle:pseudoElement:")]
	public virtual DomCssStyleDeclaration GetOverrideStyle(DomElement element, string pseudoElement)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (pseudoElement == null)
		{
			throw new ArgumentNullException("pseudoElement");
		}
		IntPtr arg = NSString.CreateNative(pseudoElement);
		DomCssStyleDeclaration result = ((!IsDirectBinding) ? ((DomCssStyleDeclaration)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetOverrideStylePseudoElement_Handle, element.Handle, arg))) : ((DomCssStyleDeclaration)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetOverrideStylePseudoElement_Handle, element.Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("execCommand:userInterface:value:")]
	public virtual bool ExecCommand(string command, bool userInterface, string value)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr arg = NSString.CreateNative(command);
		IntPtr arg2 = NSString.CreateNative(value);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool_IntPtr(base.SuperHandle, selExecCommandUserInterfaceValue_Handle, arg, userInterface, arg2) : Messaging.bool_objc_msgSend_IntPtr_bool_IntPtr(base.Handle, selExecCommandUserInterfaceValue_Handle, arg, userInterface, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("execCommand:userInterface:")]
	public virtual bool ExecCommand(string command, bool userInterface)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		IntPtr arg = NSString.CreateNative(command);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selExecCommandUserInterface_Handle, arg, userInterface) : Messaging.bool_objc_msgSend_IntPtr_bool(base.Handle, selExecCommandUserInterface_Handle, arg, userInterface));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("execCommand:")]
	public virtual bool ExecCommand(string command)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		IntPtr arg = NSString.CreateNative(command);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selExecCommand_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selExecCommand_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("queryCommandEnabled:")]
	public virtual bool QueryCommandEnabled(string command)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		IntPtr arg = NSString.CreateNative(command);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selQueryCommandEnabled_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selQueryCommandEnabled_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("queryCommandIndeterm:")]
	public virtual bool QueryCommandIndeterm(string command)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		IntPtr arg = NSString.CreateNative(command);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selQueryCommandIndeterm_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selQueryCommandIndeterm_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("queryCommandState:")]
	public virtual bool QueryCommandState(string command)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		IntPtr arg = NSString.CreateNative(command);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selQueryCommandState_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selQueryCommandState_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("queryCommandSupported:")]
	public virtual bool QueryCommandSupported(string command)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		IntPtr arg = NSString.CreateNative(command);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selQueryCommandSupported_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selQueryCommandSupported_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("queryCommandValue:")]
	public virtual string QueryCommandValue(string command)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		IntPtr arg = NSString.CreateNative(command);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selQueryCommandValue_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selQueryCommandValue_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getElementsByName:")]
	public virtual DomNodeList GetElementsByName(string elementName)
	{
		if (elementName == null)
		{
			throw new ArgumentNullException("elementName");
		}
		IntPtr arg = NSString.CreateNative(elementName);
		DomNodeList result = ((!IsDirectBinding) ? ((DomNodeList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetElementsByName_Handle, arg))) : ((DomNodeList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetElementsByName_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("elementFromPoint:y:")]
	public virtual DomElement ElementFromPoint(int x, int y)
	{
		if (IsDirectBinding)
		{
			return (DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_int_int(base.Handle, selElementFromPointY_Handle, x, y));
		}
		return (DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_int_int(base.SuperHandle, selElementFromPointY_Handle, x, y));
	}

	[Export("createCSSStyleDeclaration")]
	public virtual DomCssStyleDeclaration CreateCssStyleDeclaration()
	{
		if (IsDirectBinding)
		{
			return (DomCssStyleDeclaration)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selCreateCSSStyleDeclarationHandle));
		}
		return (DomCssStyleDeclaration)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreateCSSStyleDeclarationHandle));
	}

	[Export("getComputedStyle:pseudoElement:")]
	public virtual DomCssStyleDeclaration GetComputedStyle(DomElement element, string pseudoElement)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (pseudoElement == null)
		{
			throw new ArgumentNullException("pseudoElement");
		}
		IntPtr arg = NSString.CreateNative(pseudoElement);
		DomCssStyleDeclaration result = ((!IsDirectBinding) ? ((DomCssStyleDeclaration)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetComputedStylePseudoElement_Handle, element.Handle, arg))) : ((DomCssStyleDeclaration)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetComputedStylePseudoElement_Handle, element.Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getMatchedCSSRules:pseudoElement:")]
	public virtual DomCssRuleList GetMatchedCSSRules(DomElement element, string pseudoElement)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (pseudoElement == null)
		{
			throw new ArgumentNullException("pseudoElement");
		}
		IntPtr arg = NSString.CreateNative(pseudoElement);
		DomCssRuleList result = ((!IsDirectBinding) ? ((DomCssRuleList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetMatchedCSSRulesPseudoElement_Handle, element.Handle, arg))) : ((DomCssRuleList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetMatchedCSSRulesPseudoElement_Handle, element.Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getMatchedCSSRules:pseudoElement:authorOnly:")]
	public virtual DomCssRuleList GetMatchedCSSRules(DomElement element, string pseudoElement, bool authorOnly)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (pseudoElement == null)
		{
			throw new ArgumentNullException("pseudoElement");
		}
		IntPtr arg = NSString.CreateNative(pseudoElement);
		DomCssRuleList result = ((!IsDirectBinding) ? ((DomCssRuleList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selGetMatchedCSSRulesPseudoElementAuthorOnly_Handle, element.Handle, arg, authorOnly))) : ((DomCssRuleList)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selGetMatchedCSSRulesPseudoElementAuthorOnly_Handle, element.Handle, arg, authorOnly))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getElementsByClassName:")]
	public virtual DomNodeList GetElementsByClassName(string tagname)
	{
		if (tagname == null)
		{
			throw new ArgumentNullException("tagname");
		}
		IntPtr arg = NSString.CreateNative(tagname);
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
			__mt_DocumentType_var = null;
			__mt_Implementation_var = null;
			__mt_DocumentElement_var = null;
			__mt_DefaultView_var = null;
			__mt_StyleSheets_var = null;
			__mt_body_var = null;
			__mt_images_var = null;
			__mt_applets_var = null;
			__mt_links_var = null;
			__mt_forms_var = null;
			__mt_anchors_var = null;
		}
	}
}
