using System;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NaturalLanguage;

[Register("NLGazetteer", true)]
[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
public class NLGazetteer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selData = "data";

	private static readonly IntPtr selDataHandle = Selector.GetHandle("data");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGazetteerWithContentsOfURL_Error_ = "gazetteerWithContentsOfURL:error:";

	private static readonly IntPtr selGazetteerWithContentsOfURL_Error_Handle = Selector.GetHandle("gazetteerWithContentsOfURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithContentsOfURL_Error_ = "initWithContentsOfURL:error:";

	private static readonly IntPtr selInitWithContentsOfURL_Error_Handle = Selector.GetHandle("initWithContentsOfURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_Error_ = "initWithData:error:";

	private static readonly IntPtr selInitWithData_Error_Handle = Selector.GetHandle("initWithData:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDictionary_Language_Error_ = "initWithDictionary:language:error:";

	private static readonly IntPtr selInitWithDictionary_Language_Error_Handle = Selector.GetHandle("initWithDictionary:language:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLabelForString_ = "labelForString:";

	private static readonly IntPtr selLabelForString_Handle = Selector.GetHandle("labelForString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguage = "language";

	private static readonly IntPtr selLanguageHandle = Selector.GetHandle("language");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWriteGazetteerForDictionary_Language_ToURL_Error_ = "writeGazetteerForDictionary:language:toURL:error:";

	private static readonly IntPtr selWriteGazetteerForDictionary_Language_ToURL_Error_Handle = Selector.GetHandle("writeGazetteerForDictionary:language:toURL:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NLGazetteer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData Data
	{
		[Export("data", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selDataHandle));
			}
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDataHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[BindAs(typeof(NLLanguage?), OriginalType = typeof(NSString))]
	public virtual NLLanguage? Language
	{
		[Export("language")]
		get
		{
			IntPtr ptr;
			if (base.IsDirectBinding)
			{
				return ((ptr = Messaging.IntPtr_objc_msgSend(base.Handle, selLanguageHandle)) == IntPtr.Zero) ? null : new NLLanguage?(NLLanguageExtensions.GetValue(Runtime.GetNSObject<NSString>(ptr)));
			}
			IntPtr ptr2;
			return ((ptr2 = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLanguageHandle)) == IntPtr.Zero) ? null : new NLLanguage?(NLLanguageExtensions.GetValue(Runtime.GetNSObject<NSString>(ptr2)));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NLGazetteer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NLGazetteer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithContentsOfURL:error:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NLGazetteer(NSUrl url, out NSError? error)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithContentsOfURL_Error_Handle, url.Handle, ref arg), "initWithContentsOfURL:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithContentsOfURL_Error_Handle, url.Handle, ref arg), "initWithContentsOfURL:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initWithData:error:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NLGazetteer(NSData data, out NSError? error)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithData_Error_Handle, data.Handle, ref arg), "initWithData:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithData_Error_Handle, data.Handle, ref arg), "initWithData:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[Export("initWithDictionary:language:error:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NLGazetteer(NSDictionary dictionary, NSString? language, out NSError? error)
		: base(NSObjectFlag.Empty)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitWithDictionary_Language_Error_Handle, dictionary.Handle, (language == null) ? IntPtr.Zero : language.Handle, ref arg), "initWithDictionary:language:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithDictionary_Language_Error_Handle, dictionary.Handle, (language == null) ? IntPtr.Zero : language.Handle, ref arg), "initWithDictionary:language:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NLGazetteer(NLStrongDictionary dictionary, NLLanguage? language, out NSError? error)
		: this(dictionary.GetDictionary(), language.HasValue ? language.Value.GetConstant() : null, out error)
	{
	}

	[Export("gazetteerWithContentsOfURL:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NLGazetteer? Create(NSUrl url, out NSError? error)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		NLGazetteer nSObject = Runtime.GetNSObject<NLGazetteer>(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(class_ptr, selGazetteerWithContentsOfURL_Error_Handle, url.Handle, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
		return nSObject;
	}

	[Export("labelForString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? GetLabel(string @string)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		IntPtr arg = NSString.CreateNative(@string);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLabelForString_Handle, arg)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLabelForString_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("writeGazetteerForDictionary:language:toURL:error:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool Write(NSDictionary dictionary, NSString? language, NSUrl url, out NSError? error)
	{
		if (dictionary == null)
		{
			throw new ArgumentNullException("dictionary");
		}
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr(class_ptr, selWriteGazetteerForDictionary_Language_ToURL_Error_Handle, dictionary.Handle, (language == null) ? IntPtr.Zero : language.Handle, url.Handle, ref arg);
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool Write(NLStrongDictionary dictionary, NLLanguage? language, NSUrl url, out NSError? error)
	{
		return Write(dictionary.GetDictionary(), language.HasValue ? language.Value.GetConstant() : null, url, out error);
	}
}
