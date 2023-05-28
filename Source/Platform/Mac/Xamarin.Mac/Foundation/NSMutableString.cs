using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

[Register("NSMutableString", true)]
public class NSMutableString : NSString, INSCoding, INativeObject, IDisposable
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selAppendString_ = "appendString:";

	private static readonly IntPtr selAppendString_Handle = Selector.GetHandle("appendString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selApplyTransform_Reverse_Range_UpdatedRange_ = "applyTransform:reverse:range:updatedRange:";

	private static readonly IntPtr selApplyTransform_Reverse_Range_UpdatedRange_Handle = Selector.GetHandle("applyTransform:reverse:range:updatedRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selDeleteCharactersInRange_ = "deleteCharactersInRange:";

	private static readonly IntPtr selDeleteCharactersInRange_Handle = Selector.GetHandle("deleteCharactersInRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEncodeWithCoder_ = "encodeWithCoder:";

	private static readonly IntPtr selEncodeWithCoder_Handle = Selector.GetHandle("encodeWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCapacity_ = "initWithCapacity:";

	private static readonly IntPtr selInitWithCapacity_Handle = Selector.GetHandle("initWithCapacity:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithCoder_ = "initWithCoder:";

	private static readonly IntPtr selInitWithCoder_Handle = Selector.GetHandle("initWithCoder:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInsertString_AtIndex_ = "insertString:atIndex:";

	private static readonly IntPtr selInsertString_AtIndex_Handle = Selector.GetHandle("insertString:atIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceCharactersInRange_WithString_ = "replaceCharactersInRange:withString:";

	private static readonly IntPtr selReplaceCharactersInRange_WithString_Handle = Selector.GetHandle("replaceCharactersInRange:withString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selReplaceOccurrencesOfString_WithString_Options_Range_ = "replaceOccurrencesOfString:withString:options:range:";

	private static readonly IntPtr selReplaceOccurrencesOfString_WithString_Options_Range_Handle = Selector.GetHandle("replaceOccurrencesOfString:withString:options:range:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetString_ = "setString:";

	private static readonly IntPtr selSetString_Handle = Selector.GetHandle("setString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NSMutableString");

	public override IntPtr ClassHandle => class_ptr;

	private void Check(NSRange range)
	{
		if (range.Location + range.Length > Length)
		{
			throw new ArgumentOutOfRangeException("range");
		}
	}

	private void Check(nint index)
	{
		if (index < 0 || index > Length)
		{
			throw new ArgumentOutOfRangeException("index");
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Export("init")]
	public NSMutableString()
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
	public NSMutableString(NSCoder coder)
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
	protected NSMutableString(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NSMutableString(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithCapacity:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NSMutableString(nint capacity)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_nint(base.Handle, selInitWithCapacity_Handle, capacity), "initWithCapacity:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_nint(base.SuperHandle, selInitWithCapacity_Handle, capacity), "initWithCapacity:");
		}
	}

	[Export("appendString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Append(NSString str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selAppendString_Handle, str.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selAppendString_Handle, str.Handle);
		}
	}

	[Export("applyTransform:reverse:range:updatedRange:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual bool ApplyTransform(NSString transform, bool reverse, NSRange range, out NSRange resultingRange)
	{
		if (transform == null)
		{
			throw new ArgumentNullException("transform");
		}
		if (base.IsDirectBinding)
		{
			return Messaging.bool_objc_msgSend_IntPtr_bool_NSRange_out_NSRange(base.Handle, selApplyTransform_Reverse_Range_UpdatedRange_Handle, transform.Handle, reverse, range, out resultingRange);
		}
		return Messaging.bool_objc_msgSendSuper_IntPtr_bool_NSRange_out_NSRange(base.SuperHandle, selApplyTransform_Reverse_Range_UpdatedRange_Handle, transform.Handle, reverse, range, out resultingRange);
	}

	[Introduced(PlatformName.iOS, 9, 0, PlatformArchitecture.All, null)]
	[Introduced(PlatformName.MacOSX, 10, 11, PlatformArchitecture.All, null)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public bool ApplyTransform(NSStringTransform transform, bool reverse, NSRange range, out NSRange resultingRange)
	{
		return ApplyTransform(transform.GetConstant(), reverse, range, out resultingRange);
	}

	[Export("deleteCharactersInRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void DeleteCharacters(NSRange range)
	{
		Check(range);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange(base.Handle, selDeleteCharactersInRange_Handle, range);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange(base.SuperHandle, selDeleteCharactersInRange_Handle, range);
		}
	}

	[Export("encodeWithCoder:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public new virtual void EncodeTo(NSCoder encoder)
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

	[Export("insertString:atIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void Insert(NSString str, nint index)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		Check(index);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr_nint(base.Handle, selInsertString_AtIndex_Handle, str.Handle, index);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr_nint(base.SuperHandle, selInsertString_AtIndex_Handle, str.Handle, index);
		}
	}

	[Export("replaceCharactersInRange:withString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void ReplaceCharactersInRange(NSRange range, NSString aString)
	{
		if (aString == null)
		{
			throw new ArgumentNullException("aString");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selReplaceCharactersInRange_WithString_Handle, range, aString.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selReplaceCharactersInRange_WithString_Handle, range, aString.Handle);
		}
	}

	[Export("replaceOccurrencesOfString:withString:options:range:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual nuint ReplaceOcurrences(NSString target, NSString replacement, NSStringCompareOptions options, NSRange range)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (replacement == null)
		{
			throw new ArgumentNullException("replacement");
		}
		Check(range);
		if (base.IsDirectBinding)
		{
			return Messaging.nuint_objc_msgSend_IntPtr_IntPtr_UInt64_NSRange(base.Handle, selReplaceOccurrencesOfString_WithString_Options_Range_Handle, target.Handle, replacement.Handle, (ulong)options, range);
		}
		return Messaging.nuint_objc_msgSendSuper_IntPtr_IntPtr_UInt64_NSRange(base.SuperHandle, selReplaceOccurrencesOfString_WithString_Options_Range_Handle, target.Handle, replacement.Handle, (ulong)options, range);
	}

	[Export("setString:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual void SetString(NSString str)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetString_Handle, str.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetString_Handle, str.Handle);
		}
	}
}
