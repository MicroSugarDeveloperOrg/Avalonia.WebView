using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace AppKit;

[Register("NSLayoutManager", true)]
public class NSLayoutManager : NSObject
{
	private static readonly IntPtr selAttributedStringHandle = Selector.GetHandle("attributedString");

	private static readonly IntPtr selTextContainersHandle = Selector.GetHandle("textContainers");

	private static readonly IntPtr selLayoutOptionsHandle = Selector.GetHandle("layoutOptions");

	private static readonly IntPtr selHasNonContiguousLayoutHandle = Selector.GetHandle("hasNonContiguousLayout");

	private static readonly IntPtr selNumberOfGlyphsHandle = Selector.GetHandle("numberOfGlyphs");

	private static readonly IntPtr selFirstUnlaidCharacterIndexHandle = Selector.GetHandle("firstUnlaidCharacterIndex");

	private static readonly IntPtr selFirstUnlaidGlyphIndexHandle = Selector.GetHandle("firstUnlaidGlyphIndex");

	private static readonly IntPtr selExtraLineFragmentRectHandle = Selector.GetHandle("extraLineFragmentRect");

	private static readonly IntPtr selExtraLineFragmentUsedRectHandle = Selector.GetHandle("extraLineFragmentUsedRect");

	private static readonly IntPtr selExtraLineFragmentTextContainerHandle = Selector.GetHandle("extraLineFragmentTextContainer");

	private static readonly IntPtr selTextStorageHandle = Selector.GetHandle("textStorage");

	private static readonly IntPtr selSetTextStorage_Handle = Selector.GetHandle("setTextStorage:");

	private static readonly IntPtr selGlyphGeneratorHandle = Selector.GetHandle("glyphGenerator");

	private static readonly IntPtr selSetGlyphGenerator_Handle = Selector.GetHandle("setGlyphGenerator:");

	private static readonly IntPtr selTypesetterHandle = Selector.GetHandle("typesetter");

	private static readonly IntPtr selSetTypesetter_Handle = Selector.GetHandle("setTypesetter:");

	private static readonly IntPtr selDelegateHandle = Selector.GetHandle("delegate");

	private static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle("setDelegate:");

	private static readonly IntPtr selBackgroundLayoutEnabledHandle = Selector.GetHandle("backgroundLayoutEnabled");

	private static readonly IntPtr selSetBackgroundLayoutEnabled_Handle = Selector.GetHandle("setBackgroundLayoutEnabled:");

	private static readonly IntPtr selUsesScreenFontsHandle = Selector.GetHandle("usesScreenFonts");

	private static readonly IntPtr selSetUsesScreenFonts_Handle = Selector.GetHandle("setUsesScreenFonts:");

	private static readonly IntPtr selShowsInvisibleCharactersHandle = Selector.GetHandle("showsInvisibleCharacters");

	private static readonly IntPtr selSetShowsInvisibleCharacters_Handle = Selector.GetHandle("setShowsInvisibleCharacters:");

	private static readonly IntPtr selShowsControlCharactersHandle = Selector.GetHandle("showsControlCharacters");

	private static readonly IntPtr selSetShowsControlCharacters_Handle = Selector.GetHandle("setShowsControlCharacters:");

	private static readonly IntPtr selHyphenationFactorHandle = Selector.GetHandle("hyphenationFactor");

	private static readonly IntPtr selSetHyphenationFactor_Handle = Selector.GetHandle("setHyphenationFactor:");

	private static readonly IntPtr selDefaultAttachmentScalingHandle = Selector.GetHandle("defaultAttachmentScaling");

	private static readonly IntPtr selSetDefaultAttachmentScaling_Handle = Selector.GetHandle("setDefaultAttachmentScaling:");

	private static readonly IntPtr selTypesetterBehaviorHandle = Selector.GetHandle("typesetterBehavior");

	private static readonly IntPtr selSetTypesetterBehavior_Handle = Selector.GetHandle("setTypesetterBehavior:");

	private static readonly IntPtr selAllowsNonContiguousLayoutHandle = Selector.GetHandle("allowsNonContiguousLayout");

	private static readonly IntPtr selSetAllowsNonContiguousLayout_Handle = Selector.GetHandle("setAllowsNonContiguousLayout:");

	private static readonly IntPtr selUsesFontLeadingHandle = Selector.GetHandle("usesFontLeading");

	private static readonly IntPtr selSetUsesFontLeading_Handle = Selector.GetHandle("setUsesFontLeading:");

	private static readonly IntPtr selReplaceTextStorage_Handle = Selector.GetHandle("replaceTextStorage:");

	private static readonly IntPtr selAddTextContainer_Handle = Selector.GetHandle("addTextContainer:");

	private static readonly IntPtr selInsertTextContainerAtIndex_Handle = Selector.GetHandle("insertTextContainer:atIndex:");

	private static readonly IntPtr selRemoveTextContainerAtIndex_Handle = Selector.GetHandle("removeTextContainerAtIndex:");

	private static readonly IntPtr selTextContainerChangedGeometry_Handle = Selector.GetHandle("textContainerChangedGeometry:");

	private static readonly IntPtr selTextContainerChangedTextView_Handle = Selector.GetHandle("textContainerChangedTextView:");

	private static readonly IntPtr selInvalidateDisplayForCharacterRange_Handle = Selector.GetHandle("invalidateDisplayForCharacterRange:");

	private static readonly IntPtr selInvalidateDisplayForGlyphRange_Handle = Selector.GetHandle("invalidateDisplayForGlyphRange:");

	private static readonly IntPtr selTextStorageEditedRangeChangeInLengthInvalidatedRange_Handle = Selector.GetHandle("textStorage:edited:range:changeInLength:invalidatedRange:");

	private static readonly IntPtr selEnsureGlyphsForCharacterRange_Handle = Selector.GetHandle("ensureGlyphsForCharacterRange:");

	private static readonly IntPtr selEnsureGlyphsForGlyphRange_Handle = Selector.GetHandle("ensureGlyphsForGlyphRange:");

	private static readonly IntPtr selEnsureLayoutForCharacterRange_Handle = Selector.GetHandle("ensureLayoutForCharacterRange:");

	private static readonly IntPtr selEnsureLayoutForGlyphRange_Handle = Selector.GetHandle("ensureLayoutForGlyphRange:");

	private static readonly IntPtr selEnsureLayoutForTextContainer_Handle = Selector.GetHandle("ensureLayoutForTextContainer:");

	private static readonly IntPtr selEnsureLayoutForBoundingRectInTextContainer_Handle = Selector.GetHandle("ensureLayoutForBoundingRect:inTextContainer:");

	private static readonly IntPtr selInsertGlyphAtGlyphIndexCharacterIndex_Handle = Selector.GetHandle("insertGlyph:atGlyphIndex:characterIndex:");

