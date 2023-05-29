using System;
using System.ComponentModel;
using CoreGraphics;
using ObjCRuntime;

namespace Foundation;

[Register("NSString", true)]
public class NSString : NSObject
{
	private const string selUTF8String = "UTF8String";

	private const string selInitWithUTF8String = "initWithUTF8String:";

	private const string selInitWithCharactersLength = "initWithCharacters:length:";

	private static IntPtr selUTF8StringHandle = Selector.GetHandle("UTF8String");

	private static IntPtr selInitWithUTF8StringHandle = Selector.GetHandle("initWithUTF8String:");

	private static IntPtr selInitWithCharactersLengthHandle = Selector.GetHandle("initWithCharacters:length:");

	private const string selDataUsingEncodingAllow = "dataUsingEncoding:allowLossyConversion:";

	private const string selInitWithDataEncoding = "initWithData:encoding:";

	private static IntPtr selDataUsingEncodingAllowHandle = Selector.GetHandle("dataUsingEncoding:allowLossyConversion:");

	private static IntPtr selInitWithDataEncodingHandle = Selector.GetHandle("initWithData:encoding:");

	private static readonly IntPtr selLengthHandle = Selector.GetHandle("length");

	private static readonly IntPtr selPathComponentsHandle = Selector.GetHandle("pathComponents");

	private static readonly IntPtr selIsAbsolutePathHandle = Selector.GetHandle("isAbsolutePath");

	private static readonly IntPtr selLastPathComponentHandle = Selector.GetHandle("lastPathComponent");

	private static readonly IntPtr selPathExtensionHandle = Selector.GetHandle("pathExtension");

	private static readonly IntPtr selSizeWithAttributes_Handle = Selector.GetHandle("sizeWithAttributes:");

	private static readonly IntPtr selBoundingRectWithSizeOptionsAttributes_Handle = Selector.GetHandle("boundingRectWithSize:options:attributes:");

	private static readonly IntPtr selDrawAtPointWithAttributes_Handle = Selector.GetHandle("drawAtPoint:withAttributes:");

	private static readonly IntPtr selDrawInRectWithAttributes_Handle = Selector.GetHandle("drawInRect:withAttributes:");

	private static readonly IntPtr selDrawWithRectOptionsAttributes_Handle = Selector.GetHandle("drawWithRect:options:attributes:");

	private static readonly IntPtr selCharacterAtIndex_Handle = Selector.GetHandle("characterAtIndex:");

	private static readonly IntPtr selHashHandle = Selector.GetHandle("hash");

	private static readonly IntPtr selIsEqualToString_Handle = Selector.GetHandle("isEqualToString:");

	private static readonly IntPtr selCompare_Handle = Selector.GetHandle("compare:");

	private static readonly IntPtr selCompareOptions_Handle = Selector.GetHandle("compare:options:");

	private static readonly IntPtr selCompareOptionsRange_Handle = Selector.GetHandle("compare:options:range:");

	private static readonly IntPtr selCompareOptionsRangeLocale_Handle = Selector.GetHandle("compare:options:range:locale:");

	private static readonly IntPtr selStringByReplacingCharactersInRangeWithString_Handle = Selector.GetHandle("stringByReplacingCharactersInRange:withString:");

	private static readonly IntPtr selPathWithComponents_Handle = Selector.GetHandle("pathWithComponents:");

	private static readonly IntPtr selStringByDeletingLastPathComponentHandle = Selector.GetHandle("stringByDeletingLastPathComponent");

	private static readonly IntPtr selStringByAppendingPathComponent_Handle = Selector.GetHandle("stringByAppendingPathComponent:");

	private static readonly IntPtr selStringByDeletingPathExtensionHandle = Selector.GetHandle("stringByDeletingPathExtension");

	private static readonly IntPtr selStringByAppendingPathExtension_Handle = Selector.GetHandle("stringByAppendingPathExtension:");

	private static readonly IntPtr selStringByAbbreviatingWithTildeInPathHandle = Selector.GetHandle("stringByAbbreviatingWithTildeInPath");

	private static readonly IntPtr selStringByExpandingTildeInPathHandle = Selector.GetHandle("stringByExpandingTildeInPath");

	private static readonly IntPtr selStringByStandardizingPathHandle = Selector.GetHandle("stringByStandardizingPath");

	private static readonly IntPtr selStringByResolvingSymlinksInPathHandle = Selector.GetHandle("stringByResolvingSymlinksInPath");

