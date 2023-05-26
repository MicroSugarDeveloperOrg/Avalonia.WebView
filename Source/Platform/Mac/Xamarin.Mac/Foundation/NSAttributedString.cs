using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using CoreGraphics;
using CoreText;
using ObjCRuntime;

namespace Foundation;

[Register("NSAttributedString", true)]
public class NSAttributedString : NSObject
{
	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	private static readonly IntPtr selSizeHandle = Selector.GetHandle("size");

	private static readonly IntPtr selAttributesAtIndexEffectiveRange_Handle = Selector.GetHandle("attributesAtIndex:effectiveRange:");

	private static readonly IntPtr selAttributeAtIndexEffectiveRange_Handle = Selector.GetHandle("attribute:atIndex:effectiveRange:");

	private static readonly IntPtr selAttributedSubstringFromRange_Handle = Selector.GetHandle("attributedSubstringFromRange:");

	private static readonly IntPtr selAttributesAtIndexLongestEffectiveRangeInRange_Handle = Selector.GetHandle("attributesAtIndex:longestEffectiveRange:inRange:");

	private static readonly IntPtr selAttributeAtIndexLongestEffectiveRangeInRange_Handle = Selector.GetHandle("attribute:atIndex:longestEffectiveRange:inRange:");

	private static readonly IntPtr selIsEqualToAttributedString_Handle = Selector.GetHandle("isEqualToAttributedString:");

	private static readonly IntPtr selInitWithString_Handle = Selector.GetHandle("initWithString:");

	private static readonly IntPtr selInitWithStringAttributes_Handle = Selector.GetHandle("initWithString:attributes:");

	private static readonly IntPtr selInitWithAttributedString_Handle = Selector.GetHandle("initWithAttributedString:");

	private static readonly IntPtr selEnumerateAttributesInRangeOptionsUsingBlock_Handle = Selector.GetHandle("enumerateAttributesInRange:options:usingBlock:");

	private static readonly IntPtr selEnumerateAttributeInRangeOptionsUsingBlock_Handle = Selector.GetHandle("enumerateAttribute:inRange:options:usingBlock:");

	private static readonly IntPtr selInitWithDataOptionsDocumentAttributesError_Handle = Selector.GetHandle("initWithData:options:documentAttributes:error:");

	private static readonly IntPtr selInitWithDocFormatDocumentAttributes_Handle = Selector.GetHandle("initWithDocFormat:documentAttributes:");

	private static readonly IntPtr selInitWithHTMLBaseURLDocumentAttributes_Handle = Selector.GetHandle("initWithHTML:baseURL:documentAttributes:");

	private static readonly IntPtr selDrawAtPoint_Handle = Selector.GetHandle("drawAtPoint:");

	private static readonly IntPtr selDrawInRect_Handle = Selector.GetHandle("drawInRect:");

	private static readonly IntPtr selDrawWithRectOptions_Handle = Selector.GetHandle("drawWithRect:options:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSAttributedString");

	private static NSString _FontAttributeName;

	private static NSString _LinkAttributeName;

	private static NSString _UnderlineStyleAttributeName;

	private static NSString _StrikethroughStyleAttributeName;

	private static NSString _StrokeWidthAttributeName;

	private static NSString _ParagraphStyleAttributeName;

	private static NSString _ForegroundColorAttributeName;

	private static NSString _BackgroundColorAttributeName;

	private static NSString _LigatureAttributeName;

	private static NSString _ObliquenessAttributeName;

	private static NSString _SuperscriptAttributeName;

	private static NSString _AttachmentAttributeName;

	private static NSString _BaselineOffsetAttributeName;

	private static NSString _KernAttributeName;

	private static NSString _StrokeColorAttributeName;

	private static NSString _UnderlineColorAttributeName;

	private static NSString _StrikethroughColorAttributeName;

	private static NSString _ShadowAttributeName;

	private static NSString _ExpansionAttributeName;

	private static NSString _CursorAttributeName;

	private static NSString _ToolTipAttributeName;

	private static NSString _MarkedClauseSegmentAttributeName;

	private static NSString _WritingDirectionAttributeName;

	private static NSString _VerticalGlyphFormAttributeName;

	public override IntPtr ClassHandle => class_ptr;

