using System.ComponentModel;
using Foundation;
using ObjCRuntime;
using Xamarin.Mac.System.Mac;

namespace NaturalLanguage;

[Register("NLTokenizer", true)]
[Introduced(PlatformName.iOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 14, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 12, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.WatchOS, 5, 0, PlatformArchitecture.All, null)]
public class NLTokenizer : NSObject
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateTokensInRange_UsingBlock_ = "enumerateTokensInRange:usingBlock:";

	private static readonly IntPtr selEnumerateTokensInRange_UsingBlock_Handle = Selector.GetHandle("enumerateTokensInRange:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selInitWithUnit_ = "initWithUnit:";

	private static readonly IntPtr selInitWithUnit_Handle = Selector.GetHandle("initWithUnit:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetLanguage_ = "setLanguage:";

	private static readonly IntPtr selSetLanguage_Handle = Selector.GetHandle("setLanguage:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selSetString_ = "setString:";

	private static readonly IntPtr selSetString_Handle = Selector.GetHandle("setString:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selString = "string";

	private static readonly IntPtr selStringHandle = Selector.GetHandle("string");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTokenRangeAtIndex_ = "tokenRangeAtIndex:";

	private static readonly IntPtr selTokenRangeAtIndex_Handle = Selector.GetHandle("tokenRangeAtIndex:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selTokensForRange_ = "tokensForRange:";

	private static readonly IntPtr selTokensForRange_Handle = Selector.GetHandle("tokensForRange:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selUnit = "unit";

	private static readonly IntPtr selUnitHandle = Selector.GetHandle("unit");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = ObjCRuntime.Class.GetHandle("NLTokenizer");

	public override IntPtr ClassHandle => class_ptr;

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual string? String
	{
		[Export("string", ArgumentSemantic.Retain)]
		get
		{
			if (base.IsDirectBinding)
			{
				return NSString.FromHandle(Messaging.IntPtr_objc_msgSend(base.Handle, selStringHandle));
			}
			return NSString.FromHandle(Messaging.IntPtr_objc_msgSendSuper(base.SuperHandle, selStringHandle));
		}
		[Export("setString:", ArgumentSemantic.Retain)]
		set
		{
			IntPtr arg = NSString.CreateNative(value);
			if (base.IsDirectBinding)
			{
				Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetString_Handle, arg);
			}
			else
			{
				Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetString_Handle, arg);
			}
			NSString.ReleaseNative(arg);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NLTokenUnit Unit
	{
		[Export("unit")]
		get
		{
			if (base.IsDirectBinding)
			{
				return (NLTokenUnit)Messaging.Int64_objc_msgSend(base.Handle, selUnitHandle);
			}
			return (NLTokenUnit)Messaging.Int64_objc_msgSendSuper(base.SuperHandle, selUnitHandle);
		}
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected NLTokenizer(NSObjectFlag t)
		: base(t)
	{
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	protected internal NLTokenizer(IntPtr handle)
		: base(handle)
	{
	}

	[Export("initWithUnit:")]
	[DesignatedInitializer]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public NLTokenizer(NLTokenUnit unit)
		: base(NSObjectFlag.Empty)
	{
		if (base.IsDirectBinding)
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSend_Int64(base.Handle, selInitWithUnit_Handle, (long)unit), "initWithUnit:");
		}
		else
		{
			InitializeHandle(Messaging.IntPtr_objc_msgSendSuper_Int64(base.SuperHandle, selInitWithUnit_Handle, (long)unit), "initWithUnit:");
		}
	}

	[Export("enumerateTokensInRange:usingBlock:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe virtual void EnumerateTokens(NSRange range, [BlockProxy(typeof(Trampolines.NIDNLTokenizerEnumerateContinuationHandler))] NLTokenizerEnumerateContinuationHandler handler)
	{
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNLTokenizerEnumerateContinuationHandler.Handler, handler);
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_NSRange_IntPtr(base.Handle, selEnumerateTokensInRange_UsingBlock_Handle, range, (IntPtr)ptr);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_NSRange_IntPtr(base.SuperHandle, selEnumerateTokensInRange_UsingBlock_Handle, range, (IntPtr)ptr);
		}
		ptr->CleanupBlock();
	}

	[Export("tokenRangeAtIndex:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSRange GetTokenRange(nuint characterIndex)
	{
		if (base.IsDirectBinding)
		{
			return Messaging.NSRange_objc_msgSend_nuint(base.Handle, selTokenRangeAtIndex_Handle, characterIndex);
		}
		return Messaging.NSRange_objc_msgSendSuper_nuint(base.SuperHandle, selTokenRangeAtIndex_Handle, characterIndex);
	}

	[Export("tokensForRange:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public virtual NSValue[] GetTokens(NSRange range)
	{
		if (base.IsDirectBinding)
		{
			return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSend_NSRange(base.Handle, selTokensForRange_Handle, range));
		}
		return NSArray.ArrayFromHandle<NSValue>(Messaging.IntPtr_objc_msgSendSuper_NSRange(base.SuperHandle, selTokensForRange_Handle, range));
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public void SetLanguage(NLLanguage language)
	{
		_SetLanguage(language.GetConstant());
	}

	[Export("setLanguage:")]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	internal virtual void _SetLanguage(NSString language)
	{
		if (language == null)
		{
			throw new ArgumentNullException("language");
		}
		if (base.IsDirectBinding)
		{
			Messaging.void_objc_msgSend_IntPtr(base.Handle, selSetLanguage_Handle, language.Handle);
		}
		else
		{
			Messaging.void_objc_msgSendSuper_IntPtr(base.SuperHandle, selSetLanguage_Handle, language.Handle);
		}
	}
}
