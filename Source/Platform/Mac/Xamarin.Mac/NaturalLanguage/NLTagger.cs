using System;
using System.ComponentModel;
using System.Threading.Tasks;
using Foundation;
using ObjCRuntime;

namespace NaturalLanguage;

[Register("NLTagger", true)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class NLTagger : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableTagSchemesForUnit_Language_ = "availableTagSchemesForUnit:language:";

	private static readonly IntPtr selAvailableTagSchemesForUnit_Language_Handle = Selector.GetHandle("availableTagSchemesForUnit:language:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDominantLanguage = "dominantLanguage";

	private static readonly IntPtr selDominantLanguageHandle = Selector.GetHandle("dominantLanguage");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateTagsInRange_Unit_Scheme_Options_UsingBlock_ = "enumerateTagsInRange:unit:scheme:options:usingBlock:";

	private static readonly IntPtr selEnumerateTagsInRange_Unit_Scheme_Options_UsingBlock_Handle = Selector.GetHandle("enumerateTagsInRange:unit:scheme:options:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGazetteersForTagScheme_ = "gazetteersForTagScheme:";

	private static readonly IntPtr selGazetteersForTagScheme_Handle = Selector.GetHandle("gazetteersForTagScheme:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithTagSchemes_ = "initWithTagSchemes:";

	private static readonly IntPtr selInitWithTagSchemes_Handle = Selector.GetHandle("initWithTagSchemes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selModelsForTagScheme_ = "modelsForTagScheme:";

	private static readonly IntPtr selModelsForTagScheme_Handle = Selector.GetHandle("modelsForTagScheme:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestAssetsForLanguage_TagScheme_CompletionHandler_ = "requestAssetsForLanguage:tagScheme:completionHandler:";

	private static readonly IntPtr selRequestAssetsForLanguage_TagScheme_CompletionHandler_Handle = Selector.GetHandle("requestAssetsForLanguage:tagScheme:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetGazetteers_ForTagScheme_ = "setGazetteers:forTagScheme:";

	private static readonly IntPtr selSetGazetteers_ForTagScheme_Handle = Selector.GetHandle("setGazetteers:forTagScheme:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLanguage_Range_ = "setLanguage:range:";

	private static readonly IntPtr selSetLanguage_Range_Handle = Selector.GetHandle("setLanguage:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetModels_ForTagScheme_ = "setModels:forTagScheme:";

	private static readonly IntPtr selSetModels_ForTagScheme_Handle = Selector.GetHandle("setModels:forTagScheme:");

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
	private const string selTagAtIndex_Unit_Scheme_TokenRange_ = "tagAtIndex:unit:scheme:tokenRange:";

	private static readonly IntPtr selTagAtIndex_Unit_Scheme_TokenRange_Handle = Selector.GetHandle("tagAtIndex:unit:scheme:tokenRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTagSchemes = "tagSchemes";

	private static readonly IntPtr selTagSchemesHandle = Selector.GetHandle("tagSchemes");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTagsInRange_Unit_Scheme_Options_TokenRanges_ = "tagsInRange:unit:scheme:options:tokenRanges:";

	private static readonly IntPtr selTagsInRange_Unit_Scheme_Options_TokenRanges_Handle = Selector.GetHandle("tagsInRange:unit:scheme:options:tokenRanges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTokenRangeAtIndex_Unit_ = "tokenRangeAtIndex:unit:";

	private static readonly IntPtr selTokenRangeAtIndex_Unit_Handle = Selector.GetHandle("tokenRangeAtIndex:unit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NLTagger");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NLLanguage DominantLanguage => NLLanguageExtensions.GetValue(_DominantLanguage);

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? String
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
	public NLTagScheme[] TagSchemes => Array.ConvertAll(_TagSchemes, (NSString e) => NLTagSchemeExtensions.GetValue(e));

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
	internal virtual NSString[] _TagSchemes
	{
		[Export("tagSchemes", ArgumentSemantic.Copy)]
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
	protected NLTagger(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NLTagger(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithTagSchemes:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NLTagger(params NSString[] tagSchemes)
		: base(NSObjectFlag.Empty)
	{
		if (tagSchemes == null)
		{
			throw new ArgumentNullException("tagSchemes");
		}
		NSArray nSArray = NSArray.FromNSObjects(tagSchemes);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithTagSchemes_Handle, nSArray.Handle), "initWithTagSchemes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithTagSchemes_Handle, nSArray.Handle), "initWithTagSchemes:");
		}
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NLTagger(params NLTagScheme[] tagSchemes)
		: this(Array.ConvertAll(tagSchemes, (NLTagScheme e) => e.GetConstant()))
	{
	}

	[Export("enumerateTagsInRange:unit:scheme:options:usingBlock:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateTags(NSRange range, NLTokenUnit unit, NSString scheme, NLTaggerOptions options, [BlockProxy(typeof(Trampolines.NIDNLTaggerEnumerateTagsContinuationHandler))] NLTaggerEnumerateTagsContinuationHandler handler)
	{
		if (scheme == null)
		{
			throw new ArgumentNullException("scheme");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNLTaggerEnumerateTagsContinuationHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_Int64_IntPtr_UInt64_IntPtr(base.Handle, selEnumerateTagsInRange_Unit_Scheme_Options_UsingBlock_Handle, range, (long)unit, scheme.Handle, (ulong)options, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_Int64_IntPtr_UInt64_IntPtr(base.SuperHandle, selEnumerateTagsInRange_Unit_Scheme_Options_UsingBlock_Handle, range, (long)unit, scheme.Handle, (ulong)options, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void EnumerateTags(NSRange range, NLTokenUnit unit, NLTagScheme scheme, NLTaggerOptions options, [BlockProxy(typeof(Trampolines.NIDNLTaggerEnumerateTagsContinuationHandler))] NLTaggerEnumerateTagsContinuationHandler handler)
	{
		EnumerateTags(range, unit, scheme.GetConstant(), options, handler);
	}

	[Export("availableTagSchemesForUnit:language:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString[] GetAvailableTagSchemes(NLTokenUnit unit, NSString language)
	{
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend_Int64_IntPtr(class_ptr, selAvailableTagSchemesForUnit_Language_Handle, (long)unit, language.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NLTagScheme[] GetAvailableTagSchemes(NLTokenUnit unit, NLLanguage language)
	{
		return Array.ConvertAll(GetAvailableTagSchemes(unit, language.GetConstant()), (NSString e) => NLTagSchemeExtensions.GetValue(e));
	}

	[Export("gazetteersForTagScheme:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NLGazetteer[] GetGazetteers(NSString tagScheme)
	{
		if (tagScheme == null)
		{
			throw new ArgumentNullException("tagScheme");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NLGazetteer>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selGazetteersForTagScheme_Handle, tagScheme.Handle));
		}
		return NSArray.ArrayFromHandle<NLGazetteer>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selGazetteersForTagScheme_Handle, tagScheme.Handle));
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NLGazetteer[] GetGazetteers(NLTagScheme tagScheme)
	{
		return GetGazetteers(tagScheme.GetConstant());
	}

	[Export("modelsForTagScheme:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NLModel[] GetModels(NSString tagScheme)
	{
		if (tagScheme == null)
		{
			throw new ArgumentNullException("tagScheme");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NLModel>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selModelsForTagScheme_Handle, tagScheme.Handle));
		}
		return NSArray.ArrayFromHandle<NLModel>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selModelsForTagScheme_Handle, tagScheme.Handle));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NLModel[] GetModels(NLTagScheme tagScheme)
	{
		return GetModels(tagScheme.GetConstant());
	}

	[Export("tagAtIndex:unit:scheme:tokenRange:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString? GetTag(nuint characterIndex, NLTokenUnit unit, NSString scheme, out NSRange tokenRange)
	{
		if (scheme == null)
		{
			throw new ArgumentNullException("scheme");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_nuint_Int64_IntPtr_out_NSRange(base.Handle, selTagAtIndex_Unit_Scheme_TokenRange_Handle, characterIndex, (long)unit, scheme.Handle, out tokenRange));
		}
		return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper_nuint_Int64_IntPtr_out_NSRange(base.SuperHandle, selTagAtIndex_Unit_Scheme_TokenRange_Handle, characterIndex, (long)unit, scheme.Handle, out tokenRange));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSString? GetTag(nuint characterIndex, NLTokenUnit unit, NLTagScheme scheme, out NSRange tokenRange)
	{
		return GetTag(characterIndex, unit, scheme.GetConstant(), out tokenRange);
	}

	[Export("tagsInRange:unit:scheme:options:tokenRanges:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString[] GetTags(NSRange range, NLTokenUnit unit, NSString scheme, NLTaggerOptions options, out NSValue[]? tokenRanges)
	{
		if (scheme == null)
		{
			throw new ArgumentNullException("scheme");
		}
		IntPtr arg = IntPtr.Zero;
		NSString[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper_NSRange_Int64_IntPtr_UInt64_ref_IntPtr(base.SuperHandle, selTagsInRange_Unit_Scheme_Options_TokenRanges_Handle, range, (long)unit, scheme.Handle, (ulong)options, ref arg)) : NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend_NSRange_Int64_IntPtr_UInt64_ref_IntPtr(base.Handle, selTagsInRange_Unit_Scheme_Options_TokenRanges_Handle, range, (long)unit, scheme.Handle, (ulong)options, ref arg)));
		tokenRanges = NSArray.ArrayFromHandle<NSValue>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSString[] GetTags(NSRange range, NLTokenUnit unit, NLTagScheme scheme, NLTaggerOptions options, out NSValue[]? tokenRanges)
	{
		return GetTags(range, unit, scheme.GetConstant(), options, out tokenRanges);
	}

	[Export("tokenRangeAtIndex:unit:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetTokenRange(nuint characterIndex, NSString unit)
	{
		if (unit == null)
		{
			throw new ArgumentNullException("unit");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nuint_IntPtr(base.Handle, selTokenRangeAtIndex_Unit_Handle, characterIndex, unit.Handle);
		}
		return Messaging.NSRange_objc_msgSendSuper_nuint_IntPtr(base.SuperHandle, selTokenRangeAtIndex_Unit_Handle, characterIndex, unit.Handle);
	}

	[Export("requestAssetsForLanguage:tagScheme:completionHandler:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void RequestAssets(NSString language, NSString tagScheme, [BlockProxy(typeof(Trampolines.NIDActionArity2V72))] Action<NLTaggerAssetsResult, NSError> completionHandler)
	{
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		if (tagScheme == null)
		{
			throw new ArgumentNullException("tagScheme");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V72.Handler, completionHandler);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selRequestAssetsForLanguage_TagScheme_CompletionHandler_Handle, language.Handle, tagScheme.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NLTaggerAssetsResult> RequestAssetsAsync(NSString language, NSString tagScheme)
	{
		TaskCompletionSource<NLTaggerAssetsResult> tcs = new TaskCompletionSource<NLTaggerAssetsResult>();
		RequestAssets(language, tagScheme, delegate(NLTaggerAssetsResult arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void RequestAssets(NLLanguage language, NLTagScheme tagScheme, [BlockProxy(typeof(Trampolines.NIDActionArity2V72))] Action<NLTaggerAssetsResult, NSError> completionHandler)
	{
		RequestAssets(language.GetConstant(), tagScheme.GetConstant(), completionHandler);
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NLTaggerAssetsResult> RequestAssetsAsync(NLLanguage language, NLTagScheme tagScheme)
	{
		TaskCompletionSource<NLTaggerAssetsResult> tcs = new TaskCompletionSource<NLTaggerAssetsResult>();
		RequestAssets(language, tagScheme, delegate(NLTaggerAssetsResult arg1_, NSError arg2_)
		{
			if (arg2_ != null)
			{
				tcs.SetException(new NSErrorException(arg2_));
			}
			else
			{
				tcs.SetResult(arg1_);
			}
		});
		return tcs.Task;
	}

	[Export("setGazetteers:forTagScheme:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetGazetteers(NLGazetteer[] gazetteers, NSString tagScheme)
	{
		if (gazetteers == null)
		{
			throw new ArgumentNullException("gazetteers");
		}
		if (tagScheme == null)
		{
			throw new ArgumentNullException("tagScheme");
		}
		NSArray nSArray = NSArray.FromNSObjects(gazetteers);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetGazetteers_ForTagScheme_Handle, nSArray.Handle, tagScheme.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetGazetteers_ForTagScheme_Handle, nSArray.Handle, tagScheme.Handle);
		}
		nSArray.Dispose();
	}

	[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetGazetteers(NLGazetteer[] gazetteers, NLTagScheme tagScheme)
	{
		SetGazetteers(gazetteers, tagScheme.GetConstant());
	}

	[Export("setLanguage:range:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetLanguage(NSString language, NSRange range)
	{
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selSetLanguage_Range_Handle, language.Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSetLanguage_Range_Handle, language.Handle, range);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetLanguage(NLLanguage language, NSRange range)
	{
		SetLanguage(language.GetConstant(), range);
	}

	[Export("setModels:forTagScheme:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetModels(NLModel[] models, NSString tagScheme)
	{
		if (models == null)
		{
			throw new ArgumentNullException("models");
		}
		if (tagScheme == null)
		{
			throw new ArgumentNullException("tagScheme");
		}
		NSArray nSArray = NSArray.FromNSObjects(models);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selSetModels_ForTagScheme_Handle, nSArray.Handle, tagScheme.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selSetModels_ForTagScheme_Handle, nSArray.Handle, tagScheme.Handle);
		}
		nSArray.Dispose();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetModels(NLModel[] models, NLTagScheme tagScheme)
	{
		SetModels(models, tagScheme.GetConstant());
	}

	[Export("setOrthography:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetOrthography(NSOrthography orthography, NSRange range)
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
}
