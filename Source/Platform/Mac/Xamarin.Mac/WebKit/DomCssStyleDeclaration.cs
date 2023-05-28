using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace WebKit;

[Register("DOMCSSStyleDeclaration", true)]
[Deprecated(PlatformName.MacOSX, 10, 14, PlatformArchitecture.None, "No longer supported.")]
public class DomCssStyleDeclaration : DomObject, IIndexedContainer<string>, IEnumerable<string>, IEnumerable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCssText = "cssText";

	private static readonly IntPtr selCssTextHandle = Selector.GetHandle("cssText");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetPropertyCSSValue_ = "getPropertyCSSValue:";

	private static readonly IntPtr selGetPropertyCSSValue_Handle = Selector.GetHandle("getPropertyCSSValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetPropertyPriority_ = "getPropertyPriority:";

	private static readonly IntPtr selGetPropertyPriority_Handle = Selector.GetHandle("getPropertyPriority:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetPropertyShorthand_ = "getPropertyShorthand:";

	private static readonly IntPtr selGetPropertyShorthand_Handle = Selector.GetHandle("getPropertyShorthand:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetPropertyValue_ = "getPropertyValue:";

	private static readonly IntPtr selGetPropertyValue_Handle = Selector.GetHandle("getPropertyValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPropertyImplicit_ = "isPropertyImplicit:";

	private static readonly IntPtr selIsPropertyImplicit_Handle = Selector.GetHandle("isPropertyImplicit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItem_ = "item:";

	private static readonly IntPtr selItem_Handle = Selector.GetHandle("item:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLength = "length";

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selParentRule = "parentRule";

	private static readonly IntPtr selParentRuleHandle = Selector.GetHandle("parentRule");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveProperty_ = "removeProperty:";

	private static readonly IntPtr selRemoveProperty_Handle = Selector.GetHandle("removeProperty:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetCssText_ = "setCssText:";

	private static readonly IntPtr selSetCssText_Handle = Selector.GetHandle("setCssText:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetProperty_Value_Priority_ = "setProperty:value:priority:";

	private static readonly IntPtr selSetProperty_Value_Priority_Handle = Selector.GetHandle("setProperty:value:priority:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("DOMCSSStyleDeclaration");

	public string this[int index] => GetItem(index);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual int Count
	{
		[Export("length")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.int_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.int_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string CssText
	{
		[Export("cssText", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selCssTextHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selCssTextHandle));
		}
		[Export("setCssText:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomCssRule ParentRule
	{
		[Export("parentRule", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<DomCssRule>(Messaging.IntPtr_objc_msgSend(base.Handle, selParentRuleHandle));
			}
			return Runtime.GetNSObject<DomCssRule>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selParentRuleHandle));
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected DomCssStyleDeclaration(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal DomCssStyleDeclaration(IntPtr handle)
		: base(handle)
	{
	}

	[Export("item:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetItem(int index)
	{
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_int(base.Handle, selItem_Handle, index));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_int(base.SuperHandle, selItem_Handle, index));
	}

	[Export("getPropertyCSSValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual DomCssValue GetPropertyCssValue(string propertyName)
	{
		if (propertyName == null)
		{
			throw new ArgumentNullException("propertyName");
		}
		IntPtr arg = NSString.CreateNative(propertyName);
		DomCssValue result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<DomCssValue>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetPropertyCSSValue_Handle, arg)) : Runtime.GetNSObject<DomCssValue>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetPropertyCSSValue_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getPropertyPriority:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetPropertyPriority(string propertyName)
	{
		if (propertyName == null)
		{
			throw new ArgumentNullException("propertyName");
		}
		IntPtr arg = NSString.CreateNative(propertyName);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetPropertyPriority_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetPropertyPriority_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getPropertyShorthand:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetPropertyShorthand(string propertyName)
	{
		if (propertyName == null)
		{
			throw new ArgumentNullException("propertyName");
		}
		IntPtr arg = NSString.CreateNative(propertyName);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetPropertyShorthand_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetPropertyShorthand_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("getPropertyValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetPropertyValue(string propertyName)
	{
		if (propertyName == null)
		{
			throw new ArgumentNullException("propertyName");
		}
		IntPtr arg = NSString.CreateNative(propertyName);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGetPropertyValue_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGetPropertyValue_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isPropertyImplicit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsPropertyImplicit(string propertyName)
	{
		if (propertyName == null)
		{
			throw new ArgumentNullException("propertyName");
		}
		IntPtr arg = NSString.CreateNative(propertyName);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsPropertyImplicit_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsPropertyImplicit_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("removeProperty:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string RemoveProperty(string propertyName)
	{
		if (propertyName == null)
		{
			throw new ArgumentNullException("propertyName");
		}
		IntPtr arg = NSString.CreateNative(propertyName);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selRemoveProperty_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selRemoveProperty_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setProperty:value:priority:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selSetProperty_Value_Priority_Handle, arg, arg2, arg3);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selSetProperty_Value_Priority_Handle, arg, arg2, arg3);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}
}
