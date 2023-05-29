using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMHTMLElement", true)]
public class DomHtmlElement : DomElement
{
	private static readonly IntPtr selIdNameHandle = Selector.GetHandle("idName");

	private static readonly IntPtr selSetIdName_Handle = Selector.GetHandle("setIdName:");

	private static readonly IntPtr selTitleHandle = Selector.GetHandle("title");

	private static readonly IntPtr selSetTitle_Handle = Selector.GetHandle("setTitle:");

	private static readonly IntPtr selLangHandle = Selector.GetHandle("lang");

	private static readonly IntPtr selSetLang_Handle = Selector.GetHandle("setLang:");

	private static readonly IntPtr selDirHandle = Selector.GetHandle("dir");

	private static readonly IntPtr selSetDir_Handle = Selector.GetHandle("setDir:");

	private static readonly IntPtr selClassNameHandle = Selector.GetHandle("className");

	private static readonly IntPtr selSetClassName_Handle = Selector.GetHandle("setClassName:");

	private static readonly IntPtr selTabIndexHandle = Selector.GetHandle("tabIndex");

	private static readonly IntPtr selSetTabIndex_Handle = Selector.GetHandle("setTabIndex:");

	private static readonly IntPtr selInnerHTMLHandle = Selector.GetHandle("innerHTML");

	private static readonly IntPtr selSetInnerHTML_Handle = Selector.GetHandle("setInnerHTML:");

	private static readonly IntPtr selInnerTextHandle = Selector.GetHandle("innerText");

	private static readonly IntPtr selSetInnerText_Handle = Selector.GetHandle("setInnerText:");

	private static readonly IntPtr selOuterHTMLHandle = Selector.GetHandle("outerHTML");

	private static readonly IntPtr selSetOuterHTML_Handle = Selector.GetHandle("setOuterHTML:");

	private static readonly IntPtr selOuterTextHandle = Selector.GetHandle("outerText");

	private static readonly IntPtr selSetOuterText_Handle = Selector.GetHandle("setOuterText:");

	private static readonly IntPtr selChildrenHandle = Selector.GetHandle("children");

	private static readonly IntPtr selContentEditableHandle = Selector.GetHandle("contentEditable");

	private static readonly IntPtr selSetContentEditable_Handle = Selector.GetHandle("setContentEditable:");

	private static readonly IntPtr selIsContentEditableHandle = Selector.GetHandle("isContentEditable");

	private static readonly IntPtr selTitleDisplayStringHandle = Selector.GetHandle("titleDisplayString");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMHTMLElement");

	private object __mt_Children_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string IdName
	{
		[Export("idName")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selIdNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selIdNameHandle));
		}
		[Export("setIdName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetIdName_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetIdName_Handle, arg);
			}
			NSString.ReleaseNative(arg);
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

	public virtual string Lang
	{
		[Export("lang")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLangHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLangHandle));
		}
		[Export("setLang:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLang_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLang_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string Dir
	{
		[Export("dir")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDirHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDirHandle));
		}
		[Export("setDir:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDir_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDir_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string ClassName
	{
		[Export("className")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selClassNameHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selClassNameHandle));
		}
		[Export("setClassName:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
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

	public virtual int TabIndex
	{
		[Export("tabIndex")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selTabIndexHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selTabIndexHandle);
		}
		[Export("setTabIndex:")]
		set
		{
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_int(base.Handle, selSetTabIndex_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_int(base.SuperHandle, selSetTabIndex_Handle, value);
			}
		}
	}

	public virtual string InnerHTML
	{
		[Export("innerHTML")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInnerHTMLHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInnerHTMLHandle));
		}
		[Export("setInnerHTML:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInnerHTML_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInnerHTML_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public new virtual string InnerText
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
		[Export("setInnerText:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetInnerText_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetInnerText_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string OuterHTML
	{
		[Export("outerHTML")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOuterHTMLHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOuterHTMLHandle));
		}
		[Export("setOuterHTML:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOuterHTML_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOuterHTML_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string OuterText
	{
		[Export("outerText")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selOuterTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selOuterTextHandle));
		}
		[Export("setOuterText:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetOuterText_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetOuterText_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual DomHtmlCollection Children
	{
		[Export("children")]
		get
		{
			return (DomHtmlCollection)(__mt_Children_var = ((!IsDirectBinding) ? ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selChildrenHandle))) : ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selChildrenHandle)))));
		}
	}

	public virtual string ContentEditable
	{
		[Export("contentEditable")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selContentEditableHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selContentEditableHandle));
		}
		[Export("setContentEditable:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetContentEditable_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetContentEditable_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public new virtual bool IsContentEditable
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

	public virtual string TitleDisplayString
	{
		[Export("titleDisplayString")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selTitleDisplayStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTitleDisplayStringHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomHtmlElement(NSCoder coder)
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
	public DomHtmlElement(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomHtmlElement(IntPtr handle)
		: base(handle)
	{
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Children_var = null;
		}
	}
}
