using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSCharacterSet", true)]
public class NSCharacterSet : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSMutableCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAlphanumericCharacterSet = "alphanumericCharacterSet";

	private static readonly IntPtr selAlphanumericCharacterSetHandle = Selector.GetHandle("alphanumericCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selBitmapRepresentation = "bitmapRepresentation";

	private static readonly IntPtr selBitmapRepresentationHandle = Selector.GetHandle("bitmapRepresentation");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCapitalizedLetterCharacterSet = "capitalizedLetterCharacterSet";

	private static readonly IntPtr selCapitalizedLetterCharacterSetHandle = Selector.GetHandle("capitalizedLetterCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterIsMember_ = "characterIsMember:";

	private static readonly IntPtr selCharacterIsMember_Handle = Selector.GetHandle("characterIsMember:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterSetWithBitmapRepresentation_ = "characterSetWithBitmapRepresentation:";

	private static readonly IntPtr selCharacterSetWithBitmapRepresentation_Handle = Selector.GetHandle("characterSetWithBitmapRepresentation:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterSetWithCharactersInString_ = "characterSetWithCharactersInString:";

	private static readonly IntPtr selCharacterSetWithCharactersInString_Handle = Selector.GetHandle("characterSetWithCharactersInString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterSetWithContentsOfFile_ = "characterSetWithContentsOfFile:";

	private static readonly IntPtr selCharacterSetWithContentsOfFile_Handle = Selector.GetHandle("characterSetWithContentsOfFile:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCharacterSetWithRange_ = "characterSetWithRange:";

	private static readonly IntPtr selCharacterSetWithRange_Handle = Selector.GetHandle("characterSetWithRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selControlCharacterSet = "controlCharacterSet";

	private static readonly IntPtr selControlCharacterSetHandle = Selector.GetHandle("controlCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecimalDigitCharacterSet = "decimalDigitCharacterSet";

	private static readonly IntPtr selDecimalDigitCharacterSetHandle = Selector.GetHandle("decimalDigitCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDecomposableCharacterSet = "decomposableCharacterSet";

	private static readonly IntPtr selDecomposableCharacterSetHandle = Selector.GetHandle("decomposableCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selHasMemberInPlane_ = "hasMemberInPlane:";

	private static readonly IntPtr selHasMemberInPlane_Handle = Selector.GetHandle("hasMemberInPlane:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIllegalCharacterSet = "illegalCharacterSet";

	private static readonly IntPtr selIllegalCharacterSetHandle = Selector.GetHandle("illegalCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInvertedSet = "invertedSet";

	private static readonly IntPtr selInvertedSetHandle = Selector.GetHandle("invertedSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selIsSupersetOfSet_ = "isSupersetOfSet:";

	private static readonly IntPtr selIsSupersetOfSet_Handle = Selector.GetHandle("isSupersetOfSet:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLetterCharacterSet = "letterCharacterSet";

	private static readonly IntPtr selLetterCharacterSetHandle = Selector.GetHandle("letterCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLongCharacterIsMember_ = "longCharacterIsMember:";

	private static readonly IntPtr selLongCharacterIsMember_Handle = Selector.GetHandle("longCharacterIsMember:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLowercaseLetterCharacterSet = "lowercaseLetterCharacterSet";

	private static readonly IntPtr selLowercaseLetterCharacterSetHandle = Selector.GetHandle("lowercaseLetterCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMutableCopyWithZone_ = "mutableCopyWithZone:";

	private static readonly IntPtr selMutableCopyWithZone_Handle = Selector.GetHandle("mutableCopyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNewlineCharacterSet = "newlineCharacterSet";

	private static readonly IntPtr selNewlineCharacterSetHandle = Selector.GetHandle("newlineCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNonBaseCharacterSet = "nonBaseCharacterSet";

	private static readonly IntPtr selNonBaseCharacterSetHandle = Selector.GetHandle("nonBaseCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPunctuationCharacterSet = "punctuationCharacterSet";

	private static readonly IntPtr selPunctuationCharacterSetHandle = Selector.GetHandle("punctuationCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSymbolCharacterSet = "symbolCharacterSet";

	private static readonly IntPtr selSymbolCharacterSetHandle = Selector.GetHandle("symbolCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUppercaseLetterCharacterSet = "uppercaseLetterCharacterSet";

	private static readonly IntPtr selUppercaseLetterCharacterSetHandle = Selector.GetHandle("uppercaseLetterCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWhitespaceAndNewlineCharacterSet = "whitespaceAndNewlineCharacterSet";

	private static readonly IntPtr selWhitespaceAndNewlineCharacterSetHandle = Selector.GetHandle("whitespaceAndNewlineCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selWhitespaceCharacterSet = "whitespaceCharacterSet";

	private static readonly IntPtr selWhitespaceCharacterSetHandle = Selector.GetHandle("whitespaceCharacterSet");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSCharacterSet");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet Alphanumerics
	{
		[Export("alphanumericCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selAlphanumericCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet Capitalized
	{
		[Export("capitalizedLetterCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selCapitalizedLetterCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet Controls
	{
		[Export("controlCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selControlCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet DecimalDigits
	{
		[Export("decimalDigitCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selDecimalDigitCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet Decomposables
	{
		[Export("decomposableCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selDecomposableCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet Illegals
	{
		[Export("illegalCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selIllegalCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSCharacterSet InvertedSet
	{
		[Export("invertedSet")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(base.Handle, selInvertedSetHandle));
			}
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selInvertedSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet Letters
	{
		[Export("letterCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selLetterCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet LowercaseLetters
	{
		[Export("lowercaseLetterCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selLowercaseLetterCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet Marks
	{
		[Export("nonBaseCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selNonBaseCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet Newlines
	{
		[Export("newlineCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selNewlineCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet Punctuation
	{
		[Export("punctuationCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selPunctuationCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet Symbols
	{
		[Export("symbolCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selSymbolCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet UppercaseLetters
	{
		[Export("uppercaseLetterCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selUppercaseLetterCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet WhitespaceAndNewlines
	{
		[Export("whitespaceAndNewlineCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selWhitespaceAndNewlineCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet Whitespaces
	{
		[Export("whitespaceCharacterSet", ArgumentSemantic.Copy)]
		get
		{
			return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend(class_ptr, selWhitespaceCharacterSetHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSCharacterSet()
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
	public NSCharacterSet(NSCoder coder)
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
	protected NSCharacterSet(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSCharacterSet(IntPtr handle)
		: base(handle)
	{
	}

	[Export("characterIsMember:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Contains(char aCharacter)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_Char(base.Handle, selCharacterIsMember_Handle, aCharacter);
		}
		return Messaging.bool_objc_msgSendSuper_Char(base.SuperHandle, selCharacterIsMember_Handle, aCharacter);
	}

	[Export("longCharacterIsMember:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool Contains(uint theLongChar)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_UInt32(base.Handle, selLongCharacterIsMember_Handle, theLongChar);
		}
		return Messaging.bool_objc_msgSendSuper_UInt32(base.SuperHandle, selLongCharacterIsMember_Handle, theLongChar);
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

	[Export("characterSetWithBitmapRepresentation:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet FromBitmap(NSData data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCharacterSetWithBitmapRepresentation_Handle, data.Handle));
	}

	[Export("characterSetWithContentsOfFile:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet FromFile(string path)
	{
		if (path == null)
		{
			throw new ArgumentNullException("path");
		}
		IntPtr arg = NSString.CreateNative(path);
		NSCharacterSet nSObject = Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCharacterSetWithContentsOfFile_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("characterSetWithRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet FromRange(NSRange aRange)
	{
		return Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend_NSRange(class_ptr, selCharacterSetWithRange_Handle, aRange));
	}

	[Export("characterSetWithCharactersInString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSCharacterSet FromString(string aString)
	{
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		IntPtr arg = NSString.CreateNative(aString);
		NSCharacterSet nSObject = Runtime.GetNSObject<NSCharacterSet>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selCharacterSetWithCharactersInString_Handle, arg));
		NSString.ReleaseNative(arg);
		return nSObject;
	}

	[Export("bitmapRepresentation")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSData GetBitmapRepresentation()
	{
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSend(base.Handle, selBitmapRepresentationHandle));
		}
		return Runtime.GetNSObject<NSData>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selBitmapRepresentationHandle));
	}

	[Export("hasMemberInPlane:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool HasMemberInPlane(byte thePlane)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_byte(base.Handle, selHasMemberInPlane_Handle, thePlane);
		}
		return Messaging.bool_objc_msgSendSuper_byte(base.SuperHandle, selHasMemberInPlane_Handle, thePlane);
	}

	[Export("isSupersetOfSet:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool IsSupersetOf(NSCharacterSet theOtherSet)
	{
		if (theOtherSet == null)
		{
			throw new ArgumentNullException("theOtherSet");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr(base.Handle, selIsSupersetOfSet_Handle, theOtherSet.Handle);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr(base.SuperHandle, selIsSupersetOfSet_Handle, theOtherSet.Handle);
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
}
