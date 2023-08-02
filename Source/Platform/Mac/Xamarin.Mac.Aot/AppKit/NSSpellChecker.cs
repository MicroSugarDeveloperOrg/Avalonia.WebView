using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSpellChecker", true)]
public class NSSpellChecker : NSObject
{
	private static readonly IntPtr selSharedSpellCheckerHandle = Selector.GetHandle("sharedSpellChecker");

	private static readonly IntPtr selSharedSpellCheckerExistsHandle = Selector.GetHandle("sharedSpellCheckerExists");

	private static readonly IntPtr selUniqueSpellDocumentTagHandle = Selector.GetHandle("uniqueSpellDocumentTag");

	private static readonly IntPtr selUserReplacementsDictionaryHandle = Selector.GetHandle("userReplacementsDictionary");

	private static readonly IntPtr selSpellingPanelHandle = Selector.GetHandle("spellingPanel");

	private static readonly IntPtr selSubstitutionsPanelHandle = Selector.GetHandle("substitutionsPanel");

	private static readonly IntPtr selAvailableLanguagesHandle = Selector.GetHandle("availableLanguages");

	private static readonly IntPtr selUserPreferredLanguagesHandle = Selector.GetHandle("userPreferredLanguages");

	private static readonly IntPtr selAccessoryViewHandle = Selector.GetHandle("accessoryView");

	private static readonly IntPtr selSetAccessoryView_Handle = Selector.GetHandle("setAccessoryView:");

	private static readonly IntPtr selSubstitutionsPanelAccessoryViewControllerHandle = Selector.GetHandle("substitutionsPanelAccessoryViewController");

	private static readonly IntPtr selSetSubstitutionsPanelAccessoryViewController_Handle = Selector.GetHandle("setSubstitutionsPanelAccessoryViewController:");

	private static readonly IntPtr selAutomaticallyIdentifiesLanguagesHandle = Selector.GetHandle("automaticallyIdentifiesLanguages");

	private static readonly IntPtr selSetAutomaticallyIdentifiesLanguages_Handle = Selector.GetHandle("setAutomaticallyIdentifiesLanguages:");

	private static readonly IntPtr selCheckSpellingOfStringStartingAtLanguageWrapInSpellDocumentWithTagWordCount_Handle = Selector.GetHandle("checkSpellingOfString:startingAt:language:wrap:inSpellDocumentWithTag:wordCount:");

	private static readonly IntPtr selCheckSpellingOfStringStartingAt_Handle = Selector.GetHandle("checkSpellingOfString:startingAt:");

	private static readonly IntPtr selCountWordsInStringLanguage_Handle = Selector.GetHandle("countWordsInString:language:");

	private static readonly IntPtr selCheckGrammarOfStringStartingAtLanguageWrapInSpellDocumentWithTagDetails_Handle = Selector.GetHandle("checkGrammarOfString:startingAt:language:wrap:inSpellDocumentWithTag:details:");

	private static readonly IntPtr selCheckStringRangeTypesOptionsInSpellDocumentWithTagOrthographyWordCount_Handle = Selector.GetHandle("checkString:range:types:options:inSpellDocumentWithTag:orthography:wordCount:");

	private static readonly IntPtr selMenuForResultStringOptionsAtLocationInView_Handle = Selector.GetHandle("menuForResult:string:options:atLocation:inView:");

	private static readonly IntPtr selUserQuotesArrayForLanguage_Handle = Selector.GetHandle("userQuotesArrayForLanguage:");

	private static readonly IntPtr selUpdateSpellingPanelWithMisspelledWord_Handle = Selector.GetHandle("updateSpellingPanelWithMisspelledWord:");

	private static readonly IntPtr selUpdateSpellingPanelWithGrammarStringDetail_Handle = Selector.GetHandle("updateSpellingPanelWithGrammarString:detail:");

	private static readonly IntPtr selUpdatePanelsHandle = Selector.GetHandle("updatePanels");

	private static readonly IntPtr selIgnoreWordInSpellDocumentWithTag_Handle = Selector.GetHandle("ignoreWord:inSpellDocumentWithTag:");

	private static readonly IntPtr selIgnoredWordsInSpellDocumentWithTag_Handle = Selector.GetHandle("ignoredWordsInSpellDocumentWithTag:");

	private static readonly IntPtr selSetIgnoredWordsInSpellDocumentWithTag_Handle = Selector.GetHandle("setIgnoredWords:inSpellDocumentWithTag:");