	private static readonly IntPtr selReplaceGlyphAtIndexWithGlyph_Handle = Selector.GetHandle("replaceGlyphAtIndex:withGlyph:");

	private static readonly IntPtr selDeleteGlyphsInRange_Handle = Selector.GetHandle("deleteGlyphsInRange:");

	private static readonly IntPtr selSetCharacterIndexForGlyphAtIndex_Handle = Selector.GetHandle("setCharacterIndex:forGlyphAtIndex:");

	private static readonly IntPtr selSetIntAttributeValueForGlyphAtIndex_Handle = Selector.GetHandle("setIntAttribute:value:forGlyphAtIndex:");

	private static readonly IntPtr selInvalidateGlyphsOnLayoutInvalidationForGlyphRange_Handle = Selector.GetHandle("invalidateGlyphsOnLayoutInvalidationForGlyphRange:");

	private static readonly IntPtr selGlyphAtIndexIsValidIndex_Handle = Selector.GetHandle("glyphAtIndex:isValidIndex:");

	private static readonly IntPtr selGlyphAtIndex_Handle = Selector.GetHandle("glyphAtIndex:");

	private static readonly IntPtr selIsValidGlyphIndex_Handle = Selector.GetHandle("isValidGlyphIndex:");

	private static readonly IntPtr selCharacterIndexForGlyphAtIndex_Handle = Selector.GetHandle("characterIndexForGlyphAtIndex:");

	private static readonly IntPtr selGlyphIndexForCharacterAtIndex_Handle = Selector.GetHandle("glyphIndexForCharacterAtIndex:");

	private static readonly IntPtr selIntAttributeForGlyphAtIndex_Handle = Selector.GetHandle("intAttribute:forGlyphAtIndex:");

	private static readonly IntPtr selGetGlyphsInRangeGlyphsCharacterIndexesGlyphInscriptionsElasticBits_Handle = Selector.GetHandle("getGlyphsInRange:glyphs:characterIndexes:glyphInscriptions:elasticBits:");

	private static readonly IntPtr selGetGlyphsInRangeGlyphsCharacterIndexesGlyphInscriptionsElasticBitsBidiLevels_Handle = Selector.GetHandle("getGlyphsInRange:glyphs:characterIndexes:glyphInscriptions:elasticBits:bidiLevels:");

	private static readonly IntPtr selGetGlyphsRange_Handle = Selector.GetHandle("getGlyphs:range:");

	private static readonly IntPtr selSetTextContainerForGlyphRange_Handle = Selector.GetHandle("setTextContainer:forGlyphRange:");

	private static readonly IntPtr selSetLineFragmentRectForGlyphRangeUsedRect_Handle = Selector.GetHandle("setLineFragmentRect:forGlyphRange:usedRect:");

	private static readonly IntPtr selSetExtraLineFragmentRectUsedRectTextContainer_Handle = Selector.GetHandle("setExtraLineFragmentRect:usedRect:textContainer:");

	private static readonly IntPtr selSetLocationForStartOfGlyphRange_Handle = Selector.GetHandle("setLocation:forStartOfGlyphRange:");

	private static readonly IntPtr selSetNotShownAttributeForGlyphAtIndex_Handle = Selector.GetHandle("setNotShownAttribute:forGlyphAtIndex:");

	private static readonly IntPtr selSetDrawsOutsideLineFragmentForGlyphAtIndex_Handle = Selector.GetHandle("setDrawsOutsideLineFragment:forGlyphAtIndex:");

	private static readonly IntPtr selSetAttachmentSizeForGlyphRange_Handle = Selector.GetHandle("setAttachmentSize:forGlyphRange:");

	private static readonly IntPtr selGetFirstUnlaidCharacterIndexGlyphIndex_Handle = Selector.GetHandle("getFirstUnlaidCharacterIndex:glyphIndex:");

	private static readonly IntPtr selUsedRectForTextContainer_Handle = Selector.GetHandle("usedRectForTextContainer:");

	private static readonly IntPtr selLocationForGlyphAtIndex_Handle = Selector.GetHandle("locationForGlyphAtIndex:");

	private static readonly IntPtr selNotShownAttributeForGlyphAtIndex_Handle = Selector.GetHandle("notShownAttributeForGlyphAtIndex:");

	private static readonly IntPtr selDrawsOutsideLineFragmentForGlyphAtIndex_Handle = Selector.GetHandle("drawsOutsideLineFragmentForGlyphAtIndex:");

	private static readonly IntPtr selAttachmentSizeForGlyphAtIndex_Handle = Selector.GetHandle("attachmentSizeForGlyphAtIndex:");

	private static readonly IntPtr selSetLayoutRectForTextBlockGlyphRange_Handle = Selector.GetHandle("setLayoutRect:forTextBlock:glyphRange:");

	private static readonly IntPtr selSetBoundsRectForTextBlockGlyphRange_Handle = Selector.GetHandle("setBoundsRect:forTextBlock:glyphRange:");

	private static readonly IntPtr selLayoutRectForTextBlockGlyphRange_Handle = Selector.GetHandle("layoutRectForTextBlock:glyphRange:");

	private static readonly IntPtr selBoundsRectForTextBlockGlyphRange_Handle = Selector.GetHandle("boundsRectForTextBlock:glyphRange:");

	private static readonly IntPtr selGlyphRangeForTextContainer_Handle = Selector.GetHandle("glyphRangeForTextContainer:");

	private static readonly IntPtr selRangeOfNominallySpacedGlyphsContainingIndex_Handle = Selector.GetHandle("rangeOfNominallySpacedGlyphsContainingIndex:");

	private static readonly IntPtr selBoundingRectForGlyphRangeInTextContainer_Handle = Selector.GetHandle("boundingRectForGlyphRange:inTextContainer:");

	private static readonly IntPtr selGlyphRangeForBoundingRectInTextContainer_Handle = Selector.GetHandle("glyphRangeForBoundingRect:inTextContainer:");

	private static readonly IntPtr selGlyphRangeForBoundingRectWithoutAdditionalLayoutInTextContainer_Handle = Selector.GetHandle("glyphRangeForBoundingRectWithoutAdditionalLayout:inTextContainer:");

	private static readonly IntPtr selGlyphIndexForPointInTextContainerFractionOfDistanceThroughGlyph_Handle = Selector.GetHandle("glyphIndexForPoint:inTextContainer:fractionOfDistanceThroughGlyph:");

	private static readonly IntPtr selGlyphIndexForPointInTextContainer_Handle = Selector.GetHandle("glyphIndexForPoint:inTextContainer:");

	private static readonly IntPtr selFractionOfDistanceThroughGlyphForPointInTextContainer_Handle = Selector.GetHandle("fractionOfDistanceThroughGlyphForPoint:inTextContainer:");

