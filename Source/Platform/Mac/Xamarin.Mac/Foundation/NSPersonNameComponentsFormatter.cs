using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSPersonNameComponentsFormatter", true)]
[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
public class NSPersonNameComponentsFormatter : NSFormatter
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAnnotatedStringFromPersonNameComponents_ = "annotatedStringFromPersonNameComponents:";

	private static readonly IntPtr selAnnotatedStringFromPersonNameComponents_Handle = Selector.GetHandle("annotatedStringFromPersonNameComponents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGetObjectValue_ForString_ErrorDescription_ = "getObjectValue:forString:errorDescription:";

	private static readonly IntPtr selGetObjectValue_ForString_ErrorDescription_Handle = Selector.GetHandle("getObjectValue:forString:errorDescription:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsPhonetic = "isPhonetic";

	private static readonly IntPtr selIsPhoneticHandle = Selector.GetHandle("isPhonetic");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLocalizedStringFromPersonNameComponents_Style_Options_ = "localizedStringFromPersonNameComponents:style:options:";

	private static readonly IntPtr selLocalizedStringFromPersonNameComponents_Style_Options_Handle = Selector.GetHandle("localizedStringFromPersonNameComponents:style:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPersonNameComponentsFromString_ = "personNameComponentsFromString:";

	private static readonly IntPtr selPersonNameComponentsFromString_Handle = Selector.GetHandle("personNameComponentsFromString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetPhonetic_ = "setPhonetic:";

	private static readonly IntPtr selSetPhonetic_Handle = Selector.GetHandle("setPhonetic:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetStyle_ = "setStyle:";

	private static readonly IntPtr selSetStyle_Handle = Selector.GetHandle("setStyle:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringFromPersonNameComponents_ = "stringFromPersonNameComponents:";

	private static readonly IntPtr selStringFromPersonNameComponents_Handle = Selector.GetHandle("stringFromPersonNameComponents:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStyle = "style";

	private static readonly IntPtr selStyleHandle = Selector.GetHandle("style");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSPersonNameComponentsFormatter");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Phonetic
	{
		[Export("isPhonetic")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsPhoneticHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsPhoneticHandle);
		}
		[Export("setPhonetic:")]
		set
		{
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetPhonetic_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetPhonetic_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersonNameComponentsFormatterStyle Style
	{
		[Export("style", ArgumentSemantic.Assign)]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSPersonNameComponentsFormatterStyle)Messaging.Int64_objc_msgSend(base.Handle, selStyleHandle);
			}
			return (NSPersonNameComponentsFormatterStyle)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selStyleHandle);
		}
		[Export("setStyle:", ArgumentSemantic.Assign)]
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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSPersonNameComponentsFormatter()
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
	public NSPersonNameComponentsFormatter(NSCoder coder)
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
	protected NSPersonNameComponentsFormatter(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSPersonNameComponentsFormatter(IntPtr handle)
		: base(handle)
	{
	}

	[Export("annotatedStringFromPersonNameComponents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSAttributedString GetAnnotatedString(NSPersonNameComponents components)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selAnnotatedStringFromPersonNameComponents_Handle, components.Handle));
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selAnnotatedStringFromPersonNameComponents_Handle, components.Handle));
	}

	[Export("personNameComponentsFromString:")]
	[Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 10, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPersonNameComponents? GetComponents(string @string)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		IntPtr arg = NSString.CreateNative(@string);
		NSPersonNameComponents result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSPersonNameComponents>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPersonNameComponentsFromString_Handle, arg)) : Runtime.GetNSObject<NSPersonNameComponents>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPersonNameComponentsFromString_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("localizedStringFromPersonNameComponents:style:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string GetLocalizedString(NSPersonNameComponents components, NSPersonNameComponentsFormatterStyle nameFormatStyle, NSPersonNameComponentsFormatterOptions nameOptions)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_Int64_UInt64(class_ptr, selLocalizedStringFromPersonNameComponents_Style_Options_Handle, components.Handle, (long)nameFormatStyle, (ulong)nameOptions));
	}

	[Export("getObjectValue:forString:errorDescription:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool GetObjectValue(out NSObject result, string str, out string errorDescription)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		IntPtr arg3 = NSString.CreateNative(str);
		bool result2 = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_ref_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selGetObjectValue_ForString_ErrorDescription_Handle, ref arg, arg3, ref arg2) : Messaging.bool_objc_msgSend_ref_IntPtr_IntPtr_ref_IntPtr(base.Handle, selGetObjectValue_ForString_ErrorDescription_Handle, ref arg, arg3, ref arg2));
		NSString.ReleaseNative(arg3);
		result = Runtime.GetNSObject<NSObject>(arg);
		errorDescription = NSString.FromHandle(arg2);
		return result2;
	}

	[Export("stringFromPersonNameComponents:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetString(NSPersonNameComponents components)
	{
		if (components == null)
		{
			throw new ArgumentNullException("components");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringFromPersonNameComponents_Handle, components.Handle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringFromPersonNameComponents_Handle, components.Handle));
	}
}