	private static readonly IntPtr selGuessesForWordRangeInStringLanguageInSpellDocumentWithTag_Handle = Selector.GetHandle("guessesForWordRange:inString:language:inSpellDocumentWithTag:");

	private static readonly IntPtr selCompletionsForPartialWordRangeInStringLanguageInSpellDocumentWithTag_Handle = Selector.GetHandle("completionsForPartialWordRange:inString:language:inSpellDocumentWithTag:");

	private static readonly IntPtr selCloseSpellDocumentWithTag_Handle = Selector.GetHandle("closeSpellDocumentWithTag:");

	private static readonly IntPtr selSetWordFieldStringValue_Handle = Selector.GetHandle("setWordFieldStringValue:");

	private static readonly IntPtr selLearnWord_Handle = Selector.GetHandle("learnWord:");

	private static readonly IntPtr selHasLearnedWord_Handle = Selector.GetHandle("hasLearnedWord:");

	private static readonly IntPtr selUnlearnWord_Handle = Selector.GetHandle("unlearnWord:");

	private static readonly IntPtr selLanguageHandle = Selector.GetHandle("language");

	private static readonly IntPtr selSetLanguage_Handle = Selector.GetHandle("setLanguage:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSSpellChecker");

	private static object __mt_SharedSpellChecker_var_static;

	private object __mt_UserReplacementsDictionary_var;

	private object __mt_SpellingPanel_var;

	private object __mt_SubstitutionsPanel_var;

	private object __mt_AccessoryView_var;

	private object __mt_SubstitutionsPanelAccessoryViewController_var;

	public string Language
	{
		get
		{
			return GetLanguage();
		}
		set
		{
			SetLanguage(value);
		}
	}

	public override IntPtr ClassHandle => class_ptr;

