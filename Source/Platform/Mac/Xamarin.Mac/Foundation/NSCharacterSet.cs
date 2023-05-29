using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSCharacterSet", true)]
public class NSCharacterSet : NSObject
{
	private static readonly IntPtr selAlphanumericCharacterSetHandle = Selector.GetHandle("alphanumericCharacterSet");

	private static readonly IntPtr selCapitalizedLetterCharacterSetHandle = Selector.GetHandle("capitalizedLetterCharacterSet");

	private static readonly IntPtr selControlCharacterSetHandle = Selector.GetHandle("controlCharacterSet");

	private static readonly IntPtr selDecimalDigitCharacterSetHandle = Selector.GetHandle("decimalDigitCharacterSet");

	private static readonly IntPtr selDecomposableCharacterSetHandle = Selector.GetHandle("decomposableCharacterSet");

	private static readonly IntPtr selIllegalCharacterSetHandle = Selector.GetHandle("illegalCharacterSet");

	private static readonly IntPtr selLetterCharacterSetHandle = Selector.GetHandle("letterCharacterSet");

	private static readonly IntPtr selLowercaseLetterCharacterSetHandle = Selector.GetHandle("lowercaseLetterCharacterSet");

	private static readonly IntPtr selNewlineCharacterSetHandle = Selector.GetHandle("newlineCharacterSet");

	private static readonly IntPtr selNonBaseCharacterSetHandle = Selector.GetHandle("nonBaseCharacterSet");

	private static readonly IntPtr selPunctuationCharacterSetHandle = Selector.GetHandle("punctuationCharacterSet");

	private static readonly IntPtr selSymbolCharacterSetHandle = Selector.GetHandle("symbolCharacterSet");

	private static readonly IntPtr selUppercaseLetterCharacterSetHandle = Selector.GetHandle("uppercaseLetterCharacterSet");

	private static readonly IntPtr selWhitespaceAndNewlineCharacterSetHandle = Selector.GetHandle("whitespaceAndNewlineCharacterSet");

	private static readonly IntPtr selWhitespaceCharacterSetHandle = Selector.GetHandle("whitespaceCharacterSet");

	private static readonly IntPtr selInvertedSetHandle = Selector.GetHandle("invertedSet");

	private static readonly IntPtr selCharacterSetWithBitmapRepresentation_Handle = Selector.GetHandle("characterSetWithBitmapRepresentation:");

	private static readonly IntPtr selCharacterSetWithCharactersInString_Handle = Selector.GetHandle("characterSetWithCharactersInString:");

	private static readonly IntPtr selCharacterSetWithContentsOfFile_Handle = Selector.GetHandle("characterSetWithContentsOfFile:");

	private static readonly IntPtr selCharacterSetWithRange_Handle = Selector.GetHandle("characterSetWithRange:");

	private static readonly IntPtr selBitmapRepresentationHandle = Selector.GetHandle("bitmapRepresentation");

	private static readonly IntPtr selCharacterIsMember_Handle = Selector.GetHandle("characterIsMember:");

	private static readonly IntPtr selHasMemberInPlane_Handle = Selector.GetHandle("hasMemberInPlane:");

	private static readonly IntPtr selIsSupersetOfSet_Handle = Selector.GetHandle("isSupersetOfSet:");

	private static readonly IntPtr selLongCharacterIsMember_Handle = Selector.GetHandle("longCharacterIsMember:");

	private static readonly IntPtr class_ptr = Class.GetHandle("NSCharacterSet");

	private static object __mt_Alphanumerics_var_static;

	private static object __mt_Capitalized_var_static;

	private static object __mt_Controls_var_static;

	private static object __mt_DecimalDigits_var_static;

	private static object __mt_Decomposables_var_static;

	private static object __mt_Illegals_var_static;

	private static object __mt_Letters_var_static;

	private static object __mt_LowercaseLetters_var_static;

	private static object __mt_Newlines_var_static;

	private static object __mt_Marks_var_static;

	private static object __mt_Punctuation_var_static;

	private static object __mt_Symbols_var_static;

	private static object __mt_UppercaseLetters_var_static;

	private static object __mt_WhitespaceAndNewlines_var_static;

	private static object __mt_Whitespaces_var_static;

	private object __mt_InvertedSet_var;

	public override IntPtr ClassHandle => class_ptr;

