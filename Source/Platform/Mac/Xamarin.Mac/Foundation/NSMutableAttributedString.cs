using System;
using System.ComponentModel;
using AppKit;
using CoreText;
using ObjCRuntime;

namespace Foundation;

[Register("NSMutableAttributedString", true)]
public class NSMutableAttributedString : NSAttributedString
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAttribute_Value_Range_ = "addAttribute:value:range:";

	private static readonly IntPtr selAddAttribute_Value_Range_Handle = Selector.GetHandle("addAttribute:value:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAddAttributes_Range_ = "addAttributes:range:";

	private static readonly IntPtr selAddAttributes_Range_Handle = Selector.GetHandle("addAttributes:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendAttributedString_ = "appendAttributedString:";

	private static readonly IntPtr selAppendAttributedString_Handle = Selector.GetHandle("appendAttributedString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBeginEditing = "beginEditing";

	private static readonly IntPtr selBeginEditingHandle = Selector.GetHandle("beginEditing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteCharactersInRange_ = "deleteCharactersInRange:";

	private static readonly IntPtr selDeleteCharactersInRange_Handle = Selector.GetHandle("deleteCharactersInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEndEditing = "endEditing";

	private static readonly IntPtr selEndEditingHandle = Selector.GetHandle("endEditing");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAttributedString_ = "initWithAttributedString:";

	private static readonly IntPtr selInitWithAttributedString_Handle = Selector.GetHandle("initWithAttributedString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithString_ = "initWithString:";

	private static readonly IntPtr selInitWithString_Handle = Selector.GetHandle("initWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithString_Attributes_ = "initWithString:attributes:";

	private static readonly IntPtr selInitWithString_Attributes_Handle = Selector.GetHandle("initWithString:attributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertAttributedString_AtIndex_ = "insertAttributedString:atIndex:";

	private static readonly IntPtr selInsertAttributedString_AtIndex_Handle = Selector.GetHandle("insertAttributedString:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableString = "mutableString";

	private static readonly IntPtr selMutableStringHandle = Selector.GetHandle("mutableString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadFromURL_Options_DocumentAttributes_Error_ = "readFromURL:options:documentAttributes:error:";

	private static readonly IntPtr selReadFromURL_Options_DocumentAttributes_Error_Handle = Selector.GetHandle("readFromURL:options:documentAttributes:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRemoveAttribute_Range_ = "removeAttribute:range:";

	private static readonly IntPtr selRemoveAttribute_Range_Handle = Selector.GetHandle("removeAttribute:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceCharactersInRange_WithAttributedString_ = "replaceCharactersInRange:withAttributedString:";

	private static readonly IntPtr selReplaceCharactersInRange_WithAttributedString_Handle = Selector.GetHandle("replaceCharactersInRange:withAttributedString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceCharactersInRange_WithString_ = "replaceCharactersInRange:withString:";

	private static readonly IntPtr selReplaceCharactersInRange_WithString_Handle = Selector.GetHandle("replaceCharactersInRange:withString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributedString_ = "setAttributedString:";

	private static readonly IntPtr selSetAttributedString_Handle = Selector.GetHandle("setAttributedString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAttributes_Range_ = "setAttributes:range:";

	private static readonly IntPtr selSetAttributes_Range_Handle = Selector.GetHandle("setAttributes:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMutableAttributedString");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSMutableString MutableString
	{
		[Export("mutableString", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSMutableString>(Messaging.IntPtr_objc_msgSend(base.Handle, selMutableStringHandle));
			}
			return Runtime.GetNSObject<NSMutableString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selMutableStringHandle));
		}
	}

	public NSMutableAttributedString(string str, CTStringAttributes attributes)
		: this(str, attributes?.Dictionary)
	{
	}

	public void SetAttributes(NSDictionary attributes, NSRange range)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		LowLevelSetAttributes(attributes.Handle, range);
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableAttributedString()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init), "init");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[DesignatedInitializer]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSMutableAttributedString(NSCoder coder)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, Selector.InitWithCoder, coder.Handle), "initWithCoder:");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSMutableAttributedString(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMutableAttributedString(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMutableAttributedString(string str)
		: base(NSObjectFlag.Empty)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithString_Handle, arg), "initWithString:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithString_Handle, arg), "initWithString:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithString:attributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMutableAttributedString(string str, NSDictionary? attributes)
		: base(NSObjectFlag.Empty)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithString_Attributes_Handle, arg, attributes?.Handle ?? IntPtr.Zero), "initWithString:attributes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithString_Attributes_Handle, arg, attributes?.Handle ?? IntPtr.Zero), "initWithString:attributes:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithAttributedString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMutableAttributedString(NSAttributedString other)
		: base(NSObjectFlag.Empty)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAttributedString_Handle, other.Handle), "initWithAttributedString:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAttributedString_Handle, other.Handle), "initWithAttributedString:");
		}
	}

	[Export("addAttribute:value:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange(base.Handle, selAddAttribute_Value_Range_Handle, attributeName.Handle, value.Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_NSRange(base.SuperHandle, selAddAttribute_Value_Range_Handle, attributeName.Handle, value.Handle, range);
		}
	}

	[Export("addAttributes:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void AddAttributes(NSDictionary attrs, NSRange range)
	{
		if (attrs == null)
		{
			throw new ArgumentNullException("attrs");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selAddAttributes_Range_Handle, attrs.Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selAddAttributes_Range_Handle, attrs.Handle, range);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void AddAttributes(NSStringAttributes attributes, NSRange range)
	{
		AddAttributes(attributes.GetDictionary(), range);
	}

	[Export("appendAttributedString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Append(NSAttributedString attrString)
	{
		if (attrString == null)
		{
			throw new ArgumentNullException("attrString");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendAttributedString_Handle, attrString.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendAttributedString_Handle, attrString.Handle);
		}
	}

	[Export("beginEditing")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void BeginEditing()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selBeginEditingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selBeginEditingHandle);
		}
	}

	[Export("deleteCharactersInRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteRange(NSRange range)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selDeleteCharactersInRange_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selDeleteCharactersInRange_Handle, range);
		}
	}

	[Export("endEditing")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void EndEditing()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selEndEditingHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selEndEditingHandle);
		}
	}

	[Export("insertAttributedString:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Insert(NSAttributedString attrString, nint location)
	{
		if (attrString == null)
		{
			throw new ArgumentNullException("attrString");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertAttributedString_AtIndex_Handle, attrString.Handle, location);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertAttributedString_AtIndex_Handle, attrString.Handle, location);
		}
	}

	[Export("setAttributes:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LowLevelSetAttributes(IntPtr dictionaryAttrsHandle, NSRange range)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selSetAttributes_Range_Handle, dictionaryAttrsHandle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSetAttributes_Range_Handle, dictionaryAttrsHandle, range);
		}
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal bool ReadFromUrl(NSUrl url, NSDictionary options, ref NSDictionary<NSString, NSObject> returnOptions, ref NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = ((returnOptions == null) ? IntPtr.Zero : returnOptions.Handle);
		IntPtr arg2 = ((error == null) ? IntPtr.Zero : error.Handle);
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr(base.Handle, selReadFromURL_Options_DocumentAttributes_Error_Handle, url.Handle, options.Handle, ref arg, ref arg2);
		returnOptions = Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
		return result;
	}

	[Export("readFromURL:options:documentAttributes:error:")]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ReadFromUrl(NSUrl url, NSDictionary<NSString, NSObject> options, ref NSDictionary<NSString, NSObject> returnOptions, ref NSError error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = ((returnOptions == null) ? IntPtr.Zero : returnOptions.Handle);
		IntPtr arg2 = ((error == null) ? IntPtr.Zero : error.Handle);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr(base.SuperHandle, selReadFromURL_Options_DocumentAttributes_Error_Handle, url.Handle, options.Handle, ref arg, ref arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr(base.Handle, selReadFromURL_Options_DocumentAttributes_Error_Handle, url.Handle, options.Handle, ref arg, ref arg2));
		returnOptions = Runtime.GetNSObject<NSDictionary<NSString, NSObject>>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
		return result;
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool ReadFromUrl(NSUrl url, NSAttributedStringDocumentAttributes options, ref NSDictionary<NSString, NSObject> returnOptions, ref NSError error)
	{
		return ReadFromUrl(url, options.GetDictionary(), ref returnOptions, ref error);
	}

	[Export("removeAttribute:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RemoveAttribute(string name, NSRange range)
	{
		if (name == null)
		{
			throw new ArgumentNullException("name");
		}
		IntPtr arg = NSString.CreateNative(name);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selRemoveAttribute_Range_Handle, arg, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selRemoveAttribute_Range_Handle, arg, range);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("replaceCharactersInRange:withString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Replace(NSRange range, string newValue)
	{
		if (newValue == null)
		{
			throw new ArgumentNullException("newValue");
		}
		IntPtr arg = NSString.CreateNative(newValue);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selReplaceCharactersInRange_WithString_Handle, range, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selReplaceCharactersInRange_WithString_Handle, range, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("replaceCharactersInRange:withAttributedString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Replace(NSRange range, NSAttributedString value)
	{
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selReplaceCharactersInRange_WithAttributedString_Handle, range, value.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selReplaceCharactersInRange_WithAttributedString_Handle, range, value.Handle);
		}
	}

	[Export("setAttributedString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetString(NSAttributedString attrString)
	{
		if (attrString == null)
		{
			throw new ArgumentNullException("attrString");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAttributedString_Handle, attrString.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAttributedString_Handle, attrString.Handle);
		}
	}
}
