using System;
using System.ComponentModel;
using ObjCRuntime;

namespace Foundation;

public static class NSLinguisticAnalysis
{
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selEnumerateLinguisticTagsInRange_Scheme_Options_Orthography_UsingBlock_ = "enumerateLinguisticTagsInRange:scheme:options:orthography:usingBlock:";

	private static readonly IntPtr selEnumerateLinguisticTagsInRange_Scheme_Options_Orthography_UsingBlock_Handle = Selector.GetHandle("enumerateLinguisticTagsInRange:scheme:options:orthography:usingBlock:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private const string selLinguisticTagsInRange_Scheme_Options_Orthography_TokenRanges_ = "linguisticTagsInRange:scheme:options:orthography:tokenRanges:";

	private static readonly IntPtr selLinguisticTagsInRange_Scheme_Options_Orthography_TokenRanges_Handle = Selector.GetHandle("linguisticTagsInRange:scheme:options:orthography:tokenRanges:");

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	private static readonly IntPtr class_ptr = Class.GetHandle("NSString");

	[Export("enumerateLinguisticTagsInRange:scheme:options:orthography:usingBlock:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public unsafe static void EnumerateLinguisticTags(this NSString This, NSRange range, NSString scheme, NSLinguisticTaggerOptions options, NSOrthography? orthography, [BlockProxy(typeof(Trampolines.NIDNSEnumerateLinguisticTagsEnumerator))] NSEnumerateLinguisticTagsEnumerator handler)
	{
		if (scheme == null)
		{
			throw new ArgumentNullException("scheme");
		}
		if (handler == null)
		{
			throw new ArgumentNullException("handler");
		}
		BlockLiteral blockLiteral = default(BlockLiteral);
		BlockLiteral* ptr = &blockLiteral;
		blockLiteral.SetupBlockUnsafe(Trampolines.SDNSEnumerateLinguisticTagsEnumerator.Handler, handler);
		Messaging.void_objc_msgSend_NSRange_IntPtr_UInt64_IntPtr_IntPtr(This.Handle, selEnumerateLinguisticTagsInRange_Scheme_Options_Orthography_UsingBlock_Handle, range, scheme.Handle, (ulong)options, orthography?.Handle ?? IntPtr.Zero, (IntPtr)ptr);
		ptr->CleanupBlock();
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static void EnumerateLinguisticTags(this NSString This, NSRange range, NSLinguisticTagScheme scheme, NSLinguisticTaggerOptions options, NSOrthography? orthography, [BlockProxy(typeof(Trampolines.NIDNSEnumerateLinguisticTagsEnumerator))] NSEnumerateLinguisticTagsEnumerator handler)
	{
		This.EnumerateLinguisticTags(range, scheme.GetConstant(), options, orthography, handler);
	}

	[Export("linguisticTagsInRange:scheme:options:orthography:tokenRanges:")]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	[return: BindAs(typeof(NSLinguisticTagUnit[]), OriginalType = typeof(NSString[]))]
	public static NSLinguisticTagUnit[] GetLinguisticTags(this NSString This, NSRange range, NSString scheme, NSLinguisticTaggerOptions options, NSOrthography? orthography, out NSValue[]? tokenRanges)
	{
		if (scheme == null)
		{
			throw new ArgumentNullException("scheme");
		}
		IntPtr arg = IntPtr.Zero;
		IntPtr handle;
		NSLinguisticTagUnit[] result = (((handle = Messaging.IntPtr_objc_msgSend_NSRange_IntPtr_UInt64_IntPtr_ref_IntPtr(This.Handle, selLinguisticTagsInRange_Scheme_Options_Orthography_TokenRanges_Handle, range, scheme.Handle, (ulong)options, orthography?.Handle ?? IntPtr.Zero, ref arg)) == IntPtr.Zero) ? null : NSArray.ArrayFromHandleFunc(handle, delegate(IntPtr ptr)
		{
			using NSString constant = Runtime.GetNSObject<NSString>(ptr);
			return NSLinguisticTagUnitExtensions.GetValue(constant);
		}));
		tokenRanges = NSArray.ArrayFromHandle<NSValue>(arg);
		return result;
	}

	[BindingImpl(BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	public static NSLinguisticTagUnit[] GetLinguisticTags(this NSString This, NSRange range, NSLinguisticTagScheme scheme, NSLinguisticTaggerOptions options, NSOrthography? orthography, out NSValue[]? tokenRanges)
	{
		return This.GetLinguisticTags(range, scheme.GetConstant(), options, orthography, out tokenRanges);
	}
}
