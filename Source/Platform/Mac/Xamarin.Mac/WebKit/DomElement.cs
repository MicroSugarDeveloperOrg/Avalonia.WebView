using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMElement", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomElement : DomNode
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBlur = "blur";

	private static readonly IntPtr selBlurHandle = Selector.GetHandle("blur");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selChildElementCount = "childElementCount";

	private static readonly IntPtr selChildElementCountHandle = Selector.GetHandle("childElementCount");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClassName = "className";

	private static readonly IntPtr selClassNameHandle = Selector.GetHandle("className");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClientHeight = "clientHeight";

	private static readonly IntPtr selClientHeightHandle = Selector.GetHandle("clientHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClientLeft = "clientLeft";

	private static readonly IntPtr selClientLeftHandle = Selector.GetHandle("clientLeft");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClientTop = "clientTop";

	private static readonly IntPtr selClientTopHandle = Selector.GetHandle("clientTop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selClientWidth = "clientWidth";

	private static readonly IntPtr selClientWidthHandle = Selector.GetHandle("clientWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContains_ = "contains:";

	private static readonly IntPtr selContains_Handle = Selector.GetHandle("contains:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstElementChild = "firstElementChild";

	private static readonly IntPtr selFirstElementChildHandle = Selector.GetHandle("firstElementChild");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFocus = "focus";

	private static readonly IntPtr selFocusHandle = Selector.GetHandle("focus");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetAttribute_ = "getAttribute:";

	private static readonly IntPtr selGetAttribute_Handle = Selector.GetHandle("getAttribute:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetAttributeNS_LocalName_ = "getAttributeNS:localName:";

	private static readonly IntPtr selGetAttributeNS_LocalName_Handle = Selector.GetHandle("getAttributeNS:localName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetAttributeNode_ = "getAttributeNode:";

	private static readonly IntPtr selGetAttributeNode_Handle = Selector.GetHandle("getAttributeNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetAttributeNodeNS_LocalName_ = "getAttributeNodeNS:localName:";

	private static readonly IntPtr selGetAttributeNodeNS_LocalName_Handle = Selector.GetHandle("getAttributeNodeNS:localName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetElementsByClassName_ = "getElementsByClassName:";

	private static readonly IntPtr selGetElementsByClassName_Handle = Selector.GetHandle("getElementsByClassName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetElementsByTagName_ = "getElementsByTagName:";

	private static readonly IntPtr selGetElementsByTagName_Handle = Selector.GetHandle("getElementsByTagName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetElementsByTagNameNS_LocalName_ = "getElementsByTagNameNS:localName:";

	private static readonly IntPtr selGetElementsByTagNameNS_LocalName_Handle = Selector.GetHandle("getElementsByTagNameNS:localName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasAttribute_ = "hasAttribute:";

	private static readonly IntPtr selHasAttribute_Handle = Selector.GetHandle("hasAttribute:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasAttributeNS_LocalName_ = "hasAttributeNS:localName:";

	private static readonly IntPtr selHasAttributeNS_LocalName_Handle = Selector.GetHandle("hasAttributeNS:localName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInnerText = "innerText";

	private static readonly IntPtr selInnerTextHandle = Selector.GetHandle("innerText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLastElementChild = "lastElementChild";

	private static readonly IntPtr selLastElementChildHandle = Selector.GetHandle("lastElementChild");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextElementSibling = "nextElementSibling";

	private static readonly IntPtr selNextElementSiblingHandle = Selector.GetHandle("nextElementSibling");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOffsetHeight = "offsetHeight";

	private static readonly IntPtr selOffsetHeightHandle = Selector.GetHandle("offsetHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOffsetLeft = "offsetLeft";

	private static readonly IntPtr selOffsetLeftHandle = Selector.GetHandle("offsetLeft");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOffsetParent = "offsetParent";

	private static readonly IntPtr selOffsetParentHandle = Selector.GetHandle("offsetParent");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOffsetTop = "offsetTop";

	private static readonly IntPtr selOffsetTopHandle = Selector.GetHandle("offsetTop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOffsetWidth = "offsetWidth";

	private static readonly IntPtr selOffsetWidthHandle = Selector.GetHandle("offsetWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreviousElementSibling = "previousElementSibling";

	private static readonly IntPtr selPreviousElementSiblingHandle = Selector.GetHandle("previousElementSibling");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuerySelector_ = "querySelector:";

	private static readonly IntPtr selQuerySelector_Handle = Selector.GetHandle("querySelector:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selQuerySelectorAll_ = "querySelectorAll:";

	private static readonly IntPtr selQuerySelectorAll_Handle = Selector.GetHandle("querySelectorAll:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAttribute_ = "removeAttribute:";

	private static readonly IntPtr selRemoveAttribute_Handle = Selector.GetHandle("removeAttribute:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAttributeNS_LocalName_ = "removeAttributeNS:localName:";

	private static readonly IntPtr selRemoveAttributeNS_LocalName_Handle = Selector.GetHandle("removeAttributeNS:localName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAttributeNode_ = "removeAttributeNode:";

	private static readonly IntPtr selRemoveAttributeNode_Handle = Selector.GetHandle("removeAttributeNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollByLines_ = "scrollByLines:";

	private static readonly IntPtr selScrollByLines_Handle = Selector.GetHandle("scrollByLines:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollByPages_ = "scrollByPages:";

	private static readonly IntPtr selScrollByPages_Handle = Selector.GetHandle("scrollByPages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollHeight = "scrollHeight";

	private static readonly IntPtr selScrollHeightHandle = Selector.GetHandle("scrollHeight");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollIntoView_ = "scrollIntoView:";

	private static readonly IntPtr selScrollIntoView_Handle = Selector.GetHandle("scrollIntoView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollIntoViewIfNeeded_ = "scrollIntoViewIfNeeded:";

	private static readonly IntPtr selScrollIntoViewIfNeeded_Handle = Selector.GetHandle("scrollIntoViewIfNeeded:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollLeft = "scrollLeft";

	private static readonly IntPtr selScrollLeftHandle = Selector.GetHandle("scrollLeft");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollTop = "scrollTop";

	private static readonly IntPtr selScrollTopHandle = Selector.GetHandle("scrollTop");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selScrollWidth = "scrollWidth";

	private static readonly IntPtr selScrollWidthHandle = Selector.GetHandle("scrollWidth");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttribute_Value_ = "setAttribute:value:";

	private static readonly IntPtr selSetAttribute_Value_Handle = Selector.GetHandle("setAttribute:value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributeNS_QualifiedName_Value_ = "setAttributeNS:qualifiedName:value:";

	private static readonly IntPtr selSetAttributeNS_QualifiedName_Value_Handle = Selector.GetHandle("setAttributeNS:qualifiedName:value:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributeNode_ = "setAttributeNode:";

	private static readonly IntPtr selSetAttributeNode_Handle = Selector.GetHandle("setAttributeNode:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributeNodeNS_ = "setAttributeNodeNS:";

	private static readonly IntPtr selSetAttributeNodeNS_Handle = Selector.GetHandle("setAttributeNodeNS:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetClassName_ = "setClassName:";

	private static readonly IntPtr selSetClassName_Handle = Selector.GetHandle("setClassName:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScrollLeft_ = "setScrollLeft:";

	private static readonly IntPtr selSetScrollLeft_Handle = Selector.GetHandle("setScrollLeft:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetScrollTop_ = "setScrollTop:";

	private static readonly IntPtr selSetScrollTop_Handle = Selector.GetHandle("setScrollTop:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStyle = "style";

	private static readonly IntPtr selStyleHandle = Selector.GetHandle("style");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTagName = "tagName";

	private static readonly IntPtr selTagNameHandle = Selector.GetHandle("tagName");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWebkitRequestFullScreen_ = "webkitRequestFullScreen:";

	private static readonly IntPtr selWebkitRequestFullScreen_Handle = Selector.GetHandle("webkitRequestFullScreen:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMElement");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual uint ChildElementCount
	{
		[Export("childElementCount")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.UInt32_objc_msgSend(base.Handle, selChildElementCountHandle);
			}
			return Messaging.UInt32_objc_msgSendSuper(base.SuperHandle, selChildElementCountHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	public virtual string ClassName
	{
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("className", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selClassNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClassNameHandle));
		}
		[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
		[Export("setClassName:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetClassName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetClassName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int ClientHeight
	{
		[Export("clientHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selClientHeightHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selClientHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int ClientLeft
	{
		[Export("clientLeft")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selClientLeftHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selClientLeftHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int ClientTop
	{
		[Export("clientTop")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selClientTopHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selClientTopHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int ClientWidth
	{
		[Export("clientWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selClientWidthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selClientWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomElement FirstElementChild
	{
		[Export("firstElementChild", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSend(base.Handle, selFirstElementChildHandle));
			}
			return Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFirstElementChildHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string InnerText
	{
		[Export("innerText", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInnerTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInnerTextHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomElement LastElementChild
	{
		[Export("lastElementChild", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSend(base.Handle, selLastElementChildHandle));
			}
			return Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastElementChildHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomElement NextElementSibling
	{
		[Export("nextElementSibling", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSend(base.Handle, selNextElementSiblingHandle));
			}
			return Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selNextElementSiblingHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int OffsetHeight
	{
		[Export("offsetHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selOffsetHeightHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selOffsetHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int OffsetLeft
	{
		[Export("offsetLeft")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selOffsetLeftHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selOffsetLeftHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomElement OffsetParent
	{
		[Export("offsetParent", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSend(base.Handle, selOffsetParentHandle));
			}
			return Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOffsetParentHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int OffsetTop
	{
		[Export("offsetTop")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selOffsetTopHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selOffsetTopHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int OffsetWidth
	{
		[Export("offsetWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selOffsetWidthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selOffsetWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomElement PreviousElementSibling
	{
		[Export("previousElementSibling", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSend(base.Handle, selPreviousElementSiblingHandle));
			}
			return Runtime.GetNSObject<DomElement>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPreviousElementSiblingHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int ScrollHeight
	{
		[Export("scrollHeight")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selScrollHeightHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selScrollHeightHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int ScrollLeft
	{
		[Export("scrollLeft")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selScrollLeftHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selScrollLeftHandle);
		}
		[Export("setScrollLeft:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetScrollLeft_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetScrollLeft_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int ScrollTop
	{
		[Export("scrollTop")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selScrollTopHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selScrollTopHandle);
		}
		[Export("setScrollTop:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetScrollTop_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetScrollTop_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int ScrollWidth
	{
		[Export("scrollWidth")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selScrollWidthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selScrollWidthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomCssStyleDeclaration Style
	{
		[Export("style", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomCssStyleDeclaration>(Messaging.IntPtr_objc_msgSend(base.Handle, selStyleHandle));
			}
			return Runtime.GetNSObject<DomCssStyleDeclaration>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStyleHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string TagName
	{
		[Export("tagName", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTagNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTagNameHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomElement(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomElement(IntPtr handle)
		: base(handle)
	{
	}

	[Export("blur")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Blur()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBlurHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBlurHandle);
		}
	}

	[Export("contains:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Contains(DomElement element)
	{
		if (element == null)
		{
			throw new ArgumentNullException("element");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContains_Handle, element.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContains_Handle, element.Handle);
	}

	[Export("focus")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Focus()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selFocusHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selFocusHandle);
		}
	}

	[Export("getAttribute:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetAttribute(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetAttribute_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetAttribute_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getAttributeNS:localName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetAttributeNS_LocalName_Handle, arg, arg2)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetAttributeNS_LocalName_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("getAttributeNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomAttr GetAttributeNode(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		DomAttr result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomAttr>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetAttributeNode_Handle, arg)) : Runtime.GetNSObject<DomAttr>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetAttributeNode_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getAttributeNodeNS:localName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		DomAttr result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomAttr>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selGetAttributeNodeNS_LocalName_Handle, arg, arg2)) : Runtime.GetNSObject<DomAttr>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selGetAttributeNodeNS_LocalName_Handle, arg, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("getElementsByClassName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNodeList GetElementsByClassName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		DomNodeList result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomNodeList>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetElementsByClassName_Handle, arg)) : Runtime.GetNSObject<DomNodeList>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetElementsByClassName_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getElementsByTagName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomNodeList GetElementsByTagName(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
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

	[Export("hasAttribute:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasAttribute(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasAttribute_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasAttribute_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("hasAttributeNS:localName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selHasAttributeNS_LocalName_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selHasAttributeNS_LocalName_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
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

	[Export("removeAttribute:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAttribute(string name)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selRemoveAttribute_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAttribute_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("removeAttributeNS:localName:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selRemoveAttributeNS_LocalName_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selRemoveAttributeNS_LocalName_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("removeAttributeNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomAttr RemoveAttributeNode(DomAttr oldAttr)
	{
		if (oldAttr == null)
		{
			throw new ArgumentNullException("oldAttr");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomAttr>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRemoveAttributeNode_Handle, oldAttr.Handle));
		}
		return Runtime.GetNSObject<DomAttr>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveAttributeNode_Handle, oldAttr.Handle));
	}

	[Export("scrollByLines:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollByLines(int lines)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selScrollByLines_Handle, lines);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selScrollByLines_Handle, lines);
		}
	}

	[Export("scrollByPages:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollByPages(int pages)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_int(base.Handle, selScrollByPages_Handle, pages);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selScrollByPages_Handle, pages);
		}
	}

	[Export("scrollIntoView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollIntoView(bool alignWithTop)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selScrollIntoView_Handle, alignWithTop);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selScrollIntoView_Handle, alignWithTop);
		}
	}

	[Export("scrollIntoViewIfNeeded:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ScrollIntoViewIfNeeded(bool centerIfNeeded)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool(base.Handle, selScrollIntoViewIfNeeded_Handle, centerIfNeeded);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selScrollIntoViewIfNeeded_Handle, centerIfNeeded);
		}
	}

	[Export("setAttribute:value:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetAttribute_Value_Handle, arg, arg2);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetAttribute_Value_Handle, arg, arg2);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
	}

	[Export("setAttributeNS:qualifiedName:value:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSetAttributeNS_QualifiedName_Value_Handle, arg, arg2, arg3);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetAttributeNS_QualifiedName_Value_Handle, arg, arg2, arg3);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("setAttributeNode:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomAttr SetAttributeNode(DomAttr newAttr)
	{
		if (newAttr == null)
		{
			throw new ArgumentNullException("newAttr");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomAttr>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSetAttributeNode_Handle, newAttr.Handle));
		}
		return Runtime.GetNSObject<DomAttr>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributeNode_Handle, newAttr.Handle));
	}

	[Export("setAttributeNodeNS:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomAttr SetAttributeNodeNS(DomAttr newAttr)
	{
		if (newAttr == null)
		{
			throw new ArgumentNullException("newAttr");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<DomAttr>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSetAttributeNodeNS_Handle, newAttr.Handle));
		}
		return Runtime.GetNSObject<DomAttr>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributeNodeNS_Handle, newAttr.Handle));
	}

	[Export("webkitRequestFullScreen:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void WebKitRequestFullScreen(ushort flags)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt16(base.Handle, selWebkitRequestFullScreen_Handle, flags);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt16(base.SuperHandle, selWebkitRequestFullScreen_Handle, flags);
		}
	}
}
