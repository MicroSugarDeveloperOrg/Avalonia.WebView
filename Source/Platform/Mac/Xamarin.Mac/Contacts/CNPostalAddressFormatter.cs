using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Register("CNPostalAddressFormatter", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CNPostalAddressFormatter : NSFormatter
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedStringFromPostalAddress_Style_WithDefaultAttributes_ = "attributedStringFromPostalAddress:style:withDefaultAttributes:";

	private static readonly IntPtr selAttributedStringFromPostalAddress_Style_WithDefaultAttributes_Handle = Selector.GetHandle("attributedStringFromPostalAddress:style:withDefaultAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedStringFromPostalAddress_WithDefaultAttributes_ = "attributedStringFromPostalAddress:withDefaultAttributes:";

	private static readonly IntPtr selAttributedStringFromPostalAddress_WithDefaultAttributes_Handle = Selector.GetHandle("attributedStringFromPostalAddress:withDefaultAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStyle_ = "setStyle:";

	private static readonly IntPtr selSetStyle_Handle = Selector.GetHandle("setStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromPostalAddress_ = "stringFromPostalAddress:";

	private static readonly IntPtr selStringFromPostalAddress_Handle = Selector.GetHandle("stringFromPostalAddress:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromPostalAddress_Style_ = "stringFromPostalAddress:style:";

	private static readonly IntPtr selStringFromPostalAddress_Style_Handle = Selector.GetHandle("stringFromPostalAddress:style:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStyle = "style";

	private static readonly IntPtr selStyleHandle = Selector.GetHandle("style");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CNPostalAddressFormatter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _LocalizedPropertyNameAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _PropertyAttribute;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNPostalAddressFormatterStyle Style
	{
		[Export("style")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CNPostalAddressFormatterStyle)Messaging.Int64_objc_msgSend(base.Handle, selStyleHandle);
			}
			return (CNPostalAddressFormatterStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStyleHandle);
		}
		[Export("setStyle:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetStyle_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetStyle_Handle, (long)value);
			}
		}
	}

	[Field("CNPostalAddressLocalizedPropertyNameAttribute", "Contacts")]
	public static NSString LocalizedPropertyNameAttribute
	{
		get
		{
			if (_LocalizedPropertyNameAttribute == null)
			{
				_LocalizedPropertyNameAttribute = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNPostalAddressLocalizedPropertyNameAttribute");
			}
			return _LocalizedPropertyNameAttribute;
		}
	}

	[Field("CNPostalAddressPropertyAttribute", "Contacts")]
	public static NSString PropertyAttribute
	{
		get
		{
			if (_PropertyAttribute == null)
			{
				_PropertyAttribute = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNPostalAddressPropertyAttribute");
			}
			return _PropertyAttribute;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CNPostalAddressFormatter()
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
	public CNPostalAddressFormatter(NSCoder coder)
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
	protected CNPostalAddressFormatter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CNPostalAddressFormatter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("attributedStringFromPostalAddress:style:withDefaultAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAttributedString GetAttributedStringFrom(CNPostalAddress postalAddress, CNPostalAddressFormatterStyle style, NSDictionary attributes)
	{
		if (postalAddress == null)
		{
			throw new ArgumentNullException("postalAddress");
		}
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_IntPtr_Int64_IntPtr(class_ptr, selAttributedStringFromPostalAddress_Style_WithDefaultAttributes_Handle, postalAddress.Handle, (long)style, attributes.Handle));
	}

	[Export("attributedStringFromPostalAddress:withDefaultAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString GetAttributedStringFromPostalAddress(CNPostalAddress postalAddress, NSDictionary attributes)
	{
		if (postalAddress == null)
		{
			throw new ArgumentNullException("postalAddress");
		}
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selAttributedStringFromPostalAddress_WithDefaultAttributes_Handle, postalAddress.Handle, attributes.Handle));
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAttributedStringFromPostalAddress_WithDefaultAttributes_Handle, postalAddress.Handle, attributes.Handle));
	}

	[Export("stringFromPostalAddress:style:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetStringFrom(CNPostalAddress postalAddress, CNPostalAddressFormatterStyle style)
	{
		if (postalAddress == null)
		{
			throw new ArgumentNullException("postalAddress");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Int64(class_ptr, selStringFromPostalAddress_Style_Handle, postalAddress.Handle, (long)style));
	}

	[Export("stringFromPostalAddress:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetStringFromPostalAddress(CNPostalAddress postalAddress)
	{
		if (postalAddress == null)
		{
			throw new ArgumentNullException("postalAddress");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringFromPostalAddress_Handle, postalAddress.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringFromPostalAddress_Handle, postalAddress.Handle));
	}
}