	public static NSCharacterSet Alphanumerics
	{
		[Export("alphanumericCharacterSet")]
		get
		{
			return (NSCharacterSet)(__mt_Alphanumerics_var_static = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selAlphanumericCharacterSetHandle)));
		}
	}

	public static NSCharacterSet Capitalized
	{
		[Export("capitalizedLetterCharacterSet")]
		get
		{
			return (NSCharacterSet)(__mt_Capitalized_var_static = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selCapitalizedLetterCharacterSetHandle)));
		}
	}

	public static NSCharacterSet Controls
	{
		[Export("controlCharacterSet")]
		get
		{
			return (NSCharacterSet)(__mt_Controls_var_static = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selControlCharacterSetHandle)));
		}
	}

	public static NSCharacterSet DecimalDigits
	{
		[Export("decimalDigitCharacterSet")]
		get
		{
			return (NSCharacterSet)(__mt_DecimalDigits_var_static = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDecimalDigitCharacterSetHandle)));
		}
	}

	public static NSCharacterSet Decomposables
	{
		[Export("decomposableCharacterSet")]
		get
		{
			return (NSCharacterSet)(__mt_Decomposables_var_static = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selDecomposableCharacterSetHandle)));
		}
	}

	public static NSCharacterSet Illegals
	{
		[Export("illegalCharacterSet")]
		get
		{
			return (NSCharacterSet)(__mt_Illegals_var_static = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selIllegalCharacterSetHandle)));
		}
	}

	public static NSCharacterSet Letters
	{
		[Export("letterCharacterSet")]
		get
		{
			return (NSCharacterSet)(__mt_Letters_var_static = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selLetterCharacterSetHandle)));
		}
	}

	public static NSCharacterSet LowercaseLetters
	{
		[Export("lowercaseLetterCharacterSet")]
		get
		{
			return (NSCharacterSet)(__mt_LowercaseLetters_var_static = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selLowercaseLetterCharacterSetHandle)));
		}
	}

	public static NSCharacterSet Newlines
	{
		[Export("newlineCharacterSet")]
		get
		{
			return (NSCharacterSet)(__mt_Newlines_var_static = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selNewlineCharacterSetHandle)));
		}
	}

	public static NSCharacterSet Marks
	{
		[Export("nonBaseCharacterSet")]
		get
		{
			return (NSCharacterSet)(__mt_Marks_var_static = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selNonBaseCharacterSetHandle)));
		}
	}

	public static NSCharacterSet Punctuation
	{
		[Export("punctuationCharacterSet")]
		get
		{
			return (NSCharacterSet)(__mt_Punctuation_var_static = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selPunctuationCharacterSetHandle)));
		}
	}

	public static NSCharacterSet Symbols
	{
		[Export("symbolCharacterSet")]
		get
		{
			return (NSCharacterSet)(__mt_Symbols_var_static = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selSymbolCharacterSetHandle)));
		}
	}

	public static NSCharacterSet UppercaseLetters
	{
		[Export("uppercaseLetterCharacterSet")]
		get
		{
			return (NSCharacterSet)(__mt_UppercaseLetters_var_static = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selUppercaseLetterCharacterSetHandle)));
		}
	}

	public static NSCharacterSet WhitespaceAndNewlines
	{
		[Export("whitespaceAndNewlineCharacterSet")]
		get
		{
			return (NSCharacterSet)(__mt_WhitespaceAndNewlines_var_static = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selWhitespaceAndNewlineCharacterSetHandle)));
		}
	}

	public static NSCharacterSet Whitespaces
	{
		[Export("whitespaceCharacterSet")]
		get
		{
			return (NSCharacterSet)(__mt_Whitespaces_var_static = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(class_ptr, selWhitespaceCharacterSetHandle)));
		}
	}

	public virtual NSCharacterSet InvertedSet
	{
		[Export("invertedSet")]
		get
		{
			return (NSCharacterSet)(__mt_InvertedSet_var = ((!IsDirectBinding) ? ((NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInvertedSetHandle))) : ((NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selInvertedSetHandle)))));
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCharacterSet()
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
	public NSCharacterSet(NSCoder coder)
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
	public NSCharacterSet(NSObjectFlag t)
		: base(t)
	{
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public NSCharacterSet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("characterSetWithBitmapRepresentation:")]
	public static NSCharacterSet FromBitmap(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCharacterSetWithBitmapRepresentation_Handle, data.Handle));
	}

	[Export("characterSetWithCharactersInString:")]
	public static NSCharacterSet FromString(string aString)
	{
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		NSCharacterSet result = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCharacterSetWithCharactersInString_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("characterSetWithContentsOfFile:")]
	public static NSCharacterSet FromFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSCharacterSet result = (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCharacterSetWithContentsOfFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("characterSetWithRange:")]
	public static NSCharacterSet FromRange(NSRange aRange)
	{
		return (NSCharacterSet)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend_NSRange(class_ptr, selCharacterSetWithRange_Handle, aRange));
	}

	[Export("bitmapRepresentation")]
	public virtual NSData GetBitmapRepresentation()
	{
		if (IsDirectBinding)
		{
			return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSend(base.Handle, selBitmapRepresentationHandle));
		}
		return (NSData)Runtime.GetNSObject(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBitmapRepresentationHandle));
	}

	[Export("characterIsMember:")]
	public virtual bool Contains(char aCharacter)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Char(base.Handle, selCharacterIsMember_Handle, aCharacter);
		}
		return Messaging.bool_objc_msgSendSuper_Char(base.SuperHandle, selCharacterIsMember_Handle, aCharacter);
	}

	[Export("hasMemberInPlane:")]
	public virtual bool HasMemberInPlane(byte thePlane)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_byte(base.Handle, selHasMemberInPlane_Handle, thePlane);
		}
		return Messaging.bool_objc_msgSendSuper_byte(base.SuperHandle, selHasMemberInPlane_Handle, thePlane);
	}

	[Export("isSupersetOfSet:")]
	public virtual bool IsSupersetOf(NSCharacterSet theOtherSet)
	{
		if (theOtherSet == null)
		{
			throw new ArgumentNullException("theOtherSet");
		}
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsSupersetOfSet_Handle, theOtherSet.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsSupersetOfSet_Handle, theOtherSet.Handle);
	}

	[Export("longCharacterIsMember:")]
	public virtual bool Contains(uint theLongChar)
	{
		if (IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_UInt32(base.Handle, selLongCharacterIsMember_Handle, theLongChar);
		}
		return Messaging.bool_objc_msgSendSuper_UInt32(base.SuperHandle, selLongCharacterIsMember_Handle, theLongChar);
	}

	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
		if (base.Handle == IntPtr.Zero)
		{
			__mt_InvertedSet_var = null;
		}
	}
}
