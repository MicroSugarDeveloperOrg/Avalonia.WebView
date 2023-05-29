using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMCSSStyleDeclaration", true)]
public class DomCssStyleDeclaration : DomObject, IIndexedContainer<string>, IEnumerable<string>, IEnumerable
{
	private static readonly IntPtr selCssTextHandle = Selector.GetHandle("cssText");

	private static readonly IntPtr selSetCssText_Handle = Selector.GetHandle("setCssText:");

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	private static readonly IntPtr selParentRuleHandle = Selector.GetHandle("parentRule");

	private static readonly IntPtr selGetPropertyValue_Handle = Selector.GetHandle("getPropertyValue:");

	private static readonly IntPtr selGetPropertyCSSValue_Handle = Selector.GetHandle("getPropertyCSSValue:");

	private static readonly IntPtr selRemoveProperty_Handle = Selector.GetHandle("removeProperty:");

	private static readonly IntPtr selGetPropertyPriority_Handle = Selector.GetHandle("getPropertyPriority:");

	private static readonly IntPtr selSetPropertyValuePriority_Handle = Selector.GetHandle("setProperty:value:priority:");

	private static readonly IntPtr selItem_Handle = Selector.GetHandle("item:");

	private static readonly IntPtr selGetPropertyShorthand_Handle = Selector.GetHandle("getPropertyShorthand:");

	private static readonly IntPtr selIsPropertyImplicit_Handle = Selector.GetHandle("isPropertyImplicit:");

	private static readonly IntPtr class_ptr = Class.GetHandle("DOMCSSStyleDeclaration");

	private object __mt_ParentRule_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string CssText
	{
		[Export("cssText")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCssTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCssTextHandle));
		}
		[Export("setCssText:")]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetCssText_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetCssText_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	public virtual int Count
	{
		[Export("length")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
	}

	public virtual DomCssRule ParentRule
	{
		[Export("parentRule")]
		get
		{
			return (DomCssRule)(__mt_ParentRule_var = ((!IsDirectBinding) ? ((DomCssRule)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentRuleHandle))) : ((DomCssRule)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selParentRuleHandle)))));
		}
	}

	public string this[int index] => GetItem(index);

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public DomCssStyleDeclaration(NSCoder coder)
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
	public DomCssStyleDeclaration(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public DomCssStyleDeclaration(IntPtr handle)
		: base(handle)
	{
	}

	[Export("getPropertyValue:")]
	public virtual string GetPropertyValue(string propertyName)
	{
		if (propertyName == null)
		{
			throw new ArgumentNullException("propertyName");
		}
		IntPtr arg = NSString.CreateNative(propertyName);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetPropertyValue_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetPropertyValue_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getPropertyCSSValue:")]
	public virtual DomCssValue GetPropertyCssValue(string propertyName)
	{
		if (propertyName == null)
		{
			throw new ArgumentNullException("propertyName");
		}
		IntPtr arg = NSString.CreateNative(propertyName);
		DomCssValue result = ((!IsDirectBinding) ? ((DomCssValue)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetPropertyCSSValue_Handle, arg))) : ((DomCssValue)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetPropertyCSSValue_Handle, arg))));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeProperty:")]
	public virtual string RemoveProperty(string propertyName)
	{
		if (propertyName == null)
		{
			throw new ArgumentNullException("propertyName");
		}
		IntPtr arg = NSString.CreateNative(propertyName);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveProperty_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRemoveProperty_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getPropertyPriority:")]
	public virtual string GetPropertyPriority(string propertyName)
	{
		if (propertyName == null)
		{
			throw new ArgumentNullException("propertyName");
		}
		IntPtr arg = NSString.CreateNative(propertyName);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetPropertyPriority_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetPropertyPriority_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setProperty:value:priority:")]
	public virtual void SetProperty(string propertyName, string value, string priority)
	{
		if (propertyName == null)
		{
			throw new ArgumentNullException("propertyName");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (priority == null)
		{
			throw new ArgumentNullException("priority");
		}
		IntPtr arg = NSString.CreateNative(propertyName);
		IntPtr arg2 = NSString.CreateNative(value);
		IntPtr arg3 = NSString.CreateNative(priority);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSetPropertyValuePriority_Handle, arg, arg2, arg3);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetPropertyValuePriority_Handle, arg, arg2, arg3);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("item:")]
	public virtual string GetItem(int index)
	{
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_int(base.Handle, selItem_Handle, index));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selItem_Handle, index));
	}

	[Export("getPropertyShorthand:")]
	public virtual string GetPropertyShorthand(string propertyName)
	{
		if (propertyName == null)
		{
			throw new ArgumentNullException("propertyName");
		}
		IntPtr arg = NSString.CreateNative(propertyName);
		string result = ((!IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetPropertyShorthand_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetPropertyShorthand_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isPropertyImplicit:")]
	public virtual bool IsPropertyImplicit(string propertyName)
	{
		if (propertyName == null)
		{
			throw new ArgumentNullException("propertyName");
		}
		IntPtr arg = NSString.CreateNative(propertyName);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsPropertyImplicit_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsPropertyImplicit_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_ParentRule_var = null;
		}
	}

	public IEnumerator<string> GetEnumerator()
	{
		return new IndexedContainerEnumerator<string>(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<string>)this).GetEnumerator();
	}
}
