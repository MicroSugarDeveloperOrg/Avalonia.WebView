using System;
using System.ComponentModel;
using System.Threading.Tasks;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSSpellChecker", true)]
public class NSSpellChecker : NSObject
{
	public static class Notifications
	{
		public static NSObject ObserveDidChangeAutomaticCapitalization(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeAutomaticCapitalizationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChangeAutomaticCapitalization(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeAutomaticCapitalizationNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidChangeAutomaticPeriodSubstitution(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeAutomaticPeriodSubstitutionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChangeAutomaticPeriodSubstitution(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeAutomaticPeriodSubstitutionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidChangeAutomaticSpellingCorrection(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeAutomaticSpellingCorrectionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChangeAutomaticSpellingCorrection(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeAutomaticSpellingCorrectionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidChangeAutomaticTextCompletion(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeAutomaticTextCompletionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChangeAutomaticTextCompletion(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeAutomaticTextCompletionNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}

		public static NSObject ObserveDidChangeAutomaticTextReplacement(EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeAutomaticTextReplacementNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			});
		}

		public static NSObject ObserveDidChangeAutomaticTextReplacement(NSObject objectToObserve, EventHandler<NSNotificationEventArgs> handler)
		{
			EventHandler<NSNotificationEventArgs> handler2 = handler;
			return NSNotificationCenter.DefaultCenter.AddObserver(DidChangeAutomaticTextReplacementNotification, delegate(NSNotification notification)
			{
				handler2(null, new NSNotificationEventArgs(notification));
			}, objectToObserve);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAccessoryView = "accessoryView";

	private static readonly IntPtr selAccessoryViewHandle = Selector.GetHandle("accessoryView");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAutomaticallyIdentifiesLanguages = "automaticallyIdentifiesLanguages";

	private static readonly IntPtr selAutomaticallyIdentifiesLanguagesHandle = Selector.GetHandle("automaticallyIdentifiesLanguages");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAvailableLanguages = "availableLanguages";

	private static readonly IntPtr selAvailableLanguagesHandle = Selector.GetHandle("availableLanguages");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckGrammarOfString_StartingAt_Language_Wrap_InSpellDocumentWithTag_Details_ = "checkGrammarOfString:startingAt:language:wrap:inSpellDocumentWithTag:details:";

	private static readonly IntPtr selCheckGrammarOfString_StartingAt_Language_Wrap_InSpellDocumentWithTag_Details_Handle = Selector.GetHandle("checkGrammarOfString:startingAt:language:wrap:inSpellDocumentWithTag:details:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckSpellingOfString_StartingAt_ = "checkSpellingOfString:startingAt:";

	private static readonly IntPtr selCheckSpellingOfString_StartingAt_Handle = Selector.GetHandle("checkSpellingOfString:startingAt:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckSpellingOfString_StartingAt_Language_Wrap_InSpellDocumentWithTag_WordCount_ = "checkSpellingOfString:startingAt:language:wrap:inSpellDocumentWithTag:wordCount:";

	private static readonly IntPtr selCheckSpellingOfString_StartingAt_Language_Wrap_InSpellDocumentWithTag_WordCount_Handle = Selector.GetHandle("checkSpellingOfString:startingAt:language:wrap:inSpellDocumentWithTag:wordCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCheckString_Range_Types_Options_InSpellDocumentWithTag_Orthography_WordCount_ = "checkString:range:types:options:inSpellDocumentWithTag:orthography:wordCount:";

	private static readonly IntPtr selCheckString_Range_Types_Options_InSpellDocumentWithTag_Orthography_WordCount_Handle = Selector.GetHandle("checkString:range:types:options:inSpellDocumentWithTag:orthography:wordCount:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCloseSpellDocumentWithTag_ = "closeSpellDocumentWithTag:";

	private static readonly IntPtr selCloseSpellDocumentWithTag_Handle = Selector.GetHandle("closeSpellDocumentWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCompletionsForPartialWordRange_InString_Language_InSpellDocumentWithTag_ = "completionsForPartialWordRange:inString:language:inSpellDocumentWithTag:";

	private static readonly IntPtr selCompletionsForPartialWordRange_InString_Language_InSpellDocumentWithTag_Handle = Selector.GetHandle("completionsForPartialWordRange:inString:language:inSpellDocumentWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCorrectionForWordRange_InString_Language_InSpellDocumentWithTag_ = "correctionForWordRange:inString:language:inSpellDocumentWithTag:";

	private static readonly IntPtr selCorrectionForWordRange_InString_Language_InSpellDocumentWithTag_Handle = Selector.GetHandle("correctionForWordRange:inString:language:inSpellDocumentWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCountWordsInString_Language_ = "countWordsInString:language:";

	private static readonly IntPtr selCountWordsInString_Language_Handle = Selector.GetHandle("countWordsInString:language:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeletesAutospaceBetweenString_AndString_Language_ = "deletesAutospaceBetweenString:andString:language:";

	private static readonly IntPtr selDeletesAutospaceBetweenString_AndString_Language_Handle = Selector.GetHandle("deletesAutospaceBetweenString:andString:language:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDismissCorrectionIndicatorForView_ = "dismissCorrectionIndicatorForView:";

	private static readonly IntPtr selDismissCorrectionIndicatorForView_Handle = Selector.GetHandle("dismissCorrectionIndicatorForView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selGuessesForWordRange_InString_Language_InSpellDocumentWithTag_ = "guessesForWordRange:inString:language:inSpellDocumentWithTag:";

	private static readonly IntPtr selGuessesForWordRange_InString_Language_InSpellDocumentWithTag_Handle = Selector.GetHandle("guessesForWordRange:inString:language:inSpellDocumentWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasLearnedWord_ = "hasLearnedWord:";

	private static readonly IntPtr selHasLearnedWord_Handle = Selector.GetHandle("hasLearnedWord:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIgnoreWord_InSpellDocumentWithTag_ = "ignoreWord:inSpellDocumentWithTag:";

	private static readonly IntPtr selIgnoreWord_InSpellDocumentWithTag_Handle = Selector.GetHandle("ignoreWord:inSpellDocumentWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIgnoredWordsInSpellDocumentWithTag_ = "ignoredWordsInSpellDocumentWithTag:";

	private static readonly IntPtr selIgnoredWordsInSpellDocumentWithTag_Handle = Selector.GetHandle("ignoredWordsInSpellDocumentWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticCapitalizationEnabled = "isAutomaticCapitalizationEnabled";

	private static readonly IntPtr selIsAutomaticCapitalizationEnabledHandle = Selector.GetHandle("isAutomaticCapitalizationEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticDashSubstitutionEnabled = "isAutomaticDashSubstitutionEnabled";

	private static readonly IntPtr selIsAutomaticDashSubstitutionEnabledHandle = Selector.GetHandle("isAutomaticDashSubstitutionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticPeriodSubstitutionEnabled = "isAutomaticPeriodSubstitutionEnabled";

	private static readonly IntPtr selIsAutomaticPeriodSubstitutionEnabledHandle = Selector.GetHandle("isAutomaticPeriodSubstitutionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticQuoteSubstitutionEnabled = "isAutomaticQuoteSubstitutionEnabled";

	private static readonly IntPtr selIsAutomaticQuoteSubstitutionEnabledHandle = Selector.GetHandle("isAutomaticQuoteSubstitutionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticSpellingCorrectionEnabled = "isAutomaticSpellingCorrectionEnabled";

	private static readonly IntPtr selIsAutomaticSpellingCorrectionEnabledHandle = Selector.GetHandle("isAutomaticSpellingCorrectionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticTextCompletionEnabled = "isAutomaticTextCompletionEnabled";

	private static readonly IntPtr selIsAutomaticTextCompletionEnabledHandle = Selector.GetHandle("isAutomaticTextCompletionEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsAutomaticTextReplacementEnabled = "isAutomaticTextReplacementEnabled";

	private static readonly IntPtr selIsAutomaticTextReplacementEnabledHandle = Selector.GetHandle("isAutomaticTextReplacementEnabled");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguage = "language";

	private static readonly IntPtr selLanguageHandle = Selector.GetHandle("language");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLanguageForWordRange_InString_Orthography_ = "languageForWordRange:inString:orthography:";

	private static readonly IntPtr selLanguageForWordRange_InString_Orthography_Handle = Selector.GetHandle("languageForWordRange:inString:orthography:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLearnWord_ = "learnWord:";

	private static readonly IntPtr selLearnWord_Handle = Selector.GetHandle("learnWord:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMenuForResult_String_Options_AtLocation_InView_ = "menuForResult:string:options:atLocation:inView:";

	private static readonly IntPtr selMenuForResult_String_Options_AtLocation_InView_Handle = Selector.GetHandle("menuForResult:string:options:atLocation:inView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPreventsAutocorrectionBeforeString_Language_ = "preventsAutocorrectionBeforeString:language:";

	private static readonly IntPtr selPreventsAutocorrectionBeforeString_Language_Handle = Selector.GetHandle("preventsAutocorrectionBeforeString:language:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRecordResponse_ToCorrection_ForWord_Language_InSpellDocumentWithTag_ = "recordResponse:toCorrection:forWord:language:inSpellDocumentWithTag:";

	private static readonly IntPtr selRecordResponse_ToCorrection_ForWord_Language_InSpellDocumentWithTag_Handle = Selector.GetHandle("recordResponse:toCorrection:forWord:language:inSpellDocumentWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestCandidatesForSelectedRange_InString_Types_Options_InSpellDocumentWithTag_CompletionHandler_ = "requestCandidatesForSelectedRange:inString:types:options:inSpellDocumentWithTag:completionHandler:";

	private static readonly IntPtr selRequestCandidatesForSelectedRange_InString_Types_Options_InSpellDocumentWithTag_CompletionHandler_Handle = Selector.GetHandle("requestCandidatesForSelectedRange:inString:types:options:inSpellDocumentWithTag:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRequestCheckingOfString_Range_Types_Options_InSpellDocumentWithTag_CompletionHandler_ = "requestCheckingOfString:range:types:options:inSpellDocumentWithTag:completionHandler:";

	private static readonly IntPtr selRequestCheckingOfString_Range_Types_Options_InSpellDocumentWithTag_CompletionHandler_Handle = Selector.GetHandle("requestCheckingOfString:range:types:options:inSpellDocumentWithTag:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAccessoryView_ = "setAccessoryView:";

	private static readonly IntPtr selSetAccessoryView_Handle = Selector.GetHandle("setAccessoryView:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAutomaticallyIdentifiesLanguages_ = "setAutomaticallyIdentifiesLanguages:";

	private static readonly IntPtr selSetAutomaticallyIdentifiesLanguages_Handle = Selector.GetHandle("setAutomaticallyIdentifiesLanguages:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetIgnoredWords_InSpellDocumentWithTag_ = "setIgnoredWords:inSpellDocumentWithTag:";

	private static readonly IntPtr selSetIgnoredWords_InSpellDocumentWithTag_Handle = Selector.GetHandle("setIgnoredWords:inSpellDocumentWithTag:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLanguage_ = "setLanguage:";

	private static readonly IntPtr selSetLanguage_Handle = Selector.GetHandle("setLanguage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetSubstitutionsPanelAccessoryViewController_ = "setSubstitutionsPanelAccessoryViewController:";

	private static readonly IntPtr selSetSubstitutionsPanelAccessoryViewController_Handle = Selector.GetHandle("setSubstitutionsPanelAccessoryViewController:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetWordFieldStringValue_ = "setWordFieldStringValue:";

	private static readonly IntPtr selSetWordFieldStringValue_Handle = Selector.GetHandle("setWordFieldStringValue:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedSpellChecker = "sharedSpellChecker";

	private static readonly IntPtr selSharedSpellCheckerHandle = Selector.GetHandle("sharedSpellChecker");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSharedSpellCheckerExists = "sharedSpellCheckerExists";

	private static readonly IntPtr selSharedSpellCheckerExistsHandle = Selector.GetHandle("sharedSpellCheckerExists");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selShowCorrectionIndicatorOfType_PrimaryString_AlternativeStrings_ForStringInRect_View_CompletionHandler_ = "showCorrectionIndicatorOfType:primaryString:alternativeStrings:forStringInRect:view:completionHandler:";

	private static readonly IntPtr selShowCorrectionIndicatorOfType_PrimaryString_AlternativeStrings_ForStringInRect_View_CompletionHandler_Handle = Selector.GetHandle("showCorrectionIndicatorOfType:primaryString:alternativeStrings:forStringInRect:view:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSpellingPanel = "spellingPanel";

	private static readonly IntPtr selSpellingPanelHandle = Selector.GetHandle("spellingPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubstitutionsPanel = "substitutionsPanel";

	private static readonly IntPtr selSubstitutionsPanelHandle = Selector.GetHandle("substitutionsPanel");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubstitutionsPanelAccessoryViewController = "substitutionsPanelAccessoryViewController";

	private static readonly IntPtr selSubstitutionsPanelAccessoryViewControllerHandle = Selector.GetHandle("substitutionsPanelAccessoryViewController");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUniqueSpellDocumentTag = "uniqueSpellDocumentTag";

	private static readonly IntPtr selUniqueSpellDocumentTagHandle = Selector.GetHandle("uniqueSpellDocumentTag");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnlearnWord_ = "unlearnWord:";

	private static readonly IntPtr selUnlearnWord_Handle = Selector.GetHandle("unlearnWord:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdatePanels = "updatePanels";

	private static readonly IntPtr selUpdatePanelsHandle = Selector.GetHandle("updatePanels");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateSpellingPanelWithGrammarString_Detail_ = "updateSpellingPanelWithGrammarString:detail:";

	private static readonly IntPtr selUpdateSpellingPanelWithGrammarString_Detail_Handle = Selector.GetHandle("updateSpellingPanelWithGrammarString:detail:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateSpellingPanelWithMisspelledWord_ = "updateSpellingPanelWithMisspelledWord:";

	private static readonly IntPtr selUpdateSpellingPanelWithMisspelledWord_Handle = Selector.GetHandle("updateSpellingPanelWithMisspelledWord:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserPreferredLanguages = "userPreferredLanguages";

	private static readonly IntPtr selUserPreferredLanguagesHandle = Selector.GetHandle("userPreferredLanguages");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserQuotesArrayForLanguage_ = "userQuotesArrayForLanguage:";

	private static readonly IntPtr selUserQuotesArrayForLanguage_Handle = Selector.GetHandle("userQuotesArrayForLanguage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUserReplacementsDictionary = "userReplacementsDictionary";

	private static readonly IntPtr selUserReplacementsDictionaryHandle = Selector.GetHandle("userReplacementsDictionary");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSSpellChecker");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidChangeAutomaticCapitalizationNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidChangeAutomaticPeriodSubstitutionNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidChangeAutomaticSpellingCorrectionNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidChangeAutomaticTextCompletionNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _DidChangeAutomaticTextReplacementNotification;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextCheckingDocumentAuthorKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextCheckingDocumentTitleKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextCheckingDocumentURLKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextCheckingOrthographyKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextCheckingQuotesKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextCheckingReferenceDateKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextCheckingReferenceTimeZoneKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextCheckingRegularExpressionsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextCheckingReplacementsKey;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextCheckingSelectedRangeKey;

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

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSView? AccessoryView
	{
		[Export("accessoryView", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSend(base.Handle, selAccessoryViewHandle));
			}
			return Runtime.GetNSObject<NSView>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAccessoryViewHandle));
		}
		[Export("setAccessoryView:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetAccessoryView_Handle, value?.Handle ?? IntPtr.Zero);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool AutomaticallyIdentifiesLanguages
	{
		[Export("automaticallyIdentifiesLanguages")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAutomaticallyIdentifiesLanguagesHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAutomaticallyIdentifiesLanguagesHandle);
		}
		[Export("setAutomaticallyIdentifiesLanguages:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAutomaticallyIdentifiesLanguages_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAutomaticallyIdentifiesLanguages_Handle, value);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] AvailableLanguages
	{
		[Export("availableLanguages")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selAvailableLanguagesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAvailableLanguagesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static bool IsAutomaticCapitalizationEnabled
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("isAutomaticCapitalizationEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selIsAutomaticCapitalizationEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static bool IsAutomaticPeriodSubstitutionEnabled
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		[Export("isAutomaticPeriodSubstitutionEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selIsAutomaticPeriodSubstitutionEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsAutomaticSpellingCorrectionEnabled
	{
		[Export("isAutomaticSpellingCorrectionEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selIsAutomaticSpellingCorrectionEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	public static bool IsAutomaticTextCompletionEnabled
	{
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		[Export("isAutomaticTextCompletionEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selIsAutomaticTextCompletionEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsAutomaticTextReplacementEnabled
	{
		[Export("isAutomaticTextReplacementEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selIsAutomaticTextReplacementEnabledHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSSpellChecker SharedSpellChecker
	{
		[Export("sharedSpellChecker")]
		get
		{
			NSApplication.EnsureUIThread();
			return Runtime.GetNSObject<NSSpellChecker>(Messaging.IntPtr_objc_msgSend(class_ptr, selSharedSpellCheckerHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool SharedSpellCheckerExists
	{
		[Export("sharedSpellCheckerExists")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.bool_objc_msgSend(class_ptr, selSharedSpellCheckerExistsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPanel SpellingPanel
	{
		[Export("spellingPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPanel>(Messaging.IntPtr_objc_msgSend(base.Handle, selSpellingPanelHandle));
			}
			return Runtime.GetNSObject<NSPanel>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSpellingPanelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSPanel SubstitutionsPanel
	{
		[Export("substitutionsPanel")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSPanel>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubstitutionsPanelHandle));
			}
			return Runtime.GetNSObject<NSPanel>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubstitutionsPanelHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSViewController SubstitutionsPanelAccessoryViewController
	{
		[Export("substitutionsPanelAccessoryViewController", ArgumentSemantic.Retain)]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSend(base.Handle, selSubstitutionsPanelAccessoryViewControllerHandle));
			}
			return Runtime.GetNSObject<NSViewController>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selSubstitutionsPanelAccessoryViewControllerHandle));
		}
		[Export("setSubstitutionsPanelAccessoryViewController:", ArgumentSemantic.Retain)]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetSubstitutionsPanelAccessoryViewController_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetSubstitutionsPanelAccessoryViewController_Handle, value.Handle);
			}
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static nint UniqueSpellDocumentTag
	{
		[Export("uniqueSpellDocumentTag")]
		get
		{
			NSApplication.EnsureUIThread();
			return Messaging.nint_objc_msgSend(class_ptr, selUniqueSpellDocumentTagHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] UserPreferredLanguages
	{
		[Export("userPreferredLanguages")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selUserPreferredLanguagesHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserPreferredLanguagesHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary UserReplacementsDictionary
	{
		[Export("userReplacementsDictionary")]
		get
		{
			NSApplication.EnsureUIThread();
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend(base.Handle, selUserReplacementsDictionaryHandle));
			}
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selUserReplacementsDictionaryHandle));
		}
	}

	[Field("NSSpellCheckerDidChangeAutomaticCapitalizationNotification", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Advice("Use NSSpellChecker.Notifications.ObserveDidChangeAutomaticCapitalization helper method instead.")]
	public static NSString DidChangeAutomaticCapitalizationNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_DidChangeAutomaticCapitalizationNotification == null)
			{
				_DidChangeAutomaticCapitalizationNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSpellCheckerDidChangeAutomaticCapitalizationNotification");
			}
			return _DidChangeAutomaticCapitalizationNotification;
		}
	}

	[Field("NSSpellCheckerDidChangeAutomaticPeriodSubstitutionNotification", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[Advice("Use NSSpellChecker.Notifications.ObserveDidChangeAutomaticPeriodSubstitution helper method instead.")]
	public static NSString DidChangeAutomaticPeriodSubstitutionNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_DidChangeAutomaticPeriodSubstitutionNotification == null)
			{
				_DidChangeAutomaticPeriodSubstitutionNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSpellCheckerDidChangeAutomaticPeriodSubstitutionNotification");
			}
			return _DidChangeAutomaticPeriodSubstitutionNotification;
		}
	}

	[Field("NSSpellCheckerDidChangeAutomaticSpellingCorrectionNotification", "AppKit")]
	[Advice("Use NSSpellChecker.Notifications.ObserveDidChangeAutomaticSpellingCorrection helper method instead.")]
	public static NSString DidChangeAutomaticSpellingCorrectionNotification
	{
		get
		{
			if (_DidChangeAutomaticSpellingCorrectionNotification == null)
			{
				_DidChangeAutomaticSpellingCorrectionNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSpellCheckerDidChangeAutomaticSpellingCorrectionNotification");
			}
			return _DidChangeAutomaticSpellingCorrectionNotification;
		}
	}

	[Field("NSSpellCheckerDidChangeAutomaticTextCompletionNotification", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[Advice("Use NSSpellChecker.Notifications.ObserveDidChangeAutomaticTextCompletion helper method instead.")]
	public static NSString DidChangeAutomaticTextCompletionNotification
	{
		[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
		get
		{
			if (_DidChangeAutomaticTextCompletionNotification == null)
			{
				_DidChangeAutomaticTextCompletionNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSpellCheckerDidChangeAutomaticTextCompletionNotification");
			}
			return _DidChangeAutomaticTextCompletionNotification;
		}
	}

	[Field("NSSpellCheckerDidChangeAutomaticTextReplacementNotification", "AppKit")]
	[Advice("Use NSSpellChecker.Notifications.ObserveDidChangeAutomaticTextReplacement helper method instead.")]
	public static NSString DidChangeAutomaticTextReplacementNotification
	{
		get
		{
			if (_DidChangeAutomaticTextReplacementNotification == null)
			{
				_DidChangeAutomaticTextReplacementNotification = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSpellCheckerDidChangeAutomaticTextReplacementNotification");
			}
			return _DidChangeAutomaticTextReplacementNotification;
		}
	}

	[Field("NSTextCheckingDocumentAuthorKey", "AppKit")]
	public static NSString TextCheckingDocumentAuthorKey
	{
		get
		{
			if (_TextCheckingDocumentAuthorKey == null)
			{
				_TextCheckingDocumentAuthorKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingDocumentAuthorKey");
			}
			return _TextCheckingDocumentAuthorKey;
		}
	}

	[Field("NSTextCheckingDocumentTitleKey", "AppKit")]
	public static NSString TextCheckingDocumentTitleKey
	{
		get
		{
			if (_TextCheckingDocumentTitleKey == null)
			{
				_TextCheckingDocumentTitleKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingDocumentTitleKey");
			}
			return _TextCheckingDocumentTitleKey;
		}
	}

	[Field("NSTextCheckingDocumentURLKey", "AppKit")]
	public static NSString TextCheckingDocumentURLKey
	{
		get
		{
			if (_TextCheckingDocumentURLKey == null)
			{
				_TextCheckingDocumentURLKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingDocumentURLKey");
			}
			return _TextCheckingDocumentURLKey;
		}
	}

	[Field("NSTextCheckingOrthographyKey", "AppKit")]
	public static NSString TextCheckingOrthographyKey
	{
		get
		{
			if (_TextCheckingOrthographyKey == null)
			{
				_TextCheckingOrthographyKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingOrthographyKey");
			}
			return _TextCheckingOrthographyKey;
		}
	}

	[Field("NSTextCheckingQuotesKey", "AppKit")]
	public static NSString TextCheckingQuotesKey
	{
		get
		{
			if (_TextCheckingQuotesKey == null)
			{
				_TextCheckingQuotesKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingQuotesKey");
			}
			return _TextCheckingQuotesKey;
		}
	}

	[Field("NSTextCheckingReferenceDateKey", "AppKit")]
	public static NSString TextCheckingReferenceDateKey
	{
		get
		{
			if (_TextCheckingReferenceDateKey == null)
			{
				_TextCheckingReferenceDateKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingReferenceDateKey");
			}
			return _TextCheckingReferenceDateKey;
		}
	}

	[Field("NSTextCheckingReferenceTimeZoneKey", "AppKit")]
	public static NSString TextCheckingReferenceTimeZoneKey
	{
		get
		{
			if (_TextCheckingReferenceTimeZoneKey == null)
			{
				_TextCheckingReferenceTimeZoneKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingReferenceTimeZoneKey");
			}
			return _TextCheckingReferenceTimeZoneKey;
		}
	}

	[Field("NSTextCheckingRegularExpressionsKey", "AppKit")]
	public static NSString TextCheckingRegularExpressionsKey
	{
		get
		{
			if (_TextCheckingRegularExpressionsKey == null)
			{
				_TextCheckingRegularExpressionsKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingRegularExpressionsKey");
			}
			return _TextCheckingRegularExpressionsKey;
		}
	}

	[Field("NSTextCheckingReplacementsKey", "AppKit")]
	public static NSString TextCheckingReplacementsKey
	{
		get
		{
			if (_TextCheckingReplacementsKey == null)
			{
				_TextCheckingReplacementsKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingReplacementsKey");
			}
			return _TextCheckingReplacementsKey;
		}
	}

	[Field("NSTextCheckingSelectedRangeKey", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	public static NSString TextCheckingSelectedRangeKey
	{
		[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
		get
		{
			if (_TextCheckingSelectedRangeKey == null)
			{
				_TextCheckingSelectedRangeKey = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextCheckingSelectedRangeKey");
			}
			return _TextCheckingSelectedRangeKey;
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSSpellChecker()
		: base(NSObjectFlag.Empty)
	{
		NSApplication.EnsureUIThread();
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
	protected NSSpellChecker(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSSpellChecker(IntPtr handle)
		: base(handle)
	{
	}

	[Export("checkGrammarOfString:startingAt:language:wrap:inSpellDocumentWithTag:details:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange CheckGrammar(string stringToCheck, nint startingOffset, string language, bool wrapFlag, nint documentTag, NSDictionary[] details)
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
		NSRange result = ((!base.IsDirectBinding) ? Messaging.NSRange_objc_msgSendSuper_IntPtr_nint_IntPtr_bool_nint_IntPtr(base.SuperHandle, selCheckGrammarOfString_StartingAt_Language_Wrap_InSpellDocumentWithTag_Details_Handle, arg, startingOffset, arg2, wrapFlag, documentTag, nSArray.Handle) : Messaging.NSRange_objc_msgSend_IntPtr_nint_IntPtr_bool_nint_IntPtr(base.Handle, selCheckGrammarOfString_StartingAt_Language_Wrap_InSpellDocumentWithTag_Details_Handle, arg, startingOffset, arg2, wrapFlag, documentTag, nSArray.Handle));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		nSArray.Dispose();
		return result;
	}

	[Export("checkSpellingOfString:startingAt:language:wrap:inSpellDocumentWithTag:wordCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange CheckSpelling(string stringToCheck, nint startingOffset, string language, bool wrapFlag, nint documentTag, out nint wordCount)
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
		NSRange result = ((!base.IsDirectBinding) ? Messaging.NSRange_objc_msgSendSuper_IntPtr_nint_IntPtr_bool_nint_out_nint(base.SuperHandle, selCheckSpellingOfString_StartingAt_Language_Wrap_InSpellDocumentWithTag_WordCount_Handle, arg, startingOffset, arg2, wrapFlag, documentTag, out wordCount) : Messaging.NSRange_objc_msgSend_IntPtr_nint_IntPtr_bool_nint_out_nint(base.Handle, selCheckSpellingOfString_StartingAt_Language_Wrap_InSpellDocumentWithTag_WordCount_Handle, arg, startingOffset, arg2, wrapFlag, documentTag, out wordCount));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("checkSpellingOfString:startingAt:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange CheckSpelling(string stringToCheck, nint startingOffset)
	{
		NSApplication.EnsureUIThread();
		if (stringToCheck == null)
		{
			throw new ArgumentNullException("stringToCheck");
		}
		IntPtr arg = NSString.CreateNative(stringToCheck);
		NSRange result = ((!base.IsDirectBinding) ? Messaging.NSRange_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selCheckSpellingOfString_StartingAt_Handle, arg, startingOffset) : Messaging.NSRange_objc_msgSend_IntPtr_nint(base.Handle, selCheckSpellingOfString_StartingAt_Handle, arg, startingOffset));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("checkString:range:types:options:inSpellDocumentWithTag:orthography:wordCount:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextCheckingResult[] CheckString(string stringToCheck, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary? options, nint tag, out NSOrthography orthography, out nint wordCount)
	{
		NSApplication.EnsureUIThread();
		if (stringToCheck == null)
		{
			throw new ArgumentNullException("stringToCheck");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(stringToCheck);
		NSTextCheckingResult[] result = ((!base.IsDirectBinding) ? NSArray.ArrayFromHandle<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_NSRange_UInt64_IntPtr_nint_ref_IntPtr_out_nint(base.SuperHandle, selCheckString_Range_Types_Options_InSpellDocumentWithTag_Orthography_WordCount_Handle, arg2, range, (ulong)checkingTypes, options?.Handle ?? IntPtr.Zero, tag, ref arg, out wordCount)) : NSArray.ArrayFromHandle<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr_nint_ref_IntPtr_out_nint(base.Handle, selCheckString_Range_Types_Options_InSpellDocumentWithTag_Orthography_WordCount_Handle, arg2, range, (ulong)checkingTypes, options?.Handle ?? IntPtr.Zero, tag, ref arg, out wordCount)));
		NSString.ReleaseNative(arg2);
		orthography = Runtime.GetNSObject<NSOrthography>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextCheckingResult[] CheckString(string stringToCheck, NSRange range, NSTextCheckingTypes checkingTypes, NSTextCheckingOptions options, nint tag, out NSOrthography orthography, out nint wordCount)
	{
		return CheckString(stringToCheck, range, checkingTypes, options.GetDictionary(), tag, out orthography, out wordCount);
	}

	[Export("closeSpellDocumentWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void CloseSpellDocument(nint documentTag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_nint(base.Handle, selCloseSpellDocumentWithTag_Handle, documentTag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_nint(base.SuperHandle, selCloseSpellDocumentWithTag_Handle, documentTag);
		}
	}

	[Export("completionsForPartialWordRange:inString:language:inSpellDocumentWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] CompletionsForPartialWordRange(NSRange range, string theString, string language, nint documentTag)
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
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr_IntPtr_nint(base.SuperHandle, selCompletionsForPartialWordRange_InString_Language_InSpellDocumentWithTag_Handle, range, arg, arg2, documentTag)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr_IntPtr_nint(base.Handle, selCompletionsForPartialWordRange_InString_Language_InSpellDocumentWithTag_Handle, range, arg, arg2, documentTag)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("countWordsInString:language:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint CountWords(string stringToCount, string language)
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
		nint result = ((!base.IsDirectBinding) ? Messaging.nint_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selCountWordsInString_Language_Handle, arg, arg2) : Messaging.nint_objc_msgSend_IntPtr_IntPtr(base.Handle, selCountWordsInString_Language_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("deletesAutospaceBetweenString:andString:language:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool DeletesAutospace(string precedingString, string followingString, string? language)
	{
		NSApplication.EnsureUIThread();
		if (precedingString == null)
		{
			throw new ArgumentNullException("precedingString");
		}
		if (followingString == null)
		{
			throw new ArgumentNullException("followingString");
		}
		IntPtr arg = NSString.CreateNative(precedingString);
		IntPtr arg2 = NSString.CreateNative(followingString);
		IntPtr arg3 = NSString.CreateNative(language);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selDeletesAutospaceBetweenString_AndString_Language_Handle, arg, arg2, arg3) : Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selDeletesAutospaceBetweenString_AndString_Language_Handle, arg, arg2, arg3));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
		return result;
	}

	[Export("dismissCorrectionIndicatorForView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DismissCorrectionIndicator(NSView forView)
	{
		NSApplication.EnsureUIThread();
		if (forView == null)
		{
			throw new ArgumentNullException("forView");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selDismissCorrectionIndicatorForView_Handle, forView.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selDismissCorrectionIndicatorForView_Handle, forView.Handle);
		}
	}

	[Export("correctionForWordRange:inString:language:inSpellDocumentWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetCorrection(NSRange forWordRange, string inString, string language, nint inSpellDocumentWithTag)
	{
		NSApplication.EnsureUIThread();
		if (inString == null)
		{
			throw new ArgumentNullException("inString");
		}
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		IntPtr arg = NSString.CreateNative(inString);
		IntPtr arg2 = NSString.CreateNative(language);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr_IntPtr_nint(base.SuperHandle, selCorrectionForWordRange_InString_Language_InSpellDocumentWithTag_Handle, forWordRange, arg, arg2, inSpellDocumentWithTag)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr_IntPtr_nint(base.Handle, selCorrectionForWordRange_InString_Language_InSpellDocumentWithTag_Handle, forWordRange, arg, arg2, inSpellDocumentWithTag)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("language")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual string GetLanguage()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selLanguageHandle));
		}
		return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLanguageHandle));
	}

	[Export("languageForWordRange:inString:orthography:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string GetLanguage(NSRange forWordRange, string inString, NSOrthography orthography)
	{
		NSApplication.EnsureUIThread();
		if (inString == null)
		{
			throw new ArgumentNullException("inString");
		}
		if (orthography == null)
		{
			throw new ArgumentNullException("orthography");
		}
		IntPtr arg = NSString.CreateNative(inString);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr_IntPtr(base.SuperHandle, selLanguageForWordRange_InString_Orthography_Handle, forWordRange, arg, orthography.Handle)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr_IntPtr(base.Handle, selLanguageForWordRange_InString_Orthography_Handle, forWordRange, arg, orthography.Handle)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("guessesForWordRange:inString:language:inSpellDocumentWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] GuessesForWordRange(NSRange range, string theString, string language, nint documentTag)
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
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr_IntPtr_nint(base.SuperHandle, selGuessesForWordRange_InString_Language_InSpellDocumentWithTag_Handle, range, arg, arg2, documentTag)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr_IntPtr_nint(base.Handle, selGuessesForWordRange_InString_Language_InSpellDocumentWithTag_Handle, range, arg, arg2, documentTag)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("hasLearnedWord:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasLearnedWord(string word)
	{
		NSApplication.EnsureUIThread();
		if (word == null)
		{
			throw new ArgumentNullException("word");
		}
		IntPtr arg = NSString.CreateNative(word);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasLearnedWord_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasLearnedWord_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("ignoreWord:inSpellDocumentWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void IgnoreWord(string wordToIgnore, nint documentTag)
	{
		NSApplication.EnsureUIThread();
		if (wordToIgnore == null)
		{
			throw new ArgumentNullException("wordToIgnore");
		}
		IntPtr arg = NSString.CreateNative(wordToIgnore);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selIgnoreWord_InSpellDocumentWithTag_Handle, arg, documentTag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selIgnoreWord_InSpellDocumentWithTag_Handle, arg, documentTag);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("ignoredWordsInSpellDocumentWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] IgnoredWords(nint documentTag)
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selIgnoredWordsInSpellDocumentWithTag_Handle, documentTag));
		}
		return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selIgnoredWordsInSpellDocumentWithTag_Handle, documentTag));
	}

	[Export("isAutomaticDashSubstitutionEnabled")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsAutomaticDashSubstitutionEnabled()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(class_ptr, selIsAutomaticDashSubstitutionEnabledHandle);
	}

	[Export("isAutomaticQuoteSubstitutionEnabled")]
	[Introduced(PlatformName.MacOSX, 10, 9, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool IsAutomaticQuoteSubstitutionEnabled()
	{
		NSApplication.EnsureUIThread();
		return Messaging.bool_objc_msgSend(class_ptr, selIsAutomaticQuoteSubstitutionEnabledHandle);
	}

	[Export("learnWord:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void LearnWord(string word)
	{
		NSApplication.EnsureUIThread();
		if (word == null)
		{
			throw new ArgumentNullException("word");
		}
		IntPtr arg = NSString.CreateNative(word);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selLearnWord_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selLearnWord_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("menuForResult:string:options:atLocation:inView:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		NSMenu result2 = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_CGPoint_IntPtr(base.SuperHandle, selMenuForResult_String_Options_AtLocation_InView_Handle, result.Handle, arg, options.Handle, location, view.Handle)) : Runtime.GetNSObject<NSMenu>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_CGPoint_IntPtr(base.Handle, selMenuForResult_String_Options_AtLocation_InView_Handle, result.Handle, arg, options.Handle, location, view.Handle)));
		NSString.ReleaseNative(arg);
		return result2;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMenu MenuForResults(NSTextCheckingResult result, string checkedString, NSTextCheckingOptions options, CGPoint location, NSView view)
	{
		return MenuForResults(result, checkedString, options.GetDictionary(), location, view);
	}

	[Export("preventsAutocorrectionBeforeString:language:")]
	[Introduced(PlatformName.MacOSX, 10, 12, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool PreventsAutocorrectionBefore(string aString, string? language)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		IntPtr arg2 = NSString.CreateNative(language);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selPreventsAutocorrectionBeforeString_Language_Handle, arg, arg2) : Messaging.bool_objc_msgSend_IntPtr_IntPtr(base.Handle, selPreventsAutocorrectionBeforeString_Language_Handle, arg, arg2));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("recordResponse:toCorrection:forWord:language:inSpellDocumentWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void RecordResponse(NSCorrectionResponse response, string toCorrection, string forWord, string language, nint inSpellDocumentWithTag)
	{
		NSApplication.EnsureUIThread();
		if (toCorrection == null)
		{
			throw new ArgumentNullException("toCorrection");
		}
		if (forWord == null)
		{
			throw new ArgumentNullException("forWord");
		}
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		IntPtr arg = NSString.CreateNative(toCorrection);
		IntPtr arg2 = NSString.CreateNative(forWord);
		IntPtr arg3 = NSString.CreateNative(language);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr_IntPtr_IntPtr_nint(base.Handle, selRecordResponse_ToCorrection_ForWord_Language_InSpellDocumentWithTag_Handle, (long)response, arg, arg2, arg3, inSpellDocumentWithTag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr_IntPtr_IntPtr_nint(base.SuperHandle, selRecordResponse_ToCorrection_ForWord_Language_InSpellDocumentWithTag_Handle, (long)response, arg, arg2, arg3, inSpellDocumentWithTag);
		}
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		NSString.ReleaseNative(arg3);
	}

	[Export("requestCandidatesForSelectedRange:inString:types:options:inSpellDocumentWithTag:completionHandler:")]
	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual nint RequestCandidates(NSRange selectedRange, string stringToCheck, ulong checkingTypes, NSDictionary<NSString, NSObject>? options, nint tag, [BlockProxy(typeof(Trampolines.NIDActionArity2V7))] Action<nint, NSTextCheckingResult[]>? completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (stringToCheck == null)
		{
			throw new ArgumentNullException("stringToCheck");
		}
		IntPtr arg = NSString.CreateNative(stringToCheck);
		BlockLiteral* ptr;
		if (completionHandler == null)
		{
			ptr = null;
		}
		else
		{
			BlockLiteral blockLiteral = default(BlockLiteral);
			ptr = &blockLiteral;
			blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V7.Handler, completionHandler);
		}
		nint result = ((!base.IsDirectBinding) ? Messaging.nint_objc_msgSendSuper_NSRange_IntPtr_UInt64_IntPtr_nint_IntPtr(base.SuperHandle, selRequestCandidatesForSelectedRange_InString_Types_Options_InSpellDocumentWithTag_CompletionHandler_Handle, selectedRange, arg, checkingTypes, options?.Handle ?? IntPtr.Zero, tag, (IntPtr)ptr) : Messaging.nint_objc_msgSend_NSRange_IntPtr_UInt64_IntPtr_nint_IntPtr(base.Handle, selRequestCandidatesForSelectedRange_InString_Types_Options_InSpellDocumentWithTag_CompletionHandler_Handle, selectedRange, arg, checkingTypes, options?.Handle ?? IntPtr.Zero, tag, (IntPtr)ptr));
		NSString.ReleaseNative(arg);
		if (ptr != null)
		{
			ptr->CleanupBlock();
		}
		return result;
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSSpellCheckerCanidates> RequestCandidatesAsync(NSRange selectedRange, string stringToCheck, ulong checkingTypes, NSDictionary<NSString, NSObject>? options, nint tag)
	{
		TaskCompletionSource<NSSpellCheckerCanidates> tcs = new TaskCompletionSource<NSSpellCheckerCanidates>();
		RequestCandidates(selectedRange, stringToCheck, checkingTypes, options, tag, delegate(nint arg1_, NSTextCheckingResult[] arg2_)
		{
			tcs.SetResult(new NSSpellCheckerCanidates(arg1_, arg2_));
		});
		return tcs.Task;
	}

	[Introduced(PlatformName.MacOSX, 10, 12, 2, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual Task<NSSpellCheckerCanidates> RequestCandidatesAsync(NSRange selectedRange, string stringToCheck, ulong checkingTypes, NSDictionary<NSString, NSObject>? options, nint tag, out nint result)
	{
		TaskCompletionSource<NSSpellCheckerCanidates> tcs = new TaskCompletionSource<NSSpellCheckerCanidates>();
		result = RequestCandidates(selectedRange, stringToCheck, checkingTypes, options, tag, delegate(nint arg1_, NSTextCheckingResult[] arg2_)
		{
			tcs.SetResult(new NSSpellCheckerCanidates(arg1_, arg2_));
		});
		return tcs.Task;
	}

	[Export("requestCheckingOfString:range:types:options:inSpellDocumentWithTag:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual nint RequestChecking(string stringToCheck, NSRange range, NSTextCheckingTypes checkingTypes, NSDictionary? options, nint tag, [BlockProxy(typeof(Trampolines.NIDActionArity4V0))] Action<nint, NSTextCheckingResult[], NSOrthography, nint> completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (stringToCheck == null)
		{
			throw new ArgumentNullException("stringToCheck");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(stringToCheck);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity4V0.Handler, completionHandler);
		nint result = ((!base.IsDirectBinding) ? Messaging.nint_objc_msgSendSuper_IntPtr_NSRange_UInt64_IntPtr_nint_IntPtr(base.SuperHandle, selRequestCheckingOfString_Range_Types_Options_InSpellDocumentWithTag_CompletionHandler_Handle, arg, range, (ulong)checkingTypes, options?.Handle ?? IntPtr.Zero, tag, (IntPtr)ptr) : Messaging.nint_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr_nint_IntPtr(base.Handle, selRequestCheckingOfString_Range_Types_Options_InSpellDocumentWithTag_CompletionHandler_Handle, arg, range, (ulong)checkingTypes, options?.Handle ?? IntPtr.Zero, tag, (IntPtr)ptr));
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public nint RequestChecking(string stringToCheck, NSRange range, NSTextCheckingTypes checkingTypes, NSTextCheckingOptions options, nint tag, [BlockProxy(typeof(Trampolines.NIDActionArity4V0))] Action<nint, NSTextCheckingResult[], NSOrthography, nint> completionHandler)
	{
		return RequestChecking(stringToCheck, range, checkingTypes, options.GetDictionary(), tag, completionHandler);
	}

	[Export("setIgnoredWords:inSpellDocumentWithTag:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetIgnoredWords(string[] words, nint documentTag)
	{
		NSApplication.EnsureUIThread();
		if (words == null)
		{
			throw new ArgumentNullException("words");
		}
		NSArray nSArray = NSArray.FromStrings(words);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selSetIgnoredWords_InSpellDocumentWithTag_Handle, nSArray.Handle, documentTag);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selSetIgnoredWords_InSpellDocumentWithTag_Handle, nSArray.Handle, documentTag);
		}
		nSArray.Dispose();
	}

	[Export("setLanguage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	protected virtual bool SetLanguage(string language)
	{
		NSApplication.EnsureUIThread();
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		IntPtr arg = NSString.CreateNative(language);
		bool result = ((!base.IsDirectBinding) ? Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLanguage_Handle, arg) : Messaging.bool_objc_msgSend_IntPtr(base.Handle, selSetLanguage_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("setWordFieldStringValue:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetWordFieldStringValue(string aString)
	{
		NSApplication.EnsureUIThread();
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetWordFieldStringValue_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetWordFieldStringValue_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("showCorrectionIndicatorOfType:primaryString:alternativeStrings:forStringInRect:view:completionHandler:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void ShowCorrectionIndicatorOfType(NSCorrectionIndicatorType type, string primaryString, string[] alternativeStrings, CGRect forStringInRect, NSRulerView view, [BlockProxy(typeof(Trampolines.NIDNSSpellCheckerShowCorrectionIndicatorOfTypeHandler))] NSSpellCheckerShowCorrectionIndicatorOfTypeHandler completionHandler)
	{
		NSApplication.EnsureUIThread();
		if (primaryString == null)
		{
			throw new ArgumentNullException("primaryString");
		}
		if (alternativeStrings == null)
		{
			throw new ArgumentNullException("alternativeStrings");
		}
		if (view == null)
		{
			throw new ArgumentNullException("view");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(primaryString);
		NSArray nSArray = NSArray.FromStrings(alternativeStrings);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSSpellCheckerShowCorrectionIndicatorOfTypeHandler.Handler, completionHandler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_IntPtr_IntPtr_CGRect_IntPtr_IntPtr(base.Handle, selShowCorrectionIndicatorOfType_PrimaryString_AlternativeStrings_ForStringInRect_View_CompletionHandler_Handle, (long)type, arg, nSArray.Handle, forStringInRect, view.Handle, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_IntPtr_IntPtr_CGRect_IntPtr_IntPtr(base.SuperHandle, selShowCorrectionIndicatorOfType_PrimaryString_AlternativeStrings_ForStringInRect_View_CompletionHandler_Handle, (long)type, arg, nSArray.Handle, forStringInRect, view.Handle, (IntPtr)ptr);
		}
		NSString.ReleaseNative(arg);
		nSArray.Dispose();
		ptr->CleanupBlock();
	}

	[Export("unlearnWord:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UnlearnWord(string word)
	{
		NSApplication.EnsureUIThread();
		if (word == null)
		{
			throw new ArgumentNullException("word");
		}
		IntPtr arg = NSString.CreateNative(word);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUnlearnWord_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUnlearnWord_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("updatePanels")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdatePanels()
	{
		NSApplication.EnsureUIThread();
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend(base.Handle, selUpdatePanelsHandle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper(base.SuperHandle, selUpdatePanelsHandle);
		}
	}

	[Export("updateSpellingPanelWithGrammarString:detail:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr(base.Handle, selUpdateSpellingPanelWithGrammarString_Detail_Handle, arg, detail.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selUpdateSpellingPanelWithGrammarString_Detail_Handle, arg, detail.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("updateSpellingPanelWithMisspelledWord:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void UpdateSpellingPanelWithMisspelledWord(string word)
	{
		NSApplication.EnsureUIThread();
		if (word == null)
		{
			throw new ArgumentNullException("word");
		}
		IntPtr arg = NSString.CreateNative(word);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selUpdateSpellingPanelWithMisspelledWord_Handle, arg);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selUpdateSpellingPanelWithMisspelledWord_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("userQuotesArrayForLanguage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string[] UserQuotesArrayForLanguage(string language)
	{
		NSApplication.EnsureUIThread();
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		IntPtr arg = NSString.CreateNative(language);
		string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selUserQuotesArrayForLanguage_Handle, arg)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selUserQuotesArrayForLanguage_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}
}