	private static readonly IntPtr selCharacterIndexForPointInTextContainerFractionOfDistanceBetweenInsertionPoints_Handle = Selector.GetHandle("characterIndexForPoint:inTextContainer:fractionOfDistanceBetweenInsertionPoints:");

	private static readonly IntPtr selGetLineFragmentInsertionPointsForCharacterAtIndexAlternatePositionsInDisplayOrderPositionsCharacterIndexes_Handle = Selector.GetHandle("getLineFragmentInsertionPointsForCharacterAtIndex:alternatePositions:inDisplayOrder:positions:characterIndexes:");

	private static readonly IntPtr selSetTemporaryAttributesForCharacterRange_Handle = Selector.GetHandle("setTemporaryAttributes:forCharacterRange:");

	private static readonly IntPtr selAddTemporaryAttributesForCharacterRange_Handle = Selector.GetHandle("addTemporaryAttributes:forCharacterRange:");

	private static readonly IntPtr selRemoveTemporaryAttributeForCharacterRange_Handle = Selector.GetHandle("removeTemporaryAttribute:forCharacterRange:");

	private static readonly IntPtr selAddTemporaryAttributeValueForCharacterRange_Handle = Selector.GetHandle("addTemporaryAttribute:value:forCharacterRange:");

	private static readonly IntPtr selSubstituteFontForFont_Handle = Selector.GetHandle("substituteFontForFont:");

	private static readonly IntPtr selDefaultLineHeightForFont_Handle = Selector.GetHandle("defaultLineHeightForFont:");

	private static readonly IntPtr selDefaultBaselineOffsetForFont_Handle = Selector.GetHandle("defaultBaselineOffsetForFont:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSLayoutManager");

	private object __mt_AttributedString_var;

	private object __mt_TextContainers_var;

	private object __mt_ExtraLineFragmentTextContainer_var;

	private object __mt_TextStorage_var;

	private object __mt_GlyphGenerator_var;

	private object __mt_Typesetter_var;

	private object __mt_WeakDelegate_var;

	public override IntPtr ClassHandle => class_ptr;