	public virtual string Value
	{
		[Export("string")]
		get
		{
			if (IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringHandle));
		}
	}

	public virtual ulong Length
	{
		[Export("length")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.UInt64_objc_msgSend(base.Handle, selLengthHandle);
			}
			return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selLengthHandle);
		}
	}

	public virtual CGSize Size
	{
		[Export("size")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.CGSize_objc_msgSend(base.Handle, selSizeHandle);
			}
			return Messaging.CGSize_objc_msgSendSuper(base.SuperHandle, selSizeHandle);
		}
	}

	[Field("NSFontAttributeName", "AppKit")]
	public static NSString FontAttributeName
	{
		get
		{
			if (_FontAttributeName == null)
			{
				_FontAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSFontAttributeName");
			}
			return _FontAttributeName;
		}
	}

	[Field("NSLinkAttributeName", "AppKit")]
	public static NSString LinkAttributeName
	{
		get
		{
			if (_LinkAttributeName == null)
			{
				_LinkAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSLinkAttributeName");
			}
			return _LinkAttributeName;
		}
	}

	[Field("NSUnderlineStyleAttributeName", "AppKit")]
	public static NSString UnderlineStyleAttributeName
	{
		get
		{
			if (_UnderlineStyleAttributeName == null)
			{
				_UnderlineStyleAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSUnderlineStyleAttributeName");
			}
			return _UnderlineStyleAttributeName;
		}
	}

	[Field("NSStrikethroughStyleAttributeName", "AppKit")]
	public static NSString StrikethroughStyleAttributeName
	{
		get
		{
			if (_StrikethroughStyleAttributeName == null)
			{
				_StrikethroughStyleAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSStrikethroughStyleAttributeName");
			}
			return _StrikethroughStyleAttributeName;
		}
	}

	[Field("NSStrokeWidthAttributeName", "AppKit")]
	public static NSString StrokeWidthAttributeName
	{
		get
		{
			if (_StrokeWidthAttributeName == null)
			{
				_StrokeWidthAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSStrokeWidthAttributeName");
			}
			return _StrokeWidthAttributeName;
		}
	}

	[Field("NSParagraphStyleAttributeName", "AppKit")]
	public static NSString ParagraphStyleAttributeName
	{
		get
		{
			if (_ParagraphStyleAttributeName == null)
			{
				_ParagraphStyleAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSParagraphStyleAttributeName");
			}
			return _ParagraphStyleAttributeName;
		}
	}

	[Field("NSForegroundColorAttributeName", "AppKit")]
	public static NSString ForegroundColorAttributeName
	{
		get
		{
			if (_ForegroundColorAttributeName == null)
			{
				_ForegroundColorAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSForegroundColorAttributeName");
			}
			return _ForegroundColorAttributeName;
		}
	}

	[Field("NSBackgroundColorAttributeName", "AppKit")]
	public static NSString BackgroundColorAttributeName
	{
		get
		{
			if (_BackgroundColorAttributeName == null)
			{
				_BackgroundColorAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSBackgroundColorAttributeName");
			}
			return _BackgroundColorAttributeName;
		}
	}

	[Field("NSLigatureAttributeName", "AppKit")]
	public static NSString LigatureAttributeName
	{
		get
		{
			if (_LigatureAttributeName == null)
			{
				_LigatureAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSLigatureAttributeName");
			}
			return _LigatureAttributeName;
		}
	}

	[Field("NSObliquenessAttributeName", "AppKit")]
	public static NSString ObliquenessAttributeName
	{
		get
		{
			if (_ObliquenessAttributeName == null)
			{
				_ObliquenessAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSObliquenessAttributeName");
			}
			return _ObliquenessAttributeName;
		}
	}

	[Field("NSSuperscriptAttributeName", "AppKit")]
	public static NSString SuperscriptAttributeName
	{
		get
		{
			if (_SuperscriptAttributeName == null)
			{
				_SuperscriptAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSSuperscriptAttributeName");
			}
			return _SuperscriptAttributeName;
		}
	}

	[Field("NSAttachmentAttributeName", "AppKit")]
	public static NSString AttachmentAttributeName
	{
		get
		{
			if (_AttachmentAttributeName == null)
			{
				_AttachmentAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSAttachmentAttributeName");
			}
			return _AttachmentAttributeName;
		}
	}

	[Field("NSBaselineOffsetAttributeName", "AppKit")]
	public static NSString BaselineOffsetAttributeName
	{
		get
		{
			if (_BaselineOffsetAttributeName == null)
			{
				_BaselineOffsetAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSBaselineOffsetAttributeName");
			}
			return _BaselineOffsetAttributeName;
		}
	}

	[Field("NSKernAttributeName", "AppKit")]
	public static NSString KernAttributeName
	{
		get
		{
			if (_KernAttributeName == null)
			{
				_KernAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSKernAttributeName");
			}
			return _KernAttributeName;
		}
	}

	[Field("NSStrokeColorAttributeName", "AppKit")]
	public static NSString StrokeColorAttributeName
	{
		get
		{
			if (_StrokeColorAttributeName == null)
			{
				_StrokeColorAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSStrokeColorAttributeName");
			}
			return _StrokeColorAttributeName;
		}
	}

	[Field("NSUnderlineColorAttributeName", "AppKit")]
	public static NSString UnderlineColorAttributeName
	{
		get
		{
			if (_UnderlineColorAttributeName == null)
			{
				_UnderlineColorAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSUnderlineColorAttributeName");
			}
			return _UnderlineColorAttributeName;
		}
	}

	[Field("NSStrikethroughColorAttributeName", "AppKit")]
	public static NSString StrikethroughColorAttributeName
	{
		get
		{
			if (_StrikethroughColorAttributeName == null)
			{
				_StrikethroughColorAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSStrikethroughColorAttributeName");
			}
			return _StrikethroughColorAttributeName;
		}
	}

	[Field("NSShadowAttributeName", "AppKit")]
	public static NSString ShadowAttributeName
	{
		get
		{
			if (_ShadowAttributeName == null)
			{
				_ShadowAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSShadowAttributeName");
			}
			return _ShadowAttributeName;
		}
	}

	[Field("NSExpansionAttributeName", "AppKit")]
	public static NSString ExpansionAttributeName
	{
		get
		{
			if (_ExpansionAttributeName == null)
			{
				_ExpansionAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSExpansionAttributeName");
			}
			return _ExpansionAttributeName;
		}
	}

	[Field("NSCursorAttributeName", "AppKit")]
	public static NSString CursorAttributeName
	{
		get
		{
			if (_CursorAttributeName == null)
			{
				_CursorAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSCursorAttributeName");
			}
			return _CursorAttributeName;
		}
	}

	[Field("NSToolTipAttributeName", "AppKit")]
	public static NSString ToolTipAttributeName
	{
		get
		{
			if (_ToolTipAttributeName == null)
			{
				_ToolTipAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSToolTipAttributeName");
			}
			return _ToolTipAttributeName;
		}
	}

	[Field("NSMarkedClauseSegmentAttributeName", "AppKit")]
	public static NSString MarkedClauseSegmentAttributeName
	{
		get
		{
			if (_MarkedClauseSegmentAttributeName == null)
			{
				_MarkedClauseSegmentAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSMarkedClauseSegmentAttributeName");
			}
			return _MarkedClauseSegmentAttributeName;
		}
	}

	[Field("NSWritingDirectionAttributeName", "AppKit")]
	public static NSString WritingDirectionAttributeName
	{
		get
		{
			if (_WritingDirectionAttributeName == null)
			{
				_WritingDirectionAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSWritingDirectionAttributeName");
			}
			return _WritingDirectionAttributeName;
		}
	}

	[Field("NSVerticalGlyphFormAttributeName", "AppKit")]
	public static NSString VerticalGlyphFormAttributeName
	{
		get
		{
			if (_VerticalGlyphFormAttributeName == null)
			{
				_VerticalGlyphFormAttributeName = Dlfcn.GetStringConstant(Libraries.AppKit.Handle, "NSVerticalGlyphFormAttributeName");
			}
			return _VerticalGlyphFormAttributeName;
		}
	}

	public NSAttributedString(string str, CTStringAttributes attributes)
		: this(str, attributes?.Dictionary)
	{
	}

	public CTStringAttributes GetCoreTextAttributes(ulong location, out NSRange effectiveRange)
	{
		NSDictionary attributes = GetAttributes(location, out effectiveRange);
		if (attributes != null)
		{
			return new CTStringAttributes(attributes);
		}
		return null;
	}

	public CTStringAttributes GetCoreTextAttributes(ulong location, out NSRange longestEffectiveRange, NSRange rangeLimit)
	{
		NSDictionary attributes = GetAttributes(location, out longestEffectiveRange, rangeLimit);
		if (attributes != null)
		{
			return new CTStringAttributes(attributes);
		}
		return null;
	}

	public NSAttributedString Substring(int start, int len)
	{
		return Substring(new NSRange(start, len));
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSAttributedString()
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
	public NSAttributedString(NSCoder coder)
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
	public NSAttributedString(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSAttributedString(IntPtr handle)
		: base(handle)
	{
	}

	[Export("attributesAtIndex:effectiveRange:")]
	public virtual NSDictionary GetAttributes(ulong location, out NSRange effectiveRange)
	{
		if (IsDirectBinding)
		{
			return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_out_NSRange(base.Handle, selAttributesAtIndexEffectiveRange_Handle, location, out effectiveRange));
		}
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64_out_NSRange(base.SuperHandle, selAttributesAtIndexEffectiveRange_Handle, location, out effectiveRange));
	}

	[Export("attribute:atIndex:effectiveRange:")]
	public virtual NSObject GetAttribute(string attribute, ulong location, out NSRange effectiveRange)
	{
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		IntPtr arg = NSString.CreateNative(attribute);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_out_NSRange(base.SuperHandle, selAttributeAtIndexEffectiveRange_Handle, arg, location, out effectiveRange)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_out_NSRange(base.Handle, selAttributeAtIndexEffectiveRange_Handle, arg, location, out effectiveRange)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("attributedSubstringFromRange:")]
	internal virtual NSAttributedString Substring(NSRange range)
	{
		if (IsDirectBinding)
		{
			return (NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selAttributedSubstringFromRange_Handle, range));
		}
		return (NSAttributedString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selAttributedSubstringFromRange_Handle, range));
	}

	[Export("attributesAtIndex:longestEffectiveRange:inRange:")]
	public virtual NSDictionary GetAttributes(ulong location, out NSRange longestEffectiveRange, NSRange rangeLimit)
	{
		if (IsDirectBinding)
		{
			return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_UInt64_out_NSRange_NSRange(base.Handle, selAttributesAtIndexLongestEffectiveRangeInRange_Handle, location, out longestEffectiveRange, rangeLimit));
		}
		return (NSDictionary)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_UInt64_out_NSRange_NSRange(base.SuperHandle, selAttributesAtIndexLongestEffectiveRangeInRange_Handle, location, out longestEffectiveRange, rangeLimit));
	}

	[Export("attribute:atIndex:longestEffectiveRange:inRange:")]
	public virtual NSObject GetAttribute(string attribute, ulong location, out NSRange longestEffectiveRange, NSRange rangeLimit)
	{
		if (attribute == null)
		{
			throw new ArgumentNullException("attribute");
		}
		IntPtr arg = NSString.CreateNative(attribute);
		NSObject result = ((!IsDirectBinding) ? Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_out_NSRange_NSRange(base.SuperHandle, selAttributeAtIndexLongestEffectiveRangeInRange_Handle, arg, location, out longestEffectiveRange, rangeLimit)) : Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_out_NSRange_NSRange(base.Handle, selAttributeAtIndexLongestEffectiveRangeInRange_Handle, arg, location, out longestEffectiveRange, rangeLimit)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("isEqualToAttributedString:")]
	public virtual bool IsEqual(NSAttributedString other)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToAttributedString_Handle, other.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToAttributedString_Handle, other.Handle);
	}

	[Export("initWithString:")]
	public NSAttributedString(string str)
		: base(NSObjectFlag.Empty)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithString_Handle, arg);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithString_Handle, arg);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithString:attributes:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSAttributedString(string str, NSDictionary attributes)
		: base(NSObjectFlag.Empty)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		IntPtr arg = NSString.CreateNative(str);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithStringAttributes_Handle, arg, attributes.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithStringAttributes_Handle, arg, attributes.Handle);
		}
		NSString.ReleaseNative(arg);
	}

	[Export("initWithAttributedString:")]
	public NSAttributedString(NSAttributedString other)
		: base(NSObjectFlag.Empty)
	{
		if (other == null)
		{
			throw new ArgumentNullException("other");
		}
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selInitWithAttributedString_Handle, other.Handle);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selInitWithAttributedString_Handle, other.Handle);
		}
	}

	[Export("enumerateAttributesInRange:options:usingBlock:")]
	public unsafe virtual void EnumerateAttributes(NSRange range, NSAttributedStringEnumeration options, NSAttributedRangeCallback callback)
	{
		if (callback == null)
		{
			throw new ArgumentNullException("callback");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlock(Trampolines.SDNSAttributedRangeCallback.Handler, callback);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_UInt64_IntPtr(base.Handle, selEnumerateAttributesInRangeOptionsUsingBlock_Handle, range, (ulong)options, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_UInt64_IntPtr(base.SuperHandle, selEnumerateAttributesInRangeOptionsUsingBlock_Handle, range, (ulong)options, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("enumerateAttribute:inRange:options:usingBlock:")]
	public unsafe virtual void EnumerateAttribute(NSString attributeName, NSRange inRange, NSAttributedStringEnumeration options, NSAttributedStringCallback callback)
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
		blockLiteral.SetupBlock(Trampolines.SDNSAttributedStringCallback.Handler, callback);
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr(base.Handle, selEnumerateAttributeInRangeOptionsUsingBlock_Handle, attributeName.Handle, inRange, (ulong)options, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_NSRange_UInt64_IntPtr(base.SuperHandle, selEnumerateAttributeInRangeOptionsUsingBlock_Handle, attributeName.Handle, inRange, (ulong)options, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("initWithData:options:documentAttributes:error:")]
	public NSAttributedString(NSData data, NSDictionary options, out NSDictionary docAttributes, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		IntPtr intPtr2 = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr2, 0);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithDataOptionsDocumentAttributesError_Handle, data.Handle, options.Handle, intPtr, intPtr2);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithDataOptionsDocumentAttributesError_Handle, data.Handle, options.Handle, intPtr, intPtr2);
		}
		IntPtr intPtr3 = Marshal.ReadIntPtr(intPtr);
		docAttributes = ((intPtr3 != IntPtr.Zero) ? ((NSDictionary)Runtime.GetNSObject(intPtr3)) : null);
		Marshal.FreeHGlobal(intPtr);
		IntPtr intPtr4 = Marshal.ReadIntPtr(intPtr2);
		error = ((intPtr4 != IntPtr.Zero) ? ((NSError)Runtime.GetNSObject(intPtr4)) : null);
		Marshal.FreeHGlobal(intPtr2);
	}

	[Export("initWithDocFormat:documentAttributes:")]
	public NSAttributedString(NSData wordDocFormat, out NSDictionary docAttributes)
		: base(NSObjectFlag.Empty)
	{
		if (wordDocFormat == null)
		{
			throw new ArgumentNullException("wordDocFormat");
		}
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr(base.Handle, selInitWithDocFormatDocumentAttributes_Handle, wordDocFormat.Handle, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr(base.SuperHandle, selInitWithDocFormatDocumentAttributes_Handle, wordDocFormat.Handle, intPtr);
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		docAttributes = ((intPtr2 != IntPtr.Zero) ? ((NSDictionary)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("initWithHTML:baseURL:documentAttributes:")]
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
		IntPtr intPtr = Marshal.AllocHGlobal(4);
		Marshal.WriteInt32(intPtr, 0);
		if (IsDirectBinding)
		{
			base.Handle = Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr(base.Handle, selInitWithHTMLBaseURLDocumentAttributes_Handle, htmlData.Handle, baseUrl.Handle, intPtr);
		}
		else
		{
			base.Handle = Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr(base.SuperHandle, selInitWithHTMLBaseURLDocumentAttributes_Handle, htmlData.Handle, baseUrl.Handle, intPtr);
		}
		IntPtr intPtr2 = Marshal.ReadIntPtr(intPtr);
		docAttributes = ((intPtr2 != IntPtr.Zero) ? ((NSDictionary)Runtime.GetNSObject(intPtr2)) : null);
		Marshal.FreeHGlobal(intPtr);
	}

	[Export("drawAtPoint:")]
	public virtual void DrawString(CGPoint point)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGPoint(base.Handle, selDrawAtPoint_Handle, point);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGPoint(base.SuperHandle, selDrawAtPoint_Handle, point);
		}
	}

	[Export("drawInRect:")]
	public virtual void DrawString(CGRect rect)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect(base.Handle, selDrawInRect_Handle, rect);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect(base.SuperHandle, selDrawInRect_Handle, rect);
		}
	}

	[Export("drawWithRect:options:")]
	public virtual void DrawString(CGRect rect, NSStringDrawingOptions options)
	{
		if (IsDirectBinding)
		{
			Messaging.void_objc_msgSend_CGRect_UInt64(base.Handle, selDrawWithRectOptions_Handle, rect, (ulong)options);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_CGRect_UInt64(base.SuperHandle, selDrawWithRectOptions_Handle, rect, (ulong)options);
		}
	}
}
