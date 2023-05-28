using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSRegularExpression", true)]
public class NSRegularExpression : NSObject, INSCoding, INativeObject, IDisposable, INSCopying, INSSecureCoding
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selCopyWithZone_ = "copyWithZone:";

	private static readonly IntPtr selCopyWithZone_Handle = Selector.GetHandle("copyWithZone:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateMatchesInString_Options_Range_UsingBlock_ = "enumerateMatchesInString:options:range:usingBlock:";

	private static readonly IntPtr selEnumerateMatchesInString_Options_Range_UsingBlock_Handle = Selector.GetHandle("enumerateMatchesInString:options:range:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEscapedPatternForString_ = "escapedPatternForString:";

	private static readonly IntPtr selEscapedPatternForString_Handle = Selector.GetHandle("escapedPatternForString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEscapedTemplateForString_ = "escapedTemplateForString:";

	private static readonly IntPtr selEscapedTemplateForString_Handle = Selector.GetHandle("escapedTemplateForString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selFirstMatchInString_Options_Range_ = "firstMatchInString:options:range:";

	private static readonly IntPtr selFirstMatchInString_Options_Range_Handle = Selector.GetHandle("firstMatchInString:options:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithPattern_Options_Error_ = "initWithPattern:options:error:";

	private static readonly IntPtr selInitWithPattern_Options_Error_Handle = Selector.GetHandle("initWithPattern:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selMatchesInString_Options_Range_ = "matchesInString:options:range:";

	private static readonly IntPtr selMatchesInString_Options_Range_Handle = Selector.GetHandle("matchesInString:options:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfCaptureGroups = "numberOfCaptureGroups";

	private static readonly IntPtr selNumberOfCaptureGroupsHandle = Selector.GetHandle("numberOfCaptureGroups");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selNumberOfMatchesInString_Options_Range_ = "numberOfMatchesInString:options:range:";

	private static readonly IntPtr selNumberOfMatchesInString_Options_Range_Handle = Selector.GetHandle("numberOfMatchesInString:options:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selOptions = "options";

	private static readonly IntPtr selOptionsHandle = Selector.GetHandle("options");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selPattern = "pattern";

	private static readonly IntPtr selPatternHandle = Selector.GetHandle("pattern");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRangeOfFirstMatchInString_Options_Range_ = "rangeOfFirstMatchInString:options:range:";

	private static readonly IntPtr selRangeOfFirstMatchInString_Options_Range_Handle = Selector.GetHandle("rangeOfFirstMatchInString:options:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selRegularExpressionWithPattern_Options_Error_ = "regularExpressionWithPattern:options:error:";

	private static readonly IntPtr selRegularExpressionWithPattern_Options_Error_Handle = Selector.GetHandle("regularExpressionWithPattern:options:error:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceMatchesInString_Options_Range_WithTemplate_ = "replaceMatchesInString:options:range:withTemplate:";

	private static readonly IntPtr selReplaceMatchesInString_Options_Range_WithTemplate_Handle = Selector.GetHandle("replaceMatchesInString:options:range:withTemplate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplacementStringForResult_InString_Offset_Template_ = "replacementStringForResult:inString:offset:template:";

	private static readonly IntPtr selReplacementStringForResult_InString_Offset_Template_Handle = Selector.GetHandle("replacementStringForResult:inString:offset:template:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selStringByReplacingMatchesInString_Options_Range_WithTemplate_ = "stringByReplacingMatchesInString:options:range:withTemplate:";

	private static readonly IntPtr selStringByReplacingMatchesInString_Options_Range_WithTemplate_Handle = Selector.GetHandle("stringByReplacingMatchesInString:options:range:withTemplate:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSRegularExpression");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint NumberOfCaptureGroups
	{
		[Export("numberOfCaptureGroups")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Messaging.nuint_objc_msgSend(base.Handle, selNumberOfCaptureGroupsHandle);
			}
			return Messaging.nuint_objc_msgSendSuper(base.SuperHandle, selNumberOfCaptureGroupsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRegularExpressionOptions Options
	{
		[Export("options")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NSRegularExpressionOptions)Messaging.UInt64_objc_msgSend(base.Handle, selOptionsHandle);
			}
			return (NSRegularExpressionOptions)Messaging.UInt64_objc_msgSendSuper(base.SuperHandle, selOptionsHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString Pattern
	{
		[Export("pattern")]
		get
		{
			if (base.IsDirectBinding)
			{
				return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend(base.Handle, selPatternHandle));
			}
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selPatternHandle));
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSRegularExpression()
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
	public NSRegularExpression(NSCoder coder)
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
	protected NSRegularExpression(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSRegularExpression(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithPattern:options:error:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSRegularExpression(NSString pattern, NSRegularExpressionOptions options, out NSError error)
		: base(NSObjectFlag.Empty)
	{
		if (pattern == null)
		{
			throw new ArgumentNullException("pattern");
		}
		IntPtr arg = IntPtr.Zero;
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr(base.Handle, selInitWithPattern_Options_Error_Handle, pattern.Handle, (ulong)options, ref arg), "initWithPattern:options:error:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_ref_IntPtr(base.SuperHandle, selInitWithPattern_Options_Error_Handle, pattern.Handle, (ulong)options, ref arg), "initWithPattern:options:error:");
		}
		error = Runtime.GetNSObject<NSError>(arg);
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

	[Export("regularExpressionWithPattern:options:error:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSRegularExpression Create(NSString pattern, NSRegularExpressionOptions options, out NSError error)
	{
		if (pattern == null)
		{
			throw new ArgumentNullException("pattern");
		}
		IntPtr arg = IntPtr.Zero;
		NSRegularExpression nSObject = Runtime.GetNSObject<NSRegularExpression>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr(class_ptr, selRegularExpressionWithPattern_Options_Error_Handle, pattern.Handle, (ulong)options, ref arg));
		error = Runtime.GetNSObject<NSError>(arg);
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

	[Export("enumerateMatchesInString:options:range:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateMatches(NSString str, NSMatchingOptions options, NSRange range, [BlockProxy(typeof(Trampolines.NIDNSMatchEnumerator))] NSMatchEnumerator enumerator)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (enumerator == null)
		{
			throw new ArgumentNullException("enumerator");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSMatchEnumerator.Handler, enumerator);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_UInt64_NSRange_IntPtr(base.Handle, selEnumerateMatchesInString_Options_Range_UsingBlock_Handle, str.Handle, (ulong)options, range, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_UInt64_NSRange_IntPtr(base.SuperHandle, selEnumerateMatchesInString_Options_Range_UsingBlock_Handle, str.Handle, (ulong)options, range, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("firstMatchInString:options:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSTextCheckingResult? FindFirstMatch(string str, NSMatchingOptions options, NSRange range)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		NSTextCheckingResult result = ((!base.IsDirectBinding) ? Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_NSRange(base.SuperHandle, selFirstMatchInString_Options_Range_Handle, arg, (ulong)options, range)) : Runtime.GetNSObject<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_NSRange(base.Handle, selFirstMatchInString_Options_Range_Handle, arg, (ulong)options, range)));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("escapedPatternForString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString GetEscapedPattern(NSString str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selEscapedPatternForString_Handle, str.Handle));
	}

	[Export("escapedTemplateForString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSString GetEscapedTemplate(NSString str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr(class_ptr, selEscapedTemplateForString_Handle, str.Handle));
	}

	[Export("matchesInString:options:range:")]
	[Obsolete("Use 'GetMatches2' instead, this method has the wrong return type.", false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString[] GetMatches(NSString str, NSMatchingOptions options, NSRange range)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_NSRange(base.Handle, selMatchesInString_Options_Range_Handle, str.Handle, (ulong)options, range));
		}
		return NSArray.ArrayFromHandle<NSString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_NSRange(base.SuperHandle, selMatchesInString_Options_Range_Handle, str.Handle, (ulong)options, range));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSTextCheckingResult[] GetMatches2(NSString str, NSMatchingOptions options, NSRange range)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		return NSArray.ArrayFromHandle<NSTextCheckingResult>(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_NSRange(base.Handle, selMatchesInString_Options_Range_Handle, str.Handle, (ulong)options, range));
	}

	[Export("numberOfMatchesInString:options:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint GetNumberOfMatches(NSString str, NSMatchingOptions options, NSRange range)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_UInt64_NSRange(base.Handle, selNumberOfMatchesInString_Options_Range_Handle, str.Handle, (ulong)options, range);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_UInt64_NSRange(base.SuperHandle, selNumberOfMatchesInString_Options_Range_Handle, str.Handle, (ulong)options, range);
	}

	[Export("rangeOfFirstMatchInString:options:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetRangeOfFirstMatch(string str, NSMatchingOptions options, NSRange range)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		IntPtr arg = NSString.CreateNative(str);
		NSRange result = ((!base.IsDirectBinding) ? Messaging.NSRange_objc_msgSendSuper_IntPtr_UInt64_NSRange(base.SuperHandle, selRangeOfFirstMatchInString_Options_Range_Handle, arg, (ulong)options, range) : Messaging.NSRange_objc_msgSend_IntPtr_UInt64_NSRange(base.Handle, selRangeOfFirstMatchInString_Options_Range_Handle, arg, (ulong)options, range));
		NSString.ReleaseNative(arg);
		return result;
	}

	[Export("replacementStringForResult:inString:offset:template:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSString GetReplacementString(NSTextCheckingResult result, NSString str, nint offset, NSString template)
	{
		if (result == null)
		{
			throw new ArgumentNullException("result");
		}
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (template == null)
		{
			throw new ArgumentNullException("template");
		}
		if (base.IsDirectBinding)
		{
			return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_nint_IntPtr(base.Handle, selReplacementStringForResult_InString_Offset_Template_Handle, result.Handle, str.Handle, offset, template.Handle));
		}
		return Runtime.GetNSObject<NSString>(Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nint_IntPtr(base.SuperHandle, selReplacementStringForResult_InString_Offset_Template_Handle, result.Handle, str.Handle, offset, template.Handle));
	}

	[Export("stringByReplacingMatchesInString:options:range:withTemplate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string ReplaceMatches(string sourceString, NSMatchingOptions options, NSRange range, string template)
	{
		if (sourceString == null)
		{
			throw new ArgumentNullException("sourceString");
		}
		if (template == null)
		{
			throw new ArgumentNullException("template");
		}
		IntPtr arg = NSString.CreateNative(sourceString);
		IntPtr arg2 = NSString.CreateNative(template);
		string result = ((!base.IsDirectBinding) ? NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper_IntPtr_UInt64_NSRange_IntPtr(base.SuperHandle, selStringByReplacingMatchesInString_Options_Range_WithTemplate_Handle, arg, (ulong)options, range, arg2)) : NSString.FromHandle(Messaging.IntPtr_objc_msgSend_IntPtr_UInt64_NSRange_IntPtr(base.Handle, selStringByReplacingMatchesInString_Options_Range_WithTemplate_Handle, arg, (ulong)options, range, arg2)));
		NSString.ReleaseNative(arg);
		NSString.ReleaseNative(arg2);
		return result;
	}

	[Export("replaceMatchesInString:options:range:withTemplate:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ReplaceMatches(NSMutableString mutableString, NSMatchingOptions options, NSRange range, NSString template)
	{
		if (mutableString == null)
		{
			throw new ArgumentNullException("mutableString");
		}
		if (template == null)
		{
			throw new ArgumentNullException("template");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_UInt64_NSRange_IntPtr(base.Handle, selReplaceMatchesInString_Options_Range_WithTemplate_Handle, mutableString.Handle, (ulong)options, range, template.Handle);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_UInt64_NSRange_IntPtr(base.SuperHandle, selReplaceMatchesInString_Options_Range_WithTemplate_Handle, mutableString.Handle, (ulong)options, range, template.Handle);
	}
}
