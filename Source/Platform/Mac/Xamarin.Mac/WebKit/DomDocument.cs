using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMDocument", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomDocument : DomNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURL = "URL";

	private static readonly IntPtr selURLHandle = Selector.GetHandle("URL");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAdoptNode_ = "adoptNode:";

	private static readonly IntPtr selAdoptNode_Handle = Selector.GetHandle("adoptNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnchors = "anchors";

	private static readonly IntPtr selAnchorsHandle = Selector.GetHandle("anchors");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplets = "applets";

	private static readonly IntPtr selAppletsHandle = Selector.GetHandle("applets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBody = "body";

	private static readonly IntPtr selBodyHandle = Selector.GetHandle("body");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterSet = "characterSet";

	private static readonly IntPtr selCharacterSetHandle = Selector.GetHandle("characterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharset = "charset";

	private static readonly IntPtr selCharsetHandle = Selector.GetHandle("charset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCookie = "cookie";

	private static readonly IntPtr selCookieHandle = Selector.GetHandle("cookie");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateAttribute_ = "createAttribute:";

	private static readonly IntPtr selCreateAttribute_Handle = Selector.GetHandle("createAttribute:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateAttributeNS_QualifiedName_ = "createAttributeNS:qualifiedName:";

	private static readonly IntPtr selCreateAttributeNS_QualifiedName_Handle = Selector.GetHandle("createAttributeNS:qualifiedName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateCDATASection_ = "createCDATASection:";

	private static readonly IntPtr selCreateCDATASection_Handle = Selector.GetHandle("createCDATASection:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateCSSStyleDeclaration = "createCSSStyleDeclaration";

	private static readonly IntPtr selCreateCSSStyleDeclarationHandle = Selector.GetHandle("createCSSStyleDeclaration");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateComment_ = "createComment:";

	private static readonly IntPtr selCreateComment_Handle = Selector.GetHandle("createComment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateDocumentFragment = "createDocumentFragment";

	private static readonly IntPtr selCreateDocumentFragmentHandle = Selector.GetHandle("createDocumentFragment");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateElement_ = "createElement:";

	private static readonly IntPtr selCreateElement_Handle = Selector.GetHandle("createElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateElementNS_QualifiedName_ = "createElementNS:qualifiedName:";

	private static readonly IntPtr selCreateElementNS_QualifiedName_Handle = Selector.GetHandle("createElementNS:qualifiedName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateEntityReference_ = "createEntityReference:";

	private static readonly IntPtr selCreateEntityReference_Handle = Selector.GetHandle("createEntityReference:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateEvent_ = "createEvent:";

	private static readonly IntPtr selCreateEvent_Handle = Selector.GetHandle("createEvent:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateNodeIterator_WhatToShow_Filter_ExpandEntityReferences_ = "createNodeIterator:whatToShow:filter:expandEntityReferences:";

	private static readonly IntPtr selCreateNodeIterator_WhatToShow_Filter_ExpandEntityReferences_Handle = Selector.GetHandle("createNodeIterator:whatToShow:filter:expandEntityReferences:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateProcessingInstruction_Data_ = "createProcessingInstruction:data:";

	private static readonly IntPtr selCreateProcessingInstruction_Data_Handle = Selector.GetHandle("createProcessingInstruction:data:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateRange = "createRange";

	private static readonly IntPtr selCreateRangeHandle = Selector.GetHandle("createRange");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCreateTextNode_ = "createTextNode:";

	private static readonly IntPtr selCreateTextNode_Handle = Selector.GetHandle("createTextNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultCharset = "defaultCharset";

	private static readonly IntPtr selDefaultCharsetHandle = Selector.GetHandle("defaultCharset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDefaultView = "defaultView";

	private static readonly IntPtr selDefaultViewHandle = Selector.GetHandle("defaultView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoctype = "doctype";

	private static readonly IntPtr selDoctypeHandle = Selector.GetHandle("doctype");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentElement = "documentElement";

	private static readonly IntPtr selDocumentElementHandle = Selector.GetHandle("documentElement");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocumentURI = "documentURI";

	private static readonly IntPtr selDocumentURIHandle = Selector.GetHandle("documentURI");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDomain = "domain";

	private static readonly IntPtr selDomainHandle = Selector.GetHandle("domain");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selElementFromPoint_Y_ = "elementFromPoint:y:";

	private static readonly IntPtr selElementFromPoint_Y_Handle = Selector.GetHandle("elementFromPoint:y:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecCommand_ = "execCommand:";

	private static readonly IntPtr selExecCommand_Handle = Selector.GetHandle("execCommand:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecCommand_UserInterface_ = "execCommand:userInterface:";

	private static readonly IntPtr selExecCommand_UserInterface_Handle = Selector.GetHandle("execCommand:userInterface:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selExecCommand_UserInterface_Value_ = "execCommand:userInterface:value:";

	private static readonly IntPtr selExecCommand_UserInterface_Value_Handle = Selector.GetHandle("execCommand:userInterface:value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selForms = "forms";

	private static readonly IntPtr selFormsHandle = Selector.GetHandle("forms");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetComputedStyle_PseudoElement_ = "getComputedStyle:pseudoElement:";

	private static readonly IntPtr selGetComputedStyle_PseudoElement_Handle = Selector.GetHandle("getComputedStyle:pseudoElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetElementById_ = "getElementById:";

	private static readonly IntPtr selGetElementById_Handle = Selector.GetHandle("getElementById:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetElementsByClassName_ = "getElementsByClassName:";

	private static readonly IntPtr selGetElementsByClassName_Handle = Selector.GetHandle("getElementsByClassName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetElementsByName_ = "getElementsByName:";

	private static readonly IntPtr selGetElementsByName_Handle = Selector.GetHandle("getElementsByName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetElementsByTagName_ = "getElementsByTagName:";

	private static readonly IntPtr selGetElementsByTagName_Handle = Selector.GetHandle("getElementsByTagName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetElementsByTagNameNS_LocalName_ = "getElementsByTagNameNS:localName:";

	private static readonly IntPtr selGetElementsByTagNameNS_LocalName_Handle = Selector.GetHandle("getElementsByTagNameNS:localName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetMatchedCSSRules_PseudoElement_ = "getMatchedCSSRules:pseudoElement:";

	private static readonly IntPtr selGetMatchedCSSRules_PseudoElement_Handle = Selector.GetHandle("getMatchedCSSRules:pseudoElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetMatchedCSSRules_PseudoElement_AuthorOnly_ = "getMatchedCSSRules:pseudoElement:authorOnly:";

	private static readonly IntPtr selGetMatchedCSSRules_PseudoElement_AuthorOnly_Handle = Selector.GetHandle("getMatchedCSSRules:pseudoElement:authorOnly:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetOverrideStyle_PseudoElement_ = "getOverrideStyle:pseudoElement:";

	private static readonly IntPtr selGetOverrideStyle_PseudoElement_Handle = Selector.GetHandle("getOverrideStyle:pseudoElement:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImages = "images";

	private static readonly IntPtr selImagesHandle = Selector.GetHandle("images");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImplementation = "implementation";

	private static readonly IntPtr selImplementationHandle = Selector.GetHandle("implementation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selImportNode_Deep_ = "importNode:deep:";

	private static readonly IntPtr selImportNode_Deep_Handle = Selector.GetHandle("importNode:deep:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInputEncoding = "inputEncoding";

	private static readonly IntPtr selInputEncodingHandle = Selector.GetHandle("inputEncoding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastModified = "lastModified";

	private static readonly IntPtr selLastModifiedHandle = Selector.GetHandle("lastModified");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinks = "links";

	private static readonly IntPtr selLinksHandle = Selector.GetHandle("links");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreferredStylesheetSet = "preferredStylesheetSet";

	private static readonly IntPtr selPreferredStylesheetSetHandle = Selector.GetHandle("preferredStylesheetSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQueryCommandEnabled_ = "queryCommandEnabled:";

	private static readonly IntPtr selQueryCommandEnabled_Handle = Selector.GetHandle("queryCommandEnabled:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQueryCommandIndeterm_ = "queryCommandIndeterm:";

	private static readonly IntPtr selQueryCommandIndeterm_Handle = Selector.GetHandle("queryCommandIndeterm:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQueryCommandState_ = "queryCommandState:";

	private static readonly IntPtr selQueryCommandState_Handle = Selector.GetHandle("queryCommandState:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQueryCommandSupported_ = "queryCommandSupported:";

	private static readonly IntPtr selQueryCommandSupported_Handle = Selector.GetHandle("queryCommandSupported:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQueryCommandValue_ = "queryCommandValue:";

	private static readonly IntPtr selQueryCommandValue_Handle = Selector.GetHandle("queryCommandValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuerySelector_ = "querySelector:";

	private static readonly IntPtr selQuerySelector_Handle = Selector.GetHandle("querySelector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuerySelectorAll_ = "querySelectorAll:";

	private static readonly IntPtr selQuerySelectorAll_Handle = Selector.GetHandle("querySelectorAll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadyState = "readyState";

	private static readonly IntPtr selReadyStateHandle = Selector.GetHandle("readyState");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReferrer = "referrer";

	private static readonly IntPtr selReferrerHandle = Selector.GetHandle("referrer");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSelectedStylesheetSet = "selectedStylesheetSet";

	private static readonly IntPtr selSelectedStylesheetSetHandle = Selector.GetHandle("selectedStylesheetSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBody_ = "setBody:";

	private static readonly IntPtr selSetBody_Handle = Selector.GetHandle("setBody:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCharset_ = "setCharset:";

	private static readonly IntPtr selSetCharset_Handle = Selector.GetHandle("setCharset:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCookie_ = "setCookie:";

	private static readonly IntPtr selSetCookie_Handle = Selector.GetHandle("setCookie:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetDocumentURI_ = "setDocumentURI:";

	private static readonly IntPtr selSetDocumentURI_Handle = Selector.GetHandle("setDocumentURI:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSelectedStylesheetSet_ = "setSelectedStylesheetSet:";

	private static readonly IntPtr selSetSelectedStylesheetSet_Handle = Selector.GetHandle("setSelectedStylesheetSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetTitle_ = "setTitle:";

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetXmlStandalone_ = "setXmlStandalone:";

	private static readonly IntPtr selSetXmlStandalone_Handle = Selector.GetHandle("setXmlStandalone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetXmlVersion_ = "setXmlVersion:";

	private static readonly IntPtr selSetXmlVersion_Handle = Selector.GetHandle("setXmlVersion:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStyleSheets = "styleSheets";

	private static readonly IntPtr selStyleSheetsHandle = Selector.GetHandle("styleSheets");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTitle = "title";

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXmlEncoding = "xmlEncoding";

	private static readonly IntPtr selXmlEncodingHandle = Selector.GetHandle("xmlEncoding");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXmlStandalone = "xmlStandalone";

	private static readonly IntPtr selXmlStandaloneHandle = Selector.GetHandle("xmlStandalone");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selXmlVersion = "xmlVersion";

	private static readonly IntPtr selXmlVersionHandle = Selector.GetHandle("xmlVersion");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMDocument");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CharacterSet
	{
		[Export("characterSet", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCharacterSetHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Charset
	{
		[Export("charset", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCharsetHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCharsetHandle));
		}
		[Export("setCharset:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Cookie
	{
		[Export("cookie", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCookieHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCookieHandle));
		}
		[Export("setCookie:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DefaultCharset
	{
		[Export("defaultCharset", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultCharsetHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultCharsetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomAbstractView DefaultView
	{
		[Export("defaultView", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomAbstractView>(Messaging.IntPtr_objc_msgSend(base.Handle, selDefaultViewHandle));
			}
			return Runtime.GetNSObject<DomAbstractView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDefaultViewHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomElement DocumentElement
	{
		[Export("documentElement", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentElementHandle));
			}
			return Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentElementHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomDocumentType DocumentType
	{
		[Export("doctype", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomDocumentType>(Messaging.IntPtr_objc_msgSend(base.Handle, selDoctypeHandle));
			}
			return Runtime.GetNSObject<DomDocumentType>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDoctypeHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string DocumentURI
	{
		[Export("documentURI", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDocumentURIHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDocumentURIHandle));
		}
		[Export("setDocumentURI:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Domain
	{
		[Export("domain", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDomainHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDomainHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomImplementation Implementation
	{
		[Export("implementation", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomImplementation>(Messaging.IntPtr_objc_msgSend(base.Handle, selImplementationHandle));
			}
			return Runtime.GetNSObject<DomImplementation>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImplementationHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string InputEncoding
	{
		[Export("inputEncoding", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInputEncodingHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInputEncodingHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string LastModified
	{
		[Export("lastModified", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLastModifiedHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastModifiedHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string PreferredStylesheetSet
	{
		[Export("preferredStylesheetSet", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPreferredStylesheetSetHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreferredStylesheetSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ReadyState
	{
		[Export("readyState", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selReadyStateHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReadyStateHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Referrer
	{
		[Export("referrer", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selReferrerHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selReferrerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string SelectedStylesheetSet
	{
		[Export("selectedStylesheetSet", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selSelectedStylesheetSetHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSelectedStylesheetSetHandle));
		}
		[Export("setSelectedStylesheetSet:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomStyleSheetList StyleSheets
	{
		[Export("styleSheets", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomStyleSheetList>(Messaging.IntPtr_objc_msgSend(base.Handle, selStyleSheetsHandle));
			}
			return Runtime.GetNSObject<DomStyleSheetList>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStyleSheetsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Title
	{
		[Export("title", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleHandle));
		}
		[Export("setTitle:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string Url
	{
		[Export("URL", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selURLHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selURLHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string XmlEncoding
	{
		[Export("xmlEncoding", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selXmlEncodingHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selXmlEncodingHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool XmlStandalone
	{
		[Export("xmlStandalone")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selXmlStandaloneHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selXmlStandaloneHandle);
		}
		[Export("setXmlStandalone:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetXmlStandalone_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetXmlStandalone_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string XmlVersion
	{
		[Export("xmlVersion", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selXmlVersionHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selXmlVersionHandle));
		}
		[Export("setXmlVersion:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomHtmlCollection anchors
	{
		[Export("anchors", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomHtmlCollection>(Messaging.IntPtr_objc_msgSend(base.Handle, selAnchorsHandle));
			}
			return Runtime.GetNSObject<DomHtmlCollection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAnchorsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomHtmlCollection applets
	{
		[Export("applets", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomHtmlCollection>(Messaging.IntPtr_objc_msgSend(base.Handle, selAppletsHandle));
			}
			return Runtime.GetNSObject<DomHtmlCollection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAppletsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomHtmlElement body
	{
		[Export("body", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomHtmlElement>(Messaging.IntPtr_objc_msgSend(base.Handle, selBodyHandle));
			}
			return Runtime.GetNSObject<DomHtmlElement>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBodyHandle));
		}
		[Export("setBody:", ArgumentSemantic.Retain)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBody_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBody_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomHtmlCollection forms
	{
		[Export("forms", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomHtmlCollection>(Messaging.IntPtr_objc_msgSend(base.Handle, selFormsHandle));
			}
			return Runtime.GetNSObject<DomHtmlCollection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFormsHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomHtmlCollection images
	{
		[Export("images", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomHtmlCollection>(Messaging.IntPtr_objc_msgSend(base.Handle, selImagesHandle));
			}
			return Runtime.GetNSObject<DomHtmlCollection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selImagesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomHtmlCollection links
	{
		[Export("links", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomHtmlCollection>(Messaging.IntPtr_objc_msgSend(base.Handle, selLinksHandle));
			}
			return Runtime.GetNSObject<DomHtmlCollection>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLinksHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomDocument(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomDocument(IntPtr handle)
		: base(handle)
	{
	}

	[Export("adoptNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode AdoptNode(DomNode source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAdoptNode_Handle, source.Handle));
		}
		return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAdoptNode_Handle, source.Handle));
	}

	[Export("createAttribute:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomAttr CreateAttribute(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		DomAttr result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomAttr>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateAttribute_Handle, arg)) : Runtime.GetNSObject<DomAttr>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateAttribute_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("createAttributeNS:qualifiedName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		DomAttr result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomAttr>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCreateAttributeNS_QualifiedName_Handle, arg, arg2)) : Runtime.GetNSObject<DomAttr>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCreateAttributeNS_QualifiedName_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("createCDATASection:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomCDataSection CreateCDataSection(string data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(data);
		DomCDataSection result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomCDataSection>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateCDATASection_Handle, arg)) : Runtime.GetNSObject<DomCDataSection>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateCDATASection_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("createComment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomComment CreateComment(string data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(data);
		DomComment result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomComment>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateComment_Handle, arg)) : Runtime.GetNSObject<DomComment>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateComment_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("createCSSStyleDeclaration")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomCssStyleDeclaration CreateCssStyleDeclaration()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomCssStyleDeclaration>(Messaging.IntPtr_objc_msgSend(base.Handle, selCreateCSSStyleDeclarationHandle));
		}
		return Runtime.GetNSObject<DomCssStyleDeclaration>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreateCSSStyleDeclarationHandle));
	}

	[Export("createDocumentFragment")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomDocumentFragment CreateDocumentFragment()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomDocumentFragment>(Messaging.IntPtr_objc_msgSend(base.Handle, selCreateDocumentFragmentHandle));
		}
		return Runtime.GetNSObject<DomDocumentFragment>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreateDocumentFragmentHandle));
	}

	[Export("createElement:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomElement CreateElement(string tagName)
	{
		if (tagName == null)
		{
			throw new ArgumentNullException("tagName");
		}
		IntPtr arg = NSString.CreateNative(tagName);
		DomElement result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateElement_Handle, arg)) : Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateElement_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("createElementNS:qualifiedName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		DomElement result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCreateElementNS_QualifiedName_Handle, arg, arg2)) : Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCreateElementNS_QualifiedName_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("createEntityReference:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomEntityReference CreateEntityReference(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		DomEntityReference result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomEntityReference>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateEntityReference_Handle, arg)) : Runtime.GetNSObject<DomEntityReference>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateEntityReference_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("createEvent:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomEvent CreateEvent(string eventType)
	{
		if (eventType == null)
		{
			throw new ArgumentNullException("eventType");
		}
		IntPtr arg = NSString.CreateNative(eventType);
		DomEvent result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomEvent>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateEvent_Handle, arg)) : Runtime.GetNSObject<DomEvent>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateEvent_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("createNodeIterator:whatToShow:filter:expandEntityReferences:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNodeIterator CreateNodeIterator(DomNode root, uint whatToShow, IDomNodeFilter filter, bool expandEntityReferences)
	{
		if (root == null)
		{
			throw new ArgumentNullException("root");
		}
		if (filter == null)
		{
			throw new ArgumentNullException("filter");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomNodeIterator>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt32_IntPtr_bool(base.Handle, selCreateNodeIterator_WhatToShow_Filter_ExpandEntityReferences_Handle, root.Handle, whatToShow, filter.Handle, expandEntityReferences));
		}
		return Runtime.GetNSObject<DomNodeIterator>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt32_IntPtr_bool(base.SuperHandle, selCreateNodeIterator_WhatToShow_Filter_ExpandEntityReferences_Handle, root.Handle, whatToShow, filter.Handle, expandEntityReferences));
	}

	[Export("createProcessingInstruction:data:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		DomProcessingInstruction result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomProcessingInstruction>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCreateProcessingInstruction_Data_Handle, arg, arg2)) : Runtime.GetNSObject<DomProcessingInstruction>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selCreateProcessingInstruction_Data_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("createRange")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomRange CreateRange()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomRange>(Messaging.IntPtr_objc_msgSend(base.Handle, selCreateRangeHandle));
		}
		return Runtime.GetNSObject<DomRange>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCreateRangeHandle));
	}

	[Export("createTextNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomText CreateTextNode(string data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = NSString.CreateNative(data);
		DomText result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomText>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCreateTextNode_Handle, arg)) : Runtime.GetNSObject<DomText>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCreateTextNode_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("elementFromPoint:y:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomElement ElementFromPoint(int x, int y)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSend_int_int(base.Handle, selElementFromPoint_Y_Handle, x, y));
		}
		return Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSendSuper_int_int(base.SuperHandle, selElementFromPoint_Y_Handle, x, y));
	}

	[Export("execCommand:userInterface:value:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool_IntPtr(base.SuperHandle, selExecCommand_UserInterface_Value_Handle, arg, userInterface, arg2) : Messaging.bool_objc_msgSend_IntPtr_bool_IntPtr(base.Handle, selExecCommand_UserInterface_Value_Handle, arg, userInterface, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("execCommand:userInterface:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ExecCommand(string command, bool userInterface)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		IntPtr arg = NSString.CreateNative(command);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selExecCommand_UserInterface_Handle, arg, userInterface) : Messaging.bool_objc_msgSend_IntPtr_bool(base.Handle, selExecCommand_UserInterface_Handle, arg, userInterface));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("execCommand:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ExecCommand(string command)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		IntPtr arg = NSString.CreateNative(command);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selExecCommand_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selExecCommand_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getComputedStyle:pseudoElement:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		DomCssStyleDeclaration result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomCssStyleDeclaration>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetComputedStyle_PseudoElement_Handle, element.Handle, arg)) : Runtime.GetNSObject<DomCssStyleDeclaration>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetComputedStyle_PseudoElement_Handle, element.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getElementById:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomElement GetElementById(string elementId)
	{
		if (elementId == null)
		{
			throw new ArgumentNullException("elementId");
		}
		IntPtr arg = NSString.CreateNative(elementId);
		DomElement result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetElementById_Handle, arg)) : Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetElementById_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getElementsByClassName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNodeList GetElementsByClassName(string tagname)
	{
		if (tagname == null)
		{
			throw new ArgumentNullException("tagname");
		}
		IntPtr arg = NSString.CreateNative(tagname);
		DomNodeList result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomNodeList>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetElementsByClassName_Handle, arg)) : Runtime.GetNSObject<DomNodeList>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetElementsByClassName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getElementsByName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNodeList GetElementsByName(string elementName)
	{
		if (elementName == null)
		{
			throw new ArgumentNullException("elementName");
		}
		IntPtr arg = NSString.CreateNative(elementName);
		DomNodeList result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomNodeList>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetElementsByName_Handle, arg)) : Runtime.GetNSObject<DomNodeList>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetElementsByName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getElementsByTagName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNodeList GetElementsByTagName(string tagname)
	{
		if (tagname == null)
		{
			throw new ArgumentNullException("tagname");
		}
		IntPtr arg = NSString.CreateNative(tagname);
		DomNodeList result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomNodeList>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetElementsByTagName_Handle, arg)) : Runtime.GetNSObject<DomNodeList>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetElementsByTagName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getElementsByTagNameNS:localName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		DomNodeList result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomNodeList>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetElementsByTagNameNS_LocalName_Handle, arg, arg2)) : Runtime.GetNSObject<DomNodeList>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetElementsByTagNameNS_LocalName_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("getMatchedCSSRules:pseudoElement:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		DomCssRuleList result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomCssRuleList>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetMatchedCSSRules_PseudoElement_Handle, element.Handle, arg)) : Runtime.GetNSObject<DomCssRuleList>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetMatchedCSSRules_PseudoElement_Handle, element.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getMatchedCSSRules:pseudoElement:authorOnly:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		DomCssRuleList result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomCssRuleList>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool(base.SuperHandle, selGetMatchedCSSRules_PseudoElement_AuthorOnly_Handle, element.Handle, arg, authorOnly)) : Runtime.GetNSObject<DomCssRuleList>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_bool(base.Handle, selGetMatchedCSSRules_PseudoElement_AuthorOnly_Handle, element.Handle, arg, authorOnly)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getOverrideStyle:pseudoElement:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		DomCssStyleDeclaration result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomCssStyleDeclaration>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetOverrideStyle_PseudoElement_Handle, element.Handle, arg)) : Runtime.GetNSObject<DomCssStyleDeclaration>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetOverrideStyle_PseudoElement_Handle, element.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("importNode:deep:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNode ImportNode(DomNode importedNode, bool deep)
	{
		if (importedNode == null)
		{
			throw new ArgumentNullException("importedNode");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selImportNode_Deep_Handle, importedNode.Handle, deep));
		}
		return Runtime.GetNSObject<DomNode>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selImportNode_Deep_Handle, importedNode.Handle, deep));
	}

	[Export("queryCommandEnabled:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool QueryCommandEnabled(string command)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		IntPtr arg = NSString.CreateNative(command);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selQueryCommandEnabled_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selQueryCommandEnabled_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("queryCommandIndeterm:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool QueryCommandIndeterm(string command)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		IntPtr arg = NSString.CreateNative(command);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selQueryCommandIndeterm_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selQueryCommandIndeterm_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("queryCommandState:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool QueryCommandState(string command)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		IntPtr arg = NSString.CreateNative(command);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selQueryCommandState_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selQueryCommandState_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("queryCommandSupported:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool QueryCommandSupported(string command)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		IntPtr arg = NSString.CreateNative(command);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selQueryCommandSupported_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selQueryCommandSupported_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("queryCommandValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string QueryCommandValue(string command)
	{
		if (command == null)
		{
			throw new ArgumentNullException("command");
		}
		IntPtr arg = NSString.CreateNative(command);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selQueryCommandValue_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selQueryCommandValue_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("querySelector:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomElement QuerySelector(string selectors)
	{
		if (selectors == null)
		{
			throw new ArgumentNullException("selectors");
		}
		IntPtr arg = NSString.CreateNative(selectors);
		DomElement result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selQuerySelector_Handle, arg)) : Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selQuerySelector_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("querySelectorAll:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNodeList QuerySelectorAll(string selectors)
	{
		if (selectors == null)
		{
			throw new ArgumentNullException("selectors");
		}
		IntPtr arg = NSString.CreateNative(selectors);
		DomNodeList result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomNodeList>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selQuerySelectorAll_Handle, arg)) : Runtime.GetNSObject<DomNodeList>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selQuerySelectorAll_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}
}
