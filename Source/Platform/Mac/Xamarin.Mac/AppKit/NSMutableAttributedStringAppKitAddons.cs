using System;
using Foundation;
using ObjCRuntime;

namespace AppKit;

public static class NSMutableAttributedStringAppKitAddons
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyFontTraits_Range_ = "applyFontTraits:range:";

	private static readonly IntPtr selApplyFontTraits_Range_Handle = Selector.GetHandle("applyFontTraits:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFixAttachmentAttributeInRange_ = "fixAttachmentAttributeInRange:";

	private static readonly IntPtr selFixAttachmentAttributeInRange_Handle = Selector.GetHandle("fixAttachmentAttributeInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFixFontAttributeInRange_ = "fixFontAttributeInRange:";

	private static readonly IntPtr selFixFontAttributeInRange_Handle = Selector.GetHandle("fixFontAttributeInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFixParagraphStyleAttributeInRange_ = "fixParagraphStyleAttributeInRange:";

	private static readonly IntPtr selFixParagraphStyleAttributeInRange_Handle = Selector.GetHandle("fixParagraphStyleAttributeInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadFromData_Options_DocumentAttributes_ = "readFromData:options:documentAttributes:";

	private static readonly IntPtr selReadFromData_Options_DocumentAttributes_Handle = Selector.GetHandle("readFromData:options:documentAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadFromData_Options_DocumentAttributes_Error_ = "readFromData:options:documentAttributes:error:";

	private static readonly IntPtr selReadFromData_Options_DocumentAttributes_Error_Handle = Selector.GetHandle("readFromData:options:documentAttributes:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadFromURL_Options_DocumentAttributes_ = "readFromURL:options:documentAttributes:";

	private static readonly IntPtr selReadFromURL_Options_DocumentAttributes_Handle = Selector.GetHandle("readFromURL:options:documentAttributes:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReadFromURL_Options_DocumentAttributes_Error_ = "readFromURL:options:documentAttributes:error:";

	private static readonly IntPtr selReadFromURL_Options_DocumentAttributes_Error_Handle = Selector.GetHandle("readFromURL:options:documentAttributes:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetAlignment_Range_ = "setAlignment:range:";

	private static readonly IntPtr selSetAlignment_Range_Handle = Selector.GetHandle("setAlignment:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetBaseWritingDirection_Range_ = "setBaseWritingDirection:range:";

	private static readonly IntPtr selSetBaseWritingDirection_Range_Handle = Selector.GetHandle("setBaseWritingDirection:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSubscriptRange_ = "subscriptRange:";

	private static readonly IntPtr selSubscriptRange_Handle = Selector.GetHandle("subscriptRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSuperscriptRange_ = "superscriptRange:";

	private static readonly IntPtr selSuperscriptRange_Handle = Selector.GetHandle("superscriptRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnscriptRange_ = "unscriptRange:";

	private static readonly IntPtr selUnscriptRange_Handle = Selector.GetHandle("unscriptRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUpdateAttachmentsFromPath_ = "updateAttachmentsFromPath:";

	private static readonly IntPtr selUpdateAttachmentsFromPath_Handle = Selector.GetHandle("updateAttachmentsFromPath:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSMutableAttributedString");

	[Export("applyFontTraits:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void ApplyFontTraits(this NSMutableAttributedString This, NSFontTraitMask traitMask, NSRange range)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_UInt64_NSRange(This.Handle, selApplyFontTraits_Range_Handle, (ulong)traitMask, range);
	}

	[Export("fixAttachmentAttributeInRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FixAttachmentAttributeInRange(this NSMutableAttributedString This, NSRange range)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_NSRange(This.Handle, selFixAttachmentAttributeInRange_Handle, range);
	}

	[Export("fixFontAttributeInRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FixFontAttributeInRange(this NSMutableAttributedString This, NSRange range)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_NSRange(This.Handle, selFixFontAttributeInRange_Handle, range);
	}

	[Export("fixParagraphStyleAttributeInRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void FixParagraphStyleAttributeInRange(this NSMutableAttributedString This, NSRange range)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_NSRange(This.Handle, selFixParagraphStyleAttributeInRange_Handle, range);
	}

	[Export("readFromData:options:documentAttributes:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ReadFromData(this NSMutableAttributedString This, NSData data, NSDictionary options, out NSDictionary returnOptions, out NSError error)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr(This.Handle, selReadFromData_Options_DocumentAttributes_Error_Handle, data.Handle, options.Handle, ref arg, ref arg2);
		returnOptions = Runtime.GetNSObject<NSDictionary>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ReadFromData(this NSMutableAttributedString This, NSData data, NSAttributedStringDocumentAttributes options, out NSDictionary returnOptions, out NSError error)
	{
		return This.ReadFromData(data, options.GetDictionary(), out returnOptions, out error);
	}

	[Export("readFromData:options:documentAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ReadFromData(this NSMutableAttributedString This, NSData data, NSDictionary options, out NSDictionary dict)
	{
		NSApplication.EnsureUIThread();
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(This.Handle, selReadFromData_Options_DocumentAttributes_Handle, data.Handle, options.Handle, ref arg);
		dict = Runtime.GetNSObject<NSDictionary>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ReadFromData(this NSMutableAttributedString This, NSData data, NSAttributedStringDocumentAttributes options, out NSDictionary returnOptions)
	{
		return This.ReadFromData(data, options.GetDictionary(), out returnOptions);
	}

	[Export("readFromURL:options:documentAttributes:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ReadFromURL(this NSMutableAttributedString This, NSUrl url, NSDictionary options, out NSDictionary returnOptions, out NSError error)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr arg2 = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr(This.Handle, selReadFromURL_Options_DocumentAttributes_Error_Handle, url.Handle, options.Handle, ref arg, ref arg2);
		returnOptions = Runtime.GetNSObject<NSDictionary>(arg);
		error = Runtime.GetNSObject<NSError>(arg2);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ReadFromURL(this NSMutableAttributedString This, NSUrl url, NSAttributedStringDocumentAttributes options, out NSDictionary returnOptions, out NSError error)
	{
		return This.ReadFromURL(url, options.GetDictionary(), out returnOptions, out error);
	}

	[Export("readFromURL:options:documentAttributes:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ReadFromURL(this NSMutableAttributedString This, NSUrl url, NSDictionary options, out NSDictionary returnOptions)
	{
		NSApplication.EnsureUIThread();
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		IntPtr arg = IntPtr.Zero;
		bool result = Messaging.bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr(This.Handle, selReadFromURL_Options_DocumentAttributes_Handle, url.Handle, options.Handle, ref arg);
		returnOptions = Runtime.GetNSObject<NSDictionary>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static bool ReadFromURL(this NSMutableAttributedString This, NSUrl url, NSAttributedStringDocumentAttributes options, out NSDictionary returnOptions)
	{
		return This.ReadFromURL(url, options.GetDictionary(), out returnOptions);
	}

	[Export("setAlignment:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetAlignment(this NSMutableAttributedString This, NSTextAlignment alignment, NSRange range)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_UInt64_NSRange(This.Handle, selSetAlignment_Range_Handle, (ulong)alignment, range);
	}

	[Export("setBaseWritingDirection:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SetBaseWritingDirection(this NSMutableAttributedString This, NSWritingDirection writingDirection, NSRange range)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_Int64_NSRange(This.Handle, selSetBaseWritingDirection_Range_Handle, (long)writingDirection, range);
	}

	[Export("subscriptRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SubscriptRange(this NSMutableAttributedString This, NSRange range)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_NSRange(This.Handle, selSubscriptRange_Handle, range);
	}

	[Export("superscriptRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void SuperscriptRange(this NSMutableAttributedString This, NSRange range)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_NSRange(This.Handle, selSuperscriptRange_Handle, range);
	}

	[Export("unscriptRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UnscriptRange(this NSMutableAttributedString This, NSRange range)
	{
		NSApplication.EnsureUIThread();
		Messaging.void_objc_msgSend_NSRange(This.Handle, selUnscriptRange_Handle, range);
	}

	[Export("updateAttachmentsFromPath:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void UpdateAttachmentsFromPath(this NSMutableAttributedString This, string path)
	{
		NSApplication.EnsureUIThread();
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr intPtr = NSString.CreateNative(path);
		Messaging.void_objc_msgSend_IntPtr(This.Handle, selUpdateAttachmentsFromPath_Handle, intPtr);
		NSString.ReleaseNative(intPtr);
	}
}
