using System;
using System.ComponentModel;
using AppKit;
using CloudKit;
using System.Runtime.InteropServices;
using CoreGraphics;
using ObjCRuntime;
namespace Foundation;

[Register("NSString", true)]
public class NSString : NSObject, IComparable<NSString>, INSCoding, INativeObject, IDisposable, INSCopying, INSItemProviderReading, INSItemProviderWriting, INSMutableCopying, INSSecureCoding, INSPasteboardReading, INSPasteboardWriting, ICKRecordValue
{
    private const string selDataUsingEncodingAllow = "dataUsingEncoding:allowLossyConversion:";

    private static IntPtr selDataUsingEncodingAllowHandle = Selector.GetHandle("dataUsingEncoding:allowLossyConversion:");

    private const string selUTF8String = "UTF8String";

    private const string selInitWithCharactersLength = "initWithCharacters:length:";

    private static IntPtr selUTF8StringHandle = Selector.GetHandle("UTF8String");

    private static IntPtr selInitWithCharactersLengthHandle = Selector.GetHandle("initWithCharacters:length:");

    public static readonly NSString Empty = new NSString(string.Empty);

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selBoundingRectWithSize_Options_Attributes_ = "boundingRectWithSize:options:attributes:";

    private static readonly IntPtr selBoundingRectWithSize_Options_Attributes_Handle = Selector.GetHandle("boundingRectWithSize:options:attributes:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCapitalizedStringWithLocale_ = "capitalizedStringWithLocale:";

    private static readonly IntPtr selCapitalizedStringWithLocale_Handle = Selector.GetHandle("capitalizedStringWithLocale:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCharacterAtIndex_ = "characterAtIndex:";

    private static readonly IntPtr selCharacterAtIndex_Handle = Selector.GetHandle("characterAtIndex:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCommonPrefixWithString_Options_ = "commonPrefixWithString:options:";

    private static readonly IntPtr selCommonPrefixWithString_Options_Handle = Selector.GetHandle("commonPrefixWithString:options:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCompare_ = "compare:";

    private static readonly IntPtr selCompare_Handle = Selector.GetHandle("compare:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCompare_Options_ = "compare:options:";

    private static readonly IntPtr selCompare_Options_Handle = Selector.GetHandle("compare:options:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCompare_Options_Range_ = "compare:options:range:";

    private static readonly IntPtr selCompare_Options_Range_Handle = Selector.GetHandle("compare:options:range:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCompare_Options_Range_Locale_ = "compare:options:range:locale:";

    private static readonly IntPtr selCompare_Options_Range_Locale_Handle = Selector.GetHandle("compare:options:range:locale:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selComponentsSeparatedByCharactersInSet_ = "componentsSeparatedByCharactersInSet:";

    private static readonly IntPtr selComponentsSeparatedByCharactersInSet_Handle = Selector.GetHandle("componentsSeparatedByCharactersInSet:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selComponentsSeparatedByString_ = "componentsSeparatedByString:";

    private static readonly IntPtr selComponentsSeparatedByString_Handle = Selector.GetHandle("componentsSeparatedByString:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selContainsString_ = "containsString:";

    private static readonly IntPtr selContainsString_Handle = Selector.GetHandle("containsString:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selCopyWithZone_ = "copyWithZone:";

    private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDrawAtPoint_WithAttributes_ = "drawAtPoint:withAttributes:";

    private static readonly IntPtr selDrawAtPoint_WithAttributes_Handle = Selector.GetHandle("drawAtPoint:withAttributes:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDrawInRect_WithAttributes_ = "drawInRect:withAttributes:";

    private static readonly IntPtr selDrawInRect_WithAttributes_Handle = Selector.GetHandle("drawInRect:withAttributes:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selDrawWithRect_Options_Attributes_ = "drawWithRect:options:attributes:";

    private static readonly IntPtr selDrawWithRect_Options_Attributes_Handle = Selector.GetHandle("drawWithRect:options:attributes:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selEncodeWithCoder_ = "encodeWithCoder:";

    private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selGetLineStart_End_ContentsEnd_ForRange_ = "getLineStart:end:contentsEnd:forRange:";

    private static readonly IntPtr selGetLineStart_End_ContentsEnd_ForRange_Handle = Selector.GetHandle("getLineStart:end:contentsEnd:forRange:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selGetParagraphStart_End_ContentsEnd_ForRange_ = "getParagraphStart:end:contentsEnd:forRange:";

    private static readonly IntPtr selGetParagraphStart_End_ContentsEnd_ForRange_Handle = Selector.GetHandle("getParagraphStart:end:contentsEnd:forRange:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selHasPrefix_ = "hasPrefix:";

    private static readonly IntPtr selHasPrefix_Handle = Selector.GetHandle("hasPrefix:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selHasSuffix_ = "hasSuffix:";

    private static readonly IntPtr selHasSuffix_Handle = Selector.GetHandle("hasSuffix:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithCoder_ = "initWithCoder:";

    private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selInitWithData_Encoding_ = "initWithData:encoding:";

    private static readonly IntPtr selInitWithData_Encoding_Handle = Selector.GetHandle("initWithData:encoding:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selIsAbsolutePath = "isAbsolutePath";

    private static readonly IntPtr selIsAbsolutePathHandle = Selector.GetHandle("isAbsolutePath");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selIsEqualToString_ = "isEqualToString:";

    private static readonly IntPtr selIsEqualToString_Handle = Selector.GetHandle("isEqualToString:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selItemProviderVisibilityForRepresentationWithTypeIdentifier_ = "itemProviderVisibilityForRepresentationWithTypeIdentifier:";

    private static readonly IntPtr selItemProviderVisibilityForRepresentationWithTypeIdentifier_Handle = Selector.GetHandle("itemProviderVisibilityForRepresentationWithTypeIdentifier:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLastPathComponent = "lastPathComponent";

    private static readonly IntPtr selLastPathComponentHandle = Selector.GetHandle("lastPathComponent");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLength = "length";

    private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLineRangeForRange_ = "lineRangeForRange:";

    private static readonly IntPtr selLineRangeForRange_Handle = Selector.GetHandle("lineRangeForRange:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_ = "loadDataWithTypeIdentifier:forItemProviderCompletionHandler:";

    private static readonly IntPtr selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_Handle = Selector.GetHandle("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLocalizedCapitalizedString = "localizedCapitalizedString";

    private static readonly IntPtr selLocalizedCapitalizedStringHandle = Selector.GetHandle("localizedCapitalizedString");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLocalizedCaseInsensitiveContainsString_ = "localizedCaseInsensitiveContainsString:";

    private static readonly IntPtr selLocalizedCaseInsensitiveContainsString_Handle = Selector.GetHandle("localizedCaseInsensitiveContainsString:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLocalizedLowercaseString = "localizedLowercaseString";

    private static readonly IntPtr selLocalizedLowercaseStringHandle = Selector.GetHandle("localizedLowercaseString");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLocalizedStandardContainsString_ = "localizedStandardContainsString:";

    private static readonly IntPtr selLocalizedStandardContainsString_Handle = Selector.GetHandle("localizedStandardContainsString:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLocalizedStandardRangeOfString_ = "localizedStandardRangeOfString:";

    private static readonly IntPtr selLocalizedStandardRangeOfString_Handle = Selector.GetHandle("localizedStandardRangeOfString:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLocalizedUppercaseString = "localizedUppercaseString";

    private static readonly IntPtr selLocalizedUppercaseStringHandle = Selector.GetHandle("localizedUppercaseString");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLocalizedUserNotificationStringForKey_Arguments_ = "localizedUserNotificationStringForKey:arguments:";

    private static readonly IntPtr selLocalizedUserNotificationStringForKey_Arguments_Handle = Selector.GetHandle("localizedUserNotificationStringForKey:arguments:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selLowercaseStringWithLocale_ = "lowercaseStringWithLocale:";

    private static readonly IntPtr selLowercaseStringWithLocale_Handle = Selector.GetHandle("lowercaseStringWithLocale:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

    private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selObjectWithItemProviderData_TypeIdentifier_Error_ = "objectWithItemProviderData:typeIdentifier:error:";

    private static readonly IntPtr selObjectWithItemProviderData_TypeIdentifier_Error_Handle = Selector.GetHandle("objectWithItemProviderData:typeIdentifier:error:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selParagraphRangeForRange_ = "paragraphRangeForRange:";

    private static readonly IntPtr selParagraphRangeForRange_Handle = Selector.GetHandle("paragraphRangeForRange:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selPasteboardPropertyListForType_ = "pasteboardPropertyListForType:";

    private static readonly IntPtr selPasteboardPropertyListForType_Handle = Selector.GetHandle("pasteboardPropertyListForType:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selPathComponents = "pathComponents";

    private static readonly IntPtr selPathComponentsHandle = Selector.GetHandle("pathComponents");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selPathExtension = "pathExtension";

    private static readonly IntPtr selPathExtensionHandle = Selector.GetHandle("pathExtension");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selPathWithComponents_ = "pathWithComponents:";

    private static readonly IntPtr selPathWithComponents_Handle = Selector.GetHandle("pathWithComponents:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selReadableTypeIdentifiersForItemProvider = "readableTypeIdentifiersForItemProvider";

    private static readonly IntPtr selReadableTypeIdentifiersForItemProviderHandle = Selector.GetHandle("readableTypeIdentifiersForItemProvider");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selReadableTypesForPasteboard_ = "readableTypesForPasteboard:";

    private static readonly IntPtr selReadableTypesForPasteboard_Handle = Selector.GetHandle("readableTypesForPasteboard:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selReadingOptionsForType_Pasteboard_ = "readingOptionsForType:pasteboard:";

    private static readonly IntPtr selReadingOptionsForType_Pasteboard_Handle = Selector.GetHandle("readingOptionsForType:pasteboard:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selSizeWithAttributes_ = "sizeWithAttributes:";

    private static readonly IntPtr selSizeWithAttributes_Handle = Selector.GetHandle("sizeWithAttributes:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selStringByAbbreviatingWithTildeInPath = "stringByAbbreviatingWithTildeInPath";

    private static readonly IntPtr selStringByAbbreviatingWithTildeInPathHandle = Selector.GetHandle("stringByAbbreviatingWithTildeInPath");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selStringByAppendingPathComponent_ = "stringByAppendingPathComponent:";

    private static readonly IntPtr selStringByAppendingPathComponent_Handle = Selector.GetHandle("stringByAppendingPathComponent:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selStringByAppendingPathExtension_ = "stringByAppendingPathExtension:";

    private static readonly IntPtr selStringByAppendingPathExtension_Handle = Selector.GetHandle("stringByAppendingPathExtension:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selStringByApplyingTransform_Reverse_ = "stringByApplyingTransform:reverse:";

    private static readonly IntPtr selStringByApplyingTransform_Reverse_Handle = Selector.GetHandle("stringByApplyingTransform:reverse:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selStringByDeletingLastPathComponent = "stringByDeletingLastPathComponent";

    private static readonly IntPtr selStringByDeletingLastPathComponentHandle = Selector.GetHandle("stringByDeletingLastPathComponent");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selStringByDeletingPathExtension = "stringByDeletingPathExtension";

    private static readonly IntPtr selStringByDeletingPathExtensionHandle = Selector.GetHandle("stringByDeletingPathExtension");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selStringByExpandingTildeInPath = "stringByExpandingTildeInPath";

    private static readonly IntPtr selStringByExpandingTildeInPathHandle = Selector.GetHandle("stringByExpandingTildeInPath");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selStringByReplacingCharactersInRange_WithString_ = "stringByReplacingCharactersInRange:withString:";

    private static readonly IntPtr selStringByReplacingCharactersInRange_WithString_Handle = Selector.GetHandle("stringByReplacingCharactersInRange:withString:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selStringByResolvingSymlinksInPath = "stringByResolvingSymlinksInPath";

    private static readonly IntPtr selStringByResolvingSymlinksInPathHandle = Selector.GetHandle("stringByResolvingSymlinksInPath");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selStringByStandardizingPath = "stringByStandardizingPath";

    private static readonly IntPtr selStringByStandardizingPathHandle = Selector.GetHandle("stringByStandardizingPath");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selStringEncodingForData_EncodingOptions_ConvertedString_UsedLossyConversion_ = "stringEncodingForData:encodingOptions:convertedString:usedLossyConversion:";

    private static readonly IntPtr selStringEncodingForData_EncodingOptions_ConvertedString_UsedLossyConversion_Handle = Selector.GetHandle("stringEncodingForData:encodingOptions:convertedString:usedLossyConversion:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selStringsByAppendingPaths_ = "stringsByAppendingPaths:";

    private static readonly IntPtr selStringsByAppendingPaths_Handle = Selector.GetHandle("stringsByAppendingPaths:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selUppercaseStringWithLocale_ = "uppercaseStringWithLocale:";

    private static readonly IntPtr selUppercaseStringWithLocale_Handle = Selector.GetHandle("uppercaseStringWithLocale:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selVariantFittingPresentationWidth_ = "variantFittingPresentationWidth:";

    private static readonly IntPtr selVariantFittingPresentationWidth_Handle = Selector.GetHandle("variantFittingPresentationWidth:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selWritableTypeIdentifiersForItemProvider = "writableTypeIdentifiersForItemProvider";

    private static readonly IntPtr selWritableTypeIdentifiersForItemProviderHandle = Selector.GetHandle("writableTypeIdentifiersForItemProvider");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selWritableTypesForPasteboard_ = "writableTypesForPasteboard:";

    private static readonly IntPtr selWritableTypesForPasteboard_Handle = Selector.GetHandle("writableTypesForPasteboard:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selWritingOptionsForType_Pasteboard_ = "writingOptionsForType:pasteboard:";

    private static readonly IntPtr selWritingOptionsForType_Pasteboard_Handle = Selector.GetHandle("writingOptionsForType:pasteboard:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private const string selXamarinselector_Removed_ = "xamarinselector:removed:";

    private static readonly IntPtr selXamarinselector_Removed_Handle = Selector.GetHandle("xamarinselector:removed:");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSString");

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _EncodingDetectionAllowLossyKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _EncodingDetectionDisallowedEncodingsKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _EncodingDetectionFromWindowsKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _EncodingDetectionLikelyLanguageKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _EncodingDetectionLossySubstitutionKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _EncodingDetectionSuggestedEncodingsKey;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    private static NSString? _EncodingDetectionUseOnlySuggestedEncodingsKey;

    public char this[nint idx] => _characterAtIndex(idx);

    public override IntPtr ClassHandle => class_ptr;

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool IsAbsolutePath
    {
        [Export("isAbsolutePath")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.bool_objc_msgSend(base.Handle, selIsAbsolutePathHandle);
            }
            return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAbsolutePathHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSString LastPathComponent
    {
        [Export("lastPathComponent")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selLastPathComponentHandle));
            }
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastPathComponentHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual nint Length
    {
        [Export("length")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Messaging.nint_objc_msgSend(base.Handle, selLengthHandle);
            }
            return Messaging.nint_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
    public virtual NSString LocalizedCapitalizedString
    {
        [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
        [Export("localizedCapitalizedString")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedCapitalizedStringHandle));
            }
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedCapitalizedStringHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
    public virtual NSString LocalizedLowercaseString
    {
        [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
        [Export("localizedLowercaseString")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedLowercaseStringHandle));
            }
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedLowercaseStringHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
    public virtual NSString LocalizedUppercaseString
    {
        [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
        [Export("localizedUppercaseString")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selLocalizedUppercaseStringHandle));
            }
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLocalizedUppercaseStringHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string[] PathComponents
    {
        [Export("pathComponents")]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPathComponentsHandle));
            }
            return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathComponentsHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSString PathExtension
    {
        [Export("pathExtension")]
        get
        {
            if (base.IsDirectBinding)
            {
                return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selPathExtensionHandle));
            }
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathExtensionHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
    public static string[] ReadableTypeIdentifiers
    {
        [Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
        [Export("readableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
        get
        {
            return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selReadableTypeIdentifiersForItemProviderHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
    public static string[] WritableTypeIdentifiers
    {
        [Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
        [Export("writableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
        get
        {
            return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(class_ptr, selWritableTypeIdentifiersForItemProviderHandle));
        }
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
    public virtual string[] WritableTypeIdentifiersForItemProvider
    {
        [Export("writableTypeIdentifiersForItemProvider", ArgumentSemantic.Copy)]
        get
        {
            if (base.IsDirectBinding)
            {
                return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selWritableTypeIdentifiersForItemProviderHandle));
            }
            return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selWritableTypeIdentifiersForItemProviderHandle));
        }
    }

    [Field("NSStringEncodingDetectionAllowLossyKey", "Foundation")]
    [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
    internal static NSString EncodingDetectionAllowLossyKey
    {
        [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
        get
        {
            if (_EncodingDetectionAllowLossyKey == null)
            {
                _EncodingDetectionAllowLossyKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStringEncodingDetectionAllowLossyKey");
            }
            return _EncodingDetectionAllowLossyKey;
        }
    }

    [Field("NSStringEncodingDetectionDisallowedEncodingsKey", "Foundation")]
    [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
    internal static NSString EncodingDetectionDisallowedEncodingsKey
    {
        [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
        get
        {
            if (_EncodingDetectionDisallowedEncodingsKey == null)
            {
                _EncodingDetectionDisallowedEncodingsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStringEncodingDetectionDisallowedEncodingsKey");
            }
            return _EncodingDetectionDisallowedEncodingsKey;
        }
    }

    [Field("NSStringEncodingDetectionFromWindowsKey", "Foundation")]
    [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
    internal static NSString EncodingDetectionFromWindowsKey
    {
        [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
        get
        {
            if (_EncodingDetectionFromWindowsKey == null)
            {
                _EncodingDetectionFromWindowsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStringEncodingDetectionFromWindowsKey");
            }
            return _EncodingDetectionFromWindowsKey;
        }
    }

    [Field("NSStringEncodingDetectionLikelyLanguageKey", "Foundation")]
    [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
    internal static NSString EncodingDetectionLikelyLanguageKey
    {
        [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
        get
        {
            if (_EncodingDetectionLikelyLanguageKey == null)
            {
                _EncodingDetectionLikelyLanguageKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStringEncodingDetectionLikelyLanguageKey");
            }
            return _EncodingDetectionLikelyLanguageKey;
        }
    }

    [Field("NSStringEncodingDetectionLossySubstitutionKey", "Foundation")]
    [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
    internal static NSString EncodingDetectionLossySubstitutionKey
    {
        [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
        get
        {
            if (_EncodingDetectionLossySubstitutionKey == null)
            {
                _EncodingDetectionLossySubstitutionKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStringEncodingDetectionLossySubstitutionKey");
            }
            return _EncodingDetectionLossySubstitutionKey;
        }
    }

    [Field("NSStringEncodingDetectionSuggestedEncodingsKey", "Foundation")]
    [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
    internal static NSString EncodingDetectionSuggestedEncodingsKey
    {
        [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
        get
        {
            if (_EncodingDetectionSuggestedEncodingsKey == null)
            {
                _EncodingDetectionSuggestedEncodingsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStringEncodingDetectionSuggestedEncodingsKey");
            }
            return _EncodingDetectionSuggestedEncodingsKey;
        }
    }

    [Field("NSStringEncodingDetectionUseOnlySuggestedEncodingsKey", "Foundation")]
    [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
    internal static NSString EncodingDetectionUseOnlySuggestedEncodingsKey
    {
        [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
        [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
        get
        {
            if (_EncodingDetectionUseOnlySuggestedEncodingsKey == null)
            {
                _EncodingDetectionUseOnlySuggestedEncodingsKey = Dlfcn.GetStringConstant(Libraries.Foundation.Handle, "NSStringEncodingDetectionUseOnlySuggestedEncodingsKey");
            }
            return _EncodingDetectionUseOnlySuggestedEncodingsKey;
        }
    }

    public NSData Encode(NSStringEncoding enc, bool allowLossyConversion = false)
    {
        return new NSData(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selDataUsingEncodingAllowHandle, (IntPtr)(int)enc, allowLossyConversion));
    }

    public static NSString FromData(NSData data, NSStringEncoding encoding)
    {
        if (data == null)
        {
            throw new ArgumentNullException("data");
        }
        NSString result = null;
        try
        {
            result = new NSString(data, encoding);
        }
        catch (Exception)
        {
        }
        return result;
    }

    public int CompareTo(NSString other)
    {
        return (int)Compare(other);
    }

    internal NSString(IntPtr handle, bool alloced)
        : base(handle, alloced)
    {
    }

    private unsafe static IntPtr CreateWithCharacters(IntPtr handle, string str, int offset, int length, bool autorelease = false)
    {
        fixed (char* ptr = str)
        {
            IntPtr arg = (IntPtr)(ptr + offset);
            handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(handle, selInitWithCharactersLengthHandle, arg, (IntPtr)length);
            if (autorelease)
            {
                NSObject.DangerousAutorelease(handle);
            }
            return handle;
        }
    }

    public static IntPtr CreateNative(string str)
    {
        return CreateNative(str, autorelease: false);
    }

    public static IntPtr CreateNative(string str, bool autorelease)
    {
        if (str == null)
        {
            return IntPtr.Zero;
        }
        return CreateNative(str, 0, str.Length, autorelease);
    }

    public static IntPtr CreateNative(string value, int start, int length)
    {
        return CreateNative(value, start, length, autorelease: false);
    }

    public static IntPtr CreateNative(string value, int start, int length, bool autorelease)
    {
        if (value == null)
        {
            return IntPtr.Zero;
        }
        if (start < 0 || start > value.Length)
        {
            throw new ArgumentOutOfRangeException("start");
        }
        if (length < 0 || start > value.Length - length)
        {
            throw new ArgumentOutOfRangeException("length");
        }
        IntPtr intPtr = Messaging.IntPtr_objc_msgSend(class_ptr, Selector.AllocHandle);
        return CreateWithCharacters(intPtr, value, start, length, autorelease);
    }

    public static void ReleaseNative(IntPtr handle)
    {
        NSObject.DangerousRelease(handle);
    }

    public NSString(string str)
    {
        if (str == null)
        {
            throw new ArgumentNullException("str");
        }
        base.Handle = CreateWithCharacters(base.Handle, str, 0, str.Length);
    }

    public NSString(string value, int start, int length)
    {
        if (value == null)
        {
            throw new ArgumentNullException("value");
        }
        if (start < 0 || start > value.Length)
        {
            throw new ArgumentOutOfRangeException("start");
        }
        if (length < 0 || start > value.Length - length)
        {
            throw new ArgumentOutOfRangeException("length");
        }
        base.Handle = CreateWithCharacters(base.Handle, value, start, length);
    }

    public override string ToString()
    {
        return FromHandle(base.Handle);
    }

    public static implicit operator string(NSString str)
    {
        return str?.ToString();
    }

    public static explicit operator NSString(string str)
    {
        if (str == null)
        {
            return null;
        }
        return new NSString(str);
    }

    public static string FromHandle(IntPtr usrhandle)
    {
        if (usrhandle == IntPtr.Zero)
        {
            return null;
        }
        return Marshal.PtrToStringAuto(Messaging.IntPtr_objc_msgSend(usrhandle, selUTF8StringHandle));
    }

    public static bool Equals(NSString a, NSString b)
    {
        if ((object)a == b)
        {
            return true;
        }
        if ((object)a == null || (object)b == null)
        {
            return false;
        }
        if (a.Handle == b.Handle)
        {
            return true;
        }
        return a.IsEqualTo(b.Handle);
    }

    public static bool operator ==(NSString a, NSString b)
    {
        return Equals(a, b);
    }

    public static bool operator !=(NSString a, NSString b)
    {
        return !Equals(a, b);
    }

    public override bool Equals(object obj)
    {
        return Equals(this, obj as NSString);
    }

    [DllImport("__Internal")]
    private static extern IntPtr xamarin_localized_string_format(IntPtr fmt);

    [DllImport("__Internal")]
    private static extern IntPtr xamarin_localized_string_format_1(IntPtr fmt, IntPtr arg1);

    [DllImport("__Internal")]
    private static extern IntPtr xamarin_localized_string_format_2(IntPtr fmt, IntPtr arg1, IntPtr arg2);

    [DllImport("__Internal")]
    private static extern IntPtr xamarin_localized_string_format_3(IntPtr fmt, IntPtr arg1, IntPtr arg2, IntPtr arg3);

    [DllImport("__Internal")]
    private static extern IntPtr xamarin_localized_string_format_4(IntPtr fmt, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

    [DllImport("__Internal")]
    private static extern IntPtr xamarin_localized_string_format_5(IntPtr fmt, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

    [DllImport("__Internal")]
    private static extern IntPtr xamarin_localized_string_format_6(IntPtr fmt, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

    [DllImport("__Internal")]
    private static extern IntPtr xamarin_localized_string_format_7(IntPtr fmt, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);

    [DllImport("__Internal")]
    private static extern IntPtr xamarin_localized_string_format_8(IntPtr fmt, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

    [DllImport("__Internal")]
    private static extern IntPtr xamarin_localized_string_format_9(IntPtr fmt, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9);

    public static NSString LocalizedFormat(string format, params object[] args)
    {
        using NSString format2 = new NSString(format);
        return LocalizedFormat(format2, args);
    }

    public static NSString LocalizedFormat(NSString format, params object[] args)
    {
        int num = args.Length;
        NSObject[] array = new NSObject[num];
        for (int i = 0; i < num; i++)
        {
            array[i] = NSObject.FromObject(args[i]);
        }
        return LocalizedFormat(format, array);
    }

    public static NSString LocalizedFormat(NSString format, NSObject[] args)
    {
        return args.Length switch
        {
            0 => new NSString(xamarin_localized_string_format(format.Handle)),
            1 => new NSString(xamarin_localized_string_format_1(format.Handle, args[0].Handle)),
            2 => new NSString(xamarin_localized_string_format_2(format.Handle, args[0].Handle, args[1].Handle)),
            3 => new NSString(xamarin_localized_string_format_3(format.Handle, args[0].Handle, args[1].Handle, args[2].Handle)),
            4 => new NSString(xamarin_localized_string_format_4(format.Handle, args[0].Handle, args[1].Handle, args[2].Handle, args[3].Handle)),
            5 => new NSString(xamarin_localized_string_format_5(format.Handle, args[0].Handle, args[1].Handle, args[2].Handle, args[3].Handle, args[4].Handle)),
            6 => new NSString(xamarin_localized_string_format_6(format.Handle, args[0].Handle, args[1].Handle, args[2].Handle, args[3].Handle, args[4].Handle, args[5].Handle)),
            7 => new NSString(xamarin_localized_string_format_7(format.Handle, args[0].Handle, args[1].Handle, args[2].Handle, args[3].Handle, args[4].Handle, args[5].Handle, args[6].Handle)),
            8 => new NSString(xamarin_localized_string_format_8(format.Handle, args[0].Handle, args[1].Handle, args[2].Handle, args[3].Handle, args[4].Handle, args[5].Handle, args[6].Handle, args[7].Handle)),
            9 => new NSString(xamarin_localized_string_format_9(format.Handle, args[0].Handle, args[1].Handle, args[2].Handle, args[3].Handle, args[4].Handle, args[5].Handle, args[6].Handle, args[7].Handle, args[8].Handle)),
            _ => throw new Exception("Unsupported number of arguments, maximum number is 9"),
        };
    }

    public NSString TransliterateString(NSStringTransform transform, bool reverse)
    {
        return TransliterateString(transform.GetConstant(), reverse);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [DesignatedInitializer]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Export("init")]
    public NSString()
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
    public NSString(NSCoder coder)
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
    protected NSString(NSObjectFlag t)
        : base(t)
    {
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    protected internal NSString(IntPtr handle)
        : base(handle)
    {
    }

    [Export("initWithData:encoding:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public NSString(NSData data, NSStringEncoding encoding)
        : base(NSObjectFlag.Empty)
    {
        if (data == null)
        {
            throw new ArgumentNullException("data");
        }
        if (base.IsDirectBinding)
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selInitWithData_Encoding_Handle, data.Handle, (ulong)encoding), "initWithData:encoding:");
        }
        else
        {
            InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selInitWithData_Encoding_Handle, data.Handle, (ulong)encoding), "initWithData:encoding:");
        }
    }

    [Export("stringByAbbreviatingWithTildeInPath")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSString AbbreviateTildeInPath()
    {
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selStringByAbbreviatingWithTildeInPathHandle));
        }
        return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringByAbbreviatingWithTildeInPathHandle));
    }

    [Export("stringByAppendingPathComponent:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSString AppendPathComponent(NSString str)
    {
        if (str == null)
        {
            throw new ArgumentNullException("str");
        }
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringByAppendingPathComponent_Handle, str.Handle));
        }
        return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringByAppendingPathComponent_Handle, str.Handle));
    }

    [Export("stringByAppendingPathExtension:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSString AppendPathExtension(NSString str)
    {
        if (str == null)
        {
            throw new ArgumentNullException("str");
        }
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringByAppendingPathExtension_Handle, str.Handle));
        }
        return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringByAppendingPathExtension_Handle, str.Handle));
    }

    [Export("stringsByAppendingPaths:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string[] AppendPaths(string[] paths)
    {
        if (paths == null)
        {
            throw new ArgumentNullException("paths");
        }
        NSArray nSArray = NSArray.FromStrings(paths);
        string[] result = ((!base.IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringsByAppendingPaths_Handle, nSArray.Handle)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringsByAppendingPaths_Handle, nSArray.Handle)));
        nSArray.Dispose();
        return result;
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public CGRect BoundingRectWithSize(CGSize size, NSStringDrawingOptions options, NSDictionary attributes)
    {
        if (attributes == null)
        {
            throw new ArgumentNullException("attributes");
        }
        Messaging.CGRect_objc_msgSend_stret_CGSize_UInt64_IntPtr(out var retval, base.Handle, selBoundingRectWithSize_Options_Attributes_Handle, size, (ulong)options, attributes.Handle);
        return retval;
    }

    [Export("capitalizedStringWithLocale:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string Capitalize(NSLocale? locale)
    {
        if (base.IsDirectBinding)
        {
            return FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCapitalizedStringWithLocale_Handle, locale?.Handle ?? IntPtr.Zero));
        }
        return FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCapitalizedStringWithLocale_Handle, locale?.Handle ?? IntPtr.Zero));
    }

    [Export("commonPrefixWithString:options:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSString CommonPrefix(NSString aString, NSStringCompareOptions options)
    {
        if (aString == null)
        {
            throw new ArgumentNullException("aString");
        }
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64(base.Handle, selCommonPrefixWithString_Options_Handle, aString.Handle, (ulong)options));
        }
        return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selCommonPrefixWithString_Options_Handle, aString.Handle, (ulong)options));
    }

    [Export("compare:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSComparisonResult Compare(NSString aString)
    {
        if (aString == null)
        {
            throw new ArgumentNullException("aString");
        }
        if (base.IsDirectBinding)
        {
            return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selCompare_Handle, aString.Handle);
        }
        return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompare_Handle, aString.Handle);
    }

    [Export("compare:options:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSComparisonResult Compare(NSString aString, NSStringCompareOptions mask)
    {
        if (aString == null)
        {
            throw new ArgumentNullException("aString");
        }
        if (base.IsDirectBinding)
        {
            return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr_UInt64(base.Handle, selCompare_Options_Handle, aString.Handle, (ulong)mask);
        }
        return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr_UInt64(base.SuperHandle, selCompare_Options_Handle, aString.Handle, (ulong)mask);
    }

    [Export("compare:options:range:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSComparisonResult Compare(NSString aString, NSStringCompareOptions mask, NSRange range)
    {
        if (aString == null)
        {
            throw new ArgumentNullException("aString");
        }
        if (base.IsDirectBinding)
        {
            return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr_UInt64_NSRange(base.Handle, selCompare_Options_Range_Handle, aString.Handle, (ulong)mask, range);
        }
        return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr_UInt64_NSRange(base.SuperHandle, selCompare_Options_Range_Handle, aString.Handle, (ulong)mask, range);
    }

    [Export("compare:options:range:locale:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSComparisonResult Compare(NSString aString, NSStringCompareOptions mask, NSRange range, NSLocale? locale)
    {
        if (aString == null)
        {
            throw new ArgumentNullException("aString");
        }
        if (base.IsDirectBinding)
        {
            return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr_UInt64_NSRange_IntPtr(base.Handle, selCompare_Options_Range_Locale_Handle, aString.Handle, (ulong)mask, range, locale?.Handle ?? IntPtr.Zero);
        }
        return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr_UInt64_NSRange_IntPtr(base.SuperHandle, selCompare_Options_Range_Locale_Handle, aString.Handle, (ulong)mask, range, locale?.Handle ?? IntPtr.Zero);
    }

    [Export("containsString:")]
    [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool Contains(NSString str)
    {
        if (str == null)
        {
            throw new ArgumentNullException("str");
        }
        if (base.IsDirectBinding)
        {
            return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selContainsString_Handle, str.Handle);
        }
        return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selContainsString_Handle, str.Handle);
    }

    [Export("copyWithZone:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [return: Release]
    public virtual NSObject Copy(NSZone? zone)
    {
        NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
        if (nSObject != null)
        {
            Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
        }
        return nSObject;
    }

    [Export("stringByDeletingLastPathComponent")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSString DeleteLastPathComponent()
    {
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selStringByDeletingLastPathComponentHandle));
        }
        return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringByDeletingLastPathComponentHandle));
    }

    [Export("stringByDeletingPathExtension")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSString DeletePathExtension()
    {
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selStringByDeletingPathExtensionHandle));
        }
        return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringByDeletingPathExtensionHandle));
    }

    [Export("stringEncodingForData:encodingOptions:convertedString:usedLossyConversion:")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static nuint DetectStringEncoding(NSData rawData, NSDictionary options, out string convertedString, out bool usedLossyConversion)
    {
        if (rawData == null)
        {
            throw new ArgumentNullException("rawData");
        }
        if (options == null)
        {
            throw new ArgumentNullException("options");
        }
        IntPtr arg = IntPtr.Zero;
        nuint result = Messaging.nuint_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_out_Boolean(class_ptr, selStringEncodingForData_EncodingOptions_ConvertedString_UsedLossyConversion_Handle, rawData.Handle, options.Handle, ref arg, out usedLossyConversion);
        convertedString = FromHandle(arg);
        return result;
    }

    [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static nuint DetectStringEncoding(NSData rawData, EncodingDetectionOptions options, out string convertedString, out bool usedLossyConversion)
    {
        return DetectStringEncoding(rawData, options.GetDictionary(), out convertedString, out usedLossyConversion);
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public void DrawString(CGPoint point, NSDictionary attributes)
    {
        if (attributes == null)
        {
            throw new ArgumentNullException("attributes");
        }
        Messaging.void_objc_msgSend_CGPoint_IntPtr(base.Handle, selDrawAtPoint_WithAttributes_Handle, point, attributes.Handle);
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public void DrawString(CGRect rect, NSDictionary attributes)
    {
        if (attributes == null)
        {
            throw new ArgumentNullException("attributes");
        }
        Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawInRect_WithAttributes_Handle, rect, attributes.Handle);
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public void DrawString(CGRect rect, NSStringDrawingOptions options, NSDictionary attributes)
    {
        if (attributes == null)
        {
            throw new ArgumentNullException("attributes");
        }
        Messaging.void_objc_msgSend_CGRect_UInt64_IntPtr(base.Handle, selDrawWithRect_Options_Attributes_Handle, rect, (ulong)options, attributes.Handle);
    }

    [Export("encodeWithCoder:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual void EncodeTo(NSCoder encoder)
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

    [Export("stringByExpandingTildeInPath")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSString ExpandTildeInPath()
    {
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selStringByExpandingTildeInPathHandle));
        }
        return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringByExpandingTildeInPathHandle));
    }

    [Export("itemProviderVisibilityForRepresentationWithTypeIdentifier:")]
    [Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSItemProviderRepresentationVisibility GetItemProviderVisibilityForTypeIdentifier(string typeIdentifier)
    {
        if (typeIdentifier == null)
        {
            throw new ArgumentNullException("typeIdentifier");
        }
        IntPtr arg = CreateNative(typeIdentifier);
        NSItemProviderRepresentationVisibility result = (NSItemProviderRepresentationVisibility)((!base.IsDirectBinding) ? Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selItemProviderVisibilityForRepresentationWithTypeIdentifier_Handle, arg) : Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selItemProviderVisibilityForRepresentationWithTypeIdentifier_Handle, arg));
        ReleaseNative(arg);
        return result;
    }

    [Export("getLineStart:end:contentsEnd:forRange:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual void GetLineStart(out nuint startPtr, out nuint lineEndPtr, out nuint contentsEndPtr, NSRange range)
    {
        if (base.IsDirectBinding)
        {
            Messaging.void_objc_msgSend_out_nuint_out_nuint_out_nuint_NSRange(base.Handle, selGetLineStart_End_ContentsEnd_ForRange_Handle, out startPtr, out lineEndPtr, out contentsEndPtr, range);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_out_nuint_out_nuint_out_nuint_NSRange(base.SuperHandle, selGetLineStart_End_ContentsEnd_ForRange_Handle, out startPtr, out lineEndPtr, out contentsEndPtr, range);
        }
    }

    [Export("localizedUserNotificationStringForKey:arguments:")]
    [Introduced(PlatformName.iOS, 10, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.WatchOS, 3, 0, PlatformArchitecture.All, null)]
    [Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSString GetLocalizedUserNotificationString(NSString key, params NSObject[]? arguments)
    {
        if (key == null)
        {
            throw new ArgumentNullException("key");
        }
        NSArray nSArray = ((arguments == null) ? null : NSArray.FromNSObjects(arguments));
        NSString nSObject = Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(class_ptr, selLocalizedUserNotificationStringForKey_Arguments_Handle, key.Handle, nSArray?.Handle ?? IntPtr.Zero));
        nSArray?.Dispose();
        return nSObject;
    }

    [Export("objectWithItemProviderData:typeIdentifier:error:")]
    [Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSString? GetObject(NSData data, string typeIdentifier, out NSError? outError)
    {
        if (data == null)
        {
            throw new ArgumentNullException("data");
        }
        if (typeIdentifier == null)
        {
            throw new ArgumentNullException("typeIdentifier");
        }
        IntPtr arg = IntPtr.Zero;
        IntPtr arg2 = CreateNative(typeIdentifier);
        NSString nSObject = Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(class_ptr, selObjectWithItemProviderData_TypeIdentifier_Error_Handle, data.Handle, arg2, ref arg));
        ReleaseNative(arg2);
        outError = Runtime.GetNSObject<NSError>(arg);
        return nSObject;
    }

    [Export("getParagraphStart:end:contentsEnd:forRange:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual void GetParagraphPositions(out nuint paragraphStartPosition, out nuint paragraphEndPosition, out nuint contentsEndPosition, NSRange range)
    {
        if (base.IsDirectBinding)
        {
            Messaging.void_objc_msgSend_out_nuint_out_nuint_out_nuint_NSRange(base.Handle, selGetParagraphStart_End_ContentsEnd_ForRange_Handle, out paragraphStartPosition, out paragraphEndPosition, out contentsEndPosition, range);
        }
        else
        {
            Messaging.void_objc_msgSendSuper_out_nuint_out_nuint_out_nuint_NSRange(base.SuperHandle, selGetParagraphStart_End_ContentsEnd_ForRange_Handle, out paragraphStartPosition, out paragraphEndPosition, out contentsEndPosition, range);
        }
    }

    [Export("paragraphRangeForRange:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSRange GetParagraphRange(NSRange range)
    {
        if (base.IsDirectBinding)
        {
            return Messaging.NSRange_objc_msgSend_NSRange(base.Handle, selParagraphRangeForRange_Handle, range);
        }
        return Messaging.NSRange_objc_msgSendSuper_NSRange(base.SuperHandle, selParagraphRangeForRange_Handle, range);
    }

    [Export("pasteboardPropertyListForType:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSObject GetPasteboardPropertyListForType(string type)
    {
        if (type == null)
        {
            throw new ArgumentNullException("type");
        }
        IntPtr arg = CreateNative(type);
        NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteboardPropertyListForType_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPasteboardPropertyListForType_Handle, arg)));
        ReleaseNative(arg);
        return result;
    }

    [Export("readableTypesForPasteboard:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static string[] GetReadableTypesForPasteboard(NSPasteboard pasteboard)
    {
        if (pasteboard == null)
        {
            throw new ArgumentNullException("pasteboard");
        }
        return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selReadableTypesForPasteboard_Handle, pasteboard.Handle));
    }

    [Export("readingOptionsForType:pasteboard:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static NSPasteboardReadingOptions GetReadingOptionsForType(string type, NSPasteboard pasteboard)
    {
        if (type == null)
        {
            throw new ArgumentNullException("type");
        }
        if (pasteboard == null)
        {
            throw new ArgumentNullException("pasteboard");
        }
        IntPtr arg = CreateNative(type);
        NSPasteboardReadingOptions result = (NSPasteboardReadingOptions)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(class_ptr, selReadingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle);
        ReleaseNative(arg);
        return result;
    }

    [Export("variantFittingPresentationWidth:")]
    [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSString GetVariantFittingPresentationWidth(nint width)
    {
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selVariantFittingPresentationWidth_Handle, width));
        }
        return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selVariantFittingPresentationWidth_Handle, width));
    }

    [Export("writableTypesForPasteboard:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string[] GetWritableTypesForPasteboard(NSPasteboard pasteboard)
    {
        if (pasteboard == null)
        {
            throw new ArgumentNullException("pasteboard");
        }
        if (base.IsDirectBinding)
        {
            return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selWritableTypesForPasteboard_Handle, pasteboard.Handle));
        }
        return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selWritableTypesForPasteboard_Handle, pasteboard.Handle));
    }

    [Export("writingOptionsForType:pasteboard:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSPasteboardWritingOptions GetWritingOptionsForType(string type, NSPasteboard pasteboard)
    {
        if (type == null)
        {
            throw new ArgumentNullException("type");
        }
        if (pasteboard == null)
        {
            throw new ArgumentNullException("pasteboard");
        }
        IntPtr arg = CreateNative(type);
        NSPasteboardWritingOptions result = (NSPasteboardWritingOptions)((!base.IsDirectBinding) ? Messaging.UInt64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWritingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle) : Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(base.Handle, selWritingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle));
        ReleaseNative(arg);
        return result;
    }

    [Export("hasPrefix:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool HasPrefix(NSString prefix)
    {
        if (prefix == null)
        {
            throw new ArgumentNullException("prefix");
        }
        if (base.IsDirectBinding)
        {
            return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasPrefix_Handle, prefix.Handle);
        }
        return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasPrefix_Handle, prefix.Handle);
    }

    [Export("hasSuffix:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool HasSuffix(NSString suffix)
    {
        if (suffix == null)
        {
            throw new ArgumentNullException("suffix");
        }
        if (base.IsDirectBinding)
        {
            return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selHasSuffix_Handle, suffix.Handle);
        }
        return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selHasSuffix_Handle, suffix.Handle);
    }

    [Export("xamarinselector:removed:")]
    [Obsolete("It will never be called.", false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSObject InitWithPasteboardPropertyList(NSObject propertyList, string type)
    {
        if (propertyList == null)
        {
            throw new ArgumentNullException("propertyList");
        }
        if (type == null)
        {
            throw new ArgumentNullException("type");
        }
        IntPtr arg = CreateNative(type);
        NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selXamarinselector_Removed_Handle, propertyList.Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selXamarinselector_Removed_Handle, propertyList.Handle, arg)));
        ReleaseNative(arg);
        return result;
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public bool IsEqualTo(IntPtr handle)
    {
        return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToString_Handle, handle);
    }

    [Export("lineRangeForRange:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSRange LineRangeForRange(NSRange range)
    {
        if (base.IsDirectBinding)
        {
            return Messaging.NSRange_objc_msgSend_NSRange(base.Handle, selLineRangeForRange_Handle, range);
        }
        return Messaging.NSRange_objc_msgSendSuper_NSRange(base.SuperHandle, selLineRangeForRange_Handle, range);
    }

    [Export("loadDataWithTypeIdentifier:forItemProviderCompletionHandler:")]
    [Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public unsafe virtual NSProgress? LoadData(string typeIdentifier, [BlockProxy(typeof(Trampolines.NIDActionArity2V3))] Action<NSData, NSError> completionHandler)
    {
        if (typeIdentifier == null)
        {
            throw new ArgumentNullException("typeIdentifier");
        }
        if (completionHandler == null)
        {
            throw new ArgumentNullException("completionHandler");
        }
        IntPtr arg = CreateNative(typeIdentifier);
        BlockLiteral blockLiteral = default(BlockLiteral);
        BlockLiteral* ptr = &blockLiteral;
        blockLiteral.SetupBlockUnsafe(Trampolines.SDActionArity2V3.Handler, completionHandler);
        NSProgress result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_Handle, arg, (IntPtr)ptr)) : Runtime.GetNSObject<NSProgress>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selLoadDataWithTypeIdentifier_ForItemProviderCompletionHandler_Handle, arg, (IntPtr)ptr)));
        ReleaseNative(arg);
        ptr->CleanupBlock();
        return result;
    }

    [Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual Task<NSData> LoadDataAsync(string typeIdentifier)
    {
        TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
        LoadData(typeIdentifier, delegate (NSData arg1_, NSError arg2_)
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

    [Introduced(PlatformName.WatchOS, 4, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.TvOS, 11, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 13, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.iOS, 11, 0, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual Task<NSData> LoadDataAsync(string typeIdentifier, out NSProgress result)
    {
        TaskCompletionSource<NSData> tcs = new TaskCompletionSource<NSData>();
        result = LoadData(typeIdentifier, delegate (NSData arg1_, NSError arg2_)
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

    [Export("localizedCaseInsensitiveContainsString:")]
    [Introduced(PlatformName.iOS, 8, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 10, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool LocalizedCaseInsensitiveContains(NSString str)
    {
        if (str == null)
        {
            throw new ArgumentNullException("str");
        }
        if (base.IsDirectBinding)
        {
            return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selLocalizedCaseInsensitiveContainsString_Handle, str.Handle);
        }
        return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selLocalizedCaseInsensitiveContainsString_Handle, str.Handle);
    }

    [Export("localizedStandardContainsString:")]
    [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual bool LocalizedStandardContainsString(NSString str)
    {
        if (str == null)
        {
            throw new ArgumentNullException("str");
        }
        if (base.IsDirectBinding)
        {
            return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selLocalizedStandardContainsString_Handle, str.Handle);
        }
        return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selLocalizedStandardContainsString_Handle, str.Handle);
    }

    [Export("localizedStandardRangeOfString:")]
    [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSRange LocalizedStandardRangeOfString(NSString str)
    {
        if (str == null)
        {
            throw new ArgumentNullException("str");
        }
        if (base.IsDirectBinding)
        {
            return Messaging.NSRange_objc_msgSend_IntPtr(base.Handle, selLocalizedStandardRangeOfString_Handle, str.Handle);
        }
        return Messaging.NSRange_objc_msgSendSuper_IntPtr(base.SuperHandle, selLocalizedStandardRangeOfString_Handle, str.Handle);
    }

    [Export("mutableCopyWithZone:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    [return: Release]
    public virtual NSObject MutableCopy(NSZone? zone)
    {
        NSObject nSObject = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selMutableCopyWithZone_Handle, zone?.Handle ?? IntPtr.Zero)));
        if (nSObject != null)
        {
            Messaging.void_objc_msgSend(nSObject.Handle, Selector.GetHandle("release"));
        }
        return nSObject;
    }

    [Export("pathWithComponents:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public static string[] PathWithComponents(string[] components)
    {
        if (components == null)
        {
            throw new ArgumentNullException("components");
        }
        NSArray nSArray = NSArray.FromStrings(components);
        string[] result = NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selPathWithComponents_Handle, nSArray.Handle));
        nSArray.Dispose();
        return result;
    }

    [Export("stringByReplacingCharactersInRange:withString:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSString Replace(NSRange range, NSString replacement)
    {
        if (replacement == null)
        {
            throw new ArgumentNullException("replacement");
        }
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(base.Handle, selStringByReplacingCharactersInRange_WithString_Handle, range, replacement.Handle));
        }
        return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selStringByReplacingCharactersInRange_WithString_Handle, range, replacement.Handle));
    }

    [Export("stringByResolvingSymlinksInPath")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSString ResolveSymlinksInPath()
    {
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selStringByResolvingSymlinksInPathHandle));
        }
        return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringByResolvingSymlinksInPathHandle));
    }

    [Export("componentsSeparatedByString:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSString[] SeparateComponents(NSString separator)
    {
        if (separator == null)
        {
            throw new ArgumentNullException("separator");
        }
        if (base.IsDirectBinding)
        {
            return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selComponentsSeparatedByString_Handle, separator.Handle));
        }
        return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selComponentsSeparatedByString_Handle, separator.Handle));
    }

    [Export("componentsSeparatedByCharactersInSet:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSString[] SeparateComponents(NSCharacterSet separator)
    {
        if (separator == null)
        {
            throw new ArgumentNullException("separator");
        }
        if (base.IsDirectBinding)
        {
            return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selComponentsSeparatedByCharactersInSet_Handle, separator.Handle));
        }
        return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selComponentsSeparatedByCharactersInSet_Handle, separator.Handle));
    }

    [Export("stringByStandardizingPath")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSString StandarizePath()
    {
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selStringByStandardizingPathHandle));
        }
        return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringByStandardizingPathHandle));
    }

    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public CGSize StringSize(NSDictionary? attributedStringAttributes)
    {
        return Messaging.CGSize_objc_msgSend_IntPtr(base.Handle, selSizeWithAttributes_Handle, attributedStringAttributes?.Handle ?? IntPtr.Zero);
    }

    [Export("lowercaseStringWithLocale:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string ToLower(NSLocale locale)
    {
        if (locale == null)
        {
            throw new ArgumentNullException("locale");
        }
        if (base.IsDirectBinding)
        {
            return FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLowercaseStringWithLocale_Handle, locale.Handle));
        }
        return FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLowercaseStringWithLocale_Handle, locale.Handle));
    }

    [Export("uppercaseStringWithLocale:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual string ToUpper(NSLocale locale)
    {
        if (locale == null)
        {
            throw new ArgumentNullException("locale");
        }
        if (base.IsDirectBinding)
        {
            return FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selUppercaseStringWithLocale_Handle, locale.Handle));
        }
        return FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selUppercaseStringWithLocale_Handle, locale.Handle));
    }

    [Export("stringByApplyingTransform:reverse:")]
    [Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
    [Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    public virtual NSString? TransliterateString(NSString transform, bool reverse)
    {
        if (transform == null)
        {
            throw new ArgumentNullException("transform");
        }
        if (base.IsDirectBinding)
        {
            return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr_bool(base.Handle, selStringByApplyingTransform_Reverse_Handle, transform.Handle, reverse));
        }
        return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_bool(base.SuperHandle, selStringByApplyingTransform_Reverse_Handle, transform.Handle, reverse));
    }

    [Export("characterAtIndex:")]
    [BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
    internal virtual char _characterAtIndex(nint index)
    {
        if (base.IsDirectBinding)
        {
            return Messaging.Char_objc_msgSend_nint(base.Handle, selCharacterAtIndex_Handle, index);
        }
        return Messaging.Char_objc_msgSendSuper_nint(base.SuperHandle, selCharacterAtIndex_Handle, index);
    }
}

