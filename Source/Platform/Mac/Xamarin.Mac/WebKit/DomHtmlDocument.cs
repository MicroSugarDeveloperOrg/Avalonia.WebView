using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMHTMLDocument", true)]
public class DomHtmlDocument : DomDocument
{
	private static readonly IntPtr selEmbedsHandle = Selector.GetHandle("embeds");

	private static readonly IntPtr selPluginsHandle = Selector.GetHandle("plugins");

	private static readonly IntPtr selScriptsHandle = Selector.GetHandle("scripts");

	private static readonly IntPtr selWidthHandle = Selector.GetHandle("width");

	private static readonly IntPtr selHeightHandle = Selector.GetHandle("height");

	private static readonly IntPtr selDirHandle = Selector.GetHandle("dir");

	private static readonly IntPtr selSetDir_Handle = Selector.GetHandle("setDir:");

	private static readonly IntPtr selDesignModeHandle = Selector.GetHandle("designMode");

	private static readonly IntPtr selSetDesignMode_Handle = Selector.GetHandle("setDesignMode:");

	private static readonly IntPtr selCompatModeHandle = Selector.GetHandle("compatMode");

	private static readonly IntPtr selActiveElementHandle = Selector.GetHandle("activeElement");

	private static readonly IntPtr selBgColorHandle = Selector.GetHandle("bgColor");

	private static readonly IntPtr selSetBgColor_Handle = Selector.GetHandle("setBgColor:");

	private static readonly IntPtr selFgColorHandle = Selector.GetHandle("fgColor");

	private static readonly IntPtr selSetFgColor_Handle = Selector.GetHandle("setFgColor:");

	private static readonly IntPtr selAlinkColorHandle = Selector.GetHandle("alinkColor");

	private static readonly IntPtr selSetAlinkColor_Handle = Selector.GetHandle("setAlinkColor:");

	private static readonly IntPtr selLinkColorHandle = Selector.GetHandle("linkColor");

	private static readonly IntPtr selSetLinkColor_Handle = Selector.GetHandle("setLinkColor:");

	private static readonly IntPtr selVlinkColorHandle = Selector.GetHandle("vlinkColor");

	private static readonly IntPtr selSetVlinkColor_Handle = Selector.GetHandle("setVlinkColor:");

	private static readonly IntPtr selOpenHandle = Selector.GetHandle("open");

	private static readonly IntPtr selCloseHandle = Selector.GetHandle("close");

	private static readonly IntPtr selWrite_Handle = Selector.GetHandle("write:");

	private static readonly IntPtr selWriteln_Handle = Selector.GetHandle("writeln:");

	private static readonly IntPtr selClearHandle = Selector.GetHandle("clear");

	private static readonly IntPtr selCaptureEventsHandle = Selector.GetHandle("captureEvents");

	private static readonly IntPtr selReleaseEventsHandle = Selector.GetHandle("releaseEvents");

	private static readonly IntPtr selHasFocusHandle = Selector.GetHandle("hasFocus");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMHTMLDocument");

	private object __mt_Embeds_var;

	private object __mt_Plugins_var;

	private object __mt_Scripts_var;

	private object __mt_ActiveElement_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual DomHtmlCollection Embeds
	{
		[Export("embeds")]
		get
		{
			return (DomHtmlCollection)(__mt_Embeds_var = ((!IsDirectBinding) ? ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selEmbedsHandle))) : ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selEmbedsHandle)))));
		}
	}

	public virtual DomHtmlCollection Plugins
	{
		[Export("plugins")]
		get
		{
			return (DomHtmlCollection)(__mt_Plugins_var = ((!IsDirectBinding) ? ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPluginsHandle))) : ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPluginsHandle)))));
		}
	}

	public virtual DomHtmlCollection Scripts
	{
		[Export("scripts")]
		get
		{
			return (DomHtmlCollection)(__mt_Scripts_var = ((!IsDirectBinding) ? ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selScriptsHandle))) : ((DomHtmlCollection)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selScriptsHandle)))));
		}
	}

	public virtual int Width
	{
		[Export("width")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selWidthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selWidthHandle);
		}
	}

	public virtual int Height
	{
		[Export("height")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selHeightHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selHeightHandle);
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

	public virtual string DesignMode
	{
		[Export("designMode")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDesignModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDesignModeHandle));
		}
		[Export("setDesignMode:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDesignMode_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDesignMode_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string CompatMode
	{
		[Export("compatMode")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCompatModeHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCompatModeHandle));
		}
	}

	public virtual DomElement ActiveElement
	{
		[Export("activeElement")]
		get
		{
			return (DomElement)(__mt_ActiveElement_var = ((!IsDirectBinding) ? ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selActiveElementHandle))) : ((DomElement)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selActiveElementHandle)))));
		}
	}

	public virtual string BackgroundColor
	{
		[Export("bgColor")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selBgColorHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBgColorHandle));
		}
		[Export("setBgColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetBgColor_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetBgColor_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string ForegroundColor
	{
		[Export("fgColor")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selFgColorHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selFgColorHandle));
		}
		[Export("setFgColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetFgColor_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetFgColor_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string ALinkColor
	{
		[Export("alinkColor")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAlinkColorHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAlinkColorHandle));
		}
		[Export("setAlinkColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAlinkColor_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAlinkColor_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string LinkColor
	{
		[Export("linkColor")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLinkColorHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLinkColorHandle));
		}
		[Export("setLinkColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLinkColor_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLinkColor_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual string VLinkColor
	{
		[Export("vlinkColor")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selVlinkColorHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selVlinkColorHandle));
		}
		[Export("setVlinkColor:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetVlinkColor_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetVlinkColor_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomHtmlDocument(NSCoder coder)
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
	public DomHtmlDocument(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomHtmlDocument(IntPtr handle)
		: base(handle)
	{
	}

	[Export("open")]
	public virtual void Open()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selOpenHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selOpenHandle);
		}
	}

	[Export("close")]
	public virtual void Close()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCloseHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCloseHandle);
		}
	}

	[Export("write:")]
	public virtual void Write(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		IntPtr arg = NSString.CreateNative(text);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWrite_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWrite_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("writeln:")]
	public virtual void Writeln(string text)
	{
		if (text == null)
		{
			throw new ArgumentNullException("text");
		}
		IntPtr arg = NSString.CreateNative(text);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selWriteln_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selWriteln_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("clear")]
	public virtual void Clear()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selClearHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selClearHandle);
		}
	}

	[Export("captureEvents")]
	public virtual void CaptureEvents()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selCaptureEventsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selCaptureEventsHandle);
		}
	}

	[Export("releaseEvents")]
	public virtual void ReleaseEvents()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selReleaseEventsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selReleaseEventsHandle);
		}
	}

	[Export("hasFocus")]
	public virtual bool HasFocus()
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend(base.Handle, selHasFocusHandle);
		}
		return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasFocusHandle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_Embeds_var = null;
			__mt_Plugins_var = null;
			__mt_Scripts_var = null;
			__mt_ActiveElement_var = null;
		}
	}
}
