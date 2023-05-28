using System.ComponentModel;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace Foundation;

[Register("NSLinguisticTagger", true)]
public class NSLinguisticTagger : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableTagSchemesForLanguage_ = "availableTagSchemesForLanguage:";

	private static readonly IntPtr selAvailableTagSchemesForLanguage_Handle = Selector.GetHandle("availableTagSchemesForLanguage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableTagSchemesForUnit_Language_ = "availableTagSchemesForUnit:language:";

	private static readonly IntPtr selAvailableTagSchemesForUnit_Language_Handle = Selector.GetHandle("availableTagSchemesForUnit:language:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDominantLanguage = "dominantLanguage";

	private static readonly IntPtr selDominantLanguageHandle = Selector.GetHandle("dominantLanguage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDominantLanguageForString_ = "dominantLanguageForString:";

	private static readonly IntPtr selDominantLanguageForString_Handle = Selector.GetHandle("dominantLanguageForString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateTagsForString_Range_Unit_Scheme_Options_Orthography_UsingBlock_ = "enumerateTagsForString:range:unit:scheme:options:orthography:usingBlock:";

	private static readonly IntPtr selEnumerateTagsForString_Range_Unit_Scheme_Options_Orthography_UsingBlock_Handle = Selector.GetHandle("enumerateTagsForString:range:unit:scheme:options:orthography:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateTagsInRange_Scheme_Options_UsingBlock_ = "enumerateTagsInRange:scheme:options:usingBlock:";

	private static readonly IntPtr selEnumerateTagsInRange_Scheme_Options_UsingBlock_Handle = Selector.GetHandle("enumerateTagsInRange:scheme:options:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateTagsInRange_Unit_Scheme_Options_UsingBlock_ = "enumerateTagsInRange:unit:scheme:options:usingBlock:";

	private static readonly IntPtr selEnumerateTagsInRange_Unit_Scheme_Options_UsingBlock_Handle = Selector.GetHandle("enumerateTagsInRange:unit:scheme:options:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTagSchemes_Options_ = "initWithTagSchemes:options:";

	private static readonly IntPtr selInitWithTagSchemes_Options_Handle = Selector.GetHandle("initWithTagSchemes:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOrthographyAtIndex_EffectiveRange_ = "orthographyAtIndex:effectiveRange:";

	private static readonly IntPtr selOrthographyAtIndex_EffectiveRange_Handle = Selector.GetHandle("orthographyAtIndex:effectiveRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPossibleTagsAtIndex_Scheme_TokenRange_SentenceRange_Scores_ = "possibleTagsAtIndex:scheme:tokenRange:sentenceRange:scores:";

	private static readonly IntPtr selPossibleTagsAtIndex_Scheme_TokenRange_SentenceRange_Scores_Handle = Selector.GetHandle("possibleTagsAtIndex:scheme:tokenRange:sentenceRange:scores:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSentenceRangeForRange_ = "sentenceRangeForRange:";

	private static readonly IntPtr selSentenceRangeForRange_Handle = Selector.GetHandle("sentenceRangeForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetOrthography_Range_ = "setOrthography:range:";

	private static readonly IntPtr selSetOrthography_Range_Handle = Selector.GetHandle("setOrthography:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetString_ = "setString:";

	private static readonly IntPtr selSetString_Handle = Selector.GetHandle("setString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selString = "string";

	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringEditedInRange_ChangeInLength_ = "stringEditedInRange:changeInLength:";

	private static readonly IntPtr selStringEditedInRange_ChangeInLength_Handle = Selector.GetHandle("stringEditedInRange:changeInLength:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTagAtIndex_Scheme_TokenRange_SentenceRange_ = "tagAtIndex:scheme:tokenRange:sentenceRange:";

	private static readonly IntPtr selTagAtIndex_Scheme_TokenRange_SentenceRange_Handle = Selector.GetHandle("tagAtIndex:scheme:tokenRange:sentenceRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTagAtIndex_Unit_Scheme_TokenRange_ = "tagAtIndex:unit:scheme:tokenRange:";

	private static readonly IntPtr selTagAtIndex_Unit_Scheme_TokenRange_Handle = Selector.GetHandle("tagAtIndex:unit:scheme:tokenRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTagForString_AtIndex_Unit_Scheme_Orthography_TokenRange_ = "tagForString:atIndex:unit:scheme:orthography:tokenRange:";

	private static readonly IntPtr selTagForString_AtIndex_Unit_Scheme_Orthography_TokenRange_Handle = Selector.GetHandle("tagForString:atIndex:unit:scheme:orthography:tokenRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTagSchemes = "tagSchemes";

	private static readonly IntPtr selTagSchemesHandle = Selector.GetHandle("tagSchemes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTagsForString_Range_Unit_Scheme_Options_Orthography_TokenRanges_ = "tagsForString:range:unit:scheme:options:orthography:tokenRanges:";

	private static readonly IntPtr selTagsForString_Range_Unit_Scheme_Options_Orthography_TokenRanges_Handle = Selector.GetHandle("tagsForString:range:unit:scheme:options:orthography:tokenRanges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTagsInRange_Scheme_Options_TokenRanges_ = "tagsInRange:scheme:options:tokenRanges:";

	private static readonly IntPtr selTagsInRange_Scheme_Options_TokenRanges_Handle = Selector.GetHandle("tagsInRange:scheme:options:tokenRanges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTagsInRange_Unit_Scheme_Options_TokenRanges_ = "tagsInRange:unit:scheme:options:tokenRanges:";

	private static readonly IntPtr selTagsInRange_Unit_Scheme_Options_TokenRanges_Handle = Selector.GetHandle("tagsInRange:unit:scheme:options:tokenRanges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTokenRangeAtIndex_Unit_ = "tokenRangeAtIndex:unit:";

	private static readonly IntPtr selTokenRangeAtIndex_Unit_Handle = Selector.GetHandle("tokenRangeAtIndex:unit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSLinguisticTagger");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? AnalysisString
	{
		[Export("string", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringHandle));
		}
		[Export("setString:", ArgumentSemantic.Retain)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetString_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetString_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	public virtual string? DominantLanguage
	{
		[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
		[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
		[Export("dominantLanguage")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selDominantLanguageHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDominantLanguageHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString[] TagSchemes
	{
		[Export("tagSchemes")]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selTagSchemesHandle));
			}
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTagSchemesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSLinguisticTagger()
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
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NSLinguisticTagger(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSLinguisticTagger(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTagSchemes:options:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSLinguisticTagger(NSString[] tagSchemes, NSLinguisticTaggerOptions opts)
		: base(NSObjectFlag.Empty)
	{
		if (tagSchemes == null)
		{
			throw new ArgumentNullException("tagSchemes");
		}
		NSArray nSArray = NSArray.FromNSObjects(tagSchemes);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selInitWithTagSchemes_Options_Handle, nSArray.Handle, (ulong)opts), "initWithTagSchemes:options:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInitWithTagSchemes_Options_Handle, nSArray.Handle, (ulong)opts), "initWithTagSchemes:options:");
		}
		nSArray.Dispose();
	}

	[Export("enumerateTagsInRange:unit:scheme:options:usingBlock:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateTags(NSRange range, NSLinguisticTaggerUnit unit, string scheme, NSLinguisticTaggerOptions options, [BlockProxy(typeof(Trampolines.NIDLinguisticTagEnumerator))] LinguisticTagEnumerator enumerator)
	{
		if (scheme == null)
		{
			throw new ArgumentNullException("scheme");
		}
		if (enumerator == null)
		{
			throw new ArgumentNullException("enumerator");
		}
		IntPtr arg = NSString.CreateNative(scheme);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDLinguisticTagEnumerator.Handler, enumerator);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_Int64_IntPtr_UInt64_IntPtr(base.Handle, selEnumerateTagsInRange_Unit_Scheme_Options_UsingBlock_Handle, range, (long)unit, arg, (ulong)options, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_Int64_IntPtr_UInt64_IntPtr(base.SuperHandle, selEnumerateTagsInRange_Unit_Scheme_Options_UsingBlock_Handle, range, (long)unit, arg, (ulong)options, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[Export("enumerateTagsForString:range:unit:scheme:options:orthography:usingBlock:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void EnumerateTags(string str, NSRange range, NSLinguisticTaggerUnit unit, string scheme, NSLinguisticTaggerOptions options, NSOrthography? orthography, [BlockProxy(typeof(Trampolines.NIDLinguisticTagEnumerator))] LinguisticTagEnumerator enumerator)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (scheme == null)
		{
			throw new ArgumentNullException("scheme");
		}
		if (enumerator == null)
		{
			throw new ArgumentNullException("enumerator");
		}
		IntPtr arg = NSString.CreateNative(str);
		IntPtr arg2 = NSString.CreateNative(scheme);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDLinguisticTagEnumerator.Handler, enumerator);
		Messaging.void_objc_msgSend_IntPtr_NSRange_Int64_IntPtr_UInt64_IntPtr_IntPtr(class_ptr, selEnumerateTagsForString_Range_Unit_Scheme_Options_Orthography_UsingBlock_Handle, arg, range, (long)unit, arg2, (ulong)options, orthography?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		ptr->CleanupBlock();
	}

	[Export("enumerateTagsInRange:scheme:options:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateTagsInRange(NSRange range, NSString tagScheme, NSLinguisticTaggerOptions opts, [BlockProxy(typeof(Trampolines.NIDNSLingusticEnumerator))] NSLingusticEnumerator enumerator)
	{
		if (tagScheme == null)
		{
			throw new ArgumentNullException("tagScheme");
		}
		if (enumerator == null)
		{
			throw new ArgumentNullException("enumerator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSLingusticEnumerator.Handler, enumerator);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr_UInt64_IntPtr(base.Handle, selEnumerateTagsInRange_Scheme_Options_UsingBlock_Handle, range, tagScheme.Handle, (ulong)opts, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr_UInt64_IntPtr(base.SuperHandle, selEnumerateTagsInRange_Scheme_Options_UsingBlock_Handle, range, tagScheme.Handle, (ulong)opts, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("availableTagSchemesForUnit:language:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetAvailableTagSchemes(NSLinguisticTaggerUnit unit, string language)
	{
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		IntPtr arg = NSString.CreateNative(language);
		string[] result = NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_Int64_IntPtr(class_ptr, selAvailableTagSchemesForUnit_Language_Handle, (long)unit, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("availableTagSchemesForLanguage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString[] GetAvailableTagSchemesForLanguage(string language)
	{
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		IntPtr arg = NSString.CreateNative(language);
		NSString[] result = NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAvailableTagSchemesForLanguage_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("dominantLanguageForString:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string? GetDominantLanguage(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selDominantLanguageForString_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("orthographyAtIndex:effectiveRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSOrthography GetOrthography(nint charIndex, ref NSRange effectiveRange)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSOrthography>(Messaging.IntPtr_objc_msgSend_nint_ref_NSRange(base.Handle, selOrthographyAtIndex_EffectiveRange_Handle, charIndex, ref effectiveRange));
		}
		return Runtime.GetNSObject<NSOrthography>(Messaging.IntPtr_objc_msgSendSuper_nint_ref_NSRange(base.SuperHandle, selOrthographyAtIndex_EffectiveRange_Handle, charIndex, ref effectiveRange));
	}

	[Export("possibleTagsAtIndex:scheme:tokenRange:sentenceRange:scores:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSString[] GetPossibleTags(nint charIndex, NSString tagScheme, ref NSRange tokenRange, ref NSRange sentenceRange, ref NSArray scores)
	{
		if (tagScheme == null)
		{
			throw new ArgumentNullException("tagScheme");
		}
		IntPtr arg = ((scores == null) ? IntPtr.Zero : scores.Handle);
		NSString[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper_nint_IntPtr_ref_NSRange_ref_NSRange_ref_IntPtr(base.SuperHandle, selPossibleTagsAtIndex_Scheme_TokenRange_SentenceRange_Scores_Handle, charIndex, tagScheme.Handle, ref tokenRange, ref sentenceRange, ref arg)) : NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend_nint_IntPtr_ref_NSRange_ref_NSRange_ref_IntPtr(base.Handle, selPossibleTagsAtIndex_Scheme_TokenRange_SentenceRange_Scores_Handle, charIndex, tagScheme.Handle, ref tokenRange, ref sentenceRange, ref arg)));
		scores = Runtime.GetNSObject<NSArray>(arg);
		return result;
	}

	[Export("sentenceRangeForRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetSentenceRangeForRange(NSRange range)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_NSRange(base.Handle, selSentenceRangeForRange_Handle, range);
		}
		return Messaging.NSRange_objc_msgSendSuper_NSRange(base.SuperHandle, selSentenceRangeForRange_Handle, range);
	}

	[Export("tagAtIndex:scheme:tokenRange:sentenceRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetTag(nint charIndex, NSString tagScheme, ref NSRange tokenRange, ref NSRange sentenceRange)
	{
		if (tagScheme == null)
		{
			throw new ArgumentNullException("tagScheme");
		}
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend_nint_IntPtr_ref_NSRange_ref_NSRange(base.Handle, selTagAtIndex_Scheme_TokenRange_SentenceRange_Handle, charIndex, tagScheme.Handle, ref tokenRange, ref sentenceRange));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_nint_IntPtr_ref_NSRange_ref_NSRange(base.SuperHandle, selTagAtIndex_Scheme_TokenRange_SentenceRange_Handle, charIndex, tagScheme.Handle, ref tokenRange, ref sentenceRange));
	}

	[Export("tagAtIndex:unit:scheme:tokenRange:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? GetTag(nuint charIndex, NSLinguisticTaggerUnit unit, string scheme, ref NSRange tokenRange)
	{
		if (scheme == null)
		{
			throw new ArgumentNullException("scheme");
		}
		IntPtr arg = NSString.CreateNative(scheme);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_nuint_Int64_IntPtr_ref_NSRange(base.SuperHandle, selTagAtIndex_Unit_Scheme_TokenRange_Handle, charIndex, (long)unit, arg, ref tokenRange)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_nuint_Int64_IntPtr_ref_NSRange(base.Handle, selTagAtIndex_Unit_Scheme_TokenRange_Handle, charIndex, (long)unit, arg, ref tokenRange)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("tagForString:atIndex:unit:scheme:orthography:tokenRange:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string? GetTag(string str, nuint charIndex, NSLinguisticTaggerUnit unit, string scheme, NSOrthography? orthography, ref NSRange tokenRange)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (scheme == null)
		{
			throw new ArgumentNullException("scheme");
		}
		IntPtr arg = NSString.CreateNative(str);
		IntPtr arg2 = NSString.CreateNative(scheme);
		string result = NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_nuint_Int64_IntPtr_IntPtr_ref_NSRange(class_ptr, selTagForString_AtIndex_Unit_Scheme_Orthography_TokenRange_Handle, arg, charIndex, (long)unit, arg2, orthography?.Handle ?? IntPtr.Zero, ref tokenRange));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("tagsInRange:unit:scheme:options:tokenRanges:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GetTags(NSRange range, NSLinguisticTaggerUnit unit, string scheme, NSLinguisticTaggerOptions options, out NSValue[]? tokenRanges)
	{
		if (scheme == null)
		{
			throw new ArgumentNullException("scheme");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(scheme);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_NSRange_Int64_IntPtr_UInt64_ref_IntPtr(base.SuperHandle, selTagsInRange_Unit_Scheme_Options_TokenRanges_Handle, range, (long)unit, arg2, (ulong)options, ref arg)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_NSRange_Int64_IntPtr_UInt64_ref_IntPtr(base.Handle, selTagsInRange_Unit_Scheme_Options_TokenRanges_Handle, range, (long)unit, arg2, (ulong)options, ref arg)));
		NSString.ReleaseNative(arg2);
		tokenRanges = NSArray.ArrayFromHandle<NSValue>(arg);
		return result;
	}

	[Export("tagsForString:range:unit:scheme:options:orthography:tokenRanges:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static string[] GetTags(string str, NSRange range, NSLinguisticTaggerUnit unit, string scheme, NSLinguisticTaggerOptions options, NSOrthography? orthography, out NSValue[]? tokenRanges)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (scheme == null)
		{
			throw new ArgumentNullException("scheme");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(str);
		IntPtr arg3 = NSString.CreateNative(scheme);
		string[] result = NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_NSRange_Int64_IntPtr_UInt64_IntPtr_ref_IntPtr(class_ptr, selTagsForString_Range_Unit_Scheme_Options_Orthography_TokenRanges_Handle, arg2, range, (long)unit, arg3, (ulong)options, orthography?.Handle ?? IntPtr.Zero, ref arg));
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		tokenRanges = NSArray.ArrayFromHandle<NSValue>(arg);
		return result;
	}

	[Export("tagsInRange:scheme:options:tokenRanges:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSString[] GetTagsInRange(NSRange range, NSString tagScheme, NSLinguisticTaggerOptions opts, ref NSArray tokenRanges)
	{
		if (tagScheme == null)
		{
			throw new ArgumentNullException("tagScheme");
		}
		IntPtr arg = ((tokenRanges == null) ? IntPtr.Zero : tokenRanges.Handle);
		NSString[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr_UInt64_ref_IntPtr(base.SuperHandle, selTagsInRange_Scheme_Options_TokenRanges_Handle, range, tagScheme.Handle, (ulong)opts, ref arg)) : NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr_UInt64_ref_IntPtr(base.Handle, selTagsInRange_Scheme_Options_TokenRanges_Handle, range, tagScheme.Handle, (ulong)opts, ref arg)));
		tokenRanges = Runtime.GetNSObject<NSArray>(arg);
		return result;
	}

	[Export("tokenRangeAtIndex:unit:")]
	[Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetTokenRange(nuint charIndex, NSLinguisticTaggerUnit unit)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nuint_Int64(base.Handle, selTokenRangeAtIndex_Unit_Handle, charIndex, (long)unit);
		}
		return Messaging.NSRange_objc_msgSendSuper_nuint_Int64(base.SuperHandle, selTokenRangeAtIndex_Unit_Handle, charIndex, (long)unit);
	}

	[Export("setOrthography:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetOrthographyrange(NSOrthography orthography, NSRange range)
	{
		if (orthography == null)
		{
			throw new ArgumentNullException("orthography");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selSetOrthography_Range_Handle, orthography.Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSetOrthography_Range_Handle, orthography.Handle, range);
		}
	}

	[Export("stringEditedInRange:changeInLength:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void StringEditedInRange(NSRange newRange, nint delta)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_nint(base.Handle, selStringEditedInRange_ChangeInLength_Handle, newRange, delta);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_nint(base.SuperHandle, selStringEditedInRange_ChangeInLength_Handle, newRange, delta);
		}
	}
}
