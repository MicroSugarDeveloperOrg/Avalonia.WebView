using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMText", true)]
public class DomText : DomCharacterData
{
	private static readonly IntPtr selWholeTextHandle = Selector.GetHandle("wholeText");

	private static readonly IntPtr selSplitText_Handle = Selector.GetHandle("splitText:");

	private static readonly IntPtr selReplaceWholeText_Handle = Selector.GetHandle("replaceWholeText:");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMText");

	public override IntPtr ClassHandle => class_ptr;

	public virtual string WholeText
	{
		[Export("wholeText")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selWholeTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWholeTextHandle));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomText(NSCoder coder)
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
	public DomText(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomText(IntPtr handle)
		: base(handle)
	{
	}

	[Export("splitText:")]
	public virtual DomText SplitText(uint offset)
	{
		if (IsDirectBinding)
		{
			return (DomText)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt32(base.Handle, selSplitText_Handle, offset));
		}
		return (DomText)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt32(base.SuperHandle, selSplitText_Handle, offset));
	}

	[Export("replaceWholeText:")]
	public virtual DomText ReplaceWholeText(string content)
	{
		if (content == null)
		{
			throw new ArgumentNullException("content");
		}
		IntPtr arg = NSString.CreateNative(content);
		DomText result = ((!IsDirectBinding) ? ((DomText)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceWholeText_Handle, arg))) : ((DomText)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selReplaceWholeText_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}
}
