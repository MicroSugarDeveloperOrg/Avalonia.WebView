using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace Contacts;

[Register("CNContactFormatter", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class CNContactFormatter : NSFormatter, INSCoding, INativeObject, IDisposable, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedStringFromContact_DefaultAttributes_ = "attributedStringFromContact:defaultAttributes:";

	private static readonly IntPtr selAttributedStringFromContact_DefaultAttributes_Handle = Selector.GetHandle("attributedStringFromContact:defaultAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedStringFromContact_Style_DefaultAttributes_ = "attributedStringFromContact:style:defaultAttributes:";

	private static readonly IntPtr selAttributedStringFromContact_Style_DefaultAttributes_Handle = Selector.GetHandle("attributedStringFromContact:style:defaultAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDelimiterForContact_ = "delimiterForContact:";

	private static readonly IntPtr selDelimiterForContact_Handle = Selector.GetHandle("delimiterForContact:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDescriptorForRequiredKeysForStyle_ = "descriptorForRequiredKeysForStyle:";

	private static readonly IntPtr selDescriptorForRequiredKeysForStyle_Handle = Selector.GetHandle("descriptorForRequiredKeysForStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNameOrderForContact_ = "nameOrderForContact:";

	private static readonly IntPtr selNameOrderForContact_Handle = Selector.GetHandle("nameOrderForContact:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStyle_ = "setStyle:";

	private static readonly IntPtr selSetStyle_Handle = Selector.GetHandle("setStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromContact_ = "stringFromContact:";

	private static readonly IntPtr selStringFromContact_Handle = Selector.GetHandle("stringFromContact:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromContact_Style_ = "stringFromContact:style:";

	private static readonly IntPtr selStringFromContact_Style_Handle = Selector.GetHandle("stringFromContact:style:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStyle = "style";

	private static readonly IntPtr selStyleHandle = Selector.GetHandle("style");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("CNContactFormatter");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _ContactPropertyAttribute;

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CNContactFormatterStyle Style
	{
		[Export("style")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (CNContactFormatterStyle)Messaging.Int64_objc_msgSend(base.Handle, selStyleHandle);
			}
			return (CNContactFormatterStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStyleHandle);
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

	[Field("CNContactPropertyAttribute", "Contacts")]
	public static NSString ContactPropertyAttribute
	{
		get
		{
			if (_ContactPropertyAttribute == null)
			{
				_ContactPropertyAttribute = Dlfcn.GetStringConstant(Libraries.Contacts.Handle, "CNContactPropertyAttribute");
			}
			return _ContactPropertyAttribute;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public CNContactFormatter()
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
	public CNContactFormatter(NSCoder coder)
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
	protected CNContactFormatter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal CNContactFormatter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
	{
		if (encoder == null)
		{
			throw new ArgumentNullException("encoder");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEncodeWithCoder_Handle, encoder.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEncodeWithCoder_Handle, encoder.Handle);
		}
	}

	[Export("attributedStringFromContact:defaultAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString? GetAttributedString(CNContact contact, NSDictionary? attributes)
	{
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selAttributedStringFromContact_DefaultAttributes_Handle, contact.Handle, attributes?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selAttributedStringFromContact_DefaultAttributes_Handle, contact.Handle, attributes?.Handle ?? IntPtr.Zero));
	}

	[Export("attributedStringFromContact:style:defaultAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAttributedString? GetAttributedStringFrom(CNContact contact, CNContactFormatterStyle style, NSDictionary? attributes)
	{
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_IntPtr_Int64_IntPtr(class_ptr, selAttributedStringFromContact_Style_DefaultAttributes_Handle, contact.Handle, (long)style, attributes?.Handle ?? IntPtr.Zero));
	}

	[Export("delimiterForContact:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetDelimiterFor(CNContact contact)
	{
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDelimiterForContact_Handle, contact.Handle));
	}

	[Export("descriptorForRequiredKeysForStyle:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static ICNKeyDescriptor GetDescriptorForRequiredKeys(CNContactFormatterStyle style)
	{
		return Runtime.GetINativeObject<ICNKeyDescriptor>(Messaging.IntPtr_objc_msgSend_Int64(class_ptr, selDescriptorForRequiredKeysForStyle_Handle, (long)style), owns: false);
	}

	[Export("nameOrderForContact:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static CNContactDisplayNameOrder GetNameOrderFor(CNContact contact)
	{
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		return (CNContactDisplayNameOrder)Messaging.Int64_objc_msgSend_IntPtr(class_ptr, selNameOrderForContact_Handle, contact.Handle);
	}

	[Export("stringFromContact:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? GetString(CNContact contact)
	{
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringFromContact_Handle, contact.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringFromContact_Handle, contact.Handle));
	}

	[Export("stringFromContact:style:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string? GetStringFrom(CNContact contact, CNContactFormatterStyle style)
	{
		if (contact == null)
		{
			throw new ArgumentNullException("contact");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Int64(class_ptr, selStringFromContact_Style_Handle, contact.Handle, (long)style));
	}
}