	public virtual NSAttributedString AttributedString
	{
		[Export("attributedString")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSAttributedString)(__mt_AttributedString_var = ((!IsDirectBinding) ? ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selAttributedStringHandle))) : ((NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selAttributedStringHandle)))));
		}
	}

	public virtual NSTextContainer[] TextContainers
	{
		[Export("textContainers")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextContainer[])(__mt_TextContainers_var = ((!IsDirectBinding) ? NSArray.ArrayFromHandle<NSTextContainer>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextContainersHandle)) : NSArray.ArrayFromHandle<NSTextContainer>(Messaging.IntPtr_objc_msgSend(base.Handle, selTextContainersHandle))));
		}
	}

	public virtual NSGlyphStorageOptions LayoutOptions
	{
		[Export("layoutOptions")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSGlyphStorageOptions)Messaging.UInt64_objc_msgSend(base.Handle, selLayoutOptionsHandle);
			}
			return (NSGlyphStorageOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLayoutOptionsHandle);
		}
	}

	public virtual bool HasNonContiguousLayout
	{
		[Export("hasNonContiguousLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selHasNonContiguousLayoutHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selHasNonContiguousLayoutHandle);
		}
	}

	public virtual long NumberOfGlyphs
	{
		[Export("numberOfGlyphs")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selNumberOfGlyphsHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selNumberOfGlyphsHandle);
		}
	}

	public virtual long FirstUnlaidCharacterIndex
	{
		[Export("firstUnlaidCharacterIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selFirstUnlaidCharacterIndexHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFirstUnlaidCharacterIndexHandle);
		}
	}

	public virtual long FirstUnlaidGlyphIndex
	{
		[Export("firstUnlaidGlyphIndex")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.Int64_objc_msgSend(base.Handle, selFirstUnlaidGlyphIndexHandle);
			}
			return Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selFirstUnlaidGlyphIndexHandle);
		}
	}

	public virtual CGRect ExtraLineFragmentRect
	{
		[Export("extraLineFragmentRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selExtraLineFragmentRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selExtraLineFragmentRectHandle);
			}
			return retval;
		}
	}

	public virtual CGRect ExtraLineFragmentUsedRect
	{
		[Export("extraLineFragmentUsedRect")]
		get
		{
			NSApplication.EnsureUIThread();
			CGRect retval;
			if (IsDirectBinding)
			{
				Messaging.CGRect_objc_msgSend_stret(out retval, base.Handle, selExtraLineFragmentUsedRectHandle);
			}
			else
			{
				Messaging.CGRect_objc_msgSendSuper_stret(out retval, base.SuperHandle, selExtraLineFragmentUsedRectHandle);
			}
			return retval;
		}
	}

	public virtual NSTextContainer ExtraLineFragmentTextContainer
	{
		[Export("extraLineFragmentTextContainer")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextContainer)(__mt_ExtraLineFragmentTextContainer_var = ((!IsDirectBinding) ? ((NSTextContainer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selExtraLineFragmentTextContainerHandle))) : ((NSTextContainer)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selExtraLineFragmentTextContainerHandle)))));
		}
	}

	public virtual NSTextStorage TextStorage
	{
		[Export("textStorage")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTextStorage)(__mt_TextStorage_var = ((!IsDirectBinding) ? ((NSTextStorage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTextStorageHandle))) : ((NSTextStorage)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTextStorageHandle)))));
		}
		[Export("setTextStorage:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTextStorage_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTextStorage_Handle, value.Handle);
			}
			__mt_TextStorage_var = value;
		}
	}

	public virtual NSGlyphGenerator GlyphGenerator
	{
		[Export("glyphGenerator")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSGlyphGenerator)(__mt_GlyphGenerator_var = ((!IsDirectBinding) ? ((NSGlyphGenerator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selGlyphGeneratorHandle))) : ((NSGlyphGenerator)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selGlyphGeneratorHandle)))));
		}
		[Export("setGlyphGenerator:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetGlyphGenerator_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetGlyphGenerator_Handle, value.Handle);
			}
			__mt_GlyphGenerator_var = value;
		}
	}

	public virtual NSTypesetter Typesetter
	{
		[Export("typesetter")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSTypesetter)(__mt_Typesetter_var = ((!IsDirectBinding) ? ((NSTypesetter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selTypesetterHandle))) : ((NSTypesetter)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selTypesetterHandle)))));
		}
		[Export("setTypesetter:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetTypesetter_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetTypesetter_Handle, value.Handle);
			}
			__mt_Typesetter_var = value;
		}
	}

	public virtual NSObject WeakDelegate
	{
		[Export("delegate")]
		get
		{
			NSApplication.EnsureUIThread();
			return (NSObject)(__mt_WeakDelegate_var = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selDelegateHandle)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selDelegateHandle))));
		}
		[Export("setDelegate:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetDelegate_Handle, value.Handle);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetDelegate_Handle, value.Handle);
			}
			__mt_WeakDelegate_var = value;
		}
	}

	public NSLayoutManagerDelegate Delegate
	{
		get
		{
			return WeakDelegate as NSLayoutManagerDelegate;
		}
		set
		{
			WeakDelegate = value;
		}
	}

	public virtual bool BackgroundLayoutEnabled
	{
		[Export("backgroundLayoutEnabled")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selBackgroundLayoutEnabledHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selBackgroundLayoutEnabledHandle);
		}
		[Export("setBackgroundLayoutEnabled:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetBackgroundLayoutEnabled_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetBackgroundLayoutEnabled_Handle, value);
			}
		}
	}

	public virtual bool UsesScreenFonts
	{
		[Export("usesScreenFonts")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesScreenFontsHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesScreenFontsHandle);
		}
		[Export("setUsesScreenFonts:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesScreenFonts_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesScreenFonts_Handle, value);
			}
		}
	}

	public virtual bool ShowsInvisibleCharacters
	{
		[Export("showsInvisibleCharacters")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsInvisibleCharactersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsInvisibleCharactersHandle);
		}
		[Export("setShowsInvisibleCharacters:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsInvisibleCharacters_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsInvisibleCharacters_Handle, value);
			}
		}
	}

	public virtual bool ShowsControlCharacters
	{
		[Export("showsControlCharacters")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selShowsControlCharactersHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selShowsControlCharactersHandle);
		}
		[Export("setShowsControlCharacters:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetShowsControlCharacters_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetShowsControlCharacters_Handle, value);
			}
		}
	}

	public virtual float HyphenationFactor
	{
		[Export("hyphenationFactor")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.float_objc_msgSend(base.Handle, selHyphenationFactorHandle);
			}
			return Messaging.float_objc_msgSendSuper(base.SuperHandle, selHyphenationFactorHandle);
		}
		[Export("setHyphenationFactor:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_float(base.Handle, selSetHyphenationFactor_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_float(base.SuperHandle, selSetHyphenationFactor_Handle, value);
			}
		}
	}

	public virtual NSImageScaling DefaultAttachmentScaling
	{
		[Export("defaultAttachmentScaling")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSImageScaling)Messaging.UInt64_objc_msgSend(base.Handle, selDefaultAttachmentScalingHandle);
			}
			return (NSImageScaling)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selDefaultAttachmentScalingHandle);
		}
		[Export("setDefaultAttachmentScaling:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_UInt64(base.Handle, selSetDefaultAttachmentScaling_Handle, (ulong)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_UInt64(base.SuperHandle, selSetDefaultAttachmentScaling_Handle, (ulong)value);
			}
		}
	}

	public virtual NSTypesetterBehavior TypesetterBehavior
	{
		[Export("typesetterBehavior")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return (NSTypesetterBehavior)Messaging.Int64_objc_msgSend(base.Handle, selTypesetterBehaviorHandle);
			}
			return (NSTypesetterBehavior)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selTypesetterBehaviorHandle);
		}
		[Export("setTypesetterBehavior:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_Int64(base.Handle, selSetTypesetterBehavior_Handle, (long)value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selSetTypesetterBehavior_Handle, (long)value);
			}
		}
	}

	public virtual bool AllowsNonContiguousLayout
	{
		[Export("allowsNonContiguousLayout")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selAllowsNonContiguousLayoutHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selAllowsNonContiguousLayoutHandle);
		}
		[Export("setAllowsNonContiguousLayout:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetAllowsNonContiguousLayout_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetAllowsNonContiguousLayout_Handle, value);
			}
		}
	}

	public virtual bool UsesFontLeading
	{
		[Export("usesFontLeading")]
		get
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selUsesFontLeadingHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selUsesFontLeadingHandle);
		}
		[Export("setUsesFontLeading:")]
		set
		{
			NSApplication.EnsureUIThread();
			if (IsDirectBinding)
			{
				Messaging.void_objc_msgSend_bool(base.Handle, selSetUsesFontLeading_Handle, value);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_bool(base.SuperHandle, selSetUsesFontLeading_Handle, value);
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSLayoutManager()
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
	public NSLayoutManager(NSCoder coder)
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
	public NSLayoutManager(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSLayoutManager(IntPtr handle)
		: base(handle)
	{
	}

	[Export("replaceTextStorage:")]
	public virtual void ReplaceTextStorage(NSTextStorage newTextStorage)
	{
		NSApplication.EnsureUIThread();
		if (newTextStorage == null)
		{
			throw new ArgumentNullException("newTextStorage");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selReplaceTextStorage_Handle, newTextStorage.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selReplaceTextStorage_Handle, newTextStorage.Handle);
		}
	}

	[Export("addTextContainer:")]
	public virtual void AddTextContainer(NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAddTextContainer_Handle, container.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAddTextContainer_Handle, container.Handle);
		}
		_ = TextContainers;
	}

	[Export("insertTextContainer:atIndex:")]
	public virtual void InsertTextContainer(NSTextContainer container, long index)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_Int64(base.Handle, selInsertTextContainerAtIndex_Handle, container.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_Int64(base.SuperHandle, selInsertTextContainerAtIndex_Handle, container.Handle, index);
		}
		_ = TextContainers;
	}

	[Export("removeTextContainerAtIndex:")]
	public virtual void RemoveTextContainer(long index)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64(base.Handle, selRemoveTextContainerAtIndex_Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64(base.SuperHandle, selRemoveTextContainerAtIndex_Handle, index);
		}
		_ = TextContainers;
	}

	[Export("textContainerChangedGeometry:")]
	public virtual void TextContainerChangedGeometry(NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextContainerChangedGeometry_Handle, container.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextContainerChangedGeometry_Handle, container.Handle);
		}
	}

	[Export("textContainerChangedTextView:")]
	public virtual void TextContainerChangedTextView(NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selTextContainerChangedTextView_Handle, container.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selTextContainerChangedTextView_Handle, container.Handle);
		}
	}

	[Export("invalidateDisplayForCharacterRange:")]
	public virtual void InvalidateDisplayForCharacterRange(NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selInvalidateDisplayForCharacterRange_Handle, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selInvalidateDisplayForCharacterRange_Handle, charRange);
		}
	}

	[Export("invalidateDisplayForGlyphRange:")]
	public virtual void InvalidateDisplayForGlyphRange(NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selInvalidateDisplayForGlyphRange_Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selInvalidateDisplayForGlyphRange_Handle, glyphRange);
		}
	}

	[Export("textStorage:edited:range:changeInLength:invalidatedRange:")]
	public virtual void TextStorageEdited(NSTextStorage str, NSTextStorageEditedFlags editedMask, NSRange newCharRange, long changeInLength, NSRange invalidatedCharRange)
	{
		NSApplication.EnsureUIThread();
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_NSRange_Int64_NSRange(base.Handle, selTextStorageEditedRangeChangeInLengthInvalidatedRange_Handle, str.Handle, (ulong)editedMask, newCharRange, changeInLength, invalidatedCharRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_NSRange_Int64_NSRange(base.SuperHandle, selTextStorageEditedRangeChangeInLengthInvalidatedRange_Handle, str.Handle, (ulong)editedMask, newCharRange, changeInLength, invalidatedCharRange);
		}
	}

	[Export("ensureGlyphsForCharacterRange:")]
	public virtual void EnsureGlyphsForCharacterRange(NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selEnsureGlyphsForCharacterRange_Handle, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selEnsureGlyphsForCharacterRange_Handle, charRange);
		}
	}

	[Export("ensureGlyphsForGlyphRange:")]
	public virtual void EnsureGlyphsForGlyphRange(NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selEnsureGlyphsForGlyphRange_Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selEnsureGlyphsForGlyphRange_Handle, glyphRange);
		}
	}

	[Export("ensureLayoutForCharacterRange:")]
	public virtual void EnsureLayoutForCharacterRange(NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selEnsureLayoutForCharacterRange_Handle, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selEnsureLayoutForCharacterRange_Handle, charRange);
		}
	}

	[Export("ensureLayoutForGlyphRange:")]
	public virtual void EnsureLayoutForGlyphRange(NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selEnsureLayoutForGlyphRange_Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selEnsureLayoutForGlyphRange_Handle, glyphRange);
		}
	}

	[Export("ensureLayoutForTextContainer:")]
	public virtual void EnsureLayoutForTextContainer(NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selEnsureLayoutForTextContainer_Handle, container.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selEnsureLayoutForTextContainer_Handle, container.Handle);
		}
	}

	[Export("ensureLayoutForBoundingRect:inTextContainer:")]
	public virtual void EnsureLayoutForBoundingRect(CGRect bounds, NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selEnsureLayoutForBoundingRectInTextContainer_Handle, bounds, container.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selEnsureLayoutForBoundingRectInTextContainer_Handle, bounds, container.Handle);
		}
	}

	[Export("insertGlyph:atGlyphIndex:characterIndex:")]
	public virtual void InsertGlyph(ulong glyph, long glyphIndex, long charIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_UInt64_Int64_Int64(base.Handle, selInsertGlyphAtGlyphIndexCharacterIndex_Handle, glyph, glyphIndex, charIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_UInt64_Int64_Int64(base.SuperHandle, selInsertGlyphAtGlyphIndexCharacterIndex_Handle, glyph, glyphIndex, charIndex);
		}
	}

	[Export("replaceGlyphAtIndex:withGlyph:")]
	public virtual void ReplaceGlyphAtIndex(long glyphIndex, ulong newGlyph)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_UInt64(base.Handle, selReplaceGlyphAtIndexWithGlyph_Handle, glyphIndex, newGlyph);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_UInt64(base.SuperHandle, selReplaceGlyphAtIndexWithGlyph_Handle, glyphIndex, newGlyph);
		}
	}

	[Export("deleteGlyphsInRange:")]
	public virtual void DeleteGlyphs(NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selDeleteGlyphsInRange_Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selDeleteGlyphsInRange_Handle, glyphRange);
		}
	}

	[Export("setCharacterIndex:forGlyphAtIndex:")]
	public virtual void SetCharacterIndex(long charIndex, long glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64(base.Handle, selSetCharacterIndexForGlyphAtIndex_Handle, charIndex, glyphIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selSetCharacterIndexForGlyphAtIndex_Handle, charIndex, glyphIndex);
		}
	}

	[Export("setIntAttribute:value:forGlyphAtIndex:")]
	public virtual void SetIntAttribute(long attributeTag, long value, long glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_Int64_Int64_Int64(base.Handle, selSetIntAttributeValueForGlyphAtIndex_Handle, attributeTag, value, glyphIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_Int64_Int64_Int64(base.SuperHandle, selSetIntAttributeValueForGlyphAtIndex_Handle, attributeTag, value, glyphIndex);
		}
	}

	[Export("invalidateGlyphsOnLayoutInvalidationForGlyphRange:")]
	public virtual void InvalidateGlyphsOnLayoutInvalidation(NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selInvalidateGlyphsOnLayoutInvalidationForGlyphRange_Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selInvalidateGlyphsOnLayoutInvalidationForGlyphRange_Handle, glyphRange);
		}
	}

	[Export("glyphAtIndex:isValidIndex:")]
	public virtual ulong GlyphAtIndexisValidIndex(ulong glyphIndex, ref bool isValidIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend_UInt64_out_Boolean(base.Handle, selGlyphAtIndexIsValidIndex_Handle, glyphIndex, out isValidIndex);
		}
		return Messaging.UInt64_objc_msgSendSuper_UInt64_out_Boolean(base.SuperHandle, selGlyphAtIndexIsValidIndex_Handle, glyphIndex, out isValidIndex);
	}

	[Export("glyphAtIndex:")]
	public virtual ulong GlyphCount(long glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend_Int64(base.Handle, selGlyphAtIndex_Handle, glyphIndex);
		}
		return Messaging.UInt64_objc_msgSendSuper_Int64(base.SuperHandle, selGlyphAtIndex_Handle, glyphIndex);
	}

	[Export("isValidGlyphIndex:")]
	public virtual bool IsValidGlyphIndex(long glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selIsValidGlyphIndex_Handle, glyphIndex);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selIsValidGlyphIndex_Handle, glyphIndex);
	}

	[Export("characterIndexForGlyphAtIndex:")]
	public virtual ulong CharacterIndexForGlyphAtIndex(long glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend_Int64(base.Handle, selCharacterIndexForGlyphAtIndex_Handle, glyphIndex);
		}
		return Messaging.UInt64_objc_msgSendSuper_Int64(base.SuperHandle, selCharacterIndexForGlyphAtIndex_Handle, glyphIndex);
	}

	[Export("glyphIndexForCharacterAtIndex:")]
	public virtual ulong GlyphIndexForCharacterAtIndex(long charIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend_Int64(base.Handle, selGlyphIndexForCharacterAtIndex_Handle, charIndex);
		}
		return Messaging.UInt64_objc_msgSendSuper_Int64(base.SuperHandle, selGlyphIndexForCharacterAtIndex_Handle, charIndex);
	}

	[Export("intAttribute:forGlyphAtIndex:")]
	public virtual long IntAttributeforGlyphAtIndex(long attributeTag, long glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_Int64_Int64(base.Handle, selIntAttributeForGlyphAtIndex_Handle, attributeTag, glyphIndex);
		}
		return Messaging.Int64_objc_msgSendSuper_Int64_Int64(base.SuperHandle, selIntAttributeForGlyphAtIndex_Handle, attributeTag, glyphIndex);
	}

	[Export("getGlyphsInRange:glyphs:characterIndexes:glyphInscriptions:elasticBits:")]
	internal virtual long GetGlyphs(NSRange glyphRange, IntPtr glyphBuffer, IntPtr charIndexBuffer, IntPtr inscribeBuffer, IntPtr elasticBuffer)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_NSRange_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selGetGlyphsInRangeGlyphsCharacterIndexesGlyphInscriptionsElasticBits_Handle, glyphRange, glyphBuffer, charIndexBuffer, inscribeBuffer, elasticBuffer);
		}
		return Messaging.Int64_objc_msgSendSuper_NSRange_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selGetGlyphsInRangeGlyphsCharacterIndexesGlyphInscriptionsElasticBits_Handle, glyphRange, glyphBuffer, charIndexBuffer, inscribeBuffer, elasticBuffer);
	}

	[Export("getGlyphsInRange:glyphs:characterIndexes:glyphInscriptions:elasticBits:bidiLevels:")]
	internal virtual long GetGlyphs(NSRange glyphRange, IntPtr glyphBuffer, IntPtr charIndexBuffer, IntPtr inscribeBuffer, IntPtr elasticBuffer, IntPtr bidiLevelBuffer)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.Int64_objc_msgSend_NSRange_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selGetGlyphsInRangeGlyphsCharacterIndexesGlyphInscriptionsElasticBitsBidiLevels_Handle, glyphRange, glyphBuffer, charIndexBuffer, inscribeBuffer, elasticBuffer, bidiLevelBuffer);
		}
		return Messaging.Int64_objc_msgSendSuper_NSRange_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selGetGlyphsInRangeGlyphsCharacterIndexesGlyphInscriptionsElasticBitsBidiLevels_Handle, glyphRange, glyphBuffer, charIndexBuffer, inscribeBuffer, elasticBuffer, bidiLevelBuffer);
	}

	[Export("getGlyphs:range:")]
	internal virtual ulong GetGlyphsrange(IntPtr glyphArray, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend_IntPtr_NSRange(base.Handle, selGetGlyphsRange_Handle, glyphArray, glyphRange);
		}
		return Messaging.UInt64_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selGetGlyphsRange_Handle, glyphArray, glyphRange);
	}

	[Export("setTextContainer:forGlyphRange:")]
	public virtual void SetTextContainerForRange(NSTextContainer container, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selSetTextContainerForGlyphRange_Handle, container.Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSetTextContainerForGlyphRange_Handle, container.Handle, glyphRange);
		}
	}

	[Export("setLineFragmentRect:forGlyphRange:usedRect:")]
	public virtual void SetLineFragmentRect(CGRect fragmentRect, NSRange glyphRange, CGRect usedRect)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_NSRange_CGRect(base.Handle, selSetLineFragmentRectForGlyphRangeUsedRect_Handle, fragmentRect, glyphRange, usedRect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_NSRange_CGRect(base.SuperHandle, selSetLineFragmentRectForGlyphRangeUsedRect_Handle, fragmentRect, glyphRange, usedRect);
		}
	}

	[Export("setExtraLineFragmentRect:usedRect:textContainer:")]
	public virtual void SetExtraLineFragmentRect(CGRect fragmentRect, CGRect usedRect, NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_CGRect_IntPtr(base.Handle, selSetExtraLineFragmentRectUsedRectTextContainer_Handle, fragmentRect, usedRect, container.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_CGRect_IntPtr(base.SuperHandle, selSetExtraLineFragmentRectUsedRectTextContainer_Handle, fragmentRect, usedRect, container.Handle);
		}
	}

	[Export("setLocation:forStartOfGlyphRange:")]
	public virtual void SetLocation(CGPoint location, NSRange forStartOfGlyphRange)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint_NSRange(base.Handle, selSetLocationForStartOfGlyphRange_Handle, location, forStartOfGlyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint_NSRange(base.SuperHandle, selSetLocationForStartOfGlyphRange_Handle, location, forStartOfGlyphRange);
		}
	}

	[Export("setNotShownAttribute:forGlyphAtIndex:")]
	public virtual void SetNotShownAttribute(bool flag, long glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_Int64(base.Handle, selSetNotShownAttributeForGlyphAtIndex_Handle, flag, glyphIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_Int64(base.SuperHandle, selSetNotShownAttributeForGlyphAtIndex_Handle, flag, glyphIndex);
		}
	}

	[Export("setDrawsOutsideLineFragment:forGlyphAtIndex:")]
	public virtual void SetDrawsOutsideLineFragment(bool flag, long glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_bool_Int64(base.Handle, selSetDrawsOutsideLineFragmentForGlyphAtIndex_Handle, flag, glyphIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_bool_Int64(base.SuperHandle, selSetDrawsOutsideLineFragmentForGlyphAtIndex_Handle, flag, glyphIndex);
		}
	}

	[Export("setAttachmentSize:forGlyphRange:")]
	public virtual void SetAttachmentSize(CGSize attachmentSize, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGSize_NSRange(base.Handle, selSetAttachmentSizeForGlyphRange_Handle, attachmentSize, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGSize_NSRange(base.SuperHandle, selSetAttachmentSizeForGlyphRange_Handle, attachmentSize, glyphRange);
		}
	}

	[Export("getFirstUnlaidCharacterIndex:glyphIndex:")]
	public virtual void GetFirstUnlaidCharacterIndex(ref ulong charIndex, ref ulong glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_out_UInt64_out_UInt64(base.Handle, selGetFirstUnlaidCharacterIndexGlyphIndex_Handle, out charIndex, out glyphIndex);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_out_UInt64_out_UInt64(base.SuperHandle, selGetFirstUnlaidCharacterIndexGlyphIndex_Handle, out charIndex, out glyphIndex);
		}
	}

	[Export("usedRectForTextContainer:")]
	public virtual CGRect GetUsedRectForTextContainer(NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr(out retval, base.Handle, selUsedRectForTextContainer_Handle, container.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr(out retval, base.SuperHandle, selUsedRectForTextContainer_Handle, container.Handle);
		}
		return retval;
	}

	[Export("locationForGlyphAtIndex:")]
	public virtual CGPoint LocationForGlyphAtIndex(long glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGPoint_objc_msgSend_Int64(base.Handle, selLocationForGlyphAtIndex_Handle, glyphIndex);
		}
		return Messaging.CGPoint_objc_msgSendSuper_Int64(base.SuperHandle, selLocationForGlyphAtIndex_Handle, glyphIndex);
	}

	[Export("notShownAttributeForGlyphAtIndex:")]
	public virtual bool NotShownAttributeForGlyphAtIndex(long glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selNotShownAttributeForGlyphAtIndex_Handle, glyphIndex);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selNotShownAttributeForGlyphAtIndex_Handle, glyphIndex);
	}

	[Export("drawsOutsideLineFragmentForGlyphAtIndex:")]
	public virtual bool DrawsOutsideLineFragmentForGlyphAt(long glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Int64(base.Handle, selDrawsOutsideLineFragmentForGlyphAtIndex_Handle, glyphIndex);
		}
		return Messaging.bool_objc_msgSendSuper_Int64(base.SuperHandle, selDrawsOutsideLineFragmentForGlyphAtIndex_Handle, glyphIndex);
	}

	[Export("attachmentSizeForGlyphAtIndex:")]
	public virtual CGSize AttachmentSizeForGlyphAt(long glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.CGSize_objc_msgSend_Int64(base.Handle, selAttachmentSizeForGlyphAtIndex_Handle, glyphIndex);
		}
		return Messaging.CGSize_objc_msgSendSuper_Int64(base.SuperHandle, selAttachmentSizeForGlyphAtIndex_Handle, glyphIndex);
	}

	[Export("setLayoutRect:forTextBlock:glyphRange:")]
	public virtual void SetLayoutRect(CGRect layoutRect, NSTextBlock forTextBlock, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (forTextBlock == null)
		{
			throw new ArgumentNullException("forTextBlock");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_NSRange(base.Handle, selSetLayoutRectForTextBlockGlyphRange_Handle, layoutRect, forTextBlock.Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_NSRange(base.SuperHandle, selSetLayoutRectForTextBlockGlyphRange_Handle, layoutRect, forTextBlock.Handle, glyphRange);
		}
	}

	[Export("setBoundsRect:forTextBlock:glyphRange:")]
	public virtual void SetBoundsRect(CGRect boundsRect, NSTextBlock forTextBlock, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (forTextBlock == null)
		{
			throw new ArgumentNullException("forTextBlock");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_IntPtr_NSRange(base.Handle, selSetBoundsRectForTextBlockGlyphRange_Handle, boundsRect, forTextBlock.Handle, glyphRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_IntPtr_NSRange(base.SuperHandle, selSetBoundsRectForTextBlockGlyphRange_Handle, boundsRect, forTextBlock.Handle, glyphRange);
		}
	}

	[Export("layoutRectForTextBlock:glyphRange:")]
	public virtual CGRect LayoutRect(NSTextBlock block, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_NSRange(out retval, base.Handle, selLayoutRectForTextBlockGlyphRange_Handle, block.Handle, glyphRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_NSRange(out retval, base.SuperHandle, selLayoutRectForTextBlockGlyphRange_Handle, block.Handle, glyphRange);
		}
		return retval;
	}

	[Export("boundsRectForTextBlock:glyphRange:")]
	public virtual CGRect BoundsRect(NSTextBlock block, NSRange glyphRange)
	{
		NSApplication.EnsureUIThread();
		if (block == null)
		{
			throw new ArgumentNullException("block");
		}
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_IntPtr_NSRange(out retval, base.Handle, selBoundsRectForTextBlockGlyphRange_Handle, block.Handle, glyphRange);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_IntPtr_NSRange(out retval, base.SuperHandle, selBoundsRectForTextBlockGlyphRange_Handle, block.Handle, glyphRange);
		}
		return retval;
	}

	[Export("glyphRangeForTextContainer:")]
	public virtual NSRange GetGlyphRange(NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_IntPtr(base.Handle, selGlyphRangeForTextContainer_Handle, container.Handle);
		}
		return Messaging.NSRange_objc_msgSendSuper_IntPtr(base.SuperHandle, selGlyphRangeForTextContainer_Handle, container.Handle);
	}

	[Export("rangeOfNominallySpacedGlyphsContainingIndex:")]
	public virtual NSRange RangeOfNominallySpacedGlyphsContainingIndex(long glyphIndex)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_Int64(base.Handle, selRangeOfNominallySpacedGlyphsContainingIndex_Handle, glyphIndex);
		}
		return Messaging.NSRange_objc_msgSendSuper_Int64(base.SuperHandle, selRangeOfNominallySpacedGlyphsContainingIndex_Handle, glyphIndex);
	}

	[Export("boundingRectForGlyphRange:inTextContainer:")]
	public virtual CGRect BoundingRectForGlyphRange(NSRange glyphRange, NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		CGRect retval;
		if (IsDirectBinding)
		{
			Messaging.CGRect_objc_msgSend_stret_NSRange_IntPtr(out retval, base.Handle, selBoundingRectForGlyphRangeInTextContainer_Handle, glyphRange, container.Handle);
		}
		else
		{
			Messaging.CGRect_objc_msgSendSuper_stret_NSRange_IntPtr(out retval, base.SuperHandle, selBoundingRectForGlyphRangeInTextContainer_Handle, glyphRange, container.Handle);
		}
		return retval;
	}

	[Export("glyphRangeForBoundingRect:inTextContainer:")]
	public virtual NSRange GlyphRangeForBoundingRect(CGRect bounds, NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_CGRect_IntPtr(base.Handle, selGlyphRangeForBoundingRectInTextContainer_Handle, bounds, container.Handle);
		}
		return Messaging.NSRange_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selGlyphRangeForBoundingRectInTextContainer_Handle, bounds, container.Handle);
	}

	[Export("glyphRangeForBoundingRectWithoutAdditionalLayout:inTextContainer:")]
	public virtual NSRange GlyphRangeForBoundingRectWithoutAdditionalLayout(CGRect bounds, NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_CGRect_IntPtr(base.Handle, selGlyphRangeForBoundingRectWithoutAdditionalLayoutInTextContainer_Handle, bounds, container.Handle);
		}
		return Messaging.NSRange_objc_msgSendSuper_CGRect_IntPtr(base.SuperHandle, selGlyphRangeForBoundingRectWithoutAdditionalLayoutInTextContainer_Handle, bounds, container.Handle);
	}

	[Export("glyphIndexForPoint:inTextContainer:fractionOfDistanceThroughGlyph:")]
	public virtual ulong GlyphIndexForPointInTextContainer(CGPoint point, NSTextContainer container, ref double fractionOfDistanceThroughGlyph)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend_CGPoint_IntPtr_out_Double(base.Handle, selGlyphIndexForPointInTextContainerFractionOfDistanceThroughGlyph_Handle, point, container.Handle, out fractionOfDistanceThroughGlyph);
		}
		return Messaging.UInt64_objc_msgSendSuper_CGPoint_IntPtr_out_Double(base.SuperHandle, selGlyphIndexForPointInTextContainerFractionOfDistanceThroughGlyph_Handle, point, container.Handle, out fractionOfDistanceThroughGlyph);
	}

	[Export("glyphIndexForPoint:inTextContainer:")]
	public virtual ulong GlyphIndexForPoint(CGPoint point, NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend_CGPoint_IntPtr(base.Handle, selGlyphIndexForPointInTextContainer_Handle, point, container.Handle);
		}
		return Messaging.UInt64_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selGlyphIndexForPointInTextContainer_Handle, point, container.Handle);
	}

	[Export("fractionOfDistanceThroughGlyphForPoint:inTextContainer:")]
	public virtual double FractionOfDistanceThroughGlyphForPoint(CGPoint point, NSTextContainer container)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_CGPoint_IntPtr(base.Handle, selFractionOfDistanceThroughGlyphForPointInTextContainer_Handle, point, container.Handle);
		}
		return Messaging.Double_objc_msgSendSuper_CGPoint_IntPtr(base.SuperHandle, selFractionOfDistanceThroughGlyphForPointInTextContainer_Handle, point, container.Handle);
	}

	[Export("characterIndexForPoint:inTextContainer:fractionOfDistanceBetweenInsertionPoints:")]
	public virtual ulong CharacterIndexForPoint(CGPoint point, NSTextContainer container, ref double fractionOfDistanceBetweenInsertionPoints)
	{
		NSApplication.EnsureUIThread();
		if (container == null)
		{
			throw new ArgumentNullException("container");
		}
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend_CGPoint_IntPtr_out_Double(base.Handle, selCharacterIndexForPointInTextContainerFractionOfDistanceBetweenInsertionPoints_Handle, point, container.Handle, out fractionOfDistanceBetweenInsertionPoints);
		}
		return Messaging.UInt64_objc_msgSendSuper_CGPoint_IntPtr_out_Double(base.SuperHandle, selCharacterIndexForPointInTextContainerFractionOfDistanceBetweenInsertionPoints_Handle, point, container.Handle, out fractionOfDistanceBetweenInsertionPoints);
	}

	[Export("getLineFragmentInsertionPointsForCharacterAtIndex:alternatePositions:inDisplayOrder:positions:characterIndexes:")]
	public virtual ulong GetLineFragmentInsertionPoints(ulong charIndex, bool aFlag, bool dFlag, IntPtr positions, IntPtr charIndexes)
	{
		NSApplication.EnsureUIThread();
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend_UInt64_bool_bool_IntPtr_IntPtr(base.Handle, selGetLineFragmentInsertionPointsForCharacterAtIndexAlternatePositionsInDisplayOrderPositionsCharacterIndexes_Handle, charIndex, aFlag, dFlag, positions, charIndexes);
		}
		return Messaging.UInt64_objc_msgSendSuper_UInt64_bool_bool_IntPtr_IntPtr(base.SuperHandle, selGetLineFragmentInsertionPointsForCharacterAtIndexAlternatePositionsInDisplayOrderPositionsCharacterIndexes_Handle, charIndex, aFlag, dFlag, positions, charIndexes);
	}

	[Export("setTemporaryAttributes:forCharacterRange:")]
	public virtual void SetTemporaryAttributes(NSDictionary attrs, NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (attrs == null)
		{
			throw new ArgumentNullException("attrs");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selSetTemporaryAttributesForCharacterRange_Handle, attrs.Handle, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selSetTemporaryAttributesForCharacterRange_Handle, attrs.Handle, charRange);
		}
	}

	[Export("addTemporaryAttributes:forCharacterRange:")]
	public virtual void AddTemporaryAttributes(NSDictionary attrs, NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (attrs == null)
		{
			throw new ArgumentNullException("attrs");
		}
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selAddTemporaryAttributesForCharacterRange_Handle, attrs.Handle, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selAddTemporaryAttributesForCharacterRange_Handle, attrs.Handle, charRange);
		}
	}

	[Export("removeTemporaryAttribute:forCharacterRange:")]
	public virtual void RemoveTemporaryAttribute(string attrName, NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (attrName == null)
		{
			throw new ArgumentNullException("attrName");
		}
		IntPtr arg = NSString.CreateNative(attrName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange(base.Handle, selRemoveTemporaryAttributeForCharacterRange_Handle, arg, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange(base.SuperHandle, selRemoveTemporaryAttributeForCharacterRange_Handle, arg, charRange);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("addTemporaryAttribute:value:forCharacterRange:")]
	public virtual void AddTemporaryAttribute(string attrName, NSObject value, NSRange charRange)
	{
		NSApplication.EnsureUIThread();
		if (attrName == null)
		{
			throw new ArgumentNullException("attrName");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		IntPtr arg = NSString.CreateNative(attrName);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_IntPtr_NSRange(base.Handle, selAddTemporaryAttributeValueForCharacterRange_Handle, arg, value.Handle, charRange);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_NSRange(base.SuperHandle, selAddTemporaryAttributeValueForCharacterRange_Handle, arg, value.Handle, charRange);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("substituteFontForFont:")]
	public virtual NSFont SubstituteFontForFont(NSFont originalFont)
	{
		NSApplication.EnsureUIThread();
		if (originalFont == null)
		{
			throw new ArgumentNullException("originalFont");
		}
		if (IsDirectBinding)
		{
			return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selSubstituteFontForFont_Handle, originalFont.Handle));
		}
		return (NSFont)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selSubstituteFontForFont_Handle, originalFont.Handle));
	}

	[Export("defaultLineHeightForFont:")]
	public virtual double DefaultLineHeightForFont(NSFont theFont)
	{
		NSApplication.EnsureUIThread();
		if (theFont == null)
		{
			throw new ArgumentNullException("theFont");
		}
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_IntPtr(base.Handle, selDefaultLineHeightForFont_Handle, theFont.Handle);
		}
		return Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selDefaultLineHeightForFont_Handle, theFont.Handle);
	}

	[Export("defaultBaselineOffsetForFont:")]
	public virtual double DefaultBaselineOffsetForFont(NSFont theFont)
	{
		NSApplication.EnsureUIThread();
		if (theFont == null)
		{
			throw new ArgumentNullException("theFont");
		}
		if (IsDirectBinding)
		{
			return Messaging.Double_objc_msgSend_IntPtr(base.Handle, selDefaultBaselineOffsetForFont_Handle, theFont.Handle);
		}
		return Messaging.Double_objc_msgSendSuper_IntPtr(base.SuperHandle, selDefaultBaselineOffsetForFont_Handle, theFont.Handle);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_AttributedString_var = null;
			__mt_TextContainers_var = null;
			__mt_ExtraLineFragmentTextContainer_var = null;
			__mt_TextStorage_var = null;
			__mt_GlyphGenerator_var = null;
			__mt_Typesetter_var = null;
			__mt_WeakDelegate_var = null;
		}
	}
}
