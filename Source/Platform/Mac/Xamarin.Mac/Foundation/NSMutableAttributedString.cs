using System;
using System.ComponentModel;
using CoreText;
using ObjCRuntime;

namespace Foundation;

[Register("NSMutableAttributedString", true)]
public class NSMutableAttributedString : NSAttributedString
{
	private static readonly IntPtr selInitWithString_Handle = Selector.GetHandle("initWithString:");

	private static readonly IntPtr selInitWithStringAttributes_Handle = Selector.GetHandle("initWithString:attributes:");

	private static readonly IntPtr selInitWithAttributedString_Handle = Selector.GetHandle("initWithAttributedString:");

	private static readonly IntPtr selReplaceCharactersInRangeWithString_Handle = Selector.GetHandle("replaceCharactersInRange:withString:");

	private static readonly IntPtr selSetAttributesRange_Handle = Selector.GetHandle("setAttributes:range:");

	private static readonly IntPtr selAddAttributeValueRange_Handle = Selector.GetHandle("addAttribute:value:range:");

	private static readonly IntPtr selAddAttributesRange_Handle = Selector.GetHandle("addAttributes:range:");

	private static readonly IntPtr selRemoveAttributeRange_Handle = Selector.GetHandle("removeAttribute:range:");

	private static readonly IntPtr selReplaceCharactersInRangeWithAttributedString_Handle = Selector.GetHandle("replaceCharactersInRange:withAttributedString:");

	private static readonly IntPtr selInsertAttributedStringAtIndex_Handle = Selector.GetHandle("insertAttributedString:atIndex:");

	private static readonly IntPtr selAppendAttributedString_Handle = Selector.GetHandle("appendAttributedString:");

	private static readonly IntPtr selDeleteCharactersInRange_Handle = Selector.GetHandle("deleteCharactersInRange:");

	private static readonly IntPtr selSetAttributedString_Handle = Selector.GetHandle("setAttributedString:");

	private static readonly IntPtr selBeginEditingHandle = Selector.GetHandle("beginEditing");

	private static readonly IntPtr selEndEditingHandle = Selector.GetHandle("endEditing");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSMutableAttributedString");

	public override IntPtr ClassHandle => class_ptr;

	public NSMutableAttributedString(string str, CTStringAttributes attributes)
		: this(str, attributes?.Dictionary)
	{
	}

	public void SetAttributes(CTStringAttributes attrs, NSRange range)
	{
		SetAttributes(attrs?.Dictionary, range);
	}

	public void AddAttributes(CTStringAttributes attrs, NSRange range)
	{
		AddAttributes(attrs?.Dictionary, range);
	}

	public void Append(NSAttributedString first, params object[] rest)
	{
		Append(first);
		foreach (object obj in rest)
		{
			if (obj is NSAttributedString)
			{
				Append((NSAttributedString)obj);
			}
			else if (obj is string)
			{
				Append(new NSAttributedString((string)obj));
			}
			else
			{
				Append(new NSAttributedString(obj.ToString()));
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableAttributedString()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSMutableAttributedString(NSCoder coder)
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
	public NSMutableAttributedString(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSMutableAttributedString(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithString:")]
	public NSMutableAttributedString(string str)
		: base(NSObjectFlag.Empty)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithString_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithString_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithString:attributes:")]
	public NSMutableAttributedString(string str, NSDictionary attributes)
		: base(NSObjectFlag.Empty)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		IntPtr arg = NSString.CreateNative(str);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithStringAttributes_Handle, arg, attributes.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithStringAttributes_Handle, arg, attributes.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithAttributedString:")]
	public NSMutableAttributedString(NSAttributedString other)
		: base(NSObjectFlag.Empty)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAttributedString_Handle, other.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAttributedString_Handle, other.Handle);
		}
	}

	[Export("replaceCharactersInRange:withString:")]
	public virtual void Replace(NSRange range, string newValue)
	{
		if (newValue == null)
		{
			throw new ArgumentNullException("newValue");
		}
		IntPtr arg = NSString.CreateNative(newValue);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selReplaceCharactersInRangeWithString_Handle, range, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selReplaceCharactersInRangeWithString_Handle, range, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("setAttributes:range:")]
	public virtual void SetAttributes(NSDictionary attrs, NSRange range)
	{
		if (attrs == null)
		{
			throw new ArgumentNullException("attrs");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selSetAttributesRange_Handle, attrs.Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSetAttributesRange_Handle, attrs.Handle, range);
		}
	}

	[Export("addAttribute:value:range:")]
	public virtual void AddAttribute(NSString attributeName, NSObject value, NSRange range)
	{
		if (attributeName == null)
		{
			throw new ArgumentNullException("attributeName");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange(base.Handle, selAddAttributeValueRange_Handle, attributeName.Handle, value.Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_NSRange(base.SuperHandle, selAddAttributeValueRange_Handle, attributeName.Handle, value.Handle, range);
		}
	}

	[Export("addAttributes:range:")]
	public virtual void AddAttributes(NSDictionary attrs, NSRange range)
	{
		if (attrs == null)
		{
			throw new ArgumentNullException("attrs");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selAddAttributesRange_Handle, attrs.Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selAddAttributesRange_Handle, attrs.Handle, range);
		}
	}

	[Export("removeAttribute:range:")]
	public virtual void RemoveAttribute(string name, NSRange range)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selRemoveAttributeRange_Handle, arg, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selRemoveAttributeRange_Handle, arg, range);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("replaceCharactersInRange:withAttributedString:")]
	public virtual void Replace(NSRange range, NSAttributedString value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selReplaceCharactersInRangeWithAttributedString_Handle, range, value.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selReplaceCharactersInRangeWithAttributedString_Handle, range, value.Handle);
		}
	}

	[Export("insertAttributedString:atIndex:")]
	public virtual void Insert(NSAttributedString attrString, ulong location)
	{
		if (attrString == null)
		{
			throw new ArgumentNullException("attrString");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64(base.Handle, selInsertAttributedStringAtIndex_Handle, attrString.Handle, location);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInsertAttributedStringAtIndex_Handle, attrString.Handle, location);
		}
	}

	[Export("appendAttributedString:")]
	public virtual void Append(NSAttributedString attrString)
	{
		if (attrString == null)
		{
			throw new ArgumentNullException("attrString");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendAttributedString_Handle, attrString.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendAttributedString_Handle, attrString.Handle);
		}
	}

	[Export("deleteCharactersInRange:")]
	public virtual void DeleteRange(NSRange range)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selDeleteCharactersInRange_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selDeleteCharactersInRange_Handle, range);
		}
	}

	[Export("setAttributedString:")]
	public virtual void SetString(NSAttributedString attrString)
	{
		if (attrString == null)
		{
			throw new ArgumentNullException("attrString");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributedString_Handle, attrString.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributedString_Handle, attrString.Handle);
		}
	}

	[Export("beginEditing")]
	public virtual void BeginEditing()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBeginEditingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBeginEditingHandle);
		}
	}

	[Export("endEditing")]
	public virtual void EndEditing()
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEndEditingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEndEditingHandle);
		}
	}
}