	public static NSSpellChecker SharedSpellChecker
	{
		[Export("sharedSpellChecker")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSSpellChecker)(__mt_SharedSpellChecker_var_static = (NSSpellChecker)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedSpellCheckerHandle)));
		}
	}

	public static bool SharedSpellCheckerExists
	{
		[Export("sharedSpellCheckerExists")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selSharedSpellCheckerExistsHandle);
		}
	}

	public static long UniqueSpellDocumentTag
	{
		[Export("uniqueSpellDocumentTag")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.Int64_objc_msgSend(class_ptr, selUniqueSpellDocumentTagHandle);
		}
	}

	public virtual NSDictionary UserReplacementsDictionary
	{
		[Export("userReplacementsDictionary")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSDictionary)(__mt_UserReplacementsDictionary_var = ((!IsDirectBinding) ? ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserReplacementsDictionaryHandle))) : ((NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selUserReplacementsDictionaryHandle)))));
		}
	}

	public virtual NSPanel SpellingPanel
	{
		[Export("spellingPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPanel)(__mt_SpellingPanel_var = ((!IsDirectBinding) ? ((NSPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSpellingPanelHandle))) : ((NSPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSpellingPanelHandle)))));
		}
	}

	public virtual NSPanel SubstitutionsPanel
	{
		[Export("substitutionsPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSPanel)(__mt_SubstitutionsPanel_var = ((!IsDirectBinding) ? ((NSPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubstitutionsPanelHandle))) : ((NSPanel)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSubstitutionsPanelHandle)))));
		}
	}

	public virtual string[] AvailableLanguages
	{
		[Export("availableLanguages")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableLanguagesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableLanguagesHandle));
		}
	}

	public virtual string[] UserPreferredLanguages
	{
		[Export("userPreferredLanguages")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUserPreferredLanguagesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserPreferredLanguagesHandle));
		}
	}

	public virtual NSView AccessoryView
	{
		[Export("accessoryView")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSView)(__mt_AccessoryView_var = ((!IsDirectBinding) ? ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessoryViewHandle))) : ((NSView)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessoryViewHandle)))));
		}
		[Export("setAccessoryView:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			__mt_AccessoryView_var = value;
		}
	}

	public virtual NSViewController SubstitutionsPanelAccessoryViewController
	{
		[Export("substitutionsPanelAccessoryViewController")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSViewController)(__mt_SubstitutionsPanelAccessoryViewController_var = ((!IsDirectBinding) ? ((NSViewController)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubstitutionsPanelAccessoryViewControllerHandle))) : ((NSViewController)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selSubstitutionsPanelAccessoryViewControllerHandle)))));
		}
		[Export("setSubstitutionsPanelAccessoryViewController:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubstitutionsPanelAccessoryViewController_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubstitutionsPanelAccessoryViewController_Handle, value.Handle);
			}
			__mt_SubstitutionsPanelAccessoryViewController_var = value;
		}
	}

	public virtual bool AutomaticallyIdentifiesLanguages
	{
		[Export("automaticallyIdentifiesLanguages")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticallyIdentifiesLanguagesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticallyIdentifiesLanguagesHandle);
		}
		[Export("setAutomaticallyIdentifiesLanguages:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticallyIdentifiesLanguages_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticallyIdentifiesLanguages_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSpellChecker()
		: base(NSObjectFlag.Empty)
	{
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend(base.Handle, Selector.Init);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, Selector.Init);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("initWithCoder:")]
	public NSSpellChecker(NSCoder coder)
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
	public NSSpellChecker(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSSpellChecker(IntPtr handle)
		: base(handle)
	{
	}

	[Export("checkSpellingOfString:startingAt:language:wrap:inSpellDocumentWithTag:wordCount:")]
	public virtual NSRange CheckSpelling(string stringToCheck, long startingOffset, string language, bool wrapFlag, long documentTag, out long wordCount)
	{
		NSApplication.EnsureUIThread();
		if (stringToCheck == null)
		{
			throw new ArgumentNullException("stringToCheck");
		}
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		IntPtr arg = NSString.CreateNative(stringToCheck);
		IntPtr arg2 = NSString.CreateNative(language);
		NSRange result = ((!IsDirectBinding) ? Messaging.NSRange_objc_msgSendSuper_IntPtr_Int64_IntPtr_bool_Int64_out_Int64(base.SuperHandle, selCheckSpellingOfStringStartingAtLanguageWrapInSpellDocumentWithTagWordCount_Handle, arg, startingOffset, arg2, wrapFlag, documentTag, out wordCount) : Messaging.NSRange_objc_msgSend_IntPtr_Int64_IntPtr_bool_Int64_out_Int64(base.Handle, selCheckSpellingOfStringStartingAtLanguageWrapInSpellDocumentWithTagWordCount_Handle, arg, startingOffset, arg2, wrapFlag, documentTag, out wordCount));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("checkSpellingOfString:startingAt:")]
	public virtual NSRange CheckSpelling(string stringToCheck, long startingOffset)
	{
		NSApplication.EnsureUIThread();
		if (stringToCheck == null)
		{
			throw new ArgumentNullException("stringToCheck");
		}
		IntPtr arg = NSString.CreateNative(stringToCheck);
		NSRange result = ((!IsDirectBinding) ? Messaging.NSRange_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selCheckSpellingOfStringStartingAt_Handle, arg, startingOffset) : Messaging.NSRange_objc_msgSend_IntPtr_Int64(base.Handle, selCheckSpellingOfStringStartingAt_Handle, arg, startingOffset));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("countWordsInString:language:")]
	public virtual long CountWords(string stringToCount, string language)
	{
		NSApplication.EnsureUIThread();
		if (stringToCount == null)
		{
			throw new ArgumentNullException("stringToCount");
		}
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		IntPtr arg = NSString.CreateNative(stringToCount);
		IntPtr arg2 = NSString.CreateNative(language);
		long result = ((!IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCountWordsInStringLanguage_Handle, arg, arg2) : Messaging.Int64_objc_msgSend_IntPtr_IntPtr(base.Handle, selCountWordsInStringLanguage_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("checkGrammarOfString:startingAt:language:wrap:inSpellDocumentWithTag:details:")]
	public virtual NSRange CheckGrammar(string stringToCheck, int startingOffset, string language, bool wrapFlag, long documentTag, NSDictionary[] details)
	{
		NSApplication.EnsureUIThread();
		if (stringToCheck == null)
		{
			throw new ArgumentNullException("stringToCheck");
		}
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		if (details == null)
		{
			throw new ArgumentNullException("details");
		}
		IntPtr arg = NSString.CreateNative(stringToCheck);
		IntPtr arg2 = NSString.CreateNative(language);
		NSArray nSArray = NSArray.FromNSObjects(details);
		NSRange result = ((!IsDirectBinding) ? Messaging.NSRange_objc_msgSendSuper_IntPtr_int_IntPtr_bool_Int64_IntPtr(base.SuperHandle, selCheckGrammarOfStringStartingAtLanguageWrapInSpellDocumentWithTagDetails_Handle, arg, startingOffset, arg2, wrapFlag, documentTag, nSArray.Handle) : Messaging.NSRange_objc_msgSend_IntPtr_int_IntPtr_bool_Int64_IntPtr(base.Handle, selCheckGrammarOfStringStartingAtLanguageWrapInSpellDocumentWithTagDetails_Handle, arg, startingOffset, arg2, wrapFlag, documentTag, nSArray.Handle));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		nSArray.Dispose();
		return result;
	}

	[Export("checkString:range:types:options:inSpellDocumentWithTag:orthography:wordCount:")]
	public virtual NSTextCheckingResult[] CheckString(string stringToCheck, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary options, long tag, out NSOrthography orthography, out long wordCount)
	{
		NSApplication.EnsureUIThread();
		if (stringToCheck == null)
		{
			throw new ArgumentNullException("stringToCheck");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr arg = NSString.CreateNative(stringToCheck);
		NSTextCheckingResult[] result = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_NSRange_UInt64_IntPtr_Int64_IntPtr_out_Int64(base.SuperHandle, selCheckStringRangeTypesOptionsInSpellDocumentWithTagOrthographyWordCount_Handle, arg, range, (ulong)checkingTypes, options.Handle, tag, intPtr, out wordCount)) : NSArray.ArrayFromHandle<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr_Int64_IntPtr_out_Int64(base.Handle, selCheckStringRangeTypesOptionsInSpellDocumentWithTagOrthographyWordCount_Handle, arg, range, (ulong)checkingTypes, options.Handle, tag, intPtr, out wordCount)));
		NSString.ReleaseNative(arg);
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		orthography = ((intPtr2 != IntPtr.Zero) ? ((NSOrthography)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[Export("menuForResult:string:options:atLocation:inView:")]
	public virtual NSMenu MenuForResults(NSTextCheckingResult result, string checkedString, NSDictionary options, CGPoint location, NSView view)
	{
		NSApplication.EnsureUIThread();
		if (result == null)
		{
			throw new ArgumentNullException("result");
		}
		if (checkedString == null)
		{
			throw new ArgumentNullException("checkedString");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		IntPtr arg = NSString.CreateNative(checkedString);
		NSMenu result2 = ((!IsDirectBinding) ? ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_CGPoint_IntPtr(base.SuperHandle, selMenuForResultStringOptionsAtLocationInView_Handle, result.Handle, arg, options.Handle, location, view.Handle))) : ((NSMenu)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_CGPoint_IntPtr(base.Handle, selMenuForResultStringOptionsAtLocationInView_Handle, result.Handle, arg, options.Handle, location, view.Handle))));
		NSString.ReleaseNative(arg);
		return result2;
	}

	[Export("userQuotesArrayForLanguage:")]
	public virtual string[] UserQuotesArrayForLanguage(string language)
	{
		NSApplication.EnsureUIThread();
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		IntPtr arg = NSString.CreateNative(language);
		string[] result = ((!IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selUserQuotesArrayForLanguage_Handle, arg)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selUserQuotesArrayForLanguage_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("updateSpellingPanelWithMisspelledWord:")]
	public virtual void UpdateSpellingPanelWithMisspelledWord(string word)
	{
		NSApplication.EnsureUIThread();
		if (word == null)
		{
			throw new ArgumentNullException("word");
		}
		IntPtr arg = NSString.CreateNative(word);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUpdateSpellingPanelWithMisspelledWord_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUpdateSpellingPanelWithMisspelledWord_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("updateSpellingPanelWithGrammarString:detail:")]
	public virtual void UpdateSpellingPanelWithGrammarl(string theString, NSDictionary detail)
	{
		NSApplication.EnsureUIThread();
		if (theString == null)
		{
			throw new ArgumentNullException("theString");
		}
		if (detail == null)
		{
			throw new ArgumentNullException("detail");
		}
		IntPtr arg = NSString.CreateNative(theString);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selUpdateSpellingPanelWithGrammarStringDetail_Handle, arg, detail.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selUpdateSpellingPanelWithGrammarStringDetail_Handle, arg, detail.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("updatePanels")]
	public virtual void UpdatePanels()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdatePanelsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdatePanelsHandle);
		}
	}

	[Export("ignoreWord:inSpellDocumentWithTag:")]
	public virtual void IgnoreWord(string wordToIgnore, long documentTag)
	{
		NSApplication.EnsureUIThread();
		if (wordToIgnore == null)
		{
			throw new ArgumentNullException("wordToIgnore");
		}
		IntPtr arg = NSString.CreateNative(wordToIgnore);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selIgnoreWordInSpellDocumentWithTag_Handle, arg, documentTag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selIgnoreWordInSpellDocumentWithTag_Handle, arg, documentTag);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("ignoredWordsInSpellDocumentWithTag:")]
	public virtual string[] IgnoredWords(long documentTag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selIgnoredWordsInSpellDocumentWithTag_Handle, documentTag));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selIgnoredWordsInSpellDocumentWithTag_Handle, documentTag));
	}

	[Export("setIgnoredWords:inSpellDocumentWithTag:")]
	public virtual void SetIgnoredWords(string[] words, long documentTag)
	{
		NSApplication.EnsureUIThread();
		if (words == null)
		{
			throw new ArgumentNullException("words");
		}
		NSArray nSArray = NSArray.FromStrings(words);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selSetIgnoredWordsInSpellDocumentWithTag_Handle, nSArray.Handle, documentTag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selSetIgnoredWordsInSpellDocumentWithTag_Handle, nSArray.Handle, documentTag);
		}
		nSArray.Dispose();
	}

	[Export("guessesForWordRange:inString:language:inSpellDocumentWithTag:")]
	public virtual string[] GuessesForWordRange(NSRange range, string theString, string language, long documentTag)
	{
		NSApplication.EnsureUIThread();
		if (theString == null)
		{
			throw new ArgumentNullException("theString");
		}
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		IntPtr arg = NSString.CreateNative(theString);
		IntPtr arg2 = NSString.CreateNative(language);
		string[] result = ((!IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr_IntPtr_Int64(base.SuperHandle, selGuessesForWordRangeInStringLanguageInSpellDocumentWithTag_Handle, range, arg, arg2, documentTag)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr_IntPtr_Int64(base.Handle, selGuessesForWordRangeInStringLanguageInSpellDocumentWithTag_Handle, range, arg, arg2, documentTag)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("completionsForPartialWordRange:inString:language:inSpellDocumentWithTag:")]
	public virtual string[] CompletionsForPartialWordRange(NSRange range, string theString, string language, long documentTag)
	{
		NSApplication.EnsureUIThread();
		if (theString == null)
		{
			throw new ArgumentNullException("theString");
		}
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		IntPtr arg = NSString.CreateNative(theString);
		IntPtr arg2 = NSString.CreateNative(language);
		string[] result = ((!IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr_IntPtr_Int64(base.SuperHandle, selCompletionsForPartialWordRangeInStringLanguageInSpellDocumentWithTag_Handle, range, arg, arg2, documentTag)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr_IntPtr_Int64(base.Handle, selCompletionsForPartialWordRangeInStringLanguageInSpellDocumentWithTag_Handle, range, arg, arg2, documentTag)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("closeSpellDocumentWithTag:")]
	public virtual void CloseSpellDocument(long documentTag)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selCloseSpellDocumentWithTag_Handle, documentTag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selCloseSpellDocumentWithTag_Handle, documentTag);
		}
	}

	[Export("setWordFieldStringValue:")]
	public virtual void SetWordFieldStringValue(string aString)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWordFieldStringValue_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWordFieldStringValue_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("learnWord:")]
	public virtual void LearnWord(string word)
	{
		NSApplication.EnsureUIThread();
		if (word == null)
		{
			throw new ArgumentNullException("word");
		}
		IntPtr arg = NSString.CreateNative(word);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLearnWord_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLearnWord_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("hasLearnedWord:")]
	public virtual bool HasLearnedWord(string word)
	{
		NSApplication.EnsureUIThread();
		if (word == null)
		{
			throw new ArgumentNullException("word");
		}
		IntPtr arg = NSString.CreateNative(word);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasLearnedWord_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasLearnedWord_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("unlearnWord:")]
	public virtual void UnlearnWord(string word)
	{
		NSApplication.EnsureUIThread();
		if (word == null)
		{
			throw new ArgumentNullException("word");
		}
		IntPtr arg = NSString.CreateNative(word);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUnlearnWord_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnlearnWord_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("language")]
	protected virtual string GetLanguage()
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLanguageHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLanguageHandle));
	}

	[Export("setLanguage:")]
	protected virtual bool SetLanguage(string language)
	{
		NSApplication.EnsureUIThread();
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		IntPtr arg = NSString.CreateNative(language);
		bool result = ((!IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLanguage_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetLanguage_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_UserReplacementsDictionary_var = null;
			__mt_SpellingPanel_var = null;
			__mt_SubstitutionsPanel_var = null;
			__mt_AccessoryView_var = null;
			__mt_SubstitutionsPanelAccessoryViewController_var = null;
		}
	}
}