	private static readonly IntPtr selStringsByAppendingPaths_Handle = Selector.GetHandle("stringsByAppendingPaths:");

	private static readonly IntPtr selCapitalizedStringWithLocale_Handle = Selector.GetHandle("capitalizedStringWithLocale:");

	private static readonly IntPtr selLowercaseStringWithLocale_Handle = Selector.GetHandle("lowercaseStringWithLocale:");

	private static readonly IntPtr selUppercaseStringWithLocale_Handle = Selector.GetHandle("uppercaseStringWithLocale:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSString");

	private object __mt_LastPathComponent_var;

	private object __mt_PathExtension_var;

	public char this[int idx] => _characterAtIndex((ulong)idx);

	public override IntPtr ClassHandle => class_ptr;

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

	public virtual string[] PathComponents
	{
		[Export("pathComponents")]
		get
		{
			if (IsDirectBinding)
			{
				return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selPathComponentsHandle));
			}
			return NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathComponentsHandle));
		}
	}

	public virtual bool IsAbsolutePath
	{
		[Export("isAbsolutePath")]
		get
		{
			if (IsDirectBinding)
			{
				return Messaging.bool_objc_msgSend(base.Handle, selIsAbsolutePathHandle);
			}
			return Messaging.bool_objc_msgSendSuper(base.SuperHandle, selIsAbsolutePathHandle);
		}
	}

	public virtual NSString LastPathComponent
	{
		[Export("lastPathComponent")]
		get
		{
			return (NSString)(__mt_LastPathComponent_var = ((!IsDirectBinding) ? ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selLastPathComponentHandle))) : ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selLastPathComponentHandle)))));
		}
	}

	public virtual NSString PathExtension
	{
		[Export("pathExtension")]
		get
		{
			return (NSString)(__mt_PathExtension_var = ((!IsDirectBinding) ? ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPathExtensionHandle))) : ((NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selPathExtensionHandle)))));
		}
	}

	public unsafe static IntPtr CreateNative(string str)
	{
		if (str == null)
		{
			return IntPtr.Zero;
		}
		fixed (char* ptr = str)
		{
			return Messaging.intptr_objc_msgsend_intptr_int(Messaging.intptr_objc_msgSend(class_ptr, Selector.AllocHandle), selInitWithCharactersLengthHandle, (IntPtr)ptr, str.Length);
		}
	}

	public static void ReleaseNative(IntPtr handle)
	{
		if (!(handle == IntPtr.Zero))
		{
			Messaging.void_objc_msgSend(handle, Selector.ReleaseHandle);
		}
	}

	public unsafe NSString(string str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		fixed (char* ptr = str)
		{
			base.Handle = Messaging.intptr_objc_msgsend_intptr_int(base.Handle, selInitWithCharactersLengthHandle, (IntPtr)ptr, str.Length);
		}
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
		return Messaging.StringFromNativeUtf8(Messaging.intptr_objc_msgSend(usrhandle, selUTF8StringHandle));
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

	public override int GetHashCode()
	{
		return (int)base.Handle;
	}

	[Advice("Use Encode instead")]
	public NSData DataUsingEncoding(NSStringEncoding enc)
	{
		return new NSData(Messaging.IntPtr_objc_msgSend_int_int(base.Handle, selDataUsingEncodingAllowHandle, (int)enc, 0));
	}

	[Advice("Use Encode instead")]
	public NSData DataUsingEncoding(NSStringEncoding enc, bool allowLossyConversion)
	{
		return new NSData(Messaging.IntPtr_objc_msgSend_int_int(base.Handle, selDataUsingEncodingAllowHandle, (int)enc, allowLossyConversion ? 1 : 0));
	}

	public NSData Encode(NSStringEncoding enc)
	{
		return new NSData(Messaging.IntPtr_objc_msgSend_int_int(base.Handle, selDataUsingEncodingAllowHandle, (int)enc, 0));
	}

	public NSData Encode(NSStringEncoding enc, bool allowLossyConversion)
	{
		return new NSData(Messaging.IntPtr_objc_msgSend_int_int(base.Handle, selDataUsingEncodingAllowHandle, (int)enc, allowLossyConversion ? 1 : 0));
	}

	public static NSString FromData(NSData data, NSStringEncoding encoding)
	{
		return new NSString(Messaging.IntPtr_objc_msgSend_IntPtr_int(Messaging.IntPtr_objc_msgSend(Class.GetHandle("NSString"), Selector.AllocHandle), selInitWithDataEncodingHandle, data.Handle, (int)encoding));
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSString()
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
	public NSString(NSCoder coder)
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
	public NSString(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSString(IntPtr handle)
		: base(handle)
	{
	}

	public CGSize StringSize(NSDictionary attributedStringAttributes)
	{
		return Messaging.CGSize_objc_msgSend_IntPtr(base.Handle, selSizeWithAttributes_Handle, attributedStringAttributes?.Handle ?? IntPtr.Zero);
	}

	public CGRect BoundingRectWithSize(CGSize size, NSStringDrawingOptions options, NSDictionary attributes)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		Messaging.CGRect_objc_msgSend_stret_CGSize_UInt64_IntPtr(out var retval, base.Handle, selBoundingRectWithSizeOptionsAttributes_Handle, size, (ulong)options, attributes.Handle);
		return retval;
	}

	public void DrawString(CGPoint point, NSDictionary attributes)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		Messaging.void_objc_msgSend_CGPoint_IntPtr(base.Handle, selDrawAtPointWithAttributes_Handle, point, attributes.Handle);
	}

	public void DrawString(CGRect rect, NSDictionary attributes)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		Messaging.void_objc_msgSend_CGRect_IntPtr(base.Handle, selDrawInRectWithAttributes_Handle, rect, attributes.Handle);
	}

	public void DrawString(CGRect rect, NSStringDrawingOptions options, NSDictionary attributes)
	{
		if (attributes == null)
		{
			throw new ArgumentNullException("attributes");
		}
		Messaging.void_objc_msgSend_CGRect_UInt64_IntPtr(base.Handle, selDrawWithRectOptionsAttributes_Handle, rect, (ulong)options, attributes.Handle);
	}

	[Export("characterAtIndex:")]
	public virtual char _characterAtIndex(ulong index)
	{
		if (IsDirectBinding)
		{
			return Messaging.Char_objc_msgSend_UInt64(base.Handle, selCharacterAtIndex_Handle, index);
		}
		return Messaging.Char_objc_msgSendSuper_UInt64(base.SuperHandle, selCharacterAtIndex_Handle, index);
	}

	[Export("hash")]
	internal virtual ulong Hash()
	{
		if (IsDirectBinding)
		{
			return Messaging.UInt64_objc_msgSend(base.Handle, selHashHandle);
		}
		return Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selHashHandle);
	}

	[Export("isEqualToString:")]
	internal virtual bool IsEqualTo(IntPtr handle)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsEqualToString_Handle, handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsEqualToString_Handle, handle);
	}

	[Export("compare:")]
	public virtual NSComparisonResult Compare(NSString aString)
	{
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		if (IsDirectBinding)
		{
			return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr(base.Handle, selCompare_Handle, aString.Handle);
		}
		return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr(base.SuperHandle, selCompare_Handle, aString.Handle);
	}

	[Export("compare:options:")]
	public virtual NSComparisonResult Compare(NSString aString, NSStringCompareOptions mask)
	{
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		if (IsDirectBinding)
		{
			return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr_UInt32(base.Handle, selCompareOptions_Handle, aString.Handle, (uint)mask);
		}
		return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr_UInt32(base.SuperHandle, selCompareOptions_Handle, aString.Handle, (uint)mask);
	}

	[Export("compare:options:range:")]
	public virtual NSComparisonResult Compare(NSString aString, NSStringCompareOptions mask, NSRange range)
	{
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		if (IsDirectBinding)
		{
			return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr_UInt32_NSRange(base.Handle, selCompareOptionsRange_Handle, aString.Handle, (uint)mask, range);
		}
		return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr_UInt32_NSRange(base.SuperHandle, selCompareOptionsRange_Handle, aString.Handle, (uint)mask, range);
	}

	[Export("compare:options:range:locale:")]
	public virtual NSComparisonResult Compare(NSString aString, NSStringCompareOptions mask, NSRange range, NSLocale locale)
	{
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		if (IsDirectBinding)
		{
			return (NSComparisonResult)Messaging.Int64_objc_msgSend_IntPtr_UInt32_NSRange_IntPtr(base.Handle, selCompareOptionsRangeLocale_Handle, aString.Handle, (uint)mask, range, locale?.Handle ?? IntPtr.Zero);
		}
		return (NSComparisonResult)Messaging.Int64_objc_msgSendSuper_IntPtr_UInt32_NSRange_IntPtr(base.SuperHandle, selCompareOptionsRangeLocale_Handle, aString.Handle, (uint)mask, range, locale?.Handle ?? IntPtr.Zero);
	}

	[Export("stringByReplacingCharactersInRange:withString:")]
	public virtual NSString Replace(NSRange range, NSString replacement)
	{
		if (replacement == null)
		{
			throw new ArgumentNullException("replacement");
		}
		if (IsDirectBinding)
		{
			return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_NSRange_IntPtr(base.Handle, selStringByReplacingCharactersInRangeWithString_Handle, range, replacement.Handle));
		}
		return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selStringByReplacingCharactersInRangeWithString_Handle, range, replacement.Handle));
	}

	[Export("pathWithComponents:")]
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

	[Export("stringByDeletingLastPathComponent")]
	public virtual NSString DeleteLastPathComponent()
	{
		if (IsDirectBinding)
		{
			return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStringByDeletingLastPathComponentHandle));
		}
		return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringByDeletingLastPathComponentHandle));
	}

	[Export("stringByAppendingPathComponent:")]
	public virtual NSString AppendPathComponent(NSString str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (IsDirectBinding)
		{
			return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringByAppendingPathComponent_Handle, str.Handle));
		}
		return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringByAppendingPathComponent_Handle, str.Handle));
	}

	[Export("stringByDeletingPathExtension")]
	public virtual NSString DeletePathExtension()
	{
		if (IsDirectBinding)
		{
			return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStringByDeletingPathExtensionHandle));
		}
		return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringByDeletingPathExtensionHandle));
	}

	[Export("stringByAppendingPathExtension:")]
	public virtual NSString AppendPathExtension(NSString str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (IsDirectBinding)
		{
			return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringByAppendingPathExtension_Handle, str.Handle));
		}
		return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringByAppendingPathExtension_Handle, str.Handle));
	}

	[Export("stringByAbbreviatingWithTildeInPath")]
	public virtual NSString AbbreviateTildeInPath()
	{
		if (IsDirectBinding)
		{
			return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStringByAbbreviatingWithTildeInPathHandle));
		}
		return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringByAbbreviatingWithTildeInPathHandle));
	}

	[Export("stringByExpandingTildeInPath")]
	public virtual NSString ExpandTildeInPath()
	{
		if (IsDirectBinding)
		{
			return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStringByExpandingTildeInPathHandle));
		}
		return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringByExpandingTildeInPathHandle));
	}

	[Export("stringByStandardizingPath")]
	public virtual NSString StandarizePath()
	{
		if (IsDirectBinding)
		{
			return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStringByStandardizingPathHandle));
		}
		return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringByStandardizingPathHandle));
	}

	[Export("stringByResolvingSymlinksInPath")]
	public virtual NSString ResolveSymlinksInPath()
	{
		if (IsDirectBinding)
		{
			return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selStringByResolvingSymlinksInPathHandle));
		}
		return (NSString)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringByResolvingSymlinksInPathHandle));
	}

	[Export("stringsByAppendingPaths:")]
	public virtual string[] AppendPaths(string[] paths)
	{
		if (paths == null)
		{
			throw new ArgumentNullException("paths");
		}
		NSArray nSArray = NSArray.FromStrings(paths);
		string[] result = ((!IsDirectBinding) ? NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selStringsByAppendingPaths_Handle, nSArray.Handle)) : NSArray.StringArrayFromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selStringsByAppendingPaths_Handle, nSArray.Handle)));
		nSArray.Dispose();
		return result;
	}

	[Export("capitalizedStringWithLocale:")]
	public virtual string Capitalize(NSLocale locale)
	{
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		if (IsDirectBinding)
		{
			return FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selCapitalizedStringWithLocale_Handle, locale.Handle));
		}
		return FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selCapitalizedStringWithLocale_Handle, locale.Handle));
	}

	[Export("lowercaseStringWithLocale:")]
	public virtual string ToLower(NSLocale locale)
	{
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		if (IsDirectBinding)
		{
			return FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selLowercaseStringWithLocale_Handle, locale.Handle));
		}
		return FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selLowercaseStringWithLocale_Handle, locale.Handle));
	}

	[Export("uppercaseStringWithLocale:")]
	public virtual string ToUpper(NSLocale locale)
	{
		if (locale == null)
		{
			throw new ArgumentNullException("locale");
		}
		if (IsDirectBinding)
		{
			return FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr(base.Handle, selUppercaseStringWithLocale_Handle, locale.Handle));
		}
		return FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr(base.SuperHandle, selUppercaseStringWithLocale_Handle, locale.Handle));
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_LastPathComponent_var = null;
			__mt_PathExtension_var = null;
		}
	}
}
