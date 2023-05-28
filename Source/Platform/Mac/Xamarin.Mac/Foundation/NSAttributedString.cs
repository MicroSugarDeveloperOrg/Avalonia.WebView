using System;
using System.ComponentModel;
using System.Threading.Tasks;
using AppKit;
using CoreGraphics;
using CoreText;
using ObjCRuntime;
using WebKit;

namespace Foundation;

[Register("NSAttributedString", true)]
public class NSAttributedString : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSMutableCopying, INSSecureCoding, INSPasteboardReading, INSPasteboardWriting
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRTFDFileWrapperFromRange_DocumentAttributes_ = "RTFDFileWrapperFromRange:documentAttributes:";

	private static readonly IntPtr selRTFDFileWrapperFromRange_DocumentAttributes_Handle = Selector.GetHandle("RTFDFileWrapperFromRange:documentAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRTFDFromRange_DocumentAttributes_ = "RTFDFromRange:documentAttributes:";

	private static readonly IntPtr selRTFDFromRange_DocumentAttributes_Handle = Selector.GetHandle("RTFDFromRange:documentAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRTFFromRange_DocumentAttributes_ = "RTFFromRange:documentAttributes:";

	private static readonly IntPtr selRTFFromRange_DocumentAttributes_Handle = Selector.GetHandle("RTFFromRange:documentAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selURLAtIndex_EffectiveRange_ = "URLAtIndex:effectiveRange:";

	private static readonly IntPtr selURLAtIndex_EffectiveRange_Handle = Selector.GetHandle("URLAtIndex:effectiveRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttribute_AtIndex_EffectiveRange_ = "attribute:atIndex:effectiveRange:";

	private static readonly IntPtr selAttribute_AtIndex_EffectiveRange_Handle = Selector.GetHandle("attribute:atIndex:effectiveRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttribute_AtIndex_LongestEffectiveRange_InRange_ = "attribute:atIndex:longestEffectiveRange:inRange:";

	private static readonly IntPtr selAttribute_AtIndex_LongestEffectiveRange_InRange_Handle = Selector.GetHandle("attribute:atIndex:longestEffectiveRange:inRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedStringWithAttachment_ = "attributedStringWithAttachment:";

	private static readonly IntPtr selAttributedStringWithAttachment_Handle = Selector.GetHandle("attributedStringWithAttachment:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributedSubstringFromRange_ = "attributedSubstringFromRange:";

	private static readonly IntPtr selAttributedSubstringFromRange_Handle = Selector.GetHandle("attributedSubstringFromRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributesAtIndex_EffectiveRange_ = "attributesAtIndex:effectiveRange:";

	private static readonly IntPtr selAttributesAtIndex_EffectiveRange_Handle = Selector.GetHandle("attributesAtIndex:effectiveRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAttributesAtIndex_LongestEffectiveRange_InRange_ = "attributesAtIndex:longestEffectiveRange:inRange:";

	private static readonly IntPtr selAttributesAtIndex_LongestEffectiveRange_InRange_Handle = Selector.GetHandle("attributesAtIndex:longestEffectiveRange:inRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBoundingRectWithSize_Options_ = "boundingRectWithSize:options:";

	private static readonly IntPtr selBoundingRectWithSize_Options_Handle = Selector.GetHandle("boundingRectWithSize:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsAttachments = "containsAttachments";

	private static readonly IntPtr selContainsAttachmentsHandle = Selector.GetHandle("containsAttachments");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selContainsAttachmentsInRange_ = "containsAttachmentsInRange:";

	private static readonly IntPtr selContainsAttachmentsInRange_Handle = Selector.GetHandle("containsAttachmentsInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDataFromRange_DocumentAttributes_Error_ = "dataFromRange:documentAttributes:error:";

	private static readonly IntPtr selDataFromRange_DocumentAttributes_Error_Handle = Selector.GetHandle("dataFromRange:documentAttributes:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDocFormatFromRange_DocumentAttributes_ = "docFormatFromRange:documentAttributes:";

	private static readonly IntPtr selDocFormatFromRange_DocumentAttributes_Handle = Selector.GetHandle("docFormatFromRange:documentAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDoubleClickAtIndex_ = "doubleClickAtIndex:";

	private static readonly IntPtr selDoubleClickAtIndex_Handle = Selector.GetHandle("doubleClickAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawAtPoint_ = "drawAtPoint:";

	private static readonly IntPtr selDrawAtPoint_Handle = Selector.GetHandle("drawAtPoint:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawInRect_ = "drawInRect:";

	private static readonly IntPtr selDrawInRect_Handle = Selector.GetHandle("drawInRect:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDrawWithRect_Options_ = "drawWithRect:options:";

	private static readonly IntPtr selDrawWithRect_Options_Handle = Selector.GetHandle("drawWithRect:options:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateAttribute_InRange_Options_UsingBlock_ = "enumerateAttribute:inRange:options:usingBlock:";

	private static readonly IntPtr selEnumerateAttribute_InRange_Options_UsingBlock_Handle = Selector.GetHandle("enumerateAttribute:inRange:options:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateAttributesInRange_Options_UsingBlock_ = "enumerateAttributesInRange:options:usingBlock:";

	private static readonly IntPtr selEnumerateAttributesInRange_Options_UsingBlock_Handle = Selector.GetHandle("enumerateAttributesInRange:options:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFileWrapperFromRange_DocumentAttributes_Error_ = "fileWrapperFromRange:documentAttributes:error:";

	private static readonly IntPtr selFileWrapperFromRange_DocumentAttributes_Error_Handle = Selector.GetHandle("fileWrapperFromRange:documentAttributes:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFontAttributesInRange_ = "fontAttributesInRange:";

	private static readonly IntPtr selFontAttributesInRange_Handle = Selector.GetHandle("fontAttributesInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithAttributedString_ = "initWithAttributedString:";

	private static readonly IntPtr selInitWithAttributedString_Handle = Selector.GetHandle("initWithAttributedString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithData_Options_DocumentAttributes_Error_ = "initWithData:options:documentAttributes:error:";

	private static readonly IntPtr selInitWithData_Options_DocumentAttributes_Error_Handle = Selector.GetHandle("initWithData:options:documentAttributes:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithDocFormat_DocumentAttributes_ = "initWithDocFormat:documentAttributes:";

	private static readonly IntPtr selInitWithDocFormat_DocumentAttributes_Handle = Selector.GetHandle("initWithDocFormat:documentAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithHTML_BaseURL_DocumentAttributes_ = "initWithHTML:baseURL:documentAttributes:";

	private static readonly IntPtr selInitWithHTML_BaseURL_DocumentAttributes_Handle = Selector.GetHandle("initWithHTML:baseURL:documentAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithHTML_DocumentAttributes_ = "initWithHTML:documentAttributes:";

	private static readonly IntPtr selInitWithHTML_DocumentAttributes_Handle = Selector.GetHandle("initWithHTML:documentAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithHTML_Options_DocumentAttributes_ = "initWithHTML:options:documentAttributes:";

	private static readonly IntPtr selInitWithHTML_Options_DocumentAttributes_Handle = Selector.GetHandle("initWithHTML:options:documentAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPath_DocumentAttributes_ = "initWithPath:documentAttributes:";

	private static readonly IntPtr selInitWithPath_DocumentAttributes_Handle = Selector.GetHandle("initWithPath:documentAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRTF_DocumentAttributes_ = "initWithRTF:documentAttributes:";

	private static readonly IntPtr selInitWithRTF_DocumentAttributes_Handle = Selector.GetHandle("initWithRTF:documentAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRTFD_DocumentAttributes_ = "initWithRTFD:documentAttributes:";

	private static readonly IntPtr selInitWithRTFD_DocumentAttributes_Handle = Selector.GetHandle("initWithRTFD:documentAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithRTFDFileWrapper_DocumentAttributes_ = "initWithRTFDFileWrapper:documentAttributes:";

	private static readonly IntPtr selInitWithRTFDFileWrapper_DocumentAttributes_Handle = Selector.GetHandle("initWithRTFDFileWrapper:documentAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithString_ = "initWithString:";

	private static readonly IntPtr selInitWithString_Handle = Selector.GetHandle("initWithString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithString_Attributes_ = "initWithString:attributes:";

	private static readonly IntPtr selInitWithString_Attributes_Handle = Selector.GetHandle("initWithString:attributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_DocumentAttributes_ = "initWithURL:documentAttributes:";

	private static readonly IntPtr selInitWithURL_DocumentAttributes_Handle = Selector.GetHandle("initWithURL:documentAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithURL_Options_DocumentAttributes_Error_ = "initWithURL:options:documentAttributes:error:";

	private static readonly IntPtr selInitWithURL_Options_DocumentAttributes_Error_Handle = Selector.GetHandle("initWithURL:options:documentAttributes:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsEqualToAttributedString_ = "isEqualToAttributedString:";

	private static readonly IntPtr selIsEqualToAttributedString_Handle = Selector.GetHandle("isEqualToAttributedString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selItemNumberInTextList_AtIndex_ = "itemNumberInTextList:atIndex:";

	private static readonly IntPtr selItemNumberInTextList_AtIndex_Handle = Selector.GetHandle("itemNumberInTextList:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLength = "length";

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineBreakBeforeIndex_WithinRange_ = "lineBreakBeforeIndex:withinRange:";

	private static readonly IntPtr selLineBreakBeforeIndex_WithinRange_Handle = Selector.GetHandle("lineBreakBeforeIndex:withinRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLineBreakByHyphenatingBeforeIndex_WithinRange_ = "lineBreakByHyphenatingBeforeIndex:withinRange:";

	private static readonly IntPtr selLineBreakByHyphenatingBeforeIndex_WithinRange_Handle = Selector.GetHandle("lineBreakByHyphenatingBeforeIndex:withinRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadFromHTMLWithData_Options_CompletionHandler_ = "loadFromHTMLWithData:options:completionHandler:";

	private static readonly IntPtr selLoadFromHTMLWithData_Options_CompletionHandler_Handle = Selector.GetHandle("loadFromHTMLWithData:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadFromHTMLWithFileURL_Options_CompletionHandler_ = "loadFromHTMLWithFileURL:options:completionHandler:";

	private static readonly IntPtr selLoadFromHTMLWithFileURL_Options_CompletionHandler_Handle = Selector.GetHandle("loadFromHTMLWithFileURL:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadFromHTMLWithRequest_Options_CompletionHandler_ = "loadFromHTMLWithRequest:options:completionHandler:";

	private static readonly IntPtr selLoadFromHTMLWithRequest_Options_CompletionHandler_Handle = Selector.GetHandle("loadFromHTMLWithRequest:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLoadFromHTMLWithString_Options_CompletionHandler_ = "loadFromHTMLWithString:options:completionHandler:";

	private static readonly IntPtr selLoadFromHTMLWithString_Options_CompletionHandler_Handle = Selector.GetHandle("loadFromHTMLWithString:options:completionHandler:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

	private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNextWordFromIndex_Forward_ = "nextWordFromIndex:forward:";

	private static readonly IntPtr selNextWordFromIndex_Forward_Handle = Selector.GetHandle("nextWordFromIndex:forward:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPasteboardPropertyListForType_ = "pasteboardPropertyListForType:";

	private static readonly IntPtr selPasteboardPropertyListForType_Handle = Selector.GetHandle("pasteboardPropertyListForType:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeOfTextBlock_AtIndex_ = "rangeOfTextBlock:atIndex:";

	private static readonly IntPtr selRangeOfTextBlock_AtIndex_Handle = Selector.GetHandle("rangeOfTextBlock:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeOfTextList_AtIndex_ = "rangeOfTextList:atIndex:";

	private static readonly IntPtr selRangeOfTextList_AtIndex_Handle = Selector.GetHandle("rangeOfTextList:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeOfTextTable_AtIndex_ = "rangeOfTextTable:atIndex:";

	private static readonly IntPtr selRangeOfTextTable_AtIndex_Handle = Selector.GetHandle("rangeOfTextTable:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadableTypesForPasteboard_ = "readableTypesForPasteboard:";

	private static readonly IntPtr selReadableTypesForPasteboard_Handle = Selector.GetHandle("readableTypesForPasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadingOptionsForType_Pasteboard_ = "readingOptionsForType:pasteboard:";

	private static readonly IntPtr selReadingOptionsForType_Pasteboard_Handle = Selector.GetHandle("readingOptionsForType:pasteboard:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRulerAttributesInRange_ = "rulerAttributesInRange:";

	private static readonly IntPtr selRulerAttributesInRange_Handle = Selector.GetHandle("rulerAttributesInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSize = "size";

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selString = "string";

	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

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
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSAttributedString");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _CocoaVersionDocumentAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _SourceTextScalingDocumentAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextLayoutSectionOrientation;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextLayoutSectionRange;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextLayoutSectionsAttribute;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static NSString? _TextScalingDocumentAttribute;

	public string Value => NSString.FromHandle(LowLevelValue);

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ContainsAttachments
	{
		[Export("containsAttachments")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selContainsAttachmentsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selContainsAttachmentsHandle);
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
	public virtual IntPtr LowLevelValue
	{
		[Export("string")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.IntPtr_objc_msgSend(base.Handle, selStringHandle);
			}
			return Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGSize Size
	{
		[Export("size")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
	}

	[Field("NSCocoaVersionDocumentAttribute", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString CocoaVersionDocumentAttribute
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_CocoaVersionDocumentAttribute == null)
			{
				_CocoaVersionDocumentAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSCocoaVersionDocumentAttribute");
			}
			return _CocoaVersionDocumentAttribute;
		}
	}

	[Field("NSSourceTextScalingDocumentAttribute", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString SourceTextScalingDocumentAttribute
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_SourceTextScalingDocumentAttribute == null)
			{
				_SourceTextScalingDocumentAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSourceTextScalingDocumentAttribute");
			}
			return _SourceTextScalingDocumentAttribute;
		}
	}

	[Field("NSTextLayoutSectionOrientation", "AppKit")]
	public static NSString TextLayoutSectionOrientation
	{
		get
		{
			if (_TextLayoutSectionOrientation == null)
			{
				_TextLayoutSectionOrientation = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextLayoutSectionOrientation");
			}
			return _TextLayoutSectionOrientation;
		}
	}

	[Field("NSTextLayoutSectionRange", "AppKit")]
	public static NSString TextLayoutSectionRange
	{
		get
		{
			if (_TextLayoutSectionRange == null)
			{
				_TextLayoutSectionRange = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextLayoutSectionRange");
			}
			return _TextLayoutSectionRange;
		}
	}

	[Field("NSTextLayoutSectionsAttribute", "AppKit")]
	public static NSString TextLayoutSectionsAttribute
	{
		get
		{
			if (_TextLayoutSectionsAttribute == null)
			{
				_TextLayoutSectionsAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextLayoutSectionsAttribute");
			}
			return _TextLayoutSectionsAttribute;
		}
	}

	[Field("NSTextScalingDocumentAttribute", "AppKit")]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	public static NSString TextScalingDocumentAttribute
	{
		[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
		get
		{
			if (_TextScalingDocumentAttribute == null)
			{
				_TextScalingDocumentAttribute = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSTextScalingDocumentAttribute");
			}
			return _TextScalingDocumentAttribute;
		}
	}

	[Field("NSUnderlineByWordMask", "AppKit")]
	[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	public static nint UnderlineByWordMaskAttributeName
	{
		[Unavailable(PlatformName.iOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
		[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
		[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
		get
		{
			return Dlfcn.GetNInt(Libraries.AppKit.Handle, "NSUnderlineByWordMask");
		}
	}

	public NSDictionary GetAttributes(nint location, out NSRange effectiveRange)
	{
		return Runtime.GetNSObject<NSDictionary>(LowLevelGetAttributes(location, out effectiveRange));
	}

	public NSAttributedString(string str, CTStringAttributes attributes)
		: this(str, attributes?.Dictionary)
	{
	}

	public CTStringAttributes GetCoreTextAttributes(nint location, out NSRange effectiveRange)
	{
		NSDictionary attributes = GetAttributes(location, out effectiveRange);
		return (attributes == null) ? null : new CTStringAttributes(attributes);
	}

	public CTStringAttributes GetCoreTextAttributes(nint location, out NSRange longestEffectiveRange, NSRange rangeLimit)
	{
		NSDictionary attributes = GetAttributes(location, out longestEffectiveRange, rangeLimit);
		return (attributes == null) ? null : new CTStringAttributes(attributes);
	}

	public NSAttributedString Substring(nint start, nint len)
	{
		return Substring(new NSRange(start, len));
	}

	public NSAttributedString(string str, NSStringAttributes attributes)
		: this(str, attributes?.Dictionary)
	{
	}

	public NSAttributedString(string str, NSFont font = null, NSColor foregroundColor = null, NSColor backgroundColor = null, NSColor strokeColor = null, NSColor underlineColor = null, NSColor strikethroughColor = null, NSUnderlineStyle underlineStyle = NSUnderlineStyle.None, NSUnderlineStyle strikethroughStyle = NSUnderlineStyle.None, NSParagraphStyle paragraphStyle = null, float strokeWidth = 0f, NSShadow shadow = null, NSUrl link = null, bool superscript = false, NSTextAttachment attachment = null, NSLigatureType ligature = NSLigatureType.Default, float baselineOffset = 0f, float kerningAdjustment = 0f, float obliqueness = 0f, float expansion = 0f, NSCursor cursor = null, string toolTip = null, int characterShape = 0, NSGlyphInfo glyphInfo = null, NSArray writingDirection = null, bool markedClauseSegment = false, NSTextLayoutOrientation verticalGlyphForm = NSTextLayoutOrientation.Horizontal, NSTextAlternatives textAlternatives = null, NSSpellingState spellingState = NSSpellingState.None)
		: this(str, NSStringAttributes.ToDictionary(font, foregroundColor, backgroundColor, strokeColor, underlineColor, strikethroughColor, underlineStyle, strikethroughStyle, paragraphStyle, strokeWidth, shadow, link, superscript, attachment, ligature, baselineOffset, kerningAdjustment, obliqueness, expansion, cursor, toolTip, characterShape, glyphInfo, writingDirection, markedClauseSegment, verticalGlyphForm, textAlternatives, spellingState))
	{
	}

	internal NSAttributedString(NSData data, NSAttributedStringDataType type, out NSDictionary resultDocumentAttributes)
	{
		switch (type)
		{
		case NSAttributedStringDataType.DocFormat:
			base.Handle = new NSAttributedString(data, out resultDocumentAttributes).Handle;
			break;
		case NSAttributedStringDataType.HTML:
			base.Handle = InitWithHTML(data, out resultDocumentAttributes);
			break;
		case NSAttributedStringDataType.RTF:
			base.Handle = InitWithRtf(data, out resultDocumentAttributes);
			break;
		case NSAttributedStringDataType.RTFD:
			base.Handle = InitWithRtfd(data, out resultDocumentAttributes);
			break;
		default:
			throw new ArgumentException("Error creating NSAttributedString.");
		}
		if (base.Handle == IntPtr.Zero)
		{
			throw new ArgumentException("Error creating NSAttributedString.");
		}
	}

	public static NSAttributedString CreateWithRTF(NSData rtfData, out NSDictionary resultDocumentAttributes)
	{
		return new NSAttributedString(rtfData, NSAttributedStringDataType.RTF, out resultDocumentAttributes);
	}

	public static NSAttributedString CreateWithRTFD(NSData rtfdData, out NSDictionary resultDocumentAttributes)
	{
		return new NSAttributedString(rtfdData, NSAttributedStringDataType.RTFD, out resultDocumentAttributes);
	}

	public static NSAttributedString CreateWithHTML(NSData htmlData, out NSDictionary resultDocumentAttributes)
	{
		return new NSAttributedString(htmlData, NSAttributedStringDataType.HTML, out resultDocumentAttributes);
	}

	public static NSAttributedString CreateWithDocFormat(NSData wordDocFormat, out NSDictionary docAttributes)
	{
		return new NSAttributedString(wordDocFormat, NSAttributedStringDataType.DocFormat, out docAttributes);
	}

	public NSStringAttributes GetAppKitAttributes(nint location, out NSRange effectiveRange)
	{
		NSDictionary attributes = GetAttributes(location, out effectiveRange);
		return (attributes == null) ? null : new NSStringAttributes(attributes);
	}

	public NSStringAttributes GetAppKitAttributes(nint location, out NSRange longestEffectiveRange, NSRange rangeLimit)
	{
		NSDictionary attributes = GetAttributes(location, out longestEffectiveRange, rangeLimit);
		return (attributes == null) ? null : new NSStringAttributes(attributes);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAttributedString()
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
	public NSAttributedString(NSCoder coder)
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
	protected NSAttributedString(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSAttributedString(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString(string str)
		: base(NSObjectFlag.Empty)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithString_Handle, arg), "initWithString:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithString_Handle, arg), "initWithString:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithString:attributes:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString(string str, NSDictionary? attributes)
		: base(NSObjectFlag.Empty)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithString_Attributes_Handle, arg, attributes?.Handle ?? IntPtr.Zero), "initWithString:attributes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithString_Attributes_Handle, arg, attributes?.Handle ?? IntPtr.Zero), "initWithString:attributes:");
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithAttributedString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString(NSAttributedString other)
		: base(NSObjectFlag.Empty)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAttributedString_Handle, other.Handle), "initWithAttributedString:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAttributedString_Handle, other.Handle), "initWithAttributedString:");
		}
	}

	[Export("initWithData:options:documentAttributes:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString(NSData data, NSDictionary? options, out NSDictionary docAttributes, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr(base.Handle, selInitWithData_Options_DocumentAttributes_Error_Handle, data.Handle, options?.Handle ?? IntPtr.Zero, ref arg, ref arg2), "initWithData:options:documentAttributes:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithData_Options_DocumentAttributes_Error_Handle, data.Handle, options?.Handle ?? IntPtr.Zero, ref arg, ref arg2), "initWithData:options:documentAttributes:error:");
		}
		docAttributes = Runtime.GetNSObject<NSDictionary>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
	}

	[Export("initWithDocFormat:documentAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString(NSData wordDocFormat, out NSDictionary docAttributes)
		: base(NSObjectFlag.Empty)
	{
		if (wordDocFormat == null)
		{
			throw new ArgumentNullException("wordDocFormat");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithDocFormat_DocumentAttributes_Handle, wordDocFormat.Handle, ref arg), "initWithDocFormat:documentAttributes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithDocFormat_DocumentAttributes_Handle, wordDocFormat.Handle, ref arg), "initWithDocFormat:documentAttributes:");
		}
		docAttributes = Runtime.GetNSObject<NSDictionary>(arg);
	}

	[Export("initWithHTML:baseURL:documentAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString(NSData htmlData, NSUrl baseUrl, out NSDictionary docAttributes)
		: base(NSObjectFlag.Empty)
	{
		if (htmlData == null)
		{
			throw new ArgumentNullException("htmlData");
		}
		if (baseUrl == null)
		{
			throw new ArgumentNullException("baseUrl");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitWithHTML_BaseURL_DocumentAttributes_Handle, htmlData.Handle, baseUrl.Handle, ref arg), "initWithHTML:baseURL:documentAttributes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithHTML_BaseURL_DocumentAttributes_Handle, htmlData.Handle, baseUrl.Handle, ref arg), "initWithHTML:baseURL:documentAttributes:");
		}
		docAttributes = Runtime.GetNSObject<NSDictionary>(arg);
	}

	[Export("initWithURL:options:documentAttributes:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString(NSUrl url, NSDictionary? options, out NSDictionary resultDocumentAttributes, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr(base.Handle, selInitWithURL_Options_DocumentAttributes_Error_Handle, url.Handle, options?.Handle ?? IntPtr.Zero, ref arg, ref arg2), "initWithURL:options:documentAttributes:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithURL_Options_DocumentAttributes_Error_Handle, url.Handle, options?.Handle ?? IntPtr.Zero, ref arg, ref arg2), "initWithURL:options:documentAttributes:error:");
		}
		resultDocumentAttributes = Runtime.GetNSObject<NSDictionary>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString(NSUrl url, NSAttributedStringDocumentAttributes options, out NSDictionary resultDocumentAttributes, out NSError error)
		: this(url, options.GetDictionary(), out resultDocumentAttributes, out error)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString(NSData data, NSAttributedStringDocumentAttributes options, out NSDictionary resultDocumentAttributes, out NSError error)
		: this(data, options.GetDictionary(), out resultDocumentAttributes, out error)
	{
	}

	[Export("initWithPath:documentAttributes:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSAttributedString (NSUrl, NSDictionary, out NSDictionary, ref NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString(string path, out NSDictionary resultDocumentAttributes)
		: base(NSObjectFlag.Empty)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = NSString.CreateNative(path);
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithPath_DocumentAttributes_Handle, arg2, ref arg), "initWithPath:documentAttributes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithPath_DocumentAttributes_Handle, arg2, ref arg), "initWithPath:documentAttributes:");
		}
		NSString.ReleaseNative(arg2);
		resultDocumentAttributes = Runtime.GetNSObject<NSDictionary>(arg);
	}

	[Export("initWithURL:documentAttributes:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSAttributedString (NSUrl, NSDictionary, out NSDictionary, ref NSError)' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString(NSUrl url, out NSDictionary resultDocumentAttributes)
		: base(NSObjectFlag.Empty)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithURL_DocumentAttributes_Handle, url.Handle, ref arg), "initWithURL:documentAttributes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithURL_DocumentAttributes_Handle, url.Handle, ref arg), "initWithURL:documentAttributes:");
		}
		resultDocumentAttributes = Runtime.GetNSObject<NSDictionary>(arg);
	}

	[Export("initWithHTML:options:documentAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString(NSData data, NSDictionary? options, out NSDictionary resultDocumentAttributes)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(base.Handle, selInitWithHTML_Options_DocumentAttributes_Handle, data.Handle, options?.Handle ?? IntPtr.Zero, ref arg), "initWithHTML:options:documentAttributes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithHTML_Options_DocumentAttributes_Handle, data.Handle, options?.Handle ?? IntPtr.Zero, ref arg), "initWithHTML:options:documentAttributes:");
		}
		resultDocumentAttributes = Runtime.GetNSObject<NSDictionary>(arg);
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString(NSData data, NSAttributedStringDocumentAttributes options, out NSDictionary resultDocumentAttributes)
		: this(data, options.GetDictionary(), out resultDocumentAttributes)
	{
	}

	[Export("initWithRTFDFileWrapper:documentAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSAttributedString(NSFileWrapper wrapper, out NSDictionary resultDocumentAttributes)
		: base(NSObjectFlag.Empty)
	{
		if (wrapper == null)
		{
			throw new ArgumentNullException("wrapper");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithRTFDFileWrapper_DocumentAttributes_Handle, wrapper.Handle, ref arg), "initWithRTFDFileWrapper:documentAttributes:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithRTFDFileWrapper_DocumentAttributes_Handle, wrapper.Handle, ref arg), "initWithRTFDFileWrapper:documentAttributes:");
		}
		resultDocumentAttributes = Runtime.GetNSObject<NSDictionary>(arg);
	}

	[Export("boundingRectWithSize:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual CGRect BoundingRectWithSize(CGSize size, NSStringDrawingOptions options)
	{
		CGRect retval;
		if (base.IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_CGSize_UInt64(out retval, base.Handle, selBoundingRectWithSize_Options_Handle, size, (ulong)options);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_CGSize_UInt64(out retval, base.SuperHandle, selBoundingRectWithSize_Options_Handle, size, (ulong)options);
		}
		return retval;
	}

	[Export("containsAttachmentsInRange:")]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ContainsAttachmentsInRange(NSRange range)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_NSRange(base.Handle, selContainsAttachmentsInRange_Handle, range);
		}
		return Messaging.bool_objc_msgSendSuper_NSRange(base.SuperHandle, selContainsAttachmentsInRange_Handle, range);
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

	[Export("doubleClickAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange DoubleClick(nuint index)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nuint(base.Handle, selDoubleClickAtIndex_Handle, index);
		}
		return Messaging.NSRange_objc_msgSendSuper_nuint(base.SuperHandle, selDoubleClickAtIndex_Handle, index);
	}

	[Export("drawAtPoint:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawString(CGPoint point)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selDrawAtPoint_Handle, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selDrawAtPoint_Handle, point);
		}
	}

	[Export("drawInRect:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawString(CGRect rect)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawInRect_Handle, rect);
		}
	}

	[Export("drawWithRect:options:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DrawString(CGRect rect, NSStringDrawingOptions options)
	{
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_UInt64(base.Handle, selDrawWithRect_Options_Handle, rect, (ulong)options);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_UInt64(base.SuperHandle, selDrawWithRect_Options_Handle, rect, (ulong)options);
		}
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

	[Export("enumerateAttribute:inRange:options:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateAttribute(NSString attributeName, NSRange inRange, NSAttributedStringEnumeration options, [BlockProxy(typeof(Trampolines.NIDNSAttributedStringCallback))] NSAttributedStringCallback callback)
	{
		if (attributeName == null)
		{
			throw new ArgumentNullException("attributeName");
		}
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSAttributedStringCallback.Handler, callback);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr(base.Handle, selEnumerateAttribute_InRange_Options_UsingBlock_Handle, attributeName.Handle, inRange, (ulong)options, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange_UInt64_IntPtr(base.SuperHandle, selEnumerateAttribute_InRange_Options_UsingBlock_Handle, attributeName.Handle, inRange, (ulong)options, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("enumerateAttributesInRange:options:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateAttributes(NSRange range, NSAttributedStringEnumeration options, [BlockProxy(typeof(Trampolines.NIDNSAttributedRangeCallback))] NSAttributedRangeCallback callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSAttributedRangeCallback.Handler, callback);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_UInt64_IntPtr(base.Handle, selEnumerateAttributesInRange_Options_UsingBlock_Handle, range, (ulong)options, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_UInt64_IntPtr(base.SuperHandle, selEnumerateAttributesInRange_Options_UsingBlock_Handle, range, (ulong)options, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("attributedStringWithAttachment:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSAttributedString FromAttachment(NSTextAttachment attachment)
	{
		if (attachment == null)
		{
			throw new ArgumentNullException("attachment");
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selAttributedStringWithAttachment_Handle, attachment.Handle));
	}

	[Export("attribute:atIndex:effectiveRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetAttribute(string attribute, nint location, out NSRange effectiveRange)
	{
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		IntPtr arg = NSString.CreateNative(attribute);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_out_NSRange(base.SuperHandle, selAttribute_AtIndex_EffectiveRange_Handle, arg, location, out effectiveRange)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_nint_out_NSRange(base.Handle, selAttribute_AtIndex_EffectiveRange_Handle, arg, location, out effectiveRange)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("attribute:atIndex:longestEffectiveRange:inRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetAttribute(string attribute, nint location, out NSRange longestEffectiveRange, NSRange rangeLimit)
	{
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		IntPtr arg = NSString.CreateNative(attribute);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_nint_out_NSRange_NSRange(base.SuperHandle, selAttribute_AtIndex_LongestEffectiveRange_InRange_Handle, arg, location, out longestEffectiveRange, rangeLimit)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_nint_out_NSRange_NSRange(base.Handle, selAttribute_AtIndex_LongestEffectiveRange_InRange_Handle, arg, location, out longestEffectiveRange, rangeLimit)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("attributesAtIndex:longestEffectiveRange:inRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary GetAttributes(nint location, out NSRange longestEffectiveRange, NSRange rangeLimit)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_nint_out_NSRange_NSRange(base.Handle, selAttributesAtIndex_LongestEffectiveRange_InRange_Handle, location, out longestEffectiveRange, rangeLimit));
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_nint_out_NSRange_NSRange(base.SuperHandle, selAttributesAtIndex_LongestEffectiveRange_InRange_Handle, location, out longestEffectiveRange, rangeLimit));
	}

	[Export("dataFromRange:documentAttributes:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetData(NSRange range, NSDictionary? options, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		NSData result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr_ref_IntPtr(base.SuperHandle, selDataFromRange_DocumentAttributes_Error_Handle, range, options?.Handle ?? IntPtr.Zero, ref arg)) : Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr_ref_IntPtr(base.Handle, selDataFromRange_DocumentAttributes_Error_Handle, range, options?.Handle ?? IntPtr.Zero, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSData GetData(NSRange range, NSAttributedStringDocumentAttributes options, out NSError error)
	{
		return GetData(range, options.GetDictionary(), out error);
	}

	[Export("docFormatFromRange:documentAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetDocFormat(NSRange range, NSDictionary? options)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(base.Handle, selDocFormatFromRange_DocumentAttributes_Handle, range, options?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selDocFormatFromRange_DocumentAttributes_Handle, range, options?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSData GetDocFormat(NSRange range, NSAttributedStringDocumentAttributes options)
	{
		return GetDocFormat(range, options.GetDictionary());
	}

	[Export("fileWrapperFromRange:documentAttributes:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFileWrapper GetFileWrapper(NSRange range, NSDictionary? options, out NSError error)
	{
		IntPtr arg = IntPtr.Zero;
		NSFileWrapper result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSFileWrapper>(Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr_ref_IntPtr(base.SuperHandle, selFileWrapperFromRange_DocumentAttributes_Error_Handle, range, options?.Handle ?? IntPtr.Zero, ref arg)) : Runtime.GetNSObject<NSFileWrapper>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr_ref_IntPtr(base.Handle, selFileWrapperFromRange_DocumentAttributes_Error_Handle, range, options?.Handle ?? IntPtr.Zero, ref arg)));
		error = Runtime.GetNSObject<NSError>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSFileWrapper GetFileWrapper(NSRange range, NSAttributedStringDocumentAttributes options, out NSError error)
	{
		return GetFileWrapper(range, options.GetDictionary(), out error);
	}

	[Export("fontAttributesInRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary GetFontAttributes(NSRange range)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selFontAttributesInRange_Handle, range));
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selFontAttributesInRange_Handle, range));
	}

	[Export("itemNumberInTextList:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nint GetItemNumber(NSTextList textList, nuint index)
	{
		if (textList == null)
		{
			throw new ArgumentNullException("textList");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nint_objc_msgSend_IntPtr_nuint(base.Handle, selItemNumberInTextList_AtIndex_Handle, textList.Handle, index);
		}
		return Messaging.nint_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selItemNumberInTextList_AtIndex_Handle, textList.Handle, index);
	}

	[Export("lineBreakBeforeIndex:withinRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetLineBreak(nuint beforeIndex, NSRange aRange)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nuint_NSRange(base.Handle, selLineBreakBeforeIndex_WithinRange_Handle, beforeIndex, aRange);
		}
		return Messaging.nuint_objc_msgSendSuper_nuint_NSRange(base.SuperHandle, selLineBreakBeforeIndex_WithinRange_Handle, beforeIndex, aRange);
	}

	[Export("lineBreakByHyphenatingBeforeIndex:withinRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetLineBreakByHyphenating(nuint beforeIndex, NSRange aRange)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nuint_NSRange(base.Handle, selLineBreakByHyphenatingBeforeIndex_WithinRange_Handle, beforeIndex, aRange);
		}
		return Messaging.nuint_objc_msgSendSuper_nuint_NSRange(base.SuperHandle, selLineBreakByHyphenatingBeforeIndex_WithinRange_Handle, beforeIndex, aRange);
	}

	[Export("nextWordFromIndex:forward:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetNextWord(nuint fromIndex, bool isForward)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_nuint_bool(base.Handle, selNextWordFromIndex_Forward_Handle, fromIndex, isForward);
		}
		return Messaging.nuint_objc_msgSendSuper_nuint_bool(base.SuperHandle, selNextWordFromIndex_Forward_Handle, fromIndex, isForward);
	}

	[Export("pasteboardPropertyListForType:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSObject GetPasteboardPropertyListForType(string type)
	{
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		IntPtr arg = NSString.CreateNative(type);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selPasteboardPropertyListForType_Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selPasteboardPropertyListForType_Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("rangeOfTextBlock:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetRange(NSTextBlock textBlock, nuint index)
	{
		if (textBlock == null)
		{
			throw new ArgumentNullException("textBlock");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_IntPtr_nuint(base.Handle, selRangeOfTextBlock_AtIndex_Handle, textBlock.Handle, index);
		}
		return Messaging.NSRange_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selRangeOfTextBlock_AtIndex_Handle, textBlock.Handle, index);
	}

	[Export("rangeOfTextTable:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetRange(NSTextTable textTable, nuint index)
	{
		if (textTable == null)
		{
			throw new ArgumentNullException("textTable");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_IntPtr_nuint(base.Handle, selRangeOfTextTable_AtIndex_Handle, textTable.Handle, index);
		}
		return Messaging.NSRange_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selRangeOfTextTable_AtIndex_Handle, textTable.Handle, index);
	}

	[Export("rangeOfTextList:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetRange(NSTextList textList, nuint index)
	{
		if (textList == null)
		{
			throw new ArgumentNullException("textList");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_IntPtr_nuint(base.Handle, selRangeOfTextList_AtIndex_Handle, textList.Handle, index);
		}
		return Messaging.NSRange_objc_msgSendSuper_IntPtr_nuint(base.SuperHandle, selRangeOfTextList_AtIndex_Handle, textList.Handle, index);
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
		IntPtr arg = NSString.CreateNative(type);
		NSPasteboardReadingOptions result = (NSPasteboardReadingOptions)Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(class_ptr, selReadingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle);
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("RTFFromRange:documentAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetRtf(NSRange range, NSDictionary? options)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(base.Handle, selRTFFromRange_DocumentAttributes_Handle, range, options?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selRTFFromRange_DocumentAttributes_Handle, range, options?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSData GetRtf(NSRange range, NSAttributedStringDocumentAttributes options)
	{
		return GetRtf(range, options.GetDictionary());
	}

	[Export("RTFDFromRange:documentAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetRtfd(NSRange range, NSDictionary? options)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(base.Handle, selRTFDFromRange_DocumentAttributes_Handle, range, options?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selRTFDFromRange_DocumentAttributes_Handle, range, options?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSData GetRtfd(NSRange range, NSAttributedStringDocumentAttributes options)
	{
		return GetRtfd(range, options.GetDictionary());
	}

	[Export("RTFDFileWrapperFromRange:documentAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSFileWrapper GetRtfdFileWrapper(NSRange range, NSDictionary? options)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSFileWrapper>(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(base.Handle, selRTFDFileWrapperFromRange_DocumentAttributes_Handle, range, options?.Handle ?? IntPtr.Zero));
		}
		return Runtime.GetNSObject<NSFileWrapper>(Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selRTFDFileWrapperFromRange_DocumentAttributes_Handle, range, options?.Handle ?? IntPtr.Zero));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSFileWrapper GetRtfdFileWrapper(NSRange range, NSAttributedStringDocumentAttributes options)
	{
		return GetRtfdFileWrapper(range, options.GetDictionary());
	}

	[Export("rulerAttributesInRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSDictionary GetRulerAttributes(NSRange range)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selRulerAttributesInRange_Handle, range));
		}
		return Runtime.GetNSObject<NSDictionary>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selRulerAttributesInRange_Handle, range));
	}

	[Export("URLAtIndex:effectiveRange:")]
	[Deprecated(PlatformName.MacOSX, 10, 11, PlatformArchitecture.None, "Use 'NSDataDetector' instead.")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSUrl GetUrl(nuint index, out NSRange effectiveRange)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSend_nuint_out_NSRange(base.Handle, selURLAtIndex_EffectiveRange_Handle, index, out effectiveRange));
		}
		return Runtime.GetNSObject<NSUrl>(Messaging.IntPtr_objc_msgSendSuper_nuint_out_NSRange(base.SuperHandle, selURLAtIndex_EffectiveRange_Handle, index, out effectiveRange));
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
		IntPtr arg = NSString.CreateNative(type);
		NSPasteboardWritingOptions result = (NSPasteboardWritingOptions)((!base.IsDirectBinding) ? Messaging.UInt64_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selWritingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle) : Messaging.UInt64_objc_msgSend_IntPtr_IntPtr(base.Handle, selWritingOptionsForType_Pasteboard_Handle, arg, pasteboard.Handle));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithHTML:documentAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithHTML(NSData data, out NSDictionary resultDocumentAttributes)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithHTML_DocumentAttributes_Handle, data.Handle, ref arg) : Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithHTML_DocumentAttributes_Handle, data.Handle, ref arg));
		resultDocumentAttributes = Runtime.GetNSObject<NSDictionary>(arg);
		return result;
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
		IntPtr arg = NSString.CreateNative(type);
		NSObject result = ((!base.IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selXamarinselector_Removed_Handle, propertyList.Handle, arg)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selXamarinselector_Removed_Handle, propertyList.Handle, arg)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("initWithRTF:documentAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithRtf(NSData data, out NSDictionary resultDocumentAttributes)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithRTF_DocumentAttributes_Handle, data.Handle, ref arg) : Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithRTF_DocumentAttributes_Handle, data.Handle, ref arg));
		resultDocumentAttributes = Runtime.GetNSObject<NSDictionary>(arg);
		return result;
	}

	[Export("initWithRTFD:documentAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual IntPtr InitWithRtfd(NSData data, out NSDictionary resultDocumentAttributes)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr result = ((!base.IsDirectBinding) ? Messaging.IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr(base.SuperHandle, selInitWithRTFD_DocumentAttributes_Handle, data.Handle, ref arg) : Messaging.IntPtr_objc_msgSend_IntPtr_ref_IntPtr(base.Handle, selInitWithRTFD_DocumentAttributes_Handle, data.Handle, ref arg));
		resultDocumentAttributes = Runtime.GetNSObject<NSDictionary>(arg);
		return result;
	}

	[Export("isEqualToAttributedString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsEqual(NSAttributedString other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToAttributedString_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToAttributedString_Handle, other.Handle);
	}

	[Export("loadFromHTMLWithRequest:options:completionHandler:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void LoadFromHtml(NSUrlRequest request, NSDictionary options, [BlockProxy(typeof(Trampolines.NIDNSAttributedStringCompletionHandler))] NSAttributedStringCompletionHandler completionHandler)
	{
		if (request == null)
		{
			throw new ArgumentNullException("request");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSAttributedStringCompletionHandler.Handler, completionHandler);
		GC.KeepAlive(WKContentMode.Recommended);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selLoadFromHTMLWithRequest_Options_CompletionHandler_Handle, request.Handle, options.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync(NSUrlRequest request, NSDictionary options)
	{
		TaskCompletionSource<NSLoadFromHtmlResult> tcs = new TaskCompletionSource<NSLoadFromHtmlResult>();
		LoadFromHtml(request, options, delegate(NSAttributedString? attributedString_, NSDictionary<NSString, NSObject>? attributes_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSLoadFromHtmlResult(attributedString_, attributes_));
			}
		});
		return tcs.Task;
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LoadFromHtml(NSUrlRequest request, NSAttributedStringDocumentAttributes options, [BlockProxy(typeof(Trampolines.NIDNSAttributedStringCompletionHandler))] NSAttributedStringCompletionHandler completionHandler)
	{
		LoadFromHtml(request, options.GetDictionary(), completionHandler);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync(NSUrlRequest request, NSAttributedStringDocumentAttributes options)
	{
		TaskCompletionSource<NSLoadFromHtmlResult> tcs = new TaskCompletionSource<NSLoadFromHtmlResult>();
		LoadFromHtml(request, options, delegate(NSAttributedString? attributedString_, NSDictionary<NSString, NSObject>? attributes_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSLoadFromHtmlResult(attributedString_, attributes_));
			}
		});
		return tcs.Task;
	}

	[Export("loadFromHTMLWithFileURL:options:completionHandler:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void LoadFromHtml(NSUrl fileUrl, NSDictionary options, [BlockProxy(typeof(Trampolines.NIDNSAttributedStringCompletionHandler))] NSAttributedStringCompletionHandler completionHandler)
	{
		if (fileUrl == null)
		{
			throw new ArgumentNullException("fileUrl");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSAttributedStringCompletionHandler.Handler, completionHandler);
		GC.KeepAlive(WKContentMode.Recommended);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selLoadFromHTMLWithFileURL_Options_CompletionHandler_Handle, fileUrl.Handle, options.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync(NSUrl fileUrl, NSDictionary options)
	{
		TaskCompletionSource<NSLoadFromHtmlResult> tcs = new TaskCompletionSource<NSLoadFromHtmlResult>();
		LoadFromHtml(fileUrl, options, delegate(NSAttributedString? attributedString_, NSDictionary<NSString, NSObject>? attributes_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSLoadFromHtmlResult(attributedString_, attributes_));
			}
		});
		return tcs.Task;
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LoadFromHtml(NSUrl fileUrl, NSAttributedStringDocumentAttributes options, [BlockProxy(typeof(Trampolines.NIDNSAttributedStringCompletionHandler))] NSAttributedStringCompletionHandler completionHandler)
	{
		LoadFromHtml(fileUrl, options.GetDictionary(), completionHandler);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync(NSUrl fileUrl, NSAttributedStringDocumentAttributes options)
	{
		TaskCompletionSource<NSLoadFromHtmlResult> tcs = new TaskCompletionSource<NSLoadFromHtmlResult>();
		LoadFromHtml(fileUrl, options, delegate(NSAttributedString? attributedString_, NSDictionary<NSString, NSObject>? attributes_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSLoadFromHtmlResult(attributedString_, attributes_));
			}
		});
		return tcs.Task;
	}

	[Export("loadFromHTMLWithString:options:completionHandler:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void LoadFromHtml(string @string, NSDictionary options, [BlockProxy(typeof(Trampolines.NIDNSAttributedStringCompletionHandler))] NSAttributedStringCompletionHandler completionHandler)
	{
		if (@string == null)
		{
			throw new ArgumentNullException("@string");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		IntPtr arg = NSString.CreateNative(@string);
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSAttributedStringCompletionHandler.Handler, completionHandler);
		GC.KeepAlive(WKContentMode.Recommended);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selLoadFromHTMLWithString_Options_CompletionHandler_Handle, arg, options.Handle, (IntPtr)ptr);
		NSString.ReleaseNative(arg);
		ptr->CleanupBlock();
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync(string @string, NSDictionary options)
	{
		TaskCompletionSource<NSLoadFromHtmlResult> tcs = new TaskCompletionSource<NSLoadFromHtmlResult>();
		LoadFromHtml(@string, options, delegate(NSAttributedString? attributedString_, NSDictionary<NSString, NSObject>? attributes_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSLoadFromHtmlResult(attributedString_, attributes_));
			}
		});
		return tcs.Task;
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LoadFromHtml(string @string, NSAttributedStringDocumentAttributes options, [BlockProxy(typeof(Trampolines.NIDNSAttributedStringCompletionHandler))] NSAttributedStringCompletionHandler completionHandler)
	{
		LoadFromHtml(@string, options.GetDictionary(), completionHandler);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync(string @string, NSAttributedStringDocumentAttributes options)
	{
		TaskCompletionSource<NSLoadFromHtmlResult> tcs = new TaskCompletionSource<NSLoadFromHtmlResult>();
		LoadFromHtml(@string, options, delegate(NSAttributedString? attributedString_, NSDictionary<NSString, NSObject>? attributes_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSLoadFromHtmlResult(attributedString_, attributes_));
			}
		});
		return tcs.Task;
	}

	[Export("loadFromHTMLWithData:options:completionHandler:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void LoadFromHtml(NSData data, NSDictionary options, [BlockProxy(typeof(Trampolines.NIDNSAttributedStringCompletionHandler))] NSAttributedStringCompletionHandler completionHandler)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		if (completionHandler == null)
		{
			throw new ArgumentNullException("completionHandler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSAttributedStringCompletionHandler.Handler, completionHandler);
		GC.KeepAlive(WKContentMode.Recommended);
		Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr(class_ptr, selLoadFromHTMLWithData_Options_CompletionHandler_Handle, data.Handle, options.Handle, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync(NSData data, NSDictionary options)
	{
		TaskCompletionSource<NSLoadFromHtmlResult> tcs = new TaskCompletionSource<NSLoadFromHtmlResult>();
		LoadFromHtml(data, options, delegate(NSAttributedString? attributedString_, NSDictionary<NSString, NSObject>? attributes_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSLoadFromHtmlResult(attributedString_, attributes_));
			}
		});
		return tcs.Task;
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void LoadFromHtml(NSData data, NSAttributedStringDocumentAttributes options, [BlockProxy(typeof(Trampolines.NIDNSAttributedStringCompletionHandler))] NSAttributedStringCompletionHandler completionHandler)
	{
		LoadFromHtml(data, options.GetDictionary(), completionHandler);
	}

	[Unavailable(PlatformName.WatchOS, PlatformArchitecture.All, null)]
	[Unavailable(PlatformName.TvOS, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static Task<NSLoadFromHtmlResult> LoadFromHtmlAsync(NSData data, NSAttributedStringDocumentAttributes options)
	{
		TaskCompletionSource<NSLoadFromHtmlResult> tcs = new TaskCompletionSource<NSLoadFromHtmlResult>();
		LoadFromHtml(data, options, delegate(NSAttributedString? attributedString_, NSDictionary<NSString, NSObject>? attributes_, NSError? error_)
		{
			if (error_ != null)
			{
				tcs.SetException(new NSErrorException(error_));
			}
			else
			{
				tcs.SetResult(new NSLoadFromHtmlResult(attributedString_, attributes_));
			}
		});
		return tcs.Task;
	}

	[Export("attributesAtIndex:effectiveRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual IntPtr LowLevelGetAttributes(nint location, out NSRange effectiveRange)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.IntPtr_objc_msgSend_nint_out_NSRange(base.Handle, selAttributesAtIndex_EffectiveRange_Handle, location, out effectiveRange);
		}
		return Messaging.IntPtr_objc_msgSendSuper_nint_out_NSRange(base.SuperHandle, selAttributesAtIndex_EffectiveRange_Handle, location, out effectiveRange);
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

	[Export("attributedSubstringFromRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual NSAttributedString Substring(NSRange range)
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selAttributedSubstringFromRange_Handle, range));
		}
		return Runtime.GetNSObject<NSAttributedString>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selAttributedSubstringFromRange_Handle, range));
	}
}
