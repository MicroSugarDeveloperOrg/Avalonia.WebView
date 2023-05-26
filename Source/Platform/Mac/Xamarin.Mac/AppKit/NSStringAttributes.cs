using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public class NSStringAttributes : DictionaryContainer
{
	public NSUrl LinkUrl
	{
		get
		{
			return Link as NSUrl;
		}
		set
		{
			Link = value;
		}
	}

	public NSString LinkString
	{
		get
		{
			return Link as NSString;
		}
		set
		{
			Link = value;
		}
	}

	public NSFont Font
	{
		get
		{
			return Get(NSStringAttributeKey.Font, (IntPtr handle) => new NSFont(handle));
		}
		set
		{
			SetNativeValue(NSStringAttributeKey.Font, value);
		}
	}

	public NSParagraphStyle ParagraphStyle
	{
		get
		{
			return Get(NSStringAttributeKey.ParagraphStyle, (IntPtr handle) => new NSParagraphStyle(handle));
		}
		set
		{
			SetNativeValue(NSStringAttributeKey.ParagraphStyle, value);
		}
	}

	public NSColor ForegroundColor
	{
		get
		{
			return Get(NSStringAttributeKey.ForegroundColor, (IntPtr handle) => new NSColor(handle));
		}
		set
		{
			SetNativeValue(NSStringAttributeKey.ForegroundColor, value);
		}
	}

	public int? UnderlineStyle
	{
		get
		{
			return GetInt32Value(NSStringAttributeKey.UnderlineStyle);
		}
		set
		{
			SetNumberValue(NSStringAttributeKey.UnderlineStyle, value);
		}
	}

	public bool? Superscript
	{
		get
		{
			return GetBool(NSStringAttributeKey.Superscript);
		}
		set
		{
			Set(NSStringAttributeKey.Superscript, value);
		}
	}

	public NSColor BackgroundColor
	{
		get
		{
			return Get(NSStringAttributeKey.BackgroundColor, (IntPtr handle) => new NSColor(handle));
		}
		set
		{
			SetNativeValue(NSStringAttributeKey.BackgroundColor, value);
		}
	}

	public NSTextAttachment Attachment
	{
		get
		{
			return Get(NSStringAttributeKey.Attachment, (IntPtr handle) => new NSTextAttachment(handle));
		}
		set
		{
			SetNativeValue(NSStringAttributeKey.Attachment, value);
		}
	}

	public NSLigatureType? Ligature
	{
		get
		{
			return (NSLigatureType?)GetInt32Value(NSStringAttributeKey.Ligature);
		}
		set
		{
			SetNumberValue(NSStringAttributeKey.Ligature, (int?)value);
		}
	}

	public float? BaselineOffset
	{
		get
		{
			return GetFloatValue(NSStringAttributeKey.BaselineOffset);
		}
		set
		{
			SetNumberValue(NSStringAttributeKey.BaselineOffset, value);
		}
	}

	public float? KerningAdjustment
	{
		get
		{
			return GetFloatValue(NSStringAttributeKey.KerningAdjustment);
		}
		set
		{
			SetNumberValue(NSStringAttributeKey.KerningAdjustment, value);
		}
	}

	private NSObject Link
	{
		get
		{
			IntPtr intPtr = Get(NSStringAttributeKey.Link);
			return (intPtr == IntPtr.Zero) ? null : Runtime.GetNSObject(intPtr);
		}
		set
		{
			SetNativeValue(NSStringAttributeKey.Link, value);
		}
	}

	public float? StrokeWidth
	{
		get
		{
			return GetFloatValue(NSStringAttributeKey.StrokeWidth);
		}
		set
		{
			SetNumberValue(NSStringAttributeKey.StrokeWidth, value);
		}
	}

	public NSColor StrokeColor
	{
		get
		{
			return Get(NSStringAttributeKey.StrokeColor, (IntPtr handle) => new NSColor(handle));
		}
		set
		{
			SetNativeValue(NSStringAttributeKey.StrokeColor, value);
		}
	}

	public NSColor UnderlineColor
	{
		get
		{
			return Get(NSStringAttributeKey.UnderlineColor, (IntPtr handle) => new NSColor(handle));
		}
		set
		{
			SetNativeValue(NSStringAttributeKey.UnderlineColor, value);
		}
	}

	public int? StrikethroughStyle
	{
		get
		{
			return GetInt32Value(NSStringAttributeKey.StrikethroughStyle);
		}
		set
		{
			SetNumberValue(NSStringAttributeKey.StrikethroughStyle, value);
		}
	}

	public NSColor StrikethroughColor
	{
		get
		{
			return Get(NSStringAttributeKey.StrikethroughColor, (IntPtr handle) => new NSColor(handle));
		}
		set
		{
			SetNativeValue(NSStringAttributeKey.StrikethroughColor, value);
		}
	}

	public NSShadow Shadow
	{
		get
		{
			return Get(NSStringAttributeKey.Shadow, (IntPtr handle) => new NSShadow(handle));
		}
		set
		{
			SetNativeValue(NSStringAttributeKey.Shadow, value);
		}
	}

	public float? Obliqueness
	{
		get
		{
			return GetFloatValue(NSStringAttributeKey.Obliqueness);
		}
		set
		{
			SetNumberValue(NSStringAttributeKey.Obliqueness, value);
		}
	}

	public float? Expansion
	{
		get
		{
			return GetFloatValue(NSStringAttributeKey.Expansion);
		}
		set
		{
			SetNumberValue(NSStringAttributeKey.Expansion, value);
		}
	}

	public NSCursor Cursor
	{
		get
		{
			return Get(NSStringAttributeKey.Cursor, (IntPtr handle) => new NSCursor(handle));
		}
		set
		{
			SetNativeValue(NSStringAttributeKey.Cursor, value);
		}
	}

	public string ToolTip
	{
		get
		{
			return Get(NSStringAttributeKey.ToolTip, (IntPtr handle) => new NSString(handle));
		}
		set
		{
			SetNativeValue(NSStringAttributeKey.ToolTip, new NSString(value));
		}
	}

	public int? CharacterShape
	{
		get
		{
			return GetInt32Value(NSStringAttributeKey.CharacterShape);
		}
		set
		{
			SetNumberValue(NSStringAttributeKey.CharacterShape, value);
		}
	}

	public NSGlyphInfo GlyphInfo
	{
		get
		{
			return Get(NSStringAttributeKey.GlyphInfo, (IntPtr handle) => new NSGlyphInfo(handle));
		}
		set
		{
			SetNativeValue(NSStringAttributeKey.GlyphInfo, value);
		}
	}

	public NSArray WritingDirection
	{
		get
		{
			return Get(NSStringAttributeKey.WritingDirection, (IntPtr handle) => new NSArray(handle));
		}
		set
		{
			SetNativeValue(NSStringAttributeKey.GlyphInfo, value);
		}
	}

	public bool? MarkedClauseSegment
	{
		get
		{
			return GetBool(NSStringAttributeKey.MarkedClauseSegment);
		}
		set
		{
			Set(NSStringAttributeKey.MarkedClauseSegment, value);
		}
	}

	public NSTextLayoutOrientation? VerticalGlyphForm
	{
		get
		{
			return (NSTextLayoutOrientation?)GetInt32Value(NSStringAttributeKey.VerticalGlyphForm);
		}
		set
		{
			SetNumberValue(NSStringAttributeKey.VerticalGlyphForm, (int?)value);
		}
	}

	public NSTextAlternatives TextAlternatives
	{
		get
		{
			return Get(NSStringAttributeKey.TextAlternatives, (IntPtr handle) => new NSTextAlternatives(handle));
		}
		set
		{
			SetNativeValue(NSStringAttributeKey.TextAlternatives, value);
		}
	}

	public NSSpellingState? SpellingState
	{
		get
		{
			return (NSSpellingState?)GetInt32Value(NSStringAttributeKey.SpellingState);
		}
		set
		{
			SetNumberValue(NSStringAttributeKey.SpellingState, (int?)value);
		}
	}

	internal static NSDictionary ToDictionary(NSFont font, NSColor foregroundColor, NSColor backgroundColor, NSColor strokeColor, NSColor underlineColor, NSColor strikethroughColor, NSUnderlineStyle underlineStyle, NSUnderlineStyle strikethroughStyle, NSParagraphStyle paragraphStyle, float strokeWidth, NSShadow shadow, NSUrl link, bool superscript, NSTextAttachment attachment, NSLigatureType ligature, float baselineOffset, float kerningAdjustment, float obliqueness, float expansion, NSCursor cursor, string toolTip, int characterShape, NSGlyphInfo glyphInfo, NSArray writingDirection, bool markedClauseSegment, NSTextLayoutOrientation verticalGlyphForm, NSTextAlternatives textAlternatives, NSSpellingState spellingState)
	{
		NSStringAttributes nSStringAttributes = new NSStringAttributes();
		if (font != null)
		{
			nSStringAttributes.Font = font;
		}
		if (paragraphStyle != null)
		{
			nSStringAttributes.ParagraphStyle = paragraphStyle;
		}
		if (foregroundColor != null)
		{
			nSStringAttributes.ForegroundColor = foregroundColor;
		}
		if (underlineStyle != NSUnderlineStyle.None)
		{
			nSStringAttributes.UnderlineStyle = (int)underlineStyle;
		}
		if (superscript)
		{
			nSStringAttributes.Superscript = true;
		}
		if (backgroundColor != null)
		{
			nSStringAttributes.BackgroundColor = backgroundColor;
		}
		if (attachment != null)
		{
			nSStringAttributes.Attachment = attachment;
		}
		if (ligature != NSLigatureType.Default)
		{
			nSStringAttributes.Ligature = ligature;
		}
		if (baselineOffset != 0f)
		{
			nSStringAttributes.BaselineOffset = baselineOffset;
		}
		if (kerningAdjustment != 0f)
		{
			nSStringAttributes.KerningAdjustment = kerningAdjustment;
		}
		if (link != null)
		{
			nSStringAttributes.Link = link;
		}
		if (strokeWidth != 0f)
		{
			nSStringAttributes.StrokeWidth = strokeWidth;
		}
		if (strokeColor != null)
		{
			nSStringAttributes.StrokeColor = strokeColor;
		}
		if (underlineColor != null)
		{
			nSStringAttributes.UnderlineColor = underlineColor;
		}
		if (strikethroughStyle != NSUnderlineStyle.None)
		{
			nSStringAttributes.StrikethroughStyle = (int)strikethroughStyle;
		}
		if (strikethroughColor != null)
		{
			nSStringAttributes.StrikethroughColor = strikethroughColor;
		}
		if (shadow != null)
		{
			nSStringAttributes.Shadow = shadow;
		}
		if (obliqueness != 0f)
		{
			nSStringAttributes.Obliqueness = obliqueness;
		}
		if (expansion != 0f)
		{
			nSStringAttributes.Expansion = expansion;
		}
		if (cursor != null)
		{
			nSStringAttributes.Cursor = cursor;
		}
		if (toolTip != null)
		{
			nSStringAttributes.ToolTip = toolTip;
		}
		if (characterShape != 0)
		{
			nSStringAttributes.CharacterShape = 0;
		}
		if (glyphInfo != null)
		{
			nSStringAttributes.GlyphInfo = glyphInfo;
		}
		if (writingDirection != null)
		{
			nSStringAttributes.WritingDirection = writingDirection;
		}
		if (markedClauseSegment)
		{
			nSStringAttributes.MarkedClauseSegment = true;
		}
		if (verticalGlyphForm != NSTextLayoutOrientation.Horizontal)
		{
			nSStringAttributes.VerticalGlyphForm = verticalGlyphForm;
		}
		if (textAlternatives != null)
		{
			nSStringAttributes.TextAlternatives = textAlternatives;
		}
		if (spellingState != 0)
		{
			nSStringAttributes.SpellingState = spellingState;
		}
		NSDictionary dictionary = nSStringAttributes.Dictionary;
		return (dictionary.Count == (byte)0) ? null : dictionary;
	}

	public NSStringAttributes()
		: base(new NSMutableDictionary())
	{
	}

	public NSStringAttributes(NSDictionary dictionary)
		: base(dictionary)
	{
	}

	private IntPtr Get(NSString key)
	{
		return CFDictionary.GetValue(base.Dictionary.Handle, key.Handle);
	}

	private T Get<T>(NSString key, Func<IntPtr, T> ctor)
	{
		IntPtr intPtr = Get(key);
		if (intPtr == IntPtr.Zero)
		{
			return default(T);
		}
		return ctor(intPtr);
	}

	private bool? GetBool(NSString key)
	{
		int? int32Value = GetInt32Value(key);
		return (!int32Value.HasValue) ? null : new bool?(int32Value.Value != 0);
	}

	private void Set(NSString key, bool? value)
	{
		SetNumberValue(key, (!value.HasValue) ? null : new int?(value.Value ? 1 : 0));
	}

	private int SetUnderlineStyle(NSString attr, NSUnderlineStyle style, NSUnderlinePattern pattern, bool byWord)
	{
		int num = (int)style | (int)pattern;
		if (byWord)
		{
			num |= (int)NSAttributedString.UnderlineByWordMaskAttributeName;
		}
		SetNumberValue(attr, num);
		return num;
	}

	public int SetUnderlineStyle(NSUnderlineStyle style = NSUnderlineStyle.None, NSUnderlinePattern pattern = NSUnderlinePattern.Solid, bool byWord = false)
	{
		return SetUnderlineStyle(NSStringAttributeKey.UnderlineStyle, style, pattern, byWord);
	}

	public int SetStrikethroughStyle(NSUnderlineStyle style = NSUnderlineStyle.None, NSUnderlinePattern pattern = NSUnderlinePattern.Solid, bool byWord = false)
	{
		return SetUnderlineStyle(NSStringAttributeKey.StrikethroughStyle, style, pattern, byWord);
	}
}
