using System;
using System.Collections.Generic;
using System.ComponentModel;
using Foundation;
using ObjCRuntime;

namespace NaturalLanguage;

[Register("NLLanguageRecognizer", true)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class NLLanguageRecognizer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDominantLanguage = "dominantLanguage";

	private static readonly IntPtr selDominantLanguageHandle = Selector.GetHandle("dominantLanguage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDominantLanguageForString_ = "dominantLanguageForString:";

	private static readonly IntPtr selDominantLanguageForString_Handle = Selector.GetHandle("dominantLanguageForString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInit = "init";

	private static readonly IntPtr selInitHandle = Selector.GetHandle("init");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguageConstraints = "languageConstraints";

	private static readonly IntPtr selLanguageConstraintsHandle = Selector.GetHandle("languageConstraints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguageHints = "languageHints";

	private static readonly IntPtr selLanguageHintsHandle = Selector.GetHandle("languageHints");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguageHypothesesWithMaximum_ = "languageHypothesesWithMaximum:";

	private static readonly IntPtr selLanguageHypothesesWithMaximum_Handle = Selector.GetHandle("languageHypothesesWithMaximum:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selProcessString_ = "processString:";

	private static readonly IntPtr selProcessString_Handle = Selector.GetHandle("processString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReset = "reset";

	private static readonly IntPtr selResetHandle = Selector.GetHandle("reset");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLanguageConstraints_ = "setLanguageConstraints:";

	private static readonly IntPtr selSetLanguageConstraints_Handle = Selector.GetHandle("setLanguageConstraints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLanguageHints_ = "setLanguageHints:";

	private static readonly IntPtr selSetLanguageHints_Handle = Selector.GetHandle("setLanguageHints:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NLLanguageRecognizer");

	public Dictionary<NLLanguage, double> LanguageHints
	{
		get
		{
			Dictionary<NLLanguage, double> dictionary = new Dictionary<NLLanguage, double>(NativeLanguageHints.Keys.Length);
			NSString[] keys = NativeLanguageHints.Keys;
			foreach (NSString nSString in keys)
			{
				dictionary[NLLanguageExtensions.GetValue(nSString)] = NativeLanguageHints[nSString].DoubleValue;
			}
			return dictionary;
		}
		set
		{
			int num = 0;
			NSString[] array = new NSString[value.Keys.Count];
			NSNumber[] array2 = new NSNumber[value.Keys.Count];
			foreach (KeyValuePair<NLLanguage, double> item in value)
			{
				array[num] = item.Key.GetConstant();
				array2[num] = new NSNumber(item.Value);
				num++;
			}
			NativeLanguageHints = NSDictionary<NSString, NSNumber>.FromObjectsAndKeys(array2, array, array.Length);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NLLanguage DominantLanguage => NLLanguageExtensions.GetValue(_DominantLanguage);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NLLanguage[] LanguageConstraints
	{
		get
		{
			return Array.ConvertAll(_LanguageConstraints, (NSString e) => NLLanguageExtensions.GetValue(e));
		}
		set
		{
			_LanguageConstraints = Array.ConvertAll(value, (NLLanguage e) => e.GetConstant());
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, NSNumber> NativeLanguageHints
	{
		[Export("languageHints", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary<NSString, NSNumber>>(Messaging.IntPtr_objc_msgSend(base.Handle, selLanguageHintsHandle));
			}
			return Runtime.GetNSObject<NSDictionary<NSString, NSNumber>>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLanguageHintsHandle));
		}
		[Export("setLanguageHints:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLanguageHints_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLanguageHints_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSString? _DominantLanguage
	{
		[Export("dominantLanguage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selDominantLanguageHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDominantLanguageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSString[] _LanguageConstraints
	{
		[Export("languageConstraints", ArgumentSemantic.Copy)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selLanguageConstraintsHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLanguageConstraintsHandle));
		}
		[Export("setLanguageConstraints:", ArgumentSemantic.Copy)]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			NSArray nSArray = NSArray.FromNSObjects(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLanguageConstraints_Handle, nSArray.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLanguageConstraints_Handle, nSArray.Handle);
			}
			nSArray.Dispose();
		}
	}

	public static NLLanguage GetDominantLanguage(string @string)
	{
		IntPtr string2 = NSString.CreateNative(@string);
		NSString nSString = _GetDominantLanguage(string2);
		NLLanguage value = NLLanguageExtensions.GetValue(nSString);
		nSString?.Dispose();
		NSString.ReleaseNative(string2);
		return value;
	}

	public Dictionary<NLLanguage, double> GetLanguageHypotheses(nuint maxHypotheses)
	{
		using NSDictionary<NSString, NSNumber> nSDictionary = GetNativeLanguageHypotheses(maxHypotheses);
		Dictionary<NLLanguage, double> dictionary = new Dictionary<NLLanguage, double>(nSDictionary.Keys.Length);
		NSString[] keys = nSDictionary.Keys;
		foreach (NSString nSString in keys)
		{
			dictionary[NLLanguageExtensions.GetValue(nSString)] = nSDictionary[nSString].DoubleValue;
		}
		return dictionary;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NLLanguageRecognizer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NLLanguageRecognizer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("init")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NLLanguageRecognizer()
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selInitHandle), "init");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInitHandle), "init");
		}
	}

	[Export("languageHypothesesWithMaximum:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary<NSString, NSNumber> GetNativeLanguageHypotheses(nuint maxHypotheses)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary<NSString, NSNumber>>(Messaging.IntPtr_objc_msgSend_nuint(base.Handle, selLanguageHypothesesWithMaximum_Handle, maxHypotheses));
		}
		return Runtime.GetNSObject<NSDictionary<NSString, NSNumber>>(Messaging.IntPtr_objc_msgSendSuper_nuint(base.SuperHandle, selLanguageHypothesesWithMaximum_Handle, maxHypotheses));
	}

	[Export("processString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Process(string @string)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		IntPtr arg = NSString.CreateNative(@string);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selProcessString_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selProcessString_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("reset")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Reset()
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selResetHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selResetHandle);
		}
	}

	[Export("dominantLanguageForString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal static NSString? _GetDominantLanguage(IntPtr @string)
	{
		return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDominantLanguageForString_Handle, @string));
	}
}
